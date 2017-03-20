using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeklyReport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                frmSplash objfrmSplash = new frmSplash();
                objfrmSplash.ShowDialog();
                frmWeeklyReportMain g_objfrmWeeklyReportMain = new frmWeeklyReportMain();
                Application.Run(g_objfrmWeeklyReportMain);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Weekly Report",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
    }
}
