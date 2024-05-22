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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ALLENIA
{
    public partial class CreateProduct : Form
    {
        public CreateProduct()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productCategory = 0;
                if (barcodeTxt.Text == "") barcodeTxt.BorderColor = Color.Red;
                if (priceTxt.Text == "") priceTxt.BorderColor = Color.Red;
                if (productNameTxt.Text == "") productNameTxt.BorderColor = Color.Red;

                // Tabasco = 1; Fruits and Vegeterians = 2; Alcohol = 3; Meat Products = 4; Milk Products = 5; Food Items = 6; Non-Food Items = 7
                if (tabascoRadio.Checked) productCategory = 1;
                if (fruitAndVegeteriansRadio.Checked) productCategory = 2;
                if (alcoholRadio.Checked) productCategory = 3;
                if (meatProductsRadio.Checked) productCategory = 4;
                if (milkProductsRadio.Checked) productCategory = 5;
                if (foodItemsRadio.Checked) productCategory = 6;
                if (nonFoodItemsRadio.Checked) productCategory = 7;

                if (barcodeTxt.Text != "" && priceTxt.Text != "" && productNameTxt.Text != "" && tabascoRadio.Checked || fruitAndVegeteriansRadio.Checked || alcoholRadio.Checked || meatProductsRadio.Checked || milkProductsRadio.Checked || foodItemsRadio.Checked || nonFoodItemsRadio.Checked)
                {
                    productTypePanel.FillColor = Color.Transparent; // Reset panel color
                    try
                    {
                        using (SqlConnection con = new SqlConnection("Server =.; Database = dpDatabase; Integrated security = true"))
                        {
                            con.Open();
                            SqlCommand extractData = new SqlCommand("INSERT INTO Products (barcode, productName, productPrice, category) VALUES (@barcode, @productName, @productPrice, @category)", con);
                            extractData.Parameters.AddWithValue("@barcode", barcodeTxt.Text);
                            extractData.Parameters.AddWithValue("@productName", productNameTxt.Text);
                            extractData.Parameters.AddWithValue("@productPrice", priceTxt.Text);
                            extractData.Parameters.AddWithValue("@category", productCategory);
                            extractData.ExecuteNonQuery();
                           DialogResult result = MessageBox.Show("Product (" + barcodeTxt.Text + ") has been created successfully!", "Create a product", MessageBoxButtons.OK);
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the product: " + ex.Message, "Create a product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // You can also log the exception to a file or database for further analysis
                    }
                }
                else
                {
                    productTypePanel.FillColor = Color.Red; // Set panel color to red if any field is empty or category is not selected
                    MessageBox.Show("Please fill in all the fields and select a category.", "Create a product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Creating a product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
