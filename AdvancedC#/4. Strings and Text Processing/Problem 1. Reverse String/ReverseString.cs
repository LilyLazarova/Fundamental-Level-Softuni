//Write a program that reads a string from the console, reverses it and prints the result back at the console.
//Input	Output
//sample	elpmas
//24tvcoi92	29iocvt42


using System;

    class ReverseString
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);

            foreach (var item in input)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }

