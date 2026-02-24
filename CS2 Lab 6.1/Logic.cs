using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2_Lab_6._1
{

    /// <summary>
    /// Takes the input of the user and computer to determine the winner and return it.
    /// </summary>
    /// <param name="player">The player's choice.</param>
    /// <param name="computer">The computer's random choice.</param>
    class GameLogic (string player, string computer)
    {

        /// <summary>
        /// Takes the input and compares to find the winnner.
        /// </summary>
        /// <remarks>
        /// The method only works in lowercase. Make sure the input ues .ToLower
        /// </remarks>
        public void DetermineWinner()
        {
            if (player == "paper" && computer == "scissors")
            {
                Console.WriteLine("You lose!");
            }

            else if (player == "paper" && computer == "rock")
            {
                Console.WriteLine("You win!");
            }

            else if (player == "scissors" && computer == "rock")
            {
                Console.WriteLine("You lose!");
            }

            else if (player == "scissors" && computer == "paper")
            {
                Console.WriteLine("You win!");
            }

            else if (player == "rock" && computer == "paper")
            {
                Console.WriteLine("You lose!");
            }

            else if (player == "rock" && computer == "scissors")
            {
                Console.WriteLine("You win!");
            }

            else if (player == computer)
            {
                Console.WriteLine("Tie! Try again");
            }




        }

    }



   
}





