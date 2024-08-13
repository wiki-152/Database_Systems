using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Database_Systems_Project
{
    public partial class CartForm : Form
    {
        List<Product> cartProducts;
        Customer customer;
        public CartForm(List<Product> products, Customer input = null)
        {
            InitializeComponent();

            this.cartProducts = products;

            //MessageBox.Show(products.Count.ToString());

            this.Load += CartForm_Load;

            if (input != null)
            {
                this.customer = input;
            }
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cartProducts;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Place Order Button
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string query = "SELECT MAX(TransactionId) FROM Transactions";

                int transactionId = 0;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            transactionId = reader.GetInt32(0);
                        }
                    }
                }

                transactionId++;

                query = "INSERT INTO Transactions (CustomerId, EmployeeId,TransactionDateTime, TransactionType ,RegisterId) VALUES (@CustomerId, @EmployeeId, @TransactionDateTime, @TransactionType, @RegisterId)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DateTime dateTime = DateTime.Now;

                    command.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
                    command.Parameters.AddWithValue("@EmployeeId", 1);
                    command.Parameters.AddWithValue("@TransactionDateTime", dateTime);
                    command.Parameters.AddWithValue("@TransactionType", "Sale");

                    

                    command.Parameters.AddWithValue("@RegisterId", 2);

                    command.ExecuteNonQuery();
                }

                foreach (Product product in cartProducts)
                {
                    query = "INSERT INTO TransactionItems (ProductId, TransactionId, Quantity, Price) VALUES (@ProductId, @TransactionId, @Quantity, @Price)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductId", product.ProductId);
                        command.Parameters.AddWithValue("@TransactionId", transactionId);
                        command.Parameters.AddWithValue("@Quantity", 1);
                        command.Parameters.AddWithValue("@Price", product.Price);

                        command.ExecuteNonQuery();
                    }
                }

            }

            // Clear Cart

            cartProducts = new List<Product>();



            dataGridView1.DataSource = cartProducts;


            MessageBox.Show("Order Placed Successfully");
        }

        // Remove from Cart Button
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Product product = row.DataBoundItem as Product;
                if (product != null)
                {
                    sb.AppendLine($"Name: {product.ProductName}, ID: {product.ProductId}");

                    if (product.ProductId != 0)
                    {
                        cartProducts.Remove(product);
                        
                        // Display Product also
                        MessageBox.Show(product.ProductName);
                        MessageBox.Show("Product removed from cart");

                        dataGridView1.DataSource = null;

                        dataGridView1.DataSource = cartProducts;

                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            //MessageBox.Show(sb.ToString(), "Selected Menu Details");

        }
    }
}
