using CPUWindowsFormsFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmMealsList : Form
    {
        public frmMealsList()
        {
            InitializeComponent();
            this.Activated += MealsList_Activated;
        }

        private void MealsList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }


        private void BindData()
        {
            gMeals.DataSource = Recipe.GetMealsList();
            WindowsFormsUtility.FormatGridForSearchResults(gMeals, "Meal");
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gMeals, rowindex, "mealId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMealsList)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmMealsList), id);
            }
            frmRecipe frm = new();
            frm.LoadForm(id);
        }
    }
}
