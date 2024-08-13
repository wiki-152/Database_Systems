
-- Views

--1. `EmployeePerformance`:
CREATE VIEW EmployeePerformance AS
SELECT
    e.EmployeeID,
    e.FirstName,
    e.LastName,
    e.Role,
    e.Salary,
    COUNT(t.TransactionID) AS TotalTransactions,
    SUM(t.TotalAmount) AS TotalSales
FROM Employees e
LEFT JOIN Transactions t ON e.EmployeeID = t.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName, e.Role, e.Salary;

SELECT * FROM EmployeePerformance;

--2. `InventoryManagement`:
CREATE VIEW InventoryManagement AS
SELECT
    i.ItemName,
    i.QuantityInStock,
    i.ReorderThreshold,
    i.UnitOfMeasurement,
    s.SupplierName,
    s.Phone,
    s.Email
FROM InventoryItems i
JOIN Suppliers s ON i.SupplierID = s.SupplierID;

SELECT * FROM InventoryManagement;

--3. `LoyaltyProgramPerformance`:
CREATE VIEW LoyaltyProgramPerformance AS
SELECT
    lp.ProgramName,
    lp.Description,
    lp.PointsPerRuppeeSpent,
    lp.PointsForSignup,
    lp.ExpiryMonths,
    COUNT(ca.AccountID) AS TotalEnrolledCustomers,
    SUM(ca.PointsBalance) AS TotalPointsEarned
FROM LoyaltyPrograms lp
LEFT JOIN CustomerAccounts ca ON lp.LoyaltyProgramID = ca.LoyaltyProgramID
GROUP BY lp.ProgramName, lp.Description, lp.PointsPerRuppeeSpent, lp.PointsForSignup, lp.ExpiryMonths;

SELECT * FROM LoyaltyProgramPerformance;

--4
CREATE VIEW LowStockInventory AS
SELECT 
    i.ItemID,
    i.ItemName, 
    i.QuantityInStock, 
    i.ReorderThreshold,
    s.SupplierName,
    s.Phone
FROM InventoryItems i
JOIN Suppliers s ON i.SupplierID = s.SupplierID
WHERE i.QuantityInStock <= i.ReorderThreshold;

SELECT * FROM LowStockInventory;

-- 5
CREATE VIEW BestSellingProductsByMonth AS
SELECT
    MONTH(t.TransactionDateTime) AS Month,
    p.ProductName,
    SUM(ti.Quantity) AS TotalQuantitySold,
    SUM(ti.Quantity * ti.Price) AS TotalRevenue
FROM Transactions t
JOIN TransactionItems ti ON t.TransactionID = ti.TransactionID
JOIN Products p ON ti.ProductID = p.ProductID
GROUP BY MONTH(t.TransactionDateTime), p.ProductName; 

SELECT * FROM BestSellingProductsByMonth;

-- 6
CREATE VIEW CustomerLifetimeValue AS 
SELECT
    c.CustomerID, 
    c.FirstName, 
    c.LastName,
    SUM(t.TotalAmount) AS TotalSpending
FROM Customers c
JOIN Transactions t ON c.CustomerID = t.CustomerID
GROUP BY c.CustomerID, c.FirstName, c.LastName;

SELECT * FROM CustomerLifetimeValue;


