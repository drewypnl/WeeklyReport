namespace WeeklyReport
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.picRobot = new System.Windows.Forms.PictureBox();
            this.picHelixorter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picRobot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelixorter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picRobot
            // 
            this.picRobot.Cursor = System.Windows.Forms.Cursors.Default;
            this.picRobot.Image = ((System.Drawing.Image)(resources.GetObject("picRobot.Image")));
            this.picRobot.InitialImage = ((System.Drawing.Image)(resources.GetObject("picRobot.InitialImage")));
            this.picRobot.Location = new System.Drawing.Point(12, 63);
            this.picRobot.Name = "picRobot";
            this.picRobot.Size = new System.Drawing.Size(200, 125);
            this.picRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRobot.TabIndex = 2;
            this.picRobot.TabStop = false;
            // 
            // picHelixorter
            // 
            this.picHelixorter.Cursor = System.Windows.Forms.Cursors.Default;
            this.picHelixorter.Image = ((System.Drawing.Image)(resources.GetObject("picHelixorter.Image")));
            this.picHelixorter.InitialImage = ((System.Drawing.Image)(resources.GetObject("picHelixorter.InitialImage")));
            this.picHelixorter.Location = new System.Drawing.Point(257, 63);
            this.picHelixorter.Name = "picHelixorter";
            this.picHelixorter.Size = new System.Drawing.Size(193, 125);
            this.picHelixorter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHelixorter.TabIndex = 3;
            this.picHelixorter.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Copyright 2014: Vanderlande";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "For Information Please Contact steve.drew@vanderlande.com";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 254);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picHelixorter);
            this.Controls.Add(this.picRobot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            ((System.ComponentModel.ISupportInitialize)(this.picRobot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelixorter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRobot;
        private System.Windows.Forms.PictureBox picHelixorter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}