using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            while (listBox1.Items.Count < 2)
            {
                addHazard("Pit");
            }
            while (listBox1.Items.Count < 4)
            {
                addHazard("Bats");
            }
            
        }

        private void addHazard(string hazard)
        {
            int number = random.Next(1, 31);
            Hazards newHazard = new Hazards(hazard, number);
            if (!listBox1.Items.Contains(number))
            {
                hazards.Add(newHazard);
                listBox1.Items.Add(newHazard.room);
            }
        }
            

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Hazards selectedHazard)
            {
                label1.Text = selectedHazard.room.ToString();
            }
        }
    }
}
