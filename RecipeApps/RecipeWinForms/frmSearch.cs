using System.Data;
using CPUFramework;
using CPUWindowsFormsFramework;
using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            WindowsFormsUtility.FormatGridForSearchResults(gRecipe, "Recipe");
            btnNew.Click += BtnNew_Click;
        }

        private void SearchForRecipe(string recipe)
        {
            DataTable dt = Recipe.SearchRecipe(recipe);
            gRecipe.DataSource = dt;
            gRecipe.Columns["recipeid"].Visible = false;
        }

        //private void ShowRecipeForms(int rowindex)
        //{
        //    int id = 0;
        //    if (rowindex > -1)
        //    {
        //        id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
        //    }
        //    frmRecipe frm = new();
        //    frm.LoadForm(id);
        //}

        //-- i changed showform to loadform, by president it was changed like this
        //fixed - but when use this it x open a recipe if its double clicked.
        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gRecipe, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmDashboard)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
            frmRecipe frm = new();
            frm.LoadForm(id);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipe.Text);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
    }
}
