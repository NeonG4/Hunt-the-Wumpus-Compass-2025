namespace _2030638_Choy_PlayerTestUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonArrows = new System.Windows.Forms.Button();
            this.buttonCoins = new System.Windows.Forms.Button();
            this.buttonIncrement = new System.Windows.Forms.Button();
            this.checkBoxIsAddition = new System.Windows.Forms.CheckBox();
            this.buttonGetScore = new System.Windows.Forms.Button();
            this.checkBoxKilledWumpus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxArrows = new System.Windows.Forms.TextBox();
            this.textBoxCoins = new System.Windows.Forms.TextBox();
            this.textBoxMoves = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonArrows
            // 
            this.buttonArrows.Location = new System.Drawing.Point(458, 168);
            this.buttonArrows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonArrows.Name = "buttonArrows";
            this.buttonArrows.Size = new System.Drawing.Size(270, 77);
            this.buttonArrows.TabIndex = 0;
            this.buttonArrows.Text = "Add or Subtract Arrows";
            this.buttonArrows.UseVisualStyleBackColor = true;
            this.buttonArrows.Click += new System.EventHandler(this.buttonArrows_Click);
            // 
            // buttonCoins
            // 
            this.buttonCoins.Location = new System.Drawing.Point(458, 254);
            this.buttonCoins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCoins.Name = "buttonCoins";
            this.buttonCoins.Size = new System.Drawing.Size(270, 77);
            this.buttonCoins.TabIndex = 1;
            this.buttonCoins.Text = "Add or Subtract Coins";
            this.buttonCoins.UseVisualStyleBackColor = true;
            this.buttonCoins.Click += new System.EventHandler(this.buttonCoins_Click);
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.Location = new System.Drawing.Point(458, 340);
            this.buttonIncrement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIncrement.Name = "buttonIncrement";
            this.buttonIncrement.Size = new System.Drawing.Size(270, 77);
            this.buttonIncrement.TabIndex = 2;
            this.buttonIncrement.Text = "Increment Move Count";
            this.buttonIncrement.UseVisualStyleBackColor = true;
            this.buttonIncrement.Click += new System.EventHandler(this.buttonIncrement_Click);
            // 
            // checkBoxIsAddition
            // 
            this.checkBoxIsAddition.AutoSize = true;
            this.checkBoxIsAddition.Checked = true;
            this.checkBoxIsAddition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsAddition.Location = new System.Drawing.Point(93, 115);
            this.checkBoxIsAddition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxIsAddition.Name = "checkBoxIsAddition";
            this.checkBoxIsAddition.Size = new System.Drawing.Size(119, 24);
            this.checkBoxIsAddition.TabIndex = 3;
            this.checkBoxIsAddition.Text = "Is Addition?";
            this.checkBoxIsAddition.UseVisualStyleBackColor = true;
            // 
            // buttonGetScore
            // 
            this.buttonGetScore.Location = new System.Drawing.Point(458, 426);
            this.buttonGetScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGetScore.Name = "buttonGetScore";
            this.buttonGetScore.Size = new System.Drawing.Size(270, 77);
            this.buttonGetScore.TabIndex = 4;
            this.buttonGetScore.Text = "Get Ending Score";
            this.buttonGetScore.UseVisualStyleBackColor = true;
            this.buttonGetScore.Click += new System.EventHandler(this.buttonGetScore_Click);
            // 
            // checkBoxKilledWumpus
            // 
            this.checkBoxKilledWumpus.AutoSize = true;
            this.checkBoxKilledWumpus.Location = new System.Drawing.Point(258, 115);
            this.checkBoxKilledWumpus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxKilledWumpus.Name = "checkBoxKilledWumpus";
            this.checkBoxKilledWumpus.Size = new System.Drawing.Size(148, 24);
            this.checkBoxKilledWumpus.TabIndex = 5;
            this.checkBoxKilledWumpus.Text = "Killed Wumpus?";
            this.checkBoxKilledWumpus.UseVisualStyleBackColor = true;
            this.checkBoxKilledWumpus.CheckedChanged += new System.EventHandler(this.checkBoxKilledWumpus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arrows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gold Coins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Moves";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Score";
            // 
            // textBoxArrows
            // 
            this.textBoxArrows.Location = new System.Drawing.Point(202, 192);
            this.textBoxArrows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxArrows.Name = "textBoxArrows";
            this.textBoxArrows.ReadOnly = true;
            this.textBoxArrows.Size = new System.Drawing.Size(148, 26);
            this.textBoxArrows.TabIndex = 10;
            this.textBoxArrows.Text = "0";
            // 
            // textBoxCoins
            // 
            this.textBoxCoins.Location = new System.Drawing.Point(202, 249);
            this.textBoxCoins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCoins.Name = "textBoxCoins";
            this.textBoxCoins.ReadOnly = true;
            this.textBoxCoins.Size = new System.Drawing.Size(148, 26);
            this.textBoxCoins.TabIndex = 11;
            this.textBoxCoins.Text = "0";
            // 
            // textBoxMoves
            // 
            this.textBoxMoves.Location = new System.Drawing.Point(202, 306);
            this.textBoxMoves.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMoves.Name = "textBoxMoves";
            this.textBoxMoves.ReadOnly = true;
            this.textBoxMoves.Size = new System.Drawing.Size(148, 26);
            this.textBoxMoves.TabIndex = 12;
            this.textBoxMoves.Text = "0";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(202, 365);
            this.textBoxScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.ReadOnly = true;
            this.textBoxScore.Size = new System.Drawing.Size(148, 26);
            this.textBoxScore.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 455);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount +/-";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(202, 451);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(148, 26);
            this.textBoxAmount.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 608);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxMoves);
            this.Controls.Add(this.textBoxCoins);
            this.Controls.Add(this.textBoxArrows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxKilledWumpus);
            this.Controls.Add(this.buttonGetScore);
            this.Controls.Add(this.checkBoxIsAddition);
            this.Controls.Add(this.buttonIncrement);
            this.Controls.Add(this.buttonCoins);
            this.Controls.Add(this.buttonArrows);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArrows;
        private System.Windows.Forms.Button buttonCoins;
        private System.Windows.Forms.Button buttonIncrement;
        private System.Windows.Forms.CheckBox checkBoxIsAddition;
        private System.Windows.Forms.Button buttonGetScore;
        private System.Windows.Forms.CheckBox checkBoxKilledWumpus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxArrows;
        private System.Windows.Forms.TextBox textBoxCoins;
        private System.Windows.Forms.TextBox textBoxMoves;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAmount;
    }
}

