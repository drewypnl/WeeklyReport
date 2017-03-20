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
using System.Globalization;

namespace WeeklyReport
{
    public partial class frmFrontPage : Form
    {

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.SQLConn);

        public frmFrontPage()
        {
            InitializeComponent();
        }

        public static int GetWeekNumber(DateTime dtPassed)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        private void frmFrontPage_Load(object sender, EventArgs e)
        {

            this.Text = "Project " + clsGlobal.projectNumber;

            conn.Open();

            SqlCommand cmdRepHead = new SqlCommand("SELECT tblProjectInfo.ProjectNumber, tblProjectInfo.ProjectDescription, " +
                                                "tblEmployees.FullName, tblShiftType.ShiftType " +
                                                "FROM Weekly_Report.tblReportHeader " +
                                                "INNER JOIN Weekly_Report.tblProjectInfo " +
                                                "ON tblReportHeader.ReportID = tblProjectInfo.ReportID " +
                                                "INNER JOIN Weekly_Report.tblReportSupervisor " +
                                                "ON tblReportSupervisor.ReportID = tblReportHeader.ReportID " +
                                                "INNER JOIN Weekly_Report.tblEmployees " +
                                                "ON tblReportSupervisor.EmpID = tblEmployees.EmpID " +
                                                "INNER JOIN Weekly_Report.tblShiftType " +
                                                "ON tblReportHeader.ShiftID = tblShiftType.ShiftID " +
                                                "WHERE tblReportHeader.ReportID = " + clsGlobal.currentReportID + ";", conn);

            SqlDataReader drRepHead = cmdRepHead.ExecuteReader();

            while (drRepHead.Read())
            {
                
                txtProjNumber.Text = drRepHead["ProjectNumber"].ToString();
                txtProjName.Text = drRepHead["ProjectDescription"].ToString();
                txtName.Text = drRepHead["FullName"].ToString();
                txtShift.Text = drRepHead["ShiftType"].ToString();

            }

            conn.Close();

            for (int i = 1; i < 54; i++)
            {
                cboWeekNum.Items.Add(i);
            }
        }

        private void frmFrontPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            var m = refWeeklyReportMDI.mdi;
            m.mdiToolStripProject.Text = "    Project: ";
            m.mnuFileOpenReport.Enabled = true;
            m.mnuFileNewReport.Enabled = true;
            m.mnuFileCloseReport.Enabled = false;
            m.mnuFileLogin.Enabled = false;
            m.mnuFileLogout.Enabled = true;
            m.mnuProject.Enabled = false;
            m.mnuReports.Enabled = false;
            m.mnuTools.Enabled = false;

            clsGlobal.currentReportID = 0;

        }

        private void cboWeekNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsGlobal.weekNumber = cboWeekNum.SelectedItem.ToString();

            SqlDataAdapter adWeather = new SqlDataAdapter("SELECT datepart (wk, tblWeather.WeatherDate) AS WeekNumber, " +
                "tblWeather.WeatherDate AS Date, tblReportHeader.ReportID, datename (dw, tblWeather.WeatherDate) AS Day, " +
                "tblWeather.Temperature as Temp, tblWeather.Wind, tblWeatherType.WeatherType AS Type " +
                "FROM Weekly_Report.tblWeatherType INNER JOIN Weekly_Report.tblWeather " +
                "ON tblWeatherType.WeatherTypeID = tblWeather.WeatherTypeID " +
                "INNER JOIN Weekly_Report.tblReportHeader ON tblReportHeader.ReportID = tblWeather.ReportID " +
                "WHERE tblReportHeader.ReportID = " + clsGlobal.currentReportID + " " +
                "AND datepart (wk, tblWeather.WeatherDate) = " + clsGlobal.weekNumber + " " +
                "ORDER BY tblWeather.WeatherDate;", conn);

            DataTable dtWeather = new DataTable();
            DataSet dsWeather = new DataSet();
            conn.Open();
            adWeather.Fill(dtWeather);
            dsWeather.Tables.Add(dtWeather);
            conn.Close();
            dgWeather.DataSource = dsWeather.Tables[0];

            dgWeather.Columns[0].Visible = false;
            dgWeather.Columns[2].Visible = false;
        }
    }
}
