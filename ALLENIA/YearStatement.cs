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
    public partial class YearStatement : Form
    {
        public YearStatement()
        {
            InitializeComponent();
        }

        private void YearStatement_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear - 10; i <= currentYear; i++)
            {
                selectYear.Items.Add(i);
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int selectedYear = (int)selectYear.SelectedItem;

            using (SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(statementValue) FROM Statements WHERE YEAR(statementDate) = @selectedYear", con))
                {
                    cmd.Parameters.AddWithValue("@selectedYear", selectedYear);

                    int countStatements = (int)cmd.ExecuteScalar();
                    clientsCount.Text = countStatements.ToString();
                }
                using (SqlCommand cmd2 = new SqlCommand("SELECT SUM(statementValue) FROM Statements WHERE YEAR(statementDate) = @selectedYear", con))
                {
                    cmd2.Parameters.AddWithValue("@selectedYear", selectedYear);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
