using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database_Systems_Project
{
    public class DataAnaylst
    {
        public int DataAnalystId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date_of_birth { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public Decimal Salary { get; set; }
        public string Address { get; set; }


    }


    internal class DataAnalystManager
    {
        private static string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

        public static List<DataAnaylst> GetAllDataAnalysts()
        {
            List<DataAnaylst> dataAnalysts = new List<DataAnaylst>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DataAnalyst", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // if null, set accordingly
                        DataAnaylst dataAnalyst = new DataAnaylst();
                        dataAnalyst.DataAnalystId = reader.IsDBNull(reader.GetOrdinal("DataAnalystId")) ? 0 : reader.GetInt32(reader.GetOrdinal("DataAnalystId"));
                        dataAnalyst.FirstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? null : reader.GetString(reader.GetOrdinal("FirstName"));
                        dataAnalyst.LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? null : reader.GetString(reader.GetOrdinal("LastName"));
                        dataAnalyst.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email"));
                        dataAnalyst.Username = reader.IsDBNull(reader.GetOrdinal("Username")) ? null : reader.GetString(reader.GetOrdinal("Username"));
                        dataAnalyst.Pass = reader.IsDBNull(reader.GetOrdinal("Pass")) ? null : reader.GetString(reader.GetOrdinal("Pass"));
                        dataAnalyst.Salary = reader.IsDBNull(reader.GetOrdinal("Salary")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Salary"));
                        dataAnalyst.Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? null : reader.GetString(reader.GetOrdinal("Address"));
                        dataAnalyst.Date_of_birth = reader.IsDBNull(reader.GetOrdinal("Date_of_birth")) ? default : reader.GetDateTime(reader.GetOrdinal("Date_of_birth"));

                        dataAnalysts.Add(dataAnalyst);
                    }
                }
            }
            return dataAnalysts;
        }

        public static void UpdateDataAnalyst(int dataAnalystId, string firstName, string lastName, string email, string username, string pass, Decimal salary, string address, DateTime date_of_birth)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE DataAnalyst SET FirstName = '" + firstName + "', LastName = '" + lastName + "', Email = '" + email + "', Username = '" + username + "', Pass = '" + pass + "', Salary = '" + salary + "', Address = '" + address + "', Date_of_birth = '" + date_of_birth + "' WHERE DataAnalystId = " + dataAnalystId;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteDataAnalyst(int dataAnalystId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM DataAnalyst WHERE DataAnalystId = " + dataAnalystId;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
