using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;

using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ScoreBoardLibrary
{
    public class Scoreboard : IScoreboard
    {
        const string ScoreData = "Scores.csv";//this is where im gonna store all the scores !
        public List<ScoreItem> SortHighScore(string highscoredatafile)
        {
            List<ScoreItem> scores = new List<ScoreItem>();

            scores = forTestOnlyGetFourNames();
            //TODO: implement stub

            return scores;
        }

        public List<ScoreItem> forTestOnlyGetFourNames()
        {
            List<ScoreItem> scores = new List<ScoreItem>();

            ScoreItem score1 = new ScoreItem("a", 5, "g");
            ScoreItem score2 = new ScoreItem("b", 4, "g");
            ScoreItem score3 = new ScoreItem("c", 3, "g");
            ScoreItem score4 = new ScoreItem("d", 1, "g");

            scores.Add(score1);
            scores.Add(score2);
            scores.Add(score3);
            scores.Add(score4);

            return scores;
        }
        public List<ScoreItem> GetHighScores()
        {

            return null;
        }

        public int CalculateHighScore(int turns, int coins, int arrows, bool wumpus)
        {
            //TODO; implement stub, might have to change return value to an array/list
            int score;
            if (wumpus)
            { score = (100 - turns + coins + (arrows * 5) + 50); }
            else
            { { score = (100 - turns + coins + (arrows * 5) + 50); } }
            return score;
        }
        private string ReadToFile(string fileName)
        {
            //TODO this will read exisiting high scores from file
            StreamReader reader = new StreamReader(fileName);
            string line = reader.ReadLine();

            List<int[]> list = new List<int[]>();
            return "";

        }
        private string WriteTofile()
        {
            //todo write down new high scores
            return "";
        }
        public string AddHighScore()
        {

            // to do
            return null;
        }
    }
    public interface IScoreboard
    {
        //sort high scores if a new entry scores high enough
        List<ScoreItem> SortHighScore(string highscoredatafile);
        //calculates the high score using the various parameters.
        int CalculateHighScore(int turns, int coins, int arrows, bool wumpus);

        string AddHighScore();
        //add higschore. check
        // sort highscore. check
        //track highscore in memory. not check
        //save highscore. chechk
        //getting highscores from. file check
        List<ScoreItem> GetHighScores();
    }
}
