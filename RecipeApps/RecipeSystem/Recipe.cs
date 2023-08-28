﻿using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using CPUFramework;

namespace RecipeSystem
{
    public class Recipe
    {

        public static DataTable SearchRecipe(String recipename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;

            //string sql = "Select r.Recipeid, r.RecipeName, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePictureName from Recipe r where r.RecipeName like '%" + recipename + "%'";
            //DataTable dt = SQLUtility.GetDataTable(sql);
            //return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;

            //string sql = "select r.*, c.cousinetype, u.username from Recipe r join Cousine c on r.cousineid = c.Cousineid join Users u on u.UsersId = r.Usersid where r.recipeid = " + recipeid.ToString();
            //return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetRecipeList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;

            //return SQLUtility.GetDataTable("select recipeid, recipename from Recipe");
        }

        public static void Save(DataTable dtRecipe)
        {
            SQLUtility.DebugPrintDataTable(dtRecipe);
            DataRow r = dtRecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"DateDrafted = '{r["DateDrafted"]}',",
                    ////$"RecipeStatus = '{r["RecipeStatus"]}',",        --------- hardcoded so not changing
                    ////$"RecipePictureName = '{r["RecipePictureName"]}'",  //,",         --------- hardcoded so not changing
                    $"Usersid = '{r["usersid"]}',",
                    $"Cousineid = '{r["Cousineid"]}'",
                    $"where recipeId = {r["recipeId"]}");
            }
            else
            {
                sql = "insert recipe(usersid, recipename, calories, datedrafted, Cousineid)";
                sql += $"select '{r["usersid"]}', '{r["recipename"]}','{r["calories"]}', '{r["datedrafted"]}','{r["CousineId"]}'";
            }
            Debug.Print("---------------------");
            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtRecipe)
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "delete CourseMealRecipe where Recipeid = " + id + "delete CookBookRecipe where Recipeid = " + id + "delete IngredientRecipe where Recipeid = " + id + "delete DirectionRecipe where Recipeid = " + id + "delete Recipe where Recipeid = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
