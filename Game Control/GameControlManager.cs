using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaveLibrary;
using GameLocationLibrary;
using PlayerLibrary;
using UI_Class_Library;
using ScoreBoardLibrary;
using System.Windows.Forms;
using System.Media;
using Hunt_the_Wumpus_2025;

namespace Game_Control
{
    public class GameControl : IGameControl
    {
        public bool debugMode = false;
        GameState gameState { get; set; }
        GameLocation _gameLocations;
        CaveManager _cave;
        Scoreboard _scoreboard;
        TriviaManager _triviaManager;
        public UIClassManager _UIClassManager;
        PlayerManager _playerManager;
        int triviaQuestionIndex = 0;
        public GameControl()
        {
            gameState = GameState.MainMenu;
             _gameLocations = new GameLocation(); // randomly generated positions
            _scoreboard = new Scoreboard();
            _UIClassManager = new UIClassManager();
            _triviaManager = new TriviaManager();
            _playerManager = new PlayerManager(0); // use _gamelocations to get a valid spot to place the player 
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
        public void Tick(PaintEventArgs e)
        {
            bool[] inputs = _UIClassManager.GetInputs();
            // progress the game based on the input array
            // inputs changes based on the game state
            switch (gameState)
            {
                case GameState.MainMenu:
                    {
                        if (inputs.Length == 6)
                        {
                            // should process inputs based on main menu
                            // 0 if debug mode is clicked
                            // 1 -5 which map is selected
                            if (inputs[0])
                            {
                                // activate debug mode
                                debugMode = true;
                            }
                            if (inputs[1] || inputs[2] || inputs[3] || inputs[4] || inputs[5])
                            {
                                // a map is selected, choose and change the scene, load the map from memory, and start the game
                                int caveNumber;
                                if (inputs[1]) { caveNumber = 0; }
                                else if (inputs[2]) { caveNumber = 1; }
                                else if (inputs[3]) { caveNumber = 2; }
                                else if (inputs[4]) { caveNumber = 3; }
                                else { caveNumber = 4; }
                                _cave = new CaveManager(caveNumber); // pass in the room number
                                gameState = GameState.PlayingGame; // add a gamestate here for cutscenes
                            }
                        }

                        // renders main menu
                        _UIClassManager.RenderMainMenu(e);
                        break;
                    }
                case GameState.PlayingGame:
                    {
                        
                        // should render the game
                        // should process inputs based on game
                        int pPosition = _playerManager.CurrentRoom;
                        bool[] rooms = _cave.GetDirectionsBoolArray(pPosition);
                        bool[] hazards = _gameLocations.CheckForHazard(_playerManager).Concat<bool>(_gameLocations.CheckForNearbyHazards(_playerManager, _cave)).ToArray<bool>();
                        bool[] moved = _UIClassManager.RenderGame(e, rooms, hazards, _playerManager);
                        for (int i = 0; i < 6; i++)
                        {
                            if (moved[i])
                            {
                                _playerManager.CurrentRoom = _cave.GetNewRoomNumber(pPosition, i);
                            }
                        }
                        if (moved[6])
                        {
                            // user encountered wumpus, ask 5 questions, and make sure that at least 3 are correct
                            // throw new Exception("You have hit the wumpus");
                            gameState = GameState.GetTrivia;
                        }
                        if (moved[7])
                        {
                            // user encountered bat
                            throw new Exception("You have hit a bat");
                        }
                        if (moved[8])
                        {
                            // user encountered pit
                            // throw new Exception("You have hit a pit");
                            gameState = GameState.GetTrivia;
                        }
                        break;
                    }
                case GameState.GetTrivia:
                    {

                        string triviaQuestion = "";// _triviaManager.getQuestion(triviaQuestionIndex);
                        string[] triviaAnswers = [""];//_triviaManager.getPosssibleAnswers(triviaQuestionIndex);
                        triviaQuestionIndex++;
                        bool[] answers = _UIClassManager.RenderTrivia(e, triviaQuestion,triviaAnswers);
                        if (answers.Contains<bool>(true))
                        {

                        }
                        break;
                    }
            }
        }
    }
    public enum GameState
    {
        MainMenu,
        PlayingGame,
        GetTrivia,
    }
    public interface IGameControl
    {
        public void StartGame(int map, int startingRoom);
        public void StopGame();
        public void RestartGame(int map, int startingRoom);
        public void Tick(PaintEventArgs e);


    }
}
