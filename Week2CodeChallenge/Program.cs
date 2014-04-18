using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {


            TextStats("Coding is super fun and useful");



            LetterCounter("i", "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter("n", "Never gonna give you up. Never gonna let you down.");
            LetterCounter("s", "Sally sells seashells down by the seashore. She's from Sussex.");
            for (var i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }

            Console.ReadKey();

        }
        // declaring function for fizzbuzz
        static void FizzBuzz(int number)
        {
            for (var i = 0; i <= 1; i++)
            // declaring variable to end number to write out all of them
            {
                // declaring my if statements
                if (number % 5 == 0 && number % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(number);
                }

            }


        }

        static void LetterCounter(string letter, string inString)
        {

            int LetterUpper = 0;
            int LetterLower = 0;
            int LetterTotal = 0;
            var LetterUppers = letter.ToUpper();
            var LetterLowers = letter.ToLower();


            for (int i = 0; i < inString.Length; i++)
            {
                if (inString[i].ToString() == LetterUppers)
                {
                    LetterUpper++;
                    LetterTotal++;
                }
                else if (inString[i].ToString() == LetterLowers)
                {
                    LetterLower++;
                    LetterTotal++;
                }

            }


            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase " + LetterLower + " s found");
            Console.WriteLine("Number of Uppercase " + LetterUpper + " s found");
            Console.WriteLine("Total Number of " + LetterTotal + " s found");

        }

        static void TextStats(string input)
        {
            Console.WriteLine("# of characters: " + input.Length);
            string[] array = input.Split(' ');
            Console.WriteLine("# of words: " + array.Length);

            var vowel = 0;
            var consonants = 0;
            var specialChars = 0;
            var longWord = "coding";
            var shortWord = "is";



            for (var i = 0; i < input.Length; i++)
            {
                var c = input[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y')
                {
                    vowel += 1;
                }
                else if (c == '.' || c == ',' || c == '!' || c == '?' || c == ' ')
                {
                    specialChars += 1;
                }
                else if (longWord == "coding")
                {
                    Console.WriteLine("yay you did it");
                }
                else if (shortWord == "is")
                {
                    Console.WriteLine("either way you did it!");
                }
                else 
                {
                    consonants += 1;
                }
           }
        
           
            Console.WriteLine("# of Vowels: " + vowel);
            Console.WriteLine("# of consanants: " + consonants);
            Console.WriteLine("# of specialChars: " + specialChars);
            Console.WriteLine("Longest Word: " + longWord);
            Console.WriteLine("Shortest Word: " + shortWord);
            Console.WriteLine("# of characters: " + input.Length);
        
        }
    }
}

