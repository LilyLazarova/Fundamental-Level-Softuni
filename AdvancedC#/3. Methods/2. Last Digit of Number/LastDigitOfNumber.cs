//Write a method that returns the last digit of a given integer as an English word. Test the method with different input values. Ensure you name the method properly.
//Sample Code	Output
//    two
//four
//nine


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace _2.Last_Digit_of_Number
{
    class LastDigitOfNumber
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            GetLastDigitsAsWord(number);
        }

        private static void GetLastDigitsAsWord(string number)
        {
            switch (number[number.Length-1])
            {
                case '1': Console.WriteLine("one"); break;
                case '2': Console.WriteLine("two"); break;
                case '3': Console.WriteLine("three"); break;
                case '4': Console.WriteLine("four"); break;
                case '5': Console.WriteLine("five"); break;
                case '6': Console.WriteLine("six"); break;
                case '7': Console.WriteLine("seven"); break;
                case '8': Console.WriteLine("eight"); break;
                case '9': Console.WriteLine("nine"); break;
                case '0': Console.WriteLine("zero"); break;
                
                default:
                    break;
            }
        }
        
    }
}
