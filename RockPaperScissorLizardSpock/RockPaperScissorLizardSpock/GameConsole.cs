using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class GameConsole
    {
        public Player player1;
        public Player player2;
        public GameConsole()
        {
            Console.WriteLine("Is this a two-player or one-player game? \n" +
                              "Please enter '1' for one-player game or '2' for a two-player game.");
            char selection = char.Parse(Console.ReadLine());
            switch (selection)
            {
                case '1':
                    player1 = new Human();
                    player2 = new Computer();
                    break;
                case '2':
                    player1 = new Human();
                    player2 = new Human();
                    break;
                default:
                    Console.WriteLine("Invalid choice selected. Please try again");
                    break;
            }
        }

    }
}
