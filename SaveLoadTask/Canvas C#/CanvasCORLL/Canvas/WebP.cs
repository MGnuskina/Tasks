﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imazen.WebP;

namespace Canvas
{
    public class WebP : IPictureSL
    {
        public Bitmap Load(string FileName)
        {
            Bitmap image = WebPFormat.LoadFromStream(new FileStream(FileName, FileMode.Open, FileAccess.Read));
            throw new NotImplementedException();
        }

        public void Save(string FileName, Bitmap picture)
        {
            throw new NotImplementedException();
        }
    }
}
