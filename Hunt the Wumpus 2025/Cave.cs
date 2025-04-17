using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus_2025
{
    public class Cave : ICave
    {
        public int[] GetNeighboringRooms(int room)
        {
            //placeholder, to get from file
            //(which has neighboring rooms)

            //placeholder

            return [0, 0, 0, 0, 0, 0];
        }
    }

    public interface ICave
    {
        //For UI to tell player which rooms are nearby

        int[] GetNeighboringRooms(int room);

        //make new method
    }
}
