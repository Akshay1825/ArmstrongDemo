using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongDemo.Model
{
    internal class Armstrong
    {
        public bool IsArmstrong(int num)
        {
            int sum = 0;
            int temp = num;
            int digits = num.ToString().Length;

            while (temp > 0)
            {
                int remainder = temp % 10;
                sum += (int)Math.Pow(remainder, digits);
                temp /= 10;
            }
            return sum == num;
        }
    }
}
