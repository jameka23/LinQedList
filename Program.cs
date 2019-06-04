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


                                                //      --F I L T E R I N G--
            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);



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

            // Build a collection of these numbers sorted in ascending order
            List<int> nums = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> ascend = from num in nums
                                      orderby num
                                      select num;

                                // --A G G R E G A T I O N  O P E R A T I O N S--
            // Output how many numbers are in this list
            List<int> theNums = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            // Console.WriteLine(theNums.Count);

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            // Console.WriteLine(purchases.Sum());


            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            // Console.WriteLine(prices.Max());


                                    // --P A R T I T I O N  O P E R A T I O N S--
            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            List<int> notSquared = new List<int>();
            
            foreach(int num in wheresSquaredo){
                double checkNumber = Math.Sqrt(num);
                bool squared = checkNumber % 1 == 0;
                if(squared == false){
                    notSquared.Add(num);
                }   
                else{
                    // 81 and 4 should only be printed out here
                    Console.WriteLine($"{num}");
                }
            }

            
        }
    }
}
