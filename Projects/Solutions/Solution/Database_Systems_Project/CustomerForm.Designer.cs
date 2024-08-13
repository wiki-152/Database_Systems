namespace Database_Systems_Project
{
    partial class CustomerForm
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button9 = new Button();
            dataGridView2 = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            menuIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            menuBindingSource = new BindingSource(components);
            adminBindingSource = new BindingSource(components);
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            dataGridView4 = new DataGridView();
            transactionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionBindingSource = new BindingSource(components);
            dataGridView3 = new DataGridView();
            PromotionName = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            DiscountValue = new DataGridViewTextBoxColumn();
            promotionBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminBindingSource).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 69);
            button1.Name = "button1";
            button1.Size = new Size(117, 26);
            button1.TabIndex = 0;
            button1.Text = "View Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 136);
            button2.Name = "button2";
            button2.Size = new Size(117, 26);
            button2.TabIndex = 1;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button9);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(135, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 418);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(519, 76);
            button9.Name = "button9";
            button9.Size = new Size(145, 26);
            button9.TabIndex = 2;
            button9.Text = "Add To Cart";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
            dataGridView2.DataSource = productBindingSource;
            dataGridView2.Location = new Point(0, 197);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(787, 199);
            dataGridView2.TabIndex = 1;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { menuIdDataGridViewTextBoxColumn, menuNameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = menuBindingSource;
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(307, 169);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // menuIdDataGridViewTextBoxColumn
            // 
            menuIdDataGridViewTextBoxColumn.DataPropertyName = "MenuId";
            menuIdDataGridViewTextBoxColumn.HeaderText = "MenuId";
            menuIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            menuIdDataGridViewTextBoxColumn.Name = "menuIdDataGridViewTextBoxColumn";
            menuIdDataGridViewTextBoxColumn.ReadOnly = true;
            menuIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // menuNameDataGridViewTextBoxColumn
            // 
            menuNameDataGridViewTextBoxColumn.DataPropertyName = "MenuName";
            menuNameDataGridViewTextBoxColumn.HeaderText = "MenuName";
            menuNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            menuNameDataGridViewTextBoxColumn.Name = "menuNameDataGridViewTextBoxColumn";
            menuNameDataGridViewTextBoxColumn.ReadOnly = true;
            menuNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // menuBindingSource
            // 
            menuBindingSource.DataSource = typeof(Menu);
            // 
            // adminBindingSource
            // 
            adminBindingSource.DataSource = typeof(Admin);
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(12, 205);
            button3.Name = "button3";
            button3.Size = new Size(117, 26);
            button3.TabIndex = 3;
            button3.Text = "Notifications";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(12, 264);
            button4.Name = "button4";
            button4.Size = new Size(117, 26);
            button4.TabIndex = 4;
            button4.Text = "History";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(12, 329);
            button5.Name = "button5";
            button5.Size = new Size(117, 26);
            button5.TabIndex = 5;
            button5.Text = "Cart";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(203, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(791, 515);
            panel2.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Consolas", 12F);
            label15.Location = new Point(473, 374);
            label15.Name = "label15";
            label15.Size = new Size(21, 23);
            label15.TabIndex = 24;
            label15.Text = "-";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Consolas", 12F);
            label14.Location = new Point(473, 334);
            label14.Name = "label14";
            label14.Size = new Size(21, 23);
            label14.TabIndex = 23;
            label14.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Consolas", 12F);
            label13.Location = new Point(473, 288);
            label13.Name = "label13";
            label13.Size = new Size(21, 23);
            label13.TabIndex = 22;
            label13.Text = "-";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 12F);
            label12.Location = new Point(473, 239);
            label12.Name = "label12";
            label12.Size = new Size(21, 23);
            label12.TabIndex = 21;
            label12.Text = "-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 12F);
            label11.Location = new Point(473, 187);
            label11.Name = "label11";
            label11.Size = new Size(21, 23);
            label11.TabIndex = 20;
            label11.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 12F);
            label10.Location = new Point(473, 131);
            label10.Name = "label10";
            label10.Size = new Size(21, 23);
            label10.TabIndex = 19;
            label10.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 12F);
            label9.Location = new Point(473, 68);
            label9.Name = "label9";
            label9.Size = new Size(21, 23);
            label9.TabIndex = 18;
            label9.Text = "-";
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(497, 485);
            button8.Name = "button8";
            button8.Size = new Size(94, 26);
            button8.TabIndex = 17;
            button8.Text = "Clear";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(188, 485);
            button7.Name = "button7";
            button7.Size = new Size(94, 26);
            button7.TabIndex = 16;
            button7.Text = "Save";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(343, 485);
            button6.Name = "button6";
            button6.Size = new Size(94, 26);
            button6.TabIndex = 15;
            button6.Text = "Edit";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 12F);
            label8.Location = new Point(110, 288);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 7;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F);
            label7.Location = new Point(110, 374);
            label7.Name = "label7";
            label7.Size = new Size(98, 23);
            label7.TabIndex = 6;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F);
            label6.Location = new Point(110, 334);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 5;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F);
            label5.Location = new Point(110, 239);
            label5.Name = "label5";
            label5.Size = new Size(142, 23);
            label5.TabIndex = 4;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F);
            label4.Location = new Point(110, 187);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F);
            label3.Location = new Point(110, 131);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F);
            label2.Location = new Point(110, 69);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 1;
            label2.Text = "First name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F);
            label1.Location = new Point(350, 22);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 0;
            label1.Text = "Profile";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView4);
            panel3.Controls.Add(dataGridView3);
            panel3.Location = new Point(151, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(643, 383);
            panel3.TabIndex = 7;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToOrderColumns = true;
            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { transactionIdDataGridViewTextBoxColumn, transactionDateTimeDataGridViewTextBoxColumn, transactionTypeDataGridViewTextBoxColumn, totalAmountDataGridViewTextBoxColumn });
            dataGridView4.DataSource = transactionBindingSource;
            dataGridView4.Location = new Point(56, 192);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(570, 169);
            dataGridView4.TabIndex = 1;
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            transactionIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionId";
            transactionIdDataGridViewTextBoxColumn.HeaderText = "TransactionId";
            transactionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            transactionIdDataGridViewTextBoxColumn.ReadOnly = true;
            transactionIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionDateTimeDataGridViewTextBoxColumn
            // 
            transactionDateTimeDataGridViewTextBoxColumn.DataPropertyName = "TransactionDateTime";
            transactionDateTimeDataGridViewTextBoxColumn.HeaderText = "TransactionDateTime";
            transactionDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            transactionDateTimeDataGridViewTextBoxColumn.Name = "transactionDateTimeDataGridViewTextBoxColumn";
            transactionDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            transactionDateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
            transactionTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            transactionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            transactionTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            totalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            totalAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Transaction);
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToOrderColumns = true;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { PromotionName, descriptionDataGridViewTextBoxColumn1, EndDate, DiscountValue });
            dataGridView3.DataSource = promotionBindingSource;
            dataGridView3.Location = new Point(56, 17);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(558, 169);
            dataGridView3.TabIndex = 0;
            // 
            // PromotionName
            // 
            PromotionName.DataPropertyName = "PromotionName";
            PromotionName.HeaderText = "PromotionName";
            PromotionName.MinimumWidth = 6;
            PromotionName.Name = "PromotionName";
            PromotionName.ReadOnly = true;
            PromotionName.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // EndDate
            // 
            EndDate.DataPropertyName = "EndDate";
            EndDate.HeaderText = "EndDate";
            EndDate.MinimumWidth = 6;
            EndDate.Name = "EndDate";
            EndDate.ReadOnly = true;
            EndDate.Width = 125;
            // 
            // DiscountValue
            // 
            DiscountValue.DataPropertyName = "DiscountValue";
            DiscountValue.HeaderText = "DiscountValue";
            DiscountValue.MinimumWidth = 6;
            DiscountValue.Name = "DiscountValue";
            DiscountValue.ReadOnly = true;
            DiscountValue.Width = 125;
            // 
            // promotionBindingSource
            // 
            promotionBindingSource.DataSource = typeof(Promotion);
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 130, 196);
            ClientSize = new Size(932, 633);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Consolas", 9F);
            Name = "CustomerForm";
            Text = "Customer Form";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button button3;
        private Button button4;
        private Button button5;
        private BindingSource adminBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn menuIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn menuNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAvailableDataGridViewCheckBoxColumn;
        private BindingSource menuBindingSource;
        private DataGridView dataGridView2;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private Panel panel2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button8;
        private Button button7;
        private Button button6;
        private Panel panel3;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn PromotionName;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn DiscountValue;
        private BindingSource promotionBindingSource;
        private DataGridView dataGridView4;
        private BindingSource transactionBindingSource;
        private DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private Button button9;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
    }
}