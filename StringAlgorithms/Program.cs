using System;

namespace StringAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insert any sentence in your mind: \n");
            string sentence = Console.ReadLine();

            StringAlgorithms stringAlgorithms = new StringAlgorithms();

            Console.WriteLine("Reversed with While Loop: " + stringAlgorithms.ReverseSentenceWithWhileLoop(sentence),"\n");
            Console.WriteLine("Reversed with For Loop: " + stringAlgorithms.ReverseSentenceWithForLoop(sentence), "\n");
            Console.WriteLine("Reverse Words with While Loop: " + stringAlgorithms.ReverseWordsWithWhileLoop(sentence), "\n");
            Console.WriteLine("Reverse Words with For Loop: " + stringAlgorithms.ReverseWordsWithForLoop(sentence), "\n");

            Console.ReadLine();

        }

        public class StringAlgorithms
        {
            public string ReverseSentenceWithWhileLoop(string body)
            {
                string reverse = "";
                int stringLength = body.Length - 1;

                while (stringLength >= 0)
                {
                    reverse = reverse + body[stringLength];
                    stringLength--;
                }

                return reverse;
            }

            public string ReverseSentenceWithForLoop(string body)
            {
                string reverse = " ";

                for (int i = body.Length - 1; i > - 1; i--)
                {
                    reverse = reverse + body[i];
                }

                return reverse;
            }

            public string ReverseWordsWithWhileLoop(string body)
            {
                string reverse = "";
                string[] splitWords = body.Split(' ');
                int stringLength = splitWords.Length - 1;

                while( stringLength >= 0)
                {
                    reverse = reverse + splitWords[stringLength] + " ";
                    stringLength--;
                }

                return reverse;
            }

            public string ReverseWordsWithForLoop(string body)
            {
                string reverse = "";
                string[] splitWords = body.Split(' ');

                for (int i = splitWords.Length - 1; i > -1; i--)
                {
                    reverse = reverse + splitWords[i] + " ";
                }

                return reverse;
            }
        }
    }
}
