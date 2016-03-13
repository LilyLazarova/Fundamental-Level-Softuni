//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. Examples:
//Matrix	Output		Matrix	Output
//    ha, ha, ha		 	s, s, s



// HAVE TO BE FIXED !!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sequence_in_Matrix
{
    class SequenceInMatrix
    {
        static void Main(string[] args)
        {
            int rows = 3;//int.Parse(Console.ReadLine());
            int cols = 3; //int.Parse(Console.ReadLine());
            string[,] matrix =  { 
                {"s","q","s"},
                {"mi","s","s"},
                {"s","mi","m"}

            };//[rows,cols];
            int longestLine=1;
            int longestColumn=1;
            int longestRightDiagonal=1;
            int longestLeftDiagonal = 1;
            List<int> maxDimention = new List<int>();
            int maxSequence = 1;
            string maxValue = "";
            string currentLongestString="";
           
            
            //Fill in the matrix

            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        matrix[row, col] = Console.ReadLine();
            //    }
            //}

            //search in the matrix

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    //check row
                   while (col<cols-1 && matrix[row,col]==matrix[row,col+1])
                    {
                        longestLine++;
                        currentLongestString = matrix[row, col];
                        col++;
                    }
                   maxDimention.Add(longestLine);
                    //check col
                    while (row<rows-1 && matrix[row,col]==matrix[row+1,col])
                    {
                        longestColumn++;
                        currentLongestString = matrix[row, col];
                        row++;
                    }
                    maxDimention.Add(longestColumn);

                    //check right diagonal
                    while (row < rows-1 && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                            longestRightDiagonal++;
                            currentLongestString = matrix[row, col];
                            row++;
                            col++; 
                    }

                    maxDimention.Add(longestRightDiagonal);

                    //check left diagonal
                    while (col>0 && row<rows-1 && matrix[row,col]==matrix[row+1,col-1])
                    {
                        longestLeftDiagonal++;
                        currentLongestString = matrix[row, col];
                        row++;
                        col--;
                    }
                    maxDimention.Add(longestLeftDiagonal);
                    maxSequence = maxDimention.Max();
                    maxValue = currentLongestString;

                }
                longestColumn=1;
                longestLine=1;
                longestLeftDiagonal=1;
                longestRightDiagonal=1;
                currentLongestString="";
            }
            
            for (int i = 0; i < maxSequence; i++)
            {

                Console.Write("{0}, ", maxValue);
            }
            Console.WriteLine();
            
        }
    }
}
