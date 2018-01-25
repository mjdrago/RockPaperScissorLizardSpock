using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
            this.typeOfPlayer = "human";
            this.numberOfWins = 0;
        }
        public override void ChooseWeapon()
        {
            Console.WriteLine("{0} choose your weapon (Enter the number in parenthesis): \n" +
                              " - Rock (1) \n" +
                              " - Paper (2) \n" +
                              " - Scissors (3) \n" +
                              " - Lizard (4) \n" +
                              " - Spock (5) \n",name);
            currentSelection = int.Parse(Console.ReadLine());
        }
    }
}
