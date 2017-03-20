using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WeeklyReport
{
    public partial class frmOpenReport : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.SQLConn);

        public frmOpenReport()
        {
            InitializeComponent();
        }

        private void frmOpenReport_Load(object sender, EventArgs e)
        {
            try
            {
//*****************************************************************************************************************************************

                var m = refWeeklyReportMDI.mdi;
                    m.mnuFileNewReport.Enabled = false;

                lstSavedReports.Items.Clear();
                lstSavedReports.FullRowSelect = true;
                lstSavedReports.GridLines = true;

                conn.Open();

                SqlCommand cmdProj = new SqlCommand("SELECT tblReportHeader.ReportID, tblProjectInfo.ProjectNumber, " +
                                        "tblProjectInfo.ProjectDescription, tblRepDiscipline.DisciplineDescription, " +
                                        "tblShiftType.ShiftType " +
                                        "FROM ((Weekly_Report.tblProjectInfo tblProjectInfo " +
                                        "INNER JOIN Weekly_Report.tblReportHeader tblReportHeader " +
                                        "ON (tblProjectInfo.ReportID = tblReportHeader.ReportID)) " +
                                        "INNER JOIN Weekly_Report.tblRepDiscipline tblRepDiscipline "+
                                        "ON (tblRepDiscipline.DisciplineID = tblReportHeader.DisciplineID)) " +
                                        "INNER JOIN Weekly_Report.tblShiftType tblShiftType " +
                                        "ON (tblShiftType.ShiftID = tblReportHeader.ShiftID);", conn);

                SqlDataReader drProj = cmdProj.ExecuteReader();
             
                while (drProj.Read())
                {
                    ListViewItem item = new ListViewItem(drProj["ReportID"].ToString());
                    item.SubItems.Add(drProj["ProjectNumber"].ToString());
                    item.SubItems.Add(drProj["ProjectDescription"].ToString());
                    item.SubItems.Add(drProj["DisciplineDescription"].ToString());
                    item.SubItems.Add(drProj["ShiftType"].ToString());

                    lstSavedReports.Items.Add(item);
                    
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            clsGlobal.currentReportID = 0;
            this.Close();
        }

        private void lstSavedReports_Click(object sender, EventArgs e)
        {
            clsGlobal.currentReportID = Convert.ToInt32(lstSavedReports.SelectedItems[0].SubItems[0].Text);
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (clsGlobal.currentReportID==0)
                {
                    MessageBox.Show("You must select a report to open.", "Weekly Report.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    
//*****************************************************************************************************************************************
                    //Get max ReportID from table tblReportHeader

                    SqlCommand cmdReportNo = new SqlCommand("SELECT ProjectNumber FROM Weekly_Report.tblProjectInfo WHERE ReportID = " + 
                                                                clsGlobal.currentReportID + ";", conn);
                    conn.Open();
                    SqlDataReader readerReportNo = cmdReportNo.ExecuteReader();
                    readerReportNo.Read();
                    clsGlobal.projectNumber = readerReportNo.GetString(0);
                    conn.Close();

                    var m = refWeeklyReportMDI.mdi;
                        m.mdiToolStripProject.Text = "    Project: " + clsGlobal.projectNumber;
                        m.mnuProject.Enabled = true;
                        m.mnuReports.Enabled = true;
                        m.mnuFileCloseReport.Enabled = true;
                        m.mnuFileOpenReport.Enabled = false;

                    //Open the form frmFrontPage as a child to the parent
                    frmFrontPage objfrmFrontPage = new frmFrontPage();
                    objfrmFrontPage.MdiParent = this.MdiParent;
                    objfrmFrontPage.StartPosition = FormStartPosition.CenterScreen;
                    objfrmFrontPage.Show();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmOpenReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            var m = refWeeklyReportMDI.mdi;
            m.mnuFileNewReport.Enabled = true;
        }

        private void lstSavedReports_DoubleClick(object sender, EventArgs e)
        {
            cmdOK.PerformClick();
        }
    }
}
