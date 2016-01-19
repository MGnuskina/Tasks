using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas
{
    public partial class RectangleRound : Shape
    {
        public RectangleRound(int X, int Y, int height, int width, int lineWidth, Color color)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.Width = width;
            this.Height = height;
            this.BackColor = color;
            this.DrawPen = new Pen(color, lineWidth);
            this.X = X;
            this.Y = Y;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics graphics = pe.Graphics;
            int widthNew = (int)(Width * 0.6);
            int heightNew = (int)(Height * 0.6);
            int xNew = (int)(Width * 0.2);
            int xNewRec = xNew - (int)(xNew / 2.0);
            int yNew = (int)(Height * 0.2);
            int yNewREc = yNew - (int)(yNew / 2.0);
            graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, this.Width, this.Height);
            graphics.DrawLine(this.DrawPen, xNewRec, 0, xNew + xNewRec + widthNew, 0);
            graphics.DrawLine(this.DrawPen, xNewRec, Height, xNew + xNewRec + widthNew, Height);
            graphics.DrawLine(this.DrawPen, 0, yNewREc, 0, yNew + yNewREc + heightNew);
            graphics.DrawLine(this.DrawPen, Width, yNewREc, Width, yNew + yNewREc + heightNew);
            graphics.DrawArc(this.DrawPen, new System.Drawing.Rectangle(0, 0, xNew + 1, yNew + 1), 180, 90);
            graphics.DrawArc(this.DrawPen, new System.Drawing.Rectangle(2 * xNewRec + widthNew, 0, xNew + 1, yNew + 1), 270, 90);
            graphics.DrawArc(this.DrawPen, new System.Drawing.Rectangle(0, 2 * yNewREc + heightNew, xNew + 1, yNew + 1), 90, 90);
            graphics.DrawArc(this.DrawPen, new System.Drawing.Rectangle(2 * xNewRec + widthNew, 2 * yNewREc + heightNew, xNew + 1, yNew + 1), 0, 90);
        }
    }
}
