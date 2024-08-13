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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        // User First Name
        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is not a letter and also not a control character (like backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // This prevents the character from being entered
            }
        }

        // Clear Button
        private void button2_Click(object sender, EventArgs e)
        {
            // Make All Text Boxes Empty
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox6.Text = "";

            richTextBox1.Text = "";

        }

        // Save Button
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

            string firstName = maskedTextBox2.Text;
            string lastName = maskedTextBox3.Text;
            string address = richTextBox1.Text;
            string email = maskedTextBox4.Text;
            string phone = maskedTextBox1.Text;
            string username = maskedTextBox5.Text;
            string password = maskedTextBox6.Text;
            DateTime date = dateTimePicker1.Value;

            // remove whitespaces from username and password

            username = username.Trim();
            password = password.Trim();

            // Extract Only date from the DateTimePicker
            string dateOfBirth = date.ToString("yyyy-MM-dd");

            //MessageBox.Show(dateOfBirth);

            // Check if all fields are filled
            if (maskedTextBox5.Text == "" || maskedTextBox6.Text == "")
            {
                MessageBox.Show("Please fill username and password fields");
            }
            else
            {
                // Save the data to the database
                string query = "INSERT INTO Customers ( FirstName, LastName,Email, PhoneNumber, Date_of_birth, Username, Pass, Address) VALUES ('" + firstName + "','" + lastName + "','" + email + "','" + phone + "','" + dateOfBirth + "','" + username + "','" + password + "','" + address + "')";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Customer Added Successfully");
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
