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

namespace ALLENIA
{
    public partial class StatementDeposit : Form
    {
        private readonly int userID;

        public StatementDeposit(int userID)
        {
            InitializeComponent();
            this.userID = userID;

            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT firstName, lastName FROM Users WHERE userID=" + userID, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string firstname = reader.GetString(0);
                    string lastname= reader.GetString(1);
                    depostiMaker.Text = firstname + " " + lastname;
                }
                reader.Close();
                con.Close();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
                con.Open();
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Statements VALUES ('Statement Deposit', @cashier, @value, @date)", con);
                    cmd.Parameters.AddWithValue("@cashier", depostiMaker.Text);
                    cmd.Parameters.AddWithValue("@value", depositValue.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Deposit complete", "Statement Deposit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception message)
            {
                string text = message.Message;
                MessageBox.Show(text);
            }
        }
    }
}
