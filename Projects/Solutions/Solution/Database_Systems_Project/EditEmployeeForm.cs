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
    public partial class EditEmployeeForm : Form
    {
        Employee Employee;
        public EditEmployeeForm(Employee employee)
        {
            InitializeComponent();
            Employee = employee;

            maskedTextBox2.Text = employee.FirstName;
            maskedTextBox3.Text = employee.LastName;
            maskedTextBox5.Text = employee.Username;
            maskedTextBox6.Text = employee.Pass;

            richTextBox1.Text = employee.Address;

            dateTimePicker1.Value = employee.Date_of_birth;
        }

        // save button
        private void button1_Click(object sender, EventArgs e)
        {
            Employeemanager.UpdateEmployee(Employee.EmployeeId,  maskedTextBox2.Text, maskedTextBox3.Text, Employee.Role,maskedTextBox5.Text,maskedTextBox6.Text, Employee.Salary, Employee.ManagerId, richTextBox1.Text, dateTimePicker1.Value);

            MessageBox.Show("Employee updated successfully!");

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
