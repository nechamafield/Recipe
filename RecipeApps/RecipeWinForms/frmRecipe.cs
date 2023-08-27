using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using CPUFramework;
using CPUWindowsFormsFramework;
using RecipeSystem;

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
            dtRecipe = Recipe.Load(recipeid);
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
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, dtRecipe);
            WindowsFormsUtility.SetControlBinding(dtpDatePublished, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipePictureName, dtRecipe);
            this.Show();
        }
        private void Save()
        {
            Recipe.Save(dtRecipe);
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Recipe.Delete(dtRecipe);
            this.Close();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

    }
}
