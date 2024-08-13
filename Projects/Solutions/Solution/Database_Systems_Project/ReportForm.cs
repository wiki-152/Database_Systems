using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Database_Systems_Project
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private DataTable ExecuteQueryAndReturnDataTable(string query)
        {
            string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        // Button 1
        public void button1_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT
                e.Role,
                AVG(e.Salary) AS AvgSalary
                FROM Employees e
                GROUP BY e.Role
                HAVING AVG(e.Salary) > (
                SELECT AVG(Salary) FROM Employees
            );";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "Average salary for each role, and roles with an average \n salary greater than the overall average salary";
        }

        // Button 2
        public void button2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT TOP 2
            c.CustomerID,
            c.FirstName,
            c.LastName,
             (
            SELECT SUM(ti.Quantity * ti.Price) AS TotalSpent
            FROM Transactions t
            JOIN TransactionItems ti ON t.TransactionID = ti.TransactionID
            JOIN Products p ON ti.ProductID = p.ProductID
            WHERE t.CustomerID = c.CustomerID AND p.Category IN ('Main Course')
            ) AS TotalSpentOnElectronics
            FROM Customers c
            ORDER BY TotalSpentOnElectronics DESC;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The customers who have spent the most money on products in a specific category";
        }

        // Button 3

        public void button3_Click(object sender, EventArgs e)
        {
            string query = @"SELECT TOP 3
            e.FirstName,
            e.LastName,
            COUNT(t.TransactionID) AS TotalTransactions
            FROM Employees e
            JOIN Transactions t ON e.EmployeeID = t.EmployeeID
            GROUP BY e.EmployeeID, e.FirstName, e.LastName
            HAVING COUNT(t.TransactionID) != 0
            ORDER BY TotalTransactions DESC;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The top 3 cashiers who have processed the most transactions";
        }

        // Button 4
        public void button4_Click(object sender, EventArgs e)
        {
            string query = @"SELECT TOP 5
            p.ProductName,
            SUM(ti.Quantity) AS TotalQuantitySold,
            AVG(ti.Price) AS AvgPrice,
            SUM(ti.Quantity * ti.Price) AS TotalRevenue
            FROM Products p
            JOIN TransactionItems ti ON p.ProductID = ti.ProductID
            GROUP BY p.ProductName
            having SUM(ti.Quantity)>0
            ORDER BY TotalRevenue DESC;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The top 5 best-selling products by total revenue, \nalong with the total quantity sold and the average price";
        }

        // Button 5
        public void button5_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
            c.CustomerID,
            c.FirstName,
            c.LastName,
            AVG(t.TotalAmount) AS AvgOrderValue
            FROM Customers c
            JOIN Transactions t ON c.CustomerID = t.CustomerID
            GROUP BY c.CustomerID, c.FirstName, c.LastName
            HAVING AVG(t.TotalAmount) > (
            SELECT AVG(TotalAmount)
            FROM Transactions
            );";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The average order value for each customer, \nand only include customers with an average order \nvalue greater than the overall average";
        }

        // Button 6
        public void button6_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
            c.CustomerID,
            c.FirstName,
            c.LastName,
            lp.ProgramName,
            ca.PointsBalance
            FROM Customers c
            JOIN CustomerAccounts ca ON c.CustomerID = ca.CustomerID
            JOIN LoyaltyPrograms lp ON ca.LoyaltyProgramID = lp.LoyaltyProgramID;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The total points earned by each customer,\n along with the loyalty program they are enrolled in";
        }

        // Button 7
        public void button7_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
            s.SupplierName,
            i.ItemName,
            i.QuantityInStock
            FROM Suppliers s
            JOIN InventoryItems i ON s.SupplierID = i.SupplierID;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The list of suppliers, the inventory items they \nprovide, and the total quantity in stock for each item";
        }

        // Button 8
        public void button8_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
            p.ProductName,
            p.Category,
            SUM(ti.Quantity) AS TotalQuantitySold
            FROM Products p
            JOIN TransactionItems ti ON p.ProductID = ti.ProductID
            GROUP BY p.ProductName, p.Category
            HAVING SUM(ti.Quantity) < 50;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The products that have sold less than 50 units";
        }

        // Button 9
        public void button9_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
            e.FirstName AS EmployeeFirstName,
            e.LastName AS EmployeeLastName,
            m.FirstName AS ManagerFirstName,
            m.LastName AS ManagerLastName,
            COUNT(es.ShiftID) AS TotalShiftsWorked
            FROM Employees e
            LEFT JOIN Employees m ON e.ManagerID = m.EmployeeID
            LEFT JOIN EmployeeShifts es ON e.EmployeeID = es.EmployeeID
            GROUP BY e.EmployeeID, e.FirstName, e.LastName, m.FirstName, m.LastName;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The list of employees, their manager's name, and the \ntotal number of shifts they have worked";
        }

        // Button 10
        public void button10_Click(object sender, EventArgs e)
        {
            string query = @"SELECT TOP 3
            p.ProductName,
            SUM(ti.Quantity * ti.Price) AS TotalRevenue,
            (
            SELECT TOP 1 e.FirstName + ' ' + e.LastName
            FROM Employees e
            JOIN Transactions t ON e.EmployeeID = t.EmployeeID
            JOIN TransactionItems ti2 ON t.TransactionID = ti2.TransactionID
            WHERE ti2.ProductID = p.ProductID
            GROUP BY e.EmployeeID, e.FirstName, e.LastName
            ORDER BY SUM(ti2.Quantity) DESC
            ) AS TopSellingEmployee,
            (
            SELECT TOP 1 c.FirstName + ' ' + c.LastName
            FROM Customers c
            JOIN Transactions t ON c.CustomerID = t.CustomerID
            JOIN TransactionItems ti2 ON t.TransactionID = ti2.TransactionID
            WHERE ti2.ProductID = p.ProductID
            GROUP BY c.CustomerID, c.FirstName, c.LastName
            ORDER BY SUM(ti2.Quantity * ti2.Price) DESC
            ) AS TopSpendingCustomer
            FROM Products p
            JOIN TransactionItems ti ON p.ProductID = ti.ProductID
            GROUP BY p.ProductName, p.ProductID
            ORDER BY TotalRevenue DESC;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The top 3 best-selling products by total revenue, \nalong with the employee who sold the most of each product \nand the customer who spent the most on each product";
        }

        // Button 11
        public void button11_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
            DATEPART(WEEKDAY, Transactions.TransactionDateTime) AS DayOfWeek,
            SUM(Transactions.TotalAmount) AS DailySales
            FROM Transactions
            JOIN EmployeeShifts ON Transactions.EmployeeID = EmployeeShifts.EmployeeID
            JOIN Employees ON Transactions.EmployeeID = Employees.EmployeeID
            JOIN Customers ON Transactions.CustomerID = Customers.CustomerID
            GROUP BY DATEPART(WEEKDAY, Transactions.TransactionDateTime)
            ORDER BY DayOfWeek;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The daily sales trend, showing the total sales for each day of the week";
        }

        // Button 12
        public void button12_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
            MONTH(Transactions.TransactionDateTime) AS Month,
            SUM(Transactions.TotalAmount) AS MonthlySales
            FROM Transactions
            JOIN EmployeeShifts ON Transactions.EmployeeID = EmployeeShifts.EmployeeID
            JOIN Employees ON Transactions.EmployeeID = Employees.EmployeeID
            JOIN Customers ON Transactions.CustomerID = Customers.CustomerID
            GROUP BY MONTH(Transactions.TransactionDateTime)
            ORDER BY Month;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The monthly sales trend, showing the total sales for each month";
        }

        // Button 13
        public void button13_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
            DATEPART(WEEK, Transactions.TransactionDateTime) AS Week,
            SUM(Transactions.TotalAmount) AS WeeklySales
            FROM Transactions
            JOIN EmployeeShifts ON Transactions.EmployeeID = EmployeeShifts.EmployeeID
            JOIN Employees ON Transactions.EmployeeID = Employees.EmployeeID
            JOIN Customers ON Transactions.CustomerID = Customers.CustomerID
            GROUP BY DATEPART(WEEK, Transactions.TransactionDateTime)
            ORDER BY Week;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The weekly sales trend, showing the total sales for each week of the year";
        }

        // Button 14
        public void button14_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
            DATEPART(YEAR, Transactions.TransactionDateTime) AS Year,
            SUM(Transactions.TotalAmount) AS YearlySales
            FROM Transactions
            JOIN EmployeeShifts ON Transactions.EmployeeID = EmployeeShifts.EmployeeID
            JOIN Employees ON Transactions.EmployeeID = Employees.EmployeeID
            JOIN Customers ON Transactions.CustomerID = Customers.CustomerID
            GROUP BY DATEPART(YEAR, Transactions.TransactionDateTime)
            ORDER BY Year;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The yearly sales trend, showing the total sales for each year";
        }

        // Button 15
        public void button15_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
            e.FirstName AS EmployeeFirstName,
            e.LastName AS EmployeeLastName,
            m.FirstName AS ManagerFirstName,
            m.LastName AS ManagerLastName,
            COUNT(t.EmployeeID) AS NumberOfTransactions
            FROM Employees e
            LEFT JOIN Employees m ON e.ManagerID = m.EmployeeID
            LEFT JOIN Transactions t ON e.EmployeeID = t.EmployeeID
            GROUP BY e.EmployeeID, e.FirstName, e.LastName, m.FirstName, m.LastName;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The list of employees, their manager's name, \nand the total number of transactions they have worked";
        }

        // Button 16
        public void button16_Click(object sender, EventArgs e)
        {
            string query = @"SELECT
            CONVERT(DATE, t.TransactionDateTime) AS TransactionDate,
            SUM(t.TotalAmount) AS TotalSales,
            AVG(t.TotalAmount) AS AvgTransactionValue,
            COUNT(*) AS TotalTransactions
            FROM Transactions t
            GROUP BY CONVERT(DATE, t.TransactionDateTime)
            HAVING AVG(t.TotalAmount) < (
            SELECT AVG(TotalAmount)
            FROM Transactions
            )
            ORDER BY TransactionDate;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The days where the total sales are below the average transaction value per day";
        }

        // Button 17
        private void button17_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM EmployeePerformance;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The performance of each employee, including the number of transactions processed, \nthe total sales, and the average transaction value";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM InventoryManagement;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The inventory management report, including the total quantity in stock, \nthe total quantity sold, and the total revenue for each item";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM LoyaltyProgramPerformance;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The performance of each loyalty program, including the total points earned, \nthe total points redeemed, and the total points balance";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM LowStockInventory;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The inventory items that are low in stock, including the item name, the quantity in stock,\n and the reorder level";

        }

        // Button 21
        private void button21_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM BestSellingProductsByMonth;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The best-selling products by month, including the product name, the total quantity sold, \nand the total revenue";
        }

        // Button 22
        private void button22_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM CustomerLifetimeValue;";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The customer lifetime value report, including the customer name, the total amount spent, \nand the total points earned";
        }

        // Button 23
        private void button23_Click(object sender, EventArgs e)
        {
            string query = @"SELECT P.ProductName FROM Products P WHERE P.ProductID IN ( SELECT TI.ProductID FROM TransactionItems TI GROUP BY TI.ProductID HAVING COUNT(TI.TransactionID) > 10 );";

            DataTable dataTable = ExecuteQueryAndReturnDataTable(query);

            dataGridView1.DataSource = dataTable;

            label1.Text = "The products that have been sold in more than 10 transactions";
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }
    }
}
