using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Player;

namespace _2030638_Choy_PlayerTestUI
{
    public partial class Form1 : Form
    {
        PlayerManager playerManager = new PlayerManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArrows_Click(object sender, EventArgs e)
        {
            try
            {
                //Info from UI

                int amount = int.Parse(textBoxAmount.Text);
                bool isAddition = checkBoxIsAddition.Checked;

                //Call method

                if (playerManager.AddOrSubtractArrows(isAddition, amount))
                {
                    //Display to UI

                    textBoxArrows.Text = playerManager.Arrows.ToString();
                }
                else
                {
                    MessageBox.Show("Not enough arrows!");
                }
            }
            catch
            {
                MessageBox.Show("Needs integer amount");
            }
        }

        private void buttonCoins_Click(object sender, EventArgs e)
        {
            try
            {
                //Info from UI

                int amount = int.Parse(textBoxAmount.Text);
                bool isAddition = checkBoxIsAddition.Checked;

                //Call method

                if (playerManager.AddOrSubtractGoldCoins(isAddition, amount))
                {
                    //Display to UI

                    textBoxCoins.Text = playerManager.GoldCoins.ToString();
                }
                else
                {
                    MessageBox.Show("Not enough coins! You lose!!");
                }
            }
            catch
            {
                MessageBox.Show("Needs integer amount");
            }
        }

        private void buttonIncrement_Click(object sender, EventArgs e)
        {
            //Call method

            playerManager.IncrementMoveCount();

            //Display to UI

            textBoxMoves.Text = playerManager.MoveCount.ToString();
        }

        private void buttonGetScore_Click(object sender, EventArgs e)
        {
            //Call method

            int score = playerManager.GetEndingScore();

            //Display to UI

            textBoxScore.Text = score.ToString();
        }

        private void checkBoxKilledWumpus_CheckedChanged(object sender, EventArgs e)
        {
            //Call method to change wumpus killed bool

            playerManager.KilledWumpus = checkBoxKilledWumpus.Checked;
        }
    }
}
