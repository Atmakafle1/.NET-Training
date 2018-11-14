using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMonthBy_MonthNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Week = new String[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            for (int i = 1; i<= 7; i++)
            {
                
                Console.WriteLine(Week[i-1]);
            }
            Console.ReadKey();
        }
    }
}
