using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball
{
    [Serializable()]
    public class MBall
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Dx { get; set; }
        public int Dy { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public MBall() { }

        public MBall(int x,int y,int dx,int dy, int width, int height)
        {
            X = x;
            Y = y;
            Dx = dx;
            Dy = dy;
            Width = width;
            Height = height;
        }
    }
}
