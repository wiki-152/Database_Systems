using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database_Systems_Project
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public double Salary { get; set; }
        public int ManagerId { get; set; }
        public string Address { get; set; }
        public DateTime Date_of_birth { get; set; }


    }
    internal class Employeemanager
    {
        private static string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee employee = new Employee();
                        employee.EmployeeId = reader.IsDBNull(reader.GetOrdinal("EmployeeId")) ? 0 : reader.GetInt32(reader.GetOrdinal("EmployeeId"));
                        employee.FirstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? null : reader.GetString(reader.GetOrdinal("FirstName"));
                        employee.LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? null : reader.GetString(reader.GetOrdinal("LastName"));
                        employee.Role = reader.IsDBNull(reader.GetOrdinal("Role")) ? null : reader.GetString(reader.GetOrdinal("Role"));
                        employee.Username = reader.IsDBNull(reader.GetOrdinal("Username")) ? null : reader.GetString(reader.GetOrdinal("Username"));
                        employee.Pass = reader.IsDBNull(reader.GetOrdinal("Pass")) ? null : reader.GetString(reader.GetOrdinal("Pass"));
                        employee.Salary = reader.IsDBNull(reader.GetOrdinal("Salary")) ? 0.0 : Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("Salary")));
                        employee.ManagerId = reader.IsDBNull(reader.GetOrdinal("ManagerId")) ? 0 : reader.GetInt32(reader.GetOrdinal("ManagerId"));
                        employee.Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? null : reader.GetString(reader.GetOrdinal("Address"));
                        employee.Date_of_birth = reader.IsDBNull(reader.GetOrdinal("Date_of_birth")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("Date_of_birth"));

                        employee.Salary = reader.IsDBNull(reader.GetOrdinal("Salary")) ? 0.0 : Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("Salary")));

                        employees.Add(employee);
                    }
                }
            }
            return employees;
        }

        // Update
        public static void UpdateEmployee(int employeeId, string firstName, string lastName, string role, string username, string pass, double salary, int managerId, string address, DateTime dateOfBirth)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Role = @Role, Username = @Username, Pass = @Pass, Salary = @Salary, ManagerId = @ManagerId, Address = @Address, Date_of_birth = @Date_of_birth WHERE EmployeeId = @EmployeeId", conn);
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Pass", pass);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.Parameters.AddWithValue("@ManagerId", managerId);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Date_of_birth", dateOfBirth);

                cmd.ExecuteNonQuery();
            }
        }

        //delete




    }






}
