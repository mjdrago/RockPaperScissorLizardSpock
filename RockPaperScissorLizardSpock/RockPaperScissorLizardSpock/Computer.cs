﻿using System;
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
            this.numberOfRoundWins = 0;
        }
        public override void ChooseWeapon()
        {
            Random randomNumber = new Random();
            currentSelection = randomNumber.Next(0, 5);
        }
    }
}
