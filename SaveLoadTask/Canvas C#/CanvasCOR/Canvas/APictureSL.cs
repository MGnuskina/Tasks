using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public abstract class APictureSL : IPictureSL
    {
        public abstract string[] ListOfExtentions { get; set; }

        public abstract Bitmap Load(string FileName);

        public abstract void Save(string FileName, Bitmap picture);

        public bool IsYours(string extention)
        {
            bool res = false;
            int i = 0;
            int size = ListOfExtentions.Length;
            while (i<size && extention!=ListOfExtentions[i])
            {
                i++;
            }
            if (i!=size)
            {
                res = true;
            }
            return res;
        }
    }
}
