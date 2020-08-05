using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountToTen_FlorabelIturalde07272020
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Counter application!");
            Console.WriteLine("Please hit Enter to start Couting to ten...");
            Console.ReadLine();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Counting.. {i} (Please hit Enter until Ten)");
                Console.ReadLine();
            }

            Console.WriteLine("The application is now done..");
            Console.ReadLine();

        }
    }

    //public class CountToTen
    //{
    //    public void Count()
    //    {
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.WriteLine("Counting.. " + i);
    //        }
    //    }
    //}


}
