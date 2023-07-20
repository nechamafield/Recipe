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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaptionRecipeName = new System.Windows.Forms.Label();
            this.lblCaptionRecipeStatus = new System.Windows.Forms.Label();
            this.lblCaptionDateArchived = new System.Windows.Forms.Label();
            this.lblCaptionDatePublished = new System.Windows.Forms.Label();
            this.lblCaptionDateDrafted = new System.Windows.Forms.Label();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.txtDateDrafted = new System.Windows.Forms.TextBox();
            this.txtDatePublished = new System.Windows.Forms.TextBox();
            this.txtDateArchived = new System.Windows.Forms.TextBox();
            this.txtRecipeStatus = new System.Windows.Forms.TextBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.txtRecipePicName = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lblCaptionRecipePicName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.22245F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.77755F));
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionRecipeName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionRecipeStatus, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionDateArchived, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionDatePublished, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionDateDrafted, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionCalories, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDateDrafted, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDatePublished, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDateArchived, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtRecipeStatus, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtRecipeName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRecipePicName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCalories, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCaptionRecipePicName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 298);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            this.lblCaptionRecipeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionRecipeName.AutoSize = true;
            this.lblCaptionRecipeName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionRecipeName.Location = new System.Drawing.Point(3, 5);
            this.lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            this.lblCaptionRecipeName.Size = new System.Drawing.Size(127, 25);
            this.lblCaptionRecipeName.TabIndex = 0;
            this.lblCaptionRecipeName.Text = "Recipe Name";
            this.lblCaptionRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionRecipeStatus
            // 
            this.lblCaptionRecipeStatus.AutoSize = true;
            this.lblCaptionRecipeStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionRecipeStatus.Location = new System.Drawing.Point(3, 223);
            this.lblCaptionRecipeStatus.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            this.lblCaptionRecipeStatus.Size = new System.Drawing.Size(129, 25);
            this.lblCaptionRecipeStatus.TabIndex = 5;
            this.lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblCaptionDateArchived
            // 
            this.lblCaptionDateArchived.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDateArchived.AutoSize = true;
            this.lblCaptionDateArchived.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionDateArchived.Location = new System.Drawing.Point(3, 185);
            this.lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            this.lblCaptionDateArchived.Size = new System.Drawing.Size(135, 25);
            this.lblCaptionDateArchived.TabIndex = 4;
            this.lblCaptionDateArchived.Text = "Date Archived";
            this.lblCaptionDateArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionDatePublished
            // 
            this.lblCaptionDatePublished.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDatePublished.AutoSize = true;
            this.lblCaptionDatePublished.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionDatePublished.Location = new System.Drawing.Point(3, 149);
            this.lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            this.lblCaptionDatePublished.Size = new System.Drawing.Size(143, 25);
            this.lblCaptionDatePublished.TabIndex = 3;
            this.lblCaptionDatePublished.Text = "Date Published";
            this.lblCaptionDatePublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionDateDrafted
            // 
            this.lblCaptionDateDrafted.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDateDrafted.AutoSize = true;
            this.lblCaptionDateDrafted.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionDateDrafted.Location = new System.Drawing.Point(3, 113);
            this.lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            this.lblCaptionDateDrafted.Size = new System.Drawing.Size(124, 25);
            this.lblCaptionDateDrafted.TabIndex = 2;
            this.lblCaptionDateDrafted.Text = "Date Drafted";
            this.lblCaptionDateDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptionCalories
            // 
            this.lblCaptionCalories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCalories.AutoSize = true;
            this.lblCaptionCalories.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionCalories.Location = new System.Drawing.Point(3, 77);
            this.lblCaptionCalories.Name = "lblCaptionCalories";
            this.lblCaptionCalories.Size = new System.Drawing.Size(81, 25);
            this.lblCaptionCalories.TabIndex = 1;
            this.lblCaptionCalories.Text = "Calories";
            this.lblCaptionCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDateDrafted
            // 
            this.txtDateDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateDrafted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateDrafted.Location = new System.Drawing.Point(220, 111);
            this.txtDateDrafted.Name = "txtDateDrafted";
            this.txtDateDrafted.Size = new System.Drawing.Size(855, 30);
            this.txtDateDrafted.TabIndex = 10;
            // 
            // txtDatePublished
            // 
            this.txtDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatePublished.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDatePublished.Location = new System.Drawing.Point(220, 147);
            this.txtDatePublished.Name = "txtDatePublished";
            this.txtDatePublished.Size = new System.Drawing.Size(855, 30);
            this.txtDatePublished.TabIndex = 11;
            // 
            // txtDateArchived
            // 
            this.txtDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateArchived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateArchived.Location = new System.Drawing.Point(220, 183);
            this.txtDateArchived.Name = "txtDateArchived";
            this.txtDateArchived.Size = new System.Drawing.Size(855, 30);
            this.txtDateArchived.TabIndex = 12;
            // 
            // txtRecipeStatus
            // 
            this.txtRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeStatus.Location = new System.Drawing.Point(220, 219);
            this.txtRecipeStatus.Name = "txtRecipeStatus";
            this.txtRecipeStatus.Size = new System.Drawing.Size(855, 30);
            this.txtRecipeStatus.TabIndex = 13;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipeName.Location = new System.Drawing.Point(220, 3);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(855, 30);
            this.txtRecipeName.TabIndex = 14;
            // 
            // txtRecipePicName
            // 
            this.txtRecipePicName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipePicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecipePicName.Location = new System.Drawing.Point(220, 39);
            this.txtRecipePicName.Name = "txtRecipePicName";
            this.txtRecipePicName.Size = new System.Drawing.Size(855, 30);
            this.txtRecipePicName.TabIndex = 15;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalories.Location = new System.Drawing.Point(220, 75);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(855, 30);
            this.txtCalories.TabIndex = 16;
            // 
            // lblCaptionRecipePicName
            // 
            this.lblCaptionRecipePicName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionRecipePicName.AutoSize = true;
            this.lblCaptionRecipePicName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionRecipePicName.Location = new System.Drawing.Point(3, 41);
            this.lblCaptionRecipePicName.Name = "lblCaptionRecipePicName";
            this.lblCaptionRecipePicName.Size = new System.Drawing.Size(192, 25);
            this.lblCaptionRecipePicName.TabIndex = 6;
            this.lblCaptionRecipePicName.Text = "Recipe Picture Name";
            this.lblCaptionRecipePicName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 298);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmRecipe";
            this.Text = "frmRecipe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCaptionRecipeName;
        private Label lblCaptionRecipeStatus;
        private Label lblCaptionDateArchived;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionCalories;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtRecipeStatus;
        private TextBox txtRecipeName;
        private TextBox txtRecipePicName;
        private TextBox txtCalories;
        private Label lblCaptionRecipePicName;
    }
}