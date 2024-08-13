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
    public partial class EditDataAnalystForm : Form
    {
        DataAnaylst dataAnalyst;
        public EditDataAnalystForm(DataAnaylst input = null)
        {
            InitializeComponent();

            // Set the input DataAnalyst
            dataAnalyst = input;

            if (input != null)
            {
                // Set the textboxes to the values of the input DataAnalyst
                maskedTextBox2.Text = input.FirstName;
                maskedTextBox3.Text = input.LastName;
                maskedTextBox4.Text = input.Email;
                maskedTextBox5.Text = input.Username;
                maskedTextBox6.Text = input.Pass;

                richTextBox1.Text = input.Address;

                dateTimePicker1.Value = input.Date_of_birth;

            }
        }

        // Save Button
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the values from the textboxes
            string firstName = maskedTextBox2.Text;
            string lastName = maskedTextBox3.Text;
            string email = maskedTextBox4.Text;
            string username = maskedTextBox5.Text;
            string pass = maskedTextBox6.Text;
            string address = richTextBox1.Text;
            DateTime date_of_birth = dateTimePicker1.Value;

            // If the input DataAnalyst is null, create a new DataAnalyst
            if (dataAnalyst == null)
            {
                dataAnalyst = new DataAnaylst();
            }

            // Set the values of the DataAnalyst
            dataAnalyst.FirstName = firstName;
            dataAnalyst.LastName = lastName;
            dataAnalyst.Email = email;
            dataAnalyst.Username = username;
            dataAnalyst.Pass = pass;
            dataAnalyst.Address = address;
            dataAnalyst.Date_of_birth = date_of_birth;

            // Update the DataAnalyst
            DataAnalystManager.UpdateDataAnalyst(dataAnalyst.DataAnalystId, firstName, lastName, email, username, pass, dataAnalyst.Salary, address, date_of_birth);

            MessageBox.Show("Data Analyst Updated Successfully!");

            // Close the form
            this.Close();

        }
    }
}
