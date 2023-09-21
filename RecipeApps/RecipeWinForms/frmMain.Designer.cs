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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tsMain = new ToolStrip();
            mnuMain = new ToolStrip();
            mnuFile = new ToolStripDropDownButton();
            mnuFileDashboard = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuRecipeNewRecipe = new ToolStripDropDownButton();
            mnuRecipeList = new ToolStripMenuItem();
            mnuRecipeNew = new ToolStripMenuItem();
            mnuRecipeClone = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuMeals = new ToolStripDropDownButton();
            mnuMealsList = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuCookbookAutoCreate = new ToolStripDropDownButton();
            mnuCookbookList = new ToolStripMenuItem();
            mnuCookbooksNew = new ToolStripMenuItem();
            autoCreateToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            mnuDataMaintenanceEditData = new ToolStripDropDownButton();
            editDataToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            mnuWindows = new ToolStripDropDownButton();
            mnuWindowsTile = new ToolStripMenuItem();
            mnuWindowsCascade = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // tsMain
            // 
            tsMain.Dock = DockStyle.None;
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Location = new Point(-1, 34);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(112, 25);
            tsMain.TabIndex = 6;
            tsMain.Text = "toolStrip1";
            // 
            // mnuMain
            // 
            mnuMain.Dock = DockStyle.None;
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, toolStripSeparator1, mnuRecipeNewRecipe, toolStripSeparator2, mnuMeals, toolStripSeparator3, mnuCookbookAutoCreate, toolStripSeparator4, mnuDataMaintenanceEditData, toolStripSeparator5, mnuWindows, toolStripSeparator6, toolStripButton1 });
            mnuMain.Location = new Point(-1, -1);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(753, 35);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "toolStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileDashboard });
            mnuFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuFile.ImageTransparentColor = Color.Magenta;
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(56, 32);
            mnuFile.Text = "File";
            // 
            // mnuFileDashboard
            // 
            mnuFileDashboard.Name = "mnuFileDashboard";
            mnuFileDashboard.Size = new Size(193, 32);
            mnuFileDashboard.Text = "DashBoard";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // mnuRecipeNewRecipe
            // 
            mnuRecipeNewRecipe.DisplayStyle = ToolStripItemDisplayStyle.Text;
            mnuRecipeNewRecipe.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipeList, mnuRecipeNew, mnuRecipeClone });
            mnuRecipeNewRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuRecipeNewRecipe.ImageTransparentColor = Color.Magenta;
            mnuRecipeNewRecipe.Name = "mnuRecipeNewRecipe";
            mnuRecipeNewRecipe.Size = new Size(91, 32);
            mnuRecipeNewRecipe.Text = "Recipes";
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
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 35);
            // 
            // mnuMeals
            // 
            mnuMeals.DisplayStyle = ToolStripItemDisplayStyle.Text;
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealsList });
            mnuMeals.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuMeals.ImageTransparentColor = Color.Magenta;
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
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 35);
            // 
            // mnuCookbookAutoCreate
            // 
            mnuCookbookAutoCreate.DisplayStyle = ToolStripItemDisplayStyle.Text;
            mnuCookbookAutoCreate.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbookList, mnuCookbooksNew, autoCreateToolStripMenuItem });
            mnuCookbookAutoCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuCookbookAutoCreate.ImageTransparentColor = Color.Magenta;
            mnuCookbookAutoCreate.Name = "mnuCookbookAutoCreate";
            mnuCookbookAutoCreate.Size = new Size(126, 32);
            mnuCookbookAutoCreate.Text = "Cookbooks";
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
            // autoCreateToolStripMenuItem
            // 
            autoCreateToolStripMenuItem.Name = "autoCreateToolStripMenuItem";
            autoCreateToolStripMenuItem.Size = new Size(234, 32);
            autoCreateToolStripMenuItem.Text = "Auto-Create";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 35);
            // 
            // mnuDataMaintenanceEditData
            // 
            mnuDataMaintenanceEditData.DisplayStyle = ToolStripItemDisplayStyle.Text;
            mnuDataMaintenanceEditData.DropDownItems.AddRange(new ToolStripItem[] { editDataToolStripMenuItem });
            mnuDataMaintenanceEditData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuDataMaintenanceEditData.ImageTransparentColor = Color.Magenta;
            mnuDataMaintenanceEditData.Name = "mnuDataMaintenanceEditData";
            mnuDataMaintenanceEditData.Size = new Size(218, 32);
            mnuDataMaintenanceEditData.Text = "mnuDataMaintenance";
            // 
            // editDataToolStripMenuItem
            // 
            editDataToolStripMenuItem.Name = "editDataToolStripMenuItem";
            editDataToolStripMenuItem.Size = new Size(178, 32);
            editDataToolStripMenuItem.Text = "Edit Data";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 35);
            // 
            // mnuWindows
            // 
            mnuWindows.DisplayStyle = ToolStripItemDisplayStyle.Text;
            mnuWindows.DropDownItems.AddRange(new ToolStripItem[] { mnuWindowsTile, mnuWindowsCascade });
            mnuWindows.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuWindows.ImageTransparentColor = Color.Magenta;
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
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 35);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 32);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 556);
            Controls.Add(tsMain);
            Controls.Add(mnuMain);
            IsMdiContainer = true;
            Name = "frmMain";
            Text = "Hearty Hearth";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip mnuMain;
        private ToolStripDropDownButton mnuFile;
        private ToolStripMenuItem mnuFileDashboard;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton mnuRecipeNewRecipe;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuRecipeNew;
        private ToolStripMenuItem mnuRecipeClone;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton mnuMeals;
        private ToolStripMenuItem mnuMealsList;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton mnuCookbookAutoCreate;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuCookbooksNew;
        private ToolStripMenuItem autoCreateToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripDropDownButton mnuDataMaintenanceEditData;
        private ToolStripMenuItem editDataToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripDropDownButton mnuWindows;
        private ToolStripMenuItem mnuWindowsTile;
        private ToolStripMenuItem mnuWindowsCascade;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStrip tsMain;
        private ToolStripButton toolStripButton1;
    }
}