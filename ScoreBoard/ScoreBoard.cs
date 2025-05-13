
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;

using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.InteropServices;

namespace ScoreBoard
{
    public class Scoreboard : IScoreboard
    {
        string HighScoresData = "Highscore.csv";
        public List<ScoreItem> items = new List<ScoreItem>();
        public Scoreboard() 
        {
            //initial implementation shows default scores or top scores
            FileInfo fileinfo = new FileInfo(HighScoresData);
            if (fileinfo.Exists)
            {
                ReadFromFile();
            }
            else 
            { 
            items.Add(new ScoreItem("David",0,"CaveA",0,0,0,false));
            items.Add(new ScoreItem("Milla", 0, "CaveA", 0, 0, 0, false));
            items.Add(new ScoreItem("Nathan", 0, "CaveA", 0, 0, 0, false));
            items.Add(new ScoreItem("Maxim", 0, "CaveA", 0, 0, 0, false));
            items.Add(new ScoreItem("Azeem", 0, "CaveA", 0, 0, 0, false));
            }
        }
        public void SortHighScore()
        {
            //sorts high scores
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

      
       /// <summary>
       /// 
       /// </summary>
       /// <param name="turns"> the amount of turns the game lasted</param>
       /// <param name="coins">how many coins you end with</param>
       /// <param name="arrows">how many arrows you end with</param>
       /// <param name="wumpus">bool checks whether wumpus died or not</param>
       /// <returns></returns>

        public int CalculateHighScore(int turns, int coins, int arrows, bool wumpus)
        {
            //calculates score based on each parameter
            int score;
            if (wumpus)
            { score = (100 - turns + coins + (arrows * 5) + 50); }
            else
            { { score = (100 - turns + coins + (arrows * 5) + 50); } }
            return score;
        }
        public void ReadFromFile()
        {
           //reads from file
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
         //saves new entries to file
            StreamWriter streamwriter = new StreamWriter(HighScoresData);

            foreach (ScoreItem contact in items)
            {

                string record = contact.Name + "," + contact.Score + "," + contact.CaveType + "," + contact.Turns + "," + contact.Gold + "," + contact.Arrows + "," + contact.WumpusDead;
                streamwriter.WriteLine(record);

            }
            streamwriter.Flush();
            streamwriter.Close();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of player</param>
        /// <param name="cave_type">The cave in which the game was played</param>
        /// <param name="turns">the amount of turns the game lasted</param>
        /// <param name="gold">how many coins you end with</param>
        /// <param name="arrows">how many arrows you end with</param>
        /// <param name="wumpus">bool checks whether wumpus died or not</param>
        public void AddHighScore(string name, string cave_type, int turns, int gold, int arrows, bool wumpus)
        {
            //adds high scores to wherver you want to store them in the ui
            //first we calculate the high scores
           int score = CalculateHighScore(turns, gold, arrows, wumpus);
            //see if we need to add it
           if (score > items[items.Count - 1].Score || items.Count < 10)
            {

                items.Add(new ScoreItem(name, score, cave_type,turns, gold, arrows, wumpus));
                SortHighScore();
                
            }
           //removes extra entries if needed
            if (items.Count > 10)
            { 
                items.RemoveAt(items.Count - 1); 
            }
            
            
            SaveTofile();




        }
        public List<ScoreItem> GetList()
        {
            //gets u the list of stuff
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
      
      

    }
}
