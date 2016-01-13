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
    public partial class RoundElipse : Shape
    {
        public RoundElipse(int X, int Y, int height, int width, int lineWidth, Color color)
        {
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.BackColor = color;
            this.Width = width;
            this.Height = height;
            this.DrawPen = new Pen(this.BackColor, lineWidth);//local veriable

            System.Drawing.Drawing2D.GraphicsPath Button_Path = new System.Drawing.Drawing2D.GraphicsPath();

            Button_Path.AddRectangle(new System.Drawing.Rectangle(0, 0, this.Width, this.Height));
            Region Button_Region = new Region(Button_Path);
            this.Region = Button_Region;

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
