﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas
{
    public interface IWorkWithFiles
    {
        void Save(List<ShapeData> balls, string FilePath);
        List<ShapeData> Load(string FilePath);
    }
}
