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
using System.Windows.Forms;

namespace Game_Control
{
    public class GameControl : IGameControl
    {
        GameState gameState 
        {
            get
            {
                return gameState;
            }
            set 
            { 
                gameState = value; 
            }
        }
        GameLocation _gameLocations;
        CaveManager _cave;
        Scoreboard _scoreboard;
        UIClassManager _UIClassManager;
        PlayerManager _playerManager;
        public GameControl(int caveNumber)
        {
            gameState = GameState.MainMenu;
            if (caveNumber > 4 || caveNumber < 0) 
            {
                Random random = new Random();
                _cave = new CaveManager(random.Next(0, 4)); // pass in the room number
            }
            else
            {
                _cave = new CaveManager(caveNumber); // pass in the room number
            }
             _gameLocations = new GameLocation(); // randomly generated positions
            _scoreboard = new Scoreboard();
            _UIClassManager = new UIClassManager();
            _playerManager = new PlayerManager();
        }
        public void StartGame(int map, int startingRoom)
        {
            // should start up a game
            int m, g;
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
        public void Tick(bool[] inputs, PaintEventArgs e)
        {
            // progress the game based on the input array
            // inputs changes based on the game state
            switch (gameState)
            {
                case GameState.MainMenu:
                {
                        // should render the Main Menu
                        // should process inputs based on main menu
                        _UIClassManager.RenderMainMenu(e);
                        break;
                }
                case GameState.PlayingGame:
                {
                        // should render the game
                        // should process inputs based on game
                        int pPosition = _gameLocations.GetPlayerLocation();
                        bool[] rooms = _cave.GetDirectionsBoolArray(pPosition);
                        _UIClassManager.RenderGame(e, rooms);
                        break;
                }
            }
        }
    }
    public enum GameState
    {
        MainMenu,
        PlayingGame,
    }
    public interface IGameControl
    {
        public void StartGame(int map, int startingRoom);
        public void StopGame();
        public void RestartGame(int map, int startingRoom);
        public void Tick(bool[] inputs, PaintEventArgs e);


    }
}
