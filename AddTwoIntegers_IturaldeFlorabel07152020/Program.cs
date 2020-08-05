using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoIntegers_IturaldeFlorabel07152020
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            Console.WriteLine("Calculate the sum of two numbers: ");
            Console.Write("Input number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.Write("Result:" + sum);

            Console.ReadKey();
        }
    }
}
