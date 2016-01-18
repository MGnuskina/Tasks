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
    public partial class Elipse : Shape
    {
        public Elipse(int X, int Y, int height, int width, int lineWidth, Color color)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.Width = width;
            this.Height = height;
            this.BackColor = color;
            this.DrawPen = new Pen(color,lineWidth);
            this.ResizeRedraw = true;
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
            base.OnPaint(pe);
            Graphics graphics = pe.Graphics;
            graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, this.Width, this.Height);
            graphics.DrawEllipse(this.DrawPen, 0, 0, this.Width - 1, this.Height - 1);
        }
    }
}
