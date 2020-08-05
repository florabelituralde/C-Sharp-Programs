using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExample1_FlorabelIturalde07202020
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            string result = p.GetUserDetails("Florabel Ituralde", 22);
            Console.WriteLine(result);
            Console.WriteLine("Press Enter Key To Exit...");
            Console.ReadLine();
        }

        public string GetUserDetails(string name, int age)
        {
            string info = string.Format("Name:{0}, Age:{1}", name, age);
            return info;
        }
    }
}
