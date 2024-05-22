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
    public partial class EditProductSelect : Form
    {
        public EditProductSelect()
        {
            InitializeComponent();
        }

        private void checkProduct_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                int barcode;
                SqlCommand cmdCheck = new SqlCommand("SELECT barcode FROM Products WHERE barcode='" + productNameTxt.Text + "'", con);
                SqlDataReader checkReader = cmdCheck.ExecuteReader();
                if (checkReader.Read())
                {
                    barcode = checkReader.GetInt32(0);
                    checkReader.Close();
                    EditProduct editProduct = new EditProduct(barcode);
                    editProduct.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There is no product with that barcode.", "Editing product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
