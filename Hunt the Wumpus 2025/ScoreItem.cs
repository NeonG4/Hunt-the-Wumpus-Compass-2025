using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus_2025
{
    public class ScoreItem
    {
        private string Name { get; set; }
        private int Score { get; set; } 
        private string CaveType { get; set; }

        public ScoreItem(string name, int score, string cave)
        {
            

            this.Name = name;
            this.Score = score;
            this.CaveType = cave;
        }

        
    }
}
