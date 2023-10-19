using CPUWindowsFormsFramework;
using RecipeSystem;
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
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            gRecipeList.CellDoubleClick += GRecipeList_CellDoubleClick;
            btnNewRecipe.Click += BtnNewRecipe_Click;
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
            foreach (DataGridViewColumn col in gRecipeList.Columns)
            {
                if (col.Name.StartsWith("Date"))
                {
                    col.Visible = false;
                }
            }
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gRecipeList, rowindex, "RecipeId");
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
            if (id == 0)   //this.MdiParent != null && this.MdiParent is frmRecipeList)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
        }

        private void GRecipeList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            
            ShowRecipeForm(-1);
        }

    }
}
