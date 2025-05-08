namespace ScoreBoardTest
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            namebox = new TextBox();
            scorebox = new TextBox();
            cavebox = new TextBox();
            TurnBox = new TextBox();
            Goldbvox = new TextBox();
            arrowbox = new TextBox();
            listBoxScores = new ListBox();
            Wumpusdead = new CheckBox();
            addtobox = new Button();
            loadtofile = new Button();
            Savetofile = new Button();
            addscore = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 67);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 102);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Score";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 131);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Cave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 165);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Turns";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 203);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Gold";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 246);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 5;
            label6.Text = "Arrows";
            // 
            // namebox
            // 
            namebox.Location = new Point(192, 59);
            namebox.Name = "namebox";
            namebox.Size = new Size(100, 23);
            namebox.TabIndex = 6;
            // 
            // scorebox
            // 
            scorebox.Location = new Point(192, 94);
            scorebox.Name = "scorebox";
            scorebox.Size = new Size(100, 23);
            scorebox.TabIndex = 7;
            // 
            // cavebox
            // 
            cavebox.Location = new Point(192, 123);
            cavebox.Name = "cavebox";
            cavebox.Size = new Size(100, 23);
            cavebox.TabIndex = 8;
            // 
            // TurnBox
            // 
            TurnBox.Location = new Point(192, 157);
            TurnBox.Name = "TurnBox";
            TurnBox.Size = new Size(100, 23);
            TurnBox.TabIndex = 9;
            // 
            // Goldbvox
            // 
            Goldbvox.Location = new Point(192, 195);
            Goldbvox.Name = "Goldbvox";
            Goldbvox.Size = new Size(100, 23);
            Goldbvox.TabIndex = 10;
            // 
            // arrowbox
            // 
            arrowbox.Location = new Point(192, 238);
            arrowbox.Name = "arrowbox";
            arrowbox.Size = new Size(100, 23);
            arrowbox.TabIndex = 11;
            // 
            // listBoxScores
            // 
            listBoxScores.FormattingEnabled = true;
            listBoxScores.ItemHeight = 15;
            listBoxScores.Location = new Point(410, 120);
            listBoxScores.Name = "listBoxScores";
            listBoxScores.Size = new Size(120, 94);
            listBoxScores.TabIndex = 12;
            listBoxScores.SelectedIndexChanged += listBoxScores_SelectedIndexChanged;
            // 
            // Wumpusdead
            // 
            Wumpusdead.AutoSize = true;
            Wumpusdead.Location = new Point(83, 302);
            Wumpusdead.Name = "Wumpusdead";
            Wumpusdead.Size = new Size(123, 19);
            Wumpusdead.TabIndex = 13;
            Wumpusdead.Text = "Wumpus defeated";
            Wumpusdead.UseVisualStyleBackColor = true;
            // 
            // addtobox
            // 
            addtobox.Location = new Point(342, 291);
            addtobox.Name = "addtobox";
            addtobox.Size = new Size(110, 38);
            addtobox.TabIndex = 14;
            addtobox.Text = "ADd to listbox";
            addtobox.UseVisualStyleBackColor = true;
            addtobox.Click += addtobox_Click;
            // 
            // loadtofile
            // 
            loadtofile.Location = new Point(623, 364);
            loadtofile.Name = "loadtofile";
            loadtofile.Size = new Size(110, 38);
            loadtofile.TabIndex = 15;
            loadtofile.Text = "loadTOfile";
            loadtofile.UseVisualStyleBackColor = true;
            loadtofile.Click += loadtofile_Click;
            // 
            // Savetofile
            // 
            Savetofile.Location = new Point(623, 291);
            Savetofile.Name = "Savetofile";
            Savetofile.Size = new Size(110, 38);
            Savetofile.TabIndex = 16;
            Savetofile.Text = "SavetoFile";
            Savetofile.UseVisualStyleBackColor = true;
            Savetofile.Click += Savetofile_Click;
            // 
            // addscore
            // 
            addscore.Location = new Point(483, 291);
            addscore.Name = "addscore";
            addscore.Size = new Size(110, 38);
            addscore.TabIndex = 17;
            addscore.Text = "addscore";
            addscore.UseVisualStyleBackColor = true;
            addscore.Click += addscore_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addscore);
            Controls.Add(Savetofile);
            Controls.Add(loadtofile);
            Controls.Add(addtobox);
            Controls.Add(Wumpusdead);
            Controls.Add(listBoxScores);
            Controls.Add(arrowbox);
            Controls.Add(Goldbvox);
            Controls.Add(TurnBox);
            Controls.Add(cavebox);
            Controls.Add(scorebox);
            Controls.Add(namebox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox namebox;
        private TextBox scorebox;
        private TextBox cavebox;
        private TextBox TurnBox;
        private TextBox Goldbvox;
        private TextBox arrowbox;
        private ListBox listBoxScores;
        private CheckBox Wumpusdead;
        private Button addtobox;
        private Button loadtofile;
        private Button Savetofile;
        private Button addscore;
    }
}
