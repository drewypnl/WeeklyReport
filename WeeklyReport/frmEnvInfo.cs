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
    public partial class frmEnvInfo : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.SQLConn);

        public frmEnvInfo()
        {
            InitializeComponent();
        }
        public static int GetWeekNumber(DateTime dtPassed)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(dtpWeatherDate.Text))
            {
                MessageBox.Show("A date must be entered.", "Weekly Report.",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var t = this.dtpWeatherDate;
                t.Focus();
                t.BackColor = Color.Red;
                t.ForeColor = Color.White;
                return;
            }

            if (string.IsNullOrEmpty(cboWeather.Text))
            {
                MessageBox.Show("A type of weather must be selected.", "Weekly Report.",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var t = this.cboWeather;
                t.Focus();
                t.BackColor = Color.Red;
                t.ForeColor = Color.White;
                return;
            }

            if (string.IsNullOrEmpty(txtTemp.Text))
            {
                MessageBox.Show("A temperature must be entered.", "Weekly Report.",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var t = this.txtTemp;
                t.Focus();
                t.BackColor = Color.Red;
                t.ForeColor = Color.White;
                return;
            }

            if (string.IsNullOrEmpty(txtWind.Text))
            {
                MessageBox.Show("A wind speed must be entered.", "Weekly Report.",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                var t = this.txtWind;
                t.Focus();
                t.BackColor = Color.Red;
                t.ForeColor = Color.White;
                return;
            }
            //Check if entered report already exists from table tblReportHeader

            SqlCommand cmdCheckWeather = new SqlCommand("SELECT tblWeather.ReportID, tblWeather.WeatherDate " +
                                                        "FROM Weekly_Report.tblWeather " +
                                                        "WHERE tblWeather.ReportID = " + clsGlobal.currentReportID +
                                                        "AND cast(tblWeather.WeatherDate AS DATE) = '" +  dtpWeatherDate.Value.ToString("yyyy/MM/dd") + "';", conn);
            conn.Open();

            SqlDataReader reader = cmdCheckWeather.ExecuteReader();

            int countWeather = reader.Cast<object>().Count();

            conn.Close();

            if (countWeather > 0)
            {
                MessageBox.Show("Weather information for that date has already been entered. If you wish to change the entered " +
                                "value it must be deleted first. " , "Weekly Report",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            else
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Weekly_Report.tblWeather(WeatherTypeID, ReportID, WeatherDate, " +
                                                "Temperature, Wind ) " +
                                                "VALUES (@WeatherTypeID, @ReportID, @Date, @Temp, @Wind)", conn);
                cmd.Parameters.AddWithValue("@WeatherTypeID", cboWeather.SelectedValue);
                cmd.Parameters.AddWithValue("@ReportID", clsGlobal.currentReportID);
                cmd.Parameters.AddWithValue("@Date", dtpWeatherDate.Value);
                cmd.Parameters.AddWithValue("@Temp", txtTemp.Text);
                cmd.Parameters.AddWithValue("@Wind", txtWind.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                int week = GetWeekNumber(dtpWeatherDate.Value);

                MessageBox.Show("The weather information has been added.", "Weekly Report",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlDataAdapter adWeather = new SqlDataAdapter("SELECT datepart (wk, tblWeather.WeatherDate) AS WeekNumber, " +
                    "tblWeather.WeatherDate AS Date, tblReportHeader.ReportID, datename (dw, tblWeather.WeatherDate) AS Day, " +
                    "tblWeather.Temperature, tblWeather.Wind, tblWeatherType.WeatherType AS Type " +
                    "FROM Weekly_Report.tblWeatherType INNER JOIN Weekly_Report.tblWeather " +
                    "ON tblWeatherType.WeatherTypeID = tblWeather.WeatherTypeID " +
                    "INNER JOIN Weekly_Report.tblReportHeader ON tblReportHeader.ReportID = tblWeather.ReportID " +
                    "WHERE tblReportHeader.ReportID = " + clsGlobal.currentReportID + " " +
                    "AND datepart (wk, tblWeather.WeatherDate) = " + week + " " +
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

        private void frmEnvInfo_Load(object sender, EventArgs e)
        {

            dtpWeatherDate.Value = DateTime.Today;

            SqlDataAdapter adapterWeather = new SqlDataAdapter();
            DataSet dsCBOWeather = new DataSet();
            conn.Open();
            SqlCommand cmdWeather = new SqlCommand("SELECT tblWeatherType.WeatherTypeID, tblWeatherType.WeatherType " +
                                                   "FROM Weekly_Report.tblWeatherType;", conn);
            adapterWeather.SelectCommand = cmdWeather;
            adapterWeather.Fill(dsCBOWeather);
            conn.Close();

            cboWeather.DataSource = dsCBOWeather.Tables[0];
            cboWeather.ValueMember = "WeatherTypeID";
            cboWeather.DisplayMember = "WeatherType";

            adapterWeather = null;
            dsCBOWeather = null;
            cmdWeather = null;

            int week = GetWeekNumber(DateTime.Today);

            SqlDataAdapter adWeather = new SqlDataAdapter("SELECT datepart (wk, tblWeather.WeatherDate) AS WeekNumber, " +
                "tblWeather.WeatherDate AS Date, tblReportHeader.ReportID, datename (dw, tblWeather.WeatherDate) AS Day, " +
                "tblWeather.Temperature, tblWeather.Wind, tblWeatherType.WeatherType AS Type " +
                "FROM Weekly_Report.tblWeatherType INNER JOIN Weekly_Report.tblWeather " +
                "ON tblWeatherType.WeatherTypeID = tblWeather.WeatherTypeID " +
                "INNER JOIN Weekly_Report.tblReportHeader ON tblReportHeader.ReportID = tblWeather.ReportID " +
                "WHERE tblReportHeader.ReportID = " + clsGlobal.currentReportID + " " +
                "AND datepart (wk, tblWeather.WeatherDate) = " + week + " " +
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

        private void dtpWeatherDate_ValueChanged(object sender, EventArgs e)
        {

            int week = GetWeekNumber(dtpWeatherDate.Value);

            SqlDataAdapter adWeather = new SqlDataAdapter("SELECT datepart (wk, tblWeather.WeatherDate) AS WeekNumber, " +
                "tblWeather.WeatherDate AS Date, tblReportHeader.ReportID, datename (dw, tblWeather.WeatherDate) AS Day, " +
                "tblWeather.Temperature, tblWeather.Wind, tblWeatherType.WeatherType AS Type " +
                "FROM Weekly_Report.tblWeatherType INNER JOIN Weekly_Report.tblWeather " +
                "ON tblWeatherType.WeatherTypeID = tblWeather.WeatherTypeID " +
                "INNER JOIN Weekly_Report.tblReportHeader ON tblReportHeader.ReportID = tblWeather.ReportID " +
                "WHERE tblReportHeader.ReportID = " + clsGlobal.currentReportID + " " +
                "AND datepart (wk, tblWeather.WeatherDate) = " + week + " " +
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

        private void txtTemp_Click(object sender, EventArgs e)
        {
            var t = this.txtTemp;
            t.Focus();
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;
            return;
        }

        private void txtWind_Click(object sender, EventArgs e)
        {
            var t = this.txtWind;
            t.Focus();
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;
            return;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
