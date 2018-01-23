using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Player
    {
        string isHuman;
        string currentSelection;
        string[] roundResults = new string[3];

        public Player(string isHuman)
        {
            this.isHuman = isHuman;
        }
    }
}
