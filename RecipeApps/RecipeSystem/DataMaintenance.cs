using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public static class DataMaintenance
    {
        public static DataTable GetDashboard()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("DashboardGet");
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetDataList(string tablename, bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Get");
            SQLUtility.SetParameterValue(cmd, "@All", 1);
            if (includeblank == true)
            {
                SQLUtility.SetParameterValue(cmd, "@IncludeBlank", includeblank);
            }
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void DeleteRow(string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Delete");
            SQLUtility.SetParameterValue(cmd, $"@{tablename}Id", id);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
