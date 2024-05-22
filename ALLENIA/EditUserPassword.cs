using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ALLENIA
{
    public partial class EditUserPassword : Form
    {
        public readonly int userID;

        public EditUserPassword(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void EditUserPassword_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand extractData = new SqlCommand("SELECT username FROM Users WHERE userID=" + userID, con);
                SqlDataReader reader = extractData.ExecuteReader();
                while (reader.Read())
                {
                    string username = reader.GetString(0);
                    usernameTxt.Text = username;
                }
            }
            con.Close();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if(password.Text == "") password.BorderColor = Color.Red;
            if(confpassword.Text == "") confpassword.BorderColor = Color.Red;
            if (password.Text == confpassword.Text)
            {
                SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
                con.Open();
                using (con)
                {
                    SqlCommand extractData = new SqlCommand("UPDATE Users SET passwd=@password WHERE userID=@userID", con);
                    extractData.Parameters.AddWithValue("@password", password.Text);
                    extractData.Parameters.AddWithValue("@userID", userID.ToString());
                    extractData.ExecuteNonQuery();

                    int rowsAffected = extractData.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User password changed.", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User password was not updated", "Change password", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }
            }
        }
    }
}
