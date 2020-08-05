using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
//Class:      ERAU ISTA220 Programming Fundamentals
//Student:    Florabel Ituralde
//Instructor: Cristine E Lee, Instructor
//Date:       22 JUL 2020

/*******************************************************************
This project contains the code to create "Rectangle Area".
It is a console application that displays on a console window.

Revisions: 

Revision Date: 

Revised By: 
********************************************************************/

namespace RectangleMethod_FlorabelIturalde07222020
{
    class Program
    {


        static void Main(string[] args)
        {
            //double getwidth;

            //rectangle a = new rectangle;
            //a.getwidth(Console.Write("Enter the value for width: "));


            Console.WriteLine("Area of a Rectangle");
            Console.Write("Enter the value of width: ");
            string width = Console.ReadLine();
            int w = int.Parse(width);
            Console.Write("Enter the value of length: ");
            string length = Console.ReadLine();
            int l = int.Parse(length);
            Console.Write("Enter the value of height: ");
            string height = Console.ReadLine();
            int h = int.Parse(height);
            double area = (l * w * h);
            Console.WriteLine($"The area is {area}");
            Console.ReadLine();

        }

        //public class rectangle
        //{
        //    public void getwidth(int a)
        //    {
        //        Console.Write("Enter the value of width: ");
        //        string width = Console.ReadLine();
        //        int w = int.Parse(width);
        //    }
        //    public void getlength(int a)
        //    {
        //        Console.Write("Enter the value of length: ");
        //        string length = Console.ReadLine();
        //        int l = int.Parse(length);
        //    }
        //    public void getheight(int a)
        //    {
        //        Console.Write("Enter the value of height: ");
        //        string height = Console.ReadLine();
        //        int h = int.Parse(height);
        //    }
            //public void getarea(int a)
            //{
            //    double area = (l * w * h);
            //    Console.WriteLine($"The area is {area}");
            //    Console.ReadLine();
            //}

    }
}
