using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyReport
{
    //Public variable class
    internal static class clsGlobal
    {
        public static string userName;
        public static Int32 currentReportID;
        public static string projectNumber;
        public static string weekNumber;
     
    }
    //Public MDI class to reference contrals on MDI form
    public class refWeeklyReportMDI
    {
        public static frmWeeklyReportMain mdi;
    }
}