using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;

namespace UI_Class_Library
{
    public class UIClassManager : IUIClassManager
    {
        int width, height;
        public UIClassManager()
        {
            // standard size of a google slide, same size that this game is
            width = 960;
            height = 540; 
        }
        public void RenderGame(PaintEventArgs e, bool[] doorsOut)
        {
            e.Graphics.Clear(Color.FromArgb(0, 0, 0));
        }
        public void RenderGameUI(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(0, 0, 0));
        }
        public void RenderMainMenu(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(76, 76, 76));
            Font comfertaa = new Font("Comfortaa", 41);
            SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, 255, 255));
            e.Graphics.DrawString("Hunt the Wumpus", comfertaa, textBrush, new Point(100, 100));
            
        }
        public bool[] GetInputs()
        {
            bool[] controls = new bool[3];
            controls[0] = true;
            controls[1] = false;
            controls[2] = true;
            return controls;
        }
    }
    public interface IUIClassManager
    {
        public void RenderGame(PaintEventArgs e, bool[] doorsout); // requires PaintEventArgs to draw to the win form
        public void RenderGameUI(PaintEventArgs e); // requires PaintEventArgs to draw to the win form
        public void RenderMainMenu(PaintEventArgs e);
        public bool[] GetInputs(); // returns an array of binary values, 0 if pressed, 1 if 0. Changes depending on scene
    }
}
