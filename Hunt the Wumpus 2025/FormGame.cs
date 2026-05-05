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
        public GameControl gc;
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
                
                gc._UIClassManager.UpdateScreenSize(this.Width, this.Height);
                // game control is the manager for the form, update the black box size there
                /*
                gc.vwidth = gc._UIClassManager.width;
                gc.vheight = gc._UIClassManager.height + (this.RectangleToScreen(this.ClientRectangle).Top - this.Top); // accounts for windows bar
            */
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

        private void FormGame_MouseMove(object sender, MouseEventArgs e)
        {
            gc._UIClassManager.UpdateMousePosition(e.Location);
        }

        private void FormGame_MouseDown(object sender, MouseEventArgs e)
        {
            gc._UIClassManager.UpdateMouseClicked(true);
        }

        private void FormGame_MouseUp(object sender, MouseEventArgs e)
        {
            gc._UIClassManager.UpdateMouseClicked(false);
        }

        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            // needed for unmanaged memory
            gc.StopGame();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }
    }
}
