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
            String[] Months = new String[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            for (int i = 1; i<= 12; i++)
            {
                
                Console.WriteLine(Months[i-1]);
            }
            Console.ReadKey();
        }
    }
}
