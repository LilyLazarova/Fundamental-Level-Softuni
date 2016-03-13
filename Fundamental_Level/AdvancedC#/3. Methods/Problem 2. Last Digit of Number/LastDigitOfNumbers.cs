using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Problem_2.Last_Digit_of_Number
{
    class LastDigitOfNumbers
    {
        static void Main(string[] args)
        {
           
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetLastDigitAsWord(number));
            
        }

        private static string GetLastDigitAsWord(int num)
        {
            string[] digitAsWord = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int digit = num % 10;

            return digitAsWord[digit];
        }
    }
}
