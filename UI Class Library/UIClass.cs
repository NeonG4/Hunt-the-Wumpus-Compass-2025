using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hunt_the_Wumpus_2025
{
    public class UIClass
    {
    }
    public interface IUIClass
    {
        public void Render(PaintEventArgs e); // requires PaintEventArgs to draw to the win form
        public void RenderUI(PaintEventArgs e); // requires PaintEventArgs to draw to the win form
    }
}
