namespace Database_Systems_Project
{
    partial class EditEmployeeForm
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
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            maskedTextBox6 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label1 = new Label();
            label6 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(maskedTextBox6);
            panel1.Controls.Add(maskedTextBox5);
            panel1.Controls.Add(maskedTextBox3);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(35, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(873, 538);
            panel1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(608, 46);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 25);
            dateTimePicker1.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F);
            label5.Location = new Point(439, 48);
            label5.Name = "label5";
            label5.Size = new Size(153, 23);
            label5.TabIndex = 18;
            label5.Text = "Date of Birth";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(518, 364);
            button2.Name = "button2";
            button2.Size = new Size(94, 30);
            button2.TabIndex = 17;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(245, 364);
            button1.Name = "button1";
            button1.Size = new Size(94, 30);
            button1.TabIndex = 16;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(234, 236);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(307, 57);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(234, 191);
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(170, 25);
            maskedTextBox6.TabIndex = 14;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(234, 146);
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(170, 25);
            maskedTextBox5.TabIndex = 13;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(234, 94);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(170, 25);
            maskedTextBox3.TabIndex = 11;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(234, 48);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(170, 25);
            maskedTextBox2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F);
            label1.Location = new Point(46, 48);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F);
            label6.Location = new Point(46, 235);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 7;
            label6.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F);
            label2.Location = new Point(46, 94);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F);
            label7.Location = new Point(46, 190);
            label7.Name = "label7";
            label7.Size = new Size(98, 23);
            label7.TabIndex = 6;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 12F);
            label8.Location = new Point(46, 146);
            label8.Name = "label8";
            label8.Size = new Size(98, 23);
            label8.TabIndex = 5;
            label8.Text = "Username";
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 130, 196);
            ClientSize = new Size(932, 633);
            Controls.Add(panel1);
            Font = new Font("Consolas", 9F);
            Name = "EditEmployeeForm";
            Text = "EditEmployeeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button button2;
        private Button button1;
        private RichTextBox richTextBox1;
        private MaskedTextBox maskedTextBox6;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private Label label1;
        private Label label6;
        private Label label2;
        private Label label7;
        private Label label8;
    }
}