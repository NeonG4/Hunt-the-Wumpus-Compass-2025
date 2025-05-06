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
        private GameControl gc;
        public FormGame()
        {
            InitializeComponent();
            gc = new GameControl();
        }
        private void FormGame_Paint(object sender, PaintEventArgs e)
        {
            // ticks the game control
            gc.Tick(e);
        }

        private void timerTicker_Tick(object sender, EventArgs e)
        {
            // tick should be called here, but currently tick is called in the draw method
            this.Refresh(); 
        }
    }
}
