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
            }
            else if(txtDatePublished.Text != "" && txtDateArchived.Text == "")
            {
                btnPublish.Enabled = false;
            }
            else if(txtDateArchived.Text != "")
            {
                btnArchive.Enabled = false;
            }
        }
    

        //private void BtnStatus_Click(object? sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    if (btn.Text == "Draft")
        //    {
        //        txtPublished.Text = "";
        //        txtArchived.Text = "";
        //    }
        //    //?? LoadForm(recipeid); - to refresh
        //}

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change this recipe status?", "Hearty Hearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                txtDatePublished.Text = "";
                txtDateArchived.Text = "";
                btnDraft.Enabled = false;
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

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change this recipe status?", "Hearty Hearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                txtDateArchived.Text = "";
                btnPublish.Enabled = false;
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

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change this recipe status?", "Hearty Hearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                btnArchive.Enabled = false;
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

    }
}
