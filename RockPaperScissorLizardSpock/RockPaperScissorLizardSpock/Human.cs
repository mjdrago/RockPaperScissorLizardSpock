using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Human : Player
    {
        public Human()
        {
            this.typeOfPlayer = "human";
            this.numberOfWins = 0;
        }
        public override void ChooseWeapon()
        {
            Console.WriteLine("Enter your weapon: \n" +
                              " - rock \n" +
                              " - paper \n" +
                              " - scissors \n" +
                              " - lizard \n" +
                              " - spock \n");
        }
    }
}
