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
    public partial class EmployeeForm : Form
    {
        Employee employee;
        public EmployeeForm(Employee input)
        {
            InitializeComponent();

            employee = input;

            panel2.Visible = false;
            panel3.Visible = false;


            // Hide datagridview1

            dataGridView1.Visible = false;


        }

        // Inventory Button
        private void button1_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

            panel2.Visible = false;
            dataGridView1.Visible = false;


        }

        // report button
        private void button3_Click(object sender, EventArgs e)
        {
            // Open report form

            ReportForm reportForm = new ReportForm();

            reportForm.Show();


        }

        public void LoadTransactions()
        {
            List<Transaction> transactions = TransactionManager.GetAllTransactions();

            if (employee != null)
            {
                for (int i = transactions.Count - 1; i >= 0; i--)
                {
                    if (transactions[i].EmployeeId != employee.EmployeeId)
                    {
                        transactions.RemoveAt(i);
                    }
                }

                dataGridView1.DataSource = transactions;


                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }


        }

        // History button  
        private void button4_Click(object sender, EventArgs e)
        {
            // Load all transactions where 

            LoadTransactions();

            dataGridView1.Visible = true;

            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

            panel3.Visible = false;
            dataGridView1.Visible = false;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditEmployeeForm editEmployeeForm = new EditEmployeeForm(employee);

            editEmployeeForm.Show();
        }
    }
}
