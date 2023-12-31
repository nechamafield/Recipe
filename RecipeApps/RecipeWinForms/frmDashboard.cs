﻿using CPUFramework;
using CPUWindowsFormsFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;

        }

        private void BindData()
        {
            DataTable dt = DataMaintenance.GetDashboard();
            SetTextBoxText(dt, "Recipe", txtRecipes);
            SetTextBoxText(dt, "Meal", txtMeals);
            SetTextBoxText(dt, "Cookbook", txtCookbooks);
        }

        private void SetTextBoxText(DataTable dt, string recordtype, TextBox txt)
        {
            var rows = dt.Select($"DashboardType = '{recordtype}'");
            if (rows.Length > 0)
            {
                txt.Text = rows[0]["DashboardText"].ToString();
            }
        }

        private void ShowFormRecipe()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeList));
            }
        }

        private void ShowFormMeal()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmMealsList));
            }
        }

        private void ShowFormCookbook()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
            }
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ShowFormCookbook();
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ShowFormMeal();
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ShowFormRecipe();
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }
    }
}
