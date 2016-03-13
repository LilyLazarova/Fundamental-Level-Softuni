//Write a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. 
//On the first line, you will receive the rows N and columns M. On the next N lines you will receive each row with its columns.
//Print the elements of the 3 x 3 square as a matrix, along with their sum.
//Input	Matrix	Output
//4 5
//1 5 5 2 4
//2 1 4 14 3
//3 7 11 2 8
//4 8 12 16 4	 	Sum = 75
//1 4 14
//7 11 2
//8 12 16


using System;
using System.Linq;

namespace _2.Maximal_Sum
{
    class MaximumSum
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter numbers of rows and cols of the matrix separated by empty space:");
            int[] dimentions = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[dimentions[0],dimentions[1]];
            int[] rowsMatrix = new int[matrix.GetLength(0)];
            Console.WriteLine("Enter the numbers that the matrix contains depending of the rows and cols:");

            //Fill in the matrix
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                rowsMatrix = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowsMatrix[j];
                }                
            }

            //Search for maximum sum of elements in square 3x3
            int maxRow = 0;
            int maxCol = 0;
            int maxSum = int.MinValue;
            int sum = maxSum;
            
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    //check the elements in the square(3x3)

                    for (int i = row; i < row+3; i++)
			        {
			            for (int j = col; j < col+3; j++)
			            {
                            sum += matrix[i, j];
			            }
			        }
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    } sum = 0;                 
                }
            }

            //Print the results

            Console.WriteLine("Sum = {0}", maxSum);

            for (int i = maxRow; i < maxRow+3; i++)
            {
                for (int j = maxCol ; j < maxCol+3; j++)
                {
                    Console.Write("{0,-4}", matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
