namespace _2030638_Choy_CaveTestUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdjacent = new System.Windows.Forms.Button();
            this.buttonValid = new System.Windows.Forms.Button();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            this.textBoxAdjacent = new System.Windows.Forms.TextBox();
            this.textBoxValid = new System.Windows.Forms.TextBox();
            this.buttonMoveValid = new System.Windows.Forms.Button();
            this.textBoxDirection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCaveIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelValid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adjacent Rooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valid Rooms";
            // 
            // buttonAdjacent
            // 
            this.buttonAdjacent.Location = new System.Drawing.Point(693, 60);
            this.buttonAdjacent.Name = "buttonAdjacent";
            this.buttonAdjacent.Size = new System.Drawing.Size(200, 67);
            this.buttonAdjacent.TabIndex = 3;
            this.buttonAdjacent.Text = "Get Adjacent Rooms";
            this.buttonAdjacent.UseVisualStyleBackColor = true;
            this.buttonAdjacent.Click += new System.EventHandler(this.buttonAdjacent_Click);
            // 
            // buttonValid
            // 
            this.buttonValid.Location = new System.Drawing.Point(693, 170);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(200, 67);
            this.buttonValid.TabIndex = 4;
            this.buttonValid.Text = "Get Valid Rooms";
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Location = new System.Drawing.Point(104, 235);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.Size = new System.Drawing.Size(133, 26);
            this.textBoxRoom.TabIndex = 5;
            // 
            // textBoxAdjacent
            // 
            this.textBoxAdjacent.Location = new System.Drawing.Point(217, 140);
            this.textBoxAdjacent.Name = "textBoxAdjacent";
            this.textBoxAdjacent.Size = new System.Drawing.Size(203, 26);
            this.textBoxAdjacent.TabIndex = 6;
            // 
            // textBoxValid
            // 
            this.textBoxValid.Location = new System.Drawing.Point(470, 140);
            this.textBoxValid.Name = "textBoxValid";
            this.textBoxValid.Size = new System.Drawing.Size(187, 26);
            this.textBoxValid.TabIndex = 7;
            // 
            // buttonMoveValid
            // 
            this.buttonMoveValid.Location = new System.Drawing.Point(693, 277);
            this.buttonMoveValid.Name = "buttonMoveValid";
            this.buttonMoveValid.Size = new System.Drawing.Size(200, 67);
            this.buttonMoveValid.TabIndex = 8;
            this.buttonMoveValid.Text = "Is Move Valid?";
            this.buttonMoveValid.UseVisualStyleBackColor = true;
            this.buttonMoveValid.Click += new System.EventHandler(this.buttonMoveValid_Click);
            // 
            // textBoxDirection
            // 
            this.textBoxDirection.Location = new System.Drawing.Point(287, 323);
            this.textBoxDirection.Name = "textBoxDirection";
            this.textBoxDirection.Size = new System.Drawing.Size(133, 26);
            this.textBoxDirection.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Direction";
            // 
            // textBoxCaveIndex
            // 
            this.textBoxCaveIndex.Location = new System.Drawing.Point(459, 323);
            this.textBoxCaveIndex.Name = "textBoxCaveIndex";
            this.textBoxCaveIndex.Size = new System.Drawing.Size(133, 26);
            this.textBoxCaveIndex.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cave Index";
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Location = new System.Drawing.Point(937, 300);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(55, 20);
            this.labelValid.TabIndex = 14;
            this.labelValid.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 419);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.textBoxCaveIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDirection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonMoveValid);
            this.Controls.Add(this.textBoxValid);
            this.Controls.Add(this.textBoxAdjacent);
            this.Controls.Add(this.textBoxRoom);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.buttonAdjacent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cave Test UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdjacent;
        private System.Windows.Forms.Button buttonValid;
        private System.Windows.Forms.TextBox textBoxRoom;
        private System.Windows.Forms.TextBox textBoxAdjacent;
        private System.Windows.Forms.TextBox textBoxValid;
        private System.Windows.Forms.Button buttonMoveValid;
        private System.Windows.Forms.TextBox textBoxDirection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCaveIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelValid;
    }
}

