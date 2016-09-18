using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType == null)
                return null;
            else if (shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Circle();
            }

            else if (shapeType.Equals("triangle", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Triangle();
            }

            else if (shapeType.Equals("rectangle", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Rectangle();
            }

            return null;
        }
    }
}
