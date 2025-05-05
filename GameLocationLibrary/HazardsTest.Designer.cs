namespace GameLocationLibrary
{
    partial class HazardsTest
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
            listBoxHazards = new ListBox();
            label1 = new Label();
            button1 = new Button();
            textBoxData = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBoxHazards
            // 
            listBoxHazards.FormattingEnabled = true;
            listBoxHazards.ItemHeight = 15;
            listBoxHazards.Location = new Point(12, 12);
            listBoxHazards.Name = "listBoxHazards";
            listBoxHazards.Size = new Size(83, 109);
            listBoxHazards.TabIndex = 0;
            listBoxHazards.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 12);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 1;
            label1.Text = "TEST DATA";
            // 
            // button1
            // 
            button1.Location = new Point(12, 127);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 2;
            button1.Text = "Get Hazards";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(121, 40);
            textBoxData.Name = "textBoxData";
            textBoxData.ReadOnly = true;
            textBoxData.Size = new Size(123, 23);
            textBoxData.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(12, 156);
            button2.Name = "button2";
            button2.Size = new Size(83, 44);
            button2.TabIndex = 4;
            button2.Text = "Spawn Player";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // HazardsTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 243);
            Controls.Add(button2);
            Controls.Add(textBoxData);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBoxHazards);
            Name = "HazardsTest";
            Text = "HazardsTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxHazards;
        private Label label1;
        private Button button1;
        private TextBox textBoxData;
        private Button button2;
    }
}