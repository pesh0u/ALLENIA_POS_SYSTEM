using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
