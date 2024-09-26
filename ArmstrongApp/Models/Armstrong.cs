using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongApp.Models
{
    internal class Armstrong
    {
        public bool CheckArmstrong(int input)
        {
            int len = input.ToString().Length;
            int num = input;
            double result = 0;

            if (num < 0)
                return false;
            else if (num == 0)
                return true;
            else
            {
                while (num > 0)
                {
                    int remainder = num % 10;
                    result = result + Math.Pow(remainder, len);
                    num = num / 10;
                }
            }

            if (result == input)
                return true;
            return false;
        }
    }
}
