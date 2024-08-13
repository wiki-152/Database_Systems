using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database_Systems_Project
{
    public class Suppliers
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    internal class SuppliersManager
    {
        private static string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

        public static List<Suppliers> GetAllSuppliers()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Suppliers", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Suppliers supplier = new Suppliers();
                        supplier.SupplierId = reader.IsDBNull(reader.GetOrdinal("SupplierId")) ? 0 : reader.GetInt32(reader.GetOrdinal("SupplierId"));
                        supplier.SupplierName = reader.IsDBNull(reader.GetOrdinal("SupplierName")) ? null : reader.GetString(reader.GetOrdinal("SupplierName"));
                        supplier.ContactName = reader.IsDBNull(reader.GetOrdinal("ContactName")) ? null : reader.GetString(reader.GetOrdinal("ContactName"));
                        supplier.Phone = reader.IsDBNull(reader.GetOrdinal("Phone")) ? null : reader.GetString(reader.GetOrdinal("Phone"));
                        supplier.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email"));
                        suppliers.Add(supplier);
                    }
                }
            }
            return suppliers;
        }

        public static void UpdateSupplier(int supplierId, string supplierName, string contactName, string phone, string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Suppliers SET SupplierName = @SupplierName, ContactName = @ContactName, Phone = @Phone, Email = @Email WHERE SupplierId = @SupplierId", conn);
                cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                cmd.Parameters.AddWithValue("@ContactName", contactName);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteSupplier(int supplierId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Suppliers WHERE SupplierId = @SupplierId", conn);
                cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void InsertSupplier(string supplierName, string contactName, string phone, string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Suppliers (SupplierName, ContactName, Phone, Email) VALUES (@SupplierName, @ContactName, @Phone, @Email)", conn);
                cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                cmd.Parameters.AddWithValue("@ContactName", contactName);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
