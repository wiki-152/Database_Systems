
SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM Admins;
SELECT * FROM DataAnalyst;

SELECT * FROM EmployeeShifts;
SELECT * FROM LoyaltyPrograms;

SELECT * FROM Menu;

SELECT * FROM Products;

SELECT * FROM Promotions;

SELECT * FROM SalesReports; ------------------------

SELECT * FROM Suppliers;

SELECT * FROM TransactionItems;
SELECT * FROM Transactions;

SELECT * FROM CustomerAccounts;

SELECT * FROM Recipes;
SELECT * FROM Instructions;
SELECT * FROM Ingredients;

SELECT * FROM InventoryItems;

SELECT * FROM Cart;
SELECT * FROM Register;

CREATE VIEW vw_SalesSummary AS
SELECT ReportDate, SUM(TotalSales) AS DailyTotalSales, AVG(AverageTransactionValue) AS AvgTransactionValue
FROM SalesReports
GROUP BY ReportDate;

SELECT * FROM vw_SalesSummary;