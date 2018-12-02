using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Odd Numbers **");
            for(int i=5; i<=18; i++)
            {
                if(i%2 != 0)
                {
                    Console.Write(i + "," );
                }
            }
            
            Console.ReadKey();
        }
    }
}
