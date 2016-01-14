using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas.Serelization
{
    public class ShapeMemento
    {
        private List<ShapeData> shapes;

        public ShapeMemento(List<ShapeData> balls)
        {
            this.shapes = new List<ShapeData>(balls);
        }

        public List<ShapeData> GetMemento()
        {
            return shapes;
        }
    }
}
