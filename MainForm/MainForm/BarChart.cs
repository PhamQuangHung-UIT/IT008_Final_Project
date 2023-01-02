using System.CodeDom;
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
        private readonly List<ChartItem<T>> chartItems;
        private bool isValueLabelShow;
        private string? title;
        private bool autoCalculateVerticalValueList;
        private readonly List<T> verticalValueList;

        public BarChart()
        {
            InitializeComponent();
            BackColor = Color.White;
            chartItems = new List<ChartItem<T>>();
            verticalValueList = new List<T>();
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
                float horizontalAxisLength = DisplayRectangle.Width * 0.8f;
                float horizontalPerItemWidth = (horizontalAxisLength - 30 - horizontalTextSize.Width) / chartItems.Count;
                float maxTextWidth = graphics.MeasureString(chartItems.MaxBy(item => item?.Name?.Length)?.Name, Font).Width;
                float verticalAxisLength = verticalAxisLength = DisplayRectangle.Height * 0.8f;
                if (horizontalPerItemWidth < maxTextWidth)
                    verticalAxisLength -= maxTextWidth;
                PointF chartPosition = new(verticalTextSize.Width * 1.1f, DisplayRectangle.Height * 0.1f);
                Pen axisPen = new(axisColor, 5)
                {
                    EndCap = LineCap.ArrowAnchor
                };

                // Draw horizontal axis
                graphics.Transform = new(1, 0, 0, -1, chartPosition.X, verticalAxisLength + chartPosition.Y);
                graphics.DrawLine(axisPen, 0, 0, horizontalAxisLength, 0);
                for (int i = 0; i < chartItems.Count; i++)
                {
                    graphics.DrawLine(new(axisColor, 3),
                        horizontalPerItemWidth * (i + 1), -5,
                        horizontalPerItemWidth * (i + 1), 5);
                    if (horizontalPerItemWidth < maxTextWidth)
                    {
                        graphics.Transform = new(0, -1, 1, 0, chartPosition.X, verticalAxisLength + chartPosition.Y);
                        graphics.DrawString(
                            chartItems[i].Name,
                            Font,
                            new SolidBrush(ForeColor),
                            -graphics.MeasureString(chartItems[i].Name, Font).Width - 8,
                            horizontalPerItemWidth * (i + 0.5f) - graphics.MeasureString(chartItems[i].Name, Font).Height / 2
                            );
                        graphics.Transform = new(1, 0, 0, -1, chartPosition.X, verticalAxisLength + chartPosition.Y);
                    }
                    else
                    {
                        graphics.Transform = new(1, 0, 0, 1, chartPosition.X, verticalAxisLength + chartPosition.Y);
                        graphics.DrawString(
                        chartItems[i].Name,
                        Font,
                        new SolidBrush(ForeColor),
                        (horizontalPerItemWidth * (i + 0.5f)) - graphics.MeasureString(chartItems[i].Name, Font).Width / 2,
                        8);
                    }
                }

                // Draw vertical axis
                graphics.Transform = new(1, 0, 0, -1, chartPosition.X, verticalAxisLength + chartPosition.Y);
                graphics.DrawLine(axisPen, 0, 0, 0, verticalAxisLength);
                foreach (var value in VerticalValueList)
                {
                    graphics.DrawLine(new Pen(axisColor, 3), -5, ValueToHeight(value), 5, ValueToHeight(value));
                    var transform = graphics.Transform;
                    var measureStringWidth = graphics.MeasureString(value.ToString(), Font).Width;
                    graphics.Transform = new Matrix(1, 0, 0, 1, chartPosition.X, verticalAxisLength + chartPosition.Y);
                    if (typeof(T) == typeof(Enum))
                        graphics.DrawString(
                            Enum.GetName(typeof(T), value),
                            Font,
                            new SolidBrush(ForeColor),
                            new PointF(-measureStringWidth - 8, -ValueToHeight(value) - 12));
                    else graphics.DrawString(
                            value.ToString(),
                            Font,
                            new SolidBrush(ForeColor),
                            new PointF(-measureStringWidth - 8, -ValueToHeight(value) - 12));
                    graphics.Transform = transform;
                }

                // Draw text displayed on horizontal axis, vertical axis and draw the title of the bar chart
                graphics.Transform = new Matrix(1, 0, 0, 1, chartPosition.X, verticalAxisLength + chartPosition.Y);
                graphics.DrawString(
                    verticalText,
                    Font,
                    new SolidBrush(ForeColor),
                    -verticalTextSize.Width - 8,
                    -verticalAxisLength + 10);
                graphics.DrawString(
                    horizontalText,
                    Font,
                    new SolidBrush(ForeColor),
                    horizontalAxisLength - horizontalTextSize.Width - 15,
                    8);
                graphics.DrawString(
                    title,
                    Font,
                    new SolidBrush(ForeColor),
                    (horizontalAxisLength - graphics.MeasureString(title, Font).Width) / 2,
                    verticalAxisLength - 10);
                if (isValueLabelShow)
                    for (int i = 0; i < chartItems.Count; i++)
                        graphics.DrawString(
                            chartItems[i].Value.ToString(),
                            Font,
                            new SolidBrush(ForeColor),
                            horizontalPerItemWidth * (i + 0.5f) - graphics.MeasureString(chartItems[i].Value.ToString(), Font).Width / 2,
                            -ValueToHeight(chartItems[i].Value) - graphics.MeasureString(chartItems[i].Value.ToString(), Font).Height - 5);
                // Draw column bar
                graphics.Transform = new(1, 0, 0, -1, chartPosition.X, verticalAxisLength + chartPosition.Y);
                for (int i = 0; i < chartItems.Count; i++)
                {
                    float barWidth = horizontalPerItemWidth * 0.7f;
                    float barHeight = ValueToHeight(chartItems[i].Value);
                    graphics.DrawRectangle(new(barBorderColor, 2), horizontalPerItemWidth * (i + 0.15f), 0, barWidth, barHeight);
                    graphics.FillRectangle(new SolidBrush(barColor), horizontalPerItemWidth * (i + 0.15f), 0, barWidth, barHeight);
                }
                //Local function
                float ValueToHeight(T? value)
                    => (Convert.ToSingle(value) / Convert.ToSingle(VerticalValueList.Max()) * (verticalAxisLength - verticalTextSize.Height - 50));
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
                    for (double i = 0; i <= maxValue; i += unit)
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
                axisColor = value;
                Refresh();
            }
        }

        /// <summary>
        /// The color used for paint the border of the bars
        /// </summary>
        public Color BarBorderColor
        {
            get => barBorderColor;
            set
            {
                barBorderColor = value;
                Refresh();
            }
        }

        /// <summary>
        /// The color used for fill the bars of the chart
        /// </summary>
        public Color BarColor
        {
            get => barColor;
            set
            {
                barColor = value;
                Refresh();
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
                horizontalText = value;
                Refresh();
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
                verticalText = value;
                Refresh();
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
                    val += Convert.ToDouble(chartItems[i]);
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
                isValueLabelShow = value;
                Refresh();
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
                title = value;
                Refresh();
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
                autoCalculateVerticalValueList = value;
                Refresh();
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
