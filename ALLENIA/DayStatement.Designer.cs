namespace ALLENIA
{
    partial class DayStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayStatement));
            this.label1 = new System.Windows.Forms.Label();
            this.timeSelect = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.checkButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientsCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalStatement = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAY STATEMENT";
            // 
            // timeSelect
            // 
            this.timeSelect.Animated = true;
            this.timeSelect.AutoRoundedCorners = true;
            this.timeSelect.BackColor = System.Drawing.Color.Transparent;
            this.timeSelect.BorderRadius = 17;
            this.timeSelect.BorderThickness = 2;
            this.timeSelect.Checked = true;
            this.timeSelect.FillColor = System.Drawing.Color.Silver;
            this.timeSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeSelect.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.timeSelect.IndicateFocus = true;
            this.timeSelect.Location = new System.Drawing.Point(32, 57);
            this.timeSelect.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeSelect.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeSelect.Name = "timeSelect";
            this.timeSelect.Size = new System.Drawing.Size(370, 36);
            this.timeSelect.TabIndex = 1;
            this.timeSelect.UseTransparentBackground = true;
            this.timeSelect.Value = new System.DateTime(2023, 4, 18, 17, 21, 24, 14);
            // 
            // checkButton
            // 
            this.checkButton.AutoRoundedCorners = true;
            this.checkButton.BorderRadius = 17;
            this.checkButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkButton.FillColor = System.Drawing.Color.Black;
            this.checkButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkButton.ForeColor = System.Drawing.Color.White;
            this.checkButton.Location = new System.Drawing.Point(148, 108);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(152, 36);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check";
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "____________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clients count: ";
            // 
            // clientsCount
            // 
            this.clientsCount.AutoRoundedCorners = true;
            this.clientsCount.BorderColor = System.Drawing.Color.Black;
            this.clientsCount.BorderRadius = 9;
            this.clientsCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientsCount.DefaultText = "";
            this.clientsCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientsCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientsCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientsCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientsCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientsCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clientsCount.ForeColor = System.Drawing.Color.Black;
            this.clientsCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientsCount.Location = new System.Drawing.Point(292, 176);
            this.clientsCount.Name = "clientsCount";
            this.clientsCount.PasswordChar = '\0';
            this.clientsCount.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientsCount.PlaceholderText = "0";
            this.clientsCount.ReadOnly = true;
            this.clientsCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientsCount.SelectedText = "";
            this.clientsCount.Size = new System.Drawing.Size(110, 20);
            this.clientsCount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Statement:";
            // 
            // totalStatement
            // 
            this.totalStatement.AutoRoundedCorners = true;
            this.totalStatement.BorderColor = System.Drawing.Color.Black;
            this.totalStatement.BorderRadius = 9;
            this.totalStatement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalStatement.DefaultText = "";
            this.totalStatement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalStatement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalStatement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalStatement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalStatement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalStatement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalStatement.ForeColor = System.Drawing.Color.Black;
            this.totalStatement.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalStatement.Location = new System.Drawing.Point(292, 215);
            this.totalStatement.Name = "totalStatement";
            this.totalStatement.PasswordChar = '\0';
            this.totalStatement.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalStatement.PlaceholderText = "0";
            this.totalStatement.ReadOnly = true;
            this.totalStatement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalStatement.SelectedText = "";
            this.totalStatement.Size = new System.Drawing.Size(110, 20);
            this.totalStatement.TabIndex = 5;
            // 
            // DayStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(434, 270);
            this.Controls.Add(this.totalStatement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.timeSelect);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DayStatement";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day Statement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeSelect;
        private Guna.UI2.WinForms.Guna2Button checkButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox clientsCount;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox totalStatement;
    }
}