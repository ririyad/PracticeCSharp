using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
