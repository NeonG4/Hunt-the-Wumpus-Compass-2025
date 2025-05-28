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
using CaveLibrary;
using PlayerLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GameLocationLibrary
{
    public partial class GameLocationTest : Form
    {
        public List<Hazards> hazards = new List<Hazards>();
        public List<Hazards> allSpawnables = new List<Hazards>();
        Random random = new Random();
        int wumpusspawn = 31;
        int playerspawn = 31;
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
                //Generates a random integer that represents a random room 
                Hazards newHazard = new Hazards(hazard, number);
                bool tmp = true;
                //Cycles through the hazards list until the random room is a unique value
                for (int i = 0; i < hazards.Count; i++)
                {
                    if (hazards[i].room == number)
                    {
                        tmp = false;
                        i = hazards.Count();
                    }
                }
                // If the number generated is unique, add the new hazard
                if (tmp)
                {
                    hazards.Add(newHazard);
                    allSpawnables.Add(newHazard);
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
                int playerstart = random.Next(0, 30);
                //Generates a random integer that represents a random room 
                Hazards newHazard = new Hazards("Player", playerstart);
                bool tmp = true;
                //Cycles through the list of hazards/wumpus until the random room is a unique value
                for (int i = 0; i < allSpawnables.Count; i++)
                {
                    if (allSpawnables[i].room == playerstart)
                    {
                        tmp = false;
                        i = allSpawnables.Count();
                    }
                }
                // If the number generated is unique, spawn the player
                if (tmp)
                {
                    playerspawn = playerstart;
                    listBoxHazards.Items.Add("Room " + newHazard + ": Player").ToString();
                    return playerstart;
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
                int wumpusstart = random.Next(0, 30);
                //Generates a random integer that represents a random room 
                Hazards newHazard = new Hazards("Wumpus", wumpusstart);
                bool tmp = true;
                //Checks for uniqeness between the player's starting room and the Wumpus's starting room
                if (playerspawn == wumpusstart)
                {
                    tmp = false;

                }
                // If the number generated is unique from the player's, spawn the Wumpus
                if (tmp)
                {
                    allSpawnables.Add(newHazard);
                    wumpusspawn = wumpusstart;
                    listBoxHazards.Items.Add("Room " + newHazard + ": Wumpus").ToString();
                    return wumpusstart;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int room = int.Parse(textBox1.Text);
                bool[] hazardChecker = CheckForHazard(room);
                textBox2.Text = ("Wumpus: " + hazardChecker[0] + ", Bats: " + hazardChecker[1] + ", Pit: " + hazardChecker[2]).ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a number");
            }
        }

        public bool[] CheckForHazard(int currentRoom)
        {
            bool[] hazardChecker = [false, false, false];
            for (int i = 0; i < allSpawnables.Count; i++)
            {
                if (allSpawnables[i].room == currentRoom)
                {
                    if (allSpawnables[i].hazard == "Wumpus")
                    {
                        hazardChecker[0] = true;
                    }
                    if (allSpawnables[i].hazard == "Bats")
                    {
                        hazardChecker[1] = true;
                    }
                    if (allSpawnables[i].hazard == "Pit")
                    {
                        hazardChecker[2] = true;
                    }
                }
            }
            return hazardChecker;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int room = int.Parse(textBox1.Text);
                bool[] hazardChecker = CheckForHazard(room);
                textBox2.Text = ("Wumpus: " + hazardChecker[0] + ", Bats: " + hazardChecker[1] + ", Pit: " + hazardChecker[2]).ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a number");
            }
        }
    }
}
