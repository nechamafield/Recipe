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
    public partial class frmAuto_CreateCookbook : Form
    {
        DataTable dtusers = new();
        int recipeid = 0;
        int userid = 0;
        string recipename = "";
        BindingSource bindsource = new BindingSource();
        public frmAuto_CreateCookbook()
        {
            InitializeComponent();
            this.Activated += FrmAuto_CreateCookbook_Activated;
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }

        private void FrmAuto_CreateCookbook_Activated(object? sender, EventArgs e)
        {
            BindData(recipeid);
        }

        private void BindData(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtusers = Recipe.Load(recipeid);
            bindsource.DataSource = dtusers;
            if (recipeid == 0)
            {
                dtusers.Rows.Add();
            }
            DataTable dtUser = Cookbook.GetUsersList();
            WindowsFormsUtility.SetListBinding(lstUsersCompleteName, dtUser, dtusers, "Users");
        }

        //////THIS MAKES CLONE NOT POP OUT TRY IT FOR AUTOCREATE AFTER SPROC IS WORKING
        //private void ShowRecipeForm(int rowindex)
        //{
        //    int id = 0;
        //    if (rowindex > -1)
        //    {
        //        recipeid = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);
        //        Recipe.UpdateClonedRecipeInfo(dtRecipe);
        //        string newid = "";
        //        newid = dtRecipe.Rows[0][0].ToString();
        //        bool b = int.TryParse(newid, out id);
        //        ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
        //    }
        //    if (recipeid == 0)
        //    {
        //        ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), recipeid);
        //    }
        //}

        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                userid = WindowsFormsUtility.GetIdFromComboBox(lstUsersCompleteName);
                Cookbook.GetAutoCreateCookbook(dtusers);
                string newid = "";
                newid = dtusers.Rows[0][0].ToString();
                bool b = int.TryParse(newid, out id);
                ((frmMain)this.MdiParent).OpenForm(typeof(frmAuto_CreateCookbook), id);
            }
            if (recipeid == 0)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmAuto_CreateCookbook), recipeid);
            }

            //int id = 0;
            //if (rowindex > -1)
            //{
            //    Cookbook.GetAutoCreateCookbook(dtusers);
            //    id = WindowsFormsUtility.GetIdFromComboBox(lstUsersCompleteName);
            //    ((frmMain)this.MdiParent).OpenForm(typeof(frmNewCookbook), id);
            //}
            //if (this.MdiParent != null && this.MdiParent is frmCookbookList)
            //{
            //    ((frmMain)this.MdiParent).OpenForm(typeof(frmNewCookbook), id);
            //}
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(recipeid);
        }
    }
}
