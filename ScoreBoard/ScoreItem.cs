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

        public ScoreItem(string name, int score, string cave)
        {


            this.Name = name;
            this.Score = score;
            this.CaveType = cave;
        }


    }
}


