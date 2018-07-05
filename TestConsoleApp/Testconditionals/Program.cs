using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testconditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("a is bigger hehe!");
            }

            else
            {
                Console.WriteLine("uhu, b is bigger");
            }
        }
    }
}
