using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Class:      ERAU ISTA220 Programming Fundamentals
//Student:    Florabel Ituralde
//Instructor: Cristine E Lee, Instructor
//Date:       29 JUL 2020

/*******************************************************************
This project contains the code to create "Case...Switch statements".
It is a console application that displays on a console window.

Revisions: 

Revision Date: 

Revised By: 
********************************************************************/
namespace CaseSwitch_FlorabelIturalde
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Is the value of x greater than or equal to 0?"); //Headline statement
            int x = 0;

            switch (x)
            {
                case 0:
                    Console.WriteLine("The value of x is equals to 0.");
                    Console.ReadLine();
                    break;

                case 1:
                    Console.WriteLine("\nThe value of x is greater than 0.");
                    Console.ReadLine();
                    break;

                case -1:
                    Console.WriteLine("\nThe value of x is less than 0.");
                    Console.ReadLine();
                    break;

                default:
                    break;
            }
        }
    
    }
}
