using System;

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
