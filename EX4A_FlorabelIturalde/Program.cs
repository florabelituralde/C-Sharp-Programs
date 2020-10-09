using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //LAMBDA

            // 1) An expression which takes no parameters and evaluates to the string "Hello, World".
            //Correct Answer:
            Func<string> helloWorld = () => "Hello, World!";
            Console.WriteLine(helloWorld());

            // My answer
            string Greet() => "Hello World!";
            Console.WriteLine("\nTakes no parameters and returns Hello World: ");
            Console.WriteLine(Greet());

            //PS. Ive tried it this way but it's giving me an error that says "Cannot Implicitly convert type string to System.Func(string, String) and I'm not sure how to do it.
            // Func<string, string> Greet() => "Hello World!";
            // Console.WriteLine(Greet());

            // 2) An expression which returns an integer, takes a single integer parameter, and adds the integer 1 to it.
            //Correct Answer:
            int Increment(int i) => i + 1;
            Console.WriteLine(Increment(12));

            //My answer
            Func<int, int> func = x => x + 1; //correct
            Console.WriteLine("\nAdding 1 to an integer: ");
            Console.WriteLine(func(11));

            // 3) An expression which returns an integer, takes two integer parameters, and raises the first parameter to the power of the second.

            //My Answer
            Func<int, int, int> value = (x, y) => (int)Math.Pow(x, y); //correct
            Console.WriteLine("\nTaking an integer to the power of the second: ");
            Console.WriteLine(value(3, 7));

            // 4) An expression which returns an integer, takes two integer parameters and sums them.

            //My Answer
            Func<int, int, int> value1 = (x, y) => x + y; // correct
            Console.WriteLine("\nTaking two integer parameters and sums them: ");
            Console.WriteLine(value1(4, 8));

            // 5) An expression which returns a string, takes two strings, and appends the first to the second.
            Func<string, string, string> word = (x, y) => x + y; //correct
            Console.WriteLine("\nAppending two strings: ");
            Console.WriteLine(word("Hello", "World!"));

            // LINQ

            // Declare a list of sequential integers with a method from the Enumerable class.
            var numbers = Enumerable.Range(1, 5);

            // Declare a list of dummy strings.
            var wordNumbers = new List<string> { "one", "two", "three", "four", "five" };

            // 1) Use #2 to add one to a list of integers individually.
            //Correct Answer
            var incrementedInts = numbers.Select(Increment);
            var incrementedInts2 = numbers.Select(i => i + 1);

            //My Answer
            var func1 = new List<int> { 2, 4, 6, 8, 9 };
            foreach (var i in func1)
            {
                Func<int, int, int> func2 = (func1, y) => func1 + 1;
                Console.WriteLine("\nAdding one to a list of integers individually: ");
                Console.WriteLine(func2(i, 1));
            }

            // 2) Use #3 to raise a list of integers to the second power individually.
            // Correct Answer
            var squaredInts = numbers.Select(i => value(i, 2));

            //My Answer
            var power1 = new List<int> { 2, 4, 6, 8, 9 };
            foreach (var n in power1)
            {
                Func<int, int, int> powerFunc = (power1, y) => (int)Math.Pow(power1, 2);
                Console.WriteLine("\nRaising a list of integers to the second power individually: ");
                Console.WriteLine(powerFunc(n, 2));
            }

            // 3) Use #4 to sum a list of integers.
            // Correct Answer
            var sumOfInts = numbers.Aggregate(value1);
            var sumOfInts2 = numbers.Aggregate((a, b) => a + b);

            // My Answer
            var sumList = new List<int> { 2, 4, 6, 8, 9 };
            int sum = sumList.Sum();
            Console.WriteLine("\nSum of the list of integers: ");
            Console.WriteLine(sum);

            // 4) Use #5 to concatenate a list of strings, returning an empty string if given an empty list.
            var concatOfstrings = wordNumbers.Aggregate(word);
            var notAnError = new List<string>().Aggregate("", word);

            // My Answer
            var emptyString = new List<string> { "Hello", "there" };
            foreach (var w in emptyString)
            {
                Console.WriteLine(w);
            }
            Console.ReadLine();

            // 5) Use #3 and a method from the Enumerable class in a new lambda expression which returns an integer,
            // takes two integer parameters (base and times), and which raises the base to its own value times times.
            // Evaluating your function with base of 2 and times of 4 should result in 65536.
            // This is repeated exponentiation, also known as tetration,
            // and is frequently expressed in Knuth's up-arrow notation (Links to an external site.) using double up-arrows.

            //Correct Answer
            Func<int, int, int> tetrate = (@base, times) => Enumerable.Repeat(@base, times)
                .Aggregate(@base, value);

            // I am really lost on this one.
        }
    }
}