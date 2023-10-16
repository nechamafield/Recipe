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
    public partial class frmChangeStatus : Form
    {
        BindingSource bindsource = new BindingSource();
        string recipestatus = "";
        public frmChangeStatus()
        {
            InitializeComponent();
            this.Activated += FrmChangeStatus_Activated;
            lblRecipeName.Text = "Recipe";
        }

        private void FrmChangeStatus_Activated(object? sender, EventArgs e)
        {
            //BindData();
        }

        //   //????????????
        //private void BindData(string recipestatusval)
        //{
        //    recipestatus = recipestatusval;
        //    this.Tag = recipestatus;
        //    txtDrafted.Text = Recipe.GetStatusList(recipestatus);
        //    bindsource.DataSource = txtDrafted;
        //    WindowsFormsUtility.SetControlBinding(txtDrafted, bindsource);
        //    WindowsFormsUtility.SetControlBinding(txtPublished, bindsource);
        //    WindowsFormsUtility.SetControlBinding(txtArchived, bindsource);

        //}

        ////    //public void LoadForm(int recipeidval)
        ////    //{
        ////    //    recipeid = recipeidval;
        ////    //    this.Tag = recipeid;
        ////    //    dtRecipe = Recipe.Load(recipeid);
        ////    //    bindsource.DataSource = dtRecipe;
        ////    //    if (recipeid == 0)
        ////    //    {
        ////    //        dtRecipe.Rows.Add();
        ////    //    }
        ////    //    DataTable dtcousine = Recipe.GetCousineList();
        ////    //    WindowsFormsUtility.SetListBinding(lstCousineType, dtcousine, dtRecipe, "Cousine");
        ////    //    //DataTable dtusername = Recipe.GetUsersList();
        ////    //    //WindowsFormsUtility.SetListBinding(lstUsername, dtusername, dtRecipe, "Users");
        ////    //    WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
        ////    //    WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
        ////    //    WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
        ////    //    WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
        ////    //    WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
        ////    //    WindowsFormsUtility.SetControlBinding(txtRecipeStatus, bindsource);
        ////    //    //WindowsFormsUtility.SetControlBinding(txtRecipePictureName, bindsource);
        ////    //    this.Text = GetRecipeDesc();

        ////    //    this.Show();
        ////    //}
        }
    }
