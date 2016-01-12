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
        public override string[] ListOfExtentions { get; set; }

        public BitmapFile()
        {
            ListOfExtentions= new string[] { "jpg", "gif", "ico", "png", "tif", "exif", "bmp" };
        }

        private ImageFormat imageFromat;

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

        public override APictureSL GetHandler(string extention)
        {
            if (IsYours(extention))
            {
                return new BitmapFile();
            }
            else
            {
                if (successor != null)
                {
                    return successor.GetHandler(extention);
                }
                else
                {
                    throw new ArgumentNullException("Such type can't be handled");
                }
            }
        }
    }
}

