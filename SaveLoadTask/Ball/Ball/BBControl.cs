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

namespace Ball
{
    public partial class BBControl : Control
    {
        public int dx { get; set; }
        public int dy { get; set; }

        private Thread thread;

        public BBControl(int X, int Y, int dx, int dy)
        {
            InitializeComponent();
            this.Location = new Point(X, Y);
            Random rannd = new Random();
            this.dx = dx;
            this.dy = dy;
            while (dy == 0)
            {
                this.dy = rannd.Next(-50, 50);
            }
            while (dx == 0)
            {
                this.dx = rannd.Next(-50, 50);
            }
            Color color = Color.FromArgb(rannd.Next(255), rannd.Next(255), rannd.Next(255));
            while (color == Color.White)
            {
                color = Color.FromArgb(rannd.Next(255), rannd.Next(255), rannd.Next(255));
            }
            this.BackColor = color;
            this.Width = 2 * rannd.Next(2, 25);
            this.Height = this.Width;

            System.Drawing.Drawing2D.GraphicsPath Button_Path = new System.Drawing.Drawing2D.GraphicsPath();

            Button_Path.AddEllipse(0, 0, this.Width, this.Height);

            Region Button_Region = new Region(Button_Path);

            this.Region = Button_Region;

            thread = new Thread(DoWork);
            thread.Start();
        }

        public BBControl(int X, int Y, int dx, int dy, int width, int height)
        {
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.dx = dx;
            this.dy = dy;
            this.BackColor = Color.Black;
            this.Width = width;
            this.Height = height;

            System.Drawing.Drawing2D.GraphicsPath Button_Path = new System.Drawing.Drawing2D.GraphicsPath();

            Button_Path.AddEllipse(0, 0, this.Width, this.Height);

            Region Button_Region = new Region(Button_Path);

            this.Region = Button_Region;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics graphics = pe.Graphics;
            graphics.DrawEllipse(new Pen(this.BackColor), this.Location.X, this.Location.Y, this.Width, this.Height);
        }

        public new void Move()
        {
            int tmpX = Location.X;
            int tmpY = Location.Y;
            if (tmpX < 0 || tmpX + Size.Width > Parent.Size.Width)
            {
                dx = -dx;
                tmpX = Location.X < 0 ? 0 : Parent.Size.Width - Size.Width;
            }
            tmpY = tmpY + dy;
            if (tmpY < 0 || tmpY + Size.Width + 25 > Parent.Size.Height)
            {
                dy = -dy;
                tmpY = tmpY < 0 ? 0 : Parent.Size.Height - Size.Width - 25;
            }
            tmpX = tmpX + dx;

            this.Location = new Point(tmpX, tmpY);
        }

        private void DoWork()
        {
            while (true)
            {
                Thread.Sleep(25);
                Invoke(new MethodInvoker(Move));
            }
        }

        public void Start()
        {
            if (thread == null)
            {
                thread = new Thread(DoWork);
                thread.Start();
            }
        }

        public void Stop()
        {
            thread.Abort();
            //thread.Join();
        }
    }
}
