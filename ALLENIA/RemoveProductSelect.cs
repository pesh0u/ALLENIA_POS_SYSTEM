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
    public partial class RemoveProductSelect : Form
    {
        public RemoveProductSelect()
        {
            InitializeComponent();
        }

        private void checkBarcode_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                int userID;
                SqlCommand cmdCheck = new SqlCommand("SELECT barcode FROM Products WHERE barcode='" + barcodeTxt.Text + "'", con);
                SqlDataReader checkReader = cmdCheck.ExecuteReader();
                if (checkReader.Read())
                {
                    userID = checkReader.GetInt32(0);
                    checkReader.Close();
                    DialogResult result = MessageBox.Show("Are you sure to remove ( " + barcodeTxt.Text + " ) from the system?", "Removing a product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            SqlCommand deleteUser = new SqlCommand("DELETE FROM Products WHERE barcode='" + barcodeTxt.Text + "'", con);
                            deleteUser.ExecuteNonQuery();
                            MessageBox.Show("The product is successfuly removed.", "Removing product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            break;
                        case DialogResult.No:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("There is no product with that barcode.", "Removing barcode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }
    }
}
