//You are given n numbers. Write a program to find among these numbers all sets of 4 numbers {a, b, c, d}, such that a|b == c|d, where a ≠ b ≠ c ≠ d. Assume that "a|b" means to append the number b after a. We call these numbers {a, b, c, d} stuck numbers: if we append a and b, we get the same result as if we appended c and d. Note that the numbers a, b, c and d should be distinct (a ≠ b ≠ c ≠ d).
//Input
//The input comes from the console. The first line holds the count n. The next line holds n integer numbers, separated by a space. The input numbers will be distinct (no duplicates are allowed).
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//Print at the console all stuck numbers {a, b, c, d} found in the input sequence in format "a|b==c|d" (without any spaces), each at a separate line. The order of the output lines is not important. Print "No" in case no stuck numbers exist among the input sequence of numbers.
//Constraints
//•	The count n will be an integer number in the range [1 … 50].
//•	The input numbers will be distinct integers in the range [0 … 9999].
//•	Time limit: 0.5 sec. Memory limit: 16 MB.
//Examples
//Input	Output		Input	Output		Input	Output
//5
//2 51 1 75 25	2|51==25|1
//25|1==2|51		7
//2 22 23 32 322 222 5	2|322==23|22
//23|22==2|322
//32|22==322|2
//32|222==322|22
//322|2==32|22
//322|22==32|222		3
//5 1 20	No

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _9.Stuck_Numbers
{
    class StuckNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 4)
            {
                Console.WriteLine("No");
                return;
            }

            string[] numbers = Console.ReadLine().Split(' ').ToArray();
                        
            //List<string> combinations = new List<string>();
            GenerateCombination(numbers);
        }

        private static void GenerateCombination(params string[] numbers)
        {
            //string combination;
            //List<string> combinations = new List<string>();
            //List<string> combinationsWithPipe = new List<string>();
            //string combinationWithPipe;
            int count = 0;
           
            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = 0; b < numbers.Length; b++)
                {
                    for (int c = 0; c < numbers.Length; c++)
                    {
                        for (int d = 0; d < numbers.Length; d++)
                        {
                            if (numbers[a] != numbers[b] && 
                                numbers[a] != numbers[c] && 
                                numbers[a] != numbers[d] && 
                                numbers[b] != numbers[c] && 
                                numbers[b] != numbers[d] && 
                                numbers[c] != numbers[d] &&
                                a!=b && a!=c && a!=d && b!=c && b!=d && c !=d)
                            {

                                if (numbers[a]+numbers[b]==numbers[c]+numbers[d])
                                {
                                    Console.WriteLine("{0}|{1}=={2}|{3}", numbers[a], numbers[b], numbers[c], numbers[d]);
                                    count++;
                                }
                                

                                //combination = numbers[c] + numbers[d];
                                //combinations.Add(combination);
                                //combinationWithPipe = numbers[c] + "|" + numbers[d];
                                //combinationsWithPipe.Add(combinationWithPipe);
                            }
                        }  
                    }
                }
            }
            
            //for (int i = 0; i < combinations.Count; i++)
            //{
            //    for (int j = 0; j < combinations.Count; j++)
            //    {
            //        if(i!=j)
            //        if (combinations[j].Equals(combinations[i]))
            //        {
            //            Console.WriteLine("{0}=={1}",combinationsWithPipe[i],combinationsWithPipe[j]);
            //            count++;
            //        }
                   
            //    }
            //}
            if (count==0)
            {
                Console.WriteLine("No");
            }

            //Console.WriteLine(combinations.Count());
        }
    }
}
