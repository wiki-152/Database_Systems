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
    public partial class AddInventoryItemForm : Form
    {
        List<InventoryItems> inventoryItemsLocal = new List<InventoryItems>();
        List<Suppliers> suppliersLocal = new List<Suppliers>();
        public AddInventoryItemForm()
        {
            InitializeComponent();

            // Get all the suppliers from the database
            suppliersLocal = SuppliersManager.GetAllSuppliers();

            // Add the suppliers to the datagridview

            dataGridView1.DataSource = suppliersLocal;

        }

        private void maskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is not a letter and also not a control character (like backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // This prevents the character from being entered
            }
        }

        private void maskedTextBoxnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is not a number and also not a control character (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // This prevents the character from being entered
            }

        }

        // Add Button
        private void button1_Click(object sender, EventArgs e)
        {
            // item name to string
            string itemName = Convert.ToString(maskedTextBox1.Text);
            int quantityInStock = Convert.ToInt32(maskedTextBox2.Text);
            string unitOfMeasurement = Convert.ToString(maskedTextBox3.Text);
            int reorderThreshold = Convert.ToInt32(maskedTextBox4.Text);
            int supplierId = Convert.ToInt32(maskedTextBox5.Text);

            // trim

            itemName = itemName.Trim();
            unitOfMeasurement = unitOfMeasurement.Trim();


            // Check if supplierid is valid

            bool supplierIdIsValid = false;

            foreach (Suppliers supplier in suppliersLocal)
            {
                if (supplier.SupplierId == supplierId)
                {
                    supplierIdIsValid = true;
                    break;
                }
            }

            if (!supplierIdIsValid)
            {
                MessageBox.Show("Invalid Supplier ID");
                return;
            }

            // Add the item to the database

            InventoryItemsManager.AddInventoryItem(itemName, quantityInStock, unitOfMeasurement, reorderThreshold, supplierId);

            MessageBox.Show("Inventory Item Added");

        }

        private void AddInventoryItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
