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
        //AF int recipeid = 0;
        int userid = 0;
        //AF string recipename = "";
        //AF BindingSource bindsource = new BindingSource();
        public frmAuto_CreateCookbook()
        {
            InitializeComponent();
            this.Activated += FrmAuto_CreateCookbook_Activated;
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }

        private void FrmAuto_CreateCookbook_Activated(object? sender, EventArgs e)
        {
            BindData();//AFrecipeid);
        }

        private void BindData()//AFint recipeidval)
        {
            //AF recipeid = recipeidval;
            //AF this.Tag = recipeid;
            //AFdtusers = Recipe.Load(recipeid);
            //AFbindsource.DataSource = dtusers;
            //AFif (recipeid == 0)
            //AF{
            //AF    dtusers.Rows.Add();
            //AF}
            DataTable dtUser = Cookbook.GetUsersList();
            WindowsFormsUtility.SetListBinding(lstUsersCompleteName, dtUser, null, "Users");
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

        private void ShowCookbookForm()//AFint rowindex)
        {
            int id = 0;
            //AFif (rowindex > -1)
            //AF{
            DataTable dt = Cookbook.Load(0);
            dt.Rows.Add();
            DataRow row = dt.Rows[0];
            userid = WindowsFormsUtility.GetIdFromComboBox(lstUsersCompleteName);
            row["usersId"] = userid;
            Cookbook.GetAutoCreateCookbook(row);
            int cookbookid = (int)row["CookbookId"];
            //AF newid = dtusers.Rows[0][0].ToString();
            //AF bool b = int.TryParse(newid, out id);
            ((frmMain)this.MdiParent).OpenForm(typeof(frmNewCookbook), cookbookid);
            //AF}
            //AFif (recipeid == 0)
            //AF{
            //AF    ((frmMain)this.MdiParent).OpenForm(typeof(frmAuto_CreateCookbook), recipeid);
            //AF}

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
            ShowCookbookForm();//AFrecipeid);
        }
    }
}
