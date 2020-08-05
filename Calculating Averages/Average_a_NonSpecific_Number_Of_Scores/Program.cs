﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Class:      ERAU ISTA220 Programming Fundamentals
//Student:    Florabel Ituralde
//Instructor: Cristine E Lee, Instructor
//Date:       12 JUL 2020

/*******************************************************************
This project contains the code to create "Average a non-specific Number Of Scores".
It is a console application that displays on a console window.

Revisions: 

Revision Date: 

Revised By: 
********************************************************************/

namespace Average_a_NonSpecific_Number_Of_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 0;
            double t = 0;
            double sum = 0;
            double avg = 0;

            Console.WriteLine("Average a non-specific Number of Scores");

            Console.Write("\nPlease specify the Number Of Tests: ");
            t = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter your test scores here \n");
            while (i < t)
            {
                Console.Write("Test-Score {0}: ", (i + 1));
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
                avg = sum / t;
            }
            Console.Write("\nThe total number of Tests is: {0}", t);
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