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
using System.Diagnostics.Contracts;
using Microsoft.VisualBasic;
using System.ComponentModel.Design;

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
        int triviaCount = 0;
        int triviaCorrect = 0;
        int triviaTotalQuestions = 0;
        int totalGoldCoins = 100;
        bool angeredWumpus = false;
        bool arrowNocked = false;
        TriviaState triviaState = TriviaState.Empty;
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
                                _playerManager.CurrentRoom = _gameLocations.SpawnPlayer();
                            }
                        }

                        // renders main menu
                        _UIClassManager.RenderMainMenu(e);
                        break;
                    }
                case GameState.PlayingGame:
                    {
                        
                        int pPosition = _playerManager.CurrentRoom;
                        bool[] rooms = _cave.GetDirectionsBoolArray(pPosition);
                        bool[] hazards = _gameLocations.CheckForHazard(_playerManager).Concat<bool>(_gameLocations.CheckForNearbyHazards(_playerManager, _cave)).ToArray<bool>();
                        bool[] outputs = _UIClassManager.RenderGame(e, rooms, hazards, _playerManager);
                        
                        if (triviaState != TriviaState.Empty)
                        {
                            // just got back from trivia questions
                            if (triviaState == TriviaState.Wumpus)
                            {
                                if (triviaCorrect > 2)
                                {
                                    _gameLocations.MoveWumpus(_cave);
                                }
                                else
                                {
                                    gameState = GameState.Died;
                                    return;
                                }
                                
                            }
                            else if (triviaState == TriviaState.BuyingSecret)
                            {
                                if (triviaCorrect > 1)
                                {
                                    // buy a secret
                                }
                                else
                                {
                                    // don't buy a secret
                                }
                            }
                            else if (triviaState == TriviaState.BuyingArrow)
                            {
                                if (triviaCorrect > 1)
                                {
                                    // buy an arrow
                                    _playerManager.Arrows++;
                                }
                                else
                                {
                                    // don't buy an arrow
                                }
                            }
                            else if (triviaState == TriviaState.Pit)
                            {
                                if (triviaCorrect > 1)
                                {
                                    _playerManager.CurrentRoom = _gameLocations.playerspawn;
                                }
                                else
                                {
                                    gameState = GameState.Died;
                                    return;
                                }
                            }
                        }
                        triviaState = TriviaState.Empty;
                        
                        // should render the game
                        // should process inputs based on game
                        for (int i = 0; i < 6; i++)
                        {
                            if (outputs[i])
                            {
                                _playerManager.CurrentRoom = _cave.GetNewRoomNumber(pPosition, i);
                                if (arrowNocked)
                                {
                                    arrowNocked = false;
                                    if (_gameLocations.GetWumpusRoom() ==  _playerManager.CurrentRoom)
                                    {
                                        gameState = GameState.Win;
                                        return;
                                    }
                                    else
                                    {
                                        angeredWumpus = true;
                                    }
                                }
                                if (angeredWumpus)
                                {
                                    _gameLocations.MoveWumpus(_cave);
                                }
                                _playerManager.MoveCount++;
                                if (totalGoldCoins > 0)
                                {
                                    totalGoldCoins --;
                                    _playerManager.GoldCoins++;
                                }
                            }
                        }
                        if (outputs[6] && arrowNocked == false)
                        {
                            // shoot arrow
                            if (_playerManager.Arrows > 0)
                            {
                                arrowNocked = true;
                                _playerManager.Arrows--;
                            }
                        }
                        if (outputs[7])
                        {
                            // buy arrow
                            // buy arrow with 2/3 trivia questions answered correctly
                            triviaState = TriviaState.BuyingArrow;
                            triviaTotalQuestions = 3;
                            triviaCount = 3;
                            triviaCorrect = 0;
                            gameState = GameState.GetTrivia;
                        }
                        if (outputs[8])
                        {
                            // buy secret
                            // buy secret with 2/3 trivia questions answered correctly
                            // secrets are things like where the bat is, pit is, if the wumpus is nearby, or the answer to a trivia question already asked
                            triviaState = TriviaState.BuyingSecret;
                            triviaTotalQuestions = 3;
                            triviaCount = 3;
                            triviaCorrect = 0;
                            gameState = GameState.GetTrivia;
                        }
                        if (outputs[9])
                        {
                            // user encountered wumpus, ask 5 questions, and make sure that at least 3 are correct
                            // throw new Exception("You have hit the wumpus");
                            triviaState = TriviaState.Wumpus;
                            triviaTotalQuestions = 5;
                            triviaCount = 5;
                            triviaCorrect = 0;
                            gameState = GameState.GetTrivia;
                        }
                        if (outputs[10])
                        {
                            // user encountered bat
                            //throw new Exception("You have hit a bat");
                            
                        }
                        if (outputs[11])
                        {
                            // user encountered pit
                            // throw new Exception("You have hit a pit");
                            gameState = GameState.GetTrivia;
                            triviaState = TriviaState.Pit;
                            triviaTotalQuestions = 3;
                            triviaCount = 3;
                            triviaCorrect = 0;
                        }
                        break;
                    }
                case GameState.GetTrivia:
                    {

                        string triviaQuestion = _triviaManager.getQuestion(triviaQuestionIndex);
                        string[] triviaAnswers = _triviaManager.getPossibleAnswers(triviaQuestionIndex);
                        string correctAnswer = _triviaManager.getCorrectAnswer(triviaQuestionIndex);
                        bool[] answers = _UIClassManager.RenderTrivia(e, triviaQuestion,triviaAnswers);
                        if (answers.Contains<bool>(true))
                        {
                            _playerManager.GoldCoins--;
                            triviaCount--; // we want to move to the next question after the current question is answered
                            triviaQuestionIndex++;
                            for (int i = 0; i < triviaAnswers.Length; i++)
                            {
                                if (triviaAnswers[i] == correctAnswer && answers[i])
                                {
                                    triviaCorrect++;
                                    i = 4;
                                }
                            }
                        }
                        if (triviaCount == 1)
                        {
                            gameState = GameState.PlayingGame;
                        }
                       break;
                    }
                case GameState.Died:
                    {
                        // renders game over screen
                        _playerManager.KilledWumpus = false;
                        _UIClassManager.RenderDeath(e, _playerManager.Score);
                        break;
                    }
                case GameState.Win:
                    {
                        // renders win screen
                        _playerManager.KilledWumpus = true;
                        _UIClassManager.RenderWin(e, _playerManager.Score, "Name");
                        break;
                    }
                case GameState.GetHighScores:
                    {
                        // renders high scores
                        ScoreItem[] scoreData = _scoreboard.GetHighScores().ToArray();
                        List<string> names = new List<string>();
                        for (int i = 0; i < scoreData.Length; i++)
                        {
                            names.Add(scoreData[i].Name);
                        }
                        List<int> scores = new List<int>();
                        for (int i = 0; i < scoreData.Length; i++)
                        {
                            scores.Add(scoreData[i].Score);
                        }
                        List<string> caveType = new List<string>();
                        for (int i = 0; i < scoreData.Length; i++)
                        {
                            caveType.Add(scoreData[i].CaveType);
                        }
                        if (_UIClassManager.RenderHighScore(e, names.ToArray(), scores.ToArray(), caveType.ToArray()))
                        {
                            gameState = GameState.MainMenu;
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
        Died,
        GetHighScores,
        Win,
    }
    public enum TriviaState
    {
        Empty,
        Wumpus,
        BuyingArrow,
        BuyingSecret,
        Pit,
    }
    public interface IGameControl
    {
        public void StartGame(int map, int startingRoom);
        public void StopGame();
        public void RestartGame(int map, int startingRoom);
        public void Tick(PaintEventArgs e);
    }
}
