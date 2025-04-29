using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Player
    {
        //Properties

        public int Arrows { get; set; }
        public int GoldCoins { get; set; }
        public int MoveCount { get; set; }

        //Constructor

        public Player()
        {
            Arrows = 0;
            GoldCoins = 0;
            MoveCount = 0;
        }
    }
}
