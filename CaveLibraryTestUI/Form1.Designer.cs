namespace CaveLibraryTestUI
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
            labelValid = new Label();
            textBoxRoom = new TextBox();
            textBoxDirection = new TextBox();
            textBoxCaveIndex = new TextBox();
            textBoxAdjacent = new TextBox();
            textBoxReachableDirections = new TextBox();
            textBoxNewRoomNumber = new TextBox();
            buttonAdjacent = new Button();
            buttonValid = new Button();
            buttonMoveValid = new Button();
            buttonGetNewRoom = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 0;
            label1.Text = "Room";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 1;
            label2.Text = "Adjacent Rooms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 260);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 2;
            label3.Text = "Direction";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 260);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(222, 25);
            label4.TabIndex = 3;
            label4.Text = "Valid Directions Bool Array";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 448);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 4;
            label5.Text = "Cave Index";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(209, 448);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(170, 25);
            label6.TabIndex = 5;
            label6.Text = "New Room Number";
            // 
            // labelValid
            // 
            labelValid.AutoSize = true;
            labelValid.Location = new Point(786, 348);
            labelValid.Margin = new Padding(4, 0, 4, 0);
            labelValid.Name = "labelValid";
            labelValid.Size = new Size(59, 25);
            labelValid.TabIndex = 6;
            labelValid.Text = "Result";
            // 
            // textBoxRoom
            // 
            textBoxRoom.Location = new Point(51, 125);
            textBoxRoom.Margin = new Padding(4, 5, 4, 5);
            textBoxRoom.Name = "textBoxRoom";
            textBoxRoom.Size = new Size(118, 31);
            textBoxRoom.TabIndex = 7;
            // 
            // textBoxDirection
            // 
            textBoxDirection.Location = new Point(51, 315);
            textBoxDirection.Margin = new Padding(4, 5, 4, 5);
            textBoxDirection.Name = "textBoxDirection";
            textBoxDirection.Size = new Size(118, 31);
            textBoxDirection.TabIndex = 8;
            // 
            // textBoxCaveIndex
            // 
            textBoxCaveIndex.Location = new Point(51, 503);
            textBoxCaveIndex.Margin = new Padding(4, 5, 4, 5);
            textBoxCaveIndex.Name = "textBoxCaveIndex";
            textBoxCaveIndex.Size = new Size(118, 31);
            textBoxCaveIndex.TabIndex = 9;
            // 
            // textBoxAdjacent
            // 
            textBoxAdjacent.Location = new Point(209, 125);
            textBoxAdjacent.Margin = new Padding(4, 5, 4, 5);
            textBoxAdjacent.Name = "textBoxAdjacent";
            textBoxAdjacent.Size = new Size(277, 31);
            textBoxAdjacent.TabIndex = 10;
            // 
            // textBoxReachableDirections
            // 
            textBoxReachableDirections.Location = new Point(209, 315);
            textBoxReachableDirections.Margin = new Padding(4, 5, 4, 5);
            textBoxReachableDirections.Name = "textBoxReachableDirections";
            textBoxReachableDirections.Size = new Size(277, 31);
            textBoxReachableDirections.TabIndex = 11;
            // 
            // textBoxNewRoomNumber
            // 
            textBoxNewRoomNumber.Location = new Point(209, 503);
            textBoxNewRoomNumber.Margin = new Padding(4, 5, 4, 5);
            textBoxNewRoomNumber.Name = "textBoxNewRoomNumber";
            textBoxNewRoomNumber.Size = new Size(277, 31);
            textBoxNewRoomNumber.TabIndex = 12;
            // 
            // buttonAdjacent
            // 
            buttonAdjacent.Location = new Point(521, 73);
            buttonAdjacent.Margin = new Padding(4, 5, 4, 5);
            buttonAdjacent.Name = "buttonAdjacent";
            buttonAdjacent.Size = new Size(226, 90);
            buttonAdjacent.TabIndex = 13;
            buttonAdjacent.Text = "Get Adjacent Rooms";
            buttonAdjacent.UseVisualStyleBackColor = true;
            buttonAdjacent.Click += buttonAdjacent_Click_1;
            // 
            // buttonValid
            // 
            buttonValid.Location = new Point(521, 195);
            buttonValid.Margin = new Padding(4, 5, 4, 5);
            buttonValid.Name = "buttonValid";
            buttonValid.Size = new Size(226, 90);
            buttonValid.TabIndex = 14;
            buttonValid.Text = "Directions 0-5 Reachable?";
            buttonValid.UseVisualStyleBackColor = true;
            buttonValid.Click += buttonValid_Click_1;
            // 
            // buttonMoveValid
            // 
            buttonMoveValid.Location = new Point(521, 315);
            buttonMoveValid.Margin = new Padding(4, 5, 4, 5);
            buttonMoveValid.Name = "buttonMoveValid";
            buttonMoveValid.Size = new Size(226, 90);
            buttonMoveValid.TabIndex = 15;
            buttonMoveValid.Text = "Is Move Valid?";
            buttonMoveValid.UseVisualStyleBackColor = true;
            buttonMoveValid.Click += buttonMoveValid_Click_1;
            // 
            // buttonGetNewRoom
            // 
            buttonGetNewRoom.Location = new Point(521, 435);
            buttonGetNewRoom.Margin = new Padding(4, 5, 4, 5);
            buttonGetNewRoom.Name = "buttonGetNewRoom";
            buttonGetNewRoom.Size = new Size(226, 90);
            buttonGetNewRoom.TabIndex = 16;
            buttonGetNewRoom.Text = "Get New Room #";
            buttonGetNewRoom.UseVisualStyleBackColor = true;
            buttonGetNewRoom.Click += buttonGetNewRoom_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 615);
            Controls.Add(buttonGetNewRoom);
            Controls.Add(buttonMoveValid);
            Controls.Add(buttonValid);
            Controls.Add(buttonAdjacent);
            Controls.Add(textBoxNewRoomNumber);
            Controls.Add(textBoxReachableDirections);
            Controls.Add(textBoxAdjacent);
            Controls.Add(textBoxCaveIndex);
            Controls.Add(textBoxDirection);
            Controls.Add(textBoxRoom);
            Controls.Add(labelValid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Nathan - Cave Test UI";
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
        private Label labelValid;
        private TextBox textBoxRoom;
        private TextBox textBoxDirection;
        private TextBox textBoxCaveIndex;
        private TextBox textBoxAdjacent;
        private TextBox textBoxReachableDirections;
        private TextBox textBoxNewRoomNumber;
        private Button buttonAdjacent;
        private Button buttonValid;
        private Button buttonMoveValid;
        private Button buttonGetNewRoom;
    }
}
