using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ALLENIA
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     
            int nTopRect,      
            int nRightRect,    
            int nBottomRect,   
            int nWidthEllipse, 
            int nHeightEllipse 
        );

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BringToFront();
            TopMost = true;
            Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "" && passwordTxt.Text == "")
            {
                giflogo.Image = Properties.Resources._1140_error_gradient;
                instructionText.Text = "Please enter username and password";
                usernameTxt.BorderColor = Color.Red;
                passwordTxt.BorderColor = Color.Red;
                loginLogo.Select();
                loginLogo.Focus();
            }
            else
            {
                string user = usernameTxt.Text;
                string pass = passwordTxt.Text;
                usernameTxt.BorderColor = Color.Gray;
                passwordTxt.BorderColor = Color.Gray;
                usernameTxt.ReadOnly = true;
                passwordTxt.ReadOnly = true;
                usernameTxt.HoverState.BorderColor = Color.Gray;
                passwordTxt.HoverState.BorderColor = Color.Gray;
                loginBtn.Enabled = false;
                giflogo.Image = Properties.Resources._105_loader_1_gradient;
                loginLogo.Select();
                loginLogo.Focus();

                try
                {
                    SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
                    con.Open();
                    con.Close();
                }
                catch (SqlException)
                {
                    DialogResult result = MessageBox.Show("[ Code 500 ]: An internal error occurred on the server. This may be because of an application error or configuration problem. The application will be closed.", "Checking connection: Failed", MessageBoxButtons.OK);
                    switch (result)
                    {
                        case DialogResult.OK:
                            Application.Exit();
                            break;

                        default:
                            break;
                    }

                }
                try
                {
                    SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
                    con.Open();
                    using (con)
                    {
                        SqlCommand cmdLogin = new SqlCommand("SELECT userID FROM Users WHERE username='" + usernameTxt.Text + "'AND passwd ='" + passwordTxt.Text + "'", con);
                        SqlDataReader loginReader = cmdLogin.ExecuteReader();

                        if (loginReader.Read())
                        {
                            loginReader.Close();
                            SqlCommand cmdAdmincheck = new SqlCommand("SELECT userID FROM Users WHERE username='" + usernameTxt.Text + "'AND userStatus=2", con);
                            SqlDataReader adminReader = cmdAdmincheck.ExecuteReader();
                            if (adminReader.Read())
                            {
                                adminReader.Close();
                                int userID;
                                SqlCommand takeData = new SqlCommand("SELECT userID FROM Users WHERE username='" + usernameTxt.Text + "'", con);
                                SqlDataReader dataReader = takeData.ExecuteReader();                                
                                while (dataReader.Read())
                                {
                                    userID = dataReader.GetInt32(0);
                                    AdminPanel adminPanel = new AdminPanel(userID);
                                    adminPanel.Show();
                                }
                                adminReader.Close();
                                giflogo.Image = Properties.Resources._1140_error_gradient;
                                instructionText.Text = "Admin Login Successful";
                                usernameTxt.BorderColor = Color.Green;
                                passwordTxt.BorderColor = Color.Green;
                                this.Close();
                            }
                            else
                            {
                                adminReader.Close();
                                int userID;
                                SqlCommand takeData = new SqlCommand("SELECT userID FROM Users WHERE username='" + usernameTxt.Text + "'", con);
                                SqlDataReader dataReader = takeData.ExecuteReader();
                                while (dataReader.Read())
                                {
                                    userID = dataReader.GetInt32(0);
                                    UserMenu userMenu = new UserMenu(userID);
                                    userMenu.Show();
                                }
                                dataReader.Close();
                                giflogo.Image = Properties.Resources._1140_error_gradient;
                                instructionText.Text = "User Login Successful";
                                usernameTxt.BorderColor = Color.Green;
                                passwordTxt.BorderColor = Color.Green;
                                this.Close();
                            }

                        }

                        else
                        {
                            giflogo.Image = Properties.Resources._1140_error_gradient;
                            usernameTxt.Text = "";
                            passwordTxt.Text = "";
                            usernameTxt.ReadOnly = false;
                            passwordTxt.ReadOnly = false;
                            instructionText.Text = "Invalid username or password";
                            usernameTxt.BorderColor = Color.Red;
                            passwordTxt.BorderColor = Color.Red;
                            loginBtn.Enabled = true;
                        }
                        con.Close();
                    }
                }
                catch (Exception message)
                {
                    string text = message.Message;
                    MessageBox.Show(text);
                }
                
            }
        }
    }
}
