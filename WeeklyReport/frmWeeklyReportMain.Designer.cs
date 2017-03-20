namespace WeeklyReport
{
    partial class frmWeeklyReportMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWeeklyReportMain));
            this.mnuMDIStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNewReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileCloseReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthAndSafetyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpContents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiStatusLabel = new System.Windows.Forms.StatusStrip();
            this.mdiStatusStripUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mdiToolStripProject = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMDIStrip.SuspendLayout();
            this.mdiStatusLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMDIStrip
            // 
            this.mnuMDIStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuProject,
            this.mnuReports,
            this.mnuTools,
            this.mnuHelp});
            this.mnuMDIStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMDIStrip.Name = "mnuMDIStrip";
            this.mnuMDIStrip.Size = new System.Drawing.Size(953, 24);
            this.mnuMDIStrip.TabIndex = 0;
            this.mnuMDIStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewReport,
            this.mnuFileOpenReport,
            this.mnuFileCloseReport,
            this.toolStripSeparator1,
            this.mnuFileLogin,
            this.mnuFileLogout,
            this.toolStripSeparator2,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNewReport
            // 
            this.mnuFileNewReport.Name = "mnuFileNewReport";
            this.mnuFileNewReport.Size = new System.Drawing.Size(154, 22);
            this.mnuFileNewReport.Text = "New Report";
            this.mnuFileNewReport.Click += new System.EventHandler(this.mnuFileNewReport_Click);
            // 
            // mnuFileOpenReport
            // 
            this.mnuFileOpenReport.Name = "mnuFileOpenReport";
            this.mnuFileOpenReport.Size = new System.Drawing.Size(154, 22);
            this.mnuFileOpenReport.Text = "Open Report";
            this.mnuFileOpenReport.Click += new System.EventHandler(this.mnuFileOpenReport_Click);
            // 
            // mnuFileCloseReport
            // 
            this.mnuFileCloseReport.Name = "mnuFileCloseReport";
            this.mnuFileCloseReport.Size = new System.Drawing.Size(154, 22);
            this.mnuFileCloseReport.Text = "Close Report";
            this.mnuFileCloseReport.Click += new System.EventHandler(this.mnuFileCloseReport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // mnuFileLogin
            // 
            this.mnuFileLogin.Enabled = false;
            this.mnuFileLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFileLogin.Name = "mnuFileLogin";
            this.mnuFileLogin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuFileLogin.Size = new System.Drawing.Size(154, 22);
            this.mnuFileLogin.Text = "&Login";
            this.mnuFileLogin.Click += new System.EventHandler(this.mnuFileLogin_Click);
            // 
            // mnuFileLogout
            // 
            this.mnuFileLogout.Name = "mnuFileLogout";
            this.mnuFileLogout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mnuFileLogout.Size = new System.Drawing.Size(154, 22);
            this.mnuFileLogout.Text = "Lo&gout";
            this.mnuFileLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(154, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuProject
            // 
            this.mnuProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProjectUpdate,
            this.mnuProjectView});
            this.mnuProject.Name = "mnuProject";
            this.mnuProject.Size = new System.Drawing.Size(56, 20);
            this.mnuProject.Text = "P&roject";
            // 
            // mnuProjectUpdate
            // 
            this.mnuProjectUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weatherToolStripMenuItem,
            this.healthAndSafetyToolStripMenuItem,
            this.deliveriesToolStripMenuItem,
            this.siteIssuesToolStripMenuItem});
            this.mnuProjectUpdate.Name = "mnuProjectUpdate";
            this.mnuProjectUpdate.Size = new System.Drawing.Size(191, 22);
            this.mnuProjectUpdate.Text = "&Update Weekly Report";
            // 
            // weatherToolStripMenuItem
            // 
            this.weatherToolStripMenuItem.Name = "weatherToolStripMenuItem";
            this.weatherToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.weatherToolStripMenuItem.Text = "&Weather";
            this.weatherToolStripMenuItem.Click += new System.EventHandler(this.weatherToolStripMenuItem_Click);
            // 
            // healthAndSafetyToolStripMenuItem
            // 
            this.healthAndSafetyToolStripMenuItem.Name = "healthAndSafetyToolStripMenuItem";
            this.healthAndSafetyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.healthAndSafetyToolStripMenuItem.Text = "&Health and Safety";
            this.healthAndSafetyToolStripMenuItem.Click += new System.EventHandler(this.healthAndSafetyToolStripMenuItem_Click);
            // 
            // deliveriesToolStripMenuItem
            // 
            this.deliveriesToolStripMenuItem.Name = "deliveriesToolStripMenuItem";
            this.deliveriesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deliveriesToolStripMenuItem.Text = "&Deliveries";
            // 
            // siteIssuesToolStripMenuItem
            // 
            this.siteIssuesToolStripMenuItem.Name = "siteIssuesToolStripMenuItem";
            this.siteIssuesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.siteIssuesToolStripMenuItem.Text = "&Site Issues";
            // 
            // mnuProjectView
            // 
            this.mnuProjectView.Name = "mnuProjectView";
            this.mnuProjectView.Size = new System.Drawing.Size(191, 22);
            this.mnuProjectView.Text = "V&iew Weekly Report";
            // 
            // mnuReports
            // 
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(59, 20);
            this.mnuReports.Text = "&Reports";
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsOptions});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(48, 20);
            this.mnuTools.Text = "&Tools";
            // 
            // mnuToolsOptions
            // 
            this.mnuToolsOptions.Name = "mnuToolsOptions";
            this.mnuToolsOptions.Size = new System.Drawing.Size(116, 22);
            this.mnuToolsOptions.Text = "&Options";
            this.mnuToolsOptions.Click += new System.EventHandler(this.mnuToolsOptions_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpContents,
            this.toolStripSeparator5,
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpContents
            // 
            this.mnuHelpContents.Name = "mnuHelpContents";
            this.mnuHelpContents.Size = new System.Drawing.Size(122, 22);
            this.mnuHelpContents.Text = "&Contents";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(122, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mdiStatusLabel
            // 
            this.mdiStatusLabel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mdiStatusStripUser,
            this.toolStripStatusLabel1,
            this.mdiToolStripProject});
            this.mdiStatusLabel.Location = new System.Drawing.Point(0, 501);
            this.mdiStatusLabel.Name = "mdiStatusLabel";
            this.mdiStatusLabel.Size = new System.Drawing.Size(953, 22);
            this.mdiStatusLabel.TabIndex = 1;
            // 
            // mdiStatusStripUser
            // 
            this.mdiStatusStripUser.BackColor = System.Drawing.SystemColors.Control;
            this.mdiStatusStripUser.Name = "mdiStatusStripUser";
            this.mdiStatusStripUser.Size = new System.Drawing.Size(33, 17);
            this.mdiStatusStripUser.Text = "User:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // mdiToolStripProject
            // 
            this.mdiToolStripProject.BackColor = System.Drawing.SystemColors.Control;
            this.mdiToolStripProject.Name = "mdiToolStripProject";
            this.mdiToolStripProject.Size = new System.Drawing.Size(47, 17);
            this.mdiToolStripProject.Text = "Project:";
            // 
            // frmWeeklyReportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 523);
            this.Controls.Add(this.mdiStatusLabel);
            this.Controls.Add(this.mnuMDIStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMDIStrip;
            this.Name = "frmWeeklyReportMain";
            this.Text = "Weekly Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmWeeklyReportMain_Load);
            this.Resize += new System.EventHandler(this.frmWeeklyReportMain_Resize);
            this.mnuMDIStrip.ResumeLayout(false);
            this.mnuMDIStrip.PerformLayout();
            this.mdiStatusLabel.ResumeLayout(false);
            this.mdiStatusLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mdiStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripStatusLabel mdiStatusStripUser;
        public System.Windows.Forms.MenuStrip mnuMDIStrip;
        public System.Windows.Forms.ToolStripMenuItem mnuFile;
        public System.Windows.Forms.ToolStripMenuItem mnuTools;
        public System.Windows.Forms.ToolStripMenuItem mnuHelp;
        public System.Windows.Forms.ToolStripMenuItem mnuFileLogin;
        public System.Windows.Forms.ToolStripMenuItem mnuFileLogout;
        public System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        public System.Windows.Forms.ToolStripMenuItem mnuToolsOptions;
        public System.Windows.Forms.ToolStripMenuItem mnuHelpContents;
        public System.Windows.Forms.ToolStripMenuItem mnuReports;
        public System.Windows.Forms.ToolStripMenuItem mnuProject;
        public System.Windows.Forms.ToolStripMenuItem mnuProjectUpdate;
        public System.Windows.Forms.ToolStripMenuItem weatherToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mnuProjectView;
        public System.Windows.Forms.ToolStripMenuItem healthAndSafetyToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem deliveriesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem siteIssuesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        public System.Windows.Forms.ToolStripMenuItem mnuFileNewReport;
        public System.Windows.Forms.ToolStripMenuItem mnuFileOpenReport;
        public System.Windows.Forms.ToolStripStatusLabel mdiToolStripProject;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripMenuItem mnuFileCloseReport;
    }
}

