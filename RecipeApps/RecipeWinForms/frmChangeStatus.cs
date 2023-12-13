using CPUFramework;
using CPUWindowsFormsFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
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
        int recipeid = 0;
        DataTable dtrecipe = new();
        public frmChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
            this.FormClosed += FrmChangeStatus_FormClosed;
        }

        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            this.Show();
            ChangeStatusButtonsEnabled();
        }

        private void ChangeStatusButtonsEnabled()
        {
            if(txtDateDrafted.Text != "" && txtDatePublished.Text == "" && txtDateArchived.Text == "")
            {
                btnDraft.Enabled = false;
                lblCurrrentStatus.Text = lblCurrrentStatus.Text + " Draft";
            }
            else if(txtDatePublished.Text != "" && txtDateArchived.Text == "")
            {
                btnPublish.Enabled = false;
                lblCurrrentStatus.Text = lblCurrrentStatus.Text + " Published";
            }
            else if(txtDateArchived.Text != "")
            {
                btnArchive.Enabled = false;
                lblCurrrentStatus.Text = lblCurrrentStatus.Text + " Archived";
            }
        }

        private void StatusBtnClicked(string status, string lblstatus)
        {
            var response = MessageBox.Show("Are you sure you want to change this recipe status?", "Hearty Hearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.SaveRecipeStatus(dtrecipe, status);
                lblCurrrentStatus.Text = "Current Status: " + lblstatus;
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

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            StatusBtnClicked("Drafted", "Draft");
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            StatusBtnClicked("Published", "Published");
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            StatusBtnClicked("Archived", "Archived");
        }

        private void FrmChangeStatus_FormClosed(object? sender, FormClosedEventArgs e)
        {
            bindsource.ResetBindings(true);
        }
    }
}
