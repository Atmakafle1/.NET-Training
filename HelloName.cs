using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Full Name");
            String name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hello" + " " + name);
            Console.ReadKey();
        }
    }
}
