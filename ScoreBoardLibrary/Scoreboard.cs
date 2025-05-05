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
        List<ScoreItem> items = new List<ScoreItem>();
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
            items.Sort((s1,s2) => s1.Score.CompareTo(s2.Score));
            return items;
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
        private List<ScoreItem> ReadFromFile(string datafile)
        {
            List<ScoreItem> list = new List<ScoreItem>();
            StreamReader streamReader = new StreamReader(datafile);
            string line = streamReader.ReadLine();

            while (line != null)
            {
                string[] record = line.Split(',');
                ScoreItem contact = new ScoreItem(record[0], int.Parse(record[2]), record[1]);

                list.Add(contact);
                line = streamReader.ReadLine();
            }


            streamReader.Close();
            return list;
            


        }
        private void SaveTofile(string datafile, ScoreItem score)
        {
            List<ScoreItem> scores = new List<ScoreItem>(); // placeholder
            StreamWriter streamwriter = new StreamWriter(datafile);
            
           foreach (ScoreItem contact in scores)
            {
               
                string record = contact.Name + ": " + contact.Score + " " + contact.CaveType;
                streamwriter.WriteLine(record);

            }
            streamwriter.Flush();
            streamwriter.Close();

        }
        public void AddHighScore(string name, int score, string cave_type)
        {
           
            items.Add(new ScoreItem(name, score, cave_type));
           
            




            
        }
        public List<ScoreItem> GetList() { return items; }
            
    }
    public interface IScoreboard
    {
        //sort high scores if a new entry scores high enough
        List<ScoreItem> SortHighScore(string highscoredatafile);
        //calculates the high score using the various parameters.
        int CalculateHighScore(int turns, int coins, int arrows, bool wumpus);

        void AddHighScore(string name, int score, string cave_type);
        //add higschore. check
        // sort highscore. check
        //track highscore in memory. not check
        //save highscore. chechk
        //getting highscores from. file check
        List<ScoreItem> GetHighScores();
        
    }
}
