using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shape
{
    [ToolboxItem(true)]
    [DesignerCategory("code")]
    public partial class ArrowPentagon : Control
    {
        private Color m_ArrowColor = Color.SteelBlue;
        private Color m_BorderColor = Color.Orange;
        private float m_BorderSize = 1.5f;
        private bool m_BorderVisible = true;
        public ArrowPentagon()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.ResizeRedraw, true);
            MinimumSize = new Size(40, 20);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = new Region(GetRegionPath());
        }

        private GraphicsPath GetRegionPath()
        {
            // The arrow shape begins at 3/4 or the current width of the container
            float arrowSection = ClientSize.Width * .75f;
            PointF[] arrowPoints = new PointF[] {
            new PointF (0, 0),
            new PointF (arrowSection, 0),
            new PointF(ClientSize.Width, ClientSize.Height / 2.0f),
            new PointF (arrowSection, ClientSize.Height),
            new PointF (0, ClientSize.Height),
            new PointF (0, 0)
        };
            var path = new GraphicsPath();
            path.AddLines(arrowPoints);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float border = m_BorderVisible ? m_BorderSize : .5f;

            using (var path = GetRegionPath())
            {
                var rect = path.GetBounds();
                float scaleX = 1.0f - ((border * 2.5f) / rect.Width);
                float scaleY = 1.0f - ((border * 2.0f) / rect.Height);


                using (var mx = new Matrix(scaleX, 0, 0, scaleY, border, border))
                using (var brush = new SolidBrush(m_ArrowColor))
                {
                    path.Transform(mx);
                    e.Graphics.FillPath(brush, path);
                    if (m_BorderVisible)
                    {
                        using (Pen pen = new Pen(m_BorderColor, m_BorderSize))
                        {
                            e.Graphics.DrawPath(pen, path);
                        }
                    }
                }
            }
            base.OnPaint(e);
        }


        [DefaultValue(typeof(Color), "SteelBlue")]
        [Description("Color of the shape")]
        public Color ArrowColor
        {
            get => m_ArrowColor;
            set
            {
                if (m_ArrowColor != value)
                {
                    m_ArrowColor = value;
                    Invalidate();
                }
            }
        }

        [DefaultValue(true)]
        [Description("Show or hide the Border")]
        public bool BorderVisible
        {
            get => m_BorderVisible;
            set
            {
                m_BorderVisible = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "Orange")]
        [Description("Color of the Border")]
        public Color BorderColor
        {
            get => m_BorderColor;
            set
            {
                if (m_BorderColor != value)
                {
                    m_BorderColor = value;
                    Invalidate();
                }
            }
        }

        [DefaultValue(1.5f)]
        [Description("Size of the Border [1.0, 6.0]")]
        public float BorderSize
        {
            get => m_BorderSize;
            set
            {
                if (m_BorderSize != value)
                {
                    m_BorderSize = Math.Max(Math.Min(value, 6.0f), 1.0f);
                    Invalidate();
                }
            }
        }

        // [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        // public BorderStyle BorderStyle { get; set; }  // Implement if needed
    }
}

