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
        public int X { get; set; }
        public int Y { get; set; }
        public Pen DrawPen { get; set; }

        public void ResizeShape(int xNew, int yNew)
        {
            int width = xNew - X;
            int height = yNew - Y;
            if (xNew < X )
            {
                this.Location = new Point(xNew, this.Location.Y);
            }
            if (yNew < Y)
            {
                this.Location = new Point(this.Location.X, yNew);
            }

            //this.ClientSize = new Size(Math.Abs(width),Math.Abs(height));
            this.Size= new Size(Math.Abs(width), Math.Abs(height));

            this.Invalidate();
        }
    }
}
