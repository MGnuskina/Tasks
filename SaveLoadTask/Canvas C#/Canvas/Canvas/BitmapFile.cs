using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public class BitmapFile : IPictureSL
    {
        private ImageFormat imageFromat;
        public BitmapFile(ImageFormat iFormat)
        {
            this.imageFromat = iFormat;
        }

        public Bitmap Load(string FileName)
        {
            return new Bitmap(Image.FromFile(FileName));
        }

        public void Save(string FileName, Bitmap picture)
        {
            picture.Save(FileName, imageFromat);
        }
    }
}
