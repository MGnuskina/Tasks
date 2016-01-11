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
    public partial class BouncingBallForm : Form
    {
        Thread thread;
        public BouncingBallForm()
        {
            InitializeComponent();
        }

        private void BouncingBallForm_MouseDown(object sender, MouseEventArgs e)
        {
            Random rannd = new Random();
            int dx = rannd.Next(-25, 25);
            int dy = rannd.Next(-25, 25);
            BBControl ball =new BBControl(e.X,e.Y,dx,dy);
            Controls.Add(ball);
        }
    }
}
