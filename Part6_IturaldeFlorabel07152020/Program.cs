using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6_IturaldeFlorabel07152020
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1, number2, product;
            number1 = 12.45F;
            number2 = 10.74F;

            product = number1 * number2;

            Console.WriteLine("{0} * {1} = {2}", number1, number2, product);
            Console.ReadLine();
        }
    }
}
