namespace WeeklyReport
{
    partial class frmNewReport
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
            this.txtProjectNo = new System.Windows.Forms.TextBox();
            this.txtProjectDesc = new System.Windows.Forms.TextBox();
            this.cboDiscipline = new System.Windows.Forms.ComboBox();
            this.cboSupervisor = new System.Windows.Forms.ComboBox();
            this.cboProjectMan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdCreateReport = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboShift = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complete the information below to start a new report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProjectNo
            // 
            this.txtProjectNo.Location = new System.Drawing.Point(211, 51);
            this.txtProjectNo.Name = "txtProjectNo";
            this.txtProjectNo.Size = new System.Drawing.Size(100, 20);
            this.txtProjectNo.TabIndex = 1;
            this.txtProjectNo.TextChanged += new System.EventHandler(this.txtProjectNo_TextChanged);
            // 
            // txtProjectDesc
            // 
            this.txtProjectDesc.Location = new System.Drawing.Point(211, 89);
            this.txtProjectDesc.Name = "txtProjectDesc";
            this.txtProjectDesc.Size = new System.Drawing.Size(100, 20);
            this.txtProjectDesc.TabIndex = 2;
            this.txtProjectDesc.TextChanged += new System.EventHandler(this.txtProjectDesc_TextChanged);
            // 
            // cboDiscipline
            // 
            this.cboDiscipline.FormattingEnabled = true;
            this.cboDiscipline.Location = new System.Drawing.Point(190, 166);
            this.cboDiscipline.Name = "cboDiscipline";
            this.cboDiscipline.Size = new System.Drawing.Size(121, 21);
            this.cboDiscipline.TabIndex = 3;
            // 
            // cboSupervisor
            // 
            this.cboSupervisor.FormattingEnabled = true;
            this.cboSupervisor.Location = new System.Drawing.Point(190, 205);
            this.cboSupervisor.Name = "cboSupervisor";
            this.cboSupervisor.Size = new System.Drawing.Size(121, 21);
            this.cboSupervisor.TabIndex = 4;
            // 
            // cboProjectMan
            // 
            this.cboProjectMan.FormattingEnabled = true;
            this.cboProjectMan.Location = new System.Drawing.Point(190, 244);
            this.cboProjectMan.Name = "cboProjectMan";
            this.cboProjectMan.Size = new System.Drawing.Size(121, 21);
            this.cboProjectMan.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Project Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Discipline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Supervisor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Project Manager";
            // 
            // cmdCreateReport
            // 
            this.cmdCreateReport.Location = new System.Drawing.Point(15, 293);
            this.cmdCreateReport.Name = "cmdCreateReport";
            this.cmdCreateReport.Size = new System.Drawing.Size(100, 36);
            this.cmdCreateReport.TabIndex = 11;
            this.cmdCreateReport.Text = "Create";
            this.cmdCreateReport.UseVisualStyleBackColor = true;
            this.cmdCreateReport.Click += new System.EventHandler(this.cmdCreateReport_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(232, 293);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 36);
            this.cmdCancel.TabIndex = 12;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Shift";
            // 
            // cboShift
            // 
            this.cboShift.FormattingEnabled = true;
            this.cboShift.Location = new System.Drawing.Point(211, 127);
            this.cboShift.Name = "cboShift";
            this.cboShift.Size = new System.Drawing.Size(100, 21);
            this.cboShift.TabIndex = 15;
            this.cboShift.SelectedIndexChanged += new System.EventHandler(this.cboShift_SelectedIndexChanged);
            // 
            // frmNewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 339);
            this.Controls.Add(this.cboShift);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdCreateReport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboProjectMan);
            this.Controls.Add(this.cboSupervisor);
            this.Controls.Add(this.cboDiscipline);
            this.Controls.Add(this.txtProjectDesc);
            this.Controls.Add(this.txtProjectNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewReport";
            this.Text = "New Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewReport_FormClosing);
            this.Load += new System.EventHandler(this.frmNewReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjectNo;
        private System.Windows.Forms.TextBox txtProjectDesc;
        private System.Windows.Forms.ComboBox cboDiscipline;
        private System.Windows.Forms.ComboBox cboSupervisor;
        private System.Windows.Forms.ComboBox cboProjectMan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdCreateReport;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboShift;
    }
}