using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//Class:      ERAU ISTA220 Programming Fundamentals
//Student:    Florabel Ituralde
//Instructor: Cristine E Lee, Instructor
//Date:       31 JUL 2020

/*******************************************************************
This project contains the code to create "Math Application".
It is a console application that displays on a console window.

Revisions: 

Revision Date: 

Revised By: 
********************************************************************/
namespace LAB3D_FlorabelIturalde
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            int c = 0;
            int sum = 0;
            int d = 0;
            int e = 0;
            int subtract = 0;
            int f = 0;
            int g = 0;
            int multiply = 0;
            int h = 0;
            int i = 0;
            int divide = 0;

            Console.WriteLine("Welcome to the Math Application!");
            Console.WriteLine("\nPlease choose which type of mathematical action you would like to proceed:");
            Console.WriteLine("Type 1 for addition");
            Console.WriteLine("Type 2 for subtraction");
            Console.WriteLine("Type 3 for multiplication");
            Console.WriteLine("Type 4 for division");

            Console.Write("\nPlease enter your selection here: ");
            int calculate = Convert.ToInt32(Console.ReadLine());

            switch (calculate)
            {
                #region Addition
                case 1:
                    Console.WriteLine("\nYou chose Addition!");
                    Console.Write("\nPlease type your first integer: ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter your second integer: ");
                    c = Convert.ToInt32(Console.ReadLine());

                    sum = b + c;
                    Console.WriteLine($"\nThe sum of two integers is: {sum}");
                    Console.ReadLine();
                    break;
                #endregion

                #region Subtraction
                case 2:
                    Console.WriteLine("\nYou chose Subtraction!");
                    Console.Write("\nPlease type your first integer: ");
                    d = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter your second integer: ");
                    e = Convert.ToInt32(Console.ReadLine());

                    subtract = d - e;
                    Console.WriteLine($"\nThe difference of two integers is: {subtract}");
                    Console.ReadLine();
                    break;
                #endregion

                #region Multiplication
                case 3:
                    Console.WriteLine("\nYou chose Multiplication!");
                    Console.Write("\nPlease type your first integer: ");
                    f = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter your second integer: ");
                    g = Convert.ToInt32(Console.ReadLine());

                    multiply = f * g;
                    Console.WriteLine($"\nThe product of two integers is: {multiply}");
                    Console.ReadLine();
                    break;
                #endregion

                #region Division
                case 4:
                    Console.WriteLine("\nYou chose Division!");
                    Console.Write("\nPlease type your first integer: ");
                    h = Convert.ToInt32(Console.ReadLine());
                    while (h <= 0)
                    {
                        Console.WriteLine("Please enter an integer greater than 0: ");
                        h = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.Write("Please enter your second integer: ");
                    i = Convert.ToInt32(Console.ReadLine());
                    while (i <= 0)
                    {
                        Console.WriteLine("Please enter an integer greater than 0: ");
                        i = Convert.ToInt32(Console.ReadLine());
                    }

                    divide = h / i;
                    Console.WriteLine($"\nThe quotient of two integers is: {divide}");
                    Console.ReadLine();
                    break;
                #endregion

                #region default
                default:
                    {
                        Console.WriteLine("Thanks for stopping by!");
                        Console.ReadLine();
                        break;
                    }
                #endregion

            }
        }
    }
}
