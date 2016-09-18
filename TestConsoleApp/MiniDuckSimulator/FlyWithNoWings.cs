using System;

namespace MiniDuckSimulator
{
    class FlyWithNoWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
