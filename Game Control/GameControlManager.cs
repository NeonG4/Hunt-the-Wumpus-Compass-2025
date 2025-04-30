using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cave;
using GameLocationLibrary;
using Player;
using UI_Class_Library;
using ScoreBoardLibrary;

namespace Game_Control
{
    public class GameControl : IGameControl
    {
        GameLocation _gameLocations;
        CaveManager _cave;
        Scoreboard _scoreboard;
        UIClassManager _UIClassManager;
        PlayerManager _playerManager;
        public GameControl()
        {
            _gameLocations = new GameLocation(); // randomly generated positions
            _cave = new CaveManager();
            _scoreboard = new Scoreboard();
            _UIClassManager = new UIClassManager();
            _playerManager = new PlayerManager();
        }
        public void StartGame(int map, int startingRoom)
        {
            // should start up a game
            int m;
            int g;
            if (map == -1)
            {
                Random random = new Random();
                m = random.Next(0, 4);
            }
            if (startingRoom == -1)
            {
                Random random = new Random();
                g = random.Next(0, 29);
            }
            
        }
        public void StopGame()
        {
            // stops the game
        }
        public void RestartGame(int map, int startingRoom)
        {
            // should restart the game, this means to reset all data
        }
        public void Tick(bool[] inputs)
        {
            // progress the game based on the input array
        }
    }
    public interface IGameControl
    {
        public void StartGame(int map, int startingRoom);
        public void StopGame();
        public void RestartGame(int map, int startingRoom);
        public void Tick(bool[] inputs);


    }
}
