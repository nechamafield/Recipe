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
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            this.Activated += RecipeList_Activated;
        }

        private void RecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gRecipeList.DataSource = Recipe.GetRecipeList();
            WindowsFormsUtility.FormatGridForSearchResults(gRecipeList, "Recipe");
        }
    }
}
