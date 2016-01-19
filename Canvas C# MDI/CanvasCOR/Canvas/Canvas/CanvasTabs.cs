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
    }
}
