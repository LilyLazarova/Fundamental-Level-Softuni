//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on the console on a single line, separated by comma and space. Use spaces, commas, dots, question marks and exclamation marks as word delimiters. Print only unique palindromes, sorted lexicographically. String comparison should be case-sensitive as shown in the example below.
//Example:
//Input	Output
//Hi,exe? ABBA! Hog fully a string. Bob	a, ABBA, exe


using System;
using System.Collections.Generic;

class Palindromes
    {
        static void Main()
        {
            Console.Write("Please, enter a text to find palindromes:");
            string[] input = Console.ReadLine().Split(new char[] {',',' ','?','.','!'},StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i].ToString();
                bool isPalindrome =IsPalindrome(word);
                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }
            palindromes.Sort();
            foreach (var palindrome in palindromes)
            {
                Console.Write("{0}, ",palindrome);
            }
            Console.WriteLine();
        }
        public static bool IsPalindrome(string word)
        {
            for (int i = 0; i < (word.Length) / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            } 
            return true;
        }
    }

