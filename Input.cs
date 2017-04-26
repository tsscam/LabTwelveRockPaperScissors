using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Input:Player
    { 
        public override string GetRoshambo()
        {
            Console.WriteLine("Play Against Computer =====>");
            Console.WriteLine("[r] to play as the Rock [p] to play as Paper [s] to play as Scissors");
            string input = Console.ReadLine();
            return input;
        }
    }
}
