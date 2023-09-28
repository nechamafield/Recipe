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
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            this.Activated += FrmCookbookList_Activated;
            gCookbookList.CellDoubleClick += GCookbookList_CellDoubleClick;
            btnNewCookBook.Click += BtnNewCookBook_Click;
        }

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gCookbookList.DataSource = Recipe.GetCookbooksList();
            WindowsFormsUtility.FormatGridForSearchResults(gCookbookList, "Cookbook");
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gCookbookList, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmCookbookList)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
            frmRecipe frm = new();
            frm.LoadForm(id);
        }

        private void GCookbookList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnNewCookBook_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
    }
}
