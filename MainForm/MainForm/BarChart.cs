using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace MainForm
{
    /// <summary>
    /// Represents a bar chart's control for statistics
    /// </summary>
    /// <typeparam name="T">The type of value to be represented in bar chart</typeparam>
    public partial class BarChart<T> : Control where T: struct
    {
        private Color barColor = Color.DarkSlateBlue;
        private Color barBorderColor = Color.Black;
        private Color axisColor = Color.DarkGray;
        private string horizontalText = "";
        private string verticalText = "";
        private string? title;
        private bool isValueLabelShow;
        private bool autoCalculateVerticalValueList;
        private double zoomRatio = 1;
        private readonly Size defaultControlSize;
        private readonly List<T> verticalValueList;
        private readonly List<ChartItem<T>> chartItems;

        public BarChart()
        {
            InitializeComponent();
            BackColor = Color.White;
            chartItems = new List<ChartItem<T>>();
            verticalValueList = new List<T>();
            defaultControlSize = Size;
        }

        public BarChart(IContainer container) : this()
        {
            container.Add(this);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            try
            {
                if (autoCalculateVerticalValueList)
                    CalculateTheVerticalValue();
                Graphics graphics = e.Graphics;
                SizeF horizontalTextSize = graphics.MeasureString(horizontalText, Font);
                SizeF verticalTextSize = graphics.MeasureString(verticalText, Font);
                float horizontalAxisLength = 840;
                float horizontalPerItemWidth = (horizontalAxisLength - 30 - horizontalTextSize.Width) / chartItems.Count;
                float maxTextWidth = graphics.MeasureString(chartItems.MaxBy(item => item?.Name?.Length)?.Name, Font).Width;
                float verticalAxisLength = 360;

                PointF chartPosition = new((verticalTextSize.Width + 10) * (float)zoomRatio, verticalAxisLength * 0.15f * (float)zoomRatio);
                Pen axisPen = new(axisColor, 5)
                {
                    EndCap = LineCap.ArrowAnchor
                };

                // Draw horizontal axis
                graphics.Transform = new(1, 0, 0, -1, chartPosition.X, chartPosition.Y);
                graphics.ScaleTransform((float)zoomRatio, (float)zoomRatio);
                graphics.DrawLine(axisPen, 0, -verticalAxisLength, horizontalAxisLength, -verticalAxisLength);
                for (int i = 0; i < chartItems.Count; i++)
                {
                    graphics.Transform = new(1, 0, 0, -1, chartPosition.X, chartPosition.Y);
                    graphics.ScaleTransform((float)zoomRatio, (float)zoomRatio);
                    graphics.DrawLine(new(axisColor, 3),
                        horizontalPerItemWidth * (i + 1), -5 - verticalAxisLength,
                        horizontalPerItemWidth * (i + 1), 5 - verticalAxisLength);
                    if (horizontalPerItemWidth < maxTextWidth)
                    {
                        graphics.Transform = new(0, -1, 1, 0, chartPosition.X, chartPosition.Y);
                        graphics.ScaleTransform((float)zoomRatio, (float)zoomRatio);
                        graphics.DrawString(
                            chartItems[i].Name,
                            Font,
                            new SolidBrush(ForeColor),
                            -graphics.MeasureString(chartItems[i].Name, Font).Width - 8 - verticalAxisLength,
                            horizontalPerItemWidth * (i + 0.5f) - graphics.MeasureString(chartItems[i].Name, Font).Height / 2
                            );
                    }
                    else
                    {
                        graphics.Transform = new(1, 0, 0, 1, chartPosition.X, chartPosition.Y);
                        graphics.ScaleTransform((float)zoomRatio, (float)zoomRatio);
                        graphics.DrawString(
                        chartItems[i].Name,
                        Font,
                        new SolidBrush(ForeColor),
                        (horizontalPerItemWidth * (i + 0.5f)) - graphics.MeasureString(chartItems[i].Name, Font).Width / 2,
                        8 + verticalAxisLength);
                    }
                }

                // Draw vertical axis
                graphics.Transform = new(1, 0, 0, -1, chartPosition.X, chartPosition.Y);
                graphics.ScaleTransform((float)zoomRatio, (float)zoomRatio);
                graphics.DrawLine(axisPen, 0, -verticalAxisLength, 0, 0);
                foreach (var value in VerticalValueList)
                {
                    graphics.DrawLine(new Pen(axisColor, 3), -5, ValueToHeight(value) - verticalAxisLength, 5, ValueToHeight(value) - verticalAxisLength);
                    var transform = graphics.Transform;
                    var measureStringWidth = graphics.MeasureString(value.ToString(), Font).Width;
                    graphics.Transform = new(1, 0, 0, 1, chartPosition.X, chartPosition.Y);
                    graphics.ScaleTransform((float)zoomRatio, (float)zoomRatio);
                    if (typeof(T) == typeof(Enum))
                        graphics.DrawString(
                            Enum.GetName(typeof(T), value),
                            Font,
                            new SolidBrush(ForeColor),
                            new PointF(-measureStringWidth - 8, -ValueToHeight(value) - 12 + verticalAxisLength));
                    else graphics.DrawString(
                            value.ToString(),
                            Font,
                            new SolidBrush(ForeColor),
                            new PointF(-measureStringWidth - 8, -ValueToHeight(value) - 12 + verticalAxisLength));
                    graphics.Transform = transform;
                }

                // Draw text displayed on horizontal axis, vertical axis and draw the title of the bar chart
                graphics.Transform = new(1, 0, 0, 1, chartPosition.X, chartPosition.Y);
                graphics.ScaleTransform((float)zoomRatio, (float)zoomRatio);
                graphics.DrawString(
                    verticalText,
                    Font,
                    new SolidBrush(ForeColor),
                    -verticalTextSize.Width - 8,
                    10);
                graphics.DrawString(
                    horizontalText,
                    Font,
                    new SolidBrush(ForeColor),
                    horizontalAxisLength - horizontalTextSize.Width - 15,
                    8 + verticalAxisLength);
                graphics.DrawString(
                    title,
                    Font,
                    new SolidBrush(ForeColor),
                    (horizontalAxisLength - graphics.MeasureString(title, Font).Width) / 2,
                    2 * verticalAxisLength - 10);
                if (isValueLabelShow)
                    for (int i = 0; i < chartItems.Count; i++)
                        graphics.DrawString(
                            chartItems[i].Value.ToString(),
                            Font,
                            new SolidBrush(ForeColor),
                            horizontalPerItemWidth * (i + 0.5f) - graphics.MeasureString(chartItems[i].Value.ToString(), Font).Width / 2,
                            -ValueToHeight(chartItems[i].Value) - graphics.MeasureString(chartItems[i].Value.ToString(), Font).Height - 5 + verticalAxisLength);
                // Draw columns
                for (int i = 0; i < chartItems.Count; i++)
                {
                    float barWidth = horizontalPerItemWidth * 0.7f;
                    float barHeight = ValueToHeight(chartItems[i].Value);
                    graphics.DrawRectangle(new(barBorderColor, 2), horizontalPerItemWidth * (i + 0.15f), verticalAxisLength - barHeight, barWidth, barHeight);
                    graphics.FillRectangle(new SolidBrush(barColor), horizontalPerItemWidth * (i + 0.15f), verticalAxisLength - barHeight, barWidth, barHeight);
                }
                //Local function
                float ValueToHeight(T? value)
                    => Convert.ToSingle(value) / Convert.ToSingle(VerticalValueList.Max()) * (verticalAxisLength - verticalTextSize.Height - 50);
            }
            catch (Exception) { }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Refresh();
        }

        private void CalculateTheVerticalValue()
        {
            if (ChartItems.Count == 0) return;
            verticalValueList.Clear();
            if (typeof(T) != typeof(Enum))
            {
                double unit = 1;
                double maxValue = Convert.ToDouble(MaxValue);
                while (maxValue > unit * 10)
                    unit *= 10;
                if (maxValue != 0)
                {
                    while (maxValue < unit * 2)
                        unit /= 5;
                    while (maxValue < unit * 5)
                        unit /= 2;
                    for (double i = 0; i <= maxValue + unit; i += unit)
                        verticalValueList.Add((T)(object)i);
                }
                else
                {
                    verticalValueList.Add(default);
                    verticalValueList.Add((T)(object)1.0); 
                }
            }
            else 
            {
                var arr = Enum.GetValues(typeof(T));
                foreach (T item in arr)
                    verticalValueList.Add(item);
            };
        }

        /// <summary>
        /// The color of the axis
        /// </summary>
        public Color AxisColor
        {
            get => axisColor;
            set
            {
                if (axisColor != value)
                {
                    axisColor = value;
                    Refresh();
                }
            }
        }

        /// <summary>
        /// The color of the border of the columns (bars)
        /// </summary>
        public Color BarBorderColor
        {
            get => barBorderColor;
            set
            {
                if (barBorderColor != value)
                {
                    barBorderColor = value;
                    Refresh();
                }
            }
        }

        /// <summary>
        /// The color of the column (bars)
        /// </summary>
        public Color BarColor
        {
            get => barColor;
            set
            {
                if (barColor != value)
                {
                    barColor = value;
                    Refresh();
                }
            }
        }

        /// <summary>
        /// Gets the current chart's items list
        /// </summary>
        public List<ChartItem<T>> ChartItems { get => chartItems; }

        /// <summary>
        /// The text show at the end of the horizontal axis
        /// </summary>
        public string HorizontalText
        {
            get => horizontalText;
            set
            {
                if (horizontalText != value)
                {
                    horizontalText = value;
                    Refresh();
                }
            }
        }

        /// <summary>
        /// The text show at the end of the vertical axis
        /// </summary>
        public string VerticalText
        {
            get => verticalText;
            set
            {
                if (verticalText != value)
                {
                    verticalText = value;
                    Refresh();
                }
            }
        }

        /// <summary>
        /// Gets the value indicating the maximum value of all items in the chart
        /// </summary>
        public T? MaxValue
        {
            get
            {
                return ChartItems.Max(x => x.Value);
            }
        }

        /// <summary>
        /// Gets the value indicating the minimum value of all items in the chart
        /// </summary>
        public T? MinValue
        {
            get
            {
                return ChartItems.Min(x => x.Value);
            }
        }

        /// <summary>
        /// Gets the value indicating the expectation of all values from <see cref="ChartItems"/>
        /// </summary>
        public double Expectation
        {
            get
            {
                double val = 0;
                for (int i = 0; i < chartItems.Count; i++)
                    val += Convert.ToDouble(chartItems[i].Value);
                return val / chartItems.Count;
            }
        }

        /// <summary>
        /// Gets the value indicating the median of all values from <see cref="ChartItems"/>
        /// </summary>
        public T? Median
        {
            get
            {
                var list = chartItems.OrderByDescending(x => x.Value).ToList();
                if (list.Count % 2 == 0)
                    return (T)(object)((Convert.ToDouble(list[list.Count / 2 - 1].Value) + Convert.ToDouble(list[list.Count / 2].Value)) / 2);
                return list[list.Count / 2].Value;
            }
        }

        /// <summary>
        /// Gets the current values list to be showed along the vertical axis
        /// </summary>
        public List<T> VerticalValueList { get => verticalValueList; }

        /// <summary>
        /// Gets or sets the value indicating whether the label indicates the value of the items
        /// can be showed on top of the bars
        /// </summary>
        public bool IsValueLabelShowed
        {
            get => isValueLabelShow;
            set
            {
                if (isValueLabelShow != value)
                {
                    isValueLabelShow = value;
                    Refresh();
                }
            }
        }

        /// <summary>
        /// Indicates the title to be appeared at top of the bar chart
        /// </summary>
        public string? Title
        {
            get => title;
            set
            {
                if (title != value)
                {
                    title = value;
                    Refresh();
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the control should use double buffered
        /// </summary>
        public new bool DoubleBuffered { get => base.DoubleBuffered; set => base.DoubleBuffered = value; }

        /// <summary>
        /// Gets or sets a value indicating whether the chart auto calculate
        /// values showed along the vertical axis
        /// </summary>
        public bool AutoCalculateVerticalValueList
        {
            get => autoCalculateVerticalValueList;
            set
            {
                if (autoCalculateVerticalValueList != value)
                {
                    autoCalculateVerticalValueList = value;
                    Refresh();
                }
            }
        }

        public double ZoomRatio 
        { 
            get => zoomRatio;
            set
            {
                if (zoomRatio != value)
                {
                    zoomRatio = value;
                    Refresh();
                }
            }
        }
    }

    /// <summary>
    /// Represent an object in the chart with a pair of name and value
    /// </summary>
    /// <typeparam name="T">The type of value to be represented in bar chart</typeparam>
    public class ChartItem<T>
    {

        /// <summary>
        /// Create a chart item with a specific name
        /// </summary>
        /// <param name="name">Name of the item</param>
        public ChartItem(string? name)
        {
            Name = name;
            Value = default;
        }

        /// <summary>
        /// Create a chart item with a name and value
        /// </summary>
        /// <param name="name">Name of the item</param>
        /// <param name="value">The value that the item holds</param>
        public ChartItem(string? name, T? value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// The name of the item in the chart
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The value that the item holds
        /// </summary>
        public T? Value { get; set; }
    }
}
