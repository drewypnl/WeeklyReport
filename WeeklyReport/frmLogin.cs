using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace WeeklyReport
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public string CalcMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Check for null or empty Username textbox
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("A Username must be entered.", "Weekly Report.",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    var t = this.txtUsername;
                    t.Focus();
                    t.BackColor = Color.Red;
                    t.ForeColor = Color.White;
                    return;
                }
//***************************************************************************************************************
                    
                else
                {
                    //Load the public variable with the textbox value
                    clsGlobal.userName = txtUsername.Text;
                }

                //Check for null or empty Password textbox
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("A Password must be entered.", "Weekly Report.",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    var t = this.txtPassword;
                    t.Focus();
                    t.BackColor = Color.Red;
                    t.ForeColor = Color.White;

                    return;
                }
//****************************************************************************************************************

                //Connect to the DB
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.SQLConn);

                //Run SQL command to count the number of usernames on the database that match the enter value
                SqlCommand cmd = new SqlCommand("select count(*) from Weekly_Report.tblEmployees where UserName='" +
                                        clsGlobal.userName + "';", conn);

                //Open the DB connection
                conn.Open();

                //Count quanity of users based on username
                Int32 countUser = Convert.ToInt32(cmd.ExecuteScalar());

                //Close the connection
                conn.Close();

                //Count the retrieved results. If the count is more than 1 confirm the user has logged on 
                if (countUser==0)
                {
                    MessageBox.Show("The username entered isn't on the system. For access contact the system administrator", "Weekly Report",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    var t = this.txtUsername;
                    t.Focus();
                    t.BackColor = Color.Red;
                    t.ForeColor = Color.White;

                    return;
                }

//*******************************************************************************************************************

                cmd = new SqlCommand("SELECT COUNT(*) FROM Weekly_Report.tblEmployees " +
                              "WHERE ChangePass = 1 AND UserName ='" + clsGlobal.userName + "';", conn);
                //Open the DB connection
                conn.Open();

                //Add the count of the results to the variable count
                Int32 countPass = Convert.ToInt32(cmd.ExecuteScalar());

                //Close the connection
                conn.Close();

                //Count the retrieved results. If the count is more than 1 confirm the user has logged on 
                if (countPass > 0)
                {
                    MessageBox.Show("This is the first time you have logged on to the system. You must change your password to continue.", "Change Password.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Open form change pass to allow user to change thir password
                    frmChangePass objfrmChangePass = new frmChangePass();
                    objfrmChangePass.MdiParent = frmWeeklyReportMain.ActiveForm;
                    objfrmChangePass.StartPosition = FormStartPosition.CenterScreen;
                    objfrmChangePass.Show();

                    //Close the form
                    this.Close();
                    return;
                }

//**********************************************************************************************************************

                //Check password MD5
                string DBpassMD5;
                string EnteredPassMD5;
                
                //Run SQL command to retreive the passwords MD5 from the DB
                cmd = new SqlCommand( "select passwordMD5 from Weekly_Report.tblEmployees where username='" +
                                        clsGlobal.userName + "';", conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                
                //Fill variables with the DB and entered MD5 values
                DBpassMD5 = reader.GetString(0);
                EnteredPassMD5 = CalcMD5Hash(txtPassword.Text);
                
                //Compare the MD5 values

                if(String.Equals(DBpassMD5, EnteredPassMD5, StringComparison.Ordinal)==true)   
                {

                    var m = refWeeklyReportMDI.mdi;
                    m.mdiStatusStripUser.Text = "User: " + clsGlobal.userName;
                    m.mnuFileNewReport.Enabled = true;
                    m.mnuFileOpenReport.Enabled = true;
                    m.mnuFileCloseReport.Enabled = false;
                    m.mnuFileLogin.Enabled = false;
                    m.mnuFileLogout.Enabled = true;
                    m.mnuProject.Enabled = false;
                    m.mnuReports.Enabled = false;
                    m.mnuTools.Enabled = true;

                    this.Close();

                }
                else
                {
                    MessageBox.Show("The entered password is incorrect.", "Weekly Report", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            var t = this.txtUsername;
            t.Focus();
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            var t = this.txtPassword;
            t.Focus();
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
