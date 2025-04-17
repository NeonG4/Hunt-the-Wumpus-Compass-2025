namespace _132456_Donnelly_SoundDemo
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonSoundEffect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxBackGroundMusic = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(51, 49);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(224, 48);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play Jet Effect";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonSoundEffect
            // 
            this.buttonSoundEffect.Location = new System.Drawing.Point(51, 124);
            this.buttonSoundEffect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSoundEffect.Name = "buttonSoundEffect";
            this.buttonSoundEffect.Size = new System.Drawing.Size(224, 48);
            this.buttonSoundEffect.TabIndex = 1;
            this.buttonSoundEffect.Text = "Play Bubble Effect";
            this.buttonSoundEffect.UseVisualStyleBackColor = true;
            this.buttonSoundEffect.Click += new System.EventHandler(this.buttonSoundEffect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxBackGroundMusic
            // 
            this.comboBoxBackGroundMusic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBackGroundMusic.FormattingEnabled = true;
            this.comboBoxBackGroundMusic.Items.AddRange(new object[] {
            "Action Hero",
            "Lost in the Forest",
            "Raising Me Higher",
            "Steel Rods",
            "Storm Front",
            "Night Music"});
            this.comboBoxBackGroundMusic.Location = new System.Drawing.Point(341, 62);
            this.comboBoxBackGroundMusic.Name = "comboBoxBackGroundMusic";
            this.comboBoxBackGroundMusic.Size = new System.Drawing.Size(215, 24);
            this.comboBoxBackGroundMusic.TabIndex = 3;
            this.comboBoxBackGroundMusic.SelectedIndexChanged += new System.EventHandler(this.comboBoxBackGroundMusic_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 394);
            this.Controls.Add(this.comboBoxBackGroundMusic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSoundEffect);
            this.Controls.Add(this.buttonPlay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Play Sounds";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonSoundEffect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxBackGroundMusic;
    }
}

