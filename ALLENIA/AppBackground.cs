using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLENIA
{
    public partial class AppBackground : Form
    {
        public AppBackground()
        {
            InitializeComponent();
            try
            {
                SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
                con.Open();
                con.Close();
            }
            catch (SqlException)
            {
                errorPanel.Visible = true;
                string connectionMsg = "[ Code 500 ]: An internal error occurred on the server. This may be because of an application error or configuration problem. Reboot the program or contact with administrator.";
                errorMsg.Text = connectionMsg;
            }
        }

        private void AppBackground_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Login login = new Login();
            login.Show();
        }
    }
}
