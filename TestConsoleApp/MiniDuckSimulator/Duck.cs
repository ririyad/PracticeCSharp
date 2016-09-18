using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    public abstract class Duck
    {
        protected IQuackBehavior quackBehavior;
        protected IFlyBehaviour flyBehaviour;

        public abstract void Dispaly();

        public void performFly()
        {
            flyBehaviour.Fly();
        }

        public void performQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks floats, even decoys!");
        }

        public void SetFlyBehaviour(IFlyBehaviour fb)
        {
            flyBehaviour = fb;
        }

        public void SetQuackBehaviour(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
