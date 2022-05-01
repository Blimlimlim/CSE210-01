// Tic-Tac-Toe Specifications
// Michael Steadman
using System;
using System.Collections.Generic;

namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {   
            userPlay();


        }
        static List<string> createBoard()
            {
                List<string> gameBoard = new List<string>();
                for (int i = 1; i <= 9; i++)
                {
                    gameBoard.Add(i.ToString());
                }
                return gameBoard;
            }
            
            // User input...
        static void userPlay()
            {
                // Create board
                List<string>board = createBoard();
            
                bool isGameover = false;
                int playerUp = 1;

                // users take turns
                while (isGameover == false)
                {
                    // Display board
                    Console.WriteLine(" ");
                    Console.WriteLine($"{board[0]}|{board[1]}|{board[2]} \n-+-+-\n{board[3]}|{board[4]}|{board[5]} \n-+-+-\n{board[6]}|{board[7]}|{board[8]}");
                    Console.WriteLine(" ");
                    // X's go
                    if (playerUp == 1)
                    {
                        Console.Write("Player X's turn. Choose a numbered spot: ");
                    }
                    // Y's go
                    else if (playerUp == 2)
                    {
                        Console.Write("Player O's turn. Choose a numbered spot: ");
                    }
                    // Find which index the user's input corresponds to.
                    string playerchoice = Console.ReadLine();
                    int indexChoice = int.Parse(playerchoice) - 1;
                    // If a player chooses a filled in spot then they choose a different one.
                    while ((board[indexChoice] == "x") ^ (board[indexChoice] == "o"))
                    {
                        Console.Write("That spot has already been filled in. Try another one: ");
                        playerchoice = Console.ReadLine();
                        indexChoice = int.Parse(playerchoice) - 1;
                    }

                    //update board then switch player
                    if (playerUp == 1)
                    {
                        board[indexChoice] = "x";
                        playerUp = 2;
                    }
                    else if (playerUp == 2)
                    {
                        board[indexChoice] = "o";
                        playerUp = 1;
                    }
                    isGameover = endConditions(board);
                }
                Console.Write("Game Over");
            }
                
        static bool endConditions(List<string>board)
            {
                // end conditions
                if ((board[0] == board[1]) && (board[1] == board[2]))
                {
                    whichWon(board, 0);
                    return true;
                }
                else if ((board[3] == board[4]) && (board[4] == board[5]))
                {
                    whichWon(board, 3);
                    return true;
                }
                else if ((board[6] == board[7]) && (board[7] == board[8]))
                {
                    whichWon(board, 6);
                    return true;
                }
                else if ((board[0] == board[3]) && (board[3] == board[6]))
                {
                    whichWon(board, 0);
                    return true;
                }
                else if ((board[1] == board[4]) && (board[4] == board[7]))
                {
                    whichWon(board, 1);
                    return true;
                }
                else if ((board[2] == board[5]) && (board[5] == board[8]))
                {
                    whichWon(board, 2);
                    return true;
                }
                else if ((board[0] == board[4]) && (board[4] == board[8]))
                {
                    whichWon(board, 0);
                    return true;
                }
                else if ((board[2] == board[4]) && (board[4] == board[6]))
                {
                    whichWon(board, 2);
                    return true;
                }
                else if (board[0] != "1" && board[1] != "2" &&board[2] != "3" && board[3] != "4" && board[4] != "5" && board[5] != "6" && board[6] != "7" && board[7] != "8" && board[8] != "9")
                {
                    Console.WriteLine("Cats game");
                    return true;
                }
                else
                {
                    return false;
                }
                
            
            }
        static void whichWon(List<string>board, int i)
        {
            if (board[i] == "x")
            {
                Console.WriteLine("\nX's win!");
            }
            else if (board[i] == "o")
            {
                Console.WriteLine("\nO's win!");
            }
        }
    }
}
