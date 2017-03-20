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
    public partial class frmOptions : Form
    {
        public frmOptions()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdChangePass_Click(object sender, EventArgs e)
        {
            try
            { 

            if (string.IsNullOrEmpty(txtCurrentPass.Text))
            {
                MessageBox.Show("The current password must be entered.", "Weekly Report.",MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                var t = this.txtCurrentPass;
                t.Focus();
                t.BackColor = Color.Red;
                t.ForeColor = Color.White;

                return;
            }

            if (string.IsNullOrEmpty(txtNewPass.Text))
            {
                MessageBox.Show("A new password must be entered.", "Weekly Report.", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                var t = this.txtNewPass;
                t.Focus();
                t.BackColor = Color.Red;
                t.ForeColor = Color.White;

                return;
            }

            if (string.IsNullOrEmpty(txtConfirmPass.Text))
            {
                MessageBox.Show("A password confirmation must be entered.", "Weekly Report.", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                var t = this.txtConfirmPass;
                t.Focus();
                t.BackColor = Color.Red;
                t.ForeColor = Color.White;

                return;
            }

            //**********************************************************************************************************************

            //Connect to the DB
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.SQLConn);

            //Check password MD5
            string DBpassMD5;
            string EnteredPassMD5;

            //Run SQL command to retreive the passwords MD5 from the DB
            SqlCommand cmd = new SqlCommand("select passwordMD5 from Weekly_Report.tblEmployees where username='" +
                                    clsGlobal.userName + "';", conn);
            conn.Open();

            IDataReader reader = cmd.ExecuteReader();
            reader.Read();

            //Fill variables with the DB and entered MD5 values
            DBpassMD5 = reader.GetString(0);
            EnteredPassMD5 = CalcMD5Hash(txtCurrentPass.Text);

            conn.Close();

            //Compare the MD5 values
            if (String.Equals(DBpassMD5, EnteredPassMD5, StringComparison.Ordinal) == true)
            {

                //Build an OleDbCommand based on the SELECT query
                cmd = new SqlCommand("UPDATE Weekly_Report.tblEmployees SET PasswordMD5 = @NewLoginPassword, ChangePass = @ChangePass " +
                                                    "WHERE UserName = '" + clsGlobal.userName + "';", conn);

                //Add values to the query parameters
                cmd.Parameters.AddWithValue("@NewLoginPassword", CalcMD5Hash(txtNewPass.Text));
                cmd.Parameters.AddWithValue("@ChangePass", false);

                //Open the DB connection
                conn.Open();

                //Execute the query
                cmd.ExecuteNonQuery();

                //Close the conection
                conn.Close();

                //Show message box to inform user the employee has been entered
                MessageBox.Show("Your password has been updated on the system.", "Weekly Report.", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCurrentPass.Text = "";
                txtNewPass.Text = "";
                txtConfirmPass.Text = "";

            }
            else
            {
                MessageBox.Show("The current password is incorrect.", "Weekly Report",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtCurrentPass_TextChanged(object sender, EventArgs e)
        {
            var t = this.txtCurrentPass;
            t.Focus();
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            var t = this.txtNewPass;
            t.Focus();
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            var t = this.txtConfirmPass;
            t.Focus();
            t.BackColor = Color.White;
            t.ForeColor = Color.Black;
        }
    }
}
