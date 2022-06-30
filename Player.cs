// player library

namespace Tic_Tac_Toe
{
    internal class Player
    {
        // fields / properties
        public string Name { get; set; } = " ";
        public string PlayerMarker { get; set; } = " ";

        // constructor
        public Player(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Allows a player to select their marker for the game, either "X" or "O"
        /// </summary>
        /// <returns>The player's marker</returns>
        public string PlayerChoice()
        {
            bool loop = true;
            while (loop)
            {
                Console.Write($"{Name}, please choose your marker? ");
                PlayerMarker = Console.ReadLine();
                if (PlayerMarker == "X" || PlayerMarker == "O")
                    loop = false;
            }
            return PlayerMarker;
        }
    }
}
