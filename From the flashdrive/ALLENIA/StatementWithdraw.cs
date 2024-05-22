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
    public partial class StatementWithdraw : Form
    {
        private readonly int userID;

        public StatementWithdraw(int userID)
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
                    string lastname = reader.GetString(1);
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
                double sum = int.Parse(depositValue.Text);
                double negSum = sum * -1;
                SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
                con.Open();
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Statements VALUES ('Statement Withdraw', @cashier, @value, @date)", con);
                    cmd.Parameters.AddWithValue("@cashier", depostiMaker.Text);
                    cmd.Parameters.AddWithValue("@value", negSum);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw complete", "Statement Deposit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
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
