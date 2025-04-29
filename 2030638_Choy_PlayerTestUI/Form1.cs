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

                if (playerManager.AddOrSubtractGoldCoins(isAddition, amount))
                {

                }
                else
                {
                    MessageBox.Show("Not enough arrows");
                    return;
                }

                //Display to UI

                textBoxArrows.Text = playerManager.Arrows.ToString();
            }
            catch
            {
                MessageBox.Show("Needs integer amount");
                return;
            }
        }
    }
}
