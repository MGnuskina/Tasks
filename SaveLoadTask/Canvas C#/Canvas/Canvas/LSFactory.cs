using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public static class LSFactory
    {
        public static IPictureSL getI(string FileName)
        {
            IPictureSL pictureLS;
            string extention = (FileName.Substring(FileName.LastIndexOf('.') + 1)).ToString().ToLower();
            switch (extention)
            {
                case "jpg":
                    pictureLS = new BitmapFile(ImageFormat.Jpeg);
                    break;
                case "gif":
                    pictureLS = new BitmapFile(ImageFormat.Gif);
                    break;
                case "ico":
                    pictureLS = new BitmapFile(ImageFormat.Icon);
                    break;
                case "png":
                    pictureLS = new BitmapFile(ImageFormat.Png);
                    break;
                case "tif":
                    pictureLS = new BitmapFile(ImageFormat.Tiff);
                    break;
                case "exif":
                    pictureLS = new BitmapFile(ImageFormat.Exif);
                    break;
                default:
                    pictureLS = new BitmapFile(ImageFormat.Bmp);
                    break;
            }
            return pictureLS;
        }
    }
}
