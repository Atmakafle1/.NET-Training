using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Fact
    {

        public int checkFact(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            else
            {
                return number * checkFact(number - 1);
            }
        }
    }
}
