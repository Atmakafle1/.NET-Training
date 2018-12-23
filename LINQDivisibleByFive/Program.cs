using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDivisibleByFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 3, 6, 15, 21, 35, 75, 10 };
            var numDivisibleByFive = from values in Array1
                                     where (int)values % 5 == 0
                                     select  values ;
            foreach (var item in numDivisibleByFive)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
