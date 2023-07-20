using CPUFramework;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
        }

        private void SearchForRecipe(string recipe)
        {
            string sql = "select * from recipe r where r.RecipeName like '%" + recipe + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipe.DataSource = dt;
            gRecipe.Columns["recipeid"].Visible = false;
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            frmRecipe frm = new();
            frm.ShowForm(id);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipe.Text);
        }
    }
}
