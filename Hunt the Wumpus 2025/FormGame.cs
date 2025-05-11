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
                gc._UIClassManager.UpdateScreenSize(this.Width, this.Height);
                this.Width = gc._UIClassManager.width;
                this.Height = gc._UIClassManager.height + (this.RectangleToScreen(this.ClientRectangle).Top - this.Top); // accounts for windows bar
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
    }
}
