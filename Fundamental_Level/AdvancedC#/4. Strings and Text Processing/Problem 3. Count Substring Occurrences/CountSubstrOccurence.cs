//Write a program to find how many times a given string appears in a given text as substring. The text is given at the first input line. The search string is given at the second input line. The output is an integer number. Please ignore the character casing. Overlapping between occurrences is allowed. Examples:
//Input	Output
//Welcome to the Software University (SoftUni)! Welcome to programming. Programming is wellness for developers, said Maxwell.
//wel	4

//aaaaaa
//aa	5
//ababa caba
//aba	3
//Welcome to SoftUni
//Java	0


using System;

class CountSubstrOccurence
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a string:");
            string input = Console.ReadLine();
            Console.Write("Please, enter a search string:");
            string searchString = Console.ReadLine();
            int counter = 0;
            int index=0;

            do
            {
                index = input.IndexOf(searchString,index,StringComparison.OrdinalIgnoreCase);
                if (index != -1)
                {
                    index++;
                    counter++;
                }
            }
            while (index != -1);
            Console.WriteLine(counter);
        }
    }

