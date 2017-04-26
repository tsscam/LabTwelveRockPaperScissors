using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Rand:Player
    {
        public override string GetRoshambo()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            var game = new List<string> { "r", "p", "s" };
            int index = random.Next(game.Count);
            string RandomString = game[index];

            return RandomString;
        }
    }
}
