using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public class BitmapFile : APictureSL
    {
        private string[] listOfExt;
        public override string[] ListOfExtentions
        {
            get { return listOfExt; }
            set { listOfExt = new string[] { "jpg", "gif", "ico", "png", "tif", "exif", "bmp" }; }
        }

        private ImageFormat imageFromat;
        private string extention;

        public BitmapFile() { }

        public override Bitmap Load(string FileName)
        {
            return new Bitmap(Image.FromFile(FileName));
        }

        public override void Save(string FileName, Bitmap picture)
        {
            string extention = (FileName.Substring(FileName.LastIndexOf('.') + 1)).ToString().ToLower();
            SetFormat(extention);
            picture.Save(FileName, imageFromat);
        }

        private void SetFormat(string extention)
        {
            switch (extention)
            {
                case "jpg":
                    imageFromat = ImageFormat.Jpeg;
                    break;
                case "gif":
                    imageFromat = ImageFormat.Gif;
                    break;
                case "ico":
                    imageFromat = ImageFormat.Icon;
                    break;
                case "png":
                    imageFromat = ImageFormat.Png;
                    break;
                case "tif":
                    imageFromat = ImageFormat.Tiff;
                    break;
                case "exif":
                    imageFromat = ImageFormat.Exif;
                    break;
                default:
                    imageFromat = ImageFormat.Bmp;
                    break;
            }
        }
    }
}
