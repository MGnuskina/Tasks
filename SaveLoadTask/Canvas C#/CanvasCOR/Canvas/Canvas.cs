using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas
{
    public partial class CanvasForm : Form
    {
        private bool allowToDraw = false;
        private int x, y;
        Bitmap Area;

        public CanvasForm()
        {
            InitializeComponent();
            Area = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = Area;
        }

        private void CanvasForm_MouseDown(object sender, MouseEventArgs e)
        {
            allowToDraw = true;
            x = e.X;
            y = e.Y;
        }

        private void CanvasForm_MouseUp(object sender, MouseEventArgs e)
        {
            allowToDraw = false;
        }

        private void CanvasForm_Load(object sender, EventArgs e)
        {
            width.SelectedIndex = 24;
            colorPanel.BackColor = Color.Black;


            Graphics g;
            g = Graphics.FromImage(Area);

            Pen mypen = new Pen(Brushes.Black);
            g.DrawLine(mypen, 0, 0, 200, 200);
            g.Clear(Color.White);
            g.Dispose();
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
                Graphics g = Graphics.FromImage(Area);
                int widthNow = Convert.ToInt16(width.SelectedItem);
                Pen p = new Pen(colorPanel.BackColor, widthNow);
                SolidBrush pDot = new SolidBrush(colorPanel.BackColor);
                g.DrawLine(p, x, y, e.X, e.Y);
                g.FillEllipse(pDot, (int)(x - widthNow / 2.0), (int)(y - widthNow / 2.0), widthNow, widthNow);
                x = e.X;
                y = e.Y;

                pictureBox1.Image = Area;

                g.Dispose();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Load an Image";
            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Icon Image|*.ico|Png Image|*.png|Tiff Image|*.tif|Exif Image|*.exif";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string extention = (path.Substring(path.LastIndexOf('.') + 1)).ToString().ToLower();
                IPictureSL writer = LSFactory.getI(extention);
                Area = writer.Load(path);
                pictureBox1.Image = Area;
            }
            openFileDialog1.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save an Image";
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Icon Image|*.ico|Png Image|*.png|Tiff Image|*.tif|Exif Image|*.exif";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                string extention = (path.Substring(path.LastIndexOf('.') + 1)).ToString().ToLower();
                IPictureSL writer = LSFactory.getI(extention);
                Bitmap b = new Bitmap(Area);
                writer.Save(path, b);
                b.Dispose();
            }
            saveFileDialog1.Dispose();
        }
    }
}
