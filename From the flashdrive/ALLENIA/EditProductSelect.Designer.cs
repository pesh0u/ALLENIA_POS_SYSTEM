namespace ALLENIA
{
    partial class EditProductSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductSelect));
            this.productNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkProduct = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // productNameTxt
            // 
            this.productNameTxt.BorderColor = System.Drawing.Color.Black;
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
            this.productNameTxt.Location = new System.Drawing.Point(18, 58);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.PasswordChar = '\0';
            this.productNameTxt.PlaceholderText = "";
            this.productNameTxt.SelectedText = "";
            this.productNameTxt.Size = new System.Drawing.Size(410, 26);
            this.productNameTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter barcode:";
            // 
            // checkProduct
            // 
            this.checkProduct.BorderRadius = 10;
            this.checkProduct.BorderThickness = 3;
            this.checkProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkProduct.FillColor = System.Drawing.Color.Gray;
            this.checkProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkProduct.ForeColor = System.Drawing.Color.White;
            this.checkProduct.Location = new System.Drawing.Point(140, 99);
            this.checkProduct.Name = "checkProduct";
            this.checkProduct.Size = new System.Drawing.Size(161, 31);
            this.checkProduct.TabIndex = 5;
            this.checkProduct.Text = "Check";
            this.checkProduct.Click += new System.EventHandler(this.checkProduct_Click);
            // 
            // EditProductSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(446, 148);
            this.Controls.Add(this.checkProduct);
            this.Controls.Add(this.productNameTxt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProductSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox productNameTxt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button checkProduct;
    }
}