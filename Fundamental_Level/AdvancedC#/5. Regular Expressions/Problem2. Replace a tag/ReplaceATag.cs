using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem2.Replace_a_tag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"<a\shref=[""|'']http\:\/{2}(\w+\.\w+)[""|'']\>(\w+)<\/a> ";
            string replace = @"\[URL\shref=http\:\/{2}\1]\2\[\/URL]";
            Regex regex = new Regex(pattern);

            Console.WriteLine(regex.Replace(input,replace"$1"));


        }
    }
}
