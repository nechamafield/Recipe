namespace RecipeWinForms
{
    partial class frmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaptionRecipeName = new System.Windows.Forms.Label();
            this.lblCaptionRecipeStatus = new System.Windows.Forms.Label();
            this.lblCaptionDateArchived = new System.Windows.Forms.Label();
            this.lblCaptionDateDrafted = new System.Windows.Forms.Label();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.txtDateArchived = new System.Windows.Forms.TextBox();
            this.txtRecipeStatus = new System.Windows.Forms.TextBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.txtRecipePictureName = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lblCaptionRecipePicName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCousineType = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.lstCousineType = new System.Windows.Forms.ComboBox();
            this.lstUsername = new System.Windows.Forms.ComboBox();
            this.lblDateDrafted = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.625F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.375F));
            this.tblMain.Controls.Add(this.lblCaptionRecipeName, 0, 1);
            this.tblMain.Controls.Add(this.lblCaptionDateDrafted, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionCalories, 0, 3);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 1);
            this.tblMain.Controls.Add(this.txtRecipePictureName, 1, 2);
            this.tblMain.Controls.Add(this.txtCalories, 1, 3);
            this.tblMain.Controls.Add(this.lblCaptionRecipePicName, 0, 2);
            this.tblMain.Controls.Add(this.toolStrip1, 0, 0);
            this.tblMain.Controls.Add(this.lblCaptionDateArchived, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionRecipeStatus, 0, 6);
            this.tblMain.Controls.Add(this.lblCousineType, 0, 7);
            this.tblMain.Controls.Add(this.lblUserName, 0, 8);
            this.tblMain.Controls.Add(this.txtDateArchived, 1, 5);
            this.tblMain.Controls.Add(this.txtRecipeStatus, 1, 6);
            this.tblMain.Controls.Add(this.lstCousineType, 1, 7);
            this.tblMain.Controls.Add(this.lstUsername, 1, 8);
            this.tblMain.Controls.Add(this.lblDateDrafted, 1, 4);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 10;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMain.Size = new System.Drawing.Size(803, 430);
            this.tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            this.lblCaptionRecipeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionRecipeName.AutoSize = true;
            this.lblCaptionRecipeName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionRecipeName.Location = new System.Drawing.Point(3, 58);
            this.lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            this.lblCaptionRecipeName.Size = new System.Drawing.Size(127, 25);
            this.lblCaptionRecipeName.TabIndex = 1;
            this.lblCaptionRecipeName.Text = "Recipe Name";
            this.lblCaptionRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionRecipeStatus
            // 
            this.lblCaptionRecipeStatus.AutoSize = true;
            this.lblCaptionRecipeStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionRecipeStatus.Location = new System.Drawing.Point(3, 267);
            this.lblCaptionRecipeStatus.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            this.lblCaptionRecipeStatus.Size = new System.Drawing.Size(129, 25);
            this.lblCaptionRecipeStatus.TabIndex = 13;
            this.lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblCaptionDateArchived
            // 
            this.lblCaptionDateArchived.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDateArchived.AutoSize = true;
            this.lblCaptionDateArchived.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionDateArchived.Location = new System.Drawing.Point(3, 226);
            this.lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            this.lblCaptionDateArchived.Size = new System.Drawing.Size(135, 25);
            this.lblCaptionDateArchived.TabIndex = 11;
            this.lblCaptionDateArchived.Text = "Date Archived";
            this.lblCaptionDateArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionDateDrafted
            // 
            this.lblCaptionDateDrafted.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDateDrafted.AutoSize = true;
            this.lblCaptionDateDrafted.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionDateDrafted.Location = new System.Drawing.Point(3, 184);
            this.lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            this.lblCaptionDateDrafted.Size = new System.Drawing.Size(124, 25);
            this.lblCaptionDateDrafted.TabIndex = 7;
            this.lblCaptionDateDrafted.Text = "Date Drafted";
            this.lblCaptionDateDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionCalories
            // 
            this.lblCaptionCalories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCalories.AutoSize = true;
            this.lblCaptionCalories.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionCalories.Location = new System.Drawing.Point(3, 142);
            this.lblCaptionCalories.Name = "lblCaptionCalories";
            this.lblCaptionCalories.Size = new System.Drawing.Size(81, 25);
            this.lblCaptionCalories.TabIndex = 5;
            this.lblCaptionCalories.Text = "Calories";
            this.lblCaptionCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDateArchived
            // 
            this.txtDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateArchived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateArchived.Location = new System.Drawing.Point(289, 221);
            this.txtDateArchived.Name = "txtDateArchived";
            this.txtDateArchived.Size = new System.Drawing.Size(511, 30);
            this.txtDateArchived.TabIndex = 12;
            // 
            // txtRecipeStatus
            // 
            this.txtRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeStatus.Location = new System.Drawing.Point(289, 263);
            this.txtRecipeStatus.Name = "txtRecipeStatus";
            this.txtRecipeStatus.Size = new System.Drawing.Size(511, 30);
            this.txtRecipeStatus.TabIndex = 14;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeName.Location = new System.Drawing.Point(289, 53);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(511, 30);
            this.txtRecipeName.TabIndex = 2;
            // 
            // txtRecipePictureName
            // 
            this.txtRecipePictureName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipePictureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipePictureName.Location = new System.Drawing.Point(289, 95);
            this.txtRecipePictureName.Name = "txtRecipePictureName";
            this.txtRecipePictureName.Size = new System.Drawing.Size(511, 30);
            this.txtRecipePictureName.TabIndex = 4;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalories.Location = new System.Drawing.Point(289, 137);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(511, 30);
            this.txtCalories.TabIndex = 6;
            // 
            // lblCaptionRecipePicName
            // 
            this.lblCaptionRecipePicName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionRecipePicName.AutoSize = true;
            this.lblCaptionRecipePicName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionRecipePicName.Location = new System.Drawing.Point(3, 100);
            this.lblCaptionRecipePicName.Name = "lblCaptionRecipePicName";
            this.lblCaptionRecipePicName.Size = new System.Drawing.Size(192, 25);
            this.lblCaptionRecipePicName.TabIndex = 3;
            this.lblCaptionRecipePicName.Text = "Recipe Picture Name";
            this.lblCaptionRecipePicName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(3, 352);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 25);
            this.lblUserName.TabIndex = 17;
            this.lblUserName.Text = "Username";
            // 
            // lblCousineType
            // 
            this.lblCousineType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCousineType.AutoSize = true;
            this.lblCousineType.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCousineType.Location = new System.Drawing.Point(3, 310);
            this.lblCousineType.Name = "lblCousineType";
            this.lblCousineType.Size = new System.Drawing.Size(128, 25);
            this.lblCousineType.TabIndex = 15;
            this.lblCousineType.Text = "Cousine Type";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(286, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 32);
            this.btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 32);
            this.btnDelete.Text = "Delete";
            // 
            // lstCousineType
            // 
            this.lstCousineType.FormattingEnabled = true;
            this.lstCousineType.Location = new System.Drawing.Point(289, 305);
            this.lstCousineType.Name = "lstCousineType";
            this.lstCousineType.Size = new System.Drawing.Size(195, 28);
            this.lstCousineType.TabIndex = 16;
            // 
            // lstUsername
            // 
            this.lstUsername.FormattingEnabled = true;
            this.lstUsername.Location = new System.Drawing.Point(289, 347);
            this.lstUsername.Name = "lstUsername";
            this.lstUsername.Size = new System.Drawing.Size(195, 28);
            this.lstUsername.TabIndex = 18;
            // 
            // lblDateDrafted
            // 
            this.lblDateDrafted.AutoSize = true;
            this.lblDateDrafted.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDateDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateDrafted.Location = new System.Drawing.Point(289, 176);
            this.lblDateDrafted.Name = "lblDateDrafted";
            this.lblDateDrafted.Size = new System.Drawing.Size(511, 42);
            this.lblDateDrafted.TabIndex = 19;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 430);
            this.Controls.Add(this.tblMain);
            this.Name = "frmRecipe";
            this.Text = "frmRecipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionRecipeStatus;
        private Label lblCaptionDateArchived;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionCalories;
        private TextBox txtDateArchived;
        private TextBox txtRecipeStatus;
        private TextBox txtRecipeName;
        private TextBox txtRecipePictureName;
        private TextBox txtCalories;
        private Label lblCaptionRecipePicName;
        private Label lblUserName;
        private Label lblCousineType;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ComboBox lstCousineType;
        private ComboBox lstUsername;
        private Label lblDateDrafted;
    }
}