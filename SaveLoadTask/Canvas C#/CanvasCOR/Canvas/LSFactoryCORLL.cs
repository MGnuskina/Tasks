using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public class LSFactoryCORLL
    {
        static APictureSL[] classArray = new APictureSL[] { new BitmapFile(), new PDFFile(), new New2File(), new New3File() };

        public LSFactoryCORLL()
        {
            for (int i=0; i<classArray.Length-1; i++)
            {
                classArray[i].SetSuccessor(classArray[i + 1]);
            }
        }

        public APictureSL getI(string extention)
        {
            return classArray[0].GetHandler(extention);
        }
    }
}
