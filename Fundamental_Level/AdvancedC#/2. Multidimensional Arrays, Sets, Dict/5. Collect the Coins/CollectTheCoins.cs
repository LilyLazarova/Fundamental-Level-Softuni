//You receive the layout of a board from the console. Assume it will always have 4 rows which you'll get as strings, each on a separate line. Each character in the strings will represent a cell on the board. Note that the strings may be of different length.
//You are the player and start at the top-left corner (that would be position [0, 0] on the board). On the fifth line of input you'll receive a string with movement commands which tell you where to go next, it will contain only these four characters – '>' (move right), '<' (move left), '^' (move up) and 'v' (move down). 
//You need to keep track of two types of events – collecting coins (represented by the symbol '$', of course) and hitting the walls of the board (when the player tries to move off the board to invalid coordinates). When all moves are over, print the amount of money collected and the number of walls hit. Example:
//Input	Output	Comments
//Sj0u$hbc
//$87yihc87
//Ewg3444
//$4$$
//V>>^^>>>VVV<<	Coins collected: 2
//Walls hit: 2	Starting from (0, 0), move down (coin), twice right, up, up again (wall), three times right (coin on second move), twice down, down again (wall), twice to the left – game over (no more moves). Total of two coins collected and two walls hit in the process.


using System;

namespace Problem_5.Collect_the_Coins
{
    class CollectTheCoins
    {
        static void Main(string[] args)
        {

            char[][] board = new char[4][];
            
            for (int i = 0; i < 4; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                board[i]= new char[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    board[i][j] = input[j];
                }
            }
            string command = Console.ReadLine();

            int currentRow = 0;
            int currentCol = 0;
            int moneyCounter = 0;
            int wallCounter = 0;

            for (int i = 0; i < command.Length; i++)
            {
                switch (command[i])
                {
                    case 'V':
                        if (currentRow+1<4 && currentCol<board[currentRow+1].Length)
                        {
                            currentRow++;
                            if (board[currentRow][currentCol] == '$')
                            {
                                moneyCounter++;
                            }
                        }
                        else
                        {
                            wallCounter++;
                        }
                        break;
                    case '>':
                        if (currentCol+1< board[currentRow].Length)
                        {
                            currentCol++;
                            if (board[currentRow][currentCol] == '$')
                            {
                                moneyCounter++;
                            }
                        }
                        else
                        {
                            wallCounter++;
                        }break;

                    case '<':
                        if (currentCol-1>=0)
                        {
                            currentCol--;
                            if (board[currentRow][currentCol] == '$')
                            {
                                moneyCounter++;
                            }
                        }
                        else
                        {
                            wallCounter++;
                        }break;

                    case '^':
                        if (currentRow - 1 >= 0 && currentCol < board[currentRow -1].Length)
                        {
                            currentRow--;
                            if (board[currentRow][currentCol] == '$')
                            {
                                moneyCounter++;
                            }
                        }
                        else
                        {
                            wallCounter++;
                        }break;
                    default: if (command[i]!='<' || command[i]!='>'|| command[i]!='V'||command[i]!='^')
                        {
                            Console.WriteLine("You enter a wrong command");
                        }break;
                }
            }
            Console.WriteLine("Coins collected: {0}",moneyCounter);
            Console.WriteLine("Walls hit: {0}",wallCounter);
        }
    }
}
