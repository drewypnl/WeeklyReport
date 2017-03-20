namespace WeeklyReport
{
    partial class frmSafety
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
            this.cmdExit = new System.Windows.Forms.Button();
            this.dtpSafetyDate = new System.Windows.Forms.DateTimePicker();
            this.grpSafetyInspection = new System.Windows.Forms.GroupBox();
            this.cmdAddInsp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkWorkforceEng = new System.Windows.Forms.CheckBox();
            this.chkSiteAudit = new System.Windows.Forms.CheckBox();
            this.chkPOWRA = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSafetyIssue = new System.Windows.Forms.GroupBox();
            this.cmdAddIssue = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtActionTaken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCatagory = new System.Windows.Forms.ComboBox();
            this.grpSafetyInspection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpSafetyIssue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdExit
            // 
            this.cmdExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(867, 341);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(107, 37);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            // 
            // dtpSafetyDate
            // 
            this.dtpSafetyDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSafetyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSafetyDate.Location = new System.Drawing.Point(57, 30);
            this.dtpSafetyDate.Name = "dtpSafetyDate";
            this.dtpSafetyDate.Size = new System.Drawing.Size(107, 22);
            this.dtpSafetyDate.TabIndex = 4;
            this.dtpSafetyDate.Value = new System.DateTime(2014, 6, 2, 0, 0, 0, 0);
            // 
            // grpSafetyInspection
            // 
            this.grpSafetyInspection.Controls.Add(this.cmdAddInsp);
            this.grpSafetyInspection.Controls.Add(this.dataGridView1);
            this.grpSafetyInspection.Controls.Add(this.chkWorkforceEng);
            this.grpSafetyInspection.Controls.Add(this.chkSiteAudit);
            this.grpSafetyInspection.Controls.Add(this.chkPOWRA);
            this.grpSafetyInspection.Controls.Add(this.label1);
            this.grpSafetyInspection.Controls.Add(this.dtpSafetyDate);
            this.grpSafetyInspection.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSafetyInspection.Location = new System.Drawing.Point(13, 13);
            this.grpSafetyInspection.Name = "grpSafetyInspection";
            this.grpSafetyInspection.Size = new System.Drawing.Size(295, 310);
            this.grpSafetyInspection.TabIndex = 5;
            this.grpSafetyInspection.TabStop = false;
            this.grpSafetyInspection.Text = "Safety Inspection";
            // 
            // cmdAddInsp
            // 
            this.cmdAddInsp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddInsp.Location = new System.Drawing.Point(204, 79);
            this.cmdAddInsp.Name = "cmdAddInsp";
            this.cmdAddInsp.Size = new System.Drawing.Size(78, 29);
            this.cmdAddInsp.TabIndex = 6;
            this.cmdAddInsp.Text = "Add";
            this.cmdAddInsp.UseVisualStyleBackColor = true;
            this.cmdAddInsp.Click += new System.EventHandler(this.cmdAddInsp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(263, 159);
            this.dataGridView1.TabIndex = 9;
            // 
            // chkWorkforceEng
            // 
            this.chkWorkforceEng.AutoSize = true;
            this.chkWorkforceEng.Location = new System.Drawing.Point(19, 110);
            this.chkWorkforceEng.Name = "chkWorkforceEng";
            this.chkWorkforceEng.Size = new System.Drawing.Size(163, 20);
            this.chkWorkforceEng.TabIndex = 8;
            this.chkWorkforceEng.Text = "Workforce Engagement";
            this.chkWorkforceEng.UseVisualStyleBackColor = true;
            // 
            // chkSiteAudit
            // 
            this.chkSiteAudit.AutoSize = true;
            this.chkSiteAudit.Location = new System.Drawing.Point(19, 84);
            this.chkSiteAudit.Name = "chkSiteAudit";
            this.chkSiteAudit.Size = new System.Drawing.Size(154, 20);
            this.chkSiteAudit.TabIndex = 7;
            this.chkSiteAudit.Text = "Site Audit \\ Inspection";
            this.chkSiteAudit.UseVisualStyleBackColor = true;
            // 
            // chkPOWRA
            // 
            this.chkPOWRA.AutoSize = true;
            this.chkPOWRA.Location = new System.Drawing.Point(19, 58);
            this.chkPOWRA.Name = "chkPOWRA";
            this.chkPOWRA.Size = new System.Drawing.Size(77, 20);
            this.chkPOWRA.TabIndex = 6;
            this.chkPOWRA.Text = "POWRA";
            this.chkPOWRA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpSafetyIssue
            // 
            this.grpSafetyIssue.Controls.Add(this.cmdAddIssue);
            this.grpSafetyIssue.Controls.Add(this.dataGridView2);
            this.grpSafetyIssue.Controls.Add(this.txtActionTaken);
            this.grpSafetyIssue.Controls.Add(this.label5);
            this.grpSafetyIssue.Controls.Add(this.txtObservation);
            this.grpSafetyIssue.Controls.Add(this.label4);
            this.grpSafetyIssue.Controls.Add(this.label3);
            this.grpSafetyIssue.Controls.Add(this.cboLocation);
            this.grpSafetyIssue.Controls.Add(this.label2);
            this.grpSafetyIssue.Controls.Add(this.cboCatagory);
            this.grpSafetyIssue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSafetyIssue.Location = new System.Drawing.Point(314, 13);
            this.grpSafetyIssue.Name = "grpSafetyIssue";
            this.grpSafetyIssue.Size = new System.Drawing.Size(660, 310);
            this.grpSafetyIssue.TabIndex = 6;
            this.grpSafetyIssue.TabStop = false;
            this.grpSafetyIssue.Text = "Safety Issue";
            // 
            // cmdAddIssue
            // 
            this.cmdAddIssue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddIssue.Location = new System.Drawing.Point(519, 166);
            this.cmdAddIssue.Name = "cmdAddIssue";
            this.cmdAddIssue.Size = new System.Drawing.Size(78, 29);
            this.cmdAddIssue.TabIndex = 10;
            this.cmdAddIssue.Text = "Add";
            this.cmdAddIssue.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 218);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(624, 77);
            this.dataGridView2.TabIndex = 10;
            // 
            // txtActionTaken
            // 
            this.txtActionTaken.Location = new System.Drawing.Point(19, 157);
            this.txtActionTaken.Multiline = true;
            this.txtActionTaken.Name = "txtActionTaken";
            this.txtActionTaken.Size = new System.Drawing.Size(443, 50);
            this.txtActionTaken.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Action Taken";
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(19, 79);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(443, 50);
            this.txtObservation.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Observation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location";
            // 
            // cboLocation
            // 
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Location = new System.Drawing.Point(341, 28);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(121, 24);
            this.cboLocation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Catagory";
            // 
            // cboCatagory
            // 
            this.cboCatagory.FormattingEnabled = true;
            this.cboCatagory.Location = new System.Drawing.Point(97, 28);
            this.cboCatagory.Name = "cboCatagory";
            this.cboCatagory.Size = new System.Drawing.Size(121, 24);
            this.cboCatagory.TabIndex = 0;
            // 
            // frmSafety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 390);
            this.Controls.Add(this.grpSafetyIssue);
            this.Controls.Add(this.grpSafetyInspection);
            this.Controls.Add(this.cmdExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSafety";
            this.Text = "Safety";
            this.Load += new System.EventHandler(this.frmSafety_Load);
            this.grpSafetyInspection.ResumeLayout(false);
            this.grpSafetyInspection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpSafetyIssue.ResumeLayout(false);
            this.grpSafetyIssue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.DateTimePicker dtpSafetyDate;
        private System.Windows.Forms.GroupBox grpSafetyInspection;
        private System.Windows.Forms.Button cmdAddInsp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkWorkforceEng;
        private System.Windows.Forms.CheckBox chkSiteAudit;
        private System.Windows.Forms.CheckBox chkPOWRA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSafetyIssue;
        private System.Windows.Forms.TextBox txtActionTaken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCatagory;
        private System.Windows.Forms.Button cmdAddIssue;
        private System.Windows.Forms.DataGridView dataGridView2;

    }
}