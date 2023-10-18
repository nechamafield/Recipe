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

        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromComboBox(lstUsersCompleteName);
            }
            if (this.MdiParent != null && this.MdiParent is frmCookbookList)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmNewCookbook), id);
            }
            frmNewCookbook frm = new();
            frm.LoadForm(id);
            //change the cookbook to be the correct info
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(recipeid);
        }
    }
}
