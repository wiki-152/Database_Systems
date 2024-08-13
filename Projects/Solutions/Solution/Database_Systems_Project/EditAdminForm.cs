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
    public partial class EditAdminForm : Form
    {
        Admin Admin;
        public EditAdminForm(Admin input = null)
        {
            InitializeComponent();

            Admin = input;

            if (Admin != null)
            {
                maskedTextBox2.Text = Admin.FirstName;
                maskedTextBox3.Text = Admin.LastName;
                maskedTextBox4.Text = Admin.Email;
                maskedTextBox5.Text = Admin.UserName;
                maskedTextBox6.Text = Admin.Pass;
                richTextBox1.Text = Admin.Address;

                dateTimePicker1.Value = Admin.Date_of_birth;
            }
        }

        // Save button
        private void button1_Click(object sender, EventArgs e)
        {
            // send all data to AdminManager.UpdateAdmin
            AdminManager.UpdateAdmin(Admin.AdminId, maskedTextBox2.Text, maskedTextBox3.Text, maskedTextBox4.Text, maskedTextBox5.Text, maskedTextBox6.Text, richTextBox1.Text, dateTimePicker1.Value);

            MessageBox.Show("Admin updated successfully!");

            this.Close();
        }
    }
}
