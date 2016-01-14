using Canvas.Serelization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas
{
    public partial class CanvasForm : Form
    {
        private bool allowToDraw = false;
        Shape shape;
        int shapeIndex;

        public CanvasForm()
        {
            InitializeComponent();
            panelCanvas1.Focus();
        }

        private void CanvasForm_MouseDown(object sender, MouseEventArgs e)
        {
            allowToDraw = true;
            panelCanvas1.Focus();
            shape = ShapeFactory.GetShapeInstance(cbType.SelectedItem.ToString(), e.X, e.Y,
                1,1, Convert.ToInt16(width.SelectedItem), colorPanel.BackColor);
            //shape.GotFocus
            panelCanvas1.AutoSize = false;
            panelCanvas1.Controls.Add(shape);
            shapeIndex = panelCanvas1.Controls.Count - 1;
        }

        private void CanvasForm_MouseUp(object sender, MouseEventArgs e)
        {
            allowToDraw = false;
            panelCanvas1.Controls[0].BringToFront();
            foreach(Shape shape in panelCanvas1.Controls)
            {
                //shape.MouseDown += CanvasForm_MouseDown;
                //shape.MouseUp += CanvasForm_MouseUp;
            }
            
        }

        private void CanvasForm_Load(object sender, EventArgs e)
        {
            width.SelectedIndex = 0;
            colorPanel.BackColor = Color.Black;
            cbType.SelectedIndex = 0;
            tscbWidth.SelectedIndex = 0;
            tbcbWidth.SelectedIndex = 0;
            //tbcbWidth.VisibleChanged += Width_SelectedIndexChanged;
            //tscbWidth.VisibleChanged += Width_SelectedIndexChanged;
            //width.VisibleChanged += Width_SelectedIndexChanged;
        }

        private void colorPanel_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = colorDialog.Color;
            }
        }

        private void CanvasForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (allowToDraw)
            {
                if (panelCanvas1.Controls[shapeIndex] is Shape)
                {
                    Shape s = (panelCanvas1.Controls[shapeIndex] as Shape);
                    s.ResizeShape(e.X, e.Y);
                }
            }
        }

        private void Width_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbWidth.SelectedIndex != tbcbWidth.SelectedIndex && tscbWidth.SelectedIndex != width.SelectedIndex)
            {
                tbcbWidth.SelectedIndex = tscbWidth.SelectedIndex;
                width.SelectedIndex = tscbWidth.SelectedIndex;
            }
            else
            {
                if (tscbWidth.SelectedIndex != tbcbWidth.SelectedIndex && tbcbWidth.SelectedIndex != width.SelectedIndex)
                {
                    tscbWidth.SelectedIndex = tbcbWidth.SelectedIndex;
                    width.SelectedIndex = tbcbWidth.SelectedIndex;
                }
                else
                {
                    if (tscbWidth.SelectedIndex != width.SelectedIndex && tbcbWidth.SelectedIndex != width.SelectedIndex)
                    {
                        tscbWidth.SelectedIndex = width.SelectedIndex;
                        tbcbWidth.SelectedIndex = width.SelectedIndex;
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save";
            saveFileDialog1.Filter = "XML file|*.xml|JSON file|*.json|CSV file|*.csv|YAML file|*.yaml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ShapeOriginator originator = new ShapeOriginator();
                SetOriginator(originator);
                string path = saveFileDialog1.FileName;
                IWorkWithFiles saveFile = LSFactory.findExtention(path);
                saveFile.Save(originator.CreateMemento().GetMemento(), path);
            }
            saveFileDialog1.Dispose();
        }

        private void SetOriginator(ShapeOriginator originator)
        {
            originator.shapes = new List<Shape>();
            foreach (Shape shape in panelCanvas1.Controls)
            {
                originator.shapes.Add(shape);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open";
            openFileDialog1.Filter = "XML file|*.xml|JSON file|*.json|CSV file|*.csv|YAML file|*.yaml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ShapeOriginator originator = new ShapeOriginator();
                string path = openFileDialog1.FileName;
                IWorkWithFiles openFile = LSFactory.findExtention(path);
                originator.SetMemento(new ShapeMemento(openFile.Load(path)));
                SetControls(originator);
            }
            openFileDialog1.Dispose();
        }

        private void SetControls(ShapeOriginator originator)
        {
            while (panelCanvas1.Controls.Count > 0)
            {
                panelCanvas1.Controls[0].Dispose();
            }
            foreach (Shape shape in originator.shapes)
            {
                panelCanvas1.Controls.Add(shape);
            }
        }
    }
}
