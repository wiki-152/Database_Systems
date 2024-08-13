
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Database_Systems_Project
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // Close button
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            List<Customer> customers = CustomerManager.GetAllCustomers();

            List<Employee> employees = Employeemanager.GetAllEmployees();

            List<Admin> admins = AdminManager.GetAllAdmins();

            List<DataAnaylst> dataAnalysts = DataAnalystManager.GetAllDataAnalysts();

            string username = userName.Text;

            // remove whitespace

            username = username.Trim();
            //lblout.Text = username;

            string pass = password.Text;

            foreach (Customer customer in customers)
            {
                //MessageBox.Show(customer.Username + " " + customer.Pass);
                if (customer.Username == username && customer.Pass == pass)
                {

                    // Send usernmaae and password to customer form

                    MessageBox.Show("Customer Login Successful!");

                    // Open the customer form

                    CustomerForm customerForm = new CustomerForm(customer);

                    this.Hide();

                    customerForm.Closed += (s, args) => this.Close();
                    customerForm.Show();

                    return;
                }
            }

            foreach (Employee employee in employees)
            {
                // display complete employee details
                //MessageBox.Show(employee.Username + " " + employee.Pass + employee.ManagerId);

                if (employee.Username == username && employee.Pass == pass)
                {
                    MessageBox.Show("Employee Login Successful!");

                    // Open the employee form
                    EmployeeForm employeeForm = new EmployeeForm(employee);

                    this.Hide();

                    employeeForm.Closed += (s, args) => this.Close();
                    employeeForm.Show();

                    return;
                }
            }

            foreach (Admin admin in admins)
            {
                // display complete admin details
                //MessageBox.Show(admin.UserName + " " + admin.Pass);

                if (admin.UserName == username && admin.Pass == pass)
                {
                    MessageBox.Show("Admin Login Successful!");

                    // Open the admin form
                    AdminForm adminForm = new AdminForm(admin);

                    this.Hide();

                    adminForm.Closed += (s, args) => this.Close();
                    adminForm.Show();

                    return;
                }
            }

            foreach (DataAnaylst dataAnalyst in dataAnalysts)
            {
                // display complete data analyst details
                //MessageBox.Show(dataAnalyst.Username + " " + dataAnalyst.Pass);

                if (dataAnalyst.Username == username && dataAnalyst.Pass == pass)
                {
                    MessageBox.Show("Data Analyst Login Successful!");

                    //// Open the data analyst form
                    DataAnalystForm dataAnalystForm = new DataAnalystForm(dataAnalyst);

                    this.Hide();

                    dataAnalystForm.Closed += (s, args) => this.Close();
                    dataAnalystForm.Show();

                    return;
                }
            }

            MessageBox.Show("Login Failed");


            //Sample
            /*string firstName = userName.Text;
            string lastName = password.Text;

            // Check if the first name is empty
            if (string.IsNullOrWhiteSpace(firstName))
            {
                lblout.Text = "Please enter a first name.";
                return;
            }

            // Check if the last name is empty
            if (string.IsNullOrWhiteSpace(lastName))
            {
                lblout.Text = "Please enter a last name.";
                return;
            }

            // Your connection string
            string cnstring = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

            // Your SQL query
            string sqlquery = "INSERT INTO Users (Username, Password) VALUES (@FirstName, @LastName)";

            try
            {
                // Create a connection
                using (SqlConnection con = new SqlConnection(cnstring))
                {
                    con.Open();

                    // Create a command with the SQL query and the connection
                    using (SqlCommand cm = new SqlCommand(sqlquery, con))
                    {
                        // Add parameters to the command
                        cm.Parameters.AddWithValue("@FirstName", firstName);
                        cm.Parameters.AddWithValue("@LastName", lastName);

                        // Execute the query
                        cm.ExecuteNonQuery();
                    }
                }

                lblout.Text = "Record inserted successfully.";
            }
            catch (SqlException ex)
            {
                lblout.Text = "SQL Error: " + ex.Message;
            }
            catch (Exception ex)
            {
                lblout.Text = "General Error: " + ex.Message;
            }*/

        }



        // sign up button
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Hide();

            // Show Form2 and set it as the main form
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
