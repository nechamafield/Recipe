namespace RecipeWinForms
{
    partial class frmDashboard
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
            lblDashboard = new Label();
            lblDashBoardWelcome = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblType = new Label();
            lblNumber = new Label();
            lblRecipes = new Label();
            lblMeals = new Label();
            lblCookbooks = new Label();
            txtRecipes = new TextBox();
            txtMeals = new TextBox();
            txtCookbooks = new TextBox();
            tblLists = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblMain.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tblLists.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblDashboard, 0, 0);
            tblMain.Controls.Add(lblDashBoardWelcome, 0, 1);
            tblMain.Controls.Add(tableLayoutPanel2, 0, 2);
            tblMain.Controls.Add(tblLists, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(3, 25, 3, 3);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(867, 612);
            tblMain.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDashboard.Location = new Point(3, 45);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(861, 41);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "Hearty Hearth Desktop App";
            lblDashboard.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblDashBoardWelcome
            // 
            lblDashBoardWelcome.AutoSize = true;
            lblDashBoardWelcome.Dock = DockStyle.Fill;
            lblDashBoardWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDashBoardWelcome.Location = new Point(100, 111);
            lblDashBoardWelcome.Margin = new Padding(100, 25, 100, 25);
            lblDashBoardWelcome.Name = "lblDashBoardWelcome";
            lblDashBoardWelcome.Size = new Size(667, 56);
            lblDashBoardWelcome.TabIndex = 2;
            lblDashBoardWelcome.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and cookbooks. You can also edit or update existing items.\r\n";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblType, 0, 0);
            tableLayoutPanel2.Controls.Add(lblNumber, 1, 0);
            tableLayoutPanel2.Controls.Add(lblRecipes, 0, 1);
            tableLayoutPanel2.Controls.Add(lblMeals, 0, 2);
            tableLayoutPanel2.Controls.Add(lblCookbooks, 0, 3);
            tableLayoutPanel2.Controls.Add(txtRecipes, 1, 1);
            tableLayoutPanel2.Controls.Add(txtMeals, 1, 2);
            tableLayoutPanel2.Controls.Add(txtCookbooks, 1, 3);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel2.Location = new Point(159, 195);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(548, 341);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BackColor = SystemColors.ActiveBorder;
            lblType.Dock = DockStyle.Fill;
            lblType.Location = new Point(3, 0);
            lblType.Margin = new Padding(3, 0, 3, 5);
            lblType.Name = "lblType";
            lblType.Size = new Size(268, 80);
            lblType.TabIndex = 0;
            lblType.Text = "Type";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BackColor = SystemColors.ActiveBorder;
            lblNumber.Dock = DockStyle.Fill;
            lblNumber.Location = new Point(277, 0);
            lblNumber.Margin = new Padding(3, 0, 3, 5);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(268, 80);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "Number";
            lblNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipes
            // 
            lblRecipes.AutoSize = true;
            lblRecipes.Dock = DockStyle.Fill;
            lblRecipes.Location = new Point(3, 90);
            lblRecipes.Margin = new Padding(3, 5, 3, 5);
            lblRecipes.Name = "lblRecipes";
            lblRecipes.Size = new Size(268, 75);
            lblRecipes.TabIndex = 2;
            lblRecipes.Text = "Recipes";
            lblRecipes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMeals
            // 
            lblMeals.AutoSize = true;
            lblMeals.Dock = DockStyle.Fill;
            lblMeals.Location = new Point(3, 175);
            lblMeals.Margin = new Padding(3, 5, 3, 5);
            lblMeals.Name = "lblMeals";
            lblMeals.Size = new Size(268, 75);
            lblMeals.TabIndex = 3;
            lblMeals.Text = "Meals";
            lblMeals.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCookbooks
            // 
            lblCookbooks.AutoSize = true;
            lblCookbooks.Dock = DockStyle.Fill;
            lblCookbooks.Location = new Point(3, 260);
            lblCookbooks.Margin = new Padding(3, 5, 3, 5);
            lblCookbooks.Name = "lblCookbooks";
            lblCookbooks.Size = new Size(268, 76);
            lblCookbooks.TabIndex = 4;
            lblCookbooks.Text = "Cookbooks";
            lblCookbooks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipes
            // 
            txtRecipes.Dock = DockStyle.Fill;
            txtRecipes.Location = new Point(277, 88);
            txtRecipes.Multiline = true;
            txtRecipes.Name = "txtRecipes";
            txtRecipes.Size = new Size(268, 79);
            txtRecipes.TabIndex = 5;
            txtRecipes.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMeals
            // 
            txtMeals.Dock = DockStyle.Fill;
            txtMeals.Location = new Point(277, 173);
            txtMeals.Multiline = true;
            txtMeals.Name = "txtMeals";
            txtMeals.Size = new Size(268, 79);
            txtMeals.TabIndex = 6;
            txtMeals.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCookbooks
            // 
            txtCookbooks.Dock = DockStyle.Fill;
            txtCookbooks.Location = new Point(277, 258);
            txtCookbooks.Multiline = true;
            txtCookbooks.Name = "txtCookbooks";
            txtCookbooks.Size = new Size(268, 80);
            txtCookbooks.TabIndex = 7;
            txtCookbooks.TextAlign = HorizontalAlignment.Center;
            // 
            // tblLists
            // 
            tblLists.Anchor = AnchorStyles.Top;
            tblLists.ColumnCount = 3;
            tblLists.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLists.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLists.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
            tblLists.Controls.Add(btnRecipeList, 0, 0);
            tblLists.Controls.Add(btnMealList, 1, 0);
            tblLists.Controls.Add(btnCookbookList, 2, 0);
            tblLists.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tblLists.Location = new Point(187, 542);
            tblLists.Name = "tblLists";
            tblLists.RowCount = 1;
            tblLists.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLists.Size = new Size(493, 67);
            tblLists.TabIndex = 4;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecipeList.Location = new Point(3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(155, 54);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.Location = new Point(164, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(155, 54);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.Location = new Point(325, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(165, 54);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 612);
            Controls.Add(tblMain);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tblLists.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tblMain;
        private Label lblDashboard;
        private Label lblDashBoardWelcome;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblType;
        private Label lblNumber;
        private Label lblRecipes;
        private Label lblMeals;
        private Label lblCookbooks;
        private TextBox txtRecipes;
        private TextBox txtMeals;
        private TextBox txtCookbooks;
        private TableLayoutPanel tblLists;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}