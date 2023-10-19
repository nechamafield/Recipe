using CPUFramework;
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
    public partial class frmNewCookbook : Form
    {
        int cookbookid = 0;
        DataTable dtcookbook = new();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        public frmNewCookbook()
        {
            InitializeComponent();
            this.Activated += FrmNewCookbook_Activated;
            gRecipe.CellContentClick += GRecipe_CellContentClick;
            btnSave.Click += BtnSave_Click;
        }

        private void FrmNewCookbook_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gRecipe.Columns.Clear();
            gRecipe.DataSource = Recipe.GetRecipeListForOnlyRecipes();
            WindowsFormsUtility.AddComboBoxToGridForRecipe(gRecipe, DataMaintenance.GetDataList("CloneRecipe"), "RecipeName", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipe, deletecolname);
            WindowsFormsUtility.FormatGridForSearchResults(gRecipe, "Recipe");

            //foreach (DataGridViewColumn col in gRecipe.Columns)
            //{
            //    if (col.Name.EndsWith("name"))
            //    {
            //        col.Visible = false;
            //    }
            //}

            if (txtCookbookName.Text == "")
            {
                txtDateCreated.Text = DateTime.Now.ToString();
                SetButtonsEnabledBasedOnNewRecord();
            }
        }

        public void LoadForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = Cookbook.Load(cookbookid);
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
            }
            DataTable dtUser = Cookbook.GetUsersList();
            WindowsFormsUtility.SetListBinding(lstUsersCompleteName, dtUser, dtcookbook, "Users");
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(chkActive, bindsource);

            this.Text = GetCookbookDesc();

            this.Show();
        }

        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "NumRecipes") + " " + SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookbookName");
            }
            return value;
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveRecipe.Enabled = b;
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Save(dtcookbook);
                b = true;
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
                this.Tag = cookbookid;
                SetButtonsEnabledBasedOnNewRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }


        //this (Delete and GRecipe_Cell...) should add column of x's near the recipes bu tit doesnt
        private void Delete(int rowindex, DataGridView dg, string tablename)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(dg, rowindex, tablename + "Id");
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow(tablename, id);
                    BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id == 0 && rowindex < dg.Rows.Count)
            {
                dg.Rows.Remove(dg.Rows[rowindex]);
            }
        }

        private void GRecipe_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gRecipe.Columns[e.ColumnIndex].Name == deletecolname)
            {
                Delete(e.RowIndex, gRecipe, "RecipeName");
            }
        }

    }
}
