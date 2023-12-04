namespace RecipeWinForms
{
    partial class frmNewCookbook
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
            tblMain = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            lblCookbookName = new Label();
            lblUser = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            txtCookbookName = new TextBox();
            lstUsersCompleteName = new ComboBox();
            tblPrice = new TableLayoutPanel();
            txtPrice = new TextBox();
            txtDateCreated = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblDateCreated = new Label();
            chkIsActive = new CheckBox();
            tblRecipe = new TableLayoutPanel();
            btnSaveRecipe = new Button();
            gRecipe = new DataGridView();
            tblMain.SuspendLayout();
            tblPrice.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tblRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 574F));
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(lblCookbookName, 0, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lblPrice, 0, 4);
            tblMain.Controls.Add(lblActive, 0, 5);
            tblMain.Controls.Add(txtCookbookName, 1, 1);
            tblMain.Controls.Add(lstUsersCompleteName, 1, 2);
            tblMain.Controls.Add(tblPrice, 1, 4);
            tblMain.Controls.Add(tableLayoutPanel1, 1, 3);
            tblMain.Controls.Add(chkIsActive, 1, 5);
            tblMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(2, 2);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(789, 270);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlLight;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 48);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLight;
            btnDelete.Location = new Point(218, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 48);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblCookbookName
            // 
            lblCookbookName.Anchor = AnchorStyles.Left;
            lblCookbookName.AutoSize = true;
            lblCookbookName.Location = new Point(3, 60);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(161, 28);
            lblCookbookName.TabIndex = 2;
            lblCookbookName.Text = "Cookbook Name";
            lblCookbookName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 101);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 28);
            lblUser.TabIndex = 3;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 187);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(54, 28);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblActive
            // 
            lblActive.Anchor = AnchorStyles.Left;
            lblActive.AutoSize = true;
            lblActive.Location = new Point(3, 234);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(66, 28);
            lblActive.TabIndex = 5;
            lblActive.Text = "Active";
            lblActive.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCookbookName
            // 
            txtCookbookName.Dock = DockStyle.Fill;
            txtCookbookName.Location = new Point(218, 57);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(568, 34);
            txtCookbookName.TabIndex = 6;
            // 
            // lstUsersCompleteName
            // 
            lstUsersCompleteName.FormattingEnabled = true;
            lstUsersCompleteName.Location = new Point(218, 97);
            lstUsersCompleteName.Name = "lstUsersCompleteName";
            lstUsersCompleteName.Size = new Size(203, 36);
            lstUsersCompleteName.TabIndex = 7;
            // 
            // tblPrice
            // 
            tblPrice.ColumnCount = 2;
            tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPrice.Controls.Add(txtPrice, 0, 0);
            tblPrice.Controls.Add(txtDateCreated, 1, 0);
            tblPrice.Dock = DockStyle.Fill;
            tblPrice.Location = new Point(218, 178);
            tblPrice.Name = "tblPrice";
            tblPrice.RowCount = 1;
            tblPrice.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPrice.Size = new Size(568, 46);
            tblPrice.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(3, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(182, 34);
            txtPrice.TabIndex = 9;
            // 
            // txtDateCreated
            // 
            txtDateCreated.Location = new Point(287, 3);
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.Size = new Size(162, 34);
            txtDateCreated.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblDateCreated, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(218, 139);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(568, 33);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // lblDateCreated
            // 
            lblDateCreated.Anchor = AnchorStyles.Left;
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(287, 2);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(130, 28);
            lblDateCreated.TabIndex = 11;
            lblDateCreated.Text = "Date Created:";
            lblDateCreated.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkIsActive
            // 
            chkIsActive.Anchor = AnchorStyles.Left;
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(218, 240);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(18, 17);
            chkIsActive.TabIndex = 13;
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // tblRecipe
            // 
            tblRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblRecipe.ColumnCount = 1;
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipe.Controls.Add(btnSaveRecipe, 0, 0);
            tblRecipe.Controls.Add(gRecipe, 0, 1);
            tblRecipe.Location = new Point(2, 360);
            tblRecipe.Name = "tblRecipe";
            tblRecipe.RowCount = 2;
            tblRecipe.RowStyles.Add(new RowStyle());
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 78.65613F));
            tblRecipe.Size = new Size(789, 345);
            tblRecipe.TabIndex = 1;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.BackColor = SystemColors.ControlLight;
            btnSaveRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveRecipe.Location = new Point(3, 3);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(128, 45);
            btnSaveRecipe.TabIndex = 0;
            btnSaveRecipe.Text = "Save";
            btnSaveRecipe.UseVisualStyleBackColor = false;
            // 
            // gRecipe
            // 
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(3, 54);
            gRecipe.Name = "gRecipe";
            gRecipe.RowHeadersWidth = 51;
            gRecipe.RowTemplate.Height = 29;
            gRecipe.Size = new Size(783, 288);
            gRecipe.TabIndex = 1;
            // 
            // frmNewCookbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 699);
            Controls.Add(tblRecipe);
            Controls.Add(tblMain);
            Name = "frmNewCookbook";
            Text = "NewCookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblPrice.ResumeLayout(false);
            tblPrice.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tblRecipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private Label lblCookbookName;
        private Label lblUser;
        private Label lblPrice;
        private Label lblActive;
        private Button btnDelete;
        private TextBox txtCookbookName;
        private ComboBox lstUsersCompleteName;
        private TableLayoutPanel tblPrice;
        private TextBox txtPrice;
        private TextBox txtDateCreated;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDateCreated;
        private CheckBox chkIsActive;
        private TableLayoutPanel tblRecipe;
        private Button btnSaveRecipe;
        private DataGridView gRecipe;
    }
}