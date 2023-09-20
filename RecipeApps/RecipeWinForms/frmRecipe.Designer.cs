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
            tblMain = new TableLayoutPanel();
            lblCaptionRecipeName = new Label();
            lblCaptionCalories = new Label();
            txtRecipeName = new TextBox();
            txtRecipePictureName = new TextBox();
            txtCalories = new TextBox();
            lblCaptionRecipePicName = new Label();
            toolStrip1 = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            lblUserName = new Label();
            lblCousineType = new Label();
            lblCaptionRecipeStatus = new Label();
            lblCaptionDateArchived = new Label();
            lstUsername = new ComboBox();
            lstCousineType = new ComboBox();
            txtRecipeStatus = new TextBox();
            lblDatePublished = new Label();
            lblCaptionDateDrafted = new Label();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            txtDateDrafted = new TextBox();
            tblMain.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.625F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.375F));
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 1);
            tblMain.Controls.Add(lblCaptionCalories, 0, 3);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(txtRecipePictureName, 1, 2);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(lblCaptionRecipePicName, 0, 2);
            tblMain.Controls.Add(toolStrip1, 0, 0);
            tblMain.Controls.Add(lblUserName, 0, 9);
            tblMain.Controls.Add(lblCousineType, 0, 8);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 7);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 6);
            tblMain.Controls.Add(lstUsername, 1, 9);
            tblMain.Controls.Add(lstCousineType, 1, 8);
            tblMain.Controls.Add(txtRecipeStatus, 1, 7);
            tblMain.Controls.Add(lblDatePublished, 0, 5);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 4);
            tblMain.Controls.Add(txtDatePublished, 1, 5);
            tblMain.Controls.Add(txtDateArchived, 1, 6);
            tblMain.Controls.Add(txtDateDrafted, 1, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 10;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tblMain.Size = new Size(803, 430);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeName.Location = new Point(3, 58);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(127, 25);
            lblCaptionRecipeName.TabIndex = 1;
            lblCaptionRecipeName.Text = "Recipe Name";
            lblCaptionRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCalories.Location = new Point(3, 142);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(81, 25);
            lblCaptionCalories.TabIndex = 5;
            lblCaptionCalories.Text = "Calories";
            lblCaptionCalories.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeName.Location = new Point(289, 53);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(511, 30);
            txtRecipeName.TabIndex = 2;
            // 
            // txtRecipePictureName
            // 
            txtRecipePictureName.Dock = DockStyle.Fill;
            txtRecipePictureName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipePictureName.Location = new Point(289, 95);
            txtRecipePictureName.Name = "txtRecipePictureName";
            txtRecipePictureName.Size = new Size(511, 30);
            txtRecipePictureName.TabIndex = 4;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalories.Location = new Point(289, 137);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(511, 30);
            txtCalories.TabIndex = 6;
            // 
            // lblCaptionRecipePicName
            // 
            lblCaptionRecipePicName.Anchor = AnchorStyles.Left;
            lblCaptionRecipePicName.AutoSize = true;
            lblCaptionRecipePicName.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipePicName.Location = new Point(3, 100);
            lblCaptionRecipePicName.Name = "lblCaptionRecipePicName";
            lblCaptionRecipePicName.Size = new Size(192, 25);
            lblCaptionRecipePicName.TabIndex = 3;
            lblCaptionRecipePicName.Text = "Recipe Picture Name";
            lblCaptionRecipePicName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(286, 35);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(57, 32);
            btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(72, 32);
            btnDelete.Text = "Delete";
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Left;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(3, 395);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(99, 25);
            lblUserName.TabIndex = 15;
            lblUserName.Text = "Username";
            // 
            // lblCousineType
            // 
            lblCousineType.Anchor = AnchorStyles.Left;
            lblCousineType.AutoSize = true;
            lblCousineType.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCousineType.Location = new Point(3, 352);
            lblCousineType.Name = "lblCousineType";
            lblCousineType.Size = new Size(128, 25);
            lblCousineType.TabIndex = 13;
            lblCousineType.Text = "Cousine Type";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeStatus.Location = new Point(3, 309);
            lblCaptionRecipeStatus.Margin = new Padding(3, 7, 3, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(129, 25);
            lblCaptionRecipeStatus.TabIndex = 11;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionDateArchived.Location = new Point(3, 268);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(135, 25);
            lblCaptionDateArchived.TabIndex = 9;
            lblCaptionDateArchived.Text = "Date Archived";
            lblCaptionDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstUsername
            // 
            lstUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstUsername.FormattingEnabled = true;
            lstUsername.Location = new Point(289, 389);
            lstUsername.Name = "lstUsername";
            lstUsername.Size = new Size(195, 33);
            lstUsername.TabIndex = 16;
            // 
            // lstCousineType
            // 
            lstCousineType.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstCousineType.FormattingEnabled = true;
            lstCousineType.Location = new Point(289, 347);
            lstCousineType.Name = "lstCousineType";
            lstCousineType.Size = new Size(195, 33);
            lstCousineType.TabIndex = 14;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeStatus.Location = new Point(289, 305);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(511, 30);
            txtRecipeStatus.TabIndex = 12;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Left;
            lblDatePublished.AutoSize = true;
            lblDatePublished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatePublished.Location = new Point(3, 225);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(143, 28);
            lblDatePublished.TabIndex = 17;
            lblDatePublished.Text = "Date Published";
            lblDatePublished.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Left;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionDateDrafted.Location = new Point(3, 184);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(124, 25);
            lblCaptionDateDrafted.TabIndex = 7;
            lblCaptionDateDrafted.Text = "Date Drafted";
            lblCaptionDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDatePublished.Location = new Point(289, 221);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(511, 34);
            txtDatePublished.TabIndex = 19;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Enabled = false;
            txtDateArchived.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateArchived.Location = new Point(289, 263);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(511, 30);
            txtDateArchived.TabIndex = 10;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateDrafted.Location = new Point(289, 179);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(511, 34);
            txtDateDrafted.TabIndex = 20;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 430);
            Controls.Add(tblMain);
            Name = "frmRecipe";
            Text = "frmRecipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox lstCousineType;
        private ComboBox lstUsername;
        private Label lblDatePublished;
        private DateTimePicker dtpDateDrafted;
        private DateTimePicker dtpDatePublished;
        private TextBox txtDatePublished;
        private TextBox txtDateDrafted;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
    }
}