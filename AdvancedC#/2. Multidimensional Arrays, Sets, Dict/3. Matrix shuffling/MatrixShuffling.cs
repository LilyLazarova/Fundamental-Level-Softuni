//Write a program which reads a string matrix from the console and performs certain operations with its elements. User input is provided in a similar way like in the problem above – first you read the dimensions and then the data. Remember, you are not required to do this step first, you may add this functionality later.  
//Your program should then receive commands in format: "swap row1 col1 row2c col2" where row1, row2, col1, col2 are coordinates in the matrix. In order for a command to be valid, it should start with the "swap" keyword along with four valid coordinates (no more, no less). You should swap the values at the given coordinates (cell [row1, col1] with cell [row2, col2]) and print the matrix at each step (thus you'll be able to check if the operation was performed correctly). 
//If the command is not valid (doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist), print "Invalid input!" and move on to the next command. Your program should finish when the string "END" is entered. Examples:
//Input	Output
//2
//3
//1
//2
//3
//4
//5
//6
//swap 0 0 1 1
//swap 10 9 8 7
//swap 0 1 1 0
//END	(after swapping 1 and 5):
//5 2 3
//4 1 6
//Invalid input!
//(after swapping 2 and 4):
//5 4 3
//2 1 6
//1
//2
//Hello
//World
//0 0 0 1
//swap 0 0 0 1
//swap 0 1 0 0
//END	Invalid input
//World Hello
//Hello World


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Matrix_shuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args) 
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, cols];

            //fill in the matrix

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            string[] commands = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            string temp;
            int currentRow;
            int currentCol;
            int swappedRow;
            int swappedCols;
            
                do
                {
                    if (commands[0]=="swap" && 
                        commands.Length==5)
                    {
                        currentRow = int.Parse(commands[1]);
                        currentCol = int.Parse(commands[2]);
                        swappedRow = int.Parse(commands[3]);
                        swappedCols = int.Parse(commands[4]);
                        if (currentRow>=0 && currentCol>=0 && swappedRow>=0 && swappedCols>=0 &&
                            currentRow < rows && currentCol < cols && swappedRow < rows && swappedCols <cols)
	                    {
                            //swap 

                            temp = matrix[currentRow, currentCol];
                            matrix[currentRow, currentCol] = matrix[swappedRow, swappedCols];
                            matrix[swappedRow, swappedCols] = temp;

                            //print
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    Console.Write("{0,2} ", matrix[row, col]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
	                    }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    
                    commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    } 
                while (commands[0]!="END");
        }
    }
}
