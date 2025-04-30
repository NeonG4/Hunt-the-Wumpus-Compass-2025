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
            addHazard("Pit");
            addHazard("Pit");
            addHazard("Bats");
            addHazard("Bats");
        }

        private void addHazard(string hazard)
        {
            int number = random.Next(1, 31);
            Hazards newHazard = new Hazards(hazard, number);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                var item = listBox1.Items[i];
                if (item.ToString() == number.ToString())
                {
                    
                }
                else
                {
                    
                }
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
