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
        public static IPictureSL getI(string extention)
        {
            IPictureSL pictureLS;
            switch (extention)
            {
                case "jpg":
                    pictureLS = new BitmapFile();
                    break;
                case "gif":
                    pictureLS = new BitmapFile();
                    break;
                case "ico":
                    pictureLS = new BitmapFile();
                    break;
                case "png":
                    pictureLS = new BitmapFile();
                    break;
                case "tif":
                    pictureLS = new BitmapFile();
                    break;
                case "exif":
                    pictureLS = new BitmapFile();
                    break;
                case "pdf":
                    pictureLS = new PDFFile();
                    break;
                case "2":
                    pictureLS = new New2File();
                    break;
                case "3":
                    pictureLS = new New3File();
                    break;
                default:
                    pictureLS = new BitmapFile();
                    break;
            }
            return pictureLS;
        }
    }
}
