using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas
{
    public partial class CanvasForm
    {
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
            tabControlCanvas.SelectedTab.Controls[0].Controls[tabControlCanvas.SelectedTab.Controls[0].Controls.Count - 1].Enter += GetDataFromShape;
        }

        private void GetDataFromShape(object sender, EventArgs e)
        {
            foreach (var shape in tabControlCanvas.SelectedTab.Controls)
            {
                if (shape is Shape)
                {
                    if (shape != (sender as Shape))
                    {
                        (shape as Shape).Enabled = false;
                    }
                }
            }
            tmpShape = (sender as Shape);
            data.LineWidth = (int)(sender as Shape).DrawPen.Width;
            data.Type = tmpShape.GetType().ToString();
            colorPanel.BackColor = (sender as Shape).DrawPen.Color;
        }

        private void CanvasForm_Load(object sender, EventArgs e)
        {
            tbcbWidth.ComboBox.SelectedIndexChanged += Width_SelectedIndexChanged;
            tscbWidth.ComboBox.SelectedIndexChanged += Width_SelectedIndexChanged;
            width.SelectedIndexChanged += Width_SelectedIndexChanged;
            cbType.SelectedIndexChanged += Type_SelectedIndexChanged;
            tscbType.ComboBox.SelectedIndexChanged += Type_SelectedIndexChanged;
            tbcbType.ComboBox.SelectedIndexChanged += Type_SelectedIndexChanged;
            cmtscmType.ComboBox.SelectedIndex = 0;
            cmtscmType.ComboBox.SelectedIndexChanged += Type_SelectedIndexChanged;
            cmtscbWidth.ComboBox.SelectedIndexChanged += Width_SelectedIndexChanged;
            cmtscbWidth.ComboBox.SelectedIndex = 0;
            moveLeftToolStripMenuItem.Enabled = false;
            moveRightToolStripMenuItem.Enabled = false;
            deleteTabToolStripMenuItem.Enabled = false;
            //contextMenuStripRightMouseClick.Visible = false;
            //  contextMenuStripRightMouseClick.Enabled = false;
            tscbLenguage.ComboBox.SelectedIndex = 0;
            tscbStyle.ComboBox.SelectedIndex = 0;
            //listType = new List<string> { "List", "Rectangle", "Elipse", "RoundRectangle", "Fozy" };
            binding.DataSource = data;
            Binding();
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
    }
}
