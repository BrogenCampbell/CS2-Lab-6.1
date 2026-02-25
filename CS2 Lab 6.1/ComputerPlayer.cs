//CS2 - Lab 6.1
//Author: Jordan Eller
//Date: 2/25/2026
//Description: Class for computer logic
using System;

namespace CS2_Lab6._1_Computerbranch
{
    /// <summary>
    /// Represents the AI opponent in the game.
    /// </summary>
    public class ComputerPlayer
    {
        private readonly string[] _choices = { "rock", "paper", "scissors" };
        private readonly Random _random = new Random();

        /// <summary>
        /// Generates a random choice for the computer.
        /// </summary>
        /// <returns>A string representing 'rock', 'paper', or 'scissors'.</returns>
        public string GenerateChoice()
        {
            int index = _random.Next(_choices.Length);
            return _choices[index];
        }
    }
}