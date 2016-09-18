using System;

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
