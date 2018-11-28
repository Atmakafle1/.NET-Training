using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    class CompareNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0} is reater than {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} is reater than {1}", b, a);
            }
            Console.ReadKey();
        }
    }
}
