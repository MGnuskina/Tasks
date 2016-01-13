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
    public partial class Shape : Control  ///do we need it?
    {
        public Pen DrawPen{ get; set; }

        public void ResizeShape(int xNew, int yNew)
        {
            int width = xNew;
            int height = yNew;
            if (xNew<this.Location.X)
            {
                width = this.Location.X;
                this.Location = new Point(xNew, this.Location.Y);
            }
            if (yNew < this.Location.Y)
            {
                height = this.Location.Y;
                this.Location = new Point(this.Location.X, yNew);
            }
            this.Size = new Size(Math.Abs(width - this.Location.X), Math.Abs(height - this.Location.Y));
            this.Invalidate();
        }
    }
}
