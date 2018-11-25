using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int i = Convert.ToInt32(Console.ReadLine());
            int j;

            for (j = 1; j <= 10; j++)
            {
                Console.WriteLine("{0} X {1} = {2}", i, j, i * j);
            }
            Console.ReadLine();
        }
    }
}
