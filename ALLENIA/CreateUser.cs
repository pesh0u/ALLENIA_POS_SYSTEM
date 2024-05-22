using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLENIA
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (firstname.Text == "") firstname.BorderColor = Color.Red;
            if (midname.Text == "") midname.BorderColor = Color.Red;
            if (lastname.Text == "") lastname.BorderColor = Color.Red;
            if (email.Text == "") email.BorderColor = Color.Red;
            if (phone.Text == "") phone.BorderColor = Color.Red;
            if (username.Text == "") username.BorderColor = Color.Red;
            if (password.Text == "" && password.Text == confpassword.Text) password.BorderColor = Color.Red;
            if (confpassword.Text == "" && confpassword.Text == password.Text) confpassword.BorderColor = Color.Red;
            if (userStatus.Checked == false && adminStatus.Checked == false) adminStatusPanel.FillColor = Color.Red;

            if (firstname.Text != string.Empty && midname.Text != string.Empty && lastname.Text != string.Empty && email.Text != string.Empty &&
                phone.Text != string.Empty && username.Text != string.Empty && password.Text != string.Empty && confpassword.Text != string.Empty && userStatus.Checked || adminStatus.Checked)
            {
                int userType = 0;
                if (userStatus.Checked == true) userType = 1;
                if (adminStatus.Checked == true) userType = 2;

                try
                {
                    SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
                    con.Open();
                    using (con)
                    {
                        SqlCommand inputData = new SqlCommand("INSERT INTO Users(username, firstName, fatherName, lastName, phone, email, passwd, userstatus) VALUES (@username, @firstname, @midname, @lastname, @phone, @email, @password, @userType)", con);
                        inputData.Parameters.AddWithValue("@username", username.Text);
                        inputData.Parameters.AddWithValue("@firstname", firstname.Text);
                        inputData.Parameters.AddWithValue("@midname", midname.Text);
                        inputData.Parameters.AddWithValue("@lastname", lastname.Text);
                        inputData.Parameters.AddWithValue("@phone", phone.Text);
                        inputData.Parameters.AddWithValue("@email", email.Text);
                        inputData.Parameters.AddWithValue("@password", password.Text);
                        inputData.Parameters.AddWithValue("@userType", userType);
                        inputData.ExecuteNonQuery();
                    }
                    con.Close();
                    DialogResult result = MessageBox.Show("User (" + username.Text + ") has been created successfuly!", "Creating a user", MessageBoxButtons.OK);
                    switch (result) 
                    { 
                        case DialogResult.OK:
                            this.Close();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Creating a user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
