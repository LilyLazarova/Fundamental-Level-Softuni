//Write a program to find all increasing sequences inside an array of integers. The integers are given on a single line, separated by a space. Print the sequences in the order of their appearance in the input array, each at a single line. Separate the sequence elements by a space. Find also the longest increasing sequence and print it at the last line. If several sequences have the same longest length, print the left-most of them. Examples:
//Input	Output
//2 3 4 1 50 2 3 4 5	2 3 4
//1 50
//2 3 4 5
//Longest: 2 3 4 5
//8 9 9 9 -1 5 2 3	8 9
//9
//9
//-1 5
//2 3
//Longest: 8 9
//1 2 3 4 5 6 7 8 9	1 2 3 4 5 6 7 8 9
//Longest: 1 2 3 4 5 6 7 8 9
//5 -1 10 20 3 4	5
//-1 10 20
//3 4
//Longest: -1 10 20
//10 9 8 7 6 5 4 3 2 1	10
//9
//8
//7
//6
//5
//4
//3
//2
//1
//Longest: 10


using System;
using System.Collections.Generic;
using System.Linq;


    class LongestIncreasingSeq
    {
        static void Main()
        {

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> longestSequence = new List<int>();
            int counter = 1;
            int maxLengthCounter = 0;

            Console.Write("{0} ", input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] <= input[i - 1])
                {
                    Console.WriteLine();
                    if (counter > maxLengthCounter)
                    {
                        maxLengthCounter = counter;
                        longestSequence.Clear();
                        for (int j = i - maxLengthCounter; j < i; j++)
                        {
                            longestSequence.Add(input[j]);
                        }

                    }
                    counter = 0;
                }
                //below if statement is needed to check if the last element is part of the longest sequence
                if (i == input.Length - 1 && input[input.Length - 1] > input[input.Length - 2])
                {
                    counter++;
                    if (counter > maxLengthCounter)
                    {
                        maxLengthCounter = counter;
                        longestSequence.Clear();
                        for (int j = i - maxLengthCounter + 1; j < i + 1; j++)
                        {
                            longestSequence.Add(input[j]);
                        }
                    }
                }
                Console.Write("{0} ", input[i]);
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("Longest: {0}", string.Join(",", longestSequence));
        }
    }

