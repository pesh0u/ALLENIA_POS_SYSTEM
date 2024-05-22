namespace ALLENIA
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.label1 = new System.Windows.Forms.Label();
            this.adminStatusPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.userStatusRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.adminStatusRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lastnameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.midnameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstnameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitButton = new Guna.UI2.WinForms.Guna2Button();
            this.changePasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.adminStatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "EDITING A USER";
            // 
            // adminStatusPanel
            // 
            this.adminStatusPanel.BackColor = System.Drawing.Color.Transparent;
            this.adminStatusPanel.BorderRadius = 10;
            this.adminStatusPanel.Controls.Add(this.label10);
            this.adminStatusPanel.Controls.Add(this.userStatusRadio);
            this.adminStatusPanel.Controls.Add(this.adminStatusRadio);
            this.adminStatusPanel.FillColor = System.Drawing.Color.Black;
            this.adminStatusPanel.FillColor2 = System.Drawing.Color.Black;
            this.adminStatusPanel.FillColor3 = System.Drawing.Color.Black;
            this.adminStatusPanel.FillColor4 = System.Drawing.Color.Black;
            this.adminStatusPanel.ForeColor = System.Drawing.Color.White;
            this.adminStatusPanel.Location = new System.Drawing.Point(212, 221);
            this.adminStatusPanel.Name = "adminStatusPanel";
            this.adminStatusPanel.Size = new System.Drawing.Size(428, 31);
            this.adminStatusPanel.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Account Status";
            // 
            // userStatusRadio
            // 
            this.userStatusRadio.AutoSize = true;
            this.userStatusRadio.BackColor = System.Drawing.Color.Transparent;
            this.userStatusRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userStatusRadio.CheckedState.BorderThickness = 0;
            this.userStatusRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userStatusRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.userStatusRadio.CheckedState.InnerOffset = -4;
            this.userStatusRadio.Location = new System.Drawing.Point(255, 7);
            this.userStatusRadio.Name = "userStatusRadio";
            this.userStatusRadio.Size = new System.Drawing.Size(47, 17);
            this.userStatusRadio.TabIndex = 9;
            this.userStatusRadio.Text = "User";
            this.userStatusRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.userStatusRadio.UncheckedState.BorderThickness = 2;
            this.userStatusRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.userStatusRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.userStatusRadio.UseVisualStyleBackColor = false;
            // 
            // adminStatusRadio
            // 
            this.adminStatusRadio.AutoSize = true;
            this.adminStatusRadio.BackColor = System.Drawing.Color.Transparent;
            this.adminStatusRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminStatusRadio.CheckedState.BorderThickness = 0;
            this.adminStatusRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminStatusRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.adminStatusRadio.CheckedState.InnerOffset = -4;
            this.adminStatusRadio.Location = new System.Drawing.Point(324, 7);
            this.adminStatusRadio.Name = "adminStatusRadio";
            this.adminStatusRadio.Size = new System.Drawing.Size(85, 17);
            this.adminStatusRadio.TabIndex = 10;
            this.adminStatusRadio.Text = "Administrator";
            this.adminStatusRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.adminStatusRadio.UncheckedState.BorderThickness = 2;
            this.adminStatusRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.adminStatusRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.adminStatusRadio.UseVisualStyleBackColor = false;
            // 
            // lastnameTxt
            // 
            this.lastnameTxt.BorderColor = System.Drawing.SystemColors.WindowText;
            this.lastnameTxt.BorderRadius = 10;
            this.lastnameTxt.BorderThickness = 3;
            this.lastnameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastnameTxt.DefaultText = "";
            this.lastnameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastnameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastnameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastnameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastnameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastnameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastnameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastnameTxt.Location = new System.Drawing.Point(136, 171);
            this.lastnameTxt.Name = "lastnameTxt";
            this.lastnameTxt.PasswordChar = '\0';
            this.lastnameTxt.PlaceholderText = "";
            this.lastnameTxt.SelectedText = "";
            this.lastnameTxt.Size = new System.Drawing.Size(249, 25);
            this.lastnameTxt.TabIndex = 20;
            // 
            // midnameTxt
            // 
            this.midnameTxt.BorderColor = System.Drawing.SystemColors.WindowText;
            this.midnameTxt.BorderRadius = 10;
            this.midnameTxt.BorderThickness = 3;
            this.midnameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.midnameTxt.DefaultText = "";
            this.midnameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.midnameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.midnameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.midnameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.midnameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.midnameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.midnameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.midnameTxt.Location = new System.Drawing.Point(136, 131);
            this.midnameTxt.Name = "midnameTxt";
            this.midnameTxt.PasswordChar = '\0';
            this.midnameTxt.PlaceholderText = "";
            this.midnameTxt.SelectedText = "";
            this.midnameTxt.Size = new System.Drawing.Size(249, 25);
            this.midnameTxt.TabIndex = 19;
            // 
            // phoneTxt
            // 
            this.phoneTxt.BorderColor = System.Drawing.SystemColors.WindowText;
            this.phoneTxt.BorderRadius = 10;
            this.phoneTxt.BorderThickness = 3;
            this.phoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTxt.DefaultText = "";
            this.phoneTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTxt.Location = new System.Drawing.Point(535, 171);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.PasswordChar = '\0';
            this.phoneTxt.PlaceholderText = "";
            this.phoneTxt.SelectedText = "";
            this.phoneTxt.Size = new System.Drawing.Size(249, 25);
            this.phoneTxt.TabIndex = 24;
            // 
            // emailTxt
            // 
            this.emailTxt.BorderColor = System.Drawing.SystemColors.WindowText;
            this.emailTxt.BorderRadius = 10;
            this.emailTxt.BorderThickness = 3;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.DefaultText = "";
            this.emailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxt.Location = new System.Drawing.Point(535, 86);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PlaceholderText = "";
            this.emailTxt.SelectedText = "";
            this.emailTxt.Size = new System.Drawing.Size(249, 25);
            this.emailTxt.TabIndex = 21;
            // 
            // usernameTxt
            // 
            this.usernameTxt.BorderColor = System.Drawing.SystemColors.WindowText;
            this.usernameTxt.BorderRadius = 10;
            this.usernameTxt.BorderThickness = 3;
            this.usernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxt.DefaultText = "";
            this.usernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTxt.Location = new System.Drawing.Point(535, 127);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.PlaceholderText = "";
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.Size = new System.Drawing.Size(249, 25);
            this.usernameTxt.TabIndex = 23;
            // 
            // firstnameTxt
            // 
            this.firstnameTxt.BorderColor = System.Drawing.SystemColors.WindowText;
            this.firstnameTxt.BorderRadius = 10;
            this.firstnameTxt.BorderThickness = 3;
            this.firstnameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstnameTxt.DefaultText = "";
            this.firstnameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstnameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstnameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstnameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstnameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstnameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstnameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstnameTxt.Location = new System.Drawing.Point(136, 89);
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.PasswordChar = '\0';
            this.firstnameTxt.PlaceholderText = "";
            this.firstnameTxt.SelectedText = "";
            this.firstnameTxt.Size = new System.Drawing.Size(249, 25);
            this.firstnameTxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Middle name: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(432, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Phone: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "FIrst name:";
            // 
            // submitButton
            // 
            this.submitButton.BorderRadius = 15;
            this.submitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submitButton.FillColor = System.Drawing.Color.Black;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(240, 283);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(180, 38);
            this.submitButton.TabIndex = 25;
            this.submitButton.TabStop = false;
            this.submitButton.Text = "Edit";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BorderRadius = 15;
            this.changePasswordBtn.BorderThickness = 3;
            this.changePasswordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePasswordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePasswordBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changePasswordBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.changePasswordBtn.ForeColor = System.Drawing.Color.White;
            this.changePasswordBtn.Location = new System.Drawing.Point(433, 283);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(180, 38);
            this.changePasswordBtn.TabIndex = 25;
            this.changePasswordBtn.TabStop = false;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(816, 359);
            this.Controls.Add(this.adminStatusPanel);
            this.Controls.Add(this.lastnameTxt);
            this.Controls.Add(this.midnameTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.firstnameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editing a user";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.adminStatusPanel.ResumeLayout(false);
            this.adminStatusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel adminStatusPanel;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2RadioButton userStatusRadio;
        private Guna.UI2.WinForms.Guna2RadioButton adminStatusRadio;
        private Guna.UI2.WinForms.Guna2TextBox lastnameTxt;
        private Guna.UI2.WinForms.Guna2TextBox midnameTxt;
        private Guna.UI2.WinForms.Guna2TextBox phoneTxt;
        private Guna.UI2.WinForms.Guna2TextBox emailTxt;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxt;
        private Guna.UI2.WinForms.Guna2TextBox firstnameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button submitButton;
        private Guna.UI2.WinForms.Guna2Button changePasswordBtn;
    }
}