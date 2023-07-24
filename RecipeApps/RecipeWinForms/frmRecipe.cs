using System.Data;
using System.Diagnostics;
using CPUFramework;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select r.*, c.cousinetype, u.username from Recipe r join Cousine c on r.cousineid = c.Cousineid join Users u on u.UserId = r.Userid where r.recipeid = " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            txtDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            txtRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            txtRecipePicName.DataBindings.Add("Text", dt, "RecipePictureName");
            txtCuisine.DataBindings.Add("Text", dt, "Cousinetype");
            txtUserName.DataBindings.Add("Text", dt, "Username");
            this.Show();
        }

    }
}
