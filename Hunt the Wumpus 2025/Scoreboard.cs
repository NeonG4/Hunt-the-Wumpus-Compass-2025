using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus_2025
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

        private List<ScoreItem> forTestOnlyGetFourNames()
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
    }
    public interface IScoreboard
    {
        //sort high scores if a new entry scores high enough
        List<ScoreItem> SortHighScore(string highscoredatafile);
        //calculates the high score using the various parameters.
        int CalculateHighScore(int turns, int coins, int arrows, bool wumpus);
        
    }
}
