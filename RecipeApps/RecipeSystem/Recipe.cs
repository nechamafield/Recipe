﻿using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using CPUFramework;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipename)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        //public static DataTable SearchRecipe(int usersid, int cuisineid, string recipename)
        //{
        //    DataTable dt = new();
        //    SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeSearch");
        //    cmd.Parameters["@RecipeName"].Value = recipename;
        //    dt = SQLUtility.GetDataTable(cmd);
        //    return dt;
        //}

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
        }

        public static DataTable GetRecipeListForOnlyRecipes()
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSQLCommand("CloneRecipeListGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }


        public static void UpdateClonedRecipeInfo(DataTable dtRecipe)
        {

            if (dtRecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call RecipeSave Method because there are no rows in table");
            }
            DataRow r = dtRecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "ClonedRecipeUpdate");
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
            SqlCommand cmd = SQLUtility.GetSQLCommand("MealGet");
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

        public static DataTable GetIngredientList()
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSQLCommand("IngredientGet");
            cmd.Parameters["@All"].Value = 1; 
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetStepsListByRecipe(int recipeid)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSQLCommand("DirectionRecipeGet");
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

        public static void SaveStatus(DataTable dtRecipe)
        {
            if (dtRecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call RecipeSave Method because there are no rows in table");
            }
            DataRow r = dtRecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeStatusUpdate");
        }

        public static void Delete(DataTable dtRecipe)
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParameterValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void SaveRecipeStatus(DataTable dt, string DateType)
        {
            if(DateType == "Drafted")
            {
                dt.Rows[0]["DateDrafted"] = DateTime.Now;
                dt.Rows[0]["DatePublished"] = DBNull.Value;
                dt.Rows[0]["DateArchived"] = DBNull.Value;
                SaveStatus(dt);
            }
            if (DateType == "Published")
            {
                dt.Rows[0]["DatePublished"] = DateTime.Now;
                dt.Rows[0]["DateArchived"] = DBNull.Value; 
                SaveStatus(dt);
            }
            if (DateType == "Archived")
            {
                dt.Rows[0]["DateArchived"] = DateTime.Now; 
                SaveStatus(dt);
            }
        }

        public static void CloneRecipe(DataRow row)
        {
            SQLUtility.SaveDataRow(row, "ClonedRecipeUpdate");
        }

    }
}
