using System;

namespace FactoryPatternDemo
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside from Circle class");
        }
    }
}
