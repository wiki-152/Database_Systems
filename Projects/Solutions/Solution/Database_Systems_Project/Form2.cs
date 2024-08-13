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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Sign Up button
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled

            if (maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || maskedTextBox3.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            // Check if username exsts
            List<Customer> customers = CustomerManager.GetAllCustomers();
            List<Employee> employees = Employeemanager.GetAllEmployees();
            List<Admin> admins = AdminManager.GetAllAdmins();
            List<DataAnaylst> dataAnalysts = DataAnalystManager.GetAllDataAnalysts();

            bool usernameExists = false;

            foreach (Customer customer1 in customers)
            {
                if (customer1.Username == maskedTextBox1.Text)
                {
                    usernameExists = true;
                    break;
                }
            }

            foreach (Employee employee in employees)
            {
                if (employee.Username == maskedTextBox1.Text)
                {
                    usernameExists = true;
                    break;
                }
            }

            foreach (Admin admin in admins)
            {
                if (admin.UserName == maskedTextBox1.Text)
                {
                    usernameExists = true;
                    break;
                }
            }

            foreach (DataAnaylst dataAnalyst in dataAnalysts)
            {
                if (dataAnalyst.Username == maskedTextBox1.Text)
                {
                    usernameExists = true;
                    break;
                }
            }

            if (usernameExists)
            {
                MessageBox.Show("Username already exists. Please choose another one.");
                return;
            }

            // Check if pass same

            if (maskedTextBox2.Text != maskedTextBox3.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            // Save the data to the database

            Customer customer = new Customer();

            customer.Username = maskedTextBox1.Text;
            customer.Pass = maskedTextBox2.Text;

            // trim whitespaces

            customer.Username = customer.Username.Trim();
            customer.Pass = customer.Pass.Trim();

            string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customers (Username, Pass) VALUES (@Username, @Pass)", conn);
                cmd.Parameters.AddWithValue("@Username", customer.Username);
                cmd.Parameters.AddWithValue("@Pass", customer.Pass);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Sign Up Successful!");

            // Open the login form

            Form1 form1 = new Form1();

            this.Hide();

            form1.Closed += (s, args) => this.Close();

            form1.Show();




        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            // Close this and open sign in

            Form1 form1 = new Form1();

            this.Hide();

            form1.Closed += (s, args) => this.Close();

            form1.Show();



        }
    }
}
