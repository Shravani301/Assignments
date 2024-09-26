using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumberApp.Models
{
    internal class ReverseNumber
    {
        public int ReverseGivenNumber(int input)
        { 
            int result = 0;
            int num = input;
            while (num > 0)
            {
                int remainder = num % 10;
                num = num / 10;
                result = result * 10 + remainder;
            }
            return result;
        }
    }
}
