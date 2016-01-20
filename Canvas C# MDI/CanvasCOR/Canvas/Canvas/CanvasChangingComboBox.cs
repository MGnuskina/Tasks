using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas
{
    public partial class CanvasForm
    {
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
                tmpShape = null;
            }
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
            }
        }
    }
}
