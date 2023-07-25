﻿using System.Data;
using CPUFramework;
using CPUWindowsFormsFramework;

namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            WindowsFormsUtility.FormatGridForSearchResults(gRecipe);
            btnNew.Click += BtnNew_Click;
        }

        private void SearchForRecipe(string recipe)
        {
            string sql = "Select r.Recipeid, r.RecipeName, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePictureName from Recipe r where r.RecipeName like '%" + recipe + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipe.DataSource = dt;
            gRecipe.Columns["recipeid"].Visible = false;
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if(rowindex > -1)
            {
               id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }
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

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
    }
}
