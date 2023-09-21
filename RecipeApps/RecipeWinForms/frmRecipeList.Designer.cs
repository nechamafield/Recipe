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
            ((System.ComponentModel.ISupportInitialize)gRecipeList).BeginInit();
            SuspendLayout();
            // 
            // gRecipeList
            // 
            gRecipeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipeList.Dock = DockStyle.Fill;
            gRecipeList.Location = new Point(0, 0);
            gRecipeList.Name = "gRecipeList";
            gRecipeList.RowHeadersWidth = 51;
            gRecipeList.RowTemplate.Height = 29;
            gRecipeList.Size = new Size(800, 450);
            gRecipeList.TabIndex = 0;
            // 
            // RecipeList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gRecipeList);
            Name = "RecipeList";
            Text = "RecipeList";
            ((System.ComponentModel.ISupportInitialize)gRecipeList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gRecipeList;
    }
}