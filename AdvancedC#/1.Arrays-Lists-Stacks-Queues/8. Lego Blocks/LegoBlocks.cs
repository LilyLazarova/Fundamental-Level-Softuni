//This problem is from the Java Basics Exam (8 February 2015). You may check your solution here.
//You are given two jagged arrays. Each array represents a Lego block containing integers. Your task is first to reverse the second jagged array and then check if it would fit perfectly in the first jagged array.
 
//The picture above shows exactly what fitting arrays mean. If the arrays fit perfectly you should print out the newly made rectangular matrix. If the arrays do not match (they do not form a rectangular matrix) you should print out the number of cells in the first array and in the second array combined. The examples below should help you understand the assignment better.
//Input
//The first line of the input comes as an integer number n saying how many rows are there in both arrays. Then you have 2 * n lines of numbers separated by whitespace(s). The first n lines are the rows of the first jagged array; the next n lines are the rows of the second jagged array. There might be leading and/or trailing whitespace(s).
//Output
//You should print out the combined matrix in the format:
//[elem, elem, …, elem]
//[elem, elem, …, elem]
//[elem, elem, …, elem]
//If the two arrays do not fit you should print out : The total number of cells is: count
//Constraints
//•	The number n will be in the range [2 … 10].
//•	Time limit: 0.3 sec. Memory limit: 16 MB.
//Examples
//Input	Output
//2
//1 1 1 1 1 1
//2 1 1 3
//1 1
//2 2 2 3	[1, 1, 1, 1, 1, 1, 1, 1]
//[2, 1, 1, 3, 3, 2, 2, 2]
//2
//1 1 1 1 1
//1 1 1
//1
//1 1 1 1 1	The total number of cells is: 14


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Lego_Blocks
{
    class LegoBlocks
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] firstJaggedArray = new int[n][];
            int[][] secondJaggedArray = new int[n][];
            int numberOfCellsInRow = 0;
            int count = 0;
            List<int> cellsInRow = new List<int>();

            //fill in jagged arrays with the input from the console
            for (int i = 0; i < n; i++)
            {
                firstJaggedArray[i] = Console.ReadLine().Split((new char[]{' '}),StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            for (int i = 0; i < n; i++)
            {
                secondJaggedArray[i] = Console.ReadLine().Split((new char[]{' '}), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

           //Add numbers of Cells in row on every row in the List
            for (int i = 0; i < n; i++)
            {
                numberOfCellsInRow = (firstJaggedArray[i].Length) + (secondJaggedArray[i].Length);
                cellsInRow.Add(numberOfCellsInRow);
            }
            //check if the numbers of cells on each roll is equal to other rows --> if "yes" Print the new matrix
            if (cellsInRow.All(x => x == cellsInRow.First()))
            {
                for (int i = 0; i < n; i++)
                {
                    Array.Reverse(secondJaggedArray[i]);
                    Console.Write("[" + string.Join(", ", firstJaggedArray[i]) + ", ");
                    Console.Write(string.Join(", ", secondJaggedArray[i]) + "]");
                    Console.WriteLine();
                }
            }
            else
            {
                count = cellsInRow.Sum();
                Console.WriteLine("The total number of cells is: {0}", count);
            }
        }
    }
}
        //in case not use LINQ to reverse jagged array
        //public static int[][] ReverseSecondJaggedArray(int[][] secondJaggedArray)
        //{
        //    int[][] reversedArray = new int[n][];
        //    //var res = myJaggedArray.Select(a => a.Select(n => 1-n).ToArray()).ToArray();
        //    for (int row = 0; row < secondJaggedArray.GetUpperBound(0); row++)
        //    {
        //        for (int col = 0; col < secondJaggedArray[row].GetUpperBound(0); col++)
        //        {
        //            int temp = secondJaggedArray[row][col];                        
        //                secondJaggedArray[row][col] = 
        //                 secondJaggedArray[row][secondJaggedArray[row].GetUpperBound(0) - col];   
        //                secondJaggedArray[row][secondJaggedArray[row].GetUpperBound(0) - col] =  temp;
        //                reversedArray[row][col] = secondJaggedArray[row][secondJaggedArray[row].GetUpperBound(0) - col];
        //                Console.WriteLine("{0} ", reversedArray[row][col]);
            
        //        }
        //    }
        //    return reversedArray;
        //}
    

