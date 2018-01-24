using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Computer : Player
    {
        public Computer()
        {
            this.typeOfPlayer = "computer";
            this.numberOfWins = 0;
        }
        public override void ChooseWeapon()
        {
            Random randomNumber = new Random();
            int selector = randomNumber.Next(1, 6);
            switch (selector)
            {
                case 1:
                    currentSelection = "rock";
                    break;
                case 2:
                    currentSelection = "paper";
                    break;
                case 3:
                    currentSelection = "scissors";
                    break;
                case 4:
                    currentSelection = "lizzard";
                    break;
                case 5:
                    currentSelection = "spock";
                    break;
            }
        }
    }
}
