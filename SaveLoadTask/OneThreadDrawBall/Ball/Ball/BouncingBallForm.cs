using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball
{
    public partial class BouncingBallForm : Form
    {
        public BouncingBallForm()
        {
            InitializeComponent();
            timer1.Interval = 1000/30;
            g = CreateGraphics();
        }

        List<BouncingBallClass> bouncingBalls = new List<BouncingBallClass>();
        Graphics g;

        private void BouncingBallForm_MouseClick(object sender, MouseEventArgs e)
        {
            bouncingBalls.Add(new BouncingBallClass(e.X, e.Y));
            bouncingBalls[bouncingBalls.Count-1].DrawBall(g, this.ClientSize.Width, this.ClientSize.Height);
            timer1.Enabled = true;
        }

        private void MovingBall()
        {
            g.Clear(this.BackColor);
            for (int i = 0; i < bouncingBalls.Count; i++)
            {
                bouncingBalls[i].DrawBall(g, this.Width, this.Height);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MovingBall();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save";
            saveFileDialog1.Filter = "XML file|*.xml|JSON file|*.json|CSV file|*.csv|YAML file|*.yaml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                IWorkWithFiles saveFile= FileRep.findExtention(path);
                saveFile.Save(bouncingBalls, path);
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
                bouncingBalls = openFile.Load(path);
            }
            openFileDialog1.Dispose();
        }
    }
}
