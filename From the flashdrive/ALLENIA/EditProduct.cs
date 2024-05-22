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
    public partial class EditProduct : Form
    {
        private readonly int productID;

        public EditProduct(int productID)
        {
            InitializeComponent();
            this.productID = productID;
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("SELECT barcode, productName, productPrice, category FROM Products WHERE barcode=" + productID, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int barcode = reader.GetInt32(0);
                    string productName = reader.GetString(1);
                    double price = reader.GetDouble(2);
                    int category = reader.GetInt32(3);
                    barcodeTxt.Text = barcode.ToString();
                    productNameTxt.Text = productName;
                    priceTxt.Text = price.ToString("F2");

                    // Tabasco = 1; Fruits and Vegeterians = 2; Alcohol = 3; Meat Products = 4; Milk Products = 5; Food Items = 6; Non-Food Items = 7
                    if (category == 1) tabascoRadio.Checked = true;
                    if(category == 2) fruitAndVegeteriansRadio.Checked = true;
                    if(category == 3) alcoholRadio.Checked = true;
                    if(category == 4) meatProductsRadio.Checked = true;
                    if(category == 5) milkProductsRadio.Checked = true;
                    if(category == 6) foodItemsRadio.Checked = true;
                    if(category == 7) nonFoodItemsRadio.Checked = true;
                }
                reader.Close();
            }
            con.Close();

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productCatrgory = 0;
                if (barcodeTxt.Text == "") barcodeTxt.BorderColor = Color.Red;
                if (priceTxt.Text == "") priceTxt.BorderColor = Color.Red;
                if (productNameTxt.Text == "") productNameTxt.BorderColor = Color.Red;
                if (productCatrgory == 0) productTypePanel.FillColor = Color.Red;

                // Tabasco = 1; Fruits and Vegeterians = 2; Alcohol = 3; Meat Products = 4; Milk Products = 5
                if (tabascoRadio.Checked) productCatrgory = 1;
                if (fruitAndVegeteriansRadio.Checked) productCatrgory = 2;
                if (alcoholRadio.Checked) productCatrgory = 3;
                if (meatProductsRadio.Checked) productCatrgory = 4;
                if (milkProductsRadio.Checked) productCatrgory = 5;
                if (foodItemsRadio.Checked) productCatrgory = 6;
                if (nonFoodItemsRadio.Checked) productCatrgory = 7;
                if (barcode.Text != "" && priceTxt.Text != "" && productNameTxt.Text != "" && productCatrgory != 0)
                {
                    using (SqlConnection con = new SqlConnection("Server =.; Database = dpDatabase; Integrated security = true"))
                    {
                        con.Open();
                        SqlCommand extractData = new SqlCommand("UPDATE Products SET productName=@productName, productPrice=@productPrice, category=@category WHERE barcode=@barcode", con);
                        extractData.Parameters.AddWithValue("@barcode", barcodeTxt.Text);
                        extractData.Parameters.AddWithValue("@productName", productNameTxt.Text);
                        extractData.Parameters.AddWithValue("@productPrice", priceTxt.Text);
                        extractData.Parameters.AddWithValue("@category", productCatrgory);
                        extractData.ExecuteNonQuery();

                        DialogResult result = MessageBox.Show("Product (" + barcodeTxt.Text + ") has been edited successfully!", "Edit a product", MessageBoxButtons.OK);
                        switch (result)
                        {
                            case DialogResult.OK:
                                this.Close();
                                break;
                            default:
                                break;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Editing a user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
