using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLENIA
{
    public partial class EditUserSelect : Form
    {
        public EditUserSelect()
        {
            InitializeComponent();
        }

        private void checkUsername_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                int userID;
                SqlCommand cmdCheck = new SqlCommand("SELECT userID FROM Users WHERE username='" + usernameTxt.Text + "'", con);
                SqlDataReader checkReader = cmdCheck.ExecuteReader();
                if (checkReader.Read())
                {
                    userID = checkReader.GetInt32(0);
                    checkReader.Close();
                    EditUser editUser = new EditUser(userID);
                    editUser.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There is no user with that username.", "Editing user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();

        }
    }
}
