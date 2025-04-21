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

        public bool IsValidMove(int room, int direction, int caveIndex)
        {
            //placeholder

            return true;
        }

        public int[] GetReachableNeighboringRooms(int room, int caveIndex)
        {
            //placeholder

            return [0, 0, 0];
        }
    }

    public interface ICave
    {

        int[] GetNeighboringRooms(int room);

    }
}
