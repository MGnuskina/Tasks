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
using System.Globalization;

namespace Canvas
{
    public partial class CanvasForm : Form
    {
        private bool allowToDraw = false;
        Shape tmpShape;
        FormData data = new FormData();
        int shapeIndex;
        BindingSource binding = new BindingSource();

        public CanvasForm()
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");
            InitializeComponent();
            width.SelectedIndex = 0;
            colorPanel.BackColor = Color.Black;
            cbType.SelectedIndex = 1;
            tscbWidth.SelectedIndex = 0;
            tbcbWidth.SelectedIndex = 0;
            tscbType.SelectedIndex = 1;
            tbcbType.SelectedIndex = 1;
            cmtscmType.SelectedIndex = 1;
            cmtscbWidth.SelectedIndex = 0;
        }

        public void Binding()
        {
            IList<string> listType = new List<string> { "List", "Rectangle", "Elipse", "RoundRectangle", "Fozy" };
            IList<int> listWidth = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            cbType.DataSource = listType;
            cbType.DataBindings.Add("SelectedItem", binding, "Type");
            tbcbType.ComboBox.DataSource = listType;
            tbcbType.ComboBox.DataBindings.Add("SelectedItem", binding, "Type");
            tscbType.ComboBox.DataSource = listType;
            tscbType.ComboBox.DataBindings.Add("SelectedItem", binding, "Type");

            width.DataSource = listWidth;
            width.DataBindings.Add("SelectedItem", binding, "LineWidth");
            tbcbWidth.ComboBox.DataSource = listWidth;
            tbcbWidth.ComboBox.DataBindings.Add("SelectedItem", binding, "LineWidth");
            tscbWidth.ComboBox.DataSource = listWidth;
            tscbWidth.ComboBox.DataBindings.Add("SelectedItem", binding, "LineWidth");
        }

        private void CanvasForm_MouseDown(object sender, MouseEventArgs e)
        {
            allowToDraw = true;
            tmpShape = ShapeFactory.GetShapeInstance(ShapeFactory.GetTypeByNumber(cbType.SelectedIndex), e.X, e.Y, 1, 1, Convert.ToInt16(width.SelectedItem), colorPanel.BackColor);
            tabControlCanvas.SelectedTab.Controls[0].Controls.Add(tmpShape);
            shapeIndex = tabControlCanvas.SelectedTab.Controls[0].Controls.Count - 1;
        }

        private void CanvasForm_MouseUp(object sender, MouseEventArgs e)
        {
            allowToDraw = false;
            tabControlCanvas.SelectedTab.Controls[0].Controls[0].BringToFront();
            tabControlCanvas.SelectedTab.Controls[0].Controls[tabControlCanvas.SelectedTab.Controls[0].Controls.Count - 1].LostFocus += ShapeLoseFocus;
            tabControlCanvas.SelectedTab.Controls[0].Controls[tabControlCanvas.SelectedTab.Controls[0].Controls.Count - 1].MouseClick += ContexMenuShowOnRightMouseClick;
            tabControlCanvas.SelectedTab.Controls[0].Controls[tabControlCanvas.SelectedTab.Controls[0].Controls.Count - 1].MouseMove += ShowLableData;
            tmpShape = null;
        }

        private void CanvasForm_Load(object sender, EventArgs e)
        {
            tbcbWidth.ComboBox.SelectedIndexChanged += Width_SelectedIndexChanged;
            tscbWidth.ComboBox.SelectedIndexChanged += Width_SelectedIndexChanged;
            width.SelectedIndexChanged += Width_SelectedIndexChanged;
            cbType.SelectedIndexChanged += Type_SelectedIndexChanged;
            tscbType.ComboBox.SelectedIndexChanged += Type_SelectedIndexChanged;
            tbcbType.ComboBox.SelectedIndexChanged += Type_SelectedIndexChanged;
            moveLeftToolStripMenuItem.Enabled = false;
            moveRightToolStripMenuItem.Enabled = false;
            deleteTabToolStripMenuItem.Enabled = false;
            contextMenuStripRightMouseClick.Visible = false;
            contextMenuStripRightMouseClick.Enabled = false;
            tscbLenguage.ComboBox.SelectedIndex = 0;

            binding.DataSource = data;
            Binding();
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
            if (sender is ComboBox)
            {
                data.LineWidth = Convert.ToInt32((sender as ComboBox).SelectedItem.ToString());
            }
            else
            {
                if (sender is ToolStripComboBox)
                {
                    data.LineWidth = Convert.ToInt32((sender as ToolStripComboBox).SelectedItem.ToString());
                }
            }
            if (tmpShape != null)
            {
                int index = tabControlCanvas.SelectedTab.Controls[0].Controls.IndexOf(tmpShape);
                tabControlCanvas.SelectedTab.Controls[0].Controls[index].Focus();
                (tabControlCanvas.SelectedTab.Controls[0].Controls[index] as Shape).DrawPen = new Pen(colorPanel.BackColor, Convert.ToInt32(width.SelectedItem));
                tabControlCanvas.SelectedTab.Controls[0].Controls[index].Invalidate();
            }
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                data.Type = (sender as ComboBox).SelectedItem.ToString();
            }
            if (tmpShape != null)
            {
                int index = tabControlCanvas.SelectedTab.Controls[0].Controls.IndexOf(tmpShape);
                Shape shape = ShapeFactory.GetShapeInstance(ShapeFactory.GetTypeByNumber(cbType.SelectedIndex), tmpShape.Location.X, tmpShape.Location.Y,
                    tmpShape.Height, tmpShape.Width, Convert.ToInt16(width.SelectedItem), colorPanel.BackColor);
                tabControlCanvas.SelectedTab.Controls[0].Controls.RemoveAt(index);
                tabControlCanvas.SelectedTab.Controls[0].Controls.Add(shape);
                tabControlCanvas.SelectedTab.Controls[0].Controls[index].Focus();
                tmpShape = tabControlCanvas.SelectedTab.Controls[0].Controls[index] as Shape;
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
            TabPage curruntPage = new TabPage(tabControlCanvas.TabPages[0].Text);
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
                contextMenuStripRightMouseClick.BringToFront();
                contextMenuStripRightMouseClick.Show(Cursor.Position);
                contextMenuStripRightMouseClick.Visible = true;
            }
        }

        private void ShowLableData(object sender, MouseEventArgs e)
        {
            lX.Text = (sender as Shape).Location.X.ToString();
            lY.Text = (sender as Shape).Location.Y.ToString();
            lWidth.Text = (sender as Shape).Width.ToString();
            lHeight.Text = (sender as Shape).Height.ToString();
        }

        private void tscbLenguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripComboBox)
            {
                switch ((sender as ToolStripComboBox).SelectedItem.ToString())
                {
                    case "English":
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                        break;
                    case "Русский":
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-ru");
                        break;
                    default:
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");
                        break;
                }
                ChangeLanguage();
            }
        }

        private static void ChangeLanguage()
        {
            foreach (Form frm in Application.OpenForms)
            {
                LocalizeForm(frm);
            }
        }

        private static void LocalizeForm(Form frm)
        {
            var manager = new ComponentResourceManager(frm.GetType());
            manager.ApplyResources(frm, "$this");
            ApplyResources(manager, frm.Controls);
        }

        private static void ApplyResources(ComponentResourceManager manager, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                manager.ApplyResources(ctl, ctl.Name);
                if (ctl is MenuStrip)
                {
                    ApplyResourcesMenuItems(manager, (ctl as MenuStrip).Items);
                }
                else
                {
                    if (ctl is ToolStrip)
                    {
                        ApplyResourcesToolStripItems(manager, (ctl as ToolStrip).Items);
                    }
                    else
                    {
                        //if (ctl.Name=="cbType")
                        //{
                        //    var cmbBox = ctl as ComboBox;
                        //    int i = cmbBox.Items.Count;
                        //    cmbBox.Items.Clear();
                        //    for (int j = 0; j < i; j++)
                        //    {
                        //        var str = "";
                        //        if (j == 0)
                        //        {
                        //            str = string.Format("{0}.Items", cmbBox.Name);
                        //        }
                        //        else
                        //        {
                        //            str = string.Format("{0}.Items{1}", cmbBox.Name, j);
                        //        }
                        //        cmbBox.Items.AddRange(new object[]
                        //        {
                        //            manager.GetString(str)
                        //        });
                        //    }
                        //}
                        //else
                            ApplyResources(manager, ctl.Controls);
                    }
                }
            }
        }

        private static void ApplyResourcesMenuItems(ComponentResourceManager manager, ToolStripItemCollection items)
        {
            foreach (var item in items)
            {
                if (item is ToolStripMenuItem)
                {
                    ApplyResourcesMenuItems(manager, (item as ToolStripMenuItem).DropDown.Items);
                    manager.ApplyResources(item, (item as ToolStripMenuItem).Name);
                }
            }
        }

        private static void ApplyResourcesToolStripItems(ComponentResourceManager manager, ToolStripItemCollection items)
        {
            foreach (var item in items)
            {
                if (item is ToolStripLabel)
                {
                    manager.ApplyResources(item, (item as ToolStripLabel).Name);
                }
                else
                {
                    if (item is ToolStripButton)
                    {
                        manager.ApplyResources(item, (item as ToolStripButton).Name);
                    }
                }
            }
        }

        private void tscbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
