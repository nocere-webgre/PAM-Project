namespace Project_PAM
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ButonExit = new System.Windows.Forms.Button();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.ButtonStartStop = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PauseLabel = new System.Windows.Forms.Label();
            this.FullScreenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(76, 240);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(115, 15);
            this.ProgressBar.TabIndex = 7;
            // 
            // ButonExit
            // 
            this.ButonExit.BackgroundImage = global::Project_PAM.Properties.Resources._out;
            this.ButonExit.Location = new System.Drawing.Point(76, 780);
            this.ButonExit.Name = "ButonExit";
            this.ButonExit.Size = new System.Drawing.Size(115, 115);
            this.ButonExit.TabIndex = 12;
            this.ButonExit.UseVisualStyleBackColor = true;
            this.ButonExit.Click += new System.EventHandler(this.ButonExit_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.BackgroundImage = global::Project_PAM.Properties.Resources.home;
            this.ButtonHome.Location = new System.Drawing.Point(76, 420);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(115, 115);
            this.ButtonHome.TabIndex = 11;
            this.ButtonHome.UseVisualStyleBackColor = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.BackgroundImage = global::Project_PAM.Properties.Resources.left;
            this.ButtonLeft.Location = new System.Drawing.Point(76, 660);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(115, 115);
            this.ButtonLeft.TabIndex = 10;
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // ButtonRight
            // 
            this.ButtonRight.BackgroundImage = global::Project_PAM.Properties.Resources.right;
            this.ButtonRight.Location = new System.Drawing.Point(76, 540);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(115, 115);
            this.ButtonRight.TabIndex = 9;
            this.ButtonRight.UseVisualStyleBackColor = true;
            this.ButtonRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // ButtonStartStop
            // 
            this.ButtonStartStop.BackgroundImage = global::Project_PAM.Properties.Resources.playpause;
            this.ButtonStartStop.Location = new System.Drawing.Point(76, 300);
            this.ButtonStartStop.Name = "ButtonStartStop";
            this.ButtonStartStop.Size = new System.Drawing.Size(115, 115);
            this.ButtonStartStop.TabIndex = 8;
            this.ButtonStartStop.UseVisualStyleBackColor = true;
            this.ButtonStartStop.Click += new System.EventHandler(this.ButtonStartStop_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PauseLabel
            // 
            this.PauseLabel.AutoSize = true;
            this.PauseLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PauseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PauseLabel.ForeColor = System.Drawing.Color.Red;
            this.PauseLabel.Location = new System.Drawing.Point(110, 270);
            this.PauseLabel.Name = "PauseLabel";
            this.PauseLabel.Size = new System.Drawing.Size(45, 15);
            this.PauseLabel.TabIndex = 6;
            this.PauseLabel.Text = "PAUZA";
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.Location = new System.Drawing.Point(12, 264);
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(216, 46);
            this.FullScreenButton.TabIndex = 1;
            this.FullScreenButton.Text = "FULL SCREEN";
            this.FullScreenButton.UseVisualStyleBackColor = true;
            this.FullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(234, 265);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(203, 45);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "CLOSE PROGRAM";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(449, 258);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 4;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 322);
            this.Controls.Add(this.ButonExit);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.ButtonLeft);
            this.Controls.Add(this.ButtonRight);
            this.Controls.Add(this.ButtonStartStop);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.PauseLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.FullScreenButton);
            this.Controls.Add(this.PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Pokaz Slajdow PAM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button ButtonStartStop;
        private System.Windows.Forms.Button ButtonRight;
        private System.Windows.Forms.Button ButtonLeft;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Button ButonExit;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label PauseLabel;
        private System.Windows.Forms.Button FullScreenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}

