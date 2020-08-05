using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
//Class:      ERAU ISTA220 Programming Fundamentals
//Student:    Florabel Ituralde
//Instructor: Cristine E Lee, Instructor
//Date:       22 JUL 2020

/*******************************************************************
This project contains the code to create "Method that takes User's input".
It is a console application that displays on a console window.

Revisions: I polished the codes calling method

Revision Date: 22 JUL 2020

Revised By: Florabel Ituralde
********************************************************************/
namespace MethodName_FlorabelIturalde07222020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please hit Enter to Start...");

            Username f = new Username();
            string fname = f.first(Console.ReadLine());

            Console.WriteLine("\nPlease hit enter to enter your lastname");

            Username l = new Username();
            string lname = l.last(Console.ReadLine());

            Console.WriteLine("Your full name is {0} {1}", fname, lname);
            Console.ReadLine();



        }
        public class Username
        {
            public string first(string a)
            {
                Console.Write("Please enter your firstname here: ");
                return Console.ReadLine();
            }
            public string last(string a)
            {
                Console.Write("Please enter your lastname here: ");
                return Console.ReadLine();
            }
        }
    }
}
