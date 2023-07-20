using System.Data;
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
            string sql = "select * from recipe r  where r.recipeid = " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            txtDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            txtRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            txtRecipePicName.DataBindings.Add("Text", dt, "RecipePictureName");
            this.Show();
        }

    }
}
