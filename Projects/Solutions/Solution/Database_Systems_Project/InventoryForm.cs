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

    public partial class InventoryForm : Form
    {
        List<InventoryItems> inventoryItemsLocal = new List<InventoryItems>();
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            List<InventoryItems> inventoryItems = InventoryItemsManager.GetAllInventoryItems();

            inventoryItemsLocal = inventoryItems;


            dataGridView1.DataSource = inventoryItems;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "dataGridViewDeleteButton";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButtonColumn);

            dataGridView1.Columns[0].ReadOnly = true;



            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if click is on a delete button
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Optionally ask for confirmation
                if (MessageBox.Show("Are you sure you want to delete this row?", "Confirm deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    // Get the value of the first cell in the row
                    int inventoryItemId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    MessageBox.Show("Inventory Item ID: " + inventoryItemId);

                    // Delete the row
                    InventoryItemsManager.DeleteInventoryItem(inventoryItemId);

                    // Refresh the grid
                    List<InventoryItems> inventoryItems = InventoryItemsManager.GetAllInventoryItems();
                    dataGridView1.DataSource = inventoryItems;

                }
            }
        }

        // Save button
        private void button2_Click(object sender, EventArgs e)
        {
            // update all rows in database

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                int itemId = Convert.ToInt32(row.Cells[0].Value);
                string itemName = row.Cells[1].Value.ToString();
                int quantityInStock = Convert.ToInt32(row.Cells[2].Value);
                string unitOfMeasurement = row.Cells[3].Value.ToString();
                int reorderThreshold = Convert.ToInt32(row.Cells[4].Value);
                int supplierId = inventoryItemsLocal.Find(x => x.ItemId == itemId).SupplierId;

                InventoryItemsManager.UpdateInventoryItem(itemId, itemName, quantityInStock, unitOfMeasurement, reorderThreshold, supplierId);
            }

            MessageBox.Show("Inventory Items Updated");
        }

        // Add new item
        private void button1_Click(object sender, EventArgs e)
        {
            AddInventoryItemForm addInventoryItemForm = new AddInventoryItemForm();
            addInventoryItemForm.Show();
        }
    }
}
