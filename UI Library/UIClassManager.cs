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
        PrivateFontCollection comfortaaCollection = new PrivateFontCollection();
        Font comfortaa;
        // Provide the path to the font on the filesystem
        public UIClassManager()
        {
            // standard size of a google slide, same size that this game is
            width = 960;
            height = 540;
            comfortaaCollection.AddFontFile("Comfortaa-Light.ttf"); // adds the font file
            comfortaa = new Font((FontFamily)comfortaaCollection.Families[0], 41f);
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
            SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, 255, 255));
            SolidBrush shapeBrush = new SolidBrush(Color.FromArgb(127, 127, 127));
            e.Graphics.Clear(Color.FromArgb(76, 76, 76));
            DebugOnlyRenderGridPoints(e, 20); // makes it easy to draw on the screen
            
           e.Graphics.FillPolygon(shapeBrush, Hexagon(500, 100, 40, new Point(width / 2, 200)));
            e.Graphics.DrawString("Hunt the Wumpus", comfortaa, textBrush, new Point(100, 100));
        }
        private Point[] Hexagon(int width, int height, int padding, Point position)
        {
            List<Point> points = new List<Point>();
            int x = position.X;
            int y = position.Y;
            points.Add(new Point(width / 2 - x, y));
            points.Add(new Point(width / 2 - x + padding, height / 2 - y));
            points.Add(new Point(width / 2 + x - padding, height / 2 - y));
            return points.ToArray();
        }
        private void DebugOnlyRenderGridPoints(PaintEventArgs e, int size)
        {
            SolidBrush b = new SolidBrush(Color.FromArgb(255, 0, 0));
            for (int i = 0; i < width; i+= size)
            {
                for (int j = 0; j < height; j += size)
                {
                    Rectangle rect = new Rectangle(i - 1, j - 1, 2, 2);
                    e.Graphics.FillRectangle(b, rect);
                }
            }
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
