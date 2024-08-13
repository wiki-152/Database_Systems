

--1
--Managers: Get the average salary for each role, and only include roles with an average salary greater than the overall average salary:

SELECT
    e.Role,
    AVG(e.Salary) AS AvgSalary
FROM Employees e
GROUP BY e.Role
HAVING AVG(e.Salary) > (
    SELECT AVG(Salary)
    FROM Employees
);

--2. Get the customers who have spent the most money on products in a specific category:
SELECT TOP 3
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
ORDER BY TotalSpentOnElectronics DESC;

--3
--Cashiers: Get the top 3 cashiers (employees) who have processed the most transactions:(Use for salary increments or bonuses)
SELECT TOP 3
    e.FirstName,
    e.LastName,
    COUNT(t.TransactionID) AS TotalTransactions
FROM Employees e
JOIN Transactions t ON e.EmployeeID = t.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName HAVING COUNT(t.TransactionID) != 0
ORDER BY TotalTransactions DESC;

--4 Data Analysts: Get the top 5 best-selling products by total revenue, along with the total quantity sold and the average price:
SELECT TOP 5
    p.ProductName,
    SUM(ti.Quantity) AS TotalQuantitySold,
    AVG(ti.Price) AS AvgPrice,
    SUM(ti.Quantity * ti.Price) AS TotalRevenue
FROM Products p
JOIN TransactionItems ti ON p.ProductID = ti.ProductID
GROUP BY p.ProductName
ORDER BY TotalRevenue DESC;

--5
--Get the average order value for each customer, and only include customers with an average order value greater than the overall average:
SELECT
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
);

--6. Get the total points earned by each customer, along with the loyalty program they are enrolled in:
SELECT
    c.CustomerID,
    c.FirstName,
    c.LastName,
    lp.ProgramName,
    ca.PointsBalance
FROM Customers c
JOIN CustomerAccounts ca ON c.CustomerID = ca.CustomerID
JOIN LoyaltyPrograms lp ON ca.LoyaltyProgramID = lp.LoyaltyProgramID;


--7. Get the list of suppliers, the inventory items they provide, and the total quantity in stock for each item:

SELECT
    s.SupplierName,
    i.ItemName,
    i.QuantityInStock
FROM Suppliers s
JOIN InventoryItems i ON s.SupplierID = i.SupplierID;


--8 to find underperforming products 
SELECT
    p.ProductName,
    p.Category,
    SUM(ti.Quantity) AS TotalQuantitySold
FROM Products p
JOIN TransactionItems ti ON p.ProductID = ti.ProductID
GROUP BY p.ProductName, p.Category
HAVING SUM(ti.Quantity) < 50;


--9. Get the list of employees, their manager's name, and the total number of shifts they have worked:
SELECT
    e.FirstName AS EmployeeFirstName,
    e.LastName AS EmployeeLastName,
    m.FirstName AS ManagerFirstName,
    m.LastName AS ManagerLastName,
    COUNT(es.ShiftID) AS TotalShiftsWorked
FROM Employees e
LEFT JOIN Employees m ON e.ManagerID = m.EmployeeID
LEFT JOIN EmployeeShifts es ON e.EmployeeID = es.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName, m.FirstName, m.LastName;

--10
--Get the top 3 best-selling products by total revenue, along with the employee who sold the most of each product and the customer who spent the most on each product:
SELECT TOP 3
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
ORDER BY TotalRevenue DESC;

--11
-- daily Sales Trend
SELECT 
       DATEPART(WEEKDAY, Transactions.TransactionDateTime) AS DayOfWeek,
       SUM(Transactions.TotalAmount) AS DailySales
FROM Transactions 
JOIN EmployeeShifts ON Transactions.EmployeeID = EmployeeShifts.EmployeeID
JOIN Employees ON Transactions.EmployeeID = Employees.EmployeeID
JOIN Customers ON Transactions.CustomerID = Customers.CustomerID
GROUP BY DATEPART(WEEKDAY, Transactions.TransactionDateTime)
ORDER BY DayOfWeek;

--12
-- Monthly Sales Trends
SELECT 
       MONTH(Transactions.TransactionDateTime) AS Month,
       SUM(Transactions.TotalAmount) AS MonthlySales
FROM Transactions 
JOIN EmployeeShifts ON Transactions.EmployeeID = EmployeeShifts.EmployeeID
JOIN Employees ON Transactions.EmployeeID = Employees.EmployeeID
JOIN Customers ON Transactions.CustomerID = Customers.CustomerID
GROUP BY MONTH(Transactions.TransactionDateTime)
ORDER BY Month;

--13 weekly
SELECT
DATEPART(WEEK, Transactions.TransactionDateTime) AS Week,
SUM(Transactions.TotalAmount) AS WeeklySales
FROM Transactions
JOIN EmployeeShifts ON Transactions.EmployeeID = EmployeeShifts.EmployeeID
JOIN Employees ON Transactions.EmployeeID = Employees.EmployeeID
JOIN Customers ON Transactions.CustomerID = Customers.CustomerID
GROUP BY DATEPART(WEEK, Transactions.TransactionDateTime)
ORDER BY Week;

--14 Yearly
SELECT
DATEPART(YEAR, Transactions.TransactionDateTime) AS Year,
SUM(Transactions.TotalAmount) AS YearlySales
FROM Transactions
JOIN EmployeeShifts ON Transactions.EmployeeID = EmployeeShifts.EmployeeID
JOIN Employees ON Transactions.EmployeeID = Employees.EmployeeID
JOIN Customers ON Transactions.CustomerID = Customers.CustomerID
GROUP BY DATEPART(YEAR, Transactions.TransactionDateTime)
ORDER BY Year;

--15
--Get all employees along with their managerInformation and their Number Of Transactions
Select e.FirstName,e.LastName,m.FirstName,m.LastName,SUM(t.EmployeeID)As Number_of_Sales from Employees e
Join Employees m on e.ManagerID=m.EmployeeID
Join Transactions t on e.EmployeeID=t.EmployeeID
Group  By e.FirstName,e.LastName,m.FirstName,m.LastName

--16
--Worse performing day below AVG Transaction value per day
SELECT
    CONVERT(DATE, t.TransactionDateTime) AS TransactionDate,
    SUM(t.TotalAmount) AS TotalSales,
    AVG(t.TotalAmount) AS AvgTransactionValue,
    COUNT(*) AS TotalTransactions
FROM Transactions t
GROUP BY CONVERT(DATE, t.TransactionDateTime) HAVING SUM(t.TotalAmount) < 50
ORDER BY TransactionDate;

--17
SELECT P.ProductName
FROM Products P
WHERE P.ProductID IN (
    SELECT TI.ProductID
    FROM TransactionItems TI
    GROUP BY TI.ProductID
    HAVING COUNT(TI.TransactionID) > 10
);


