using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database_Systems_Project
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public bool Availability { get; set; }
        public int MenuId { get; set; }
        public string Image { get; set; }
    }
    internal class ProductManager
    {
        private static string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Products", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.ProductId = reader.IsDBNull(reader.GetOrdinal("ProductId")) ? 0 : reader.GetInt32(reader.GetOrdinal("ProductId"));
                        product.ProductName = reader.IsDBNull(reader.GetOrdinal("ProductName")) ? null : reader.GetString(reader.GetOrdinal("ProductName"));
                        product.Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description"));
                        product.Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Price"));
                        product.Category = reader.IsDBNull(reader.GetOrdinal("Category")) ? null : reader.GetString(reader.GetOrdinal("Category"));
                        product.Availability = reader.IsDBNull(reader.GetOrdinal("Availability")) ? false : reader.GetBoolean(reader.GetOrdinal("Availability"));
                        product.MenuId = reader.IsDBNull(reader.GetOrdinal("MenuId")) ? 0 : reader.GetInt32(reader.GetOrdinal("MenuId"));
                        product.Image = reader.IsDBNull(reader.GetOrdinal("Image")) ? null : reader.GetString(reader.GetOrdinal("Image"));
                        products.Add(product);
                    }
                }
            }
            return products;
        }


    }
}
