namespace WeeklyReport
{
    partial class frmOptions
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
            this.cmdOk = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.grpChangePass = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.cmdChangePass = new System.Windows.Forms.Button();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.grpChangePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdOk
            // 
            this.cmdOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOk.Location = new System.Drawing.Point(259, 331);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(99, 33);
            this.cmdOk.TabIndex = 0;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Controls.Add(this.tabSystem);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 312);
            this.tabControl1.TabIndex = 1;
            // 
            // tabUser
            // 
            this.tabUser.BackColor = System.Drawing.SystemColors.Control;
            this.tabUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabUser.Controls.Add(this.label4);
            this.tabUser.Controls.Add(this.grpChangePass);
            this.tabUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(342, 283);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = "To change your password complete the information below and click change";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpChangePass
            // 
            this.grpChangePass.Controls.Add(this.label3);
            this.grpChangePass.Controls.Add(this.label2);
            this.grpChangePass.Controls.Add(this.label1);
            this.grpChangePass.Controls.Add(this.txtConfirmPass);
            this.grpChangePass.Controls.Add(this.txtNewPass);
            this.grpChangePass.Controls.Add(this.txtCurrentPass);
            this.grpChangePass.Controls.Add(this.cmdChangePass);
            this.grpChangePass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpChangePass.Location = new System.Drawing.Point(16, 55);
            this.grpChangePass.Name = "grpChangePass";
            this.grpChangePass.Size = new System.Drawing.Size(309, 159);
            this.grpChangePass.TabIndex = 0;
            this.grpChangePass.TabStop = false;
            this.grpChangePass.Text = "Change Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Password";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(147, 84);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(148, 22);
            this.txtConfirmPass.TabIndex = 3;
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(147, 56);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(148, 22);
            this.txtNewPass.TabIndex = 2;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(147, 28);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.PasswordChar = '*';
            this.txtCurrentPass.Size = new System.Drawing.Size(148, 22);
            this.txtCurrentPass.TabIndex = 1;
            this.txtCurrentPass.TextChanged += new System.EventHandler(this.txtCurrentPass_TextChanged);
            // 
            // cmdChangePass
            // 
            this.cmdChangePass.Location = new System.Drawing.Point(217, 122);
            this.cmdChangePass.Name = "cmdChangePass";
            this.cmdChangePass.Size = new System.Drawing.Size(86, 31);
            this.cmdChangePass.TabIndex = 0;
            this.cmdChangePass.Text = "Change";
            this.cmdChangePass.UseVisualStyleBackColor = true;
            this.cmdChangePass.Click += new System.EventHandler(this.cmdChangePass_Click);
            // 
            // tabSystem
            // 
            this.tabSystem.BackColor = System.Drawing.SystemColors.Control;
            this.tabSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSystem.Location = new System.Drawing.Point(4, 25);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystem.Size = new System.Drawing.Size(342, 283);
            this.tabSystem.TabIndex = 1;
            this.tabSystem.Text = "System";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 376);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cmdOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.Text = "Options";
            this.tabControl1.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.grpChangePass.ResumeLayout(false);
            this.grpChangePass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.GroupBox grpChangePass;
        private System.Windows.Forms.TabPage tabSystem;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Button cmdChangePass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtCurrentPass;
    }
}