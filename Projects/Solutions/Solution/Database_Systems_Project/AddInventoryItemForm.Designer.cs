namespace Database_Systems_Project
{
    partial class AddInventoryItemForm
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
            supplierIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            suppliersBindingSource = new BindingSource(components);
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)suppliersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { supplierIdDataGridViewTextBoxColumn, supplierNameDataGridViewTextBoxColumn, contactNameDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn });
            dataGridView1.DataSource = suppliersBindingSource;
            dataGridView1.Location = new Point(132, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(676, 159);
            dataGridView1.TabIndex = 0;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            supplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId";
            supplierIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            supplierIdDataGridViewTextBoxColumn.ReadOnly = true;
            supplierIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            supplierNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            contactNameDataGridViewTextBoxColumn.HeaderText = "ContactName";
            contactNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            contactNameDataGridViewTextBoxColumn.ReadOnly = true;
            contactNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // suppliersBindingSource
            // 
            suppliersBindingSource.DataSource = typeof(Suppliers);
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(363, 531);
            button1.Name = "button1";
            button1.Size = new Size(129, 41);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F);
            label1.Location = new Point(166, 229);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 2;
            label1.Text = "Item Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F);
            label2.Location = new Point(166, 283);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F);
            label3.Location = new Point(166, 330);
            label3.Name = "label3";
            label3.Size = new Size(186, 23);
            label3.TabIndex = 5;
            label3.Text = "Measurement Unit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F);
            label4.Location = new Point(166, 377);
            label4.Name = "label4";
            label4.Size = new Size(197, 23);
            label4.TabIndex = 4;
            label4.Text = "Reorder Threshold";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F);
            label5.Location = new Point(166, 421);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 7;
            label5.Text = "Supplier ID";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Consolas", 12F);
            maskedTextBox1.Location = new Point(486, 226);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 31);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.KeyPress += maskedTextBox_KeyPress;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Consolas", 12F);
            maskedTextBox2.Location = new Point(486, 283);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 31);
            maskedTextBox2.TabIndex = 9;
            maskedTextBox2.KeyPress += maskedTextBoxnum_KeyPress;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Font = new Font("Consolas", 12F);
            maskedTextBox3.Location = new Point(486, 330);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(125, 31);
            maskedTextBox3.TabIndex = 11;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Font = new Font("Consolas", 12F);
            maskedTextBox4.Location = new Point(486, 374);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(125, 31);
            maskedTextBox4.TabIndex = 10;
            maskedTextBox4.KeyPress += maskedTextBoxnum_KeyPress;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Font = new Font("Consolas", 12F);
            maskedTextBox5.Location = new Point(486, 418);
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(125, 31);
            maskedTextBox5.TabIndex = 13;
            maskedTextBox5.KeyPress += maskedTextBoxnum_KeyPress;
            // 
            // AddInventoryItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 130, 196);
            ClientSize = new Size(932, 703);
            Controls.Add(maskedTextBox5);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Consolas", 9F);
            Name = "AddInventoryItemForm";
            Text = "Add New Item";
            Load += AddInventoryItemForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)suppliersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox5;
        private DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private BindingSource suppliersBindingSource;
    }
}