namespace RecipeWinForms
{
    partial class frmCookbookList
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
            gCookbookList = new DataGridView();
            tblCookbookList = new TableLayoutPanel();
            btnNewCookBook = new Button();
            ((System.ComponentModel.ISupportInitialize)gCookbookList).BeginInit();
            tblCookbookList.SuspendLayout();
            SuspendLayout();
            // 
            // gCookbookList
            // 
            gCookbookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gCookbookList.Dock = DockStyle.Fill;
            gCookbookList.Location = new Point(3, 61);
            gCookbookList.Name = "gCookbookList";
            gCookbookList.RowHeadersWidth = 51;
            gCookbookList.RowTemplate.Height = 29;
            gCookbookList.Size = new Size(836, 480);
            gCookbookList.TabIndex = 0;
            // 
            // tblCookbookList
            // 
            tblCookbookList.ColumnCount = 1;
            tblCookbookList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCookbookList.Controls.Add(gCookbookList, 0, 1);
            tblCookbookList.Controls.Add(btnNewCookBook, 0, 0);
            tblCookbookList.Dock = DockStyle.Fill;
            tblCookbookList.Location = new Point(0, 0);
            tblCookbookList.Name = "tblCookbookList";
            tblCookbookList.RowCount = 2;
            tblCookbookList.RowStyles.Add(new RowStyle());
            tblCookbookList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCookbookList.Size = new Size(842, 544);
            tblCookbookList.TabIndex = 1;
            // 
            // btnNewCookBook
            // 
            btnNewCookBook.BackColor = SystemColors.ControlLight;
            btnNewCookBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewCookBook.Location = new Point(3, 3);
            btnNewCookBook.Name = "btnNewCookBook";
            btnNewCookBook.Size = new Size(190, 52);
            btnNewCookBook.TabIndex = 1;
            btnNewCookBook.Text = "New Cookbook";
            btnNewCookBook.UseVisualStyleBackColor = false;
            // 
            // frmCookbookList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 544);
            Controls.Add(tblCookbookList);
            Name = "frmCookbookList";
            Text = "Cookbook List";
            ((System.ComponentModel.ISupportInitialize)gCookbookList).EndInit();
            tblCookbookList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gCookbookList;
        private TableLayoutPanel tblCookbookList;
        private Button btnNewCookBook;
    }
}