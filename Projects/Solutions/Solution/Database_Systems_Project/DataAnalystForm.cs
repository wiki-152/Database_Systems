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
    public partial class DataAnalystForm : Form
    {
        DataAnaylst dataAnaylst;
        public DataAnalystForm(DataAnaylst dataAnalyst)
        {
            InitializeComponent();
            this.dataAnaylst = dataAnalyst;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DataAnalystForm_Load(object sender, EventArgs e)
        {

        }

        // Report Button
        private void button3_Click(object sender, EventArgs e)
        {
            // Open Report Form
            ReportForm reportForm = new ReportForm();

            // Show Report Form
            reportForm.Show();
        }

        // Inventory Button
        private void button2_Click(object sender, EventArgs e)
        {
            // Open Inventory Form
            InventoryForm inventoryForm = new InventoryForm();

            // Show Inventory Form
            inventoryForm.Show();

        }

        // Edit Button
        private void button6_Click(object sender, EventArgs e)
        {
            // Open EditDataAnalystForm

            EditDataAnalystForm editDataAnalystForm = new EditDataAnalystForm(dataAnaylst);

            // Show EditDataAnalystForm
            editDataAnalystForm.Show();


        }
    }
}
