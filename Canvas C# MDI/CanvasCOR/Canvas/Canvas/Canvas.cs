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
        static IList<string> listType;

        public CanvasForm()
        {
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
            listType = new List<string>() { "List", "Rectangle", "Elipse", "RoundRectangle", "Fozy" };
        }

        public void Binding()
        {
            IList<int> listWidth = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            cbType.DataSource = listType;
            cbType.DataBindings.Add("SelectedItem", binding, "Type");
            tbcbType.ComboBox.DataSource = listType;
            tbcbType.ComboBox.DataBindings.Add("SelectedItem", binding, "Type");
            tscbType.ComboBox.DataSource = listType;
            tscbType.ComboBox.DataBindings.Add("SelectedItem", binding, "Type");
            cmtscmType.ComboBox.DataSource = listType;
            cmtscmType.ComboBox.DataBindings.Add("SelectedItem", binding, "Type");

            width.DataSource = listWidth;
            width.DataBindings.Add("SelectedItem", binding, "LineWidth");
            tbcbWidth.ComboBox.DataSource = listWidth;
            tbcbWidth.ComboBox.DataBindings.Add("SelectedItem", binding, "LineWidth");
            tscbWidth.ComboBox.DataSource = listWidth;
            tscbWidth.ComboBox.DataBindings.Add("SelectedItem", binding, "LineWidth");
            cmtscbWidth.ComboBox.DataSource = listWidth;
            cmtscbWidth.ComboBox.DataBindings.Add("SelectedItem", binding, "LineWidth");
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

        public void ShapeLoseFocus(object sender, EventArgs e)
        {
            tmpShape = sender as Shape;
        }

        private void ContexMenuShowOnRightMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
              //  contextMenuStripRightMouseClick.Enabled = true;
                contextMenuStripRightMouseClick.BringToFront();
                contextMenuStripRightMouseClick.Show(Cursor.Position);
               // contextMenuStripRightMouseClick.Visible = true;
            }
        }

        private void ShowLableData(object sender, MouseEventArgs e)
        {
            lX.Text = (sender as Shape).Location.X.ToString();
            lY.Text = (sender as Shape).Location.Y.ToString();
            lWidth.Text = (sender as Shape).Width.ToString();
            lHeight.Text = (sender as Shape).Height.ToString();
        }

        private void tscbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as ToolStripComboBox).SelectedItem.ToString())
            {
                case "Standart":
                    StandartStyle.UseTheme(CanvasForm.ActiveForm);
                    StandartStyle.ApplyThemeContextMenu(contextMenuStripRightMouseClick);
                    break;
                case "DarkGotic":
                    DarkGotic.UseTheme(CanvasForm.ActiveForm);
                    DarkGotic.ApplyThemeContextMenu(contextMenuStripRightMouseClick);
                    break;
                case "LightClassic":
                    LightClassicStyle.UseTheme(CanvasForm.ActiveForm);
                    LightClassicStyle.ApplyThemeContextMenu(contextMenuStripRightMouseClick);
                    break;
            }

        }
    }
}
