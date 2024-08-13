namespace Database_Systems_Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            panel1 = new Panel();
            label4 = new Label();
            button3 = new Button();
            SignIn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15F);
            label1.Location = new Point(73, 112);
            label1.Name = "label1";
            label1.Size = new Size(209, 29);
            label1.TabIndex = 0;
            label1.Text = "Enter Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15F);
            label2.Location = new Point(73, 249);
            label2.Name = "label2";
            label2.Size = new Size(209, 29);
            label2.TabIndex = 1;
            label2.Text = "Enter Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 15F);
            label3.Location = new Point(73, 388);
            label3.Name = "label3";
            label3.Size = new Size(237, 29);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(357, 516);
            button1.Name = "button1";
            button1.Size = new Size(224, 39);
            button1.TabIndex = 6;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(365, 112);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(216, 25);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(365, 249);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(216, 25);
            maskedTextBox2.TabIndex = 8;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(365, 388);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(216, 25);
            maskedTextBox3.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 130, 196);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 42);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 8);
            label4.Name = "label4";
            label4.Size = new Size(103, 27);
            label4.TabIndex = 3;
            label4.Text = "Sign Up";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(650, 0);
            button3.Name = "button3";
            button3.Size = new Size(50, 42);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SignIn
            // 
            SignIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            SignIn.FlatStyle = FlatStyle.Flat;
            SignIn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignIn.Location = new Point(73, 516);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(209, 39);
            SignIn.TabIndex = 11;
            SignIn.Text = "Sign In";
            SignIn.UseVisualStyleBackColor = true;
            SignIn.Click += SignIn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 130, 196);
            ClientSize = new Size(700, 700);
            Controls.Add(SignIn);
            Controls.Add(panel1);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Consolas", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private Panel panel1;
        private Label label4;
        private Button button3;
        private Button SignIn;
    }
}