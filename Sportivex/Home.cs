using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sportivex
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Initialize transaction info on load
            InitializeTransaction();
        }

        private void InitializeTransaction()
        {
            trac.Text = DateTime.Now.Ticks.ToString(); // Dummy Transaction No
            date.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            txtTotal.Text = "0.00";
            txtDiscount.Text = "0.00";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Barcode input logic here (if needed for instant updates)
        }

        private void eyewear_Click(object sender, EventArgs e)
        {
            Eyewear eyewear = new Eyewear();
            eyewear.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Barcode search button logic
            string barcode = txtBarcode.Text.Trim();
            if (!string.IsNullOrEmpty(barcode))
            {
                //AddProductToGrid(barcode);
            }
        }

        /*private void AddProductToGrid(string barcode)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=localhost;Database=Sportivex;userid=root;password=''");

))                {
                    conn.Open();

                    string query = "SELECT ProductCode, Description, Price FROM Products WHERE ProductCode = @Barcode";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Barcode", barcode);

                    SqlDataReader reader = cmd.ExecuteReader();

                   if (reader.Read())
                    {
                        string productCode = reader["ProductCode"].ToString();
                        string description = reader["Description"].ToString();
                       decimal price = Convert.ToDecimal(reader["Price"]);

                        // Add the product to the DataGridView
                        int rowIndex = dataGridViewProducts.Rows.Add();
                        DataGridViewRow row = dataGridViewProducts.Rows[rowIndex];
                        row.Cells["No"].Value = rowIndex + 1;
                        row.Cells["PCode"].Value = productCode;
                        row.Cells["Description"].Value = description;
                        row.Cells["Price"].Value = price;
                        row.Cells["Qty"].Value = 1;

                        UpdateTotal();
                    }
                    else
                    {
                        MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void UpdateTotal()
        {
            try
           {
                decimal total = 0;
                foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                {
                    if (row.Cells["Price"].Value != null && row.Cells["Qty"].Value != null)
                    {
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Qty"].Value);
                       total += price * quantity;
                    }
                }

                txtTotal.Text = $"{total:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
/*
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=YOUR_SERVER_NAME;Database=CashierSystem;Trusted_Connection=True;"))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Insert into Transactions table
                        string insertTransaction = "INSERT INTO Transactions (Total, Discount) OUTPUT INSERTED.TransactionID VALUES (@Total, @Discount)";
                        SqlCommand cmd = new SqlCommand(insertTransaction, conn, transaction);
                        cmd.Parameters.AddWithValue("@Total", decimal.Parse(txtTotal.Text));
                        cmd.Parameters.AddWithValue("@Discount", decimal.Parse(txtDiscount.Text));
                        int transactionId = (int)cmd.ExecuteScalar();

                       // Insert into TransactionDetails table
                        foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                       {
                           if (row.Cells["PCode"].Value != null)
                            {
                                string insertDetails = "INSERT INTO TransactionDetails (TransactionID, ProductID, Quantity, SubTotal) " +
                                   "VALUES (@TransactionID, (SELECT ProductID FROM Products WHERE ProductCode = @ProductCode), @Quantity, @SubTotal)";
                                SqlCommand detailCmd = new SqlCommand(insertDetails, conn, transaction);
                               detailCmd.Parameters.AddWithValue("@TransactionID", transactionId);
                               detailCmd.Parameters.AddWithValue("@ProductCode", row.Cells["PCode"].Value.ToString());
                                detailCmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells["Qty"].Value));
                                detailCmd.Parameters.AddWithValue("@SubTotal", Convert.ToDecimal(row.Cells["Price"].Value) * Convert.ToInt32(row.Cells["Qty"].Value));
                                detailCmd.ExecuteNonQuery();
                            }
                       }

                          transaction.Commit();
                        MessageBox.Show("Transaction completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset transaction for the next one
                        InitializeTransaction();
                       dataGridViewProducts.Rows.Clear();
                    }
                    catch (Exception ex)
                    {
                       transaction.Rollback();
                        MessageBox.Show($"Transaction failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
           }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } */

        private void home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void helmet_Click(object sender, EventArgs e)
        {
            Helmets helmet = new Helmets();
            helmet.Show();
            this.Hide();
        }

        private void locks_Click(object sender, EventArgs e)
        {
            Locks locks = new Locks();
            locks.Show();
            this.Hide();
        }

        private void pedals_Click(object sender, EventArgs e)
        {
            Pedals pedals = new Pedals();
            pedals.Show();
            this.Hide();
        }

        private void pumps_Click(object sender, EventArgs e)
        {
            Pumps pump = new Pumps();
            pump.Show();
            this.Hide();
        }

        private void grips_Click(object sender, EventArgs e)
        {
            Grip grips = new Grip();
            grips.Show();
            this.Hide();
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_log_Click(object sender, EventArgs e)
        {
            SignIn form = new SignIn();
            form.Show();
            this.Close();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}



