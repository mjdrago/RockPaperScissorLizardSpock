using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public abstract class Player
    {
        public string name;
        public string typeOfPlayer;
        public int currentSelection;
        public int numberOfWins;

        public abstract void ChooseWeapon();
    }
}
