using System;

namespace FactoryPatternDemo
{
    class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside from Triangle class");
        }
    }
}
