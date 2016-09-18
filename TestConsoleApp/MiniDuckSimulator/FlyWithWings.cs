using System;

namespace MiniDuckSimulator
{
    class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am flying");
        }
    }
}
