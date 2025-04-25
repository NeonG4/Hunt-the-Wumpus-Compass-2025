using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hunt_the_Wumpus_2025
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
            string h = string.Empty;
            int r = 0;
            Hazards newHazard = new Hazards(h, r);
            int number;
            for (int room = 0; room < 2; room++)
            {
                do
                {
                    number = random.Next(1, 31);
                } while (newHazard.room == number);
                h = "Pit";
                hazards.Add(newHazard);
                listBox1.Items.Add(newHazard);
            }
            for (int room = 0; room < 2; room++)
            {
                do
                {
                    number = random.Next(1, 31);
                } while (newHazard.room == number);
                h = "Bats";
                hazards.Add(newHazard);
                listBox1.Items.Add(newHazard);
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
