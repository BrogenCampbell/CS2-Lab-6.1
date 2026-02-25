using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cspii_lab6._1
{
    internal class Player(string name, string choice) // constructors are placeholders
    {
        public string Name { get { return name; } }
        public string Choice { get { return choice; } }

        public void getName()
        {
            Console.WriteLine("Player Name:"); //player enters their name
            name = Console.ReadLine();
        }
        public void MakeChoice() // player chooses between rock, paper, and sissors
        {
            Console.WriteLine("1.Rock, 2.Paper, 3.Sissors");
            choice = Console.ReadLine();
            
            while(true) //program allows many different ways to enter the player's choice
            {
                if(choice == "1" || choice == "Rock" || choice == "rock")
                {
                    choice = "rock";
                    break;
                }else if(choice == "2" || choice == "Paper" || choice == "paper") {
                    choice = "paper";
                    break;
                }else if(choice == "3" || choice == "Sissors" || choice == "sissors")
                {
                    choice = "sissors";
                    break;
                }else
                {
                    Console.WriteLine("Enter a valid choice....");
                    choice = Console.ReadLine(); //if the player enters something wrong, they are allowed to make a proper choice
                }
            }
        }
    }
}
