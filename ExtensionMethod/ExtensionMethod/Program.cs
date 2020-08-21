using System;
using Extensions;
//Class:      ERAU ISTA322 Developing ASP.NET Web Apps
//Student:    Florabel Ituralde
//Instructor: Cristine E Lee, Instructor
//Date:       12 AUG 2020

/*******************************************************************
This project contains the code to create "Extension method".
It is a console application that displays on a console window.

Revisions:

Revision Date:

Revised By:
********************************************************************/
namespace ExtensionMethod
{
    class Program
    {
        static void doWork()
        {
            int x = 591;
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"{x} in base {i} is {x.ConvertToBase(i)}");
            }
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
