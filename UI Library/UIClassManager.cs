using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using PlayerLibrary;
using static System.Formats.Asn1.AsnWriter;
namespace UI_Class_Library
{
    public class Map : IDisposable
    {
        public Bitmap map, bat, wumpus;
        public Color backgroundColor;
        public Color foregroundColor;
        public Color highlights;
        public string mapName;
        public Map(string mapName, string map, string bat, string wumpus, Color backgroundColor, Color foregroundColor, Color highlights)
        {
            this.map = new Bitmap($"images/{map}");
            this.bat = new Bitmap($"images/{bat}");
            this.wumpus = new Bitmap($"images/{wumpus}");
            this.backgroundColor = backgroundColor;
            this.highlights = highlights;
            this.foregroundColor = foregroundColor;
            this.mapName = mapName;
        }
        public void Dispose()
        {
            map.Dispose();
            bat.Dispose();
            wumpus.Dispose();
        }
    }
    public class UIClassManager : IUIClassManager, IDisposable
    {
        static float aspectRatio = 16f / 9f;
        public int width, height;
        Bitmap[] doors = [
            new Bitmap("images/door_0.png"),
            new Bitmap("images/door_1.png"),
            new Bitmap("images/door_2.png"),
            new Bitmap("images/door_3.png"),
            new Bitmap("images/door_4.png"),
            new Bitmap("images/door_5.png")
            ];
        Bitmap crossbow = new Bitmap("images/crossbow_icon.png");
        Bitmap crossbowLoaded = new Bitmap("images/loaded_crossbow_icon.png");
        Bitmap arrows = new Bitmap("images/arrows_icon.png");
        Bitmap question = new Bitmap("images/question_icon.png");
        public Point mouse = new Point();
        public bool mouseDown = false;
        public bool mouseDownBuffer = false;
        Map[] maps = [
            new Map("Amythyst Abyss", "amythystabyss.jpg", "bat_amethyst.png", "wumpus_amethyst.png", Color.FromArgb(137, 45, 145), Color.FromArgb(237, 145, 245), Color.FromArgb(203, 95, 212)),
            new Map("Green Grotto", "greengrotto.jpg", "bat_green.png", "wumpus_green.png", Color.FromArgb(82, 128, 82), Color.FromArgb(182, 228, 182), Color.FromArgb(108, 168, 108)),
            new Map("Teal Tunnel", "tealtunnel.jpg", "bat_teal.png", "wumpus_teal.png", Color.FromArgb(32, 109, 133), Color.FromArgb(132, 209, 233), Color.FromArgb(81, 173, 201)),
            new Map("Diamond Dungeon", "diamonddungeon.jpg", "bat_diamond.png", "wumpus_diamond.png", Color.FromArgb(27, 116, 117), Color.FromArgb(127, 216, 217), Color.FromArgb(62, 180, 181)),
            new Map("Black Borehole", "blackborehole.jpg", "bat_black.png", "wumpus_black.png", Color.FromArgb(41, 37, 36), Color.FromArgb(141, 137, 136), Color.FromArgb(74, 47, 40)),
            ];

        PrivateFontCollection comfortaaCollection = new PrivateFontCollection();
        List<TextBoxText> textBox = new List<TextBoxText>(); // should be capped at 5 items
        int lastMapLocation;
        public int map = -1;
        private List<bool> inputs = new List<bool>();
        
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
        public bool[] RenderGame(PaintEventArgs e, bool[] doorsOut, bool[] hazards, bool arrowNocked, PlayerManager player)
        {
            bool renderMouseData = false;
            // renders the game
            Map currentMap = maps[map];
            Color sidePanel = currentMap.backgroundColor;
            SolidBrush brush = new SolidBrush(sidePanel);
            SolidBrush gameSelected = new SolidBrush(currentMap.highlights);
            SolidBrush gameUnselected = new SolidBrush(currentMap.foregroundColor);
            SolidBrush roomBrush = new SolidBrush(Color.FromArgb(218, 218, 218));

            // very messy, should rewrite this
            bool[] outputs = [false, false, false, false, false, false, false, false, false];

            int currentRoom = player.CurrentRoom;
            Color bgColor = currentMap.backgroundColor;
            e.Graphics.Clear(bgColor);
            Rectangle rect = new Rectangle((int)(height), 0, (int)(width-height), height);
            int radius = (int)(width * 0.203);
            Point centerHexagonPosition = new Point((int)(width * (1f / 3f)), (int)(height / 2f));
            Bitmap bmp = currentMap.map;
            string name = currentMap.mapName;
            
            e.Graphics.DrawImage(bmp, new Rectangle(0, 0, height, height));
            // render the right panel
            float padding = 2f;
            int paddingPx = (int)(padding * (height / 54f));
            int widthOfPanel = width - height;
            Point topLeft = new Point(height, 0);

            RectangleF header = new RectangleF(topLeft.X + paddingPx, topLeft.Y + paddingPx, widthOfPanel - (2 * paddingPx), height / 5f);
            e.Graphics.FillRectangle(gameUnselected, header);

            RectangleF shootArrow = new RectangleF(topLeft.X + paddingPx, header.Y + header.Height + padding, (widthOfPanel - 3 * paddingPx) / 3f, (widthOfPanel - 3 * paddingPx) / 3f);
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
            if (arrowNocked)
            {
                e.Graphics.DrawImage(crossbowLoaded, shootArrow);
            }
            else
            {
                e.Graphics.DrawImage(crossbow, shootArrow);
            }
            if (buyArrow.Contains(mouse))
            {
                renderMouseData = true;
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

            e.Graphics.DrawImage(arrows, buyArrow);
            e.Graphics.DrawImage(question, buySecret);
            Point headerCenter = new Point(height + (int)(widthOfPanel / 2f), (int)(height / 16f) + paddingPx);
            DrawText(e, name, (int)(height / 23), headerCenter, Color.FromArgb(0, 0, 0));
            DrawText(e, "Hunt the Wumpus", (int)(height / 54), new Point(headerCenter.X, (int)(headerCenter.Y + (height / 10f))), Color.FromArgb(0, 0, 0));
           
            // doorway rendering
            Size roomSize = new Size(95, 95);
           // render the rooms around the hexagon

            if (doorsOut[0])
            {
                Rectangle rectRoom = new Rectangle(new Point((int)(centerHexagonPosition.X + radius * Math.Cos((-2 + 0) * Math.PI / 3 + Math.PI / 6)) - roomSize.Width / 2 - 10, (int)(centerHexagonPosition.Y + radius * Math.Sin((-2 + 0) * Math.PI / 3 + Math.PI / 6)) - roomSize.Height / 2 + 10), roomSize);
                e.Graphics.FillEllipse(roomBrush, rectRoom);

                e.Graphics.DrawImage(doors[0], new Rectangle(0, 0, height, height));
                float distance = (float)Math.Sqrt((mouse.X - (rectRoom.X + roomSize.Width)) * (mouse.X - (rectRoom.X + roomSize.Width)) + (mouse.Y - (rectRoom.Y + roomSize.Height)) * (mouse.Y - (rectRoom.Y + roomSize.Height)));
                if (distance < roomSize.Width && mouseDown)
                {
                    outputs[0] = true;
                    mouseDown = false;
                } 
            }
            if (doorsOut[1])
            {
                Rectangle rectRoom = new Rectangle(new Point((int)(centerHexagonPosition.X + radius * Math.Cos((-2 + 1) * Math.PI / 3 + Math.PI / 6)) - roomSize.Width / 2 - 10, (int)(centerHexagonPosition.Y + radius * Math.Sin((-2 + 1) * Math.PI / 3 + Math.PI / 6)) - roomSize.Height / 2 + 10), roomSize);
                e.Graphics.FillEllipse(roomBrush, rectRoom);

                e.Graphics.DrawImage(doors[1], new Rectangle(0, 0, height, height));
                float distance = (float)Math.Sqrt((mouse.X - (rectRoom.X + roomSize.Width)) * (mouse.X - (rectRoom.X + roomSize.Width)) + (mouse.Y - (rectRoom.Y + roomSize.Height)) * (mouse.Y - (rectRoom.Y + roomSize.Height)));
                if (distance < roomSize.Width && mouseDown)
                {
                    outputs[1] = true;
                    mouseDown = false;
                }
            }
            if (doorsOut[2])
            {
                Rectangle rectRoom = new Rectangle(new Point((int)(centerHexagonPosition.X + radius * Math.Cos((-2 + 2) * Math.PI / 3 + Math.PI / 6)) - roomSize.Width / 2 - 17, (int)(centerHexagonPosition.Y + radius * Math.Sin((-2 + 2) * Math.PI / 3 + Math.PI / 6)) - roomSize.Height / 2), roomSize);
                e.Graphics.FillEllipse(roomBrush, rectRoom);

                e.Graphics.DrawImage(doors[2], new Rectangle(0, 0, height, height));
                float distance = (float)Math.Sqrt((mouse.X - (rectRoom.X + roomSize.Width)) * (mouse.X - (rectRoom.X + roomSize.Width)) + (mouse.Y - (rectRoom.Y + roomSize.Height)) * (mouse.Y - (rectRoom.Y + roomSize.Height)));
                if (distance < roomSize.Width && mouseDown)
                {
                    outputs[2] = true;
                    mouseDown = false;
                }
            }
            if (doorsOut[3])
            {
                Rectangle rectRoom = new Rectangle(new Point((int)(centerHexagonPosition.X + radius * Math.Cos((-2 + 3) * Math.PI / 3 + Math.PI / 6)) - roomSize.Width / 2, (int)(centerHexagonPosition.Y + radius * Math.Sin((-2 + 3) * Math.PI / 3 + Math.PI / 6)) - roomSize.Height / 2), roomSize);
                e.Graphics.FillEllipse(roomBrush, rectRoom);

                e.Graphics.DrawImage(doors[3], new Rectangle(0, 0, height, height));
                float distance = (float)Math.Sqrt((mouse.X - (rectRoom.X + roomSize.Width)) * (mouse.X - (rectRoom.X + roomSize.Width)) + (mouse.Y - (rectRoom.Y + roomSize.Height)) * (mouse.Y - (rectRoom.Y + roomSize.Height)));
                if (distance < roomSize.Width && mouseDown)
                {
                    outputs[3] = true;
                    mouseDown = false;
                }
            }
            if (doorsOut[4])
            {
                Rectangle rectRoom = new Rectangle(new Point((int)(centerHexagonPosition.X + radius * Math.Cos((-2 + 4) * Math.PI / 3 + Math.PI / 6)) - roomSize.Width / 2 - 62, (int)(centerHexagonPosition.Y + radius * Math.Sin((-2 + 4) * Math.PI / 3 + Math.PI / 6)) - roomSize.Height / 2), roomSize);
                e.Graphics.FillEllipse(roomBrush, rectRoom);

                e.Graphics.DrawImage(doors[4], new Rectangle(0, 0, height, height));
                float distance = (float)Math.Sqrt((mouse.X - (rectRoom.X + roomSize.Width)) * (mouse.X - (rectRoom.X + roomSize.Width)) + (mouse.Y - (rectRoom.Y + roomSize.Height)) * (mouse.Y - (rectRoom.Y + roomSize.Height)));
                if (distance < roomSize.Width && mouseDown)
                {
                    outputs[4] = true;
                    mouseDown = false;
                }
            }
            if (doorsOut[5])
            {
                Rectangle rectRoom = new Rectangle(new Point((int)(centerHexagonPosition.X + radius * Math.Cos((-2 + 5) * Math.PI / 3 + Math.PI / 6)) - roomSize.Width / 2 - 48, (int)(centerHexagonPosition.Y + radius * Math.Sin((-2 + 5) * Math.PI / 3 + Math.PI / 6)) - roomSize.Height / 2 - 17), roomSize);
                e.Graphics.FillEllipse(roomBrush, rectRoom);

                e.Graphics.DrawImage(doors[5], new Rectangle(0, 0, height, height));
                float distance = (float)Math.Sqrt((mouse.X - (rectRoom.X + roomSize.Width)) * (mouse.X - (rectRoom.X + roomSize.Width)) + (mouse.Y - (rectRoom.Y + roomSize.Height)) * (mouse.Y - (rectRoom.Y + roomSize.Height)));
                if (distance < roomSize.Width && mouseDown)
                {
                    outputs[5] = true;
                    mouseDown = false;
                }
            }

            // also needs to render hazards
            if (lastMapLocation != currentRoom) 
            {
                lastMapLocation = currentRoom;
                if (hazards[3])
                {
                    AddToChat(ChatType.NearbyWumpus);
                }
                if (hazards[4])
                {
                    AddToChat(ChatType.NearbyBat);
                }
                if (hazards[5])
                {
                    AddToChat(ChatType.NearbyPit);
                }
            }
            if (textBox.Count > 5)
            {
                while (textBox.Count > 5)
                {
                    textBox.RemoveAt(0);
                }
            }
            int fontSize = 24 * (height / 540);
            int textBoxRectYPosition = height - (int)(height / 2.5);
            RectangleF textBoxRect = new RectangleF(height, textBoxRectYPosition, widthOfPanel, height - textBoxRectYPosition);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), textBoxRect);
            // renders the textbox 
            for (int i = 0; i < textBox.Count; i++)
            {
                textBox[(textBox.Count - 1) - i].RenderText(e, new Point(height + paddingPx, (height - paddingPx) - (int)((fontSize + (.5 * paddingPx)) * (i + 1))), fontSize, Color.FromArgb(255 - (50 * i), 255 - (50 * i), 255 - (50 * i)));
            }
            if (renderMouseData)
            {
                DrawText(e, player.Arrows.ToString(), 25, new Point(mouse.X + 28, mouse.Y + 18), Color.Gray);
                DrawText(e, player.Arrows.ToString(), 25, new Point(mouse.X + 25, mouse.Y + 15), Color.White);
            }
            brush.Dispose();
            gameSelected.Dispose();
            gameUnselected.Dispose();
            roomBrush.Dispose();
            return outputs.Concat<bool>([hazards[0], hazards[1], hazards[2]]).ToArray<bool>();
        }
        /// <summary>
        /// Renders the title screen where the user starts
        /// </summary>
        /// <param name="e">PaintEventArgs passed through Paint Form Event</param>
        public bool RenderMainMenu(PaintEventArgs e)
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
            //scoreboard button
            Pen Scorebrushs = new Pen(Color.FromArgb(0, 0, 0), 4);
            RectangleF rect = new RectangleF((int)(width/ 2.526f), (int)(height/1.9f),(int) (width/4.8f), (int)(height/15.428));
            Point scoreposition = new Point(width/2,(int)(height/1.78f));
            if (rect.Contains(mouse))
            {
                if (mouseDown)
                {
                    return true;
                }
            }
                    e.Graphics.DrawRectangle(Scorebrushs, rect);
            e.Graphics.FillRectangle(shapeBrush, rect);
            DrawText(e, "ScoreBoard", 11, scoreposition,Color.FromArgb(0, 0, 0));
           
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
            return false;
        }
        public bool[] RenderTrivia(PaintEventArgs e, string question, string[] trivia)
        {
            Map currentMap = maps[map];
            Color[] forecolor = [currentMap.foregroundColor, currentMap.foregroundColor, currentMap.foregroundColor, currentMap.foregroundColor];
            Point[] hexagonPoints = HexagonH((int)(width / 2.4f), height / 10, (int)(height / 27f), new Point((int)(width / 3.97f), (int)(height / 2.1f)));
            Point[] hexagonPoints1 = HexagonH((int)(width / 2.4f), height / 10, (int)(height / 27f), new Point((int)(width / 1.35f), (int)(height / 2.1f)));
            Point[] hexagonPoints2 = HexagonH((int)(width / 2.4f), height / 10, (int)(height / 27f), new Point((int)(width / 3.97f), (int)(height / 1.4f)));
            Point[] hexagonPoints3 = HexagonH((int)(width / 2.4f), height / 10, (int)(height / 27f), new Point((int)(width / 1.35f), (int)(height / 1.4f)));
            Point[][] HexagonArray = { hexagonPoints, hexagonPoints1, hexagonPoints2, hexagonPoints3 };
            
            for (int i = 0; i < 4; i++)
            {
                if (PointInShape(mouse, HexagonArray[i]))
                {
                    forecolor[i] = currentMap.highlights;
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
            Color bgColor = currentMap.backgroundColor;
            
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
        /// <summary>
        /// Renders the high score game state
        /// </summary>
        /// <param name="e">PaintEventArgs e</param>
        /// <param name="names">An array of names </param>
        /// <param name="scores">An array of scores</param>
        /// <param name="maps">An array of map names</param>
        /// <returns>true if leave to main menu</returns>
        public bool RenderHighScore(PaintEventArgs e, string[] names, int[] scores, string[] maps)
        {
            
            return false;
        }
        /// <summary>
        /// Adds a ChatType to the textbox
        /// </summary>
        /// <param name="chatType">ChatType</param>
        public void AddToChat(ChatType chatType)
        {
            AddToChat(chatType, string.Empty);
        }
        /// <summary>
        /// Adds a ChatType to the class
        /// </summary>
        /// <param name="chatType">ChatType</param>
        /// <param name="text">The text if ChatType.Text is selected</param>
        public void AddToChat(ChatType chatType, string text) 
        {
            TextBoxText textText;
            switch (chatType)
            {
                case (ChatType.Text):
                    {
                        textText = new TextBoxText(text);
                        break;
                    }
                case ChatType.NearbyBat:
                    {
                        textText = new TextBoxText("You hear a noise...");
                        break;
                    }
                case ChatType.NearbyPit:
                    {
                        textText = new TextBoxText("You feel a draft...");
                        break;
                    }
                case ChatType.NearbyWumpus:
                    {
                        textText = new TextBoxText("You smell an odor...");
                        break;
                    }
                case ChatType.EncounteredBat:
                    {
                        textText = new TextBoxText("You've hit a bat", new Bitmap("images/bat_teal.png"));
                        break;
                    }
                case ChatType.EncounteredPit:
                    {
                        textText = new TextBoxText("You've fallen into a pit");
                        break;
                    }
                case ChatType.EncounteredWumpus:
                    {
                        textText = new TextBoxText("You encountered the wumpus", new Bitmap("images/wumpus_teal.png"));
                        break;
                    }
                default:
                    {
                        throw new Exception("Unexpected switch case");
                    }
            }
            textBox.Add(textText);
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
        /// <summary>
        /// Disposes the unmanaged memory
        /// </summary>
        public void Dispose()
        {
            for (int i = 0; i < maps.Length; i++)
            {
                maps[i].Dispose();   
            }
        }
    }
    public class TextBoxText
    {
        static PrivateFontCollection comfortaaCollection = new PrivateFontCollection();
        public string text;
        public Image? img;
        public TextBoxText(string text, Bitmap? image)
        {
            this.text = text;
            img = image;
            comfortaaCollection.AddFontFile("Comfortaa-Light.ttf");
        }
        public TextBoxText(string text)
        {
            this.text = text;
            img = null;
            comfortaaCollection.AddFontFile("Comfortaa-Light.ttf");
        }
        public void RenderText(PaintEventArgs e, Point pos, float size, Color color)
        {
            if (img != null) 
            { 
                e.Graphics.DrawImage(img, new RectangleF(pos, new SizeF(size, size)));
                pos.X += (int)size;
            }
            if (text == string.Empty)
            {
                return;
            }
            Font font = new Font(comfortaaCollection.Families[0], size);
            SolidBrush textBrush = new SolidBrush(color);
            e.Graphics.DrawString(text, font, textBrush, pos);

        }
    }
    public enum ChatType
    {
        Text,
        NearbyBat,
        NearbyWumpus,
        NearbyPit,
        EncounteredBat,
        EncounteredWumpus,
        EncounteredPit,
    }
    public interface IUIClassManager
    {
        public bool[] RenderGame(PaintEventArgs e, bool[] doorsOut, bool[] hazards, bool arrowNocked, PlayerManager player);
        public bool RenderMainMenu(PaintEventArgs e);
        public bool[] RenderTrivia(PaintEventArgs e, string question, string[] trivia);
        public bool RenderDeath(PaintEventArgs e, int score);
        public bool RenderWin(PaintEventArgs e, int score, string name);
        public bool RenderHighscores(PaintEventArgs e, string[] names, string[] maps, string[] scores);
        public void AddToChat(ChatType c);
        public bool[] GetInputs(); // returns an array of binary values, 0 if pressed, 1 if 0. Changes depending on scene
        public void UpdateScreenSize(int width, int height);
        public void UpdateMousePosition(Point mouse);
        public void UpdateMouseClicked(bool clicked);
    }
}
