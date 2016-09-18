using System;

namespace FactoryPatternDemo
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside from Rectangle class");
        }
    }
}
