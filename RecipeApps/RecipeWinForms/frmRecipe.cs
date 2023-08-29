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
            //AF the 2 lists below should be refactored too.  RecipeSystem should have a method GetSTaffList and GetCuisineLIst, the sql should not be hardcoded in here
            // In those methods, use cpu framework to execute sprocs(add StaffGet Sproc and CuisineGet sproc if needed) Then you should use WindowsFormsUtility.SetLIstBinding
            DataTable dtcousine = Recipe.GetCousineList();
            WindowsFormsUtility.SetListBinding(lstCousineType, dtcousine, dtRecipe, "Cousine");
            DataTable dtusername = Recipe.GetUsersList();
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
