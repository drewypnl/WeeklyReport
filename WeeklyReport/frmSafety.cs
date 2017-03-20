using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WeeklyReport
{
    public partial class frmSafety : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.SQLConn);

        public frmSafety()
        {
            InitializeComponent();
        }

        private void cmdAddInsp_Click(object sender, EventArgs e)
        {
            try
            {
                if(chkPOWRA.Checked == false && chkSiteAudit.Checked == false && chkWorkforceEng.Checked == false)
                {
                    MessageBox.Show("You must select a tick box to add a line.","Weekly_Report",MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    //*****************************************************************************************************************************************

                    //Add information to main report header table tblReportHeader

                    SqlCommand cmd = new SqlCommand("INSERT INTO Weekly_Report.tblSafetyInspTick(ReportID, POWRA, SiteAudit, " +
                                          "WorkEngage) VALUES (@ReportID, @POWRATick, @SiteAuditTick, @WorkEngageTick);", conn);
                    cmd.Parameters.AddWithValue("@ReportID", clsGlobal.currentReportID);
                    cmd.Parameters.AddWithValue("@POWRATick", Convert.ToBoolean(chkPOWRA.Checked));
                    cmd.Parameters.AddWithValue("@SiteAuditTick", Convert.ToBoolean(chkSiteAudit.Checked));
                    cmd.Parameters.AddWithValue("@WorkEngageTick", Convert.ToBoolean(chkWorkforceEng.Checked));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmSafety_Load(object sender, EventArgs e)
        {
            dtpSafetyDate.Value = DateTime.Today;
        }
    }
}
