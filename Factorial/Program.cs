using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Fact fact = new Fact();
            Console.WriteLine("Enter the number that you wish to find Factorial for: ");
            int n = Convert.ToInt16(Console.ReadLine());
            int totalFact = fact.checkFact(n);
            Console.WriteLine("Factorail for {0} is {1}.", n, totalFact);
            Console.ReadLine();
        }
    }
}
