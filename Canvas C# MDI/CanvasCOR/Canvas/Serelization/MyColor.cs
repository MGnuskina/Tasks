using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    [Serializable()]
    public class MyColor
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        //alfa

        public MyColor(Color color)
        {
            Red = color.R;
            Green = color.G;
            Blue = color.B;
        }
    }
}
