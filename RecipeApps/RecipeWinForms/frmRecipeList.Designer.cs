namespace RecipeWinForms
{
    partial class frmRecipeList
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
            gRecipeList = new DataGridView();
            tblMain = new TableLayoutPanel();
            btnNewRecipe = new Button();
            ((System.ComponentModel.ISupportInitialize)gRecipeList).BeginInit();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // gRecipeList
            // 
            gRecipeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipeList.Dock = DockStyle.Fill;
            gRecipeList.Location = new Point(3, 55);
            gRecipeList.Name = "gRecipeList";
            gRecipeList.RowHeadersWidth = 51;
            gRecipeList.RowTemplate.Height = 29;
            gRecipeList.Size = new Size(811, 485);
            gRecipeList.TabIndex = 0;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(gRecipeList, 0, 1);
            tblMain.Controls.Add(btnNewRecipe, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 310F));
            tblMain.Size = new Size(817, 543);
            tblMain.TabIndex = 1;
            // 
            // btnNewRecipe
            // 
            btnNewRecipe.BackColor = SystemColors.ControlLight;
            btnNewRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewRecipe.Location = new Point(3, 3);
            btnNewRecipe.Name = "btnNewRecipe";
            btnNewRecipe.Size = new Size(130, 46);
            btnNewRecipe.TabIndex = 1;
            btnNewRecipe.Text = "New Recipe";
            btnNewRecipe.UseVisualStyleBackColor = false;
            // 
            // frmRecipeList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 543);
            Controls.Add(tblMain);
            Name = "frmRecipeList";
            Text = "RecipeList";
            ((System.ComponentModel.ISupportInitialize)gRecipeList).EndInit();
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gRecipeList;
        private TableLayoutPanel tblMain;
        private Button btnNewRecipe;
    }
}