namespace Database_Systems_Project
{

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            button3 = new Button();
            SignIn = new Button();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            userName = new TextBox();
            password = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 130, 196);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 47);
            panel1.TabIndex = 2;
            panel1.MouseDown += Form1_MouseDown;
            panel1.MouseMove += Form1_MouseMove;
            panel1.MouseUp += Form1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 27);
            label1.TabIndex = 3;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopRight;
            label1.Click += label1_Click;
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
            button3.Size = new Size(50, 47);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SignIn
            // 
            SignIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            SignIn.FlatStyle = FlatStyle.Flat;
            SignIn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignIn.Location = new Point(238, 460);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(209, 36);
            SignIn.TabIndex = 0;
            SignIn.Text = "Sign In";
            SignIn.UseVisualStyleBackColor = true;
            SignIn.Click += SignIn_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Consolas", 10.2F);
            button2.Location = new Point(238, 551);
            button2.Name = "button2";
            button2.Size = new Size(209, 36);
            button2.TabIndex = 1;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 15F);
            label3.Location = new Point(98, 358);
            label3.Name = "label3";
            label3.Size = new Size(209, 29);
            label3.TabIndex = 4;
            label3.Text = "Enter Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15F);
            label2.Location = new Point(98, 235);
            label2.Name = "label2";
            label2.Size = new Size(209, 29);
            label2.TabIndex = 3;
            label2.Text = "Enter Username";
            label2.Click += label2_Click;
            // 
            // userName
            // 
            userName.Location = new Point(374, 241);
            userName.Name = "userName";
            userName.Size = new Size(195, 25);
            userName.TabIndex = 5;
            userName.TextChanged += userName_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(374, 358);
            password.Name = "password";
            password.Size = new Size(195, 25);
            password.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 15F);
            label4.Location = new Point(192, 114);
            label4.Name = "label4";
            label4.Size = new Size(279, 29);
            label4.TabIndex = 7;
            label4.Text = "Welcome To WAH Cafe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 130, 196);
            ClientSize = new Size(700, 700);
            Controls.Add(label4);
            Controls.Add(password);
            Controls.Add(userName);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(SignIn);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Welcome";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button button3;
        private Label label1;
        private Button SignIn;
        private Button button2;
        private Label label3;
        private Label label2;
        private TextBox userName;
        private TextBox password;
        private Label label4;
    }
}
