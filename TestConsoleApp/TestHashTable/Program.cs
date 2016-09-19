using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable hashtable = new Hashtable();
            SortedList hashtable = new SortedList();
            hashtable.Add("01", "Zara");
            hashtable.Add("02", "Abida");
            hashtable.Add("03", "Masum");
            hashtable.Add("04", "Arif");

            if (hashtable.ContainsValue("Nuha"))
            {
                Console.WriteLine("The student is already in the list");
            }
            else
            {
                hashtable.Add("05", "Nuha");
            }

            // get a collection of keys
            ICollection key = hashtable.Keys;
            foreach (string s in key)
            {
                Console.WriteLine(s + " " + hashtable[s]);
            }

            Console.ReadKey();
        }
    }
}
