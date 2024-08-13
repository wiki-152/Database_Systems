namespace Database_Systems_Project
{
    partial class EmployeeForm
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
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
            promotionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            promotionNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountValueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            promotionBindingSource = new BindingSource(components);
            button10 = new Button();
            button11 = new Button();
            dataGridView1 = new DataGridView();
            transactionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionBindingSource = new BindingSource(components);
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 50);
            button1.Name = "button1";
            button1.Size = new Size(175, 26);
            button1.TabIndex = 0;
            button1.Text = "Inventory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 123);
            button2.Name = "button2";
            button2.Size = new Size(175, 26);
            button2.TabIndex = 1;
            button2.Text = "Notifications";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(12, 199);
            button3.Name = "button3";
            button3.Size = new Size(175, 26);
            button3.TabIndex = 2;
            button3.Text = "Report";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(12, 291);
            button4.Name = "button4";
            button4.Size = new Size(175, 26);
            button4.TabIndex = 3;
            button4.Text = "History";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(12, 380);
            button5.Name = "button5";
            button5.Size = new Size(175, 26);
            button5.TabIndex = 4;
            button5.Text = "Profile";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(269, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 515);
            panel2.TabIndex = 7;
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Consolas", 12F);
            label15.Location = new Point(538, 385);
            label15.Name = "label15";
            label15.Size = new Size(21, 23);
            label15.TabIndex = 14;
            label15.Text = "-";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Consolas", 12F);
            label14.Location = new Point(538, 334);
            label14.Name = "label14";
            label14.Size = new Size(21, 23);
            label14.TabIndex = 13;
            label14.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Consolas", 12F);
            label13.Location = new Point(538, 288);
            label13.Name = "label13";
            label13.Size = new Size(21, 23);
            label13.TabIndex = 12;
            label13.Text = "-";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 12F);
            label12.Location = new Point(538, 239);
            label12.Name = "label12";
            label12.Size = new Size(21, 23);
            label12.TabIndex = 11;
            label12.Text = "-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 12F);
            label11.Location = new Point(538, 183);
            label11.Name = "label11";
            label11.Size = new Size(21, 23);
            label11.TabIndex = 10;
            label11.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 12F);
            label10.Location = new Point(538, 127);
            label10.Name = "label10";
            label10.Size = new Size(21, 23);
            label10.TabIndex = 9;
            label10.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 12F);
            label9.Location = new Point(538, 69);
            label9.Name = "label9";
            label9.Size = new Size(21, 23);
            label9.TabIndex = 8;
            label9.Text = "-";
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
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button11);
            panel3.Location = new Point(214, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(685, 383);
            panel3.TabIndex = 8;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToOrderColumns = true;
            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { promotionIdDataGridViewTextBoxColumn, promotionNameDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, discountValueDataGridViewTextBoxColumn });
            dataGridView4.DataSource = promotionBindingSource;
            dataGridView4.Location = new Point(12, 12);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(673, 169);
            dataGridView4.TabIndex = 1;
            // 
            // promotionIdDataGridViewTextBoxColumn
            // 
            promotionIdDataGridViewTextBoxColumn.DataPropertyName = "PromotionId";
            promotionIdDataGridViewTextBoxColumn.HeaderText = "PromotionId";
            promotionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            promotionIdDataGridViewTextBoxColumn.Name = "promotionIdDataGridViewTextBoxColumn";
            promotionIdDataGridViewTextBoxColumn.ReadOnly = true;
            promotionIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // promotionNameDataGridViewTextBoxColumn
            // 
            promotionNameDataGridViewTextBoxColumn.DataPropertyName = "PromotionName";
            promotionNameDataGridViewTextBoxColumn.HeaderText = "PromotionName";
            promotionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            promotionNameDataGridViewTextBoxColumn.Name = "promotionNameDataGridViewTextBoxColumn";
            promotionNameDataGridViewTextBoxColumn.ReadOnly = true;
            promotionNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            endDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountValueDataGridViewTextBoxColumn
            // 
            discountValueDataGridViewTextBoxColumn.DataPropertyName = "DiscountValue";
            discountValueDataGridViewTextBoxColumn.HeaderText = "DiscountValue";
            discountValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountValueDataGridViewTextBoxColumn.Name = "discountValueDataGridViewTextBoxColumn";
            discountValueDataGridViewTextBoxColumn.ReadOnly = true;
            discountValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // promotionBindingSource
            // 
            promotionBindingSource.DataSource = typeof(Promotion);
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(380, 279);
            button10.Name = "button10";
            button10.Size = new Size(175, 26);
            button10.TabIndex = 10;
            button10.Text = "Delete";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(111, 279);
            button11.Name = "button11";
            button11.Size = new Size(175, 26);
            button11.TabIndex = 9;
            button11.Text = "Add";
            button11.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { transactionIdDataGridViewTextBoxColumn, transactionDateTimeDataGridViewTextBoxColumn, transactionTypeDataGridViewTextBoxColumn, totalAmountDataGridViewTextBoxColumn });
            dataGridView1.DataSource = transactionBindingSource;
            dataGridView1.Location = new Point(359, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(561, 169);
            dataGridView1.TabIndex = 11;
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
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 130, 196);
            ClientSize = new Size(932, 703);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Consolas", 9F);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)promotionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel2;
        private Button button8;
        private Button button7;
        private Button button6;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn promotionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn promotionNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountValueDataGridViewTextBoxColumn;
        private BindingSource promotionBindingSource;
        private Button button10;
        private Button button11;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private BindingSource transactionBindingSource;
    }
}