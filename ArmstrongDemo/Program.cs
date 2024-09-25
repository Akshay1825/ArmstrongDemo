using ArmstrongDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Armstrong armstrong = new Armstrong();

            Console.WriteLine("Enter a number :");
            int number = int.Parse(Console.ReadLine());

            string answer = armstrong.IsArmstrong(number)
                            ? $"{number} is an Armstrong number."
                            : $"{number} is not an Armstrong number.";

            Console.WriteLine(answer);
        }
    }
}
