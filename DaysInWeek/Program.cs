using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysInWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day number in between [1-7]: ");
            int n = Convert.ToInt16(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("It's  Monday");
                    break;
                case 2:
                    Console.WriteLine("It's  Tuesday");
                    break;
                case 3:
                    Console.WriteLine("It's  Wednesday");
                    break;
                case 4:
                    Console.WriteLine("It's  Thursday");
                    break;
                case 5:
                    Console.WriteLine("It's  Friday");
                    break;
                case 6:
                    Console.WriteLine("It's  Saturday");
                    break;
                case 7:
                    Console.WriteLine("It's  Sunday");
                    break;
                default:
                    Console.WriteLine("Please enter correct input [1-7]");
                    break;
            }
            Console.ReadLine();
        }
    }
}
