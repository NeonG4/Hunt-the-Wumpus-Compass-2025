namespace ScoreboardTestUI
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
            button1 = new Button();
            scorebox = new ListBox();
            label1 = new Label();
            Addnewscore = new Button();
            Scorename = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(54, 74);
            button1.Name = "button1";
            button1.Size = new Size(173, 51);
            button1.TabIndex = 0;
            button1.Text = "GetHighSciores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // scorebox
            // 
            scorebox.FormattingEnabled = true;
            scorebox.ItemHeight = 15;
            scorebox.Location = new Point(364, 90);
            scorebox.Name = "scorebox";
            scorebox.Size = new Size(221, 169);
            scorebox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 270);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "Scorename";
            // 
            // Addnewscore
            // 
            Addnewscore.Location = new Point(118, 357);
            Addnewscore.Name = "Addnewscore";
            Addnewscore.Size = new Size(233, 50);
            Addnewscore.TabIndex = 3;
            Addnewscore.Text = "AddNEwScore";
            Addnewscore.UseVisualStyleBackColor = true;
            Addnewscore.Click += Addnewscore_Click;
            // 
            // Scorename
            // 
            Scorename.Location = new Point(208, 262);
            Scorename.Name = "Scorename";
            Scorename.Size = new Size(100, 23);
            Scorename.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Scorename);
            Controls.Add(Addnewscore);
            Controls.Add(label1);
            Controls.Add(scorebox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox scorebox;
        private Label label1;
        private Button Addnewscore;
        private TextBox Scorename;
    }
}
