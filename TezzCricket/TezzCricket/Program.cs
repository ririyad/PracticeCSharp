using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezzCricket
{
    class Program
    {
        static void Main(string[] args)
        {
            TotalRun totalRun = new TotalRun();
            int testCase = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= testCase; i++)
            {
                int[] arr;
                int noOfOut = Convert.ToInt32(Console.ReadLine());
                var run = totalRun.AddRuns();

                Console.WriteLine("Case: {0}: {1}", i, run);
            }
        }
    }

    class TotalRun
    {
        public int AddRuns(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }

    }
}
