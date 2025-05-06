using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accessibility;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GameLocationLibrary
{
    public partial class GameLocationTest : Form
    {
        public List<Hazards> hazards = new List<Hazards>();
        public List<Hazards> allHazards = new List<Hazards>();
        Random random = new Random();
        public GameLocationTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hazards.Count == 0)
            {
                AddHazard("Pit");
                AddHazard("Pit");
                AddHazard("Bats");
                AddHazard("Bats");
                button1.Enabled = false;
            }

        }
        private void AddHazard(string hazard)
        {
            while (true)
            {
                int number = random.Next(0, 30);
                Hazards newHazard = new Hazards(hazard, number);
                bool tmp = true;
                for (int i = 0; i < hazards.Count; i++)
                {
                    if (hazards[i].room == number)
                    {
                        tmp = false;
                        i = hazards.Count();
                    }
                }
                if (tmp)
                {
                    hazards.Add(newHazard);
                    allHazards.Add(newHazard);
                    listBoxHazards.Items.Add("Room " + newHazard + ": " + hazard).ToString();
                    return;
                }
            }
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            SpawnPlayer();
            button2.Enabled = false;
        }

        public int SpawnPlayer()
        {
            while (true)
            {
                int startingroom = random.Next(0, 30);
                Hazards newHazard = new Hazards("Player", startingroom);
                bool tmp = true;
                for (int i = 0; i < allHazards.Count; i++)
                {
                    if (allHazards[i].room == startingroom)
                    {
                        tmp = false;
                        i = allHazards.Count();
                    }
                }
                if (tmp)
                {
                    allHazards.Add(newHazard);
                    listBoxHazards.Items.Add("Room " + newHazard + ": Player").ToString();
                    return startingroom;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SpawnWumpus();
            button3.Enabled = false;
        }

        public int SpawnWumpus()
        {
            while (true)
            {
                int wumpusspawn = random.Next(0, 30);
                Hazards newHazard = new Hazards("Wumpus", wumpusspawn);
                bool tmp = true;
                for (int i = 0; i < allHazards.Count; i++)
                {
                    if (allHazards[i].room == wumpusspawn)
                    {
                        tmp = false;
                        i = allHazards.Count();
                    }
                }
                if (tmp)
                {
                    allHazards.Add(newHazard);
                    listBoxHazards.Items.Add("Room " + newHazard + ": Wumpus").ToString();
                    return wumpusspawn;
                }
            }
        }
    }
}
