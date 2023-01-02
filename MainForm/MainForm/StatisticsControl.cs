using System.Data;

namespace MainForm
{
    /// <summary>
    /// UserControl trong phần Thống Kê của menu Quản trị viên (đang làm dở)
    /// </summary>
    public partial class StatisticsControl : UserControl
    {
        private DateTime startDate, endDate;
        private DataTable? currentTable;
        private readonly BarChart<double> barChart;
        private enum TableType
        {
            Hóa_Đơn,
            Dịch_Vụ,
            Khách_Hàng,
            Nhân_Viên,
            Bàn
        }
        private const int dayIndex = 0, monthIndex = 1;
        public StatisticsControl()
        {
            InitializeComponent();
            barChart = new()
            {
                VerticalText = "Doanh thu",
                Location = default,
                Dock = DockStyle.Fill,
                DoubleBuffered = true,
                AutoCalculateVerticalValueList = true
            };
        }

        private void StatisticsControl_Load(object sender, EventArgs e)
        {
            comboBox_TimeSpan.SelectedIndex = 0;
            comboBox_TableType.SelectedIndex = 0;
            ComboBox_TableType_SelectionChangeCommitted(sender, e);
            startDate = endDate = DateTime.Now.Date;

            while (startDate.DayOfWeek != DayOfWeek.Sunday || DateTime.Now.Date - startDate.Date == TimeSpan.Zero) 
                startDate -= TimeSpan.FromDays(1);

            while (endDate.DayOfWeek != DayOfWeek.Saturday || endDate.Date - DateTime.Now.Date == TimeSpan.Zero)
                endDate += TimeSpan.FromDays(1);

            dateTimePicker_StartDate.Value = startDate;
            dateTimePicker_EndDate.Value = endDate;
            
            ButtonShow_Click(sender, e);
            panel_Chart.Controls.Add(barChart);
            barChart.Size = new(barChart.Size.Width, panel_Chart.Height + 100);
        }

        private void CheckBox_ValueLabel_CheckedChanged(object sender, EventArgs e)
        {
            barChart.IsValueLabelShowed = checkBox_ValueLabel.Checked;
        }

        private void ComboBox_TableType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch ((TableType)comboBox_TableType.SelectedIndex)
            {
                case TableType.Hóa_Đơn:
                    label_ID.Text = "Mã hóa đơn";
                    currentTable = FMain.GetSqlData("SELECT * FROM HOADON");
                    break;
                case TableType.Dịch_Vụ:
                    label_ID.Text = "Mã dịch vụ";
                    currentTable = FMain.GetSqlData("SELECT * FROM DICHVU");
                    break;
                case TableType.Nhân_Viên:
                    label_ID.Text = "Mã nhân viên";
                    currentTable = FMain.GetSqlData("SELECT * FROM NHANVIEN");
                    break;
                case TableType.Khách_Hàng:
                    label_ID.Text = "Mã khách hàng";
                    currentTable = FMain.GetSqlData("SELECT * FROM KHACHHANG");
                    break;
                default:
                    label_ID.Text = "Mã bàn";
                    currentTable = FMain.GetSqlData("SELECT * FROM BAN");
                    break;
            }
            comboBox_ID.Items.Clear();
            comboBox_Name.Items.Clear();
            comboBox_ID.Items.AddRange(currentTable.Rows.Cast<DataRow>().Select(row => row[0]).ToArray());
            if (new[] { "Bàn", "Hóa đơn" }.Any(s => s == comboBox_TableType.SelectedItem.ToString()))
                comboBox_Name.Items.AddRange((from row in currentTable.Rows.Cast<DataRow>() select $"{comboBox_TableType.SelectedItem} {row[0]}").ToArray());
            else comboBox_Name.Items.AddRange((from row in currentTable.Rows.Cast<DataRow>() select row[1]).ToArray());
            comboBox_ID.SelectedIndex = -1;
            comboBox_Name.SelectedIndex = -1;
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePicker_StartDate.Value.Date;
            var endDate = dateTimePicker_EndDate.Value.Date;
            try
            {
                switch (comboBox_TimeSpan.SelectedIndex)
                {
                    case dayIndex:
                        if (startDate >= endDate)
                            throw new Exception("Thời điểm kết thúc phải lớn hơn thời điểm bắt đầu. Vui lòng thử lại");
                        if (endDate - startDate > TimeSpan.FromDays(30))
                            throw new Exception("Biểu đồ chỉ hiển thị tối đa 30 ngày. Vui lòng thử lại");
                        barChart.ChartItems.Clear();
                        for (var i = startDate; i != endDate + TimeSpan.FromDays(1); i += TimeSpan.FromDays(1))
                        {
                            string queryString = $"SELECT SUM(THANHTIEN) FROM {GetTableName()} " +
                                $"WHERE CONVERT(VARCHAR, GIOLAPHD, 103) = '{i:dd/MM/yyyy}' {GetCondition()}" +
                                $"GROUP BY CAST(GIOLAPHD AS DATE)";
                            var table = FMain.GetSqlData(queryString);
                            double value = Convert.ToDouble(table.Rows.Count == 0 ? 0 : table.Rows[0][0]);
                            barChart.ChartItems.Add(new ChartItem<double>($"{i:dd/MM/yyyy}\n{i:dddd}", value));
                        }
                        break;
                    case monthIndex:
                        var numOfMonths = (endDate.Year - startDate.Year) * 12 + endDate.Month - startDate.Month;
                        if (numOfMonths <= 0)
                            throw new Exception("Thời điểm kết thúc phải lớn hơn thời điểm bắt đầu");
                        if (numOfMonths > 24)
                            throw new Exception("Biểu đồ chỉ hiển thị tối đa 24 tháng. Vui lòng thử lại");
                        barChart.ChartItems.Clear();
                        for (DateTime i = new(startDate.Year, startDate.Month, 1); i <= endDate; i = i.AddMonths(1))
                        {
                            string queryString = $"SELECT SUM(THANHTIEN) FROM HOADON WHERE YEAR(GIOLAPHD) = {i.Year} and MONTH(GIOLAPHD) = {i.Month} " +
                                                $"GROUP BY YEAR(GIOLAPHD), MONTH(GIOLAPHD)";
                            var table = FMain.GetSqlData(queryString);
                            double value = (double)(table.Rows.Count == 0 ? 0 : table.Rows[0][0])/1000000;
                            barChart.ChartItems.Add(new ChartItem<double>($"{i:'Tháng' MM/yyyy}", value));
                        }
                        break;
                }
                barChart.IsValueLabelShowed = checkBox_ValueLabel.Checked;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Lỗi hiển thị", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ComboBox_TimeSpan_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_TimeSpan.SelectedIndex) 
            {
                case dayIndex:
                    dateTimePicker_StartDate.CustomFormat = dateTimePicker_EndDate.CustomFormat = "dd/MM/yyyy"; 
                    break;
                case monthIndex:
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

        private string GetTableName()
        {
            return (TableType)comboBox_TableType.SelectedIndex switch
            {
                TableType.Hóa_Đơn => "HOADON",
                TableType.Dịch_Vụ => "HOADON h JOIN (" +
                                        "SELECT IDHD, h.IDDV, THANHTIEN = SOLUONG * GIATIEN" +
                                        "FROM HOADONDV h JOIN DICHVU d ON h.IDDV = d.IDDV" +
                                        ") as c ON h.IDHD = c.IDHD",
                TableType.Nhân_Viên => "HOADON h JOIN NHANVIEN n ON h.IDNV = n.IDNV",
                TableType.Khách_Hàng => "HOADON h JOIN KHACHHANG k ON h.IDKH = k.IDKH",
                TableType.Bàn => "HOADON h JOIN (" +
                                        "SELECT IDHD, h.IDBAN, " +
                                        "THANHTIEN = (DATEPART(HOUR, GIOKETTHUC - GIOBATDAU) + DATEPART(MINUTE, GIOKETTHUC - GIOBATDAU)/60.0) * GIATIEN" +
                                        "FROM HOADONBAN h JOIN BAN b ON h.IDBAN = b.IDBAN) AS c ON h.IDHD = c.IDHD",
                _ => throw new Exception("Vui lòng chọn \"Loại đối tượng\".")
            };
        }

        private string GetCondition()
        {
            if (comboBox_ID.SelectedIndex == -1) return "";
            return (TableType)comboBox_TableType.SelectedIndex switch
            {
                TableType.Hóa_Đơn => $"AND IDHD = {comboBox_ID.SelectedItem}",
                TableType.Dịch_Vụ => $"AND IDDV = {comboBox_ID.SelectedItem}",
                TableType.Nhân_Viên => $"AND IDNV = {comboBox_ID.SelectedItem}",
                TableType.Khách_Hàng => $"AND IDKH = {comboBox_ID.SelectedItem}",
                TableType.Bàn => $"AND IDBAN = {comboBox_ID.SelectedItem}",
                _ => throw new Exception("Vui lòng chọn \"Loại đối tượng\".")
            };
        }

    }
}
