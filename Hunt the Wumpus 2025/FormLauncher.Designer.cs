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
            buttonStartWumpus = new Button();
            textBoxName = new TextBox();
            labelName = new Label();
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
            // buttonStartWumpus
            // 
            buttonStartWumpus.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStartWumpus.Location = new Point(227, 9);
            buttonStartWumpus.Name = "buttonStartWumpus";
            buttonStartWumpus.Size = new Size(176, 55);
            buttonStartWumpus.TabIndex = 8;
            buttonStartWumpus.Text = "Start Wumpus Game";
            buttonStartWumpus.UseVisualStyleBackColor = true;
            buttonStartWumpus.Click += StartGame;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(21, 33);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(175, 27);
            textBoxName.TabIndex = 9;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(21, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 10;
            labelName.Text = "Name:";
            // 
            // FormLaucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 90);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(buttonStartWumpus);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLaucher";
            Text = "Launcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonStartWumpus;
        private TextBox textBoxName;
        private Label labelName;
    }
}
