// tic-tac-toe (0's and X's)

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main()
        {
            // welcome and display instructions
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Instructions instructions = new Instructions();
            instructions.gamePad();

            // create new players and let them choose their marker
            Console.WriteLine("Choose either X or O as your marker!");
            Player player1 = new Player("player1");
            Player player2 = new Player("player2");
            player1.PlayerChoice();
            player2.PlayerChoice();
            Console.Clear();

            // generate new empty board
            Board board = new Board();
            board.InitialBoard();

            // play the game
            int exit = 0;
            bool playerTurn = true;

            while (exit == 0)
            {
                if (playerTurn)
                {
                    Console.WriteLine($"It is {player1.PlayerMarker}'s turn.");
                    board.CurrentBoard();
                    Console.Write("What square do you want to play in? ");
                    string userMove = Console.ReadLine();
                    Console.Clear();
                    if (board.updateBoard(userMove, player1.PlayerMarker))
                    {
                        playerTurn = false;
                        if (board.CheckWin(player1.PlayerMarker))
                        {
                            Console.WriteLine($"{player1.Name} wins! Congratulations, you rock :)");
                            exit = 1;
                        }
                    }
                    else
                        playerTurn = false;
                }
                else
                {
                    Console.WriteLine($"It is {player2.PlayerMarker}'s turn.");
                    board.CurrentBoard();
                    Console.Write("What square do you want to play in? ");
                    string userMove = Console.ReadLine();
                    Console.Clear();
                    if (board.updateBoard(userMove, player2.PlayerMarker))
                    {
                        playerTurn = true;
                        if (board.CheckWin(player2.PlayerMarker))
                        {
                            Console.WriteLine($"{player2.Name} wins! Congratulations, you rock :)");
                            exit = 1;
                        }
                    }
                    else
                        playerTurn = false;
                }
            }

        }

    }
}
