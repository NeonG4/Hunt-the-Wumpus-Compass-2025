using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ScoreBoard
{
    public class ScoreItem
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string CaveType { get; set; }
        public int Turns { get; set; }  
        public int Gold {  get; set; }
        public int Arrows {  get; set; }
        public bool WumpusDead {  get; set; }

        public ScoreItem(string name, int score, string cave, int turns, int gold, int arrows, bool wumpusDead)
        {


            this.Name = name;
            this.Score = score;
            this.CaveType = cave;
            Turns = turns;
            Gold = gold;
            Arrows = arrows;
            WumpusDead = wumpusDead;
        }
        public ScoreItem() { }
        public bool Equals(ScoreItem score)
        {
            return Name == score.Name && Score == score.Score && CaveType == score.CaveType;
        }
    }
}


