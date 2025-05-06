namespace Hunt_the_Wumpus_2025
{
    partial class FormLaucher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBoxTesting = new GroupBox();
            buttonTestSound = new Button();
            buttonTestPlayer = new Button();
            buttonTestTrivia = new Button();
            buttonTestHighscore = new Button();
            buttonTestCave = new Button();
            buttonTestGameLocation = new Button();
            buttonTestUI = new Button();
            buttonTestAll = new Button();
            buttonStartWumpus = new Button();
            groupBoxTesting.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 35);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // groupBoxTesting
            // 
            groupBoxTesting.Controls.Add(buttonTestSound);
            groupBoxTesting.Controls.Add(buttonTestPlayer);
            groupBoxTesting.Controls.Add(buttonTestTrivia);
            groupBoxTesting.Controls.Add(buttonTestHighscore);
            groupBoxTesting.Controls.Add(buttonTestCave);
            groupBoxTesting.Controls.Add(buttonTestGameLocation);
            groupBoxTesting.Controls.Add(buttonTestUI);
            groupBoxTesting.Controls.Add(buttonTestAll);
            groupBoxTesting.Location = new Point(10, 9);
            groupBoxTesting.Margin = new Padding(3, 2, 3, 2);
            groupBoxTesting.Name = "groupBoxTesting";
            groupBoxTesting.Padding = new Padding(3, 2, 3, 2);
            groupBoxTesting.Size = new Size(179, 232);
            groupBoxTesting.TabIndex = 1;
            groupBoxTesting.TabStop = false;
            groupBoxTesting.Text = "Testing Components";
            // 
            // buttonTestSound
            // 
            buttonTestSound.Location = new Point(5, 199);
            buttonTestSound.Margin = new Padding(3, 2, 3, 2);
            buttonTestSound.Name = "buttonTestSound";
            buttonTestSound.Size = new Size(163, 22);
            buttonTestSound.TabIndex = 7;
            buttonTestSound.Text = "Test Sound";
            buttonTestSound.UseVisualStyleBackColor = true;
            // 
            // buttonTestPlayer
            // 
            buttonTestPlayer.Location = new Point(5, 172);
            buttonTestPlayer.Margin = new Padding(3, 2, 3, 2);
            buttonTestPlayer.Name = "buttonTestPlayer";
            buttonTestPlayer.Size = new Size(163, 22);
            buttonTestPlayer.TabIndex = 6;
            buttonTestPlayer.Text = "Test Player";
            buttonTestPlayer.UseVisualStyleBackColor = true;
            // 
            // buttonTestTrivia
            // 
            buttonTestTrivia.Location = new Point(5, 146);
            buttonTestTrivia.Margin = new Padding(3, 2, 3, 2);
            buttonTestTrivia.Name = "buttonTestTrivia";
            buttonTestTrivia.Size = new Size(163, 22);
            buttonTestTrivia.TabIndex = 5;
            buttonTestTrivia.Text = "Test Trivia";
            buttonTestTrivia.UseVisualStyleBackColor = true;
            // 
            // buttonTestHighscore
            // 
            buttonTestHighscore.Location = new Point(5, 120);
            buttonTestHighscore.Margin = new Padding(3, 2, 3, 2);
            buttonTestHighscore.Name = "buttonTestHighscore";
            buttonTestHighscore.Size = new Size(163, 22);
            buttonTestHighscore.TabIndex = 4;
            buttonTestHighscore.Text = "Test Highscore";
            buttonTestHighscore.UseVisualStyleBackColor = true;
            // 
            // buttonTestCave
            // 
            buttonTestCave.Location = new Point(5, 94);
            buttonTestCave.Margin = new Padding(3, 2, 3, 2);
            buttonTestCave.Name = "buttonTestCave";
            buttonTestCave.Size = new Size(163, 22);
            buttonTestCave.TabIndex = 3;
            buttonTestCave.Text = "Test Cave";
            buttonTestCave.UseVisualStyleBackColor = true;
            buttonTestCave.Click += buttonTestCave_Click;
            // 
            // buttonTestGameLocation
            // 
            buttonTestGameLocation.Location = new Point(5, 70);
            buttonTestGameLocation.Margin = new Padding(3, 2, 3, 2);
            buttonTestGameLocation.Name = "buttonTestGameLocation";
            buttonTestGameLocation.Size = new Size(163, 22);
            buttonTestGameLocation.TabIndex = 2;
            buttonTestGameLocation.Text = "Test Game Location";
            buttonTestGameLocation.UseVisualStyleBackColor = true;
            buttonTestGameLocation.Click += buttonTestGameLocation_Click;
            // 
            // buttonTestUI
            // 
            buttonTestUI.Location = new Point(5, 44);
            buttonTestUI.Margin = new Padding(3, 2, 3, 2);
            buttonTestUI.Name = "buttonTestUI";
            buttonTestUI.Size = new Size(163, 22);
            buttonTestUI.TabIndex = 1;
            buttonTestUI.Text = "Test UI";
            buttonTestUI.UseVisualStyleBackColor = true;
            // 
            // buttonTestAll
            // 
            buttonTestAll.Location = new Point(5, 20);
            buttonTestAll.Margin = new Padding(3, 2, 3, 2);
            buttonTestAll.Name = "buttonTestAll";
            buttonTestAll.Size = new Size(163, 22);
            buttonTestAll.TabIndex = 0;
            buttonTestAll.Text = "Test All";
            buttonTestAll.UseVisualStyleBackColor = true;
            // 
            // buttonStartWumpus
            // 
            buttonStartWumpus.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStartWumpus.Location = new Point(214, 29);
            buttonStartWumpus.Margin = new Padding(3, 2, 3, 2);
            buttonStartWumpus.Name = "buttonStartWumpus";
            buttonStartWumpus.Size = new Size(154, 201);
            buttonStartWumpus.TabIndex = 8;
            buttonStartWumpus.Text = "Start Wumpus Game";
            buttonStartWumpus.UseVisualStyleBackColor = true;
            buttonStartWumpus.Click += StartGame;
            // 
            // FormLaucher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 255);
            Controls.Add(buttonStartWumpus);
            Controls.Add(groupBoxTesting);
            Controls.Add(label1);
            Name = "FormLaucher";
            Text = "Launcher";
            groupBoxTesting.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBoxTesting;
        private Button buttonTestUI;
        private Button buttonTestAll;
        private Button buttonTestSound;
        private Button buttonTestPlayer;
        private Button buttonTestTrivia;
        private Button buttonTestHighscore;
        private Button buttonTestCave;
        private Button buttonTestGameLocation;
        private Button buttonStartWumpus;
    }
}
