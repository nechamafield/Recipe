using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;
using CPUFramework;
using CPUWindowsFormsFramework;
using Microsoft.VisualBasic.ApplicationServices;
using RecipeSystem;


namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtRecipe;
        BindingSource bindsource = new BindingSource();
        DataTable dt = new();
        DataTable dtRecipeIng = new();
        DataTable dtRecipeSteps = new();
        string deletecolname = "deletecol";
        int recipeid = 0;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            this.FormClosing += FrmRecipe_FormClosing;
            btnIngredientsSave.Click += BtnIngredientsSave_Click;
            btnStepsSave.Click += BtnStepsSave_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            this.Activated += FrmRecipe_Activated;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
        }


        private void FrmRecipe_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gIngredients.Columns.Clear();
            gSteps.Columns.Clear();

            dtRecipeIng = Recipe.GetIngredientListByRecipe(recipeid);
            gIngredients.DataSource = dtRecipeIng;

            dtRecipeSteps = Recipe.GetStepsListByRecipe(recipeid);
            gSteps.DataSource = dtRecipeSteps;

            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Measurement"), "Measurement", "MeasurementName");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormsUtility.FormatGridForEdit(gIngredients, "Ingredient");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, deletecolname);

            WindowsFormsUtility.FormatGridForEdit(gSteps, "DirectionRecipe");
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolname);
            SetButtonsEnabledBasedOnNewRecord();

            foreach (DataGridViewColumn col in gIngredients.Columns)
            {
                if (col.Name.EndsWith("name"))
                {
                    col.Visible = false;
                }
            }

            if (txtRecipeName.Text == "")
            {
                txtDateDrafted.Text = DateTime.Now.ToString();
                SetButtonsEnabledBasedOnNewRecord(false);
            }

        }

        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtRecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtRecipe;
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtCuisine = Recipe.GetCuisineList();
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, dtRecipe, "Cuisine");

            DataTable dtuser = Recipe.GetUsersList();
            WindowsFormsUtility.SetListBinding(lstUsersCompleteName, dtuser, dtRecipe, "Users");

            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, bindsource);

            this.Text = GetRecipeDesc();

            this.Show();
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtRecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
                this.Tag = recipeid;
                this.Text = GetRecipeDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            SetButtonsEnabledBasedOnNewRecord();
            return b;
        }

        private void SetButtonsEnabledBasedOnNewRecord(bool b = true)
        {
            btnDelete.Enabled = b;
            btnIngredientsSave.Enabled = b;
            btnStepsSave.Enabled = b;
            btnChangeStatus.Enabled = b;
        }

        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "Calories") + " " + SQLUtility.GetValueFromFirstRowAsString(dtRecipe, "RecipeName");
            }
            return value;
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", "Hearty Hearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtRecipe);
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

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtRecipe))
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

        private void SaveRecipeIngredients()
        {
            try
            {
                IngredientRecipe.SaveTable(dtRecipeIng, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void SaveRecipeSteps()
        {
            try
            {
                StepsRecipe.SaveTable(dtRecipeSteps, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
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

        private void BtnStepsSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeSteps();
        }

        private void BtnIngredientsSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredients();
        }

        private void ShowChangeStatusForm(int rowindex)
        {
            if (rowindex > -1)
            {
                recipeid = WindowsFormsUtility.GetIdFromGrid(gIngredients, rowindex, "RecipeId");
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), recipeid);
            }
            if (recipeid == 0)  
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), recipeid);
            }
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            //this open blank form inside mdiparent
            //ShowChangeStatusForm(recipeid);

            //this opens correct form popped out
            var frm = new frmChangeStatus();
            frm.LoadForm(recipeid);
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gSteps.Columns[e.ColumnIndex].Name == deletecolname)
            {
                Delete(e.RowIndex, gSteps, "DirectionRecipe");
            }
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gIngredients.Columns[e.ColumnIndex].Name == deletecolname)
            {
                Delete(e.RowIndex, gIngredients, "IngredientRecipe");
            }
        }

    }
}
