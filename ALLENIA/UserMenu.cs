using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ALLENIA
{
    public partial class UserMenu : Form
    {
        private readonly int userID;

        public UserMenu(int userID)
        {
            InitializeComponent();
            barcodeReader.Focus();
            this.userID = userID;
        }

        void background_Resize(object sender, EventArgs e)
        {
            AppBackground background = sender as AppBackground;
            if (this.WindowState == FormWindowState.Minimized)
            {
                background.WindowState = FormWindowState.Minimized;
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            AppBackground background = new AppBackground();
            background.Resize += new EventHandler(background_Resize);
            this.Enabled = false;
            background.FormClosed += new FormClosedEventHandler(background_FormClosed);
            background.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Minimized;
        }

        void background_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void keyinputExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void keyinputLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();

        }

        private void inputkey1_Click(object sender, EventArgs e)
        {
            barcodeReader.Text = barcodeReader.Text + "1";
        }

        private void inputkey2_Click(object sender, EventArgs e)
        {
            barcodeReader.Text = barcodeReader.Text + "2";
        }

        private void inputkey3_Click(object sender, EventArgs e)
        {
            barcodeReader.Text = barcodeReader.Text + "3";
        }

        private void inputkey4_Click(object sender, EventArgs e)
        {
            barcodeReader.Text = barcodeReader.Text + "4";
        }

        private void inputkey5_Click(object sender, EventArgs e)
        {
            barcodeReader.Text = barcodeReader.Text + "5";
        }

        private void inputkey6_Click(object sender, EventArgs e)
        {
            barcodeReader.Text = barcodeReader.Text + "6";
        }

        private void inputkey7_Click(object sender, EventArgs e)
        {
            barcodeReader.Text = barcodeReader.Text + "7";
        }

        private void inputkey8_Click(object sender, EventArgs e)
        {
            barcodeReader.Text = barcodeReader.Text + "8";
        }

        private void inputkey9_Click(object sender, EventArgs e)
        {
            barcodeReader.Text = barcodeReader.Text + "9";
        }

        private void inputkey0_Click(object sender, EventArgs e)
        {
            barcodeReader.Text = barcodeReader.Text + "0";
        }

        private void inputkeyMultiply_Click(object sender, EventArgs e)
        {
            barcodeReader.Text = barcodeReader.Text + "x";
        }

        private void inputkeyClear_Click(object sender, EventArgs e)
        {
            barcodeReader.Clear();
            barcodeReader.Focus();
        }

        private void inputkeyDot_Click(object sender, EventArgs e)
        {
            barcodeReader.Text = barcodeReader.Text + ".";
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand putCashier = new SqlCommand("SELECT firstName, lastName FROM Users WHERE userID=" + userID, con);
                SqlDataReader reader = putCashier.ExecuteReader();
                while (reader.Read())
                {
                    string firstname = reader.GetString(0);
                    string lastname = reader.GetString(1);
                    cashierName.Text = firstname + " " + lastname;
                }
                reader.Close();

                SqlCommand displayProductTable = new SqlCommand("SELECT barcode, productName, category FROM Products", con);
                var displayReader = displayProductTable.ExecuteReader();
                while(displayReader.Read())
                {
                    var barcode = displayReader["Barcode"];
                    var productName = displayReader["ProductName"];
                    productList.Rows.Add(barcode, productName);
                }
                
                con.Close();
            }
        }

        private void allProductsRadio_Click(object sender, EventArgs e)
        {
            productList.Rows.Clear();
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand displayProductTable = new SqlCommand("SELECT barcode, productName, category FROM Products", con);
                var displayReader = displayProductTable.ExecuteReader();
                while (displayReader.Read())
                {
                    var barcode = displayReader["Barcode"];
                    var productName = displayReader["ProductName"];
                    productList.Rows.Add(barcode, productName);
                }

                con.Close();
            }
        }

        // Tabasco = 1; Fruits and Vegeterians = 2; Alcohol = 3; Meat Products = 4; Milk Products = 5; Food Items = 6; Non-Food Items = 7
        private void foodItemsRadio_Click(object sender, EventArgs e)
        {
            productList.Rows.Clear();
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand displayProductTable = new SqlCommand("SELECT barcode, productName, category FROM Products WHERE category=6", con);
                var displayReader = displayProductTable.ExecuteReader();
                while (displayReader.Read())
                {
                    var barcode = displayReader["Barcode"];
                    var productName = displayReader["ProductName"];
                    productList.Rows.Add(barcode, productName);
                }

                con.Close();
            }
        }

        private void nonFoodItemsRadio_Click(object sender, EventArgs e)
        {
            productList.Rows.Clear();
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand displayProductTable = new SqlCommand("SELECT barcode, productName, category FROM Products WHERE category=7", con);
                var displayReader = displayProductTable.ExecuteReader();
                while (displayReader.Read())
                {
                    var barcode = displayReader["Barcode"];
                    var productName = displayReader["ProductName"];
                    productList.Rows.Add(barcode, productName);
                }

                con.Close();
            }
        }

        private void tabascoRadio_Click(object sender, EventArgs e)
        {
            productList.Rows.Clear();
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand displayProductTable = new SqlCommand("SELECT barcode, productName, category FROM Products WHERE category=1", con);
                var displayReader = displayProductTable.ExecuteReader();
                while (displayReader.Read())
                {
                    var barcode = displayReader["Barcode"];
                    var productName = displayReader["ProductName"];
                    productList.Rows.Add(barcode, productName);
                }

                con.Close();
            }
        }

        private void MeatProductsRadio_Click(object sender, EventArgs e)
        {
            productList.Rows.Clear();
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand displayProductTable = new SqlCommand("SELECT barcode, productName, category FROM Products WHERE category=2", con);
                var displayReader = displayProductTable.ExecuteReader();
                while (displayReader.Read())
                {
                    var barcode = displayReader["Barcode"];
                    var productName = displayReader["ProductName"];
                    productList.Rows.Add(barcode, productName);
                }

                con.Close();
            }
        }

        private void alcoholRadio_Click(object sender, EventArgs e)
        {
            productList.Rows.Clear();
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand displayProductTable = new SqlCommand("SELECT barcode, productName, category FROM Products WHERE category=3", con);
                var displayReader = displayProductTable.ExecuteReader();
                while (displayReader.Read())
                {
                    var barcode = displayReader["Barcode"];
                    var productName = displayReader["ProductName"];
                    productList.Rows.Add(barcode, productName);
                }

                con.Close();
            }
        }

        private void meatRadio_Click(object sender, EventArgs e)
        {
            productList.Rows.Clear();
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand displayProductTable = new SqlCommand("SELECT barcode, productName, category FROM Products WHERE category=4", con);
                var displayReader = displayProductTable.ExecuteReader();
                while (displayReader.Read())
                {
                    var barcode = displayReader["Barcode"];
                    var productName = displayReader["ProductName"];
                    productList.Rows.Add(barcode, productName);
                }

                con.Close();
            }
        }

        private void milkproductsRadio_Click(object sender, EventArgs e)
        {
            productList.Rows.Clear();
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand displayProductTable = new SqlCommand("SELECT barcode, productName, category FROM Products WHERE category=5", con);
                var displayReader = displayProductTable.ExecuteReader();
                while (displayReader.Read())
                {
                    var barcode = displayReader["Barcode"];
                    var productName = displayReader["ProductName"];
                    productList.Rows.Add(barcode, productName);
                }

                con.Close();
            }
        }

        private void productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            barcodeReader.Focus();
            if (e.RowIndex >= 0)
            {
                DataGridViewCell cell = productList.Rows[e.RowIndex].Cells[0];
                string text = cell.Value.ToString();
                barcodeReader.Text = text;
                barcodeReader.Focus();
            }
        }

        private void inputkeyTotal_Click(object sender, EventArgs e)
        {
            string barcode = barcodeReader.Text;
            char charX = 'x';
            double quantity;
            if (barcode.Contains(charX))
            {
                string[] results = barcode.Split(charX);
                barcode = results[0].ToString();
                quantity = double.Parse(results[1]);
            }
            else
            {
                quantity = 1;
            }
            SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
            con.Open();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("SELECT productName, productPrice FROM Products WHERE barcode=@barcode", con);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        string productName = reader.GetString(0);
                        double price = reader.GetDouble(1);
                        double total = Math.Round(price * quantity, 2);
                        checkoutList.Rows.Add(barcode, productName, quantity, price, total);
                        double sum = 0;
                        foreach (DataGridViewRow row in checkoutList.Rows)
                        {
                            double value = Convert.ToDouble(row.Cells[4].Value);
                            sum += value;
                        }
                        double result = Math.Round(sum, 2);
                        priceTotal.Text = result.ToString();
                    }
                    barcodeReader.Clear();
                    barcodeReader.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid or untyped barcode", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        private void correctionButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmReset = MessageBox.Show("Are you sure to delete the last row from the order?", "Correct order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (confirmReset)
            {
                case DialogResult.Yes:
                    if (checkoutList.Rows.Count > 0)
                    {
                        int lastRowIndex = checkoutList.Rows.Count - 1;
                        checkoutList.Rows.RemoveAt(lastRowIndex);
                        double sum = 0;
                        foreach (DataGridViewRow row in checkoutList.Rows)
                        {
                            double value = Convert.ToDouble(row.Cells[4].Value);
                            sum += value;
                        }
                        double result = Math.Round(sum, 2);
                        priceTotal.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("There is nothing to correct.", "Correction error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case DialogResult.No:
                    break;
                default: break;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmReset = MessageBox.Show("Are you sure to reset the order?", "Reset order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (confirmReset) 
            {
                case DialogResult.Yes:
                    UserMenu userMenu = new UserMenu(userID);
                    userMenu.ShowDialog();
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
                default: break;
            }
        }

        private void discount10button_Click(object sender, EventArgs e)
        {
            discount10button.Enabled = false;
            discount20Button.Enabled = false;
            double price = double.Parse(priceTotal.Text);
            double total = Math.Round(price * 0.1, 2);
            checkoutList.Rows.Add("DISCOUNT10", "Order discount -10%", "-", "-", $"-{total}");
            double sum = 0;
            double newSum = 0;
            foreach (DataGridViewRow row in checkoutList.Rows)
            {
                double value = Convert.ToDouble(row.Cells[4].Value);
                newSum += value;
            }
            List<double> list = new List<double>();
            foreach (DataGridViewRow item in checkoutList.Rows)
            {
                double element = Convert.ToDouble(item.Cells[4].Value);
                list.Add(element);
            }
            double removedElement = list.Last();
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            sum = sum - removedElement;
            double discountSum = Math.Round(sum - (sum * 0.1), 2);
            priceTotal.Text = discountSum.ToString();

        }

        private void discount20Button_Click(object sender, EventArgs e)
        {
            discount10button.Enabled = false;
            discount20Button.Enabled = false;
            double price = double.Parse(priceTotal.Text);
            double total = Math.Round(price * 0.2, 2);
            checkoutList.Rows.Add("DISCOUNT20", "Order discount -20%", "-", "-", $"-{total}");
            double sum = 0;
            double newSum = 0;
            foreach (DataGridViewRow row in checkoutList.Rows)
            {
                double value = Convert.ToDouble(row.Cells[4].Value);
                newSum += value;
            }
            List<double> list = new List<double>();
            foreach (DataGridViewRow item in checkoutList.Rows)
            {
                double element = Convert.ToDouble(item.Cells[4].Value);
                list.Add(element);
            }
            double removedElement = list.Last();
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            sum = sum - removedElement;
            double discountSum = Math.Round(sum - (sum * 0.2), 2);
            priceTotal.Text = discountSum.ToString();
        }

        private void cashRequiredTxt_TextChanged(object sender, EventArgs e)
        {
            double cashRequired = double.Parse(cashRequiredTxt.Text);
            double totalprice = double.Parse(priceTotal.Text);
            double change = cashRequired - totalprice;
            changeTxt.Text = Math.Round(change, 2).ToString();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            double change = double.Parse(changeTxt.Text);
            if (change < 0)
            {
                MessageBox.Show("The value of the change is smaller than the total price.", "Invalid change", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Document recept = new Document();
                string filePath = @"C:\recepts\receipt.pdf";
                PdfWriter.GetInstance(recept, new FileStream(filePath, FileMode.Create));
                recept.Open();

                Paragraph logo = new Paragraph("ALLENIA\n\n");
                logo.Alignment = Element.ALIGN_CENTER;
                logo.Alignment = Element.TITLE;
                recept.Add(logo);

                Paragraph header = new Paragraph("Receipt\n\n");
                header.Alignment = Element.ALIGN_CENTER;
                recept.Add(header);

                DateTime dateTime = DateTime.Now;
                Paragraph date = new Paragraph($"Date: {dateTime}\n\n");
                date.Alignment = Element.ALIGN_CENTER;
                recept.Add(date);

                string casierName = cashierName.Text;
                Paragraph casier = new Paragraph($"Casier: {casierName:C}\n\n");
                casier.Alignment = Element.ALIGN_CENTER;
                recept.Add(casier);

                PdfPTable table = new PdfPTable(4);
                table.AddCell("Product");
                table.AddCell("Quantity");
                table.AddCell("Product Price");
                table.AddCell("Total Price");

                foreach (DataGridViewRow row in checkoutList.Rows)
                {
                    string productName = row.Cells["ProductName"].Value.ToString();
                    string quantity = Convert.ToString(row.Cells["Quantity"].Value);
                    string productPrice = Convert.ToString(row.Cells["ProductPrice"].Value);
                    string productTotal = Convert.ToString(row.Cells["TotalPrice"].Value);

                    table.AddCell(productName);
                    table.AddCell(quantity.ToString());
                    table.AddCell(productPrice.ToString());
                    table.AddCell(productTotal.ToString());
                }
                recept.Add(table);

                string totalPrice = priceTotal.Text.ToString();
                Paragraph total = new Paragraph($"Total: {totalPrice:C}\n\n");
                total.Alignment = Element.ALIGN_RIGHT;
                recept.Add(total);

                string cashGived = cashRequiredTxt.Text.ToString();
                Paragraph cash = new Paragraph($"Cash: {cashGived:C}\n\n");
                cash.Alignment = Element.ALIGN_RIGHT;
                recept.Add(cash);

                string changeGived = changeTxt.Text.ToString();
                Paragraph changeParagragh = new Paragraph($"Change: {changeGived:C}\n\n");
                changeParagragh.Alignment = Element.ALIGN_RIGHT;
                recept.Add(changeParagragh);

                Paragraph footer = new Paragraph("Thanks for shopping with us.");
                footer.Alignment = Element.ALIGN_CENTER;
                recept.Add(footer);
                
                recept.Close();
                System.Diagnostics.Process.Start(filePath);

                SqlConnection con = new SqlConnection("Server=.; Database=dpDatabase; Integrated Security = true");
                con.Open();
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Statements VALUES ('Client Order', @cashier, @value, @date)", con);
                    cmd.Parameters.AddWithValue("@cashier", cashierName.Text);
                    cmd.Parameters.AddWithValue("@value", priceTotal.Text);
                    cmd.Parameters.AddWithValue("@date", dateTime);
                    cmd.ExecuteNonQuery();
                }

                this.Close();
                UserMenu userMenu = new UserMenu(userID);
                userMenu.Show();
            }
        }
    }
}
