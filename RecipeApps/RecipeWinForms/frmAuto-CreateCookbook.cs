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
        int userid = 0;

        public frmAuto_CreateCookbook()
        {
            InitializeComponent();
            this.Activated += FrmAuto_CreateCookbook_Activated;
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }

        private void BindData()
        {
            DataTable dtUser = Cookbook.GetUsersList();
            WindowsFormsUtility.SetListBinding(lstUsersCompleteName, dtUser, null, "Users");
        }

        private void ShowCookbookForm()
        {
            int id = 0;
            DataTable dt = Cookbook.Load(0);
            dt.Rows.Add();
            DataRow row = dt.Rows[0];
            userid = WindowsFormsUtility.GetIdFromComboBox(lstUsersCompleteName);
            row["usersId"] = userid;
            Cookbook.GetAutoCreateCookbook(row);
            int cookbookid = (int)row["CookbookId"];
            ((frmMain)this.MdiParent).OpenForm(typeof(frmNewCookbook), cookbookid);
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm();
        }

        private void FrmAuto_CreateCookbook_Activated(object? sender, EventArgs e)
        {
            BindData();
        }
    }
}
