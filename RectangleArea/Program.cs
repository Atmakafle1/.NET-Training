using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            Console.WriteLine("Enter length of a rectangle:");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter width of a rectangle:");
            double w = Convert.ToDouble(Console.ReadLine());

            double Area = l * w;

            Console.WriteLine("Rectangle area is: {0}", Area);

            Console.WriteLine("Enter radius of a Sphere:");
            double r = Convert.ToDouble(Console.ReadLine()); 
            double volume = (4*pi*r*r*r)/ 3;
            Console.WriteLine("Sphere volume is: {0}", volume);
            Console.ReadLine();

        }
    }
}
