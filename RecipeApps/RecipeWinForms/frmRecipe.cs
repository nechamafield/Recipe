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
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int recipeid)
        {
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
            this.Show();
        }
        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtRecipe);
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

    }
}
