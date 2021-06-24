using System;
using System.Collections.Generic;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
                List<int> fibNums = new List<int>();
                foreach (int n in new int[] { 5, 10, 20 })
                {

                    fibNums.Add(fib(n));

                }

                foreach (int n in fibNums)
                {
                    Console.WriteLine(n);
                }

            

            static int fib(int n)
            {
                if (n == 0)
                {
                    return (0);
                }

                if (n == 1)
                {
                    return (1);
                }

                return (fib(n - 1) + fib(n - 2));
            }

            //# 1: Reverse a string function

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

            //#1 Test
            Console.WriteLine("Reverser Test");
            Console.WriteLine(Reverser("Hello World"));

            Console.WriteLine();
            Console.WriteLine();

            //#2 Test
            Console.WriteLine("Palindrome Test");
            Console.WriteLine(Palindrome("madam"));
            Console.WriteLine(Palindrome("charlie"));
            Console.WriteLine(Palindrome("step on no pets"));

            Console.WriteLine();
            Console.WriteLine();

            //#3 Test
            Console.WriteLine(SentenceReverser("testing taht this is reversed"));
            Console.WriteLine(SentenceReverser("testing another string to see if it's reversed and removes spaces"));

            Console.WriteLine();
            Console.WriteLine();

            //#4 Test
            Console.WriteLine(ReverseWordsIndividually("testing to see if each word is in same order but reversed individually"));
            Console.WriteLine(ReverseWordsIndividually("testing something shorter"));

            Console.WriteLine();
            Console.WriteLine();

            //#5 Test
            CountCharacterOccurence("test");
            CountCharacterOccurence("hello world");

            Console.WriteLine();
            Console.WriteLine();

        }

        //#2
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

        //# 3
        private static string SentenceReverser(string s)
        {
            String reversed_String = "";
            int oldStringLenght = s.Length;

            for (int i = oldStringLenght - 1; i >= 0; i--)
            {
                char temp = s[i];
                if (temp.ToString() == " ")
                {
                    continue;
                }
                else
                {
                    reversed_String += temp;
                }
            }
            return reversed_String;
        }

        //# 4
        private static string ReverseWordsIndividually(string s)
        {
            
            string[] splitSentence = s.Split(" ");
            List<string> newString = new List<string> {};

            foreach (string temp in splitSentence)
            {
                int tempLength = temp.Length;
                string tempString = "";
                for (int i=tempLength - 1; i >= 0; i--) 
                {
                    tempString += temp[i];
                }
                newString.Add(tempString);
            }

            var result = string.Join(" ", newString.ToArray());
            return result;
        }

        //#5 
        private static void CountCharacterOccurence (string s)
        {
            Dictionary<char, int> charDict = new Dictionary<char, int> { };

            foreach (char ch in s)
            {
                if (charDict.ContainsKey(ch))
                {
                    charDict[ch] += 1;
                }
                else
                {
                    charDict[ch] = 1;
                }
            }

            foreach (var i in charDict)
            {
                Console.WriteLine(i.ToString());
            }

        }

        //#6
    }
}
