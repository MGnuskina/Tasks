using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas.Serelization
{
    public class ShapeOriginator
    {
        public List<Shape> shapes;

        public ShapeOriginator()
        {
            shapes = new List<Shape>();
        }

        public void SetMemento(ShapeMemento memento)
        {
            shapes.Clear();
            List<ShapeData> shapeData = memento.GetMemento();
            foreach (ShapeData shape in shapeData)
            {
                shapes.Add(ShapeFactory.GetShapeInstance(shape.Type, shape.X, shape.Y, shape.Height, shape.Width, shape.LineWidth, shape.GetColor()));
            }
        }

        public ShapeMemento CreateMemento()
        {
            List<ShapeData> mShapes = new List<ShapeData>();
            foreach (Shape shape in shapes)
            {
                string type = (shape.GetType()).ToString();
                type = type.Substring(type.IndexOf(".") + 1);
                mShapes.Add(new ShapeData(shape.Location.X, shape.Location.Y, shape.Width, shape.Height, 
                    Convert.ToInt32(shape.DrawPen.Width), type , shape.DrawPen.Color ));
            }
            return new ShapeMemento(mShapes);
        }
    }
}
