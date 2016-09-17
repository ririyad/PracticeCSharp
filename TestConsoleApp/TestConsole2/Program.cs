using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is another file!");
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.WriteLine("Size of char: {0}", sizeof(char));
            Console.WriteLine("Size of double: {0}", sizeof(double));

            // type checking occurs at run time
            dynamic number = 20.5;
            dynamic stringVal = "This is a string";
            dynamic floatVal = 455.677f;

            Console.WriteLine("Testing dynamic type:");
            Console.WriteLine(number);
            Console.WriteLine(number.GetType()); // evaluating type

            Console.WriteLine(stringVal);
            Console.WriteLine(stringVal.GetType());

            Console.WriteLine(floatVal);
            Console.WriteLine(floatVal.GetType()); // System.Single

            Console.WriteLine(@"Hello unquoted String!"); // unquoted string!
        }
    }
}
