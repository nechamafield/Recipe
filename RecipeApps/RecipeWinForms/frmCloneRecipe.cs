using CPUFramework;
using CPUWindowsFormsFramework;
using Microsoft.VisualBasic.ApplicationServices;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        DataTable dtRecipe = new();
        DataTable dtselectrecipe = new();
        int recipeid = 0;
        string recipename = "";
        BindingSource bindsource = new BindingSource();
        int userid = 0;
        public frmCloneRecipe()
        {
            InitializeComponent();
            this.Activated += FrmCloneRecipe_Activated;
            btnClone.Click += BtnClone_Click;
        }

        private void FrmCloneRecipe_Activated(object? sender, EventArgs e)
        {
            BindData(recipeid);
        }

        private void BindData(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtRecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtRecipe;
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            dtselectrecipe = Recipe.GetRecipeList();
            WindowsFormsUtility.SetListBinding(lstRecipeName, dtselectrecipe, dtRecipe, "Recipe");
            this.Show();
        }


        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                try
                {
                    recipeid = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);
                    Recipe.UpdateClonedRecipeInfo(dtRecipe);
                    string newid = "";
                    newid = dtRecipe.Rows[0][0].ToString();
                    bool b = int.TryParse(newid, out id);
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
                }
                catch
                {
                    MessageBox.Show("This recipe already exists.", "Hearty Hearth", MessageBoxButtons.OKCancel);
                }
            }
            if (recipeid == 0)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), recipeid);
            }
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            //ShowRecipeForm(recipeid);
            //this.Close();

            DataRow row = dtselectrecipe.Rows[lstRecipeName.SelectedIndex];
            Recipe.CloneRecipe(row);
            int newid = (int)row["RecipeId"];
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), newid);
            }
            this.Close();
        }
    }
}
