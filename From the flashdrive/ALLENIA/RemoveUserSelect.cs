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

namespace ALLENIA
{
    public partial class RemoveUserSelect : Form
    {
        public RemoveUserSelect()
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
                    DialogResult result = MessageBox.Show("Are you sure to remove ( " + usernameTxt.Text + " ) from the system?", "Removing a user", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            SqlCommand deleteUser = new SqlCommand("DELETE FROM Users WHERE username='" + usernameTxt.Text + "'", con);
                            deleteUser.ExecuteNonQuery();
                            MessageBox.Show("The user is successfuly removed.", "Removing user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            break;
                        case DialogResult.No:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("There is no user with that username.", "Removing user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }
    }
}
