﻿using System;
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
            this.numberOfRoundWins = 0;
        }
        public override void ChooseWeapon()
        {
            Console.WriteLine("{0} choose your weapon (Enter the number in parenthesis): \n" +
                              " - Scissors (1) \n" +
                              " - Paper (2) \n" +
                              " - Rock (3) \n" +
                              " - Lizard (4) \n" +
                              " - Spock (5)",name);
            int input =  int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    currentSelection = input-1;
                    break;
                case 2:
                    currentSelection = input-1;
                    break;
                case 3:
                    currentSelection = input-1;
                    break;
                case 4:
                    currentSelection = input-1;
                    break;
                case 5:
                    currentSelection = input-1;
                    break;
                default:
                    Console.WriteLine("Not a valid option. Please try again.");
                    ChooseWeapon();
                    break;
            }
        }
    }
}
