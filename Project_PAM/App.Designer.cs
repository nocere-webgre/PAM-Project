namespace Project_PAM
{
    partial class App
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(2, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(109, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.Window;
            this.start.BackgroundImage = global::Project_PAM.Properties.Resources.playpause;
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start.Location = new System.Drawing.Point(2, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(178, 159);
            this.start.TabIndex = 3;
            this.start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.SystemColors.Window;
            this.right.BackgroundImage = global::Project_PAM.Properties.Resources.right;
            this.right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.right.FlatAppearance.BorderSize = 0;
            this.right.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.right.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.right.Location = new System.Drawing.Point(2, 159);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(178, 144);
            this.right.TabIndex = 2;
            this.right.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.SystemColors.Window;
            this.power.BackgroundImage = global::Project_PAM.Properties.Resources._out;
            this.power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.power.ForeColor = System.Drawing.SystemColors.Window;
            this.power.Location = new System.Drawing.Point(2, 371);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(178, 137);
            this.power.TabIndex = 1;
            this.power.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.power.UseVisualStyleBackColor = false;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.SystemColors.Window;
            this.left.BackgroundImage = global::Project_PAM.Properties.Resources.left;
            this.left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left.ForeColor = System.Drawing.SystemColors.Window;
            this.left.Location = new System.Drawing.Point(2, 299);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(178, 155);
            this.left.TabIndex = 0;
            this.left.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 544);
            this.Controls.Add(this.left);
            this.Controls.Add(this.power);
            this.Controls.Add(this.right);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "App";
            this.Text = "Camera";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button left;
    }
}