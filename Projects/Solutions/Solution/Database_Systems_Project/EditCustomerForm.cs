using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Systems_Project
{
    public partial class EditCustomerForm : Form
    {
        Customer customer;
        public EditCustomerForm(Customer customer)
        {
            InitializeComponent();

            maskedTextBox2.Text = customer.FirstName;
            maskedTextBox3.Text = customer.LastName;
            maskedTextBox4.Text = customer.Email;
            maskedTextBox1.Text = customer.PhoneNumber;
            maskedTextBox5.Text = customer.Username;
            maskedTextBox6.Text = customer.Pass;
            richTextBox1.Text = customer.Address;

            dateTimePicker1.Value = customer.Date_of_birth;

            this.customer = customer;


        }

        // Save button
        private void button1_Click(object sender, EventArgs e)
        {
            // send all data to CustomerManager.UpdateCustomer
            CustomerManager.UpdateCustomer(customer.CustomerId, maskedTextBox2.Text, maskedTextBox3.Text, maskedTextBox4.Text, maskedTextBox1.Text, maskedTextBox5.Text, maskedTextBox6.Text, richTextBox1.Text, dateTimePicker1.Value);

            MessageBox.Show("Customer updated successfully!");

            this.Close();

        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
