using System;
using System.Collections.Generic;
using System.Linq;

namespace linqedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LWords = from words in fruits
                                         where words.Substring(0, 1) == "L"
                                         select words;

            // foreach (string word in LWords)
            // {
            //     Console.WriteLine($"{word}");
            // }


            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);

            foreach(int number in fourSixMultiples){
                Console.WriteLine($"{number}");
            }
        }
    }
}
