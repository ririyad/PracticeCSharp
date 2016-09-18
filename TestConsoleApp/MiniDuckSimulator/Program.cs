using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallarDuck = new MallardDuck();
            mallarDuck.performFly();
            mallarDuck.performQuack();
            mallarDuck.Dispaly();

            Console.WriteLine("\n\n");

            Duck modelDuck = new ModelDuck();
            modelDuck.performFly();
            modelDuck.performQuack();
            modelDuck.Dispaly();
            Console.WriteLine("\n\n");
            modelDuck.performFly();
            modelDuck.SetFlyBehaviour(new FlyWithRockets());
            modelDuck.performFly();
            modelDuck.Dispaly();

            Console.ReadKey();
        }
    }
}
