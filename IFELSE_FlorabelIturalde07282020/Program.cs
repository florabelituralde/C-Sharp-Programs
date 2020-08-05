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
This project contains the code to create "If...Else statements".
It is a console application that displays on a console window.

Revisions: 

Revision Date: 

Revised By: 
********************************************************************/
namespace IFELSE_FlorabelIturalde07282020
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 0; //Declaring the avriable X

            Console.WriteLine("Is the value of x greater than or equal to 0?"); //Headline statement
            Console.Write("Please enter any integer: "); //User input of integer x
            x = Convert.ToInt32(Console.ReadLine()); // Conversion of user input from string to int32

            if (x > 0) //Whether to find out if user input for x is greater than 0
            {
                Console.WriteLine("\nThe value of x is greater than 0.");
                Console.ReadLine();
            }
            else if (x == 0) //Whether to find out if user input for x is equals to 0
            {
                Console.WriteLine("\nThe value of x is equals to 0.");
                Console.ReadLine(); 
            }
            else if (x < 0) //Whether to find out if user input for x is less than 0
            {
                Console.WriteLine("\nThe value of x is less than 0.");
                Console.ReadLine();
            }
        }
    }
}
