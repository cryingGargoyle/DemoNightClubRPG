using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNightClubRPG
{
    class Player
    {
        private Character selectedChar;

        public Character getSelectedChar()
        {
           return selectedChar;
        }
        public Player(int charSelected)
        {
            selectedChar = new Character(charSelected);
        }

    }
}
