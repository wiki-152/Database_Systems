-- Creating Customers table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Email VARCHAR(100) DEFAULT '-',
    PhoneNumber VARCHAR(15),
	Date_of_birth DATE,
    UserName VARCHAR(50),
    Pass VARCHAR(50),
    Address VARCHAR(255)
);


-- Creating Employees table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Role VARCHAR(50),
	Date_of_birth DATE,
    UserName VARCHAR(50),
    Pass VARCHAR(50),
    Salary DECIMAL(10, 2),
    ManagerID INT,
    Address VARCHAR(255)
);

-- Creating Admins table
CREATE TABLE Admins (
    AdminId INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
	Date_of_birth DATE,
    UserName VARCHAR(50),
    Pass VARCHAR(50),
    Salary DECIMAL(10, 2),
    Address VARCHAR(100),
    Email VARCHAR(55)
);

-- Creating Analyst table
CREATE TABLE DataAnalyst (
    DataAnalystID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
	Date_of_birth DATE,
	Email VARCHAR(100),
    UserName VARCHAR(50),
    Pass VARCHAR(50),
    Salary DECIMAL(10, 2),
    Address VARCHAR(255)
);

-- Creating EmployeeShifts table
CREATE TABLE EmployeeShifts (
    ShiftID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    StartTime DATETIME,
    EndTime DATETIME
);

-- Creating Ingredients table
CREATE TABLE Ingredients (
    IngredientID INT PRIMARY KEY IDENTITY(1,1),
    IngredientName VARCHAR(100),
    InventoryItemID INT,
    CostPerUnit DECIMAL(10, 2)
);

-- Creating InventoryItems table
CREATE TABLE InventoryItems (
    ItemID INT PRIMARY KEY IDENTITY(1,1),
    ItemName VARCHAR(100),
    QuantityInStock INT,
    UnitOfMeasurement VARCHAR(50),
    ReorderThreshold INT,
    SupplierID INT
);

-- Creating LoyaltyPrograms table
CREATE TABLE LoyaltyPrograms (
    LoyaltyProgramID INT PRIMARY KEY IDENTITY(1,1),
    ProgramName VARCHAR(100),
    Description VARCHAR(255),
    PointsPerRuppeeSpent INT,
    PointsForSignup INT,
    ExpiryMonths INT
);

-- Creating Menu table
CREATE TABLE Menu (
    MenuID INT PRIMARY KEY IDENTITY(1,1),
    MenuName VARCHAR(100),
    IsActive BIT
);

-- Creating Products table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName VARCHAR(100),
    Description VARCHAR(255),
    Price DECIMAL(10, 2),
    Category VARCHAR(100),
    Availability BIT,
    MenuID INT,
	Image VARCHAR(255)
);

-- Creating Promotions table
CREATE TABLE Promotions (
    PromotionID INT PRIMARY KEY IDENTITY(1,1),
    PromotionName VARCHAR(100),
    Description VARCHAR(255),
    StartDate DATETIME,
    EndDate DATETIME,
    DiscountType VARCHAR(50),
    DiscountValue DECIMAL(10, 2),
    IsActive BIT
);

-- Creating SalesReports table
CREATE TABLE SalesReports (
    ReportID INT PRIMARY KEY IDENTITY(1,1),
    ReportDate DATETIME,
    TotalSales DECIMAL(10, 2),
    TotalTransactions INT,
    AverageTransactionValue DECIMAL(10, 2)
);

-- Creating Suppliers table
CREATE TABLE Suppliers (
    SupplierID INT PRIMARY KEY IDENTITY(1,1),
    SupplierName VARCHAR(100),
    ContactName VARCHAR(100),
    Phone VARCHAR(15),
    Email VARCHAR(100)
);

-- Creating TransactionItems table
CREATE TABLE TransactionItems (
    TransactionItemID INT PRIMARY KEY IDENTITY(1,1),
    TransactionID INT,
    ProductID INT,
    Quantity INT,
    Price DECIMAL(10, 2)
);

-- Creating Transactions table
CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    EmployeeID INT,
    TransactionDateTime DATETIME,
    TransactionType VARCHAR(50),
    TotalAmount DECIMAL(10, 2),
    RegisterID INT
);


-- Creating Customer Accounts table
CREATE TABLE CustomerAccounts	 (
    AccountID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
	LoyaltyProgramID INT,
	PointsBalance DECIMAL(10,2)
);

-- Creating Recipes table
CREATE TABLE Recipes	 (
    RecipeID INT PRIMARY KEY IDENTITY(1,1),
	RecipeName VARCHAR(255),
	Instructions VARCHAR(500)
);

-- Creating Instructions Table
CREATE TABLE Instructions(
InstructionID INT PRIMARY KEY IDENTITY(1,1),
RecipeID INT,
IngredientID INT,
Instructions VARCHAR(500)
);

CREATE TABLE Cart(
CustomerID INT PRIMARY KEY,
datum DATE,
ProductID INT 
);

ALTER TABLE Cart ADD CONSTRAINT FK_Cart_Customer FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID);
ALTER TABLE Cart ADD CONSTRAINT FK_Cart_Products FOREIGN KEY (ProductID) REFERENCES Products(ProductID);

CREATE TABLE Register(
TransactionID INT PRIMARY KEY,
TransactionItemID INT
);

ALTER TABLE Register ADD CONSTRAINT FK_Register_Transactions FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID);
ALTER TABLE Register ADD CONSTRAINT FK_Register_TransactionItems FOREIGN KEY (TransactionItemID) REFERENCES TransactionItems(TransactionItemID);


Alter Table Instructions 
ADD  Quantity int

Alter Table Products 
ADD RECIPEID int
Alter Table Products ADD CONSTRAINT FK_RECIPEID FOREIGN KEY (RECIPEID) references RECIPES

ALTER TABLE Transactions
ADD CONSTRAINT df_Amount
DEFAULT 0 FOR TotalAmount;




-- Add foreign key constraints
ALTER TABLE Employees ADD CONSTRAINT FK_Employees_Manager FOREIGN KEY (ManagerID) REFERENCES Employees(EmployeeID);
ALTER TABLE EmployeeShifts ADD CONSTRAINT FK_EmployeeShifts_Employee FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE Ingredients ADD CONSTRAINT FK_Ingredients_InventoryItem FOREIGN KEY (InventoryItemID) REFERENCES InventoryItems(ItemID) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE InventoryItems ADD CONSTRAINT FK_InventoryItems_Supplier FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE Products ADD CONSTRAINT FK_Products_Menu FOREIGN KEY (MenuID) REFERENCES Menu(MenuID) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE TransactionItems ADD CONSTRAINT FK_TransactionItems_Transactions FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE TransactionItems ADD CONSTRAINT FK_TransactionItems_Products FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE Transactions ADD CONSTRAINT FK_Transactions_Customers FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE Transactions ADD CONSTRAINT FK_Transactions_Employees FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE CustomerAccounts ADD CONSTRAINT FK_CustomerAccounts_Customers FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE CustomerAccounts ADD CONSTRAINT FK_CustomerAccounts_LoyaltyPrograms FOREIGN KEY (LoyaltyProgramID) REFERENCES LoyaltyPrograms(LoyaltyProgramID) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE Instructions ADD CONSTRAINT FK_Instructions_Recipes FOREIGN KEY (RecipeID) REFERENCES Recipes(RecipeID) ON DELETE CASCADE ON UPDATE CASCADE;
ALTER TABLE Instructions ADD CONSTRAINT FK_Instructions_Ingredients FOREIGN KEY (IngredientID) REFERENCES Ingredients(IngredientID) ON DELETE CASCADE ON UPDATE CASCADE;




