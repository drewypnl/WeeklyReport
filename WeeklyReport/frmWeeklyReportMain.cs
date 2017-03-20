using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeklyReport
{
    public partial class frmWeeklyReportMain : Form
    {
        public frmWeeklyReportMain()
        {
            InitializeComponent();

            frmSplash splash = new frmSplash();
            splash.Show();
        }

        private void frmWeeklyReportMain_Load(object sender, EventArgs e)
        {
            try
            {
                //Set the variables on form load

                refWeeklyReportMDI.mdi = this;

                var m = refWeeklyReportMDI.mdi;
                m.mdiStatusStripUser.Text = "User: ";
                m.mdiToolStripProject.Text = "    Project: ";
                m.mnuFileOpenReport.Enabled = false;
                m.mnuFileNewReport.Enabled = false;
                m.mnuFileCloseReport.Enabled = false;
                m.mnuFileLogin.Enabled = true;
                m.mnuFileLogout.Enabled = false;
                m.mnuProject.Enabled = false;
                m.mnuReports.Enabled = false;
                m.mnuTools.Enabled = false;

                //Open the form frmLogin as a child to the parent
                frmLogin objfrmLogin = new frmLogin();
                objfrmLogin.MdiParent = this;
                objfrmLogin.StartPosition = FormStartPosition.CenterScreen;
                objfrmLogin.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("You are about to logout, are you sure?", "Weekly Report",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
                {
                    //Close all open forms
                    for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    {
                        if (Application.OpenForms[i].Name != "frmWeeklyReportMain")
                            Application.OpenForms[i].Close();
                    }

                    //Open the form frmLogin as a child to the parent
                    frmLogin objfrmLogin = new frmLogin();
                    objfrmLogin.MdiParent = this;
                    objfrmLogin.StartPosition = FormStartPosition.CenterScreen;
                    objfrmLogin.Show();

                    var m = refWeeklyReportMDI.mdi;
                    m.mdiStatusStripUser.Text = "User: ";
                    m.mdiToolStripProject.Text = "    Project: ";
                    m.mnuFileOpenReport.Enabled = false;
                    m.mnuFileNewReport.Enabled = false;
                    m.mnuFileCloseReport.Enabled = false;
                    m.mnuFileLogin.Enabled = true;
                    m.mnuFileLogout.Enabled = false;
                    m.mnuProject.Enabled = false;
                    m.mnuReports.Enabled = false;
                    m.mnuTools.Enabled = false;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuFileLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<frmLogin>().Count() == 0)
                {
                    //Set the variables on form load
                    refWeeklyReportMDI.mdi = this;

                    var m = refWeeklyReportMDI.mdi;
                    m.mdiStatusStripUser.Text = "User: ";
                    m.mdiToolStripProject.Text = "    Project: ";
                    m.mnuFileOpenReport.Enabled = false;
                    m.mnuFileNewReport.Enabled = false;
                    m.mnuFileCloseReport.Enabled = false;
                    m.mnuFileLogin.Enabled = true;
                    m.mnuFileLogout.Enabled = false;
                    m.mnuProject.Enabled = false;
                    m.mnuReports.Enabled = false;
                    m.mnuTools.Enabled = false;

                    //Open the form frmLogin as a child to the parent
                    frmLogin objfrmLogin = new frmLogin();
                    objfrmLogin.MdiParent = this;
                    objfrmLogin.StartPosition = FormStartPosition.CenterScreen;
                    objfrmLogin.Show();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<frmAbout>().Count() == 0)
                {
                    //Open the form frmAbout as a child to the parent
                    frmAbout objfrmAbout = new frmAbout();
                    objfrmAbout.MdiParent = this;
                    objfrmAbout.StartPosition = FormStartPosition.CenterScreen;
                    objfrmAbout.Show();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmWeeklyReportMain_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void mnuToolsOptions_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<frmOptions>().Count() == 0)
                {
                    //Open the form frmAbout as a child to the parent
                    frmOptions objfrmOptions = new frmOptions();
                    objfrmOptions.MdiParent = this;
                    objfrmOptions.StartPosition = FormStartPosition.CenterScreen;
                    objfrmOptions.Show();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuFileNewReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<frmNewReport>().Count() == 0)
                {
                    if (clsGlobal.currentReportID == 0)
                    {
                        //Open the form frmNewReport as a child to the parent
                        frmNewReport objfrmNewReport = new frmNewReport();
                        objfrmNewReport.MdiParent = this;
                        objfrmNewReport.StartPosition = FormStartPosition.CenterScreen;
                        objfrmNewReport.Show();
                    }
                    else
                    {
                        DialogResult newProj = MessageBox.Show("You already have a report open. Do you want to close the current report and open a new one?",
                                                            "Weekly Report.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (newProj == DialogResult.Yes)
                        {
                            //Open the form frmNewReport as a child to the parent
                            frmNewReport objfrmNewReport = new frmNewReport();
                            objfrmNewReport.MdiParent = this;
                            objfrmNewReport.StartPosition = FormStartPosition.CenterScreen;
                            objfrmNewReport.Show();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuFileCloseReport_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult closeProj = MessageBox.Show("You are about to close the weekly report for project " + clsGlobal.projectNumber + ", are you sure?",
                                                        "Weekly Report.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (closeProj == DialogResult.Yes)
                {
                    for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    {
                        if (Application.OpenForms[i].Name != "frmWeeklyReportMain")
                            Application.OpenForms[i].Close();
                    }

                    clsGlobal.currentReportID = 0;
                    var m = refWeeklyReportMDI.mdi;
                        m.mdiToolStripProject.Text = "    Project: ";
                        m.mnuProject.Enabled = false;
                        m.mnuReports.Enabled = false;
                        m.mnuFileCloseReport.Enabled = false;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuFileOpenReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<frmOpenReport>().Count() == 0)
                {
                    if (clsGlobal.currentReportID == 0)
                    {
                        //Open the form frmOpenReport as a child to the parent
                        frmOpenReport objfrmOpenReport = new frmOpenReport();
                        objfrmOpenReport.MdiParent = this;
                        objfrmOpenReport.StartPosition = FormStartPosition.CenterScreen;
                        objfrmOpenReport.Show();
                    }
                    else
                    {
                        DialogResult openProj = MessageBox.Show("You already have a report open. Do you want to close the current report and open a new one?",
                                                            "Weekly Report.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (openProj == DialogResult.Yes)
                        {
                            //Open the form frmOpenReport as a child to the parent
                            frmOpenReport objfrmOpenReport = new frmOpenReport();
                            objfrmOpenReport.MdiParent = this;
                            objfrmOpenReport.StartPosition = FormStartPosition.CenterScreen;
                            objfrmOpenReport.Show();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void weatherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<frmOpenReport>().Count() == 0)
                {
                    //Open the form frmEnvInfo as a child to the parent
                    frmEnvInfo objfrmEnvInfo = new frmEnvInfo();
                    objfrmEnvInfo.MdiParent = this;
                    objfrmEnvInfo.StartPosition = FormStartPosition.CenterScreen;
                    objfrmEnvInfo.Show();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void healthAndSafetyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.OfType<frmOpenReport>().Count() == 0)
                {
                    //Open the form frmEnvInfo as a child to the parent
                    frmSafety objfrmSafety = new frmSafety();
                    objfrmSafety.MdiParent = this;
                    objfrmSafety.StartPosition = FormStartPosition.CenterScreen;
                    objfrmSafety.Show();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
