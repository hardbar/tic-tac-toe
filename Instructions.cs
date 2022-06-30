// instructions library

namespace Tic_Tac_Toe
{
    internal class Instructions
    {
        // constructor
        public Instructions() { }

        /// <summary>
        /// Prints out the instructions for the game
        /// </summary>
        public void gamePad()
        {
            Console.WriteLine("Use the numbers on your keypad as follows to place your marker:");
            Console.WriteLine(" 7 | 8 | 9 ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 4 | 5 | 6 ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 1 | 2 | 3 ");
        }
    }
}