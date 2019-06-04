using System;
using System.Collections.Generic;
using System.Linq;

namespace linqedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //      -- R E S T R I C T I O N S --
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LWords = from words in fruits
                                         where words.Substring(0, 1) == "L"
                                         select words;

            // foreach (string word in LWords)
            // {
            //     Console.WriteLine($"{word}");
            // }

            //      --F I L T E R I N G--
            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);

            // foreach(int number in fourSixMultiples){
            //     Console.WriteLine($"{number}");
            // }



            // --O R D E R I N G   O P E R A T I O N S --
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            IEnumerable<string> descend = from name in names 
                        orderby name descending
                        select name;

            // List<string> descend =;
            foreach(string theName in descend){
                Console.WriteLine($"{theName}");
            }
        }
    }
}
