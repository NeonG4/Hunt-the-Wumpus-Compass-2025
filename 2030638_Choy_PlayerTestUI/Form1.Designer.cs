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
            this.buttonArrows.Location = new System.Drawing.Point(305, 109);
            this.buttonArrows.Name = "buttonArrows";
            this.buttonArrows.Size = new System.Drawing.Size(180, 50);
            this.buttonArrows.TabIndex = 0;
            this.buttonArrows.Text = "Add or Subtract Arrows";
            this.buttonArrows.UseVisualStyleBackColor = true;
            this.buttonArrows.Click += new System.EventHandler(this.buttonArrows_Click);
            // 
            // buttonCoins
            // 
            this.buttonCoins.Location = new System.Drawing.Point(305, 165);
            this.buttonCoins.Name = "buttonCoins";
            this.buttonCoins.Size = new System.Drawing.Size(180, 50);
            this.buttonCoins.TabIndex = 1;
            this.buttonCoins.Text = "Add or Subtract Coins";
            this.buttonCoins.UseVisualStyleBackColor = true;
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.Location = new System.Drawing.Point(305, 221);
            this.buttonIncrement.Name = "buttonIncrement";
            this.buttonIncrement.Size = new System.Drawing.Size(180, 50);
            this.buttonIncrement.TabIndex = 2;
            this.buttonIncrement.Text = "Increment Move Count";
            this.buttonIncrement.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsAddition
            // 
            this.checkBoxIsAddition.AutoSize = true;
            this.checkBoxIsAddition.Checked = true;
            this.checkBoxIsAddition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsAddition.Location = new System.Drawing.Point(62, 75);
            this.checkBoxIsAddition.Name = "checkBoxIsAddition";
            this.checkBoxIsAddition.Size = new System.Drawing.Size(81, 17);
            this.checkBoxIsAddition.TabIndex = 3;
            this.checkBoxIsAddition.Text = "Is Addition?";
            this.checkBoxIsAddition.UseVisualStyleBackColor = true;
            // 
            // buttonGetScore
            // 
            this.buttonGetScore.Location = new System.Drawing.Point(305, 277);
            this.buttonGetScore.Name = "buttonGetScore";
            this.buttonGetScore.Size = new System.Drawing.Size(180, 50);
            this.buttonGetScore.TabIndex = 4;
            this.buttonGetScore.Text = "Get Ending Score";
            this.buttonGetScore.UseVisualStyleBackColor = true;
            // 
            // checkBoxKilledWumpus
            // 
            this.checkBoxKilledWumpus.AutoSize = true;
            this.checkBoxKilledWumpus.Location = new System.Drawing.Point(172, 75);
            this.checkBoxKilledWumpus.Name = "checkBoxKilledWumpus";
            this.checkBoxKilledWumpus.Size = new System.Drawing.Size(102, 17);
            this.checkBoxKilledWumpus.TabIndex = 5;
            this.checkBoxKilledWumpus.Text = "Killed Wumpus?";
            this.checkBoxKilledWumpus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arrows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gold Coins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Moves";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Score";
            // 
            // textBoxArrows
            // 
            this.textBoxArrows.Location = new System.Drawing.Point(135, 125);
            this.textBoxArrows.Name = "textBoxArrows";
            this.textBoxArrows.Size = new System.Drawing.Size(100, 20);
            this.textBoxArrows.TabIndex = 10;
            // 
            // textBoxCoins
            // 
            this.textBoxCoins.Location = new System.Drawing.Point(135, 162);
            this.textBoxCoins.Name = "textBoxCoins";
            this.textBoxCoins.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoins.TabIndex = 11;
            // 
            // textBoxMoves
            // 
            this.textBoxMoves.Location = new System.Drawing.Point(135, 199);
            this.textBoxMoves.Name = "textBoxMoves";
            this.textBoxMoves.Size = new System.Drawing.Size(100, 20);
            this.textBoxMoves.TabIndex = 12;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(135, 237);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(100, 20);
            this.textBoxScore.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount +/-";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(135, 293);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 395);
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

