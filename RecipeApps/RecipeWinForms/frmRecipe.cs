using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using CPUFramework;
using CPUWindowsFormsFramework;
using RecipeSystem;


namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtRecipe;
        BindingSource bindsource = new BindingSource();
        DataTable dtIngredientRecipe = new();
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
            DataTable dtcousine = Recipe.GetCousineList();
            WindowsFormsUtility.SetListBinding(lstCousineType, dtcousine, dtRecipe, "Cousine");
            DataTable dtusername = Recipe.GetUsersList();
            WindowsFormsUtility.SetListBinding(lstUsername, dtusername, dtRecipe, "Users");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(txtRecipePictureName, bindsource);
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
                SetButtonsEnabledBasedOnNewRecord();
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
            return b;
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSave.Enabled = b;
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
                IngredientRecipe.SaveTable(dtIngredientRecipe, recipeid);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void BtnStepsSave_Click(object? sender, EventArgs e)
        {

        }

        private void BtnIngredientsSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredients();
        }

    }
}
