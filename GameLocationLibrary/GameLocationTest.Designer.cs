namespace GameLocationLibrary
{
    partial class GameLocationTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameLocationTest));
            listBoxHazards = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // listBoxHazards
            // 
            listBoxHazards.FormattingEnabled = true;
            resources.ApplyResources(listBoxHazards, "listBoxHazards");
            listBoxHazards.Name = "listBoxHazards";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.FromArgb(192, 0, 0);
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = Color.Navy;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            resources.ApplyResources(button3, "button3");
            button3.ForeColor = Color.Green;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // button4
            // 
            button4.ForeColor = Color.Black;
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // GameLocationTest
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBoxHazards);
            ForeColor = Color.FromArgb(255, 255, 128);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "GameLocationTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxHazards;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
    }
}