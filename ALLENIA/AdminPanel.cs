using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLENIA
{
    public partial class AdminPanel : Form
    {
        private int userID;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public AdminPanel(int userID)
        {
            InitializeComponent();
            this.userID = userID;

            this.FormBorderStyle = FormBorderStyle.None;
            try
            {
                SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
                con.Open();
                using (con)
                {
                    SqlCommand checkBalance = new SqlCommand("SELECT ISNULL(SUM(statementValue), 0) FROM Statements", con);
                    double countBalance = (double)checkBalance.ExecuteScalar();
                    balanceCount.Text = countBalance.ToString();

                    SqlCommand checkUsers = new SqlCommand("SELECT COUNT(*) FROM Users", con);
                    int countUsers = (int)checkUsers.ExecuteScalar();
                    usersCount.Text = countUsers.ToString();

                    SqlCommand checkProducts = new SqlCommand("SELECT COUNT(*) FROM Products", con);
                    int countProducts = (int)checkProducts.ExecuteScalar();
                    productsCount.Text = countProducts.ToString();

                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT username FROM Users WHERE userID=" + userID, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string username = reader.GetString(0);
                    nameLabel.Text = "Welcome, " + username + "!";
                }
                reader.Close();
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            EditUserSelect editUser = new EditUserSelect();
            editUser.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            RemoveUserSelect removeUser = new RemoveUserSelect();
            removeUser.Show();
        }

        private void addProductsBtn_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.Show();
        }

        private void editProductBtn_Click(object sender, EventArgs e)
        {
            EditProductSelect editProduct = new EditProductSelect();
            editProduct.Show();
        }

        private void removeProductBtn_Click(object sender, EventArgs e)
        {
            RemoveProductSelect removeProduct = new RemoveProductSelect();
            removeProduct.Show();
        }

        private void dOborotBtn_Click(object sender, EventArgs e)
        {
            DayStatement dayStatement = new DayStatement();
            dayStatement.Show();
        }

        private void mOborotBtn_Click(object sender, EventArgs e)
        {
            MonthStatement monthStatement = new MonthStatement();
            monthStatement.Show();
        }

        private void yOborotBtn_Click(object sender, EventArgs e)
        {
            YearStatement yearStatement = new YearStatement();
            yearStatement.Show();
        }

        private void OfficialWithraw_Click(object sender, EventArgs e)
        {
            StatementDeposit statementDeposit = new StatementDeposit(userID);
            statementDeposit.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            StatementWithdraw statementWithdraw = new StatementWithdraw(userID);
            statementWithdraw.Show();
        }
    }
}
