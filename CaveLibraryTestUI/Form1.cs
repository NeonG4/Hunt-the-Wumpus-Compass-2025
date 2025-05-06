using CaveLibrary;

namespace CaveLibraryTestUI
{
    public partial class Form1 : Form
    {
        //Initialize at first cave # for now

        CaveManager cave = new CaveManager(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdjacent_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Room number

                int room = int.Parse(textBoxRoom.Text);

                if (0 <= room && room <= 29)
                {
                    //Get adjacent rooms

                    int[] adjacentRooms = cave.GetAdjacentRooms();

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

        private void buttonValid_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Info from UI

                int room = int.Parse(textBoxRoom.Text);
                int caveIndex = int.Parse(textBoxCaveIndex.Text);

                if (0 <= room && room <= 29 &&
                0 <= caveIndex && caveIndex <= 4)
                {
                    //Get valid directions bool array

                    cave.CaveIndex = caveIndex;
                    bool[] directionsBoolArray = cave.GetDirectionsBoolArray();

                    //Output

                    string output = "";

                    foreach (bool b in directionsBoolArray)
                    {
                        output += (b + " ");
                    }

                    textBoxReachableDirections.Text = output;
                }
            }
            catch
            {
                MessageBox.Show("needs room (0-29), cave index (0-4)");
                return;
            }
        }

        private void buttonMoveValid_Click_1(object sender, EventArgs e)
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

                    bool result = cave.IsValidMove(direction);

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

        private void buttonGetNewRoom_Click_1(object sender, EventArgs e)
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

                    int newRoom = cave.GetNewRoomNumber(direction);

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

        private void textBoxRoom_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                cave.Room = int.Parse(textBoxRoom.Text);

                if (!(0 <= cave.Room && cave.Room <= 29))
                {
                    MessageBox.Show("Room must be between 0-29 inclusive");
                }
            }
            catch
            {
                if (!(textBoxRoom.Text == ""))
                {
                    MessageBox.Show("Invalid room");
                }
            }
        }
    }
}
