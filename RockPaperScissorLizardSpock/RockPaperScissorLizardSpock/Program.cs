using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            GameConsole game = new GameConsole();
            game.PlayGame();
            Console.ReadKey();
        }
    }
}
