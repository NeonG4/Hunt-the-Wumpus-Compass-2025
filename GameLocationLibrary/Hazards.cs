using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus_2025
{
    public class Hazards
    {
        public string hazard;
        public int room;

        public Hazards(string h, int r)
        {
            hazard = h;
            room = r;
        }

        public override string ToString()
        {
            return hazard;
        }
    }
}
