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
            Console.WriteLine("Please type");
            string input = Console.ReadLine();
            return input;
        }
    }
}
