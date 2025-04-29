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
            label1.Location = new Point(57, 47);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
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
            groupBoxTesting.Location = new Point(12, 12);
            groupBoxTesting.Name = "groupBoxTesting";
            groupBoxTesting.Size = new Size(205, 310);
            groupBoxTesting.TabIndex = 1;
            groupBoxTesting.TabStop = false;
            groupBoxTesting.Text = "Testing Components";
            // 
            // buttonTestSound
            // 
            buttonTestSound.Location = new Point(6, 265);
            buttonTestSound.Name = "buttonTestSound";
            buttonTestSound.Size = new Size(186, 29);
            buttonTestSound.TabIndex = 7;
            buttonTestSound.Text = "Test Sound";
            buttonTestSound.UseVisualStyleBackColor = true;
            // 
            // buttonTestPlayer
            // 
            buttonTestPlayer.Location = new Point(6, 230);
            buttonTestPlayer.Name = "buttonTestPlayer";
            buttonTestPlayer.Size = new Size(186, 29);
            buttonTestPlayer.TabIndex = 6;
            buttonTestPlayer.Text = "Test Player";
            buttonTestPlayer.UseVisualStyleBackColor = true;
            // 
            // buttonTestTrivia
            // 
            buttonTestTrivia.Location = new Point(6, 195);
            buttonTestTrivia.Name = "buttonTestTrivia";
            buttonTestTrivia.Size = new Size(186, 29);
            buttonTestTrivia.TabIndex = 5;
            buttonTestTrivia.Text = "Test Trivia";
            buttonTestTrivia.UseVisualStyleBackColor = true;
            // 
            // buttonTestHighscore
            // 
            buttonTestHighscore.Location = new Point(6, 160);
            buttonTestHighscore.Name = "buttonTestHighscore";
            buttonTestHighscore.Size = new Size(186, 29);
            buttonTestHighscore.TabIndex = 4;
            buttonTestHighscore.Text = "Test Highscore";
            buttonTestHighscore.UseVisualStyleBackColor = true;
            // 
            // buttonTestCave
            // 
            buttonTestCave.Location = new Point(6, 125);
            buttonTestCave.Name = "buttonTestCave";
            buttonTestCave.Size = new Size(186, 29);
            buttonTestCave.TabIndex = 3;
            buttonTestCave.Text = "Test Cave";
            buttonTestCave.UseVisualStyleBackColor = true;
            // 
            // buttonTestGameLocation
            // 
            buttonTestGameLocation.Location = new Point(6, 93);
            buttonTestGameLocation.Name = "buttonTestGameLocation";
            buttonTestGameLocation.Size = new Size(186, 29);
            buttonTestGameLocation.TabIndex = 2;
            buttonTestGameLocation.Text = "Test Game Location";
            buttonTestGameLocation.UseVisualStyleBackColor = true;
            // 
            // buttonTestUI
            // 
            buttonTestUI.Location = new Point(6, 58);
            buttonTestUI.Name = "buttonTestUI";
            buttonTestUI.Size = new Size(186, 29);
            buttonTestUI.TabIndex = 1;
            buttonTestUI.Text = "Test UI";
            buttonTestUI.UseVisualStyleBackColor = true;
            // 
            // buttonTestAll
            // 
            buttonTestAll.Location = new Point(6, 26);
            buttonTestAll.Name = "buttonTestAll";
            buttonTestAll.Size = new Size(186, 29);
            buttonTestAll.TabIndex = 0;
            buttonTestAll.Text = "Test All";
            buttonTestAll.UseVisualStyleBackColor = true;
            // 
            // buttonStartWumpus
            // 
            buttonStartWumpus.Location = new Point(245, 22);
            buttonStartWumpus.Name = "buttonStartWumpus";
            buttonStartWumpus.Size = new Size(176, 61);
            buttonStartWumpus.TabIndex = 8;
            buttonStartWumpus.Text = "Start Wumpus Game";
            buttonStartWumpus.UseVisualStyleBackColor = true;
            buttonStartWumpus.Click += this.StartGame;
            // 
            // FormLaucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonStartWumpus);
            Controls.Add(groupBoxTesting);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
