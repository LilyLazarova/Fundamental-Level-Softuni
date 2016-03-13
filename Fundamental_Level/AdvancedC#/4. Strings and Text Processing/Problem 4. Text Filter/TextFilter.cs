//Write a program that takes a text and a string of banned words. All words included in the ban list should be replaced with asterisks "*", equal to the word's length. The entries in the ban list will be separated by a comma and space ", ".
//The ban list should be entered on the first input line and the text on the second input line. Example:
//Input	Output
//Linux, Windows
//It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client	It is not *****, it is GNU/*****. ***** is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/*****! Sincerely, a ******* client

using System;

class TextFilter
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter the list with banned word, separated by comma:");
            string[] bannedWords = Console.ReadLine().Split(new char[] {',',' '},StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Please, enter a text:");
            string text = Console.ReadLine();
            int index = 0;
            

            for (int i = 0; i < bannedWords.Length; i++)
            {
                do{
                    index = text.IndexOf(bannedWords[i], index, StringComparison.OrdinalIgnoreCase);
                    if (index!=-1)
                    {
                        string asterix= new string('*',bannedWords[i].Length);
                        text = text.Replace(bannedWords[i], asterix);
                        index += bannedWords[i].Length;
                        Console.WriteLine();
                    }
                  }
                while (index!=-1);
                index = 0;
            }
            Console.WriteLine(text);
        }
    }

