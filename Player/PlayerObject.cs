using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class PlayerObject
    {
        //Properties

        public int Arrows { get; set; }
        public int GoldCoins { get; set; }
        public int MoveCount { get; set; }
        public bool KilledWumpus { get; set; }
        public int Score
        {
            get
            {
                if (KilledWumpus)
                {
                    return 10000 + 200 * GoldCoins + 750 * Arrows + 10000;
                }
                else
                {
                    return 10000 + 200 * GoldCoins + 750 * Arrows;
                }
            }
        }

        //Constructor

        public PlayerObject()
        {
            Arrows = 0;
            GoldCoins = 0;
            MoveCount = 0;
            KilledWumpus = false;
        }
    }
}
