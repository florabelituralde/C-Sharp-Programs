using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
//Class:      ERAU ISTA220 Programming Fundamentals
//Student:    Florabel Ituralde
//Instructor: Cristine E Lee, Instructor
//Date:       05 AUG 2020

/*******************************************************************
This project contains the code to create "Individual Work".
It is a console application that displays on a console window.

Revisions:

Revision Date:

Revised By:
********************************************************************/
namespace IndividualWork_FlorabelIturalde08052020
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.CheckBilling(); //This is to pass through the parameters of the Patient's methods
            p.CheckBilling(2, 3);
            p.CheckBilling("Mark", 25);

            Child c = new Child();
            c.CheckBilling();   //Because child class inherited from patient class, it was able to call the Patient class methods
            c.CheckBilling(4, 4);
            c.CheckBilling("Mark", "Long");
            int a = 3;
            int b = 0;

            //All code in the try block will be checked for exceptions
            try
            {
                Console.WriteLine("a divided by b is: " + (a / b));
            }
            //If an exception occurs, the code in the catch block will be run
            catch (Exception e)
            {
                Console.WriteLine("\nAn error occured: "+ e.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Finally code has been executed.");
                Console.ReadLine();
            }
        }
    }
    //This is the Patient Class where we classify different
    //method statements with different parameters
    public class Patient
    {
        public void CheckBilling()
        {
            Console.WriteLine("\nPatient: The billing has been checked.");
        }

        public void CheckBilling(int a, int b)
        {
            Console.WriteLine("Patient: The billing has been checked using two submitted integers.");
        }

        public void CheckBilling(string a, int b)
        {
            Console.WriteLine("Patient: The billing has been checked using a submitted string and integer.");
        }
    }
    //This is the Child Class that inherits from the Patient class
    //therefore getting access into the Patient Class methods
    public class Child : Patient
    {
        public void CheckBilling(string a, string b)
        {
            Console.WriteLine("Child: The billing has been checked using a submitted two strings.");
        }
    }
}
