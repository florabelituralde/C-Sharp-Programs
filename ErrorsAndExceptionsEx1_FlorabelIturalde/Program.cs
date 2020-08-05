using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
//Class:      ERAU ISTA220 Programming Fundamentals
//Student:    Florabel Ituralde
//Instructor: Cristine E Lee, Instructor
//Date:       24 JUL 2020

/*******************************************************************
This project contains the code to create "Basic Difficulty - Circles, hemispheres, and triangles".
It is a console application that displays on a console window.

Revisions:

Revision Date:

Revised By:
********************************************************************/
namespace ErrorsAndExceptionsEx1_FlorabelIturalde
{
    class Program
    {
        static void Main(string[] args)

        {
            int r = 0;
            int v = 0;

            #region Area and Circumference
            // Part 1 Area and Circumference of Circle
            Console.WriteLine("\nPart 1. circumference and area of a circle.");
            try
            {
                Console.Write("Enter an integer for the radius: ");
                r = Convert.ToInt32(Console.ReadLine());
                while (r <= 0)
                {
                    Console.Write("Please enter a positive integer greater than zero: ");
                    r = Convert.ToInt32(Console.ReadLine());

                }
                    double circumference = 2 * Math.PI * r;
                    double area = Math.PI * (r * r);
                    Console.WriteLine($"\nThe circumference is {circumference}");
                    Console.WriteLine($"The area is {area}");
                    Console.ReadLine();

            }
            //If an exception occurs, the code in the catch block will be run
            catch (Exception e)
            {
                Console.WriteLine("The following error has occured : " + e.Message);
                Console.ReadLine();
            }
            #endregion

            #region Volume of a Hemisphere
            //Part 2 Volume of a Hemisphere
            Console.WriteLine("\nPart 2. volume of a hemisphere");
            try
            {
                Console.Write("Enter an integer for the radius: ");
                v = Convert.ToInt32(Console.ReadLine());

                while (v <= 0)
                {
                    Console.Write("Please enter a number greater than zero: ");
                    v = Convert.ToInt32(Console.ReadLine());
                }
                    double volume = ((4 / 3) * Math.PI * Math.Pow(v, 3.0) / 2);
                    Console.WriteLine($"\nThe volume is {volume}");
                    Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("The following error has occured : " + e.Message);
                Console.ReadLine();
            }

            #endregion

            #region Area of triangle given the length of the sides
            //Part 3 Area of triangle given the length of the sides
            Console.WriteLine("\nPart 3. area of a triangle");
            try
            {
                Console.Write("Enter the value of a: ");
                string aside = Console.ReadLine();
                int a = int.Parse(aside);
                while (a <= 0)
                {
                    Console.Write("Please enter a number greater than zero: ");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Enter the value of b: ");
                string bside = Console.ReadLine();
                int b = int.Parse(bside);
                while (b <= 0)
                {
                    Console.Write("Please enter a number greater than zero: ");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Enter the value of c: ");
                string cside = Console.ReadLine();
                int c = int.Parse(cside);
                while (c <= 0)
                {
                    Console.Write("Please enter a number greater than zero: ");
                    c = Convert.ToInt32(Console.ReadLine());
                }
                double tcircumference = ((a + b + c) / 2);
                double tarea = (Math.Sqrt(tcircumference * (tcircumference - a) * (tcircumference - b) * (tcircumference - c)));
                Console.WriteLine($"The area is {tarea}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("The following error has occured : " + e.Message);

            }
            #endregion
            Console.WriteLine("Please hit enter to exit the application...");
        }
    }
}
