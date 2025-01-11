/*using System;
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

        private void AddProductToGrid(string barcode)
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
        } 

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

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}*/
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Sportivex
{
    public partial class Home : Form
    {
        // Connection string to connect to the MySQL database
        private string connectionString = "server=localhost;database=sportivex;uid=root;pwd=;";

        public Home()
        {
            InitializeComponent();
            AddTestColumns(); // Ensure DataGridView has the necessary columns

            // Attach the SelectionChanged event
            dataGridViewProducts.SelectionChanged += DataGridViewProducts_SelectionChanged;
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            string input = txtBarcode.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                // Fetch matching products
                DataTable matchingProducts = GetMatchingProducts(input);

                // Display the products in the DataGridView
                dataGridViewProducts.Rows.Clear();
                foreach (DataRow row in matchingProducts.Rows)
                {
                    dataGridViewProducts.Rows.Add(row.ItemArray);
                }
            }
        }

        private DataTable GetMatchingProducts(string input)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM product WHERE BarcodeValue LIKE @input";
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@input", "%" + input + "%");

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string input = txtBarcode.Text.Trim(); // Get the input from the TextBox

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a barcode to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable exactProduct = GetExactProduct(input);

            if (exactProduct.Rows.Count > 0)
            {
                // If the product exists, display it in the DataGridView
                dataGridViewProducts.Rows.Clear(); // Clear previous results
                foreach (DataRow row in exactProduct.Rows)
                {
                    dataGridViewProducts.Rows.Add(
                        row["ProductId"],
                        row["ProductName"],
                        row["BarcodeValue"],
                        
                        row["Price"],
                        row["Description"],
                        row["DateAdded"]
                    );
                }
            }
            else
            {
                MessageBox.Show("THIS PRODUCT DOESN'T EXIST", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable GetExactProduct(string barcode)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM product WHERE BarcodeValue = @barcode";
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@barcode", barcode);

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        // Handle DataGridView selection change
        private void DataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                // Clear the ListView before adding new items
             

                // Ensure that the ListView is set up with the proper columns
                lista.View = View.Details;
                lista.Columns.Clear(); // Clear any existing columns (useful if you want to reset the columns)
                lista.Columns.Add("Item", 150);  // Column for item names
                lista.Columns.Add("Price", 80); // Column for prices

                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewProducts.SelectedRows[0];

                // Validate that required columns exist
                string nameColumn = "name";       // Name column name
                string priceColumn = "price";     // Price column name

                if (!dataGridViewProducts.Columns.Contains(nameColumn) ||
                    !dataGridViewProducts.Columns.Contains(priceColumn))
                {
                    MessageBox.Show("One or more required columns (Name, Price) are missing from the DataGridView.",
                                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Retrieve values from the selected row
                string name = selectedRow.Cells[nameColumn].Value?.ToString();
                string priceText = selectedRow.Cells[priceColumn].Value?.ToString();
                decimal price = 0;

                if (!decimal.TryParse(priceText, out price))
                {
                    MessageBox.Show("Invalid price value in the selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new ListViewItem with the item name and add the price as a sub-item
                ListViewItem listViewItem = new ListViewItem(name);           // The item name is the first column
                listViewItem.SubItems.Add(price.ToString("C"));               // The price is the second column

                // Add the new ListViewItem to the ListView
                lista.Items.Add(listViewItem);

                // Update the sales total
                decimal currentTotal = 0;
                decimal.TryParse(txtTotal.Text, out currentTotal);
                txtTotal.Text = (currentTotal + price).ToString("F2");
            }
        }

        // Example method to add columns to the DataGridView for testing purposes
        private void AddTestColumns()
        {
            if (dataGridViewProducts.Columns.Count == 0)
            {
                dataGridViewProducts.Columns.Add("ProductId", "No.");
                dataGridViewProducts.Columns.Add("BarcodeValue", "Barcode");
                dataGridViewProducts.Columns.Add("ProductName", "Name");
                dataGridViewProducts.Columns.Add("Price", "Price");
                dataGridViewProducts.Columns.Add("Description", "Description");
                dataGridViewProducts.Columns.Add("DateAdded", "Date");
            }
        }

        private void bt_log_Click(object sender, EventArgs e)
        {
            SignIn form = new SignIn();
            form.Show();
            this.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

   
    }
}


