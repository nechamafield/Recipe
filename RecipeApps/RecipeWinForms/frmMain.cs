using CPUWindowsFormsFramework;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuFileDashboard.Click += MnuFileDashboard_Click;
            mnuRecipeList.Click += MnuRecipeList_Click;
            mnuRecipeNew.Click += MnuRecipeNew_Click;
            mnuRecipeClone.Click += MnuRecipeClone_Click;
            mnuMealsList.Click += MnuMealsList_Click;
            mnuCookbookList.Click += MnuCookbookList_Click;
            mnuCookbooksNew.Click += MnuCookbooksNew_Click;
            mnuCookbookAutoCreate.Click += MnuCookbookAutoCreate_Click;
            mnuDataMaintenanceEditData.Click += MnuDataMaintenanceEditData_Click;
            mnuWindowsTile.Click += MnuWindowsTile_Click;
            mnuWindowsCascade.Click += MnuWindowsCascade_Click;
            this.Shown += FrmMain_Shown;

            decimal d = new decimal();
            //d.

            //d = 32.5456;


        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype);
            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmRecipe))
                {
                    frmRecipe f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmSearch))
                {
                    frmSearch f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmMealsList))
                {
                    frmMealsList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipe))
                {
                    frmRecipe f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmNewCookbook))
                {
                    frmNewCookbook f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmChangeStatus))
                {
                    frmChangeStatus f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmChangeStatus))
                {
                    frmChangeStatus f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCloneRecipe))
                {
                    frmCloneRecipe f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmAuto_CreateCookbook))
                {
                    frmAuto_CreateCookbook f = new();
                    newfrm = f;
                }
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Frm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }
                WindowsFormsUtility.SetupNav(tsMain);
            }
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void MnuWindowsCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuWindowsTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuDataMaintenanceEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }

        private void MnuCookbookAutoCreate_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmAuto_CreateCookbook));
        }

        private void MnuCookbooksNew_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmNewCookbook));
        }

        private void MnuCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void MnuMealsList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealsList));
        }

        private void MnuRecipeClone_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneRecipe));
        }

        private void MnuRecipeNew_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipe));
        }

        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }

        private void MnuFileDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }
    }
}
