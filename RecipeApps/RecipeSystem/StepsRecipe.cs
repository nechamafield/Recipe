using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class StepsRecipe
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("DirectionRecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "DirectionRecipeUpdate");
        }

        public static void Delete(int StepRecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("DirectionRecipeDelete");
            cmd.Parameters["@DirectionRecipeId"].Value = StepRecipeid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
