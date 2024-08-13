
-- Drop foreign key constraints from Employees table
ALTER TABLE Employees DROP CONSTRAINT FK_Employees_Manager;

-- Drop foreign key constraints from EmployeeShifts table
ALTER TABLE EmployeeShifts DROP CONSTRAINT FK_EmployeeShifts_Employee;

-- Drop foreign key constraints from Ingredients table
ALTER TABLE Ingredients DROP CONSTRAINT FK_Ingredients_InventoryItem;

-- Drop foreign key constraints from InventoryItems table
ALTER TABLE InventoryItems DROP CONSTRAINT FK_InventoryItems_Supplier;

-- Drop foreign key constraints from Products table
ALTER TABLE Products DROP CONSTRAINT FK_Products_Menu;

-- Drop foreign key constraints from TransactionItems table
ALTER TABLE TransactionItems DROP CONSTRAINT FK_TransactionItems_Transactions;
ALTER TABLE TransactionItems DROP CONSTRAINT FK_TransactionItems_Products;

-- Drop foreign key constraints from Transactions table
ALTER TABLE Transactions DROP CONSTRAINT FK_Transactions_Customers;
ALTER TABLE Transactions DROP CONSTRAINT FK_Transactions_Employees;

-- Drop foreign key constraints from CustomerAccounts table
ALTER TABLE CustomerAccounts DROP CONSTRAINT FK_CustomerAccounts_Customers;
ALTER TABLE CustomerAccounts DROP CONSTRAINT FK_CustomerAccounts_LoyaltyPrograms;

-- Drop foreign key constraints from Instructions table
ALTER TABLE Instructions DROP CONSTRAINT FK_Instructions_Recipes;
ALTER TABLE Instructions DROP CONSTRAINT FK_Instructions_Ingredients;

ALTER TABLE Products DROP CONSTRAINT FK_RECIPEID;

ALTER TABLE Transactions
DROP CONSTRAINT df_Amount;

-- Drop the foreign key constraints in the Cart table
ALTER TABLE Cart DROP CONSTRAINT IF EXISTS FK_Cart_Customer;
ALTER TABLE Cart DROP CONSTRAINT IF EXISTS FK_Cart_Products;

-- Drop the foreign key constraints in the Register table
ALTER TABLE Register DROP CONSTRAINT IF EXISTS FK_Register_Transactions;
ALTER TABLE Register DROP CONSTRAINT IF EXISTS FK_Register_TransactionItems;
	




DROP TABLE Customers;
DROP TABLE Employees;
DROP TABLE Admins;
DROP TABLE EmployeeShifts;
DROP TABLE Ingredients;
DROP TABLE InventoryItems;
DROP TABLE LoyaltyPrograms;
DROP TABLE Menu;
DROP TABLE Products;
DROP TABLE Promotions;
DROP TABLE SalesReports;
DROP TABLE Suppliers;
DROP TABLE TransactionItems;
DROP TABLE Transactions;
DROP TABLE DataAnalyst;
DROP TABLE CustomerAccounts;
DROP TABLE Recipes;
DROP TABLE Instructions;
DROP TABLE Cart;
DROP TABLE Register;



