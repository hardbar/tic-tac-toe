// board library

namespace Tic_Tac_Toe
{
    internal class Board
    {
        // fields / properties
        public string Square7 { get; set; } = " ";
        public string Square8 { get; set; } = " ";
        public string Square9 { get; set; } = " ";
        public string Square4 { get; set; } = " ";
        public string Square5 { get; set; } = " ";
        public string Square6 { get; set; } = " ";
        public string Square1 { get; set; } = " ";
        public string Square2 { get; set; } = " ";
        public string Square3 { get; set; } = " ";
        public int Count { get; set; } = 0; // to keep track of the number of used spaces on the board --> to check for draws

        //constructor
        public Board() { }

        /// <summary>
        /// Draws the initial board and defines the board's structure
        /// </summary>
        /// <returns>The current board</returns>
        public string CurrentBoard()
        {
            return ($" {Square7} | {Square8} | {Square9} \n---+---+---\n {Square4} | {Square5} | {Square6} \n---+---+---\n {Square1} | {Square2} | {Square3} \n");
        }

        /// <summary>
        /// Prints the initial board to the screen
        /// </summary>
        public void InitialBoard()
        {
            Console.WriteLine(CurrentBoard());
        }

        /// <summary>
        /// Updates the board when a player selects a square using a switch block
        /// </summary>
        /// <param name="userMove"></param>
        /// <param name="playerMarker"></param>
        /// <returns>Updated board</returns>
        public bool updateBoard(string userMove, string playerMarker)
        {
            // the order below reflects a standard keypad layout, from top left (7) to bottom right (3)
            switch (userMove)
            {
                case "7":
                    if (Square7 == " ")
                    {
                        Square7 = playerMarker;
                        Count += 1;
                        Console.WriteLine(CurrentBoard());
                        break;
                    }
                    return false;
                case "8":
                    if (Square8 == " ")
                    {
                        Square8 = playerMarker;
                        Count += 1;
                        Console.WriteLine(CurrentBoard());
                        break;
                    }
                    return false;
                case "9":
                    if (Square9 == " ")
                    {
                        Square9 = playerMarker;
                        Count += 1;
                        Console.WriteLine(CurrentBoard());
                        break;
                    }
                    return false;
                case "4":
                    if (Square4 == " ")
                    {
                        Square4 = playerMarker;
                        Count += 1;
                        Console.WriteLine(CurrentBoard());
                        break;
                    }
                    return false;
                case "5":
                    if (Square5 == " ")
                    {
                        Square5 = playerMarker;
                        Count += 1;
                        Console.WriteLine(CurrentBoard());
                        break;
                    }
                    return false;
                case "6":
                    if (Square6 == " ")
                    {
                        Square6 = playerMarker;
                        Count += 1;
                        Console.WriteLine(CurrentBoard());
                        break;
                    }
                    return false;
                case "1":
                    if (Square1 == " ")
                    {
                        Square1 = playerMarker;
                        Count += 1;
                        Console.WriteLine(CurrentBoard());
                        break;
                    }
                    return false;
                case "2":
                    if (Square2 == " ")
                    {
                        Square2 = playerMarker;
                        Count += 1;
                        Console.WriteLine(CurrentBoard());
                        break;
                    }
                    return false;
                case "3":
                    if (Square3 == " ")
                    {
                        Square3 = playerMarker;
                        Count += 1;
                        Console.WriteLine(CurrentBoard());
                        break;
                    }
                    return false;
                _:
                    Console.WriteLine("Invalid choice!");
                    return false;
            }
            return true;

        }

        /// <summary>
        /// Checks if a player has won the game and exits if true
        /// </summary>
        /// <param name="playerMarker"></param>
        /// <returns>True if game has been won and false if not</returns>
        public bool CheckWin(string playerMarker)
        {
            if (Square1 == playerMarker && Square2 == playerMarker && Square3 == playerMarker)
                return true;
            else if (Square4 == playerMarker && Square5 == playerMarker && Square6 == playerMarker)
                return true;
            else if (Square7 == playerMarker && Square8 == playerMarker && Square9 == playerMarker)
                return true;
            else if (Square1 == playerMarker && Square5 == playerMarker && Square9 == playerMarker)
                return true;
            else if (Square7 == playerMarker && Square5 == playerMarker && Square3 == playerMarker)
                return true;
            else if (Square7 == playerMarker && Square4 == playerMarker && Square1 == playerMarker)
                return true;
            else if (Square9 == playerMarker && Square6 == playerMarker && Square3 == playerMarker)
                return true;
            return false;
        }

        /// <summary>
        /// Check if the game is a draw using the Count field
        /// </summary>
        /// <returns></returns>
        public bool CheckDraw()
        {
            if (Count == 9)
                return true;
            else
                return false;
        }
    }
}
