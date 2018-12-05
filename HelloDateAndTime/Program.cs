using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            Console.WriteLine("Please Enter your name: ");
            string name = Console.ReadLine();

            if((hour < 12) && (hour > 6))
            {
                Console.WriteLine("Good Morning {0}", name);
            }
            else if ((hour > 6) && (hour < 12))
            {
                Console.WriteLine("Good Night {0}", name);
            }
            else if ((hour < 18) && (hour > 12))
            {
                Console.WriteLine("Good Afternoon {0}", name);
            }
            else
            {
                Console.WriteLine("Good Evening {0}", name);
            }
            Console.ReadKey();
        }
    }
    
}

