using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Original Source Code can be found @ 
//http://tech.reboot.pro/showthread.php?tid=3942
//Special Thanks to AceFinity for posting this code for our code review.



namespace TicTacToe
{
    class Program
    {
        const int xOrig = 2;
        const int yOrig = 4;

        const int xStep = 4;
        const int yStep = 2;

        static int[] pos = new int[2];
        static Player[,] board = new Player[3, 3];
        static Player winner = Player.None;

        enum Player
        {
            None = 0,
            P1,
            P2
        }

        static void Main(string[] args)
        {
            Console.CursorSize = 100;
            ConsoleKey playAgain = ConsoleKey.Y;
            while (playAgain == ConsoleKey.Y)
            {
                Player currentPlayer = Player.P1;
                while (!GameOver())
                {
                    GetUserMove(currentPlayer);
                    currentPlayer = currentPlayer == Player.P1 ? Player.P2 : Player.P1;
                }

                DisplayBoard(Player.None);
                Console.SetCursorPosition(0, 13);

                if (winner == Player.None)
                {
                    Console.WriteLine("It was a draw...");
                }
                else
                {
                    Console.WriteLine("The winner is: Player {0}", winner == Player.P1 ? '1' : '2');
                }

                ResetGame();
                Console.WriteLine("Play Again? [Y/N]\n");
                playAgain = Console.ReadKey().Key;
            }
        }

        static void GetUserMove(Player currentPlayer)
        {
            bool validMove = false;
            while (!validMove)
            {
                DisplayBoard(currentPlayer);
                Console.CursorLeft += 2;
                Console.CursorTop -= 8;

                pos[0] = Console.CursorLeft;
                pos[1] = Console.CursorTop;

                ConsoleKey conKey = ConsoleKey.NoName;
                while ((conKey = Console.ReadKey().Key) != ConsoleKey.Enter)
                {
                    DisplayBoard(currentPlayer);
                    switch (conKey)
                    {
                        case ConsoleKey.UpArrow:
                            if (pos[1] == 8 || pos[1] == 6) pos[1] -= 2;
                            break;
                        case ConsoleKey.DownArrow:
                            if (pos[1] < 8) pos[1] += 2;
                            break;
                        case ConsoleKey.LeftArrow:
                            if (pos[0] > 2) pos[0] -= 4;
                            break;
                        case ConsoleKey.RightArrow:
                            if (pos[0] < 10) pos[0] += 4;
                            break;
                    }

                    Console.SetCursorPosition(pos[0], pos[1]);
                }

                int x = (pos[1] - yOrig) / yStep;
                int y = (pos[0] - xOrig) / xStep;
                if (board[x, y] == Player.None)
                {
                    board[x, y] = currentPlayer;
                    validMove = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("That spot already has a marker! Please place your marker elsewhere...");
                    Console.WriteLine("(Press any key to continue...)");
                    Console.ReadKey();
                }
            }
        }

        static void DisplayBoard(Player currentPlayer)
        {
            Console.Clear();
            DisplayInstructions();
            Console.WriteLine("-------------");
            for (int row = 0; row < 3; row++)
            {
                char[] arr = new char[3];
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == Player.None)
                    {
                        arr[col] = ' ';
                    }
                    else
                    {
                        arr[col] = board[row, col] == Player.P1 ? 'X' : 'O';
                    }
                }
                Console.WriteLine("| {0} |", string.Join(" | ", arr));
                Console.WriteLine("-------------");
            }
            Console.WriteLine("\nPlayer {0}'s Turn...", currentPlayer == Player.P1 ? '1' : '2');
        }

        static bool GameOver()
        {
            // Reading order
            bool boardComplete = true;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Player player = Player.None;
                    if ((player = board[row, col]) != Player.None)
                    {
                        // Check row
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (board[row, i] != player)
                                {
                                    break;
                                }
                                else if (i == 2)
                                {
                                    winner = player;
                                    return true;
                                }
                            }
                        }

                        // Check column
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (board[i, col] != player)
                                {
                                    break;
                                }
                                else if (i == 2)
                                {

                                    winner = player;
                                    return true;
                                }
                            }
                        }

                        // Determines whether we should check the diagonals
                        if ((row == 1 && col == 1) || (col != 1 && row != 1))
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (board[i, i] != player)
                                {
                                    break;
                                }
                                else if (i == 2)
                                {
                                    winner = player;
                                    return true;
                                }
                            }

                            for (int i = 2, j = 0; j < 3; i--, j++)
                            {
                                if (board[i, j] != player)
                                {
                                    break;
                                }
                                else if (j == 2)
                                {
                                    winner = player;
                                    return true;
                                }
                            }
                        }
                    }
                    else
                    {
                        boardComplete = false;
                    }
                }
            }

            if (boardComplete)
            {
                return true;
            }
            return false;
        }

        static void ResetGame()
        {
            board = new Player[3, 3];
            winner = Player.None;
        }

        static void DisplayInstructions()
        {
            Console.WriteLine("Note: Use the arrow keys to navigate.\n(Press enter when you want to place your marker.)\n");
        }
    }
}
