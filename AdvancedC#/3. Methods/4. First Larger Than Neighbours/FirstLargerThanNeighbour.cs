//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1 if there's no such element. Use the method from the previous exercise in order to re.
//Sample Code	Output
//    3
//-1
//-1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Larger_Than_Neighbours;

namespace _4.First_Larger_Than_Neighbours
{
    class FirstLargerThanNeighbour
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers to check the index of first element larger than neighbours : ");
            int[] numbers = Console.ReadLine().Split(new char[] { ' ', ',', '/' }, StringSplitOptions.RemoveEmptyEntries).
                            Select(int.Parse).ToArray();

            Console.WriteLine(GetIndex(numbers));
         }

        private static int GetIndex(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (LargerThanNeighbour.IsLargerThanNeighbour(i, numbers))  //call IsLargerThanNeighbour method from previous Problem 3.
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
