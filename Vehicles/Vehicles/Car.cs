using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Class:      ERAU ISTA322 Developing ASP.NET Web Apps
//Student:    Florabel Ituralde
//Instructor: Cristine E Lee, Instructor
//Date:       12 AUG 2020

/*******************************************************************
This project contains the code to create "Hierarchy of classes".
It is a console application that displays on a console window.

Revisions:

Revision Date:

Revised By:
********************************************************************/
namespace Vehicles
{
    class Car : Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }
        public void Brake()
        {
            Console.WriteLine("Braking");
        }
        public override void Drive()
        {
            Console.WriteLine("Motoring");
        }
    }
}
