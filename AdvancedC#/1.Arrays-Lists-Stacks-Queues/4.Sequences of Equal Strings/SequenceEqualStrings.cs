﻿//Write a program that reads an array of strings and finds in it all sequences of equal elements (comparison should be case-sensitive). The input strings are given as a single line, separated by a space. Examples:
//Input	Output
//hi yes yes yes bye	hi
//yes yes yes
//bye
//SoftUni softUni softuni	SoftUni
//softUni
//softuni
//1 1 2 2 3 3 4 4 5 5	1 1
//2 2
//3 3
//4 4
//5 5
//a b b xxx c c c	a
//b b
//xxx
//c c c
//hi hi hi hi hi	hi hi hi hi hi
//hello	hello


using System;
using System.Linq;

    class SequenceEqualStrings
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < input.Length-1; i++)
            {
                Console.Write("{0} ", input[i]);
                if (input[i] != input[i + 1])
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("{0}",input[input.Length-1]);
        }
    }
