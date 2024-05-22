namespace ALLENIA
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.usernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.instructionText = new System.Windows.Forms.Label();
            this.giflogo = new System.Windows.Forms.PictureBox();
            this.loginLogo = new System.Windows.Forms.PictureBox();
            this.createrMark = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giflogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Image = global::ALLENIA.Properties.Resources.image;
            this.exitBtn.Location = new System.Drawing.Point(370, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(20, 20);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBtn.TabIndex = 0;
            this.exitBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.exitBtn, "Close");
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Animated = true;
            this.usernameTxt.AutoRoundedCorners = true;
            this.usernameTxt.BorderColor = System.Drawing.Color.DarkViolet;
            this.usernameTxt.BorderRadius = 13;
            this.usernameTxt.BorderThickness = 2;
            this.usernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxt.DefaultText = "";
            this.usernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.FillColor = System.Drawing.Color.Black;
            this.usernameTxt.FocusedState.BorderColor = System.Drawing.Color.Violet;
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTxt.HoverState.BorderColor = System.Drawing.Color.Violet;
            this.usernameTxt.Location = new System.Drawing.Point(31, 316);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.PlaceholderText = "Username";
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.Size = new System.Drawing.Size(344, 29);
            this.usernameTxt.TabIndex = 3;
            this.usernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Animated = true;
            this.passwordTxt.AutoRoundedCorners = true;
            this.passwordTxt.BorderColor = System.Drawing.Color.DarkViolet;
            this.passwordTxt.BorderRadius = 13;
            this.passwordTxt.BorderThickness = 2;
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.DefaultText = "";
            this.passwordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.FillColor = System.Drawing.Color.Black;
            this.passwordTxt.FocusedState.BorderColor = System.Drawing.Color.Violet;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTxt.HoverState.BorderColor = System.Drawing.Color.Violet;
            this.passwordTxt.Location = new System.Drawing.Point(31, 351);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '●';
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.Size = new System.Drawing.Size(344, 29);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Animated = true;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BorderColor = System.Drawing.Color.Blue;
            this.loginBtn.BorderRadius = 13;
            this.loginBtn.BorderThickness = 3;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.FillColor = System.Drawing.SystemColors.ControlText;
            this.loginBtn.FocusedColor = System.Drawing.Color.Blue;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.loginBtn.Location = new System.Drawing.Point(88, 409);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(231, 31);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.TabStop = false;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseTransparentBackground = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // instructionText
            // 
            this.instructionText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionText.Location = new System.Drawing.Point(-1, 270);
            this.instructionText.Name = "instructionText";
            this.instructionText.Size = new System.Drawing.Size(413, 18);
            this.instructionText.TabIndex = 5;
            this.instructionText.Text = "Please enter in your account";
            this.instructionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // giflogo
            // 
            this.giflogo.Image = global::ALLENIA.Properties.Resources._500_fingerprint_security_gradient;
            this.giflogo.Location = new System.Drawing.Point(155, 155);
            this.giflogo.Name = "giflogo";
            this.giflogo.Size = new System.Drawing.Size(96, 94);
            this.giflogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.giflogo.TabIndex = 2;
            this.giflogo.TabStop = false;
            // 
            // loginLogo
            // 
            this.loginLogo.Image = global::ALLENIA.Properties.Resources.template;
            this.loginLogo.Location = new System.Drawing.Point(-71, 34);
            this.loginLogo.Name = "loginLogo";
            this.loginLogo.Size = new System.Drawing.Size(557, 138);
            this.loginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginLogo.TabIndex = 1;
            this.loginLogo.TabStop = false;
            // 
            // createrMark
            // 
            this.createrMark.BackColor = System.Drawing.Color.Transparent;
            this.createrMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createrMark.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createrMark.Location = new System.Drawing.Point(132, 502);
            this.createrMark.Name = "createrMark";
            this.createrMark.Size = new System.Drawing.Size(143, 17);
            this.createrMark.TabIndex = 6;
            this.createrMark.TabStop = false;
            this.createrMark.Text = "Created by Peter Stefanov\r\n\r\n";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(406, 531);
            this.Controls.Add(this.createrMark);
            this.Controls.Add(this.instructionText);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.giflogo);
            this.Controls.Add(this.loginLogo);
            this.Controls.Add(this.exitBtn);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giflogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox loginLogo;
        private System.Windows.Forms.PictureBox giflogo;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxt;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxt;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private System.Windows.Forms.Label instructionText;
        private Guna.UI2.WinForms.Guna2HtmlLabel createrMark;
    }
}