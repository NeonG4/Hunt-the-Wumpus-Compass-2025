using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace UI_Class_Library
{
    public class UIClassManager : IUIClassManager
    {
        public string _scene { get; set; } 
        public void RenderGame(PaintEventArgs e, bool[] doorsout)
        {
            e.Graphics.Clear(Color.FromArgb(0, 0, 0));
        }
        public void RenderGameUI(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(0, 0, 0));
        }
        public void RenderMainMenu(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(0, 0, 0));
        }
        public void GetInputs(ref bool[] controls)
        {
            controls = new bool[3];
            controls[0] = true;
            controls[1] = false;
            controls[2] = true;
        }
    }
    public interface IUIClassManager
    {
        public void RenderGame(PaintEventArgs e, bool[] doorsout); // requires PaintEventArgs to draw to the win form
        public void RenderGameUI(PaintEventArgs e); // requires PaintEventArgs to draw to the win form
        public void RenderMainMenu(PaintEventArgs e);
        public void GetInputs(ref bool[] controls); // returns an array of binary values, 0 if pressed, 1 if 0. Changes depending on scene
    }
}
