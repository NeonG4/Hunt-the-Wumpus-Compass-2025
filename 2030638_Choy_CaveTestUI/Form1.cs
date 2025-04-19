using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaveManager;

namespace _2030638_Choy_CaveTestUI
{
    public partial class Form1 : Form
    {
        CaveActions cave = new CaveActions();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdjacent_Click(object sender, EventArgs e)
        {
            //Room number

            int room = int.Parse(textBoxRoom.Text);

            //Get adjacent rooms

            int[] adjacentRooms = cave.GetAdjacentRooms(room);

            //Output

            string output = "";

            foreach (int i in adjacentRooms)
            {
                output += (i + ",");
            }

            textBoxAdjacent.Text = output;
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            try
            {
                //Info from UI

                int room = int.Parse(textBoxRoom.Text);
                int caveIndex = int.Parse(textBoxCaveIndex.Text);

                //Get valid rooms

                int[] reachableRooms = cave.GetReachableNeighboringRooms(room, caveIndex);

                //Output

                string output = "";

                foreach (int i in reachableRooms)
                {
                    output += (i + ",");
                }

                textBoxValid.Text = output;
            }
            catch
            {
                MessageBox.Show("enter valid values");
                return;
            }
        }

        private void buttonMoveValid_Click(object sender, EventArgs e)
        {
            try
            {
                //Info from UI

                int room = int.Parse(textBoxRoom.Text);
                int direction = int.Parse(textBoxDirection.Text);
                int caveIndex = int.Parse(textBoxCaveIndex.Text);

                //Get bool result

                bool result = cave.IsValidMove(room, direction, caveIndex);

                //Output

                if (result)
                {
                    labelValid.Text = "Yes";
                }
                else
                {
                    labelValid.Text = "No";
                }
            }
            catch
            {
                MessageBox.Show("enter valid values");
                return;
            }
        }
    }
}
