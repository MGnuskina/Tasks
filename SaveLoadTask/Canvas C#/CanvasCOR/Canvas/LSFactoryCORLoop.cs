using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public static class LSFactoryCORLoop
    {
        static APictureSL[] classArray = new APictureSL[] { new BitmapFile(), new PDFFile(), new New2File(), new New3File() };

        public static IPictureSL getI(string extention)
        {
            APictureSL pictureLS;
            int i = 0;
            int size = classArray.Length;
            while (i < size && !classArray[i].IsYours(extention))
            {
                i++;
            }
            if (i != size)
            {
                pictureLS = classArray[i];
            }
            else
            {
                throw new ArgumentException();
            }
            return pictureLS;
        }
    }
}
