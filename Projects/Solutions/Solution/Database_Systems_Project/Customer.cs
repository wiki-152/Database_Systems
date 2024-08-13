using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Systems_Project
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Address { get; set; }
        public DateTime Date_of_birth { get; set; }


        // Parameter constructor
        public Customer(int customerId=0, string firstName=null, string lastName=null, string email=null, string phoneNumber=null, string username=null, string pass=null, string address=null, DateTime date_of_birth=default)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Username = username;
            Pass = pass;
            Address = address;
            Date_of_birth = date_of_birth;
        }

    }

    public class CustomerManager
    {
        private static string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // if null, set accordingly
                        Customer customer = new Customer();
                        customer.CustomerId = reader.IsDBNull(reader.GetOrdinal("CustomerId")) ? 0 : reader.GetInt32(reader.GetOrdinal("CustomerId"));
                        customer.FirstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? null : reader.GetString(reader.GetOrdinal("FirstName"));
                        customer.LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? null : reader.GetString(reader.GetOrdinal("LastName"));
                        customer.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email"));
                        customer.PhoneNumber = reader.IsDBNull(reader.GetOrdinal("PhoneNumber")) ? null : reader.GetString(reader.GetOrdinal("PhoneNumber"));
                        customer.Username = reader.IsDBNull(reader.GetOrdinal("Username")) ? null : reader.GetString(reader.GetOrdinal("Username"));
                        customer.Pass = reader.IsDBNull(reader.GetOrdinal("Pass")) ? null : reader.GetString(reader.GetOrdinal("Pass"));
                        customer.Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? null : reader.GetString(reader.GetOrdinal("Address"));
                        customer.Date_of_birth = reader.IsDBNull(reader.GetOrdinal("Date_of_birth")) ? default : reader.GetDateTime(reader.GetOrdinal("Date_of_birth"));

                        customers.Add(customer);

                    }
                }
            }
            return customers;
        }

        public static void UpdateCustomer(int customerId, string firstName, string lastName, string email, string phoneNumber, string username, string pass, string address, DateTime date_of_birth)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Customers SET FirstName=@FirstName, LastName=@LastName, Email=@Email, PhoneNumber=@PhoneNumber, Username=@Username, Pass=@Pass, Address=@Address, Date_of_birth=@Date_of_birth WHERE CustomerId=@CustomerId", conn);
                
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Pass", pass);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Date_of_birth", date_of_birth);

                cmd.ExecuteNonQuery();

                conn.Close();

            }            
        }

        // Delete customer

        public static void DeleteCustomer(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Customers WHERE CustomerId=@CustomerId", conn);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }


    }

}
