using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialApp.Models
{
    internal class Factorial
    {
        public double FindFactorial(int input)
        {
            double result=1;
            if(input==0||input==1)
                return 1;
            for (int i = 1; i <= input; i++)
            {
                result=result*i;
            }
            return result;
        }
    }
}
