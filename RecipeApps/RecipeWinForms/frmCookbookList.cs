using CPUFramework;
using CPUWindowsFormsFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            this.Activated += FrmCookbookList_Activated;
            gCookbookList.CellDoubleClick += GCookbookList_CellDoubleClick;
            btnNewCookBook.Click += BtnNewCookBook_Click;
        }

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gCookbookList.DataSource = Cookbook.GetCookbooksList();
            WindowsFormsUtility.FormatGridForSearchResults(gCookbookList, "Cookbook");
            foreach (DataGridViewColumn col in gCookbookList.Columns)
            {
                if (col.Name.EndsWith("Created") || col.Name.EndsWith("Active"))
                {
                    col.Visible = false;
                }
            }

        }

        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gCookbookList, rowindex, "CookbookId");
                ((frmMain)this.MdiParent).OpenForm(typeof(frmNewCookbook), id);
            }
            if (id == 0)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmNewCookbook), id);
            }
        }

        private void GCookbookList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }

        private void BtnNewCookBook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }
    }
}
