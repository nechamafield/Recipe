namespace RecipeWinForms
{
    partial class frmAuto_CreateCookbook
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
            lstUsersCompleteName = new ComboBox();
            btnCreateCookbook = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 259F));
            tblMain.Controls.Add(lstUsersCompleteName, 0, 0);
            tblMain.Controls.Add(btnCreateCookbook, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(668, 220);
            tblMain.TabIndex = 0;
            // 
            // lstUsersCompleteName
            // 
            lstUsersCompleteName.Anchor = AnchorStyles.None;
            lstUsersCompleteName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lstUsersCompleteName.FormattingEnabled = true;
            lstUsersCompleteName.Location = new Point(62, 92);
            lstUsersCompleteName.Name = "lstUsersCompleteName";
            lstUsersCompleteName.Size = new Size(284, 39);
            lstUsersCompleteName.TabIndex = 0;
            lstUsersCompleteName.Text = "Select a User";
            // 
            // btnCreateCookbook
            // 
            btnCreateCookbook.Anchor = AnchorStyles.Left;
            btnCreateCookbook.BackColor = SystemColors.ControlLight;
            btnCreateCookbook.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateCookbook.Location = new Point(412, 88);
            btnCreateCookbook.Name = "btnCreateCookbook";
            btnCreateCookbook.Size = new Size(205, 44);
            btnCreateCookbook.TabIndex = 1;
            btnCreateCookbook.Text = "Create Cookbook";
            btnCreateCookbook.UseVisualStyleBackColor = false;
            // 
            // frmAuto_CreateCookbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 220);
            Controls.Add(tblMain);
            Name = "frmAuto_CreateCookbook";
            Text = "frmAuto_CreateCookbook";
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstUsersCompleteName;
        private Button btnCreateCookbook;
    }
}