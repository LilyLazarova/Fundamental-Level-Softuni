//Write a program that converts a string to a sequence of C# Unicode character literals. Examples:
//Input	Output
//Hi!	\u0048\u0069\u0021
//What?!?	\u0057\u0068\u0061\u0074\u003f\u0021\u003f
//SoftUni	\u0053\u006f\u0066\u0074\u0055\u006e\u0069


using System;

class UnicodeCharacters
    {
        static void Main()
        {
            Console.Write("Enter a string you want to convert: ");
            char[] input = Console.ReadLine().ToCharArray();
 
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u{0}",((int)input[i]).ToString("X4").ToLower());         //convert dec value to hex value
            }
            Console.WriteLine();
        }
    }

