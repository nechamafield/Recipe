namespace RecipeWinForms
{
    partial class frmSearch
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.gRecipe = new System.Windows.Forms.DataGridView();
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipe)).BeginInit();
            this.tblSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.gRecipe, 0, 1);
            this.tblMain.Controls.Add(this.tblSearch, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(839, 562);
            this.tblMain.TabIndex = 0;
            // 
            // gRecipe
            // 
            this.gRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipe.Location = new System.Drawing.Point(3, 51);
            this.gRecipe.Name = "gRecipe";
            this.gRecipe.RowHeadersWidth = 51;
            this.gRecipe.RowTemplate.Height = 29;
            this.gRecipe.Size = new System.Drawing.Size(833, 508);
            this.gRecipe.TabIndex = 0;
            // 
            // tblSearch
            // 
            this.tblSearch.AutoSize = true;
            this.tblSearch.ColumnCount = 4;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSearch.Controls.Add(this.lblRecipe, 0, 0);
            this.tblSearch.Controls.Add(this.txtRecipe, 1, 0);
            this.tblSearch.Controls.Add(this.btnSearch, 2, 0);
            this.tblSearch.Controls.Add(this.btnNew, 3, 0);
            this.tblSearch.Location = new System.Drawing.Point(3, 3);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.RowCount = 1;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearch.Size = new System.Drawing.Size(456, 42);
            this.tblSearch.TabIndex = 1;
            // 
            // lblRecipe
            // 
            this.lblRecipe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecipe.Location = new System.Drawing.Point(3, 7);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(69, 28);
            this.lblRecipe.TabIndex = 0;
            this.lblRecipe.Text = "Recipe";
            this.lblRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipe
            // 
            this.txtRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipe.Location = new System.Drawing.Point(78, 3);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(141, 27);
            this.txtRecipe.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(225, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(342, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 36);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 562);
            this.Controls.Add(this.tblMain);
            this.Name = "frmSearch";
            this.Text = "Search";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipe)).EndInit();
            this.tblSearch.ResumeLayout(false);
            this.tblSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gRecipe;
        private TableLayoutPanel tblSearch;
        private Label lblRecipe;
        private TextBox txtRecipe;
        private Button btnSearch;
        private Button btnNew;
    }
}