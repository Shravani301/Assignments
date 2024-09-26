using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolindromeApp.Models
{
    internal class Polindrome
    {
        public int ReverseGivenNumber(int input)
        {
            int result = 0;
            int num = input;
            if (num < 0)
            {
                return -1;
            }
            while (num > 0)
            {
                int remainder = num % 10;
                num = num / 10;
                result = result * 10 + remainder;
            }
            return result;
        }

        public bool CheckPolindrome(int input)
        {
            if (!((ReverseGivenNumber(input)) == input) || ReverseGivenNumber(input)==-1)
                return false;
            return true;
        }
    }
}
