using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Control;

namespace Hunt_the_Wumpus_2025
{
    public partial class FormGame : Form
    {
        private bool ready = false;
        private GameControl gc;
        public FormGame()
        {
            InitializeComponent();
            gc = new GameControl();
            ready = true;
        }
        private void FormGame_Paint(object sender, PaintEventArgs e)
        {
            if (ready)
            {
                // ticks the game control
                gc.Tick(e);
            }
        }

        private void timerTicker_Tick(object sender, EventArgs e)
        {
            if (ready)
            {
                // tick should be called here, but currently tick is called in the draw method
                this.Refresh();
            }
        }
    }
}
