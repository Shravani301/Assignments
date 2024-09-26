using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberApp.Models
{
    internal class PrimeNumber
    {
        int number { get; set; }

        public bool IsPrimeOrNot(int input)
        {
            if (input < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                    return false;
            }
            return true;
        }
    }
}
