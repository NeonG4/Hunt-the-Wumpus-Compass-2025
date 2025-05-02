using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accessibility;

namespace GameLocationLibrary
{
    public partial class HazardsTest : Form
    {
        public List<Hazards> hazards = new List<Hazards>();
        Random random = new Random();
        public HazardsTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hazards.Count > 4)
            {
                AddHazard("Pit");
                AddHazard("Pit");
                AddHazard("Bats");
                AddHazard("Bats");
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
                    listBox1.Items.Add(newHazard);
                    return;
                }
            }
        }
            

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Hazards selectedHazard)
            {
                label1.Text = selectedHazard.hazard.ToString();
            }
        }
    }
}
