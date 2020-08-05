using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Class:      ERAU ISTA220 Programming Fundamentals
//Student:    Florabel Ituralde
//Instructor: Cristine E Lee, Instructor
//Date:       27 JUL 2020

/*******************************************************************
This project contains the code to create "Numeric Overflow".
It is a console application that displays on a console window.

Revisions: 

Revision Date: 

Revised By: 
********************************************************************/
namespace ErrorsAndExceptionsEx3_FlorabelIturalde
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int r = 0;
                int v = 0;

                #region Area and Circumference
                // Part 1 Area and Circumference of Circle
                Console.WriteLine("\nPart 1. circumference and area of a circle.");

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
                r = checked(r + 100);

                #endregion

                #region Volume of a Hemisphere
                //Part 2 Volume of a Hemisphere
                Console.WriteLine("\nPart 2. volume of a hemisphere");

                Console.Write("Enter an integer for the radius: ");
                v = Convert.ToInt32(Console.ReadLine());
                v = checked(v + 100);

                while (v <= 0)
                {
                    Console.Write("Please enter a number greater than zero: ");
                    v = Convert.ToInt32(Console.ReadLine());
                }
                double volume = ((4 / 3) * Math.PI * Math.Pow(v, 3.0) / 2);
                Console.WriteLine($"\nThe volume is {volume}");
                Console.ReadLine();

                #endregion

                #region Area of triangle given the length of the sides
                //Part 3 Area of triangle given the length of the sides
                Console.WriteLine("\nPart 3. area of a triangle");

                Console.Write("Enter the value of a: ");
                string aside = Console.ReadLine();
                int a = int.Parse(aside);
                a = checked(a + 100);
                while (a <= 0)
                {
                    Console.Write("Please enter a number greater than zero: ");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Enter the value of b: ");
                string bside = Console.ReadLine();
                int b = int.Parse(bside);
                b = checked(b + 100);
                while (b <= 0)
                {
                    Console.Write("Please enter a number greater than zero: ");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Enter the value of c: ");
                string cside = Console.ReadLine();
                int c = int.Parse(cside);
                c = checked(c + 100);
                while (c <= 0)
                {
                    Console.Write("Please enter a number greater than zero: ");
                    c = Convert.ToInt32(Console.ReadLine());
                }
                double tcircumference = ((a + b + c) / 2);
                double tarea = (Math.Sqrt(tcircumference * (tcircumference - a) * (tcircumference - b) * (tcircumference - c)));
                Console.WriteLine($"\nThe area is {tarea}");
                Console.ReadLine();

                #endregion

                #region Solving Quadratic Equation
                Console.WriteLine("Quadratic Equation Formula Error handling");
                Console.Write("Enter the coefficient for a: ");
                string acoefficient = Console.ReadLine();
                Double aco = float.Parse(acoefficient);
                aco = checked(aco + 100);
                while (aco <= 0)
                {
                    Console.Write("Please enter a value greater than zero: ");
                    aco = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter the coefficient for b: ");
                string bcoefficient = Console.ReadLine();
                Double bco = float.Parse(bcoefficient);
                bco = checked(bco + 100);
                while (bco <= 0)
                {
                    Console.Write("Please enter a value greater than zero: ");
                    bco = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter the coefficient for c: ");
                string ccoefficient = Console.ReadLine();
                Double cco = float.Parse(ccoefficient);
                cco = checked(cco + 100);
                while (cco <= 0)
                {
                    Console.Write("Please enter a value greater than zero: ");
                    cco = int.Parse(Console.ReadLine());
                }

                double posquadratic = (-bco + Math.Sqrt(bco * bco) - 4 * aco * cco) / (2 * aco);
                if (posquadratic < 0)
                {
                    Console.WriteLine("\nThere are no real solutions for positive solution.");
                }
                double negquadratic = (-bco - Math.Sqrt(bco * bco) - 4 * aco * cco) / (2 * aco);
                if (negquadratic < 0)
                {
                    Console.WriteLine("There are no real solutions for negative solution.");
                }
                Console.WriteLine($"\nThe positive solution is {posquadratic}");
                Console.WriteLine($"The negative solution is {negquadratic}");
                Console.ReadLine();
                #endregion

            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Overflow detected:  " + e.ToString());
                Console.ReadLine();
            }
        }
    }
}
