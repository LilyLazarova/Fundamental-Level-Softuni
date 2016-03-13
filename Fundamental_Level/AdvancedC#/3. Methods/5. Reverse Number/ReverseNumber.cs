//Write a method that reverses the digits of a given floating-point number.
//Sample Code	Input	Output
//    256
//123.45
//0.12	652
//54.321
//21


using System;
using System.Text.RegularExpressions;

namespace _5.Reverse_Number
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            Console.WriteLine(ReverseNumbers(number));
        }

        public static string ReverseNumbers(string number)
        {

            string reverseNumber = string.Empty;
           
            for (int i = number.Length-1; i >=0; i--)
            {
                if (number[i].Equals('-')) //this check for minus in number and if it's minus don't add this symbol to reversed number
                {
                    break;
                } 
                reverseNumber += number[i];
            }
                       
            string pattern = @"\.\d[0]*$"; //pattern that match . followed by 0 (zero or more time)in the end of string.
            string replacement = "";
            Regex reg = new Regex(pattern);
            string result = reg.Replace(reverseNumber, replacement);

            if (reg.IsMatch(reverseNumber))
            {
                return result;
            }
            else
            {
                return reverseNumber;
            }
        }
    }
}
