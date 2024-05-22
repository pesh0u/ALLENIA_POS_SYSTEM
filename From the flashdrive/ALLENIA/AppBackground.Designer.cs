namespace ALLENIA
{
    partial class AppBackground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBackground));
            this.errorPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.errorMsg = new System.Windows.Forms.Label();
            this.errorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorPanel
            // 
            this.errorPanel.BackColor = System.Drawing.Color.Transparent;
            this.errorPanel.BorderColor = System.Drawing.Color.Red;
            this.errorPanel.BorderRadius = 10;
            this.errorPanel.BorderThickness = 4;
            this.errorPanel.Controls.Add(this.errorMsg);
            this.errorPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.errorPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.errorPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.errorPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.errorPanel.Location = new System.Drawing.Point(12, 22);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(1896, 79);
            this.errorPanel.TabIndex = 1;
            this.errorPanel.Visible = false;
            // 
            // errorMsg
            // 
            this.errorMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.Location = new System.Drawing.Point(22, 0);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(1855, 79);
            this.errorMsg.TabIndex = 0;
            this.errorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppBackground
            // 
            this.BackgroundImage = global::ALLENIA.Properties.Resources.wallpaperflare_com_wallpaper;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.errorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppBackground";
            this.Load += new System.EventHandler(this.AppBackground_Load);
            this.errorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel errorPanel;
        private System.Windows.Forms.Label errorMsg;
    }
}

