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
            this.textBoxReachableDirections = new System.Windows.Forms.TextBox();
            this.buttonMoveValid = new System.Windows.Forms.Button();
            this.textBoxDirection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCaveIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelValid = new System.Windows.Forms.Label();
            this.textBoxNewRoomNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGetNewRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adjacent Rooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Directions 0-5 Reachable?";
            // 
            // buttonAdjacent
            // 
            this.buttonAdjacent.Location = new System.Drawing.Point(620, 46);
            this.buttonAdjacent.Name = "buttonAdjacent";
            this.buttonAdjacent.Size = new System.Drawing.Size(248, 68);
            this.buttonAdjacent.TabIndex = 3;
            this.buttonAdjacent.Text = "Get Adjacent Rooms";
            this.buttonAdjacent.UseVisualStyleBackColor = true;
            this.buttonAdjacent.Click += new System.EventHandler(this.buttonAdjacent_Click);
            // 
            // buttonValid
            // 
            this.buttonValid.Location = new System.Drawing.Point(620, 155);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(248, 68);
            this.buttonValid.TabIndex = 4;
            this.buttonValid.Text = "Directions 0-5 Reachable?";
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.buttonValid_Click);
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Location = new System.Drawing.Point(68, 140);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.Size = new System.Drawing.Size(133, 26);
            this.textBoxRoom.TabIndex = 5;
            // 
            // textBoxAdjacent
            // 
            this.textBoxAdjacent.Location = new System.Drawing.Point(256, 140);
            this.textBoxAdjacent.Name = "textBoxAdjacent";
            this.textBoxAdjacent.Size = new System.Drawing.Size(164, 26);
            this.textBoxAdjacent.TabIndex = 6;
            // 
            // textBoxReachableDirections
            // 
            this.textBoxReachableDirections.Location = new System.Drawing.Point(256, 265);
            this.textBoxReachableDirections.Name = "textBoxReachableDirections";
            this.textBoxReachableDirections.Size = new System.Drawing.Size(324, 26);
            this.textBoxReachableDirections.TabIndex = 7;
            // 
            // buttonMoveValid
            // 
            this.buttonMoveValid.Location = new System.Drawing.Point(620, 263);
            this.buttonMoveValid.Name = "buttonMoveValid";
            this.buttonMoveValid.Size = new System.Drawing.Size(248, 68);
            this.buttonMoveValid.TabIndex = 8;
            this.buttonMoveValid.Text = "Is Move Valid?";
            this.buttonMoveValid.UseVisualStyleBackColor = true;
            this.buttonMoveValid.Click += new System.EventHandler(this.buttonMoveValid_Click);
            // 
            // textBoxDirection
            // 
            this.textBoxDirection.Location = new System.Drawing.Point(68, 265);
            this.textBoxDirection.Name = "textBoxDirection";
            this.textBoxDirection.Size = new System.Drawing.Size(133, 26);
            this.textBoxDirection.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Direction";
            // 
            // textBoxCaveIndex
            // 
            this.textBoxCaveIndex.Location = new System.Drawing.Point(68, 386);
            this.textBoxCaveIndex.Name = "textBoxCaveIndex";
            this.textBoxCaveIndex.Size = new System.Drawing.Size(133, 26);
            this.textBoxCaveIndex.TabIndex = 13;
            this.textBoxCaveIndex.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cave Index";
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Location = new System.Drawing.Point(886, 288);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(55, 20);
            this.labelValid.TabIndex = 14;
            this.labelValid.Text = "Result";
            // 
            // textBoxNewRoomNumber
            // 
            this.textBoxNewRoomNumber.Location = new System.Drawing.Point(256, 386);
            this.textBoxNewRoomNumber.Name = "textBoxNewRoomNumber";
            this.textBoxNewRoomNumber.Size = new System.Drawing.Size(187, 26);
            this.textBoxNewRoomNumber.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "New Room Number";
            // 
            // buttonGetNewRoom
            // 
            this.buttonGetNewRoom.Location = new System.Drawing.Point(620, 371);
            this.buttonGetNewRoom.Name = "buttonGetNewRoom";
            this.buttonGetNewRoom.Size = new System.Drawing.Size(248, 68);
            this.buttonGetNewRoom.TabIndex = 17;
            this.buttonGetNewRoom.Text = "Get New Room #";
            this.buttonGetNewRoom.UseVisualStyleBackColor = true;
            this.buttonGetNewRoom.Click += new System.EventHandler(this.buttonGetNewRoom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 491);
            this.Controls.Add(this.buttonGetNewRoom);
            this.Controls.Add(this.textBoxNewRoomNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.textBoxCaveIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDirection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonMoveValid);
            this.Controls.Add(this.textBoxReachableDirections);
            this.Controls.Add(this.textBoxAdjacent);
            this.Controls.Add(this.textBoxRoom);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.buttonAdjacent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nathan - Cave Test UI";
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
        private System.Windows.Forms.TextBox textBoxReachableDirections;
        private System.Windows.Forms.Button buttonMoveValid;
        private System.Windows.Forms.TextBox textBoxDirection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCaveIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelValid;
        private System.Windows.Forms.TextBox textBoxNewRoomNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGetNewRoom;
    }
}

