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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ALLENIA
{
    public partial class MonthStatement : Form
    {
        public MonthStatement()
        {
            InitializeComponent();
        }

        private void MonthStatement_Load(object sender, EventArgs e)
        {
            selectMonth.Items.Add("January");
            selectMonth.Items.Add("February");
            selectMonth.Items.Add("March");
            selectMonth.Items.Add("April");
            selectMonth.Items.Add("May");
            selectMonth.Items.Add("June");
            selectMonth.Items.Add("July");
            selectMonth.Items.Add("August");
            selectMonth.Items.Add("September");
            selectMonth.Items.Add("October");
            selectMonth.Items.Add("November");
            selectMonth.Items.Add("December");
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear - 10; i <= currentYear; i++)
            {
                selectYear.Items.Add(i);
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int selectedMonth = selectMonth.SelectedIndex + 1;
            int selectedYear = (int)selectYear.SelectedItem;

            DateTime selectedDate = new DateTime(selectedYear, selectedMonth, 1);

            using (SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(statementValue) FROM Statements WHERE MONTH(statementDate) = @selectedMonth AND YEAR(statementDate) = @selectedYear", con))
                {
                    cmd.Parameters.AddWithValue("@selectedMonth", selectedMonth);
                    cmd.Parameters.AddWithValue("@selectedYear", selectedYear);

                    int countStatements = (int)cmd.ExecuteScalar();
                    clientsCount.Text = countStatements.ToString();
                }
                using (SqlCommand cmd2 = new SqlCommand("SELECT SUM(statementValue) FROM Statements WHERE MONTH(statementDate) = @selectedMonth AND YEAR(statementDate) = @selectedYear", con))
                {
                    cmd2.Parameters.AddWithValue("@selectedMonth", selectedMonth);
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
    }
}
