/*

Completing designs for the three games in the Chamber of Design causes the pedestals to light up red again, and another door opens, 
letting you into the final chamber. This chamber has only a single large, broad pedestal. Inscribed on the stone floor in a circle 
around the pedestal are the engraved words,“Only a True Programmer can build object-oriented programs.” More text engraved on the 
pedestal describes what you recognize as the game of Tic-Tac-Toe, stating that in ancient times, inhabitants of the land would use 
this as a Battle of Wits to determine the outcome of political strife. Instead of fighting wars, they would battle it out in a game 
of Tic-Tac-Toe. Your job is to recreate the game of Tic-Tac-Toe, allowing two players to compete against each other. 

The following features are required: 
• Two human players take turns entering their choice using the same keyboard. 
• The players designate which square they want to play in. Hint: You might consider using the number pad as a guide. 
For example, if they enter 7, they have chosen the top left corner of the board. 
• The game should prevent players from choosing squares that are already occupied. If such a move is attempted, the 
player should be told of the problem and given another chance.
• The game must detect when a player wins or when the board is full with no winner (draw/”cat”). 
• When the game is over, the outcome is displayed to the players. 
• The state of the board must be displayed to the player after each play. Hint: One possible way to show the board could be like this:

It is X's turn. 
   | X | 
---+---+--- 
   | O | X 
---+---+--- 
 O |   | 
What square do you want to play in?

Objectives: 
• Build the game of Tic-Tac-Toe as described in the requirements above. Starting with CRC cards is recommended, 
but the goal is to make working software, not CRC cards. 
• Answer this question: How might you modify your completed program if running multiple rounds was a 
requirement (for example, a best-out-of-five series)?


Number pad layout:
 7 | 8 | 9
---+---+--- 
 4 | 5 | 6 
---+---+--- 
 1 | 2 | 3

*/

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
