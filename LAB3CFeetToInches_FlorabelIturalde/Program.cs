using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3CFeetToInches_FlorabelIturalde
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will help you convert feet to inches");

            Console.Write("\nPlease enter the number of feet to convert: ");
            int a = Convert.ToInt32(Console.ReadLine());

            double inch = a * 12.0;
            Console.WriteLine($"\nIt is {inch} inches.");
            Console.ReadLine();
        }
    }
}
