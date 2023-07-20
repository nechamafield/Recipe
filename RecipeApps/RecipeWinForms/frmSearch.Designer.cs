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
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gRecipe = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            this.tblSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.tblSearch, 0, 0);
            this.tblMain.Controls.Add(this.gRecipe, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.911392F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.08861F));
            this.tblMain.Size = new System.Drawing.Size(871, 664);
            this.tblMain.TabIndex = 0;
            // 
            // tblSearch
            // 
            this.tblSearch.ColumnCount = 3;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.15748F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.84252F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tblSearch.Controls.Add(this.lblRecipe, 0, 0);
            this.tblSearch.Controls.Add(this.txtRecipe, 1, 0);
            this.tblSearch.Controls.Add(this.btnSearch, 2, 0);
            this.tblSearch.Location = new System.Drawing.Point(3, 3);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.RowCount = 1;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSearch.Size = new System.Drawing.Size(545, 46);
            this.tblSearch.TabIndex = 0;
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecipe.Location = new System.Drawing.Point(3, 0);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(154, 46);
            this.lblRecipe.TabIndex = 0;
            this.lblRecipe.Text = "Recipe";
            this.lblRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecipe
            // 
            this.txtRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipe.Location = new System.Drawing.Point(163, 3);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(232, 34);
            this.txtRecipe.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(401, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // gRecipe
            // 
            this.gRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipe.Location = new System.Drawing.Point(3, 55);
            this.gRecipe.Name = "gRecipe";
            this.gRecipe.RowHeadersWidth = 51;
            this.gRecipe.RowTemplate.Height = 29;
            this.gRecipe.Size = new System.Drawing.Size(865, 606);
            this.gRecipe.TabIndex = 1;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 664);
            this.Controls.Add(this.tblMain);
            this.Name = "frmSearch";
            this.Text = "Recipe";
            this.tblMain.ResumeLayout(false);
            this.tblSearch.ResumeLayout(false);
            this.tblSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblSearch;
        private Label lblRecipe;
        private TextBox txtRecipe;
        private Button btnSearch;
        private DataGridView gRecipe;
    }
}