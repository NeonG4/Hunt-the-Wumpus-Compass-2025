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
        public UIClassManager()
        {
            // standard size of a google slide, same size that this game is
            width = 960;
            height = 540;
            comfortaaCollection.AddFontFile("Comfortaa-Light.ttf"); // adds the font file
        }
        /// <summary>
        /// Renders the game state
        /// </summary>
        /// <param name="e">PaintEventArgs passed through Paint Form Event</param>
        /// <param name="doorsOut">The valid doors out of the room</param>
        public void RenderGame(PaintEventArgs e, bool[] doorsOut)
        {
            e.Graphics.Clear(Color.FromArgb(0, 0, 0));
        }
        public void RenderGameUI(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(0, 0, 0));
        }
        /// <summary>
        /// Renders the title screen where the user starts
        /// </summary>
        /// <param name="e">PaintEventArgs passed through Paint Form Event</param>
        public void RenderMainMenu(PaintEventArgs e)
        {
            SolidBrush shapeBrush = new SolidBrush(Color.FromArgb(217, 217, 217));
            Pen outlineBrush = new Pen(Color.FromArgb(0, 0, 0), 4);
            e.Graphics.Clear(Color.FromArgb(76, 76, 76));
            
            DebugOnlyRenderGridPoints(e, 20); // makes it easy to draw on the screen

            Point titlePosition = new Point(width / 2, 100);
            Point[] titleHexagon = Hexagon(600, 100, 40, titlePosition);
            e.Graphics.FillPolygon(shapeBrush, titleHexagon);
            e.Graphics.DrawPolygon(outlineBrush, titleHexagon);
            DrawText(e, "Hunt the Wumpus", 41, titlePosition, Color.FromArgb(0, 0, 0));
        }
        private void DrawText(PaintEventArgs e, string text, int size, Point position, Color c)
        {
            Font font = new Font(comfortaaCollection.Families[0], size);
            SolidBrush textBrush = new SolidBrush(c);
            float height = font.GetHeight();
            float width = e.Graphics.MeasureString(text, font).Width;
            e.Graphics.DrawString(text, font, textBrush, new Point((int)(position.X - width / 2), (int)(position.Y - height/2)));
        }
        private Point[] Hexagon(int width, int height, int padding, Point position)
        {
            List<Point> points = new List<Point>();
            int x = position.X;
            int y = position.Y;
            int leftMostPoint = x - (width / 2); // leftmost point on hexagon
            int rightMostPoint = x + (width / 2); // rightmost point on hexagon
            int topLevel = y - (height / 2); // highest point on hexagon
            int bottomLevel = y + (height / 2); // lowest point on hexagon
            points.Add(new Point(leftMostPoint, y));
            points.Add(new Point(leftMostPoint + padding, bottomLevel));
            points.Add(new Point(rightMostPoint - padding, bottomLevel));
            points.Add(new Point(rightMostPoint, y));
            points.Add(new Point(rightMostPoint - padding, topLevel));
            points.Add(new Point(leftMostPoint + padding, topLevel));
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
        /// <summary>
        /// Gets the inputs for the current rendered state
        /// </summary>
        /// <returns>Returns a dynamic-length bool array of inputs</returns>
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
