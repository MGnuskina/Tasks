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
            shape = ShapeFactory.GetShapeInstance(cbType.SelectedItem.ToString(), e.Y, e.X,
                e.Y + 1, e.X + 1, Convert.ToInt16(width.SelectedItem),
                colorPanel.BackColor);
            panelCanvas1.Controls.Add(shape);
            panelCanvas1.Controls[panelCanvas1.Controls.Count - 1].BringToFront();
            panelCanvas1.Controls[panelCanvas1.Controls.Count - 1].MouseUp += CanvasForm_MouseUp;
            panelCanvas1.Controls[panelCanvas1.Controls.Count - 1].MouseDown += CanvasForm_MouseDown;
            shapeIndex = panelCanvas1.Controls.Count - 1;
        }

        private void CanvasForm_MouseUp(object sender, MouseEventArgs e)
        {
            allowToDraw = false;
        }

        private void CanvasForm_Load(object sender, EventArgs e)
        {
            width.SelectedIndex = 0;
            colorPanel.BackColor = Color.Black;
            cbType.SelectedIndex = 0;
            tscbWidth.SelectedIndex = 0;
            tbcbWidth.SelectedIndex = 0;
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
                    (panelCanvas1.Controls[shapeIndex] as Shape).ResizeShape(e.X, e.Y);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //    openFileDialog1.Title = "Load an Image";
            //    openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Icon Image|*.ico|Png Image|*.png|Tiff Image|*.tif|Exif Image|*.exif|PDF File|*.pdf";
            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        string path = openFileDialog1.FileName;
            //        string extention = (path.Substring(path.LastIndexOf('.') + 1)).ToString().ToLower();
            //        IPictureSL writer = LSFactoryCORLoop.getI(extention);
            //        IPictureSL writer = LSFactory.getI(extention);
            //        IPictureSL writer = new LSFactoryCORLL().getI(extention);
            //        Area = writer.Load(path);
            //        pictureBox1.Image = Area;
            //    }
            //    openFileDialog1.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //    saveFileDialog1.Title = "Save an Image";
            //    saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Icon Image|*.ico|Png Image|*.png|Tiff Image|*.tif|Exif Image|*.exif|PDF File|*.pdf";
            //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        string path = saveFileDialog1.FileName;
            //        string extention = (path.Substring(path.LastIndexOf('.') + 1)).ToString().ToLower();
            //        IPictureSL writer = LSFactoryCORLoop.getI(extention);
            //        IPictureSL writer = LSFactory.getI(extention);
            //        IPictureSL writer = new LSFactoryCORLL().getI(extention);
            //        Bitmap b = new Bitmap(Area);
            //        writer.Save(path, b);
            //        b.Dispose();
            //    }
            //    saveFileDialog1.Dispose();
        }

        private void cbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tscbWidth.SelectedIndex = (sender).SelectedIndex;
            //tbcbWidth.SelectedIndex = (sender).SelectedIndex;
            //width.SelectedIndex = (sender).SelectedIndex;
        }
    }
}
