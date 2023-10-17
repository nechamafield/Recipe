using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using CPUFramework;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(String recipename)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetRecipeList()
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;

            //return SQLUtility.GetDataTable("select recipeid, recipename from Recipe");
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSQLCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetUsersList()
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSQLCommand("UsersGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetMealsList()
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSQLCommand("MealsGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetIngredientListByRecipe(int recipeid)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSQLCommand("IngredientForRecipeGet");
            cmd.Parameters["@recipeid"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        //KEEP THIS!!
        //make GetIngredientList for when need all ingredients
        //dont pass in recipeid. should look exactly like this just uncomment it:
        //public static DataTable GetIngredientList()
        //{
        //    DataTable dt;
        //    SqlCommand cmd = SQLUtility.GetSQLCommand("IngredientGet");
        //    cmd.Parameters["@All"].Value = 1;
        //    dt = SQLUtility.GetDataTable(cmd);
        //    return dt;
        //}

        public static DataTable GetStepsListByRecipe(int recipeid)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSQLCommand("DirectionGet");
            cmd.Parameters["@recipeid"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetStatusList(int recipeid)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSQLCommand("StatusRecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtRecipe)
        {
            if(dtRecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call RecipeSave Method because there are no rows in table");
            }
            DataRow r = dtRecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        public static void Delete(DataTable dtRecipe)
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParameterValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }
    
    }
}
