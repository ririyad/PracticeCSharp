using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    public class MallardDuck : Duck
    {
        
        public MallardDuck()
        {
            quackBehavior = new NormalQuack();
            flyBehaviour = new FlyWithWings();
        }


        public override void Dispaly()
        {
            Console.WriteLine("I am a real mallard duck!");
        }
    }
}
