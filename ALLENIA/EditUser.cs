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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ALLENIA
{
    public partial class EditUser : Form
    {
        private readonly int userID;

        public EditUser(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("SELECT firstName, fatherName, lastName, phone, email, userStatus, username FROM Users WHERE userID=" + userID, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                { 
                    string firstName = reader.GetString(0);
                    string fatherName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string phone = reader.GetString(3);
                    string email = reader.GetString(4);
                    int userStatus = reader.GetInt32(5);
                    string username = reader.GetString(6);
                    firstnameTxt.Text = firstName;
                    midnameTxt.Text = fatherName;
                    lastnameTxt.Text = lastName;
                    phoneTxt.Text = phone;
                    emailTxt.Text = email;
                    usernameTxt.Text = username;
                    if (userStatus == 1) { userStatusRadio.Checked = true; }
                    else if (userStatus == 2) { adminStatusRadio.Checked = true; }
                }
                reader.Close();
            }
            con.Close();

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(firstnameTxt.Text == "") firstnameTxt.BorderColor = Color.Red;
            if(midnameTxt.Text == "") midnameTxt.BorderColor = Color.Red;
            if(lastnameTxt.Text == "") lastnameTxt.BorderColor = Color.Red;
            if(emailTxt.Text == "") emailTxt.BorderColor = Color.Red;
            if(usernameTxt.Text == "") usernameTxt.BorderColor = Color.Red;
            if(phoneTxt.Text == "") phoneTxt.BorderColor = Color.Red;
            if (userStatusRadio.Checked == false && adminStatusRadio.Checked == false) adminStatusPanel.FillColor = Color.Red;
            if (firstnameTxt.Text != string.Empty && midnameTxt.Text != string.Empty && lastnameTxt.Text != string.Empty && emailTxt.Text != string.Empty &&
                phoneTxt.Text != string.Empty && usernameTxt.Text != string.Empty && userStatusRadio.Checked || adminStatusRadio.Checked)
            {
                int userType = 0;
                if (userStatusRadio.Checked == true) userType = 1;
                if (adminStatusRadio.Checked == true) userType = 2;

                SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
                con.Open();
                using (con)
                {
                    SqlCommand extractData = new SqlCommand("UPDATE Users SET firstName=@firstname, fatherName=@midname, lastName=@lastname, phone=@phone, email=@email, userStatus=@userType, username=@username WHERE userID=@userId", con);
                    extractData.Parameters.AddWithValue("@username", usernameTxt.Text);
                    extractData.Parameters.AddWithValue("@firstname", firstnameTxt.Text);
                    extractData.Parameters.AddWithValue("@midname", midnameTxt.Text);
                    extractData.Parameters.AddWithValue("@lastname", lastnameTxt.Text);
                    extractData.Parameters.AddWithValue("@phone", phoneTxt.Text);
                    extractData.Parameters.AddWithValue("@email", emailTxt.Text);
                    extractData.Parameters.AddWithValue("@userType", userType);
                    extractData.Parameters.AddWithValue("@userId", userID);
                    extractData.ExecuteNonQuery();

                    int rowsAffected = extractData.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated", "Edit user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User information is not updated", "Edit user", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        this.Close();
                    } 
                }
                con.Close();
            }

        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            EditUserPassword edit = new EditUserPassword(userID);
            edit.Show();
            this.Close();
        }
    }
}
