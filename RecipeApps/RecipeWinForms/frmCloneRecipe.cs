﻿using CPUFramework;
using CPUWindowsFormsFramework;
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
        int recipeid = 0;
        string recipename = "";
        BindingSource bindsource = new BindingSource();
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
            DataTable dtselectrecipe = Recipe.GetRecipeListForClone();
            WindowsFormsUtility.SetListBinding(lstRecipeName, dtselectrecipe, dtRecipe, "Recipe");


        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);
            }
            if (this.MdiParent != null && this.MdiParent is frmRecipeList)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
            frmRecipe frm = new();
            frm.LoadForm(id);
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(recipeid);
        }
    }
}