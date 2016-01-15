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
        Shape tmpShape;
        int shapeIndex;
        bool Change = true;

        public CanvasForm()
        {
            InitializeComponent();
        }

        private void CanvasForm_MouseDown(object sender, MouseEventArgs e)
        {
            allowToDraw = true;
            //currentPanel.Focus();
            tmpShape = ShapeFactory.GetShapeInstance(cbType.SelectedItem.ToString(), e.X, e.Y,
                1, 1, Convert.ToInt16(width.SelectedItem), colorPanel.BackColor);
            //currentPanel.AutoSize = false;
            tabControlCanvas.SelectedTab.Controls[0].Controls.Add(tmpShape);
            shapeIndex = tabControlCanvas.SelectedTab.Controls[0].Controls.Count - 1;
        }

        private void CanvasForm_MouseUp(object sender, MouseEventArgs e)
        {
            allowToDraw = false;
            tabControlCanvas.SelectedTab.Controls[0].Controls[0].BringToFront();
            tabControlCanvas.SelectedTab.Controls[0].Controls[tabControlCanvas.SelectedTab.Controls[0].Controls.Count - 1].LostFocus += ShapeLoseFocus;
            tabControlCanvas.SelectedTab.Controls[0].Controls[tabControlCanvas.SelectedTab.Controls[0].Controls.Count - 1].GotFocus += ShapeGetFocus;
            tabControlCanvas.SelectedTab.Controls[0].Controls[tabControlCanvas.SelectedTab.Controls[0].Controls.Count - 1].MouseClick += ContexMenuShowOnRightMouseClick;
            tmpShape = null;
        }

        private void CanvasForm_Load(object sender, EventArgs e)
        {
            width.SelectedIndex = 0;
            colorPanel.BackColor = Color.Black;
            cbType.SelectedIndex = 1;
            tscbWidth.SelectedIndex = 0;
            tbcbWidth.SelectedIndex = 0;
            tscbType.SelectedIndex = 1;
            tbcbType.SelectedIndex = 1;
            cmtscmType.SelectedIndex = 1;
            cmtscbWidth.SelectedIndex = 0;
            tbcbWidth.SelectedIndexChanged += Width_SelectedIndexChanged;
            tscbWidth.SelectedIndexChanged += Width_SelectedIndexChanged;
            width.SelectedIndexChanged += Width_SelectedIndexChanged;
            cbType.SelectedIndexChanged += Type_SelectedIndexChanged;
            tscbType.SelectedIndexChanged += Type_SelectedIndexChanged;
            tbcbType.SelectedIndexChanged += Type_SelectedIndexChanged;
            moveLeftToolStripMenuItem.Enabled = false;
            moveRightToolStripMenuItem.Enabled = false;
            deleteTabToolStripMenuItem.Enabled = false;
            contextMenuStripRightMouseClick.Visible = false;
            contextMenuStripRightMouseClick.Enabled = false;
        }

        private void colorPanel_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = colorDialog.Color;
                foreach (Shape shape in tabControlCanvas.SelectedTab.Controls[0].Controls)
                {
                    if (shape.Focused)
                    {
                        shape.DrawPen = new Pen(colorPanel.BackColor, shape.DrawPen.Width);
                        shape.Invalidate();
                    }
                }
                contextMenuStripRightMouseClick.Visible = false;
                contextMenuStripRightMouseClick.Enabled = false;
            }
        }

        private void CanvasForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (allowToDraw)
            {
                if (tabControlCanvas.SelectedTab.Controls[0].Controls[shapeIndex] is Shape)
                {
                    Shape s = (tabControlCanvas.SelectedTab.Controls[0].Controls[shapeIndex] as Shape);
                    s.ResizeShape(e.X, e.Y);
                }
            }
        }

        private void Width_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Change)
            {
                int selectedIndex;
                if (sender is ToolStripComboBox)
                {
                    selectedIndex = Convert.ToInt32((sender as ToolStripComboBox).SelectedIndex);
                }
                else
                {
                    selectedIndex = Convert.ToInt32((sender as ComboBox).SelectedIndex);
                }
                Change = false;
                tbcbWidth.SelectedIndex = selectedIndex;
                tscbWidth.SelectedIndex = selectedIndex;
                width.SelectedIndex = selectedIndex;
                cmtscbWidth.SelectedIndex = selectedIndex;
                contextMenuStripRightMouseClick.Visible = false;
                contextMenuStripRightMouseClick.Enabled = false;
                Change = true;
                if (tmpShape != null)
                {
                    int index = tabControlCanvas.SelectedTab.Controls[0].Controls.IndexOf(tmpShape);
                    tabControlCanvas.SelectedTab.Controls[0].Controls[index].Focus();
                    (tabControlCanvas.SelectedTab.Controls[0].Controls[index] as Shape).DrawPen = new Pen(colorPanel.BackColor, Convert.ToInt32(width.SelectedItem));
                    tabControlCanvas.SelectedTab.Controls[0].Controls[index].Invalidate();
                }
            }
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Change)
            {
                int selectedIndex;
                if (sender is ToolStripComboBox)
                {
                    selectedIndex = Convert.ToInt32((sender as ToolStripComboBox).SelectedIndex);
                }
                else
                {
                    selectedIndex = Convert.ToInt32((sender as ComboBox).SelectedIndex);
                }
                Change = false;
                tbcbType.SelectedIndex = selectedIndex;
                tscbType.SelectedIndex = selectedIndex;
                cbType.SelectedIndex = selectedIndex;
                cmtscmType.SelectedIndex = selectedIndex;
                contextMenuStripRightMouseClick.Visible = false;
                contextMenuStripRightMouseClick.Enabled = false;
                Change = true;
                if (tmpShape != null)
                {
                    int index = tabControlCanvas.SelectedTab.Controls[0].Controls.IndexOf(tmpShape);
                    Shape shape = ShapeFactory.GetShapeInstance(cbType.SelectedItem.ToString(), tmpShape.Location.X, tmpShape.Location.Y,
                        tmpShape.Height, tmpShape.Width, Convert.ToInt16(width.SelectedItem), colorPanel.BackColor);
                    tabControlCanvas.SelectedTab.Controls[0].Controls.RemoveAt(index);
                    tabControlCanvas.SelectedTab.Controls[0].Controls.Add(shape);
                    tabControlCanvas.SelectedTab.Controls[0].Controls[index].Focus();
                    tmpShape = tabControlCanvas.SelectedTab.Controls[0].Controls[index] as Shape;
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
            foreach (Shape shape in tabControlCanvas.SelectedTab.Controls[0].Controls)
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
            while (tabControlCanvas.SelectedTab.Controls[0].Controls.Count > 0)
            {
                tabControlCanvas.SelectedTab.Controls[0].Controls[0].Dispose();
            }
            foreach (Shape shape in originator.shapes)
            {
                tabControlCanvas.SelectedTab.Controls[0].Controls.Add(shape);
            }
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage curruntPage = new TabPage("Canvas");
            tabControlCanvas.TabPages.Add(curruntPage);
            tabControlCanvas.TabPages[tabControlCanvas.TabPages.Count - 1].Controls.Add(new Panel());
            tabControlCanvas.TabPages[tabControlCanvas.TabPages.Count - 1].Controls[0].Dock = DockStyle.Fill;
            tabControlCanvas.TabPages[tabControlCanvas.TabPages.Count - 1].Controls[0].MouseDown += CanvasForm_MouseDown;
            tabControlCanvas.TabPages[tabControlCanvas.TabPages.Count - 1].Controls[0].MouseMove += CanvasForm_MouseMove;
            tabControlCanvas.TabPages[tabControlCanvas.TabPages.Count - 1].Controls[0].MouseUp += CanvasForm_MouseUp;
            tabControlCanvas.TabPages[tabControlCanvas.TabPages.Count - 1].Controls[0].BackColor = Color.White;
            moveRightToolStripMenuItem.Enabled = true;
            deleteTabToolStripMenuItem.Enabled = true;
        }

        private void tabControlCanvas_SelectedIndexChanged(object sender, EventArgs e)
        {
            shapeIndex = 0;
            moveLeftToolStripMenuItem.Enabled = false;
            moveRightToolStripMenuItem.Enabled = false;
            if (tabControlCanvas.SelectedIndex > 0)
            {
                moveLeftToolStripMenuItem.Enabled = true;
            }
            if (tabControlCanvas.SelectedIndex < tabControlCanvas.TabCount - 1)
            {
                moveRightToolStripMenuItem.Enabled = true;
            }
        }

        public void ShapeLoseFocus(object sender, EventArgs e)
        {
            tmpShape = sender as Shape;
        }

        public void ShapeGetFocus(object sender, EventArgs e)
        {
            if (!Change)
            {
                tmpShape = null;
            }
        }

        private void deleteTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlCanvas.TabPages.RemoveAt(tabControlCanvas.SelectedIndex);
        }

        private void moveLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlCanvas.SelectedIndex--;
        }

        private void moveRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlCanvas.SelectedIndex++;
        }

        private void ContexMenuShowOnRightMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripRightMouseClick.Enabled = true;
                contextMenuStripRightMouseClick.Show(Cursor.Position);
                contextMenuStripRightMouseClick.Visible = true;
                //foreach(Shape shape in tabControlCanvas.SelectedTab.Controls[0].Controls)
                //{
                //    if (shape.Focused)
                //    {
                //        shapeIndex = tabControlCanvas.SelectedTab.Controls[0].Controls.IndexOf(shape);
                //    }
                //}
            }
        }
    }
}
