using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database_Systems_Project
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public string TransactionType { get; set; }
        public Decimal TotalAmount { get; set; }
        public int RegisterId { get; set; }
    }
    internal class TransactionManager
    {
        private static string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

        public static List<Transaction> GetAllTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Transactions", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Transaction transaction = new Transaction();
                        transaction.TransactionId = reader.IsDBNull(reader.GetOrdinal("TransactionId")) ? 0 : reader.GetInt32(reader.GetOrdinal("TransactionId"));
                        transaction.CustomerId = reader.IsDBNull(reader.GetOrdinal("CustomerId")) ? 0 : reader.GetInt32(reader.GetOrdinal("CustomerId"));
                        transaction.EmployeeId = reader.IsDBNull(reader.GetOrdinal("EmployeeId")) ? 0 : reader.GetInt32(reader.GetOrdinal("EmployeeId"));
                        transaction.TransactionDateTime = reader.IsDBNull(reader.GetOrdinal("TransactionDateTime")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("TransactionDateTime"));
                        transaction.TransactionType = reader.IsDBNull(reader.GetOrdinal("TransactionType")) ? null : reader.GetString(reader.GetOrdinal("TransactionType"));
                        transaction.TotalAmount = reader.IsDBNull(reader.GetOrdinal("TotalAmount")) ? 0 : reader.GetDecimal(reader.GetOrdinal("TotalAmount"));
                        transaction.RegisterId = reader.IsDBNull(reader.GetOrdinal("RegisterId")) ? 0 : reader.GetInt32(reader.GetOrdinal("RegisterId"));

                        transactions.Add(transaction);
                    }
                }
            }
            return transactions;
        }
        
    }
}
