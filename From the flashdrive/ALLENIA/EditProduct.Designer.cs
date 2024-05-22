namespace ALLENIA
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            this.productTypePanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.nonFoodItemsRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.foodItemsRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tabascoRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.milkProductsRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.meatProductsRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.alcoholRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.fruitAndVegeteriansRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.submitButton = new Guna.UI2.WinForms.Guna2Button();
            this.productNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.barcodeTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productTypePanel
            // 
            this.productTypePanel.BackColor = System.Drawing.Color.Transparent;
            this.productTypePanel.BorderRadius = 10;
            this.productTypePanel.Controls.Add(this.nonFoodItemsRadio);
            this.productTypePanel.Controls.Add(this.foodItemsRadio);
            this.productTypePanel.Controls.Add(this.label10);
            this.productTypePanel.Controls.Add(this.tabascoRadio);
            this.productTypePanel.Controls.Add(this.milkProductsRadio);
            this.productTypePanel.Controls.Add(this.meatProductsRadio);
            this.productTypePanel.Controls.Add(this.alcoholRadio);
            this.productTypePanel.Controls.Add(this.fruitAndVegeteriansRadio);
            this.productTypePanel.FillColor = System.Drawing.Color.Black;
            this.productTypePanel.FillColor2 = System.Drawing.Color.Black;
            this.productTypePanel.FillColor3 = System.Drawing.Color.Black;
            this.productTypePanel.FillColor4 = System.Drawing.Color.Black;
            this.productTypePanel.ForeColor = System.Drawing.Color.White;
            this.productTypePanel.Location = new System.Drawing.Point(88, 192);
            this.productTypePanel.Name = "productTypePanel";
            this.productTypePanel.Size = new System.Drawing.Size(578, 89);
            this.productTypePanel.TabIndex = 26;
            // 
            // nonFoodItemsRadio
            // 
            this.nonFoodItemsRadio.AutoSize = true;
            this.nonFoodItemsRadio.BackColor = System.Drawing.Color.Transparent;
            this.nonFoodItemsRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nonFoodItemsRadio.CheckedState.BorderThickness = 0;
            this.nonFoodItemsRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nonFoodItemsRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.nonFoodItemsRadio.CheckedState.InnerOffset = -4;
            this.nonFoodItemsRadio.Location = new System.Drawing.Point(291, 61);
            this.nonFoodItemsRadio.Name = "nonFoodItemsRadio";
            this.nonFoodItemsRadio.Size = new System.Drawing.Size(100, 17);
            this.nonFoodItemsRadio.TabIndex = 11;
            this.nonFoodItemsRadio.Text = "Non-Food Items";
            this.nonFoodItemsRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nonFoodItemsRadio.UncheckedState.BorderThickness = 2;
            this.nonFoodItemsRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.nonFoodItemsRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.nonFoodItemsRadio.UseVisualStyleBackColor = false;
            // 
            // foodItemsRadio
            // 
            this.foodItemsRadio.AutoSize = true;
            this.foodItemsRadio.BackColor = System.Drawing.Color.Transparent;
            this.foodItemsRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.foodItemsRadio.CheckedState.BorderThickness = 0;
            this.foodItemsRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.foodItemsRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.foodItemsRadio.CheckedState.InnerOffset = -4;
            this.foodItemsRadio.Location = new System.Drawing.Point(196, 61);
            this.foodItemsRadio.Name = "foodItemsRadio";
            this.foodItemsRadio.Size = new System.Drawing.Size(77, 17);
            this.foodItemsRadio.TabIndex = 12;
            this.foodItemsRadio.Text = "Food Items";
            this.foodItemsRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.foodItemsRadio.UncheckedState.BorderThickness = 2;
            this.foodItemsRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.foodItemsRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.foodItemsRadio.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(236, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Product Type";
            // 
            // tabascoRadio
            // 
            this.tabascoRadio.AutoSize = true;
            this.tabascoRadio.BackColor = System.Drawing.Color.Transparent;
            this.tabascoRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tabascoRadio.CheckedState.BorderThickness = 0;
            this.tabascoRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tabascoRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tabascoRadio.CheckedState.InnerOffset = -4;
            this.tabascoRadio.Location = new System.Drawing.Point(26, 38);
            this.tabascoRadio.Name = "tabascoRadio";
            this.tabascoRadio.Size = new System.Drawing.Size(67, 17);
            this.tabascoRadio.TabIndex = 9;
            this.tabascoRadio.Text = "Tabasco";
            this.tabascoRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tabascoRadio.UncheckedState.BorderThickness = 2;
            this.tabascoRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.tabascoRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.tabascoRadio.UseVisualStyleBackColor = false;
            // 
            // milkProductsRadio
            // 
            this.milkProductsRadio.AutoSize = true;
            this.milkProductsRadio.BackColor = System.Drawing.Color.Transparent;
            this.milkProductsRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.milkProductsRadio.CheckedState.BorderThickness = 0;
            this.milkProductsRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.milkProductsRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.milkProductsRadio.CheckedState.InnerOffset = -4;
            this.milkProductsRadio.Location = new System.Drawing.Point(459, 38);
            this.milkProductsRadio.Name = "milkProductsRadio";
            this.milkProductsRadio.Size = new System.Drawing.Size(89, 17);
            this.milkProductsRadio.TabIndex = 10;
            this.milkProductsRadio.Text = "Milk Products";
            this.milkProductsRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.milkProductsRadio.UncheckedState.BorderThickness = 2;
            this.milkProductsRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.milkProductsRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.milkProductsRadio.UseVisualStyleBackColor = false;
            // 
            // meatProductsRadio
            // 
            this.meatProductsRadio.AutoSize = true;
            this.meatProductsRadio.BackColor = System.Drawing.Color.Transparent;
            this.meatProductsRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.meatProductsRadio.CheckedState.BorderThickness = 0;
            this.meatProductsRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.meatProductsRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.meatProductsRadio.CheckedState.InnerOffset = -4;
            this.meatProductsRadio.Location = new System.Drawing.Point(339, 38);
            this.meatProductsRadio.Name = "meatProductsRadio";
            this.meatProductsRadio.Size = new System.Drawing.Size(94, 17);
            this.meatProductsRadio.TabIndex = 10;
            this.meatProductsRadio.Text = "Meat Products";
            this.meatProductsRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.meatProductsRadio.UncheckedState.BorderThickness = 2;
            this.meatProductsRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.meatProductsRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.meatProductsRadio.UseVisualStyleBackColor = false;
            // 
            // alcoholRadio
            // 
            this.alcoholRadio.AutoSize = true;
            this.alcoholRadio.BackColor = System.Drawing.Color.Transparent;
            this.alcoholRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alcoholRadio.CheckedState.BorderThickness = 0;
            this.alcoholRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alcoholRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.alcoholRadio.CheckedState.InnerOffset = -4;
            this.alcoholRadio.Location = new System.Drawing.Point(258, 38);
            this.alcoholRadio.Name = "alcoholRadio";
            this.alcoholRadio.Size = new System.Drawing.Size(60, 17);
            this.alcoholRadio.TabIndex = 10;
            this.alcoholRadio.Text = "Alcohol";
            this.alcoholRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.alcoholRadio.UncheckedState.BorderThickness = 2;
            this.alcoholRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.alcoholRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.alcoholRadio.UseVisualStyleBackColor = false;
            // 
            // fruitAndVegeteriansRadio
            // 
            this.fruitAndVegeteriansRadio.AutoSize = true;
            this.fruitAndVegeteriansRadio.BackColor = System.Drawing.Color.Transparent;
            this.fruitAndVegeteriansRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fruitAndVegeteriansRadio.CheckedState.BorderThickness = 0;
            this.fruitAndVegeteriansRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fruitAndVegeteriansRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.fruitAndVegeteriansRadio.CheckedState.InnerOffset = -4;
            this.fruitAndVegeteriansRadio.Location = new System.Drawing.Point(110, 38);
            this.fruitAndVegeteriansRadio.Name = "fruitAndVegeteriansRadio";
            this.fruitAndVegeteriansRadio.Size = new System.Drawing.Size(130, 17);
            this.fruitAndVegeteriansRadio.TabIndex = 10;
            this.fruitAndVegeteriansRadio.Text = "Fruits and Vegeterians";
            this.fruitAndVegeteriansRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.fruitAndVegeteriansRadio.UncheckedState.BorderThickness = 2;
            this.fruitAndVegeteriansRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.fruitAndVegeteriansRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.fruitAndVegeteriansRadio.UseVisualStyleBackColor = false;
            // 
            // submitButton
            // 
            this.submitButton.BorderRadius = 20;
            this.submitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submitButton.FillColor = System.Drawing.Color.Black;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(280, 302);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(180, 38);
            this.submitButton.TabIndex = 27;
            this.submitButton.TabStop = false;
            this.submitButton.Text = "Submit";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // productNameTxt
            // 
            this.productNameTxt.BorderColor = System.Drawing.SystemColors.WindowText;
            this.productNameTxt.BorderRadius = 10;
            this.productNameTxt.BorderThickness = 3;
            this.productNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productNameTxt.DefaultText = "";
            this.productNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productNameTxt.Location = new System.Drawing.Point(102, 149);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.PasswordChar = '\0';
            this.productNameTxt.PlaceholderText = "";
            this.productNameTxt.SelectedText = "";
            this.productNameTxt.Size = new System.Drawing.Size(611, 25);
            this.productNameTxt.TabIndex = 25;
            // 
            // priceTxt
            // 
            this.priceTxt.BorderColor = System.Drawing.SystemColors.WindowText;
            this.priceTxt.BorderRadius = 10;
            this.priceTxt.BorderThickness = 3;
            this.priceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTxt.DefaultText = "";
            this.priceTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTxt.Location = new System.Drawing.Point(507, 102);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.PasswordChar = '\0';
            this.priceTxt.PlaceholderText = "";
            this.priceTxt.SelectedText = "";
            this.priceTxt.Size = new System.Drawing.Size(206, 25);
            this.priceTxt.TabIndex = 20;
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.BorderColor = System.Drawing.SystemColors.WindowText;
            this.barcodeTxt.BorderRadius = 10;
            this.barcodeTxt.BorderThickness = 3;
            this.barcodeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barcodeTxt.DefaultText = "";
            this.barcodeTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.barcodeTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.barcodeTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barcodeTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.barcodeTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barcodeTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.barcodeTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.barcodeTxt.Location = new System.Drawing.Point(102, 104);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.PasswordChar = '\0';
            this.barcodeTxt.PlaceholderText = "";
            this.barcodeTxt.ReadOnly = true;
            this.barcodeTxt.SelectedText = "";
            this.barcodeTxt.Size = new System.Drawing.Size(204, 25);
            this.barcodeTxt.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Price: ";
            // 
            // barcode
            // 
            this.barcode.AutoSize = true;
            this.barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode.Location = new System.Drawing.Point(24, 106);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(72, 18);
            this.barcode.TabIndex = 24;
            this.barcode.Text = "Barcode: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "EDITING A PRODUCT";
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(749, 373);
            this.Controls.Add(this.productTypePanel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.productNameTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.barcodeTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProduct";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            this.productTypePanel.ResumeLayout(false);
            this.productTypePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel productTypePanel;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2RadioButton tabascoRadio;
        private Guna.UI2.WinForms.Guna2RadioButton milkProductsRadio;
        private Guna.UI2.WinForms.Guna2RadioButton meatProductsRadio;
        private Guna.UI2.WinForms.Guna2RadioButton alcoholRadio;
        private Guna.UI2.WinForms.Guna2RadioButton fruitAndVegeteriansRadio;
        private Guna.UI2.WinForms.Guna2Button submitButton;
        private Guna.UI2.WinForms.Guna2TextBox productNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox priceTxt;
        private Guna.UI2.WinForms.Guna2TextBox barcodeTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label barcode;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton nonFoodItemsRadio;
        private Guna.UI2.WinForms.Guna2RadioButton foodItemsRadio;
    }
}