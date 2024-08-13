namespace Database_Systems_Project
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            itemIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityInStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitOfMeasurementDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ReorderThreshold = new DataGridViewTextBoxColumn();
            inventoryItemsBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryItemsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(25, 130, 196);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { itemIdDataGridViewTextBoxColumn, itemNameDataGridViewTextBoxColumn, quantityInStockDataGridViewTextBoxColumn, unitOfMeasurementDataGridViewTextBoxColumn, ReorderThreshold });
            dataGridView1.DataSource = inventoryItemsBindingSource;
            dataGridView1.Location = new Point(55, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(828, 169);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            itemIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            itemIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock";
            quantityInStockDataGridViewTextBoxColumn.HeaderText = "QuantityInStock";
            quantityInStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            quantityInStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitOfMeasurementDataGridViewTextBoxColumn
            // 
            unitOfMeasurementDataGridViewTextBoxColumn.DataPropertyName = "UnitOfMeasurement";
            unitOfMeasurementDataGridViewTextBoxColumn.HeaderText = "UnitOfMeasurement";
            unitOfMeasurementDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitOfMeasurementDataGridViewTextBoxColumn.Name = "unitOfMeasurementDataGridViewTextBoxColumn";
            unitOfMeasurementDataGridViewTextBoxColumn.Width = 125;
            // 
            // ReorderThreshold
            // 
            ReorderThreshold.DataPropertyName = "ReorderThreshold";
            ReorderThreshold.HeaderText = "ReorderThreshold";
            ReorderThreshold.MinimumWidth = 6;
            ReorderThreshold.Name = "ReorderThreshold";
            ReorderThreshold.Width = 125;
            // 
            // inventoryItemsBindingSource
            // 
            inventoryItemsBindingSource.DataSource = typeof(InventoryItems);
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(55, 385);
            button1.Name = "button1";
            button1.Size = new Size(148, 26);
            button1.TabIndex = 1;
            button1.Text = "Add New Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(735, 385);
            button2.Name = "button2";
            button2.Size = new Size(148, 26);
            button2.TabIndex = 2;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15F);
            label1.Location = new Point(373, 28);
            label1.Name = "label1";
            label1.Size = new Size(237, 29);
            label1.TabIndex = 3;
            label1.Text = "Manage Inventory";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 130, 196);
            ClientSize = new Size(932, 633);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Consolas", 9F);
            Name = "InventoryForm";
            Text = "Inventory Form";
            Load += InventoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryItemsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource inventoryItemsBindingSource;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitOfMeasurementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ReorderThreshold;
        private Label label1;
    }
}