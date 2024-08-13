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
    public partial class AdminForm : Form
    {
        Admin admin;
        public AdminForm(Admin admin = null)
        {
            InitializeComponent();

            this.admin = admin;

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;


        }


        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        // Profile button
        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;

            panel1.Visible = true;

            if (admin != null)
            {
                label9.Text = admin.FirstName;
                label10.Text = admin.LastName;
                label11.Text = admin.Email;
                label12.Text = admin.Address;
                label13.Text = admin.UserName;
                label14.Text = admin.Pass;
            }
            else
            {
                label9.Text = "-";
                label10.Text = "-";
                label11.Text = "-";
                label12.Text = "-";
                label13.Text = "-";
                label14.Text = "-";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (admin != null)
            {
                label9.Text = admin.FirstName;
                label10.Text = admin.LastName;
                label11.Text = admin.Email;
                label12.Text = admin.Address;
                label13.Text = admin.UserName;
                label14.Text = admin.Pass;
            }
        }


        // Manage Employees button
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            panel2.Visible = true;
        }

        // Manage Customers button
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            panel3.Visible = true;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        // edit customer
        private void button11_Click(object sender, EventArgs e)
        {
            // Open Message box and ask user to enter id of the customer
            string id = Microsoft.VisualBasic.Interaction.InputBox("Enter the ID of the customer you want to edit", "Edit Customer", "");

            // Check string all should be numbers
            if (id != null)
            {
                // there should be only numbers
                if (id.All(char.IsDigit) == false)
                {
                    MessageBox.Show("Invalid ID");
                    return;
                }
            }

            int customerId = 0;

            if (int.TryParse(id, out customerId))
            {
                // Search for the customer in the database

                List<Customer> customers = CustomerManager.GetAllCustomers();

                Customer customer = customers.Find(c => c.CustomerId == customerId);

                if (customer != null)
                {
                    // Open Edit Customer Form
                    EditCustomerForm editCustomerForm = new EditCustomerForm(customer);

                    editCustomerForm.Show();
                }
                else
                {
                    MessageBox.Show("Customer not found");
                }


            }
            else
            {
                MessageBox.Show("Invalid ID");
            }


        }

        // add customer
        private void button10_Click(object sender, EventArgs e)
        {
            // Open Add Customer Form
            AddCustomerForm addCustomerForm = new AddCustomerForm();

            addCustomerForm.Show();
        }

        // del customer
        private void button12_Click(object sender, EventArgs e)
        {
            // Open Message box and ask user to enter id of the customer
            string id = Microsoft.VisualBasic.Interaction.InputBox("Enter the ID of the customer you want to delete", "Delete Customer", "");

            if (id != null)
            {
                // there should be only numbers
                if (id.All(char.IsDigit) == false)
                {
                    MessageBox.Show("Invalid ID");
                    return;
                }
            }

            int customerId = 0;

            if (int.TryParse(id, out customerId))
            {
                // Search for the customer in the database

                List<Customer> customers = CustomerManager.GetAllCustomers();

                Customer customer = customers.Find(c => c.CustomerId == customerId);

                if (customer != null)
                {
                    CustomerManager.DeleteCustomer(customerId);

                    MessageBox.Show("Customer deleted successfully");
                }
                else
                {
                    MessageBox.Show("Customer not found");
                }
            }
        }

        // Edit Admin Profile
        private void button6_Click(object sender, EventArgs e)
        {
            // Open EditAdminForm
            EditAdminForm editAdminForm = new EditAdminForm(admin);

            editAdminForm.Show();
        }

        // View Customers
        private void button13_Click(object sender, EventArgs e)
        {
            // Load All Customers from the database to datagridview

            List<Customer> customers = CustomerManager.GetAllCustomers();

            dataGridView1.DataSource = customers;


        }

        // add employee
        private void button4_Click(object sender, EventArgs e)
        {

        }

        // edit employee
        private void button9_Click(object sender, EventArgs e)
        {

            // Open Message box and ask user to enter id of the customer
            string id = Microsoft.VisualBasic.Interaction.InputBox("Enter the ID of the customer you want to edit", "Edit Employee", "");

            // Check string all should be numbers
            if (id != null)
            {
                // there should be only numbers
                if (id.All(char.IsDigit) == false)
                {
                    MessageBox.Show("Invalid ID");
                    return;
                }
            }

            int customerId = 0;

            if (int.TryParse(id, out customerId))
            {
                // Search for the customer in the database

                List<Employee> employees = new List<Employee>();

                Employee emp = employees.Find(e => e.EmployeeId == customerId);

                if (emp != null)
                {
                    // Open Edit Customer Form
                    EditEmployeeForm editEmployeeForm = new EditEmployeeForm(emp);

                    editEmployeeForm.Show();
                }
                else
                {
                    MessageBox.Show("Employee not found");
                }


            }
            else
            {
                MessageBox.Show("Invalid ID");
            }


        }

        // delete employee
        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
