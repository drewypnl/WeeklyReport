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
using System.Security.Cryptography;

namespace WeeklyReport
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();

            txtUsername.Text = clsGlobal.userName;
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

        private void cmdChangePass_Click(object sender, EventArgs e)
        {
        try
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text))
            {
                MessageBox.Show("The existing password must be entered.", "Weekly Report.", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                var t = this.txtCurrentPassword;
                t.Focus();
                t.BackColor = Color.Red;
                t.ForeColor = Color.White;
                return;
            }

            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                MessageBox.Show("A new password must be entered.", "Weekly Report.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                var t = this.txtNewPassword;
                t.Focus();
                t.BackColor = Color.Red;
                t.ForeColor = Color.White;
                return;
            }

            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("A password conirmation must be entered.", "Weekly Report.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                var t = this.txtConfirmPassword;
                t.Focus();
                t.BackColor = Color.Red;
                t.ForeColor = Color.White;
                return;
            }

            if (string.Compare(txtNewPassword.Text, txtConfirmPassword.Text) > 0)
            {
                MessageBox.Show("The new password and confirmation must match.", "Check Password.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Open a connection to the database
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.SQLConn);
  
            //Run SQL command to retreive the passwords MD5 from the DB
            SqlCommand cmd = new SqlCommand( "select passwordMD5 from Weekly_Report.tblEmployees where username='" +
                                    clsGlobal.userName + "';", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            //Fill variables with the DB and entered MD5 values
            string DBpassMD5 = reader.GetString(0);
            string EnteredPassMD5 = CalcMD5Hash(txtCurrentPassword.Text);

            conn.Close();

            //Compare the MD5 values
            if (String.Equals(DBpassMD5, EnteredPassMD5, StringComparison.Ordinal) == false)  
            {
                MessageBox.Show("The existing password is incorrect.", "Weekly Report",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            //Build an OleDbCommand based on the SELECT query
            cmd = new SqlCommand("UPDATE Weekly_Report.tblEmployees SET PasswordMD5 = @NewLoginPassword, ChangePass = @ChangePass " +
                                                "WHERE username='" + clsGlobal.userName + "';", conn);

            //Add values to the query parameters
            cmd.Parameters.AddWithValue("@NewLoginPassword", CalcMD5Hash(txtNewPassword.Text));
            cmd.Parameters.AddWithValue("@ChangePass", false);

            //Open the DB connection
            conn.Open();

            //Execute the query
            cmd.ExecuteNonQuery();

            //Close the conection
            conn.Close();

            //Show message box to inform user the employee has been entered
            MessageBox.Show("Your password has been updated on the system.", "Password updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Open the form frmLogin as a child to the parent
            frmLogin objfrmLogin = new frmLogin();
            objfrmLogin.MdiParent = frmWeeklyReportMain.ActiveForm;
            objfrmLogin.StartPosition = FormStartPosition.CenterScreen;
            objfrmLogin.Show();

            this.Close();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Weekly Report",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        }
    }
}
