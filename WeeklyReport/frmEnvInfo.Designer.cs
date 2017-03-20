namespace WeeklyReport
{
    partial class frmEnvInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.cboWeather = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpWeatherDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCurrentWeather = new System.Windows.Forms.GroupBox();
            this.dgWeather = new System.Windows.Forms.DataGridView();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.cboCurrentWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdDelete);
            this.groupBox1.Controls.Add(this.cmdAdd);
            this.groupBox1.Controls.Add(this.txtWind);
            this.groupBox1.Controls.Add(this.txtTemp);
            this.groupBox1.Controls.Add(this.cboWeather);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpWeatherDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Weather";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(321, 27);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 29);
            this.cmdAdd.TabIndex = 10;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtWind
            // 
            this.txtWind.Location = new System.Drawing.Point(251, 69);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(50, 22);
            this.txtWind.TabIndex = 9;
            this.txtWind.Click += new System.EventHandler(this.txtWind_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(251, 29);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(50, 22);
            this.txtTemp.TabIndex = 8;
            this.txtTemp.Click += new System.EventHandler(this.txtTemp_Click);
            // 
            // cboWeather
            // 
            this.cboWeather.FormattingEnabled = true;
            this.cboWeather.Location = new System.Drawing.Point(71, 67);
            this.cboWeather.Name = "cboWeather";
            this.cboWeather.Size = new System.Drawing.Size(107, 24);
            this.cboWeather.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wind";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weather";
            // 
            // dtpWeatherDate
            // 
            this.dtpWeatherDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeatherDate.Location = new System.Drawing.Point(71, 30);
            this.dtpWeatherDate.Name = "dtpWeatherDate";
            this.dtpWeatherDate.Size = new System.Drawing.Size(107, 22);
            this.dtpWeatherDate.TabIndex = 1;
            this.dtpWeatherDate.Value = new System.DateTime(2014, 5, 31, 10, 53, 23, 0);
            this.dtpWeatherDate.ValueChanged += new System.EventHandler(this.dtpWeatherDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboCurrentWeather
            // 
            this.cboCurrentWeather.Controls.Add(this.dgWeather);
            this.cboCurrentWeather.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCurrentWeather.Location = new System.Drawing.Point(13, 146);
            this.cboCurrentWeather.Name = "cboCurrentWeather";
            this.cboCurrentWeather.Size = new System.Drawing.Size(455, 183);
            this.cboCurrentWeather.TabIndex = 1;
            this.cboCurrentWeather.TabStop = false;
            this.cboCurrentWeather.Text = "Report Weather";
            // 
            // dgWeather
            // 
            this.dgWeather.AllowUserToAddRows = false;
            this.dgWeather.AllowUserToDeleteRows = false;
            this.dgWeather.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgWeather.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWeather.Location = new System.Drawing.Point(10, 21);
            this.dgWeather.MultiSelect = false;
            this.dgWeather.Name = "dgWeather";
            this.dgWeather.ReadOnly = true;
            this.dgWeather.Size = new System.Drawing.Size(426, 150);
            this.dgWeather.TabIndex = 1;
            // 
            // cmdExit
            // 
            this.cmdExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(361, 345);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(107, 37);
            this.cmdExit.TabIndex = 2;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(321, 66);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 29);
            this.cmdDelete.TabIndex = 11;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // frmEnvInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 392);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cboCurrentWeather);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnvInfo";
            this.Text = "Enviromental Information";
            this.Load += new System.EventHandler(this.frmEnvInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cboCurrentWeather.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgWeather)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboWeather;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpWeatherDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.GroupBox cboCurrentWeather;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.DataGridView dgWeather;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdDelete;
    }
}