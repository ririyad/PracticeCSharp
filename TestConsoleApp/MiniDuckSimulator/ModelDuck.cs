using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehaviour = new FlyWithNoWings();
        }

        public override void Dispaly()
        {
            Console.WriteLine("I am a model duck!");
        }
    }
}
