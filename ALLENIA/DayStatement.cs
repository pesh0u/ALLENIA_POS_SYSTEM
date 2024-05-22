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
    public partial class DayStatement : Form
    {
        public DayStatement()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = timeSelect.Value;
            string data = dateTime.ToString("yyyy-MM-dd HH:mm:ss");

            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security=true");
            con.Open();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(statementValue) FROM Statements WHERE statementDate = @statementDate", con);
                cmd.Parameters.AddWithValue("@statementDate", data);
                int countStatements = (int)cmd.ExecuteScalar();
                clientsCount.Text = countStatements.ToString();

                SqlCommand cmd2 = new SqlCommand("SELECT SUM(statementValue) FROM Statements WHERE statementDate = @statementDate", con);
                cmd2.Parameters.AddWithValue("@statementDate", data);
                object result = cmd2.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    decimal totalValue = Convert.ToDecimal(result); 
                    totalStatement.Text = totalValue.ToString();
                }
                else
                {
                    totalStatement.Text = "NO DATA";
                }
            }
            con.Close();

        }
    }
}
