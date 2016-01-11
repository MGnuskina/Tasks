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
        BallsOriginator originator;

        public BouncingBallForm()
        {
            InitializeComponent();
            originator = new BallsOriginator();
        }

        private void BouncingBallForm_MouseDown(object sender, MouseEventArgs e)
        {
            Random rannd = new Random();
            int dx = rannd.Next(-25, 25);
            int dy = rannd.Next(-25, 25);
            BBControl ball =new BBControl(e.X,e.Y,dx,dy);
           
            panel.Controls.Add(ball);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save";
            saveFileDialog1.Filter = "XML file|*.xml|JSON file|*.json|CSV file|*.csv|YAML file|*.yaml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SetOriginator();
                string path = saveFileDialog1.FileName;
                IWorkWithFiles saveFile = FileRep.findExtention(path);
                saveFile.Save(originator.CreateMemento().GetMemento(), path);
            }
            saveFileDialog1.Dispose();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            openFileDialog1.Title = "Open";
            openFileDialog1.Filter = "XML file|*.xml|JSON file|*.json|CSV file|*.csv|YAML file|*.yaml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                IWorkWithFiles openFile = FileRep.findExtention(path);
                originator.SetMemento(new BallsMemento(openFile.Load(path)));
                SetControls();
            }
            openFileDialog1.Dispose();
        }

        private void SetOriginator()
        {
            originator.balls = new List<BBControl>();
            foreach (BBControl ball in panel.Controls)
            {
                originator.balls.Add(ball);
            }
        }

        private void SetControls()
        {
            while (panel.Controls.Count > 0)
            {
                panel.Controls[0].Dispose();
            }
            foreach (BBControl ball in originator.balls)
            {
                panel.Controls.Add(ball);
                ball.Start();
            }
        }
    }
}
