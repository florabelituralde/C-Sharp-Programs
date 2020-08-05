using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExample2_FlorabelIturalde07202020
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserDetails();
            Console.WriteLine("Press Enter Key to Exit...");
            Console.ReadLine();
        }

        public static void GetUserDetails()
        {
            string name = "Florabel Ituralde";
            int age = 22;
            //Console.WriteLine("Student Name " + name + age);
            //Console.WriteLine("Student Name: " + name + "," + age);
            Console.WriteLine("Student Name: {0}, Age {1}", name, age);
        }
    }
}
