namespace WeeklyReport
{
    partial class frmFrontPage
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
            this.grpReportInfo = new System.Windows.Forms.GroupBox();
            this.cboWeekNum = new System.Windows.Forms.ComboBox();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProjName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpWeather = new System.Windows.Forms.GroupBox();
            this.dgWeather = new System.Windows.Forms.DataGridView();
            this.grpReportInfo.SuspendLayout();
            this.grpWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // grpReportInfo
            // 
            this.grpReportInfo.Controls.Add(this.cboWeekNum);
            this.grpReportInfo.Controls.Add(this.txtShift);
            this.grpReportInfo.Controls.Add(this.label5);
            this.grpReportInfo.Controls.Add(this.label6);
            this.grpReportInfo.Controls.Add(this.txtName);
            this.grpReportInfo.Controls.Add(this.label4);
            this.grpReportInfo.Controls.Add(this.txtProjName);
            this.grpReportInfo.Controls.Add(this.label3);
            this.grpReportInfo.Controls.Add(this.txtProjNumber);
            this.grpReportInfo.Controls.Add(this.label2);
            this.grpReportInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReportInfo.Location = new System.Drawing.Point(22, 82);
            this.grpReportInfo.Name = "grpReportInfo";
            this.grpReportInfo.Size = new System.Drawing.Size(393, 143);
            this.grpReportInfo.TabIndex = 0;
            this.grpReportInfo.TabStop = false;
            this.grpReportInfo.Text = "Report Information";
            // 
            // cboWeekNum
            // 
            this.cboWeekNum.FormattingEnabled = true;
            this.cboWeekNum.Location = new System.Drawing.Point(316, 29);
            this.cboWeekNum.Name = "cboWeekNum";
            this.cboWeekNum.Size = new System.Drawing.Size(57, 24);
            this.cboWeekNum.TabIndex = 12;
            this.cboWeekNum.SelectedIndexChanged += new System.EventHandler(this.cboWeekNum_SelectedIndexChanged);
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(315, 66);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(58, 22);
            this.txtShift.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Shift";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Week No";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // txtProjName
            // 
            this.txtProjName.Location = new System.Drawing.Point(120, 66);
            this.txtProjName.Name = "txtProjName";
            this.txtProjName.Size = new System.Drawing.Size(100, 22);
            this.txtProjName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Name";
            // 
            // txtProjNumber
            // 
            this.txtProjNumber.Location = new System.Drawing.Point(120, 26);
            this.txtProjNumber.Name = "txtProjNumber";
            this.txtProjNumber.Size = new System.Drawing.Size(100, 22);
            this.txtProjNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project Number";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Site Supervisor Weekly Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpWeather
            // 
            this.grpWeather.Controls.Add(this.dgWeather);
            this.grpWeather.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWeather.Location = new System.Drawing.Point(22, 245);
            this.grpWeather.Name = "grpWeather";
            this.grpWeather.Size = new System.Drawing.Size(449, 205);
            this.grpWeather.TabIndex = 2;
            this.grpWeather.TabStop = false;
            this.grpWeather.Text = "Weather";
            // 
            // dgWeather
            // 
            this.dgWeather.AllowUserToAddRows = false;
            this.dgWeather.AllowUserToDeleteRows = false;
            this.dgWeather.AllowUserToResizeRows = false;
            this.dgWeather.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgWeather.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWeather.Location = new System.Drawing.Point(19, 21);
            this.dgWeather.MultiSelect = false;
            this.dgWeather.Name = "dgWeather";
            this.dgWeather.ReadOnly = true;
            this.dgWeather.Size = new System.Drawing.Size(412, 167);
            this.dgWeather.TabIndex = 0;
            // 
            // frmFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1234, 495);
            this.Controls.Add(this.grpWeather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpReportInfo);
            this.Name = "frmFrontPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFrontPage_FormClosed);
            this.Load += new System.EventHandler(this.frmFrontPage_Load);
            this.grpReportInfo.ResumeLayout(false);
            this.grpReportInfo.PerformLayout();
            this.grpWeather.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReportInfo;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProjName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProjNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboWeekNum;
        private System.Windows.Forms.GroupBox grpWeather;
        public System.Windows.Forms.DataGridView dgWeather;


    }
}