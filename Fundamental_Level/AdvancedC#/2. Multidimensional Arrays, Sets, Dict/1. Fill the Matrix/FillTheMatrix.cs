//Write two programs that fill and print a matrix of size N x N. Filling a matrix in the regular pattern (top to bottom and left to right) is boring. Fill the matrix as described in both patterns below:
//Pattern A	Pattern B
 	 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Fill_the_Matrix
{
    class FillTheMatrix
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of matrix : ");
             int matrixSize = int.Parse(Console.ReadLine());
           
            FillTheMatrixVertically(matrixSize);
            FillTheMatrixSnake(matrixSize);


        }

        private static void FillTheMatrixSnake(int matrixSize)
        {
            int matrixElements = 1;
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int col = 0; col < matrixSize; col++)
            {
                for (int row = 0; row < matrixSize; row++)
                {
                    matrix[col, row] = matrixElements;
                    matrixElements += 1;
                }
            }
            for (int col = 0; col < matrixSize; col++)
            {
                for (int row = 0; row < matrixSize; row++)
                {
                    Console.Write("{0,-4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        private static void FillTheMatrixVertically(int matrixSize)
        {
            int matrixElements = 1;
            int[,] matrix = new int[matrixSize, matrixSize];
            
            for (int col = 0; col < matrixSize; col++)
            {
                if (col % 2 == 0 || col == 0)
                {
                    for (int row = 0; row < matrixSize; row++)
                    {
                        matrix[col, row] = matrixElements;
                        matrixElements += 1;
                    }
                }
                else
                {
                    for (int row = matrixSize - 1; row >= 0; row--)
                    {
                        matrix[col, row] = matrixElements;
                        matrixElements++;
                    }

                }
            }
            for (int col = 0; col < matrixSize; col++)
            {
                for (int row = 0; row < matrixSize; row++)
                {
                    Console.Write("{0,-4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

    }
}
