using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            for (int i = 4; i <= 10; i++)
            {
                arrayList.Add(i);
            }
            arrayList.Add(43);
            arrayList.Add(23);
            arrayList.Add(67);
            arrayList.Add(22);
            arrayList.Add(98);
            arrayList.Add(32);

            Console.WriteLine("Capacity: {0}", arrayList.Capacity);
            Console.WriteLine("Count: {0}", arrayList.Count);

            foreach (int i in arrayList)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            arrayList.Sort();
            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            arrayList.Clear();
            Console.WriteLine(arrayList.Count);
            Console.WriteLine(arrayList.Capacity);
            Console.ReadKey();
        }
    }
}
