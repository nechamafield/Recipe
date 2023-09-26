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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnIngredientsSave = new Button();
            gIngredients = new DataGridView();
            tabPage2 = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnStepsSave = new Button();
            gSteps = new DataGridView();
            tblMain.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tabPage2.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 10;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(855, 373);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeName.Location = new Point(3, 40);
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
            lblCaptionCalories.Location = new Point(3, 112);
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
            txtRecipeName.Location = new Point(307, 38);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(545, 30);
            txtRecipeName.TabIndex = 2;
            // 
            // txtRecipePictureName
            // 
            txtRecipePictureName.Dock = DockStyle.Fill;
            txtRecipePictureName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipePictureName.Location = new Point(307, 74);
            txtRecipePictureName.Name = "txtRecipePictureName";
            txtRecipePictureName.Size = new Size(545, 30);
            txtRecipePictureName.TabIndex = 4;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalories.Location = new Point(307, 110);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(545, 30);
            txtCalories.TabIndex = 6;
            // 
            // lblCaptionRecipePicName
            // 
            lblCaptionRecipePicName.Anchor = AnchorStyles.Left;
            lblCaptionRecipePicName.AutoSize = true;
            lblCaptionRecipePicName.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipePicName.Location = new Point(3, 76);
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
            toolStrip1.Size = new Size(304, 35);
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
            lblUserName.Location = new Point(3, 341);
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
            lblCousineType.Location = new Point(3, 302);
            lblCousineType.Name = "lblCousineType";
            lblCousineType.Size = new Size(128, 25);
            lblCousineType.TabIndex = 13;
            lblCousineType.Text = "Cousine Type";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeStatus.Location = new Point(3, 266);
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
            lblCaptionDateArchived.Location = new Point(3, 228);
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
            lstUsername.Location = new Point(307, 337);
            lstUsername.Name = "lstUsername";
            lstUsername.Size = new Size(195, 33);
            lstUsername.TabIndex = 16;
            // 
            // lstCousineType
            // 
            lstCousineType.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstCousineType.FormattingEnabled = true;
            lstCousineType.Location = new Point(307, 298);
            lstCousineType.Name = "lstCousineType";
            lstCousineType.Size = new Size(195, 33);
            lstCousineType.TabIndex = 14;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeStatus.Location = new Point(307, 262);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(545, 30);
            txtRecipeStatus.TabIndex = 12;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Left;
            lblDatePublished.AutoSize = true;
            lblDatePublished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatePublished.Location = new Point(3, 189);
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
            lblCaptionDateDrafted.Location = new Point(3, 150);
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
            txtDatePublished.Location = new Point(307, 186);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(545, 34);
            txtDatePublished.TabIndex = 19;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Enabled = false;
            txtDateArchived.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateArchived.Location = new Point(307, 226);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(545, 30);
            txtDateArchived.TabIndex = 10;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateDrafted.Location = new Point(307, 146);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(545, 34);
            txtDateDrafted.TabIndex = 20;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(3, 383);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(852, 328);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tblIngredients);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(851, 341);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ingredients";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblIngredients.Controls.Add(btnIngredientsSave, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 75.10917F));
            tblIngredients.Size = new Size(845, 335);
            tblIngredients.TabIndex = 0;
            // 
            // btnIngredientsSave
            // 
            btnIngredientsSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnIngredientsSave.BackColor = Color.LightGray;
            btnIngredientsSave.Location = new Point(3, 3);
            btnIngredientsSave.Name = "btnIngredientsSave";
            btnIngredientsSave.Size = new Size(114, 37);
            btnIngredientsSave.TabIndex = 0;
            btnIngredientsSave.Text = "Save";
            btnIngredientsSave.UseVisualStyleBackColor = false;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 46);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.RowTemplate.Height = 29;
            gIngredients.Size = new Size(839, 286);
            gIngredients.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tblSteps);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(844, 287);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Steps";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblSteps.Controls.Add(btnStepsSave, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSteps.Size = new Size(838, 281);
            tblSteps.TabIndex = 0;
            // 
            // btnStepsSave
            // 
            btnStepsSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnStepsSave.BackColor = Color.LightGray;
            btnStepsSave.Location = new Point(3, 3);
            btnStepsSave.Name = "btnStepsSave";
            btnStepsSave.Size = new Size(114, 40);
            btnStepsSave.TabIndex = 0;
            btnStepsSave.Text = "Save";
            btnStepsSave.UseVisualStyleBackColor = false;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 49);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.RowTemplate.Height = 29;
            gSteps.Size = new Size(832, 229);
            gSteps.TabIndex = 1;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 715);
            Controls.Add(tabControl1);
            Controls.Add(tblMain);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tabPage2.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tblIngredients;
        private Button btnIngredientsSave;
        private DataGridView gIngredients;
        private TableLayoutPanel tblSteps;
        private Button btnStepsSave;
        private DataGridView gSteps;
    }
}