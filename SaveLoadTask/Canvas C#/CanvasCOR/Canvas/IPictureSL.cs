﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public interface IPictureSL
    {
        void Save(string FileName, Bitmap picture);
        Bitmap Load(string FileName);
    }
}
