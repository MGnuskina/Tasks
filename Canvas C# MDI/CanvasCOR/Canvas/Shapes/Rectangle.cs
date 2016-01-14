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
    public partial class Rectangle : Shape
    {
        public Rectangle(int X, int Y, int height, int width, int lineWidth, Color color)
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
            graphics.DrawRectangle(this.DrawPen, 0, 0, this.Width, this.Height);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Graphics graphics = this.CreateGraphics();
            graphics.DrawRectangle(new Pen(this.DrawPen.Color, 4), 1, 1, this.Width - 2, this.Height - 2);
        }
    }
}
