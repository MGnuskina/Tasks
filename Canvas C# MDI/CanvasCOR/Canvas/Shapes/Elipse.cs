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
    public partial class Elipse : Shape //Control
    {
        public Elipse(int X, int Y, int height, int width, int lineWidth, Color color)
        {
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.BackColor = Color.White;
            this.Width = width;
            this.Height = height;
            this.DrawPen = new Pen(color,lineWidth);//local veriable

            System.Drawing.Drawing2D.GraphicsPath Button_Path = new System.Drawing.Drawing2D.GraphicsPath();
            Button_Path.AddEllipse(0, 0, this.Width, this.Height);
            Region Button_Region = new Region(Button_Path);
            this.Region = Button_Region;

            Graphics g = this.CreateGraphics();
            OnPaint(new PaintEventArgs(g, new System.Drawing.Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height)));
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics graphics = pe.Graphics;
            graphics.FillEllipse(new SolidBrush(this.DrawPen.Color), 0,0, this.Width, this.Height);
        }
    }
}
