using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Class:      ERAU ISTA220 Programming Fundamentals
//Student:    Florabel Ituralde
//Instructor: Cristine E Lee, Instructor
//Date:       31 JUL 2020

/*******************************************************************
This project contains the code to create "Write your own program - Tuition".
It is a console application that displays on a console window.

Revisions: 

Revision Date: 

Revised By: 
********************************************************************/
namespace LAB3C_FlorabelIturalde
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will display your tuition in the next 5 years");

            int a = 6000;
            Console.WriteLine($"\nFor year 1 your tuition will be: ${a}");

            double b = 6000 + (6000 * 0.02);
            Console.WriteLine($"For year 2 your tuition will be: ${b}");

            double c = 6000 + (6000 * 0.04);
            Console.WriteLine($"For year 3 your tuition will be: ${c}");

            double d = 6000 + (6000 * 0.06);
            Console.WriteLine($"For year 4 your tuition will be: ${d}");

            double e = 6000 + (6000 * 0.08);
            Console.WriteLine($"For year 5 your tuition will be: ${e}");
            Console.ReadLine();
        }
    }
}
