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

        public void forTestOnlyGetFourNames()
        {
            List<ScoreItem> scores = new List<ScoreItem>();

            ScoreItem score1 = new ScoreItem("a", 4, "g");
            ScoreItem score2 = new ScoreItem("b", 5, "g");
            ScoreItem score3 = new ScoreItem("c", 3, "g");
            ScoreItem score4 = new ScoreItem("d", 2, "g");

            scores.Add(score1);
            scores.Add(score2);
            scores.Add(score3);
            scores.Add(score4);

            items = scores;
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
            if (score > items[items.Count - 1].Score || items.Count < 10)
            {
                items.Add(new ScoreItem(name, score, cave_type));
            }
           
           
            




            
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

        void AddHighScore(string name, int score, string cave_type);
        //add higschore. check
        // sort highscore. check
        //track highscore in memory. not check
        //save highscore. chechk
        //getting highscores from. file check
        List<ScoreItem> GetHighScores();
        
    }
}
