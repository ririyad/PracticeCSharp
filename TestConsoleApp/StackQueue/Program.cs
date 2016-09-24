using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push('A');
            stack.Push('B');
            stack.Push('C');
            stack.Push('D');
            Console.WriteLine("Current stack: ");
            foreach (char ch in stack)
            {
                Console.Write(ch + " ");  

            }

            Console.WriteLine(stack.Count);
            
        }
    }
}
