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
    public partial class CustomerForm : Form
    {
        Customer customer;

        List<Product> cartProducts;

        public CustomerForm(Customer input = null)
        {
            InitializeComponent();

            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;


            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

            customer = input;

            this.Load += CustomerForm_Load;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadMenuToGridView();
            LoadPromotionsToGridView();

        }

        private void LoadMenuToGridView()
        {
            List<Menu> menus;
            menus = MenuManager.GetAllMenus();

            // remove menus where isActive is false
            //menus.RemoveAll(m => !m.IsActive); 

            for (int i = menus.Count - 1; i >= 0; i--)
            {
                if (menus[i].IsActive == false)
                {
                    menus.RemoveAt(i);
                }
            }
            dataGridView1.DataSource = menus;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadProductsToGridView(int menuId)
        {
            List<Product> products = ProductManager.GetAllProducts();

            // remove products where MenuId is not equal to selected menu id
            for (int i = products.Count - 1; i >= 0; i--)
            {
                if (products[i].MenuId != menuId)
                {
                    products.RemoveAt(i);
                }
            }

            dataGridView2.DataSource = products;

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadPromotionsToGridView()
        {
            List<Promotion> promotions = PromotionManager.GetAllPromotions();

            // remove promotions where isActive is false
            for (int i = promotions.Count - 1; i >= 0; i--)
            {
                if (promotions[i].isActive == false)
                {
                    promotions.RemoveAt(i);
                }
            }

            dataGridView3.DataSource = promotions;

            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void LoadTransactionsToGridView()
        {
            List<Transaction> transactions = TransactionManager.GetAllTransactions();

            // remove transactions where CustomerId is not equal to selected customer id

            if (customer != null)
            {
                for (int i = transactions.Count - 1; i >= 0; i--)
                {
                    if (transactions[i].CustomerId != customer.CustomerId)
                    {
                        transactions.RemoveAt(i);
                    }
                }

                dataGridView4.DataSource = transactions;
            }



            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Menu menu = row.DataBoundItem as Menu;
                    if (menu != null)
                    {
                        sb.AppendLine($"Name: {menu.MenuName}, ID: {menu.MenuId}");

                        if (menu.MenuId != 0)
                        {
                            LoadProductsToGridView(menu.MenuId);
                        }
                        // Add other properties as needed
                    }
                }
                //MessageBox.Show(sb.ToString(), "Selected Menu Details");

            }
        }



        // view menu button
        private void button1_Click(object sender, EventArgs e)
        {
            // Display all in panel1
            panel1.Visible = true;

            // hide all in panel2
            panel2.Hide();

            // hide all in panel3
            panel3.Hide();
        }

        // Profile button
        private void button2_Click(object sender, EventArgs e)
        {
            // hide all in panel1
            panel1.Hide();

            // Display all in panel2
            panel2.Visible = true;

            // Display customer details
            if (customer != null)
            {
                label9.Text = customer.FirstName;
                label10.Text = customer.LastName;
                label11.Text = customer.Email;
                label12.Text = customer.PhoneNumber;
                label13.Text = customer.Address;

                label14.Text = customer.Username;
                label15.Text = customer.Pass;
            }



        }

        private void loadCustomerDetails()
        {
            if (customer != null)
            {
                // Get customer from list
                List<Customer> list = CustomerManager.GetAllCustomers();

                int id = customer.CustomerId;
                // find from list where customer id matches

                customer = list.FirstOrDefault(c => c.CustomerId == customer.CustomerId);

                label9.Text = customer.FirstName;
                label10.Text = customer.LastName;
                label11.Text = customer.Email;
                label12.Text = customer.PhoneNumber;
                label13.Text = customer.Address;

                label14.Text = customer.Username;
                label15.Text = customer.Pass;
            }


        }


        // clear button
        private void button8_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                label9.Text = customer.FirstName;
                label10.Text = customer.LastName;
                label11.Text = customer.Email;
                label12.Text = customer.PhoneNumber;
                label13.Text = customer.Address;

                label14.Text = customer.Username;
                label15.Text = customer.Pass;
            }
        }

        // edit button
        private void button6_Click(object sender, EventArgs e)
        {
            // Open EditCustomerForm
            EditCustomerForm editCustomerForm = new EditCustomerForm(customer);

            editCustomerForm.ShowDialog();

            // Refresh CustomerForm
            loadCustomerDetails();

        }

        // notification button
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            panel3.Visible = true;

            dataGridView3.Visible = true;

            dataGridView4.Visible = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

            dataGridView3.Visible = false;

            dataGridView4.Visible = true;

            LoadTransactionsToGridView();


        }

        // Add to cart button
        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    Product product = row.DataBoundItem as Product;
                    if (product != null)
                    {
                        sb.AppendLine($"Name: {product.ProductName}, ID: {product.ProductId}");

                        if (product.ProductId != 0)
                        {
                            if (cartProducts == null)
                            {
                                cartProducts = new List<Product>();
                            }
                            // Add to cartProducts
                            cartProducts.Add(product);
                            // Display Product also
                            MessageBox.Show(product.ProductName);
                            MessageBox.Show("Product added to cart");
                        }
                        // Add other properties as needed
                    }
                }
                //MessageBox.Show(sb.ToString(), "Selected Menu Details");

            }
        }

        // Cart Button
        private void button5_Click(object sender, EventArgs e)
        {
            // Open CartForm

            CartForm cartForm = new CartForm(cartProducts , customer);

            cartForm.ShowDialog();


        }

    }
}
