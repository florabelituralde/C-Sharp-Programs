using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Class:      ERAU ISTA220 Programming Fundamentals
//Student:    Florabel Ituralde
//Instructor: Cristine E Lee, Instructor
//Date:       12 JUL 2020

/*******************************************************************
This project contains the code to create "Sum Of Numbers".
It is a console application that displays on a console window.

Revisions: 

Revision Date: 

Revised By: 
********************************************************************/

namespace Sum_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 0;
            double sum = 0;

            Console.WriteLine("Sum of NUmbers");

            Console.WriteLine("\nPlease enter 10 scores between 0 to 100");
            while (i < 10)
            {
                Console.Write("Number {0}: ", (i + 1));
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 100)
                {
                    Console.WriteLine("Please enter a value between 0 to 100");
                    continue;
                }
                else if (n < 0)
                {
                    Console.WriteLine("Please enter a value between 0 to 100");
                    continue;
                }
                i++;
                sum += n;
            }
            Console.Write("\nThe sum of 10 numbers is: {0}", sum);
            Console.ReadLine();
        }
    }
}