namespace RecipeWinForms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            miniToolStrip = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileDashboard = new ToolStripMenuItem();
            mnuRecipe = new ToolStripMenuItem();
            mnuRecipeList = new ToolStripMenuItem();
            mnuRecipeNew = new ToolStripMenuItem();
            mnuRecipeClone = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuMealsList = new ToolStripMenuItem();
            cookbooksToolStripMenuItem = new ToolStripMenuItem();
            mnuCookbookList = new ToolStripMenuItem();
            mnuCookbooksNew = new ToolStripMenuItem();
            mnuCookbookAutoCreate = new ToolStripMenuItem();
            mnuDataMaintenance = new ToolStripMenuItem();
            mnuDataMaintenanceEditData = new ToolStripMenuItem();
            mnuWindows = new ToolStripMenuItem();
            mnuWindowsTile = new ToolStripMenuItem();
            mnuWindowsCascade = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            mnuMain = new MenuStrip();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ComboBox;
            miniToolStrip.AutoSize = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            miniToolStrip.ImageScalingSize = new Size(20, 20);
            miniToolStrip.Location = new Point(0, 0);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(641, 36);
            miniToolStrip.TabIndex = 8;
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileDashboard });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(56, 32);
            mnuFile.Text = "File";
            // 
            // mnuFileDashboard
            // 
            mnuFileDashboard.Name = "mnuFileDashboard";
            mnuFileDashboard.Size = new Size(194, 32);
            mnuFileDashboard.Text = "Dashboard";
            // 
            // mnuRecipe
            // 
            mnuRecipe.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipeList, mnuRecipeNew, mnuRecipeClone });
            mnuRecipe.Name = "mnuRecipe";
            mnuRecipe.Size = new Size(83, 32);
            mnuRecipe.Text = "Recipe";
            // 
            // mnuRecipeList
            // 
            mnuRecipeList.Name = "mnuRecipeList";
            mnuRecipeList.Size = new Size(225, 32);
            mnuRecipeList.Text = "List";
            // 
            // mnuRecipeNew
            // 
            mnuRecipeNew.Name = "mnuRecipeNew";
            mnuRecipeNew.Size = new Size(225, 32);
            mnuRecipeNew.Text = "New Recipe";
            // 
            // mnuRecipeClone
            // 
            mnuRecipeClone.Name = "mnuRecipeClone";
            mnuRecipeClone.Size = new Size(225, 32);
            mnuRecipeClone.Text = "Clone a Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealsList });
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(77, 32);
            mnuMeals.Text = "Meals";
            // 
            // mnuMealsList
            // 
            mnuMealsList.Name = "mnuMealsList";
            mnuMealsList.Size = new Size(127, 32);
            mnuMealsList.Text = "List";
            // 
            // cookbooksToolStripMenuItem
            // 
            cookbooksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbookList, mnuCookbooksNew, mnuCookbookAutoCreate });
            cookbooksToolStripMenuItem.Name = "cookbooksToolStripMenuItem";
            cookbooksToolStripMenuItem.Size = new Size(126, 32);
            cookbooksToolStripMenuItem.Text = "Cookbooks";
            // 
            // mnuCookbookList
            // 
            mnuCookbookList.Name = "mnuCookbookList";
            mnuCookbookList.Size = new Size(234, 32);
            mnuCookbookList.Text = "List";
            // 
            // mnuCookbooksNew
            // 
            mnuCookbooksNew.Name = "mnuCookbooksNew";
            mnuCookbooksNew.Size = new Size(234, 32);
            mnuCookbooksNew.Text = "New Cookbook";
            // 
            // mnuCookbookAutoCreate
            // 
            mnuCookbookAutoCreate.Name = "mnuCookbookAutoCreate";
            mnuCookbookAutoCreate.Size = new Size(234, 32);
            mnuCookbookAutoCreate.Text = "Auto-Create";
            // 
            // mnuDataMaintenance
            // 
            mnuDataMaintenance.DropDownItems.AddRange(new ToolStripItem[] { mnuDataMaintenanceEditData });
            mnuDataMaintenance.Name = "mnuDataMaintenance";
            mnuDataMaintenance.Size = new Size(184, 32);
            mnuDataMaintenance.Text = "Data Maintenance";
            // 
            // mnuDataMaintenanceEditData
            // 
            mnuDataMaintenanceEditData.Name = "mnuDataMaintenanceEditData";
            mnuDataMaintenanceEditData.Size = new Size(178, 32);
            mnuDataMaintenanceEditData.Text = "Edit Data";
            // 
            // mnuWindows
            // 
            mnuWindows.DropDownItems.AddRange(new ToolStripItem[] { mnuWindowsTile, mnuWindowsCascade });
            mnuWindows.Name = "mnuWindows";
            mnuWindows.Size = new Size(107, 32);
            mnuWindows.Text = "Windows";
            // 
            // mnuWindowsTile
            // 
            mnuWindowsTile.Name = "mnuWindowsTile";
            mnuWindowsTile.Size = new Size(169, 32);
            mnuWindowsTile.Text = "Tile";
            // 
            // mnuWindowsCascade
            // 
            mnuWindowsCascade.Name = "mnuWindowsCascade";
            mnuWindowsCascade.Size = new Size(169, 32);
            mnuWindowsCascade.Text = "Cascade";
            // 
            // tsMain
            // 
            tsMain.Dock = DockStyle.None;
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Location = new Point(0, 36);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(112, 25);
            tsMain.TabIndex = 3;
            tsMain.Text = "toolStrip1";
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipe, mnuMeals, cookbooksToolStripMenuItem, mnuDataMaintenance, mnuWindows });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(844, 36);
            mnuMain.TabIndex = 8;
            mnuMain.Text = "menuStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 739);
            Controls.Add(mnuMain);
            Controls.Add(tsMain);
            IsMdiContainer = true;
            MainMenuStrip = miniToolStrip;
            Name = "frmMain";
            Text = "Hearty Hearth";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip miniToolStrip;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileDashboard;
        private ToolStripMenuItem mnuRecipe;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuRecipeNew;
        private ToolStripMenuItem mnuRecipeClone;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealsList;
        private ToolStripMenuItem cookbooksToolStripMenuItem;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuCookbooksNew;
        private ToolStripMenuItem mnuCookbookAutoCreate;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuDataMaintenanceEditData;
        private ToolStripMenuItem mnuWindows;
        private ToolStripMenuItem mnuWindowsTile;
        private ToolStripMenuItem mnuWindowsCascade;
        private ToolStrip tsMain;
        private MenuStrip mnuMain;
    }
}