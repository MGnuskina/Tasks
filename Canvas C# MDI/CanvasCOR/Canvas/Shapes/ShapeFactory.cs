using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public static class ShapeFactory
    {
        public static Shape GetShapeInstance(string type, int X, int Y, int height, int width, int lineWidth, Color color)
        {
            Shape shape;
            switch (type)
            {
                case "Elipse":
                    shape = new Elipse(X, Y, height, width, lineWidth, color);
                    break;
                case "Rectangle":
                    shape = new Rectangle(X, Y, height, width, lineWidth, color);
                    break;
                case "Fozy":
                    shape = new Elipse(X, Y, height, width, lineWidth, color);
                    break;
                case "RectangleRound":
                    shape = new RectangleRound(X, Y, height, width, lineWidth, color);
                    break;
                default:
                    shape = new Line(X, Y, height, width, lineWidth, color);
                    break;
            }
            return shape;
        }

        static string[] typesArray=new string[]{"Line","Rectangle","Elipse", "RectangleRound", "Fozy"};

        public static string GetTypeByNumber(int Num)
        {
            return typesArray[Num];
        }
    }
}
