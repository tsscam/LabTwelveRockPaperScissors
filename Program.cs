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
            bool run = true;
            string Continue;
            do
            {
                Roshambo game = new Roshambo();
                game.Play();


                Console.WriteLine("Continue?  (y/n)");
                Continue = Console.ReadLine().ToUpper();

                if (Continue == "N")
                    break;

                if (Continue == "y")
                    return;


            } while (run == true);
        }
    }
}
