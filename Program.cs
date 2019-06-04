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
                    where words.Substring(0,1) == "L"
                    select words;

            foreach (string word in LWords){
                Console.WriteLine($"{word}");
            }
        }
    }
}
