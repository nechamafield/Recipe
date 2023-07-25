using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using CPUFramework;
using CPUWindowsFormsFramework;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtRecipe;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int recipeid)
        {
            string sql = "select r.*, c.cousinetype, u.username from Recipe r join Cousine c on r.cousineid = c.Cousineid join Users u on u.UsersId = r.Usersid where r.recipeid = " + recipeid.ToString();
            dtRecipe = SQLUtility.GetDataTable(sql);
            if(recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtcousine = SQLUtility.GetDataTable("select cousineid, cousinetype from cousine");
            WindowsFormsUtility.SetListBinding(lstCousineType, dtcousine, dtRecipe, "Cousine");
            DataTable dtusername = SQLUtility.GetDataTable("select UsersId, Username from Users");
            WindowsFormsUtility.SetListBinding(lstUsername, dtusername, dtRecipe, "Users");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipePictureName, dtRecipe);
            this.Show();
        }
        private void Save()
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
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "Delete recipe where recipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

    }
}
