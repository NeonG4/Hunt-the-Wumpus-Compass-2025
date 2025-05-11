using System.Drawing.Text;

namespace UI_Class_Library
{
    public class UIClassManager : IUIClassManager
    {
        static float aspectRatio = 16f / 9f;
        public int width, height;
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
            float scaleFactor = width / 940f;
            SolidBrush shapeBrush = new SolidBrush(Color.FromArgb(217, 217, 217));
            Pen outlineBrush = new Pen(Color.FromArgb(0, 0, 0), 4);
            e.Graphics.Clear(Color.FromArgb(76, 76, 76));

            //DebugOnlyRenderGridPoints(e, 20); // makes it easy to draw on the screen

            // renders title header
            Point titlePosition = new Point(width / 2, 100);
            Point[] titleHexagon = HexagonH(800, 100, 40, titlePosition);
            e.Graphics.FillPolygon(shapeBrush, titleHexagon);
            e.Graphics.DrawPolygon(outlineBrush, titleHexagon);
            DrawText(e, "Hunt the Wumpus", 41, titlePosition, Color.FromArgb(0, 0, 0));
            // renders subtext
            DrawText(e, "David Stall / Nathan Choy / Camilla Meija / Maxim Delyagin / Azeem Egizi", 12, new Point(width / 2, 200), Color.FromArgb(255, 255, 255));
            DrawText(e, "Made for Microsoft’s 2025 Hunt the Wumpus Challenge", 18, new Point(width / 2, 250), Color.FromArgb(255, 255, 255));
            // render maps
            string[] mapNames = ["Purple Lagoon", "Green Grotto", "Teal Tunnel", "Cyan Cavity", "Black Borehole"];
            SolidBrush purpleBrush = new SolidBrush(Color.FromArgb(142, 124, 195));
            SolidBrush greenBrush = new SolidBrush(Color.FromArgb(147, 196, 125));
            SolidBrush tealBrush = new SolidBrush(Color.FromArgb(111, 168, 220));
            SolidBrush cyanBrush = new SolidBrush(Color.FromArgb(118, 165, 175));
            SolidBrush blackBrush = new SolidBrush(Color.FromArgb(67, 67, 67));
            Brush[] brushes = [purpleBrush, greenBrush, tealBrush, cyanBrush, blackBrush];
            int spacing = (int)(80 * scaleFactor);
            int mapWidth = (int)((width / 5f)-(spacing*(4f/5f)));
            for (int i = 0; i < 5; i++)
            {
                Point position = new Point(i * (mapWidth + spacing) + (mapWidth / 2), height);
                Point[] hexagon = HexagonV(mapWidth, (int) (height * 0.8), (int)(height * 0.08), position);
                e.Graphics.FillPolygon(brushes[i], hexagon);
                e.Graphics.DrawPolygon(outlineBrush, hexagon);
                DrawText(e, mapNames[i], (int) (scaleFactor * 6), new Point(position.X, (int) (position.Y - 80)), Color.FromArgb(255, 255, 255));
                }
        }
        private void DrawText(PaintEventArgs e, string text, int size, Point position, Color c)
        {
            Font font = new Font(comfortaaCollection.Families[0], size);
            SolidBrush textBrush = new SolidBrush(c);
            float height = font.GetHeight();
            float width = e.Graphics.MeasureString(text, font).Width;
            e.Graphics.DrawString(text, font, textBrush, new Point((int)(position.X - width / 2), (int)(position.Y - height/2)));
        }
        /// <summary>
        /// A hexagon with a flat top
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="padding"></param>
        /// <param name="position"></param>
        /// <returns>A point array of hexagon boarder points</returns>
        private Point[] HexagonH(int width, int height, int padding, Point position)
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
        /// <summary>
        /// A hexagon with a vertical top
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="padding"></param>
        /// <param name="position"></param>
        /// <returns>A point array of hexagon boarder points</returns>
        private Point[] HexagonV(int width, int height, int padding, Point position)
        {
            List<Point> points = new List<Point>();
            int x = position.X;
            int y = position.Y;
            int leftLevel = x - (width / 2); // leftmost point on hexagon
            int rightLevel = x + (width / 2); // rightmost point on hexagon
            int topMostPoint = y - (height / 2); // highest point on hexagon
            int bottomMostPoint = y + (height / 2); // lowest point on hexagon
            points.Add(new Point(x, topMostPoint));
            points.Add(new Point(rightLevel, topMostPoint + padding));
            points.Add(new Point(rightLevel, bottomMostPoint - padding));
            points.Add(new Point(x, bottomMostPoint));
            points.Add(new Point(leftLevel, bottomMostPoint - padding));
            points.Add(new Point(leftLevel, topMostPoint + padding));
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
        /// <summary>
        /// Gets the width, and updates the screen size
        /// </summary>
        /// <param name="width">The width in pixels of the form</param>
        /// <param name="height">The height in pixels of the form</param>
        public void UpdateScreenSize(int width, int height)
        {
            this.width = width;
            this.height = (int) (width * (1/aspectRatio));
            if (width < 960 || height < 540)
            {
                this.width = 960;
                this.height = 540;
            }
        }
    }
    public interface IUIClassManager
    {
        public void RenderGame(PaintEventArgs e, bool[] doorsout); // requires PaintEventArgs to draw to the win form
        public void RenderGameUI(PaintEventArgs e); // requires PaintEventArgs to draw to the win form
        public void RenderMainMenu(PaintEventArgs e);
        public bool[] GetInputs(); // returns an array of binary values, 0 if pressed, 1 if 0. Changes depending on scene
        public void UpdateScreenSize(int width, int height);
    }
}
