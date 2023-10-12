using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMAS.Contoller
{
    public class UPanel : Panel
    {
        public class sPanel : Panel
        {
            private System.ComponentModel.IContainer components = null;

            #region Procedures et Fonctions Statiques
            // ==============================================================================
            public static GraphicsPath GetCapsule(RectangleF baseRect)
            {
                float diameter;
                RectangleF arc;
                GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                try
                {
                    if (baseRect.Width > baseRect.Height)
                    {
                        // return horizontal capsule 
                        diameter = baseRect.Height;
                        SizeF sizeF = new SizeF(diameter, diameter);
                        arc = new RectangleF(baseRect.Location, sizeF);
                        path.AddArc(arc, 90, 180);
                        arc.X = baseRect.Right - diameter;
                        path.AddArc(arc, 270, 180);
                    }
                    else if (baseRect.Width < baseRect.Height)
                    {
                        // return vertical capsule 
                        diameter = baseRect.Width;
                        SizeF sizeF = new SizeF(diameter, diameter);
                        arc = new RectangleF(baseRect.Location, sizeF);
                        path.AddArc(arc, 180, 180);
                        arc.Y = baseRect.Bottom - diameter;
                        path.AddArc(arc, 0, 180);
                    }
                    else
                    {
                        // return circle 
                        path.AddEllipse(baseRect);
                    }
                }
                catch (Exception ex)
                {
                    path.AddEllipse(baseRect);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    path.CloseFigure();
                }
                return path;
            }
            // ==============================================================================
            public static GraphicsPath GetRoundedRect(RectangleF baseRect, float radius)
            {
                // if corner radius is less than or equal to zero, 
                // return the original rectangle 
                if (radius <= 0.0F)
                {
                    GraphicsPath mPath = new GraphicsPath();
                    mPath.AddRectangle(baseRect);
                    mPath.CloseFigure();
                    return mPath;
                }

                // if the corner radius is greater than or equal to 
                // half the width, or height (whichever is shorter) 
                // then return a capsule instead of a lozenge 
                if (radius >= (Math.Min(baseRect.Width, baseRect.Height)) / 2.0)
                    return GetCapsule(baseRect);

                // create the arc for the rectangle sides and declare 
                // a graphics path object for the drawing 
                float diameter = radius * 2.0F;
                SizeF sizeF = new SizeF(diameter, diameter);
                RectangleF arc = new RectangleF(baseRect.Location, sizeF);
                GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

                // top left arc 
                path.AddArc(arc, 180, 90);

                // top right arc 
                arc.X = baseRect.Right - diameter;
                path.AddArc(arc, 270, 90);

                // bottom right arc 
                arc.Y = baseRect.Bottom - diameter;
                path.AddArc(arc, 0, 90);

                // bottom left arc
                arc.X = baseRect.Left;
                path.AddArc(arc, 90, 90);

                path.CloseFigure();
                return path;
            }
            // ==============================================================================
            /// <summary>
            /// 
            /// </summary>
            /// <param name="pCoef">Percentage (100 =no change)</param>
            /// <param name="pColor"></param>
            /// <returns></returns>
            public static Color ChangeLight(float pCoef, Color pColor)
            {
                pCoef = pCoef / 100;
                double dR = (double)pColor.R;
                double dG = (double)pColor.G;
                double dB = (double)pColor.B;
                dR = dR * pCoef;
                dG = dG * pCoef;
                dB = dB * pCoef;

                if (dG > 255) dG = 255;
                if (dR > 255) dR = 255;
                if (dB > 255) dB = 255;
                return Color.FromArgb((int)dR, (int)dG, (int)dB);
            }

            #endregion

            #region Variables ===============================================================
            // ==============================================================================
            // Grahpic variables
            // ==============================================================================    
            private GraphicsPath _RRBackground = GetRoundedRect(new Rectangle(0, 0, 49, 49), 1);
            private Color _BackColor = Color.FromArgb(239, 243, 255);
            private Color _SecondBackColor = Color.FromArgb(239, 243, 255);
            private Color _BorderColor = Color.FromArgb(183, 202, 234);
            private Border3DStyle _BorderStyle = Border3DStyle.Flat;
            private PenType __BrushType = PenType.SolidColor;
            private HatchStyle _HatchStyle = HatchStyle.BackwardDiagonal;
            private Brush _BorderBrush = new SolidBrush(Color.FromArgb(239, 243, 255));
            private Brush _BackroundBrush = new SolidBrush(Color.FromArgb(219, 253, 255));
            private Brush _BackroundImageBrush = new SolidBrush(Color.FromArgb(219, 253, 255));
            private int _Angle = 0;
            private int _BorderWidth = 1;

            private WrapMode _TextureMode = WrapMode.Tile;
            private Image _Image = null;
            private Image _BgImage = null;
            private Rectangle _DisplayRectangle = new Rectangle(0, 0, 49, 49);
            private ImageLayout _ImageLayout = ImageLayout.None;
            private Blend _Blend = new Blend(4);

            private float _Rayon = 4.0F;
            #endregion
            #region Methodes ================================================================
            // ==============================================================================
            // == METHODES
            // Constructor ==================================================================    
            public sPanel()
            {
                InitializeComponent();
                base.DoubleBuffered = true;

            }
            // Constructor (IContainer container)============================================    
            public sPanel(IContainer container)
            {
                container.Add(this);
                InitializeComponent();
                base.DoubleBuffered = true;
            }
            // Destructor ===================================================================
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            // ==============================================================================
            private void InitializeComponent()
            {
                this.SuspendLayout();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sPanel));
                this.ResumeLayout(false);
                base.BorderStyle = System.Windows.Forms.BorderStyle.None;
                base.BackColor = Color.Transparent;

                this._Blend = new Blend(4);
                this._Blend.Factors = new float[] { 1.0F, 0.99F, 0.01F, 0.0F };
                this._Blend.Positions = new float[] { 0.0F, 0.49F, 0.51F, 1.0F };
                this._SetBox();

            }
            // ==============================================================================    
            #endregion
            #region Properties ==============================================================
            // ==============================================================================
            //   PROPERTIES
            // ==============================================================================

            [Browsable(false)]
            protected override bool DoubleBuffered
            {
                get { return base.DoubleBuffered; }
                set { }
            }
            [Browsable(true)]
            public int LinearGradientAngle
            {
                get { return _Angle; }
                set
                {
                    _Angle = value;
                    _SetBrush();
                    Refresh();
                }
            }

            [Browsable(true)]
            public int BorderWidth
            {
                get { return _BorderWidth; }
                set
                {

                    _BorderWidth = value;
                    if (_BorderWidth < 1)
                        _BorderWidth = 1;
                    if (_BorderWidth > 10)
                        _BorderWidth = 10;

                    _SetBrush();
                    Refresh();
                }
            }
            [Browsable(true)]
            public Color BorderColor
            {
                get { return _BorderColor; }
                set
                {
                    _BorderColor = value;
                    _SetBrush();
                    Refresh();
                }
            }
            [Browsable(true)]
            public Color SecondBackColor
            {
                get { return _SecondBackColor; }
                set
                {
                    _SecondBackColor = value;
                    _SetBrush();
                    Refresh();
                }
            }


            [Browsable(true)]
            public PenType BrushType
            {
                get { return __BrushType; }
                set
                {
                    if (value == PenType.TextureFill) return;
                    __BrushType = value;
                    _SetBrush();
                    Refresh();
                }
            }
            [Browsable(true)]
            public HatchStyle HatchStyle
            {
                get { return _HatchStyle; }
                set
                {

                    _HatchStyle = value;
                    _SetBrush();
                    Refresh();
                }
            }
            // ==============================================================================
            public new Color BackColor
            {
                get { return _BackColor; }
                set
                {
                    _BackColor = value;
                    _SetBrush();
                    Refresh();
                }
            }

            // ==============================================================================
            [Browsable(true)]
            public float Rayon
            {
                get { return _Rayon; }
                set
                {
                    _Rayon = value;
                    this._SetBox();
                    _SetBrush();
                    Refresh();
                }
            }
            [Browsable(true)]
            public Image Image
            {
                get
                {
                    return _Image;
                }
                set
                {
                    _Image = value;
                    _SetBackGrounBrush();
                    _SetBrush();
                    Refresh();
                }
            }
            [Browsable(true)]
            public WrapMode TextureMode
            {
                get
                {
                    return _TextureMode;
                }
                set
                {
                    _TextureMode = value;
                    _SetBackGrounBrush();
                    _SetBrush();
                    Refresh();
                }
            }

            [Browsable(true)]
            public ImageLayout ImageLayout
            {
                get
                {
                    return _ImageLayout;
                }
                set
                {
                    _ImageLayout = value;
                    _SetBackGrounBrush();
                    _SetBrush();
                    Refresh();

                }
            }
            [Browsable(false)]
            public override ImageLayout BackgroundImageLayout
            {
                get
                {
                    return base.BackgroundImageLayout;
                }
                set
                {
                }
            }
            [Browsable(false)]
            public override Image BackgroundImage
            {
                get
                { return base.BackgroundImage; }
                set
                {
                    Image = value;
                }
            }

            [Browsable(true)]
            public new Border3DStyle BorderStyle
            {
                get
                { return _BorderStyle; }
                set
                {
                    _BorderStyle = value;
                    _SetBackGrounBrush();
                    _SetBrush();
                    Refresh();

                }
            }

            // ==============================================================================

            private void _SetBox()
            {
                _RRBackground = GetRoundedRect(new Rectangle(0, 0, this.Width - 1, this.Height - 1), _Rayon);
                int lRayon = (int)_Rayon;
                _DisplayRectangle = new Rectangle(lRayon, lRayon, this.Width - 2 * lRayon, this.Height - 2 * lRayon);

            }

            private Brush _GetBackGroundBrush()
            {
                Brush lReturn = new SolidBrush(_BackColor);
                switch (__BrushType)
                {
                    case PenType.PathGradient:
                        PathGradientBrush lPathGradientBrush = new PathGradientBrush(_RRBackground); ;
                        Color[] lColors = new Color[_RRBackground.PathPoints.Length];
                        for (int iIndex = 0; iIndex < _RRBackground.PathPoints.Length; iIndex++)
                        {
                            lColors[iIndex] = _BackColor;
                        }
                        lPathGradientBrush.CenterColor = _SecondBackColor;
                        lPathGradientBrush.SurroundColors = lColors;
                        lReturn = lPathGradientBrush;
                        break;
                    case PenType.LinearGradient:
                        lReturn = new LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), _BackColor, _SecondBackColor, _Angle);
                        break;
                    case PenType.HatchFill:
                        lReturn = new HatchBrush(_HatchStyle, _SecondBackColor, _BackColor);
                        break;
                }
                return lReturn;
            }

            private Brush _GetImageBackGroundBrush()
            {
                Brush lReturn = _GetBackGroundBrush();
                if (_Image != null)
                {
                    Bitmap lBgImage = new Bitmap(Width, Height);
                    Graphics lGraph = Graphics.FromImage(lBgImage);
                    Rectangle lRectSource = new Rectangle(0, 0, _Image.Width, _Image.Height);
                    if (_BackColor != Color.Transparent)
                        lGraph.FillRectangle(lReturn, 0, 0, Width, Height);
                    switch (_ImageLayout)
                    {
                        case ImageLayout.None:
                            lGraph.DrawImage(_Image, _Rayon, _Rayon, (float)(Width - 2 * _Rayon), (float)(Height - 2 * _Rayon));
                            break;
                        case ImageLayout.Stretch:
                            lGraph.DrawImage(_Image, new Rectangle(0, 0, Width, Height));
                            break;
                        case ImageLayout.Center:
                            //Rectangle lRectDest=  new Rectangle (, , _Image.Width,_Image.Height);
                            lGraph.DrawImage(_Image, (lBgImage.Width - _Image.Width) / 2, (lBgImage.Height - _Image.Height) / 2);

                            break;
                        case ImageLayout.Tile:
                            lBgImage.Dispose();
                            lBgImage = null;
                            GC.Collect();
                            lBgImage = new Bitmap(_Image);
                            break;
                        case ImageLayout.Zoom:
                            float lHeightCoef = (float)Height / _Image.Height;
                            float lWidthCoef = (float)Width / _Image.Width;
                            int lWidth = 0;
                            int lHeight = 0;
                            int lX = 0;
                            int lY = 0;
                            if ((_Image.Width * lHeightCoef) > Width)
                            {
                                lWidth = (int)Width;
                                lHeight = (int)(_Image.Height * lWidthCoef);
                                lX = 0;
                                lY = (int)(Height - lHeight) / 2;
                            }
                            else
                            {
                                lHeight = (int)Height;
                                lWidth = (int)(_Image.Width * lHeightCoef);
                                lX = (int)(Width - lWidth) / 2;
                                lY = 0;
                            }
                            lGraph.DrawImage(_Image, new Rectangle(lX, lY, lWidth, lHeight));
                            break;
                    }
                    lReturn.Dispose();
                    lReturn = new TextureBrush(lBgImage, _TextureMode);
                }
                return lReturn;
            }

            private void _SetBrush()
            {
                try
                {
                    _BackroundBrush = _GetBackGroundBrush();
                    _BackroundImageBrush = _GetImageBackGroundBrush();

                    Color lDarkColor = ChangeLight(80, _BorderColor);
                    Color lLightColor = ChangeLight(170, _BorderColor);
                    float hyp = (float)Math.Sqrt(Height * Height + Width * Width);
                    float lAngle = (float)(Math.Acos(Height / hyp) * 180 / Math.PI);

                    switch (_BorderStyle)
                    {
                        case Border3DStyle.Flat:
                            _BorderBrush = new SolidBrush(Color.Transparent);
                            break;

                        default:
                            _BorderBrush = new SolidBrush(_BorderColor);
                            break;
                        case Border3DStyle.Raised:
                        case Border3DStyle.RaisedInner:
                        case Border3DStyle.RaisedOuter:
                            _BorderBrush = new LinearGradientBrush(new Rectangle(0, 0, Width, Height)
                                                    , lDarkColor, lLightColor, lAngle);
                            ((LinearGradientBrush)_BorderBrush).Blend = _Blend;
                            break;
                        case Border3DStyle.Sunken:
                        case Border3DStyle.SunkenInner:
                        case Border3DStyle.SunkenOuter:
                            _BorderBrush = new LinearGradientBrush(new Rectangle(0, 0, Width, Height)
                                                    , lLightColor, lDarkColor, lAngle);
                            ((LinearGradientBrush)_BorderBrush).Blend = _Blend;
                            break;
                    }

                }
                catch { }
            }
            private void _SetBackGrounBrush()
            {

                this._SetBox();
                Graphics lGraph;
                _SetBrush();
            }
            protected void PanelPaint(Graphics pGraph)
            {

                if (Color.Transparent != _BackColor)
                    pGraph.FillPath(new SolidBrush(_BackColor), _RRBackground);
                //Appliquer la texture de Fond
                pGraph.FillPath(_BackroundBrush, _RRBackground);
                //Appliquer l'image
                if (_Image != null)
                    pGraph.FillPath(_BackroundImageBrush, _RRBackground);
                //Redessiner le Bord
                pGraph.DrawPath(new Pen(_BorderBrush, _BorderWidth), _RRBackground);

            }
            #endregion
            protected override void OnResize(EventArgs eventargs)
            {
                try
                {
                    base.OnResize(eventargs);
                    this._SetBox();
                    _SetBackGrounBrush();
                    _SetBrush();
                }
                catch { }
            }
            // Paint Background event =======================================================
            protected override void OnPaintBackground(PaintEventArgs pevent)
            {
                base.OnPaintBackground(pevent);
                try
                {
                    PanelPaint(pevent.Graphics);
                }
                catch { }
            }
            // Overirde of DisplayRectangle==================================================        
            public override Rectangle DisplayRectangle
            {
                get
                {
                    return _DisplayRectangle;

                }
            }

        }
    }
}
