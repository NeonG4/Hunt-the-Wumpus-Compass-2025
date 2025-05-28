using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Net.Http.Headers;
using System.Text;
using PlayerLibrary;
using static System.Formats.Asn1.AsnWriter;
namespace UI_Class_Library
{
    public class UIClassManager : IUIClassManager
    {
        static float aspectRatio = 16f / 9f;
        public int width, height;


        public Point mouse = new Point();
        public bool mouseDown = false;
        public bool mouseDownBuffer = false;
        Bitmap amethystImage = new Bitmap("images/amythystabyss.jpg");
        Bitmap blackImage = new Bitmap("images/blackborehole.jpg");
        Bitmap diamondImage = new Bitmap("images/diamonddungeon.jpg");
        Bitmap greenImage = new Bitmap("images/greengrotto.jpg");
        Bitmap tealImage = new Bitmap("images/tealtunnel.jpg");

        PrivateFontCollection comfortaaCollection = new PrivateFontCollection();
        List<string> textBox = new List<string>(); // should be capped at 5 items
        int lastMapLocation;
        public int map = -1;
        private List<bool> inputs = new List<bool>();
        Color[,] gameColors =
        {
            { // testing map colors
                Color.FromArgb(7, 20, 40), // background color
                Color.FromArgb(103, 78, 167), // center color
                Color.FromArgb(7, 55, 99), // side panel color
                Color.FromArgb(50, 50, 50), // background color trivia
                Color.FromArgb(150, 150, 150), // forecolor trivia highlighted
                Color.FromArgb(125, 125, 125) // forecolor trivia
                
            },{ // testing map colors
                Color.FromArgb(7, 20, 40), // background color
                Color.FromArgb(103, 78, 167), // center color
                Color.FromArgb(7, 55, 99), // side panel color
                Color.FromArgb(50, 50, 50), // background color trivia
                Color.FromArgb(150, 150, 150), // forecolor trivia highlighted
                Color.FromArgb(125, 125, 125) // forecolor trivia
                
            },{ // testing map colors
                Color.FromArgb(7, 20, 40), // background color
                Color.FromArgb(103, 78, 167), // center color
                Color.FromArgb(7, 55, 99), // side panel color
                Color.FromArgb(50, 50, 50), // background color trivia
                Color.FromArgb(150, 150, 150), // forecolor trivia highlighted
                Color.FromArgb(125, 125, 125) // forecolor trivia
                
            },{ // testing map colors
                Color.FromArgb(7, 20, 40), // background color
                Color.FromArgb(103, 78, 167), // center color
                Color.FromArgb(7, 55, 99), // side panel color
                Color.FromArgb(50, 50, 50), // background color trivia
                Color.FromArgb(150, 150, 150), // forecolor trivia highlighted
                Color.FromArgb(125, 125, 125) // forecolor trivia
                
            },{ // testing map colors
                Color.FromArgb(7, 20, 40), // background color
                Color.FromArgb(103, 78, 167), // center color
                Color.FromArgb(7, 55, 99), // side panel color
                Color.FromArgb(50, 50, 50), // background color trivia
                Color.FromArgb(150, 150, 150), // forecolor trivia highlighted
                Color.FromArgb(125, 125, 125) // forecolor trivia
                
            },{ // testing map colors
                Color.FromArgb(7, 20, 40), // background color
                Color.FromArgb(103, 78, 167), // center color
                Color.FromArgb(7, 55, 99), // side panel color
                Color.FromArgb(50, 50, 50), // background color trivia
                Color.FromArgb(150, 150, 150), // forecolor trivia highlighted
                Color.FromArgb(125, 125, 125) // forecolor trivia
                
            },

        };
        public UIClassManager()
        {
            // standard size of a google slide, same size that this game is
            width = 960;
            height = 540;
            comfortaaCollection.AddFontFile("Comfortaa-Light.ttf"); // adds the font file
        }
        /// <summary>
        /// Renders the game state, returns the inputs
        /// </summary>
        /// <param name="e">PaintEventArgs e</param>
        /// <param name="doorsOut">bool[6] of valid exits</param>
        /// <param name="hazards">bool[6] of hazards</param>
        /// <param name="player">the current player</param>
        /// <returns>Returns the inputs as well as if you encountered any hazards</returns>
        public bool[] RenderGame(PaintEventArgs e, bool[] doorsOut, bool[] hazards, PlayerManager player)
        {
            Color mainColor = gameColors[map, 1];
            Color sidePanel = gameColors[map, 2];
            
            SolidBrush brush = new SolidBrush(sidePanel);
            SolidBrush hexagonBrush = new SolidBrush(mainColor);
            SolidBrush gameSelected = new SolidBrush(gameColors[map, 5]);
            SolidBrush gameUnselected = new SolidBrush(gameColors[map, 4]);
            SolidBrush roomBrush = new SolidBrush(Color.FromArgb(218, 218, 218));



            bool[] outputs = [false, false, false, false, false, false, false, false, false];

            int currentRoom = player.CurrentRoom;
            Color bgColor = gameColors[map, 0];
            e.Graphics.Clear(bgColor);
            Rectangle rect = new Rectangle((int)(height), 0, (int)(width-height), height);
            int radius = (int)(width * 0.2);
            Point centerHexagonPosition = new Point((int)(width * (1f / 3f)), (int)(height / 2f));
            e.Graphics.FillPolygon(hexagonBrush, HexagonPerfect(radius, centerHexagonPosition));
            Bitmap bmp;
            string name;
            switch (map)
            {
                case 0:
                    {
                        bmp = amethystImage;
                        name = "Amethyst Abyss";
                        break;
                    }
                case 1:
                    {
                        bmp = greenImage;
                        name = "Green Grotto";
                        break;
                    }
                case 2:
                    {
                        bmp = tealImage;
                        name = "Teal Tunnel";
                        break;
                    }
                case 3:
                    {
                        bmp = diamondImage;
                        name = "Diamond Dungeon";
                        break;
                    }
                case 4:
                    {
                        bmp = blackImage;
                        name = "Black Borehole";
                        break;
                    }
                default:
                    {
                        throw new Exception($"Invalid map number: {map}");
                    }
            }
            e.Graphics.DrawImage(bmp, new Rectangle(1, 1, height, height));
            // render the right panel
            float padding = 2f;
            int paddingPx = (int)(padding * (height / 54f));
            int widthOfPanel = width - height;
            Point topLeft = new Point(height, 0);

            RectangleF header = new RectangleF(topLeft.X + paddingPx, topLeft.Y + paddingPx, widthOfPanel - (2 * paddingPx), height / 5f);
            e.Graphics.FillRectangle(gameUnselected, header);

            RectangleF shootArrow = new RectangleF(topLeft.X + paddingPx, header.Y + header.Height + padding, (widthOfPanel - (paddingPx * 2)) / 4f, (widthOfPanel - (paddingPx * 2)) / 4f);
            RectangleF buyArrow = new RectangleF(topLeft.X + (width - height) / 2f - (shootArrow.Width / 2f), header.Y + header.Height + padding, shootArrow.Width, shootArrow.Height);
            RectangleF buySecret = new RectangleF(width - paddingPx - shootArrow.Width, header.Y + header.Height + padding, shootArrow.Width, shootArrow.Height);
            
            if (shootArrow.Contains(mouse))
            {
                e.Graphics.FillRectangle(gameSelected, shootArrow);
                if (mouseDown)
                {
                    mouseDown = false;
                    outputs[6] = true;
                }
            }
            else
            {
                e.Graphics.FillRectangle(gameUnselected, shootArrow);
            }
            if (buyArrow.Contains(mouse))
            {
                e.Graphics.FillRectangle(gameSelected, buyArrow);
                if (mouseDown)
                {
                    mouseDown = false;
                    outputs[7] = true;
                }
            }
            else
            {
                e.Graphics.FillRectangle(gameUnselected, buyArrow);
            }
            if (buySecret.Contains(mouse))
            {
                e.Graphics.FillRectangle(gameSelected, buySecret);
                if (mouseDown)
                {
                    mouseDown = false;
                    outputs[8] = true;
                }
            }
            else
            {
                e.Graphics.FillRectangle(gameUnselected, buySecret);
            }
            

            Point headerCenter = new Point(height + (int)(widthOfPanel / 2f), (int)(height / 16f) + paddingPx);
            DrawText(e, name, (int)(height / 23), headerCenter, Color.FromArgb(0, 0, 0));
            DrawText(e, "Hunt the Wumpus", (int)(height / 54), new Point(headerCenter.X, (int)(headerCenter.Y + (height / 10f))), Color.FromArgb(0, 0, 0));
           
            // doorway rendering
            Size roomSize = new Size(40, 40);
           // render the rooms around the hexagon
            for (int i = 0; i < 6; i++)
            {
                if (doorsOut[i])
                {
                    Rectangle rectRoom = new Rectangle(new Point((int)(centerHexagonPosition.X + radius * Math.Cos((-2 + i) * Math.PI / 3 + Math.PI / 6)), (int)(centerHexagonPosition.Y + radius * Math.Sin((-2 + i) * Math.PI / 3 + Math.PI / 6))), roomSize);
                    e.Graphics.FillEllipse(roomBrush, rectRoom);
                    float distance = (float)Math.Sqrt((mouse.X - (rectRoom.X + 20)) * (mouse.X - (rectRoom.X + 20)) + (mouse.Y - (rectRoom.Y + 20)) * (mouse.Y - (rectRoom.Y + 20)));
                    if (distance < 20 && mouseDown)
                    {
                        outputs[i] = true;
                        mouseDown = false;
                    }
                    
                }
            }
            // also needs to render hazards
            if (hazards[0]) // wumpus in room
            {
                DrawText(e, "Wumpus", 20, centerHexagonPosition, Color.FromArgb(255, 255, 255));
            }
            if (hazards[1]) // bat in room
            {
                DrawText(e, "Bat", 20, centerHexagonPosition, Color.FromArgb(255, 255, 255));
            }
            if (hazards[2]) // pit in room
            {
                DrawText(e, "Pit", 20, centerHexagonPosition, Color.FromArgb(255, 255, 255));
            }
            if (lastMapLocation != currentRoom) 
            {
                lastMapLocation = currentRoom;
                if (hazards[3])
                {
                    textBox.Add("Wumpus");
                }
                if (hazards[4])
                {
                    textBox.Add("Bat");
                }
                if (hazards[5])
                {
                    textBox.Add("Pit");
                }
            }
            if (textBox.Count > 5)
            {
                while (textBox.Count > 5)
                {
                    textBox.RemoveAt(0);
                }
            }
            // renders the textbox 
            for (int i = 0; i < textBox.Count(); i++)
            {
                Font font = new Font(comfortaaCollection.Families[0], 14);
                SolidBrush fontBrush = new SolidBrush(Color.FromArgb(((i+1) * 25) + 100, ((i + 1) * 25) + 100, ((i + 1) * 25) + 100));
                e.Graphics.DrawString(textBox[i], font, fontBrush, new Point(100, i * 30));
                font.Dispose();
                fontBrush.Dispose();
            }
            brush.Dispose();
            hexagonBrush.Dispose();
            gameSelected.Dispose();
            gameUnselected.Dispose();
            roomBrush.Dispose();
            return outputs.Concat<bool>([hazards[0], hazards[1], hazards[2]]).ToArray<bool>();
        }
        private RectangleF RectangleAt(Point center, int rWidth, int rHeight)
        {
            return new RectangleF((center.X - rWidth / 2f), (center.Y - rHeight / 2f), rWidth, rHeight);
        }
        /// <summary>
        /// Renders the title screen where the user starts
        /// </summary>
        /// <param name="e">PaintEventArgs passed through Paint Form Event</param>
        public void RenderMainMenu(PaintEventArgs e)
        {
            inputs.Clear();
            for (int i = 0; i < 6; i++) { inputs.Add(false); }
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
            string[] mapNames = ["Amethyst Abyss", "Green Grotto", "Teal Tunnel", "Diamond Dungeon", "Black Borehole"];
            SolidBrush purpleBrush = new SolidBrush(Color.FromArgb(142, 124, 195));
            SolidBrush greenBrush = new SolidBrush(Color.FromArgb(147, 196, 125));
            SolidBrush tealBrush = new SolidBrush(Color.FromArgb(111, 168, 220));
            SolidBrush cyanBrush = new SolidBrush(Color.FromArgb(118, 165, 175));
            SolidBrush blackBrush = new SolidBrush(Color.FromArgb(67, 67, 67));
            SolidBrush[] brushes = [purpleBrush, greenBrush, tealBrush, cyanBrush, blackBrush];
            int spacing = (int)(80 * scaleFactor);
            int mapWidth = (int)((width / 5f)-(spacing*(4f/5f)));
            for (int i = 0; i < 5; i++)
            {
                Point position = new Point(i * (mapWidth + spacing) + (mapWidth / 2), height);
                Point[] hexagon = HexagonV(mapWidth, (int) (height * 0.8), (int)(height * 0.08), position);
                if (PointInShape(mouse, hexagon))
                {
                    int r, g, b;
                    r = brushes[i].Color.R;
                    g = brushes[i].Color.G;
                    b = brushes[i].Color.B;
                    r += 40;
                    g += 40;
                    b += 40;
                    if (r > 255) { r = 255; }
                    if (g > 255) { g = 255; }
                    if (b > 255) { b = 255; }
                    SolidBrush brush = new SolidBrush(Color.FromArgb(r, g, b));
                    e.Graphics.FillPolygon(brush, hexagon);
                    e.Graphics.DrawPolygon(outlineBrush, hexagon);
                    if (mouseDown)
                    {
                        map = i;
                        mouseDown = false;
                    }
                }
                else
                {
                    e.Graphics.FillPolygon(brushes[i], hexagon);
                    e.Graphics.DrawPolygon(outlineBrush, hexagon);
                }
                DrawText(e, mapNames[i], (int) (scaleFactor * 7), new Point(position.X, (int) (position.Y - 80)), Color.FromArgb(255, 255, 255));
            }
            if (map != -1)
            {
                inputs[map + 1] = true;
            }
        }
        public bool[] RenderTrivia(PaintEventArgs e, string question, string[] trivia)
        { 
            Color[] forecolor = [gameColors[map, 3], gameColors[map, 3], gameColors[map, 3], gameColors[map, 3]];
            Point[] hexagonPoints = HexagonH((int)(width / 2.4f), height / 10, (int)(height / 27f), new Point((int)(width / 3.97f), (int)(height / 2.1f)));
            Point[] hexagonPoints1 = HexagonH((int)(width / 2.4f), height / 10, (int)(height / 27f), new Point((int)(width / 1.35f), (int)(height / 2.1f)));
            Point[] hexagonPoints2 = HexagonH((int)(width / 2.4f), height / 10, (int)(height / 27f), new Point((int)(width / 3.97f), (int)(height / 1.4f)));
            Point[] hexagonPoints3 = HexagonH((int)(width / 2.4f), height / 10, (int)(height / 27f), new Point((int)(width / 1.35f), (int)(height / 1.4f)));
            Point[][] HexagonArray = { hexagonPoints, hexagonPoints1, hexagonPoints2, hexagonPoints3 };
            
            for (int i = 0; i < 4; i++)
            {
                if (PointInShape(mouse, HexagonArray[i]))
                {
                    forecolor[i] = gameColors[map, 4];
                    if (mouseDown)
                    {

                        mouseDown = false;
                        bool[] answer = new bool[4];
                        for (int j = 0; j < 4; j++)
                        {
                            if (j == i)
                                answer[j] = true;
                            else
                            {
                                answer[j] = false;
                            }
                        }
                        return answer;
                    }
                }
            }  
            Point titlePosition = new Point(width / 2, 100);
            Color bgColor = gameColors[map, 0];
            
            e.Graphics.Clear(bgColor);
            
           

            Pen pen = new Pen(Color.FromArgb(0, 0, 0), width/300f);
            Brush brush = new SolidBrush(forecolor[0]);
            Brush brush1 = new SolidBrush(forecolor[1]);
            Brush brush2 = new SolidBrush(forecolor[2]);
            Brush brush3= new SolidBrush(forecolor[3]);
            e.Graphics.FillPolygon(brush, hexagonPoints);
            e.Graphics.FillPolygon(brush1, hexagonPoints1);
            e.Graphics.FillPolygon(brush2, hexagonPoints2);
            e.Graphics.FillPolygon(brush3, hexagonPoints3);
            e.Graphics.DrawPolygon(pen, hexagonPoints);
            e.Graphics.DrawPolygon(pen, hexagonPoints1);
            e.Graphics.DrawPolygon(pen, hexagonPoints2);
            e.Graphics.DrawPolygon(pen, hexagonPoints3);
            DrawText(e, "Question: " + question, height / 50, titlePosition, Color.FromArgb(255, 255, 255));
            DrawText(e, trivia[0], height / 50, new Point((int)(width / 3.97f), (int)(height / 2.1f)), Color.FromArgb(255, 255, 255));
            DrawText(e, trivia[1], height / 50, new Point((int)(width / 1.35f), (int)(height / 2.1f)), Color.FromArgb(255, 255, 255));
            DrawText(e, trivia[2], height / 50, new Point((int)(width / 3.97f), (int)(height / 1.4f)), Color.FromArgb(255, 255, 255));
            DrawText(e, trivia[3], height / 50, new Point((int)(width / 1.35f), (int)(height / 1.4f)), Color.FromArgb(255, 255, 255));


            return [false];
        }
        public bool RenderHighScore(PaintEventArgs e, string[] names, int[] scores, string[] maps)
        {
            
            return false;
        }
        private bool PointInShape(Point p, Point[] polygon)
        {
            // PiP problem
            double minX = polygon[0].X;
            double maxX = polygon[0].X;
            double minY = polygon[0].Y;
            double maxY = polygon[0].Y;
            for (int i = 1; i < polygon.Length; i++)
            {
                Point q = polygon[i];
                minX = Math.Min(q.X, minX);
                maxX = Math.Max(q.X, maxX);
                minY = Math.Min(q.Y, minY);
                maxY = Math.Max(q.Y, maxY);
            }
            if (p.X < minX || p.X > maxX || p.Y < minY || p.Y > maxY)
            {
                return false;
            }
            bool inside = false;
            for (int i = 0, j = polygon.Length - 1; i < polygon.Length; j = i++)
            {
                if ((polygon[i].Y > p.Y) != (polygon[j].Y > p.Y) &&
                     p.X < (polygon[j].X - polygon[i].X) * (p.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) + polygon[i].X)
                {
                    inside = !inside;
                }
            }

            return inside;
        }
        private void DrawText(PaintEventArgs e, string text, int size, Point position, Color c)
        {
            Font font = new Font(comfortaaCollection.Families[0], size);
            SolidBrush textBrush = new SolidBrush(c);
            float height = font.GetHeight();
            float width = e.Graphics.MeasureString(text, font).Width;
            e.Graphics.DrawString(text, font, textBrush, new Point((int)(position.X - width / 2), (int)(position.Y - height/2)));
            font.Dispose();
            textBrush.Dispose();
        }
        /// <summary>
        /// Returns the 6 verticies of a hexagon
        /// </summary>
        /// <param name="radius">The distance each point is from the center</param>
        /// <param name="position">The location of the hexagon</param>
        /// <returns></returns>
        private Point[] HexagonPerfect(int radius, Point position)
        {
            Point[] points = new Point[6];
            for (int i = 0; i < 6; i++)
            {
                int x = position.X + (int)(radius * Math.Cos(i * (Math.PI / 3f)));
                int y = position.Y + (int)(radius * Math.Sin(i * (Math.PI / 3f)));
                points[i] = new Point(x, y);
            }
            return points;
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
        /// <summary>
        /// Gets the inputs for the current rendered state
        /// </summary>
        /// <returns>Returns a dynamic-length bool array of inputs</returns>
        public bool[] GetInputs()
        {
            return inputs.ToArray();
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
        /// <summary>
        /// Updates the data about the mouse
        /// </summary>
        /// <param name="mouse">The position as a Point where the mouse is</param>
        public void UpdateMousePosition(Point mouse)
        {
            this.mouse = mouse;
        }
        /// <summary>
        /// Sets if the mouse is down or up
        /// </summary>
        /// <param name="clicked">A boolean representing the mouse down (true = down, false = up)</param>
        public void UpdateMouseClicked(bool clicked)
        {
            if (clicked && !mouseDownBuffer)
            {
                mouseDown = true;
            }
            else
            {
                mouseDown = false;
            }
            mouseDownBuffer = clicked; // from the last frame
        }
        /// <summary>
        /// Renders the death screen
        /// </summary>
        /// <param name="e"></param>
        /// <returns>Playing again</returns>
        public bool RenderDeath(PaintEventArgs e, int score)
        {
            DrawText(e, $"You lost... {score}", 42, new Point(width / 2, height / 2), Color.FromArgb(0, 0, 0));

            return false;
        }
        /// <summary>
        /// Renders the high scores
        /// </summary>
        /// <param name="e"></param>
        /// <returns>Returns to leave to main menu</returns>
        public bool RenderHighscores(PaintEventArgs e, string[] names, string[] maps, string[] scores)
        {

            return false;
        }
        /// <summary>
        /// Renders the win screen
        /// </summary>
        /// <param name="e"></param>
        /// <param name="score">The user's score</param>
        /// <param name="name">The user's name</param>
        /// <returns>Returns true to head back to main menu</returns>
        public bool RenderWin(PaintEventArgs e, int score, string name)
        {
            DrawText(e, $"You won! {score}", 42, new Point(width / 2, height / 2), Color.FromArgb(0, 0, 0));
            return false;
        }
    }
    public interface IUIClassManager
    {
        public bool[] RenderGame(PaintEventArgs e, bool[] doorsOut, bool[] hazards, PlayerManager player);
        public void RenderMainMenu(PaintEventArgs e);
        public bool[] RenderTrivia(PaintEventArgs e, string question, string[] trivia);
        public bool RenderDeath(PaintEventArgs e, int score);
        public bool RenderWin(PaintEventArgs e, int score, string name);
        public bool RenderHighscores(PaintEventArgs e, string[] names, string[] maps, string[] scores);
        public bool[] GetInputs(); // returns an array of binary values, 0 if pressed, 1 if 0. Changes depending on scene
        public void UpdateScreenSize(int width, int height);
        public void UpdateMousePosition(Point mouse);
        public void UpdateMouseClicked(bool clicked);
    }
}
