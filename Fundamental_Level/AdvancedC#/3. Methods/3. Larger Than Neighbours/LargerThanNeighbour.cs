//Write a method that checks if the element at given position in a given array of integers is larger than its two neighbours (when such exist).
//Sample Code	Output
//    False
//False
//False
//True
//False
//False
//True


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Larger_Than_Neighbours
{
   public class LargerThanNeighbour
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers to check if a given number is larger than neighbours : ");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number {0} - {1}", numbers[i], IsLargerThanNeighbour(i, numbers));
            }
        }

        public static bool IsLargerThanNeighbour(int i, params int[] numbers)
        {
            bool isLarger;
            if (i == numbers.Length - 1)
            {
                isLarger=numbers[numbers.Length - 1] > numbers[numbers.Length - 2];
            }
            else
            {
                isLarger=numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1];
            }
            return isLarger;
        }
    }
}


