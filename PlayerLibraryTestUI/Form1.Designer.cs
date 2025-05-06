namespace PlayerLibraryTestUI
{
    partial class Form1
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
            checkBoxIsAddition = new CheckBox();
            checkBoxKilledWumpus = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxAmount = new TextBox();
            textBoxScore = new TextBox();
            textBoxMoves = new TextBox();
            textBoxCoins = new TextBox();
            textBoxArrows = new TextBox();
            buttonArrows = new Button();
            buttonCoins = new Button();
            buttonIncrement = new Button();
            buttonGetScore = new Button();
            SuspendLayout();
            // 
            // checkBoxIsAddition
            // 
            checkBoxIsAddition.AutoSize = true;
            checkBoxIsAddition.Checked = true;
            checkBoxIsAddition.CheckState = CheckState.Checked;
            checkBoxIsAddition.Location = new Point(65, 61);
            checkBoxIsAddition.Name = "checkBoxIsAddition";
            checkBoxIsAddition.Size = new Size(88, 19);
            checkBoxIsAddition.TabIndex = 0;
            checkBoxIsAddition.Text = "Is Addition?";
            checkBoxIsAddition.UseVisualStyleBackColor = true;
            // 
            // checkBoxKilledWumpus
            // 
            checkBoxKilledWumpus.AutoSize = true;
            checkBoxKilledWumpus.Location = new Point(177, 61);
            checkBoxKilledWumpus.Name = "checkBoxKilledWumpus";
            checkBoxKilledWumpus.Size = new Size(111, 19);
            checkBoxKilledWumpus.TabIndex = 1;
            checkBoxKilledWumpus.Text = "Killed Wumpus?";
            checkBoxKilledWumpus.UseVisualStyleBackColor = true;
            checkBoxKilledWumpus.CheckedChanged += checkBoxKilledWumpus_CheckedChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 116);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Arrows";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 153);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Gold Coins";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 192);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Moves";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 229);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Score";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 266);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 6;
            label5.Text = "Amount to +/-";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(168, 263);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(120, 23);
            textBoxAmount.TabIndex = 7;
            // 
            // textBoxScore
            // 
            textBoxScore.Location = new Point(168, 226);
            textBoxScore.Name = "textBoxScore";
            textBoxScore.ReadOnly = true;
            textBoxScore.Size = new Size(120, 23);
            textBoxScore.TabIndex = 8;
            // 
            // textBoxMoves
            // 
            textBoxMoves.Location = new Point(168, 189);
            textBoxMoves.Name = "textBoxMoves";
            textBoxMoves.ReadOnly = true;
            textBoxMoves.Size = new Size(120, 23);
            textBoxMoves.TabIndex = 9;
            textBoxMoves.Text = "0";
            // 
            // textBoxCoins
            // 
            textBoxCoins.Location = new Point(168, 150);
            textBoxCoins.Name = "textBoxCoins";
            textBoxCoins.ReadOnly = true;
            textBoxCoins.Size = new Size(120, 23);
            textBoxCoins.TabIndex = 10;
            textBoxCoins.Text = "0";
            // 
            // textBoxArrows
            // 
            textBoxArrows.Location = new Point(168, 113);
            textBoxArrows.Name = "textBoxArrows";
            textBoxArrows.ReadOnly = true;
            textBoxArrows.Size = new Size(120, 23);
            textBoxArrows.TabIndex = 11;
            textBoxArrows.Text = "0";
            // 
            // buttonArrows
            // 
            buttonArrows.Location = new Point(338, 61);
            buttonArrows.Name = "buttonArrows";
            buttonArrows.Size = new Size(151, 42);
            buttonArrows.TabIndex = 12;
            buttonArrows.Text = "Add or Subtract Arrows";
            buttonArrows.UseVisualStyleBackColor = true;
            buttonArrows.Click += buttonArrows_Click_1;
            // 
            // buttonCoins
            // 
            buttonCoins.Location = new Point(338, 116);
            buttonCoins.Name = "buttonCoins";
            buttonCoins.Size = new Size(151, 42);
            buttonCoins.TabIndex = 13;
            buttonCoins.Text = "Add or Subtract Coins";
            buttonCoins.UseVisualStyleBackColor = true;
            buttonCoins.Click += buttonCoins_Click_1;
            // 
            // buttonIncrement
            // 
            buttonIncrement.Location = new Point(338, 170);
            buttonIncrement.Name = "buttonIncrement";
            buttonIncrement.Size = new Size(151, 42);
            buttonIncrement.TabIndex = 14;
            buttonIncrement.Text = "Increment # Moves";
            buttonIncrement.UseVisualStyleBackColor = true;
            buttonIncrement.Click += buttonIncrement_Click_1;
            // 
            // buttonGetScore
            // 
            buttonGetScore.Location = new Point(338, 226);
            buttonGetScore.Name = "buttonGetScore";
            buttonGetScore.Size = new Size(151, 42);
            buttonGetScore.TabIndex = 15;
            buttonGetScore.Text = "Get Score";
            buttonGetScore.UseVisualStyleBackColor = true;
            buttonGetScore.Click += buttonGetScore_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 345);
            Controls.Add(buttonGetScore);
            Controls.Add(buttonIncrement);
            Controls.Add(buttonCoins);
            Controls.Add(buttonArrows);
            Controls.Add(textBoxArrows);
            Controls.Add(textBoxCoins);
            Controls.Add(textBoxMoves);
            Controls.Add(textBoxScore);
            Controls.Add(textBoxAmount);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBoxKilledWumpus);
            Controls.Add(checkBoxIsAddition);
            Name = "Form1";
            Text = "Nathan - Player Test UI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxIsAddition;
        private CheckBox checkBoxKilledWumpus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxAmount;
        private TextBox textBoxScore;
        private TextBox textBoxMoves;
        private TextBox textBoxCoins;
        private TextBox textBoxArrows;
        private Button buttonArrows;
        private Button buttonCoins;
        private Button buttonIncrement;
        private Button buttonGetScore;
    }
}
