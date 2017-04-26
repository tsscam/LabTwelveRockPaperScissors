using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Roshambo

    {
      
            
        Random random = new Random();
        public void Play()
        {
            string userInput = correctInput();
            string GetPlayerInput = GetPlayerChoice();

            Console.WriteLine("Your Team: {0}", letterToWord(userInput));
            Console.WriteLine("The Roshambo machine: {0}", letterToWord(GetPlayerInput));

            Winner(userInput, GetPlayerInput);
            Console.ReadLine();

        }


        private string correctInput()

        {
            Console.WriteLine("Choose an option Lions, Tigers, or Bears: ");
            string choice = Console.ReadLine();

            if (choice == "R")
            {
                return "R";
            }
            else if (choice == "P")
            {
                return "P";
            }
            else
            {
                return "S";
            }
        }
        private string GetPlayerChoice()
        {
            int number = random.Next(1, 4);
            if (number == 1)
            {
                return "P";
            }
            else if (number == 2)
            {
                return "R";
            }
            else
            {
                return "S";
            }
        }
        private string letterToWord(string choice)
        {
            if (choice == "P")
            {
                return "Paper";
            }
            else if (choice == "R")
            {
                return "Rock";
            }
            else
            {
                return "Scissors";
            }
        }
        private void Winner(string YourInput, string roshamboInput)
        {
            if ((YourInput == "P" && roshamboInput == "R") || (YourInput == "R" && roshamboInput == "S") || (YourInput == "S" && roshamboInput == "P"))
            {
                Console.WriteLine("You ARE the winner.");
            }
            else if (YourInput == roshamboInput)
            {
                Console.WriteLine("Nobody Won, TIE GAME.");
            }
            else
            {
                Console.WriteLine("ROSHAMBO has WON!");
            }
        } 
    }
}