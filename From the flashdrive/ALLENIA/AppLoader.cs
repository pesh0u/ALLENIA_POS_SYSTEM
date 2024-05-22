using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLENIA
{
    public partial class AppLoader : Form
    {
        public AppLoader()
        {
            InitializeComponent();
        }

        public void AppLoader_Load(object sender, EventArgs e)
        {
            AppBackground background = new AppBackground();
            background.ShowDialog();
            this.Close();
        }
    }
}
