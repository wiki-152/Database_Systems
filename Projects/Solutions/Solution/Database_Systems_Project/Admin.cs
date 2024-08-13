
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace Database_Systems_Project
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime Date_of_birth { get; set; }



    }
    internal class AdminManager
    {
        private static string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

        public static List<Admin> GetAllAdmins()
        {
            List<Admin> admins = new List<Admin>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Admins", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Admin admin = new Admin();
                        admin.AdminId = reader.IsDBNull(reader.GetOrdinal("AdminId")) ? 0 : reader.GetInt32(reader.GetOrdinal("AdminId"));
                        admin.FirstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? null : reader.GetString(reader.GetOrdinal("FirstName"));
                        admin.LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? null : reader.GetString(reader.GetOrdinal("LastName"));
                        admin.UserName = reader.IsDBNull(reader.GetOrdinal("UserName")) ? null : reader.GetString(reader.GetOrdinal("UserName"));
                        admin.Pass = reader.IsDBNull(reader.GetOrdinal("Pass")) ? null : reader.GetString(reader.GetOrdinal("Pass"));
                        admin.Salary = reader.IsDBNull(reader.GetOrdinal("Salary")) ? 0.0 : Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("Salary")));
                        admin.Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? null : reader.GetString(reader.GetOrdinal("Address"));
                        admin.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email"));
                        admin.Date_of_birth = reader.IsDBNull(reader.GetOrdinal("Date_of_birth")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("Date_of_birth"));

                        admin.Salary = reader.IsDBNull(reader.GetOrdinal("Salary")) ? 0.0 : Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("Salary")));

                        admins.Add(admin);
                    }
                }
            }
            return admins;
        }

        //Update Admin

        public static void UpdateAdmin(int AdminId, string FirstName, string LastName, string Email, string Username, string Pass, string Address, DateTime Date_of_birth)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Admins SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Username = @Username, Pass = @Pass, Address = @Address, Date_of_birth = @Date_of_birth WHERE AdminId = @AdminId", conn);
                cmd.Parameters.AddWithValue("@AdminId", AdminId);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Pass", Pass);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Date_of_birth", Date_of_birth);

                cmd.ExecuteNonQuery();

                conn.Close();


            }
        }

    }
}
