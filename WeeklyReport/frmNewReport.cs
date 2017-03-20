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
    public partial class frmNewReport : Form
    {
        public frmNewReport()
        {
            InitializeComponent();
        }

        private void frmNewReport_Load(object sender, EventArgs e)
        {
            try
            {
//*********************************************************************************************************************************
                var m = refWeeklyReportMDI.mdi;
                m.mnuFileOpenReport.Enabled = false;

                SqlConnection conn = new SqlConnection(Properties.Settings.Default.SQLConn);

                SqlDataAdapter adapterShift = new SqlDataAdapter();
                DataSet dsShift = new DataSet();
                conn.Open();
                SqlCommand cmdShift = new SqlCommand("SELECT ShiftID, ShiftType FROM Weekly_Report.tblShiftType;", conn);
                adapterShift.SelectCommand = cmdShift;
                adapterShift.Fill(dsShift);
                conn.Close();

                cboShift.DataSource = dsShift.Tables[0];
                cboShift.ValueMember = "ShiftID";
                cboShift.DisplayMember = "ShiftType";

                adapterShift = null;
                dsShift = null;
                cmdShift = null;

//*****************************************************************************************************************************************

                SqlDataAdapter adapterDis = new SqlDataAdapter();
                DataSet dsDis = new DataSet();
                conn.Open();
                SqlCommand cmdDis = new SqlCommand("SELECT DisciplineID, DisciplineDescription FROM Weekly_Report.tblRepDiscipline;", conn);
                adapterDis.SelectCommand = cmdDis;
                adapterDis.Fill(dsDis);
                conn.Close();

                cboDiscipline.DataSource = dsDis.Tables[0];
                cboDiscipline.ValueMember = "DisciplineID";
                cboDiscipline.DisplayMember = "DisciplineDescription";

                adapterDis = null;
                dsDis = null;
                cmdDis = null;

//****************************************************************************************************************************************

                SqlDataAdapter adapterSup = new SqlDataAdapter();
                DataSet dsSup = new DataSet();
                conn.Open();
                SqlCommand cmdSup = new SqlCommand("SELECT EmpID, FullName FROM Weekly_Report.tblEmployees;", conn);
                adapterSup.SelectCommand = cmdSup;
                adapterSup.Fill(dsSup);
                conn.Close();

                cboSupervisor.DataSource = dsSup.Tables[0];
                cboSupervisor.ValueMember = "EmpID";
                cboSupervisor.DisplayMember = "FullName";

                adapterSup = null;
                dsSup = null;
                cmdSup = null;

//*********************************************************************************************************************************

                SqlDataAdapter adapterMan = new SqlDataAdapter();
                DataSet dsMan = new DataSet();
                conn.Open();
                SqlCommand cmdMananger = new SqlCommand("SELECT EmpID, FullName FROM Weekly_Report.tblEmployees;", conn);
                adapterMan.SelectCommand = cmdMananger;
                adapterMan.Fill(dsMan);
                conn.Close();

                cboProjectMan.DataSource = dsMan.Tables[0];
                cboProjectMan.ValueMember = "EmpID";
                cboProjectMan.DisplayMember = "FullName";

                adapterMan = null;
                dsMan = null;
                cmdMananger = null;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCreateReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtProjectNo.Text))
                {
                    MessageBox.Show("A Project Number must be entered.", "Weekly Report.",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    var t = this.txtProjectNo;
                    t.Focus();
                    t.BackColor = Color.Red;
                    t.ForeColor = Color.White;
                    return;
                }

                if (string.IsNullOrEmpty(txtProjectDesc.Text))
                {
                    MessageBox.Show("A Project Description must be entered.", "Weekly Report.",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    var t = this.txtProjectDesc;
                    t.Focus();
                    t.BackColor = Color.Red;
                    t.ForeColor = Color.White;
                    return;
                }

                //Connect to the DB
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.SQLConn);

//*****************************************************************************************************************************************
                //Check if entered report already exists from table tblReportHeader

                SqlCommand cmd = new SqlCommand("SELECT tblProjectInfo.ProjectNumber, tblReportHeader.DisciplineID AS DisciplineID, " +
                                                "tblReportHeader.ShiftID " +
                                                "FROM (Weekly_Report.tblRepDiscipline tblRepDiscipline " +
                                                "INNER JOIN Weekly_Report.tblReportHeader tblReportHeader " +
                                                "ON (tblRepDiscipline.DisciplineID = tblReportHeader.DisciplineID)) " +
                                                "INNER JOIN Weekly_Report.tblProjectInfo tblProjectInfo " +
                                                "ON (tblProjectInfo.ReportID = tblReportHeader.ReportID) " +
                                                "WHERE ([tblProjectInfo].[ProjectNumber] = @ProjectNumber) " +
                                                "AND ([tblReportHeader].[DisciplineID] = @DisciplineID) " +
                                                "AND ([tblReportHeader].[ShiftID] = @ShiftID);", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ProjectNumber", txtProjectNo.Text);
                cmd.Parameters.AddWithValue("@DisciplineID", cboDiscipline.SelectedValue);
                cmd.Parameters.AddWithValue("@ShiftID", cboShift.SelectedValue);
                SqlDataReader reader = cmd.ExecuteReader();

                int countReport = reader.Cast<object>().Count();
                
                conn.Close();

                if (countReport > 0)
                {
                    MessageBox.Show("A report for the project number and discipline entered is already on the system. " +
                                    "Change the information to start a new report", "Weekly Report",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

//*****************************************************************************************************************************************

                //Add information to main report header table tblReportHeader

                cmd = new SqlCommand("INSERT INTO Weekly_Report.tblReportHeader (DisciplineID, DateCreated, ShiftID) " +
                                        "VALUES (@DisciplineID, @DateCreated, @ShiftID);", conn);
                cmd.Parameters.AddWithValue("@DisciplineID", cboDiscipline.SelectedValue);
                cmd.Parameters.AddWithValue("@DateCreated", DateTime.Today);
                cmd.Parameters.AddWithValue("@ShiftID", cboShift.SelectedValue);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

//*****************************************************************************************************************************************
                //Get max ReportID from table tblReportHeader

                cmd = new SqlCommand("SELECT MAX (tblReportHeader.ReportID) FROM Weekly_Report.tblReportHeader tblReportHeader", conn);
                conn.Open();
                SqlDataReader readerMaxRepID = cmd.ExecuteReader();
                readerMaxRepID.Read();
                clsGlobal.currentReportID = readerMaxRepID.GetInt32(0);
                conn.Close();

//*****************************************************************************************************************************************
                //Add information to project information table tblProjectInfo

                cmd = new SqlCommand("INSERT INTO Weekly_Report.tblProjectInfo(ReportID, ProjectNumber, ProjectDescription) " + 
                                        "VALUES (@ReportID, @ProjectNumber, @ProjectDescription);", conn);
                cmd.Parameters.AddWithValue("@ReportID", clsGlobal.currentReportID);
                cmd.Parameters.AddWithValue("@ProjectNumber", txtProjectNo.Text);
                cmd.Parameters.AddWithValue("@ProjectDescription", txtProjectDesc.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

//*****************************************************************************************************************************************

                //Add information to supervisor table tblReportSupervisor

                cmd = new SqlCommand("INSERT INTO Weekly_Report.tblReportSupervisor(EmpID, ReportID) " +
                                        "VALUES (@EmpID, @ReportID);", conn);
                cmd.Parameters.AddWithValue("@ReportID", clsGlobal.currentReportID);
                cmd.Parameters.AddWithValue("@EmpID", cboSupervisor.SelectedValue);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

//*****************************************************************************************************************************************

                //Add information to project manager table tblProjectMan

                cmd = new SqlCommand("INSERT INTO Weekly_Report.tblProjManager(EmpID, ReportID) " +
                                        "VALUES (@EmpID, @ReportID);", conn);
                cmd.Parameters.AddWithValue("@ReportID", clsGlobal.currentReportID);
                cmd.Parameters.AddWithValue("@EmpID", cboProjectMan.SelectedValue);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

//*****************************************************************************************************************************************

                MessageBox.Show("The weekly report has been added to the system", "Weekly Report.",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                clsGlobal.projectNumber = txtProjectNo.Text;

                var m = refWeeklyReportMDI.mdi;
                    m.mdiToolStripProject.Text = "    Project: " + clsGlobal.projectNumber;
                    m.mnuProject.Enabled = true;
                    m.mnuReports.Enabled = true;
                    m.mnuFileCloseReport.Enabled = true;

                //Open the form frmFrontPage as a child to the parent
                frmFrontPage objfrmFrontPage = new frmFrontPage();
                objfrmFrontPage.MdiParent = this.MdiParent;
                objfrmFrontPage.StartPosition = FormStartPosition.CenterScreen;
                objfrmFrontPage.Show();

                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void txtProjectNo_TextChanged(object sender, EventArgs e)
        {
            var t = this.txtProjectNo;
            t.Focus();
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;
        }

        private void txtProjectDesc_TextChanged(object sender, EventArgs e)
        {
            var t = this.txtProjectDesc;
            t.Focus();
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;
        }

        private void frmNewReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            var m = refWeeklyReportMDI.mdi;
            m.mnuFileOpenReport.Enabled = true;
        }

        private void cboShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            var t = this.cboShift;
            t.Focus();
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;
        }
    }
}
