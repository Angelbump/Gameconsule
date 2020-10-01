using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] gameboard = { '0', '0', '0', '0', '0', '0', '0', '0', '0' };

            int pl = 1;
            int blockvalue;

            boarddisplay(gameboard);

            do
            {
                //displaying board
                boarddisplay(gameboard);
                if (pl == 1)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Player 1 turn:");
                    Console.WriteLine("Enter the number of block you want to choose(1-9)");
                    blockvalue = Convert.ToInt32(Console.ReadLine());
                    pl = 2;

                    while (gameboard[blockvalue - 1] != '0')
                    {
                        Console.WriteLine("Block already filled, kindly choose a new block");
                        Console.WriteLine("Enter the number of block you want to choose(1-9)");
                        blockvalue = Convert.ToInt32(Console.ReadLine());
                    }
                    gameboard[blockvalue - 1] = 'X';

                }

                else if (pl == 2)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Player 2 turn:");
                    Console.WriteLine("Enter the number of block you want to choose(1-9)");
                    blockvalue = Convert.ToInt32(Console.ReadLine());
                    pl = 1;

                    while (gameboard[blockvalue - 1] != '0')
                    {
                        Console.WriteLine("Block already filled, kindly choose a new block");
                        Console.WriteLine("Enter the number of block you want to choose(1-9)");
                        blockvalue = Convert.ToInt32(Console.ReadLine());
                    }
                    gameboard[blockvalue - 1] = 'Y';
                }


            } while (checkwin(gameboard) == '0' && isdraw(gameboard) == false);


            boarddisplay(gameboard);
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            if (checkwin(gameboard) == 'X')
            {
                Console.WriteLine("Plater 1 wins..!!");

            }

            else if (checkwin(gameboard) == 'Y')
            {
                Console.WriteLine("Plater 2 wins..!!");

            }

            else
            {
                Console.WriteLine("Game Draw between X and Y");
            }




            Console.ReadLine();
        }

        private static void boarddisplay(char[] board)
        {
            int count = 0;

            Console.Clear();
            for (int i = 0; i < 9; i++)
            {
                Console.Write(board[i]);
                Console.Write("|");

                count++;
                if (count == 3 && i <= 6)
                {


                    Console.WriteLine(" ");
                    Console.WriteLine("------");
                    count = 0;
                }

            }

        }

        private static bool isdraw(char[] board)
        {

            for (int i = 0; i < 9; i++)
            {
                if (board[i] == '0')
                {
                    return false;
                }

            }

            return true;
        }

        private static char checkwin(char[] board)
        {
            // checking horizontally for x player
            if ((board[0] == 'X' && board[1] == 'X' && board[2] == 'X') || (board[3] == 'X' && board[4] == 'X' && board[5] == 'X') || (board[6] == 'X' && board[7] == 'X' && board[8] == 'X'))
            {
                return 'X';
            }

            // checking vertically for x player
            else if ((board[0] == 'X' && board[3] == 'X' && board[6] == 'X') || (board[1] == 'X' && board[4] == 'X' && board[7] == 'X') || (board[2] == 'X' && board[5] == 'X' && board[8] == 'X'))
            {
                return 'X';
            }

            // checking diagonally for x player

            else if ((board[0] == 'X' && board[4] == 'X' && board[8] == 'X') || (board[2] == 'X' && board[4] == 'X' && board[6] == 'X'))
            {
                return 'X';
            }


            // checking horizontally for y player
            if ((board[0] == 'Y' && board[1] == 'Y' && board[2] == 'Y') || (board[3] == 'Y' && board[4] == 'Y' && board[5] == 'Y') || (board[6] == 'Y' && board[7] == 'Y' && board[8] == 'Y'))
            {
                return 'Y';
            }

            // checking vertically for y player
            else if ((board[0] == 'Y' && board[3] == 'Y' && board[6] == 'Y') || (board[1] == 'Y' && board[4] == 'Y' && board[7] == 'Y') || (board[2] == 'Y' && board[5] == 'Y' && board[8] == 'Y'))
            {
                return 'Y';
            }

            // checking diagonally for y player

            else if ((board[0] == 'Y' && board[4] == 'Y' && board[8] == 'Y') || (board[2] == 'Y' && board[4] == 'Y' && board[6] == 'Y'))
            {
                return 'Y';
            }


            return '0';

        }
    }
}
