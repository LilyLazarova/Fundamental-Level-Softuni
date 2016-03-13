//Write a program to sort an array of numbers and then print them back on the console. The numbers should be entered from the console on a single line, separated by a space. Refer to the examples for problem 1.
//Note: Do not use the built-in sorting method, you should write your own. Use the selection sort algorithm. 
//Hint: To understand the sorting process better you may use a visual aid, e.g. Visualgo.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sort_Array_of_Numbers_by_Selection_Sort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers on a single line, separated by a space:");

            // use tryParse to check if the user is not entered letters --> with a null value corresponding to each invalid substring
            double?[] numbers = Console.ReadLine().Split(' ',',',';',':')
                                                  .Select(x=> {
                                                                double value;
                                                                return double.TryParse(x, out value) ? value : (double?)null;
                                                               })
                                                  .ToArray();
           
            double? minValue = numbers[0];
            int position = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                minValue = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < minValue)
                    {
                        minValue = numbers[j];
                        position = j;
                     }
                }

                if (minValue != numbers[i])
                {
                    numbers[position] = numbers[i];
                    numbers[i] = minValue;
                    minValue=numbers[position];
                }
            }
            Console.WriteLine("Sorted Numbers :");
            foreach (var number in numbers)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}
