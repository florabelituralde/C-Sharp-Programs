using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3CGreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application will help you determine whether a number is greater than the other.");
            Console.Write("\nPlease type your first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please type your second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"\nThe number {a} is greater than {b}");
                Console.ReadLine();
            }
            else if (a < b)
            {
                Console.WriteLine($"\nThe number {b} is greater than {a}");
                Console.ReadLine();
            }
            else if (a == b)
            {
                Console.WriteLine($"\nThe number {a} is equal to {b}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nPlease enter a valid number.");
            }
        }
    }
}
