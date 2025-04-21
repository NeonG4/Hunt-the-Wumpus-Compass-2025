using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Control
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
