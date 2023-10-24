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
        DataTable dtcookbookrecipe = new();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        public frmNewCookbook()
        {
            InitializeComponent();
            this.Activated += FrmNewCookbook_Activated;
            gRecipe.CellContentClick += GRecipe_CellContentClick;
            this.FormClosing += FrmNewCookbook_FormClosing;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
        }

        private void FrmNewCookbook_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gRecipe.Columns.Clear();
            gRecipe.DataSource = Cookbook.GetRecipeListForCookbooks(cookbookid);

            WindowsFormsUtility.AddComboBoxToGrid(gRecipe, DataMaintenance.GetDataList("CookbookRecipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipe, deletecolname);
            //WindowsFormsUtility.FormatGridForSearchResults(gRecipe, "Recipe");
            WindowsFormsUtility.FormatGridForEdit(gRecipe, "CookbookRecipe");

            foreach (DataGridViewColumn col in gRecipe.Columns)
            {
                if (col.Name.EndsWith("Name"))
                {
                    col.Visible = false;
                }
            }

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
            WindowsFormsUtility.SetControlBinding(chkIsActive, bindsource);

            if (dtcookbook.Rows[0]["IsActive"].ToString() == "1")
            {
                chkIsActive.Checked = true;
            }
            else if (dtcookbook.Rows[0]["IsActive"].ToString() == "0")
            {
                chkIsActive.Checked = false;
            }
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

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this cookbook?", "Hearty Hearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtcookbook);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
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
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "RecipeId");
                this.Tag = cookbookid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetCookbookDesc();
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

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }


        private void FrmNewCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbook))
            {
                var response = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (response)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

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

        private void SaveRecipes()
        {
            try
            {
                CookbookRecipe.SaveTable(dtcookbookrecipe, cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            SaveRecipes();
        }

    }
}
