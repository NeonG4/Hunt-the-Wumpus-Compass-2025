
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;

using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ScoreBoard
{
    public class Scoreboard : IScoreboard
    {
        string HighScoresData = "Highscore.csv";
        public List<ScoreItem> items = new List<ScoreItem>();
        public void SortHighScore()
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < items.Count - 1; j++)
                {
                    ScoreItem item1 = items[j];
                    ScoreItem item2 = items[j + 1];

                    if (item1.Score < item2.Score)
                    {
                        items[j] = item2;
                        items[j + 1] = item1;

                    }

                }
            }





        }

      
        public List<ScoreItem> GetHighScores()
        {
            items.Sort((s1, s2) => s1.Score.CompareTo(s2.Score));
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
        public void ReadFromFile()
        {
           
            StreamReader streamReader = new StreamReader(HighScoresData);
            string line = streamReader.ReadLine();

            while (line != null)
            {
                string[] record = line.Split(',');
                ScoreItem contact = new ScoreItem();
                contact.Name = record[0];
                contact.Score = int.Parse(record[1]);
                contact.CaveType = record[2];
                contact.Turns = int.Parse(record[3]);
                contact.Gold = int.Parse(record[4]);
                contact.Arrows = int.Parse(record[5]);
                contact.WumpusDead = bool.Parse(record[6]);

                items.Add(contact);
                line = streamReader.ReadLine();
            }


            streamReader.Close();
           



        }
      public void SaveTofile()
        {
         
            StreamWriter streamwriter = new StreamWriter(HighScoresData);

            foreach (ScoreItem contact in items)
            {

                string record = contact.Name + "," + contact.Score + "," + contact.CaveType + "," + contact.Turns + "," + contact.Gold + "," + contact.Arrows + "," + contact.WumpusDead;
                streamwriter.WriteLine(record);

            }
            streamwriter.Flush();
            streamwriter.Close();

        }
        public void AddHighScore(string name, string cave_type, int turns, int gold, int arrows, bool wumpus)
        {
            int score = CalculateHighScore(turns, gold, arrows, wumpus);
           //if (score > items[items.Count - 1].Score || items.Count < 10)
           // {

                items.Add(new ScoreItem(name, score, cave_type,turns, gold, arrows, wumpus));
           // }

            SortHighScore();






        }
        public List<ScoreItem> GetList()
        {
            return items;
        }

    }
    public interface IScoreboard
    {
        //sort high scores if a new entry scores high enough
        void SortHighScore();
        //calculates the high score using the various parameters.
        int CalculateHighScore(int turns, int coins, int arrows, bool wumpus);

        void AddHighScore(string name, string cave_type, int turns, int gold, int arrows, bool wumpus);
        //add higschore. check
        // sort highscore. check
        //track highscore in memory. not check
        //save highscore. chechk
        //getting highscores from. file check
        List<ScoreItem> GetHighScores();

    }
}
