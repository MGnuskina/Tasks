using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public class New2File : APictureSL
    {
        public override string[] ListOfExtentions
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override APictureSL GetHandler(string extention)
        {
            if (IsYours(extention))
            {
                return new New2File();
            }
            else
            {
                if (successor != null)
                {
                    return successor;
                }
                else
                {
                    throw new ArgumentNullException("Such type can't be handled");
                }
            }
        }

        public override Bitmap Load(string FileName)
        {
            throw new NotImplementedException();
        }

        public override void Save(string FileName, Bitmap picture)
        {
            throw new NotImplementedException();
        }
    }
}
