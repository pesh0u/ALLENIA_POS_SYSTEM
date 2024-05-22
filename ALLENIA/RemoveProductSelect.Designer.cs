namespace ALLENIA
{
    partial class RemoveProductSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveProductSelect));
            this.checkBarcode = new Guna.UI2.WinForms.Guna2Button();
            this.barcodeTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBarcode
            // 
            this.checkBarcode.BorderRadius = 10;
            this.checkBarcode.BorderThickness = 3;
            this.checkBarcode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkBarcode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkBarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkBarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkBarcode.FillColor = System.Drawing.Color.Black;
            this.checkBarcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBarcode.ForeColor = System.Drawing.Color.White;
            this.checkBarcode.Location = new System.Drawing.Point(156, 97);
            this.checkBarcode.Name = "checkBarcode";
            this.checkBarcode.Size = new System.Drawing.Size(161, 31);
            this.checkBarcode.TabIndex = 8;
            this.checkBarcode.Text = "Check";
            this.checkBarcode.Click += new System.EventHandler(this.checkBarcode_Click);
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.BorderColor = System.Drawing.Color.Black;
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
            this.barcodeTxt.Location = new System.Drawing.Point(21, 56);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.PasswordChar = '\0';
            this.barcodeTxt.PlaceholderText = "";
            this.barcodeTxt.SelectedText = "";
            this.barcodeTxt.Size = new System.Drawing.Size(410, 26);
            this.barcodeTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter product:";
            // 
            // RemoveProductSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(452, 142);
            this.Controls.Add(this.checkBarcode);
            this.Controls.Add(this.barcodeTxt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveProductSelect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button checkBarcode;
        private Guna.UI2.WinForms.Guna2TextBox barcodeTxt;
        private System.Windows.Forms.Label label1;
    }
}