using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    [Serializable()]
    public class ShapeData
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int LineWidth { get; set; }
        public string Type { get; set; }
        public int[] Color { get; set; }

        public ShapeData() { }

        public ShapeData(int X, int Y, int Width, int Height, int lineWidth, string Type, Color color)
        {
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
            this.LineWidth = lineWidth;
            this.Type = Type;
            this.Color = new int[3] { color.R, color.G, color.B };
        }

        public Color GetColor()
        {
            return System.Drawing.Color.FromArgb(Color[0], Color[1], Color[2]);
        }
    }
}
