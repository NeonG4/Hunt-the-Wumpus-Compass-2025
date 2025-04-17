using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus_2025
{
    public class GameControl : IGameControl
    {
        public void StartGame(int map, int startingRoom)
        {
            // should start up a game
        }
    }
    public interface IGameControl
    {
        void StartGame(int map, int startingRoom);
    }
}
