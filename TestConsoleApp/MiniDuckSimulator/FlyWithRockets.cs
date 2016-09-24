using System;

namespace MiniDuckSimulator
{
    class FlyWithRockets : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with rocket!");
        }
    }
}
