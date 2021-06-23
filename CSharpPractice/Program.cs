using System;
using System.Collections.Generic;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //    List<int> fibNums = new List<int>();
            //    foreach (int n in new int[] { 5, 10, 20 })
            //    {

            //        fibNums.Add(fib(n));

            //    }

            //    foreach (int n in fibNums)
            //    {
            //        Console.WriteLine(n);
            //    }

            //}

            //static int fib(int n)
            //{
            //    if (n == 0)
            //    {
            //        return (0);
            //    }

            //    if (n == 1)
            //    {
            //        return (1);
            //    }

            //    return (fib(n - 1) + fib(n - 2));
            //}

            //Reverse a string function

            static string Reverser(string str)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("---------------");
                Console.WriteLine("Input word: " + str);
                int arrayLength = str.Length;
                string newString = "";

                for (int i = arrayLength-1; i >= 0; i--)
                {
                    newString += str[i];
                }
                return newString;
            }


            Console.WriteLine("Reverser Test");
            Console.WriteLine(Reverser("Hello World"));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Palindrome Test");
            Console.WriteLine(Palindrome("madam"));
            Console.WriteLine(Palindrome("charlie"));
            Console.WriteLine(Palindrome("step on no pets"));

            Console.WriteLine();
            Console.WriteLine();


        }

        private static string Palindrome(string v)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("---------------");
            Console.WriteLine("Input word: " + v);
            int vLength = v.Length;
            string testString = "";

            for (int i = vLength - 1; i >=0; i--)
            {
                testString += v[i];
            }

            return (v == testString ? "Palindrome" : "Not Palindrome");
        }

        //private static string SentenceReverser(string s)
        //{
        //    string[] words = s.Split(" ");
        //    int numOfWords = words.Length - 1;

        //    foreach (numOfWords; numOfWords >= 0; numOfWords--) {
        //        Console.WriteLine();
        //    }
        //    return "";
        //}
    }
}
