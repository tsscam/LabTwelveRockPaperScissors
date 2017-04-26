using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
         
            do
            {
                Console.WriteLine("Ready, Set, Go! ");

                //Console.WriteLine("Choose an option Lions, Tigers, or Bears: ");
                Console.WriteLine("Please Enter Rock,Paper, Scissors: ");

                Input player = new Input();
                Rand computer = new Rand();
                string output1 = player.GetRoshambo();
                string output2 = computer.GetRoshambo();

                if ((output1 == "p" && output2 == "r") || (output1 == "r" && output2 == "s") || (output1 == "s" && output2 == "p"))
                {
                    Console.WriteLine("You ARE the WINNER {0} wins over {1}", output1, output2);

                }
                if ((output1 == "r" && output2 == "p") || (output1 == "s" && output2 == "r") || (output1 == "p" && output2 == "s"))
                {
                    Console.WriteLine("Computer WON {0} wins over {1}", output2, output1);
                }
                else if (output1 == output2)
                {
                    Console.WriteLine("Nobody Won, TIE GAME.");
                }
            } while (true);
        }
    }
}
   


     