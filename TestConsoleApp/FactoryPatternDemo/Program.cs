using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape1 = shapeFactory.GetShape("CirCLE");
            shape1.Draw();

            IShape shape2 = shapeFactory.GetShape("TrianglE");
            shape2.Draw();

            IShape shape3 = shapeFactory.GetShape("RECTANGLE");
            shape3.Draw();

            Console.ReadKey();
        }
    }
}
