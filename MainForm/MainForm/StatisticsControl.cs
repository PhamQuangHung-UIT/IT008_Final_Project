using System.Data;
using System.Runtime.Intrinsics.X86;
#nullable disable

namespace MainForm
{
    /// <summary>
    /// UserControl trong phần Thống Kê của menu Quản trị viên
    /// </summary>
    public partial class StatisticsControl : UserControl
    {
        private DateTime startDate, endDate;
        private DataTable currentTable;
        private readonly BarChart<double> barChart;
        private enum TableType
        {
            Hóa_Đơn,
            Dịch_Vụ,
            Khách_Hàng,
            Nhân_Viên,
            Bàn,
        }
        private enum GroupBy { ID, Days, Months}
        private readonly float[] zoomRatioArr = { 0.25f, 0.5f, 0.75f, 1.0f, 1.5f, 2.0f };
        private int currentZoomRatioIndex = 3;
        private int maxPageNum = 0, currentPageNum = 1, beginIndex, endIndex;
        private Size defaultBarChartSize;
        public StatisticsControl()
        {
            InitializeComponent();
            barChart = new()
            {
                BarColor = Color.Cyan,
                VerticalText = "Doanh thu (VNĐ)",
                Location = default,
                Width = panel_Chart.Width,
                Height = panel_Chart.Height + 100,
                DoubleBuffered = true,
                AutoCalculateVerticalValueList = true
            };
        }

        private void StatisticsControl_Load(object sender, EventArgs e)
        {
            comboBox_GroupBy.SelectedIndex = 0;
            startDate = endDate = DateTime.Now.Date;

            while (startDate.DayOfWeek != DayOfWeek.Sunday || DateTime.Now.Date - startDate.Date == TimeSpan.Zero) 
                startDate -= TimeSpan.FromDays(1);

            while (endDate.DayOfWeek != DayOfWeek.Saturday || endDate.Date - DateTime.Now.Date == TimeSpan.Zero)
                endDate += TimeSpan.FromDays(1);

            dateTimePicker_StartDate.Value = startDate;
            dateTimePicker_EndDate.Value = endDate;
            
            panel_Chart.Controls.Add(barChart);
            defaultBarChartSize = barChart.Size;

            button_BarColor.BackColor = barChart.BarColor;
            button_BarBorderColor.BackColor = barChart.BarBorderColor;
            button_AxisColor.BackColor = barChart.AxisColor;
        }

        private void CheckBox_ValueLabel_CheckedChanged(object sender, EventArgs e)
        {
            barChart.IsValueLabelShowed = checkBox_ValueLabel.Checked;
        }

        private void ComboBox_TableType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable table;
            switch ((TableType)comboBox_TableType.SelectedIndex)
            {
                case TableType.Hóa_Đơn:
                    label_ID.Text = "Mã hóa đơn";
                    table = FMain.GetSqlData("SELECT * FROM HOADON");
                    break;
                case TableType.Dịch_Vụ:
                    label_ID.Text = "Mã dịch vụ";
                    table = FMain.GetSqlData("SELECT * FROM DICHVU");
                    break;
                case TableType.Nhân_Viên:
                    label_ID.Text = "Mã nhân viên";
                    table = FMain.GetSqlData("SELECT * FROM NHANVIEN");
                    break;
                case TableType.Khách_Hàng:
                    label_ID.Text = "Mã khách hàng";
                    table = FMain.GetSqlData("SELECT * FROM KHACHHANG");
                    break;
                default:
                    label_ID.Text = "Mã bàn";
                    table = FMain.GetSqlData("SELECT * FROM BAN");
                    break;
            }
            comboBox_ID.Items.Clear();
            comboBox_Name.Items.Clear();
            comboBox_ID.SelectedIndex = -1;
            comboBox_Name.SelectedIndex = -1;
            comboBox_ID.Text = "";
            comboBox_Name.Text = "";
            comboBox_ID.Items.AddRange(table.Rows.Cast<DataRow>().Select(row => row[0]).ToArray());
            if (new[] { "Bàn", "Hóa đơn" }.Any(s => s == comboBox_TableType.SelectedItem.ToString()))
                comboBox_Name.Items.AddRange((from row in table.Rows.Cast<DataRow>() select $"{comboBox_TableType.SelectedItem} {row[0]}").ToArray());
            else comboBox_Name.Items.AddRange((from row in table.Rows.Cast<DataRow>() select row[1]).ToArray());
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            startDate = dateTimePicker_StartDate.Value.Date;
            endDate = dateTimePicker_EndDate.Value.Date;
            try
            {
                if (comboBox_TableType.SelectedIndex == -1)
                    throw new("Vui lòng chọn mục \"Loại đối tượng\".");
                if (comboBox_GroupBy.SelectedIndex == -1)
                    throw new("Vui lòng chọn mục \"Hiển thị doanh thu từng cột theo\".");
                string tableString = $"SELECT {GetSelect()}, DOANHTHU = SUM(THANHTIEN) FROM {GetTableName()}" +
                                    $" {GetCondition()}" +
                                    $" GROUP BY {GetGroupBy()}";

                barChart.AutoCalculateVerticalValueList = true;
                string format;
                switch ((GroupBy)comboBox_GroupBy.SelectedIndex)
                {
                    case GroupBy.ID:
                        currentTable = FMain.GetSqlData(tableString);
                        if (startDate > endDate)
                            throw new Exception("Thời điểm kết thúc phải lớn hơn hoặc bằng thời điểm bắt đầu.");
                        maxPageNum = (int)Math.Ceiling(currentTable.Rows.Count / 15.0);
                        format = "{0}";
                        barChart.HorizontalText = (TableType)comboBox_TableType.SelectedIndex switch
                        {
                            TableType.Bàn => "Bàn",
                            TableType.Hóa_Đơn => "Hóa đơn",
                            TableType.Nhân_Viên => "Nhân viên",
                            TableType.Khách_Hàng => "Khách hàng",
                            _ => "Dịch vụ"
                        };
                        break;
                    case GroupBy.Days:
                        string queryString1 = $"SELECT Dates, DOANHTHU FROM (SELECT  TOP (DATEDIFF(DAY, '{startDate:yyy-M-d}', '{endDate:yyy-M-d}') + 1) " +
                            $"Dates = DATEADD(DAY, ROW_NUMBER() OVER(ORDER BY s.object_id) - 1, '{startDate:yyy-M-d}') " +
                            $"FROM sys.all_objects s) a LEFT JOIN ({tableString}) b ON Dates = NGHD";
                        currentTable = FMain.GetSqlData(queryString1);
                        if (startDate > endDate)
                            throw new Exception("Thời điểm kết thúc phải lớn hơn hoặc bằng thời điểm bắt đầu.");
                        maxPageNum = (int)Math.Ceiling(((endDate - startDate).Days + 1) / 15.0);
                        format = "{0:dd/MM/yyyy}";
                        barChart.HorizontalText = "";
                        break;
                    default:
                        string queryString2 = $"SELECT Dates, DOANHTHU FROM (SELECT  TOP (DATEDIFF(MONTH, '{startDate:yyy-M-d}', '{endDate:yyy-M-d}') + 1) " +
                            $"Dates = DATEADD(MONTH, ROW_NUMBER() OVER(ORDER BY s.object_id) - 1, '{startDate:yyy-M-d}') " +
                            $"FROM sys.all_objects s) a LEFT JOIN ({tableString}) b ON YEAR(Dates) = NAM AND MONTH(Dates) = THANG";
                        currentTable = FMain.GetSqlData(queryString2);
                        var numOfMonths = (endDate.Year - startDate.Year) * 12 + endDate.Month - startDate.Month + 1;
                        if (numOfMonths <= 0)
                            throw new Exception("Thời điểm kết thúc phải lớn hơn hoặc bằng thời điểm bắt đầu");
                        maxPageNum = (int)Math.Ceiling(numOfMonths / 15.0);
                        format = "{0:'Tháng' MM/yyyy}";
                        barChart.HorizontalText = "";
                        break;
                }

                if (maxPageNum > 0)
                    currentPageNum = 1;
                else currentPageNum = 0;
                label_Page.Text = $"Trang {currentPageNum}/{maxPageNum}";
                beginIndex = 0;
                endIndex = 15;

                barChart.IsValueLabelShowed = checkBox_ValueLabel.Checked;
                barChart.BarColor = button_BarColor.BackColor;
                barChart.BarBorderColor = button_BarBorderColor.BackColor;
                barChart.AxisColor = button_AxisColor.BackColor;
                if (currentTable.Rows.Count > 0)
                {
                    var rows = currentTable.Rows.Cast<DataRow>();
                    var total = rows.Sum(row => Convert.ToDecimal(Convert.IsDBNull(row[1]) ? null : row[1]));
                    var avg = rows.Average(row => Convert.ToDecimal(Convert.IsDBNull(row[1]) ? null : row[1]));
                    var max = rows.Max(row => Convert.ToDecimal(Convert.IsDBNull(row[1]) ? null : row[1]));
                    var min = rows.Min(row => Convert.ToDecimal(Convert.IsDBNull(row[1]) ? null : row[1]));
                    textBox_Total.Text = $"{total:C2}";
                    textBox_MaxValue.Text = $"{max:C2}";
                    textBox_MinValue.Text = $"{min:C2}";
                    textBox_AverageValue.Text = $"{avg:C2}";
                    barChart.ChartItems.Clear();
                    barChart.ChartItems.Add(new("", Convert.ToDouble(max)));
                    barChart.CalculateTheVerticalValue();
                    barChart.AutoCalculateVerticalValueList = false;
                    barChart.ChartItems.Clear();
                    for (int i = 0; i < currentTable.Rows.Count && i < 15; i++)
                    {
                        var value = Convert.ToDouble(Convert.IsDBNull(currentTable.Rows[i][1]) ? null : currentTable.Rows[i][1]);
                        barChart.ChartItems.Add(new(string.Format(format, currentTable.Rows[i][0]), value));
                    }
                }
                else
                {
                    textBox_Total.Text = $"{0:C2}";
                    textBox_MaxValue.Text = $"{0:C2}";
                    textBox_MinValue.Text = $"{0:C2}";
                    textBox_AverageValue.Text = $"{0:C2}";
                }
                splitContainer_Top.Panel2Collapsed = false;
                splitContainer_Main.SplitterDistance = splitContainer_Top.Bounds.Height;

                barChart.Refresh();
                if (currentTable.Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy giá trị thỏa mãn","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;
        }

        private void ComboBox_GroupBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_ID.Enabled = comboBox_Name.Enabled = (GroupBy)comboBox_GroupBy.SelectedIndex != GroupBy.ID;
            switch ((GroupBy)comboBox_GroupBy.SelectedIndex)
            {
                case GroupBy.ID:
                    comboBox_ID.SelectedIndex = comboBox_Name.SelectedIndex = -1;
                    comboBox_ID.Text = comboBox_Name.Text = "";
                    dateTimePicker_StartDate.CustomFormat = dateTimePicker_EndDate.CustomFormat = "dd/MM/yyyy";
                    break;
                case GroupBy.Days:
                    dateTimePicker_StartDate.CustomFormat = dateTimePicker_EndDate.CustomFormat = "dd/MM/yyyy"; 
                    break;
                case GroupBy.Months:
                    dateTimePicker_StartDate.CustomFormat = dateTimePicker_EndDate.CustomFormat = "'Tháng' MM/yyyy";
                    break;
            }
        }

        private void ComboBox_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_ID.SelectedIndex = comboBox_Name.SelectedIndex;
        }

        private void ComboBox_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Name.SelectedIndex = comboBox_ID.SelectedIndex;
        }

        private void Button_ZoomIn_Click(object sender, EventArgs e)
        {
            currentZoomRatioIndex++;
            if (currentZoomRatioIndex == zoomRatioArr.Length - 1)
                button_ZoomIn.Enabled = false;

            barChart.ZoomRatio = zoomRatioArr[currentZoomRatioIndex];
            barChart.Width = (int)(defaultBarChartSize.Width * zoomRatioArr[currentZoomRatioIndex]);
            barChart.Height = (int)(defaultBarChartSize.Height * zoomRatioArr[currentZoomRatioIndex]);
            button_ZoomOut.Enabled = true;
        }

        private void Button_ZoomOut_Click(object sender, EventArgs e)
        {
            currentZoomRatioIndex--;
            if (currentZoomRatioIndex == 0)
                button_ZoomOut.Enabled = false;

            barChart.ZoomRatio = zoomRatioArr[currentZoomRatioIndex];
            barChart.Width = (int)(defaultBarChartSize.Width * zoomRatioArr[currentZoomRatioIndex]);
            barChart.Height = (int)(defaultBarChartSize.Height * zoomRatioArr[currentZoomRatioIndex]);
            button_ZoomIn.Enabled = true;
        }

        private void Button_PageDecrease_Click(object sender, EventArgs e)
        {
            currentPageNum--;
            label_Page.Text = $"Trang {currentPageNum}/{maxPageNum}";
            beginIndex -= 15;
            if (beginIndex < 0) beginIndex = 0;
            endIndex = beginIndex + 15;
            barChart.ChartItems.Clear();
            switch ((GroupBy)comboBox_GroupBy.SelectedIndex)
            {
                case GroupBy.Months:
                    for (int i = beginIndex; i < endIndex; i++)
                    {
                        var value = Convert.ToDouble(Convert.IsDBNull(currentTable.Rows[i][1]) ? null : currentTable.Rows[i][1]);
                        barChart.ChartItems.Add(new($"{currentTable.Rows[i][0]:'Tháng' MM/yyyy}", value));
                    }
                    break;
                default:
                    for (int i = beginIndex; i < endIndex; i++)
                    {
                        var value = Convert.ToDouble(Convert.IsDBNull(currentTable.Rows[i][1]) ? null : currentTable.Rows[i][1]);
                        barChart.ChartItems.Add(new($"{currentTable.Rows[i][0]:dd/MM/yyyy}", value));
                    }
                    break;

            }
            barChart.Refresh();
        }

        private void Button_PageIncrease_Click(object sender, EventArgs e)
        {
            currentPageNum++;
            label_Page.Text = $"Trang {currentPageNum}/{maxPageNum}";
            endIndex += 15;
            if (endIndex > currentTable.Rows.Count) endIndex = currentTable.Rows.Count;
            beginIndex = endIndex - 15;
            barChart.ChartItems.Clear();
            switch ((GroupBy)comboBox_GroupBy.SelectedIndex)
            {
                case GroupBy.Months:
                    for (int i = beginIndex; i < endIndex; i++)
                    {
                        var value = Convert.ToDouble(Convert.IsDBNull(currentTable.Rows[i][1]) ? null : currentTable.Rows[i][1]);
                        barChart.ChartItems.Add(new($"{currentTable.Rows[i][0]:'Tháng' MM/yyyy}", value));
                    }
                    break;
                default:
                    for (int i = beginIndex; i < endIndex; i++)
                    {
                        var value = Convert.ToDouble(Convert.IsDBNull(currentTable.Rows[i][1]) ? null : currentTable.Rows[i][1]);
                        barChart.ChartItems.Add(new($"{currentTable.Rows[i][0]:dd/MM/yyyy}", value));
                    }
                    break;

            }
            barChart.Refresh();
        }

        private void Label_Page_TextChanged(object sender, EventArgs e)
        {
            button_PageDecrease.Enabled = currentPageNum > 1;
            button_PageIncrease.Enabled = currentPageNum != maxPageNum;
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                ColorDialog dlg = new()
                {
                    Color = btn.BackColor,
                };
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    btn.BackColor = dlg.Color;
                }
            }
        }

        private string GetTableName()
        {
            return (TableType)comboBox_TableType.SelectedIndex switch
            {
                TableType.Hóa_Đơn => "HOADON",
                TableType.Dịch_Vụ => "(SELECT IDHD, GIOLAPHD FROM HOADON) AS h JOIN (" +
                                    "SELECT IDHD, h.IDDV, TENDV, THANHTIEN = SOLUONG * GIATIEN " +
                                    "FROM HOADONDV h JOIN DICHVU d ON h.IDDV = d.IDDV" +
                                    ") AS c ON h.IDHD = c.IDHD",
                TableType.Nhân_Viên => "HOADON h JOIN NHANVIEN n ON h.IDNV = n.IDNV",
                TableType.Khách_Hàng => "HOADON h JOIN KHACHHANG k ON h.IDKH = k.IDKH",
                _                   => "HOADON h JOIN (" +
                                        "SELECT IDHD, h.IDBAN, " +
                                        "THANHTIEN = (DATEPART(HOUR, GIOKETTHUC - GIOBATDAU) + DATEPART(MINUTE, GIOKETTHUC - GIOBATDAU)/60.0) * GIATIEN " +
                                        "FROM HOADONBAN h JOIN BAN b ON h.IDBAN = b.IDBAN) AS c ON h.IDHD = c.IDHD",
            };
        }

        private string GetCondition()
        {
            string idString;
            if (comboBox_ID.SelectedIndex == -1)
                idString = "WHERE ";
            else idString = (TableType)comboBox_TableType.SelectedIndex switch
            {
                TableType.Hóa_Đơn => $"WHERE IDHD = {comboBox_ID.SelectedItem} AND",
                TableType.Dịch_Vụ => $"WHERE IDDV = {comboBox_ID.SelectedItem} AND",
                TableType.Nhân_Viên => $"WHERE h.IDNV = {comboBox_ID.SelectedItem} AND",
                TableType.Khách_Hàng => $"WHERE h.IDKH = {comboBox_ID.SelectedItem} AND",
                _ => $"WHERE IDBAN = {comboBox_ID.SelectedItem} AND",
            };
            return (GroupBy)comboBox_GroupBy.SelectedIndex switch
            {
                GroupBy.ID => $"WHERE CAST(GIOLAPHD AS DATE) BETWEEN '{startDate:yyy-M-d}' AND '{endDate:yyy-M-d}'",
                GroupBy.Days => $"{idString} CAST(GIOLAPHD AS DATE) BETWEEN '{startDate:yyy-M-d}' AND '{endDate:yyy-M-d}'",
                _ => $"{idString} ({endDate:yyy} - YEAR(GIOLAPHD)) * 12 + {endDate:MM} - MONTH(GIOLAPHD) " +
                        $"BETWEEN 0 AND ({endDate:yyy} - {startDate:yyy}) * 12 + {endDate:MM} - {startDate:MM}",
            };
        }

        private string GetGroupBy()
        {
            return (GroupBy)comboBox_GroupBy.SelectedIndex switch
            {
                GroupBy.ID => (TableType)comboBox_TableType.SelectedIndex switch
                {
                    TableType.Bàn => "IDBAN",
                    TableType.Nhân_Viên => "h.IDNV, HOTENNV",
                    TableType.Khách_Hàng => "h.IDKH, HOTEN",
                    TableType.Dịch_Vụ => "IDDV, TENDV",
                    _ => "IDHD",
                },
                GroupBy.Days => "CAST(GIOLAPHD AS DATE)",
                _ => "YEAR(GIOLAPHD), MONTH(GIOLAPHD)"
            };
        }

        private string GetSelect()
        {
            return (GroupBy)comboBox_GroupBy.SelectedIndex switch
            {
                GroupBy.ID => (TableType)comboBox_TableType.SelectedIndex switch
                {
                    TableType.Bàn => "NAME = N'Bàn ' + CAST(IDBAN AS VARCHAR)",
                    TableType.Nhân_Viên => "NAME = HOTENNV + ' (' + CAST(h.IDNV AS VARCHAR) + ')'",
                    TableType.Khách_Hàng => "NAME = HOTEN + ' (' + CAST(h.IDKH AS VARCHAR) + ')'",
                    TableType.Dịch_Vụ => "NAME = TENDV + ' (' + CAST(IDDV AS VARCHAR) + ')'",
                    _ => "NAME = N'Hóa đơn ' + CAST(IDHD AS VARCHAR)",
                },
                GroupBy.Days => "NGHD = CAST(GIOLAPHD AS DATE)",
                _ => "NAM = YEAR(GIOLAPHD), THANG = MONTH(GIOLAPHD)"
            };
        }
    }
}