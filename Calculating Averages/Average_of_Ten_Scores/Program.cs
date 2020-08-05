using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Class:      ERAU ISTA220 Programming Fundamentals
//Student:    Florabel Ituralde
//Instructor: Cristine E Lee, Instructor
//Date:       12 JUL 2020

/*******************************************************************
This project contains the code to create "Average of Ten Scores".
It is a console application that displays on a console window.

Revisions: 

Revision Date: 

Revised By: 
********************************************************************/

namespace Average_of_Ten_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 0;
            double sum = 0;
            double avg = 0;

            Console.WriteLine("Average of Ten Scores");

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
                avg = sum / 10.0;
            }
            Console.Write("\nThe average is: {0}", avg);
            if (avg >= 94)
            {
                Console.Write("\nThe letter grade is: A+");
            }
            else if (avg >= 90)
            {
                Console.Write("\nThe letter grade is: A-");
            }
            else if (avg >= 87)
            {
                Console.Write("\nThe letter grade is: B+");
            }
            else if (avg >= 83)
            {
                Console.Write("\nThe letter grade is: B");
            }
            else if (avg >= 80)
            {
                Console.Write("\nThe letter grade is: B-");
            }
            else if (avg >= 77)
            {
                Console.Write("\nThe letter grade is: C+");
            }
            else if (avg >= 73)
            {
                Console.Write("\nThe letter grade is: C");
            }
            else if (avg >= 70)
            {
                Console.Write("\nThe letter grade is: C-");
            }
            else if (avg >= 67)
            {
                Console.Write("\nThe letter grade is: D+");
            }
            else if (avg >= 63)
            {
                Console.Write("\nThe letter grade is: D");
            }
            else if (avg >= 60)
            {
                Console.Write("\nThe letter grade is: D-");
            }
            else if (avg >= 0)
            {
                Console.Write("\nThe letter grade is: F");
            }
            Console.ReadLine();
        }
    }
}