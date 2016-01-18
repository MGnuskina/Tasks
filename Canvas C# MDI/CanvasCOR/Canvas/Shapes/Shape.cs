using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas
{
    public partial class Shape : Control
    {
        public int X { get; set; }
        private int dx, dy;
        public int Y { get; set; }
        public Pen DrawPen { get; set; }
        private bool alowToMove { get; set; }
        private Point pClicked { get; set; }

        public void ResizeShape(int xNew, int yNew)
        {
            int width = xNew - X;
            int height = yNew - Y;
            if (xNew < X)
            {
                this.Location = new Point(xNew, this.Location.Y);
            }
            if (yNew < Y)
            {
                this.Location = new Point(this.Location.X, yNew);
            }
            this.Size = new Size(Math.Abs(width), Math.Abs(height));

            this.Invalidate();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Invalidate();
        }

        private Color GetSelectionColor()
        {
            Color c = this.DrawPen.Color;
            if (c.B > 50)
            {
                c = Color.FromArgb(c.R, c.G, c.B - 50);
            }
            else
            {
                c = Color.FromArgb(c.R, c.G, c.B + 50);
            }
            if (c.R > 110)
            {
                c = Color.FromArgb(c.R - 110, c.G, c.B);
            }
            else
            {
                c = Color.FromArgb(c.R + 110, c.G, c.B);
            }
            return c;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            alowToMove = true;
            dx = 0;
            dy = 0;
            pClicked = new Point(e.X, e.Y);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            alowToMove = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (alowToMove)
            {
                dx = (pClicked.X - this.Location.X);
                dy = (pClicked.Y - this.Location.Y);
                this.Location = new Point(Math.Abs(e.X - dx), Math.Abs(e.Y - dy));
                this.Invalidate();
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Focus();
                pClicked = new Point(e.X, e.Y);
            }
        }
    }
}
