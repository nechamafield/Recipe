using CPUWindowsFormsFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;

        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            //txtRecipes.Text = //sql count of all recipes in list...same for meal & cookbook;
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {

        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {

        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {

        }
    }
}
