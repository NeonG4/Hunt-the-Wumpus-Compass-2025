using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cave;

namespace _2030638_Choy_CaveTestUI
{
    public partial class Form1 : Form
    {
        CaveManager cave = new CaveManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdjacent_Click(object sender, EventArgs e)
        {
            try
            {
                //Room number

                int room = int.Parse(textBoxRoom.Text);

                if (0 <= room && room <= 29)
                {
                    //Get adjacent rooms

                    int[] adjacentRooms = cave.GetAdjacentRooms(room);

                    //Output

                    string output = "";

                    foreach (int i in adjacentRooms)
                    {
                        output += (i + " ");
                    }

                    textBoxAdjacent.Text = output;
                }
            }
            catch
            {
                MessageBox.Show("needs room number (0-29)");
            }
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            try
            {
                //Info from UI

                int room = int.Parse(textBoxRoom.Text);
                int caveIndex = int.Parse(textBoxCaveIndex.Text);

                if (0 <= room && room <= 29 &&
                0 <= caveIndex && caveIndex <= 4)
                {
                    //Get valid rooms

                    int[] validDirections = cave.GetValidDirections(room, caveIndex);

                    //Output

                    string output = "";

                    foreach (int i in validDirections)
                    {
                        output += (i + " ");
                    }

                    textBoxValid.Text = output;
                }
            }
            catch
            {
                MessageBox.Show("needs room (0-29), cave index (0-4)");
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

                if (0 <= room && room <= 29 &&
                0 <= direction && direction <= 5 &&
                0 <= caveIndex && caveIndex <= 4)
                {
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
            }
            catch
            {
                MessageBox.Show("needs room (0-29), direction (0-5), and cave index (0-4)");
                return;
            }
        }

        private void buttonGetNewRoom_Click(object sender, EventArgs e)
        {
            try
            {
                //Info from UI

                int room = int.Parse(textBoxRoom.Text);
                int direction = int.Parse(textBoxDirection.Text);

                if (0 <= room && room <= 29 &&
                0 <= direction && direction <= 5)
                {
                    //Get new room

                    int newRoom = cave.GetNewRoomNumber(room, direction);

                    //Output

                    textBoxNewRoomNumber.Text = newRoom.ToString();
                }
            }
            catch
            {
                MessageBox.Show("needs room (0-29), direction (0-5)");
                return;
            }
        }
    }
}
