using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMaxNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 3, 4, 8, 12, 9, 74, 129, 2 };

            var maxNumbers = from values in Array1
                             orderby values descending
                             select values;

            foreach (int item in maxNumbers)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }
    }
}
