namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            lblRecipeName = new Label();
            lblCurrrentStatus = new Label();
            txtArchived = new TextBox();
            txtPublished = new TextBox();
            txtDrafted = new TextBox();
            lblStatusDates = new Label();
            lblArchived = new Label();
            lblPublished = new Label();
            lblDrafted = new Label();
            tblDates = new TableLayoutPanel();
            tblButtons = new TableLayoutPanel();
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            tblMain.SuspendLayout();
            tblDates.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblRecipeName, 0, 1);
            tblMain.Controls.Add(lblCurrrentStatus, 0, 2);
            tblMain.Controls.Add(tblDates, 0, 3);
            tblMain.Controls.Add(tblButtons, 0, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.Size = new Size(738, 552);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Rockwell", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(3, 20);
            lblRecipeName.Margin = new Padding(3, 20, 3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(732, 42);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "label";
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrrentStatus
            // 
            lblCurrrentStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrrentStatus.AutoSize = true;
            lblCurrrentStatus.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrrentStatus.Location = new Point(3, 158);
            lblCurrrentStatus.Margin = new Padding(3, 20, 3, 0);
            lblCurrrentStatus.Name = "lblCurrrentStatus";
            lblCurrrentStatus.Size = new Size(732, 38);
            lblCurrrentStatus.TabIndex = 1;
            lblCurrrentStatus.Text = "Current Status: ";
            lblCurrrentStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtArchived
            // 
            txtArchived.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtArchived.Location = new Point(564, 57);
            txtArchived.Margin = new Padding(15, 25, 3, 3);
            txtArchived.Name = "txtArchived";
            txtArchived.Size = new Size(154, 34);
            txtArchived.TabIndex = 6;
            // 
            // txtPublished
            // 
            txtPublished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPublished.Location = new Point(381, 57);
            txtPublished.Margin = new Padding(15, 25, 3, 3);
            txtPublished.Name = "txtPublished";
            txtPublished.Size = new Size(154, 34);
            txtPublished.TabIndex = 5;
            // 
            // txtDrafted
            // 
            txtDrafted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDrafted.Location = new Point(198, 57);
            txtDrafted.Margin = new Padding(15, 25, 3, 3);
            txtDrafted.Name = "txtDrafted";
            txtDrafted.Size = new Size(154, 34);
            txtDrafted.TabIndex = 4;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusDates.Location = new Point(3, 57);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(177, 28);
            lblStatusDates.TabIndex = 3;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblArchived.AutoSize = true;
            lblArchived.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblArchived.Location = new Point(552, 2);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(177, 28);
            lblArchived.TabIndex = 2;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPublished.AutoSize = true;
            lblPublished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPublished.Location = new Point(369, 2);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(177, 28);
            lblPublished.TabIndex = 1;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDrafted.AutoSize = true;
            lblDrafted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrafted.Location = new Point(186, 2);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(177, 28);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblDates
            // 
            tblDates.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tblDates.ColumnCount = 4;
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.Controls.Add(lblDrafted, 1, 0);
            tblDates.Controls.Add(lblPublished, 2, 0);
            tblDates.Controls.Add(lblArchived, 3, 0);
            tblDates.Controls.Add(lblStatusDates, 0, 1);
            tblDates.Controls.Add(txtDrafted, 1, 1);
            tblDates.Controls.Add(txtPublished, 2, 1);
            tblDates.Controls.Add(txtArchived, 3, 1);
            tblDates.Location = new Point(3, 279);
            tblDates.Name = "tblDates";
            tblDates.RowCount = 2;
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 28.985508F));
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 71.0144958F));
            tblDates.Size = new Size(732, 111);
            tblDates.TabIndex = 2;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 246F));
            tblButtons.Controls.Add(btnDraft, 0, 0);
            tblButtons.Controls.Add(btnPublish, 1, 0);
            tblButtons.Controls.Add(btnArchive, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 417);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblButtons.Size = new Size(732, 132);
            tblButtons.TabIndex = 3;
            // 
            // btnDraft
            // 
            btnDraft.Anchor = AnchorStyles.None;
            btnDraft.BackColor = SystemColors.ControlLight;
            btnDraft.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDraft.Location = new Point(61, 43);
            btnDraft.Margin = new Padding(3, 10, 3, 3);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(120, 52);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = false;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.None;
            btnPublish.BackColor = SystemColors.ControlLight;
            btnPublish.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPublish.Location = new Point(304, 43);
            btnPublish.Margin = new Padding(3, 10, 3, 3);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(120, 52);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = false;
            // 
            // btnArchive
            // 
            btnArchive.Anchor = AnchorStyles.None;
            btnArchive.BackColor = SystemColors.ControlLight;
            btnArchive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnArchive.Location = new Point(549, 43);
            btnArchive.Margin = new Padding(3, 10, 3, 3);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(120, 52);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = false;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 552);
            Controls.Add(tblMain);
            Name = "frmChangeStatus";
            Text = "Recipe - Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblDates.ResumeLayout(false);
            tblDates.PerformLayout();
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblCurrrentStatus;
        private TableLayoutPanel tblDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblStatusDates;
        private TextBox txtDrafted;
        private TextBox txtPublished;
        private TextBox txtArchived;
        private TableLayoutPanel tblButtons;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
    }
}