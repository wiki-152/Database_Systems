
-- Customers
INSERT INTO Customers ( FirstName, LastName, Email, PhoneNumber, Date_of_birth, UserName, Pass, Address) VALUES
( 'John', 'Doe', 'john.doe@example.com', '1234567890', '2001-01-01', 'john', '123', '123 Elm Street'),
( 'Jane', 'Smith', 'jane.smith@example.com', '2345678901', '2001-01-01', 'jane_smith', 'janesmith123', '456 Oak Avenue'),
( 'Alice', 'Johnson', 'alice.johnson@example.com', '3456789012', '2001-01-01', 'alice_johnson', 'alicejohnson123', '789 Pine Road'),
( 'Bob', 'Brown', 'bob.brown@example.com', '4567890123', '2001-01-01', 'bob_brown', 'bobbrown123', '321 Maple Lane'),
( 'Carol', 'Davis', 'carol.davis@example.com', '5678901234', '2001-01-01', 'carol_davis', 'caroldavis123', '654 Cedar Blvd');


-- Employees
INSERT INTO Employees ( FirstName, LastName, Role, Date_of_birth, UserName, Pass, Salary, ManagerID, Address) VALUES
( 'Steve', 'Wilson', 'Manager', '2002-01-01', 'steve', 'ste', 50000.00, NULL, '400 River St'),
( 'Emma', 'Watson', 'Cashier', '2002-01-01', 'emma_watson', 'emmawatson123', 30000.00, 1, '401 River St'),
( 'Ryan', 'Gosling', 'Chef', '2002-01-01', 'ryan_gosling', 'ryangosling123', 35000.00, 1, '402 River St'),
( 'Rachel', 'Green', 'Server', '2002-01-01', 'rachel_green', 'rachelgreen123', 25000.00, 1, '403 River St'),
( 'Ross', 'Geller', 'Cook', '2002-01-01', 'ross_geller', 'rossgeller123', 32000.00, 1, '404 River St');


-- Admins
INSERT INTO Admins ( FirstName, LastName, Date_of_birth, UserName, Pass, Salary, Address, Email) VALUES
( 'Olivia', 'Martinez', '2002-01-01', 'olivia', '111', 60000.00, '500 Circle Dr', 'olivia.martinez@example.com'),
( 'Sophia', 'Lopez', '2002-01-01', 'sophia_lopez', 'sophialopez123', 60000.00, '501 Circle Dr', 'sophia.lopez@example.com'),
( 'Isabella', 'Garcia', '2002-01-01', 'isabella_garcia', 'isabellagarcia123', 60000.00, '502 Circle Dr', 'isabella.garcia@example.com'),
( 'Mia', 'Hernandez', '2002-01-01', 'mia_hernandez', 'miahernandez123', 60000.00, '503 Circle Dr', 'mia.hernandez@example.com'),
( 'Emily', 'Martinez', '2002-01-01', 'emily_martinez', 'emilymartinez123', 60000.00, '504 Circle Dr', 'emily.martinez@example.com');

-- DataAnalyst
INSERT INTO DataAnalyst ( FirstName, LastName, Date_of_birth, UserName, Pass, Salary, Address) VALUES
( 'David', 'Miller', '2002-01-01', 'david_miller', 'davidmiller123', 70000.00, '600 Main St'),
( 'Emma', 'Davis', '2002-01-01', 'emma_davis', 'emmadavis123', 70000.00, '601 Main St'),
( 'Michael', 'Wilson', '2002-01-01', 'michael_wilson', 'michaelwilson123', 70000.00, '602 Main St'),
( 'Sophia', 'Anderson', '2002-01-01', 'sophia_anderson', 'sophiaanderson123', 70000.00, '603 Main St'),
( 'James', 'Thomas', '2002-01-01', 'james_thomas', 'jamesthomas123', 70000.00, '604 Main St');


-- EmployeeShifts
INSERT INTO EmployeeShifts ( EmployeeID, StartTime, EndTime) VALUES
( 2, '2023-01-01 09:00:00', '2023-01-01 17:00:00'),
( 3, '2023-01-01 09:00:00', '2023-01-01 17:00:00'),
( 4, '2023-01-01 14:00:00', '2023-01-01 22:00:00'),
( 5, '2023-01-01 14:00:00', '2023-01-01 22:00:00'),
( 3, '2023-01-02 09:00:00', '2023-01-02 17:00:00');



-- LoyaltyPrograms
INSERT INTO LoyaltyPrograms ( ProgramName, Description, PointsPerRuppeeSpent, PointsForSignup, ExpiryMonths) VALUES
( 'Silver Rewards', 'Earn points for every purchase.', 1, 100, 12),
( 'Gold Rewards', 'Higher points per spend and bonus points.', 2, 200, 24),
( 'Platinum Rewards', 'Premium rewards program for elite customers.', 3, 500, 36),
( 'Diamond Rewards', 'Exclusive rewards for top-tier customers.', 5, 1000, 48),
( 'Bronze Rewards', 'Basic rewards program for new customers.', 0.5, 50, 6);

-- Menu
INSERT INTO Menu ( MenuName, IsActive) VALUES
( 'Breakfast Menu', 1),
( 'Lunch Menu', 1),
( 'Dinner Menu', 1),
( 'Seasonal Menu', 1),
( 'Kids Menu', 1);

-- Products
INSERT INTO Products ( ProductName, Description, Price, Category, Availability, MenuID, Image,RECIPEID) VALUES
( 'Cheeseburger', 'A juicy cheeseburger with lettuce, tomato, and sauce.', 9.99, 'Main Course', 1, 2, 'cheeseburger.jpg',1),
( 'Veggie Pizza', 'Large pizza with bell peppers, onions, and olives.', 12.99, 'Main Course', 1, 3, 'veggiepizza.jpg',2),
( 'Chocolate Cake', 'Rich chocolate cake with frosting.', 4.99, 'Dessert', 1, 3, 'chocolatecake.jpg',3),
( 'Caesar Salad', 'Fresh lettuce with Caesar dressing, croutons, and parmesan.', 7.99, 'Salad', 1, 2, 'caesarsalad.jpg',4),
( 'Chicken Wings', 'Spicy buffalo chicken wings with blue cheese dip.', 8.99, 'Appetizer', 1, 2, 'chickenwings.jpg',5);


-- Promotions
INSERT INTO Promotions ( PromotionName, Description, StartDate, EndDate, DiscountType, DiscountValue, IsActive) VALUES
( 'Summer Sale', '20% off on all salads.', '2023-06-01 00:00:00', '2023-06-30 23:59:59', 'Percentage', 20.00, 1),
( 'Happy Hour', '50% off on appetizers from 5 pm to 7 pm.', '2023-07-01 00:00:00', '2023-07-31 23:59:59', 'Percentage', 50.00, 1),
( 'Weekend Special', 'Buy one get one free on all pizzas.', '2023-08-01 00:00:00', '2023-08-31 23:59:59', 'BOGO', 0.00, 1),
( 'Holiday Gifts', '30% off on desserts during December.', '2023-12-01 00:00:00', '2023-12-31 23:59:59', 'Percentage', 30.00, 1),
( 'New Year Special', '25% off on all menu items on New Year’s Day.', '2024-01-01 00:00:00', '2024-01-01 23:59:59', 'Percentage', 25.00, 1);


-- SalesReports
INSERT INTO SalesReports ( ReportDate, TotalSales, TotalTransactions, AverageTransactionValue) VALUES
( '2023-01-01', 12345.67, 100, 123.46),
( '2023-02-01', 23456.78, 200, 117.28),
( '2023-03-01', 34567.89, 300, 115.23),
( '2023-04-01', 45678.90, 400, 114.20),
( '2023-05-01', 56789.01, 500, 113.58);


INSERT INTO Suppliers ( SupplierName, ContactName, Phone, Email) VALUES
( 'Fresh Produce Inc.', 'John Smith', '123-456-7890', 'info@freshproduce.com'),
( 'Bakers Paradise', 'Emily Jones', '234-567-8901', 'sales@bakersparadise.com'),
( 'Dairy Delights', 'Mark Johnson', '345-678-9012', 'orders@dairydelights.com'),
( 'Poultry Palace', 'Sarah Lee', '456-789-0123', 'contact@poultrypalace.com'),
( 'Green Leaf Farms', 'Michael Brown', '567-890-1234', 'info@greenleaffarms.com');


-- Transactions
INSERT INTO Transactions ( CustomerID, EmployeeID, TransactionDateTime, TransactionType, TotalAmount, RegisterID) VALUES
( 1, 2, '2023-01-01 12:34:56', 'Sale', 45.67, 1),
( 2, 3, '2023-01-02 13:45:23', 'Sale', 56.78, 2),
( 3, 4, '2023-01-03 14:56:34', 'Sale', 67.89, 3),
( 4, 5, '2023-01-04 15:07:45', 'Sale', 78.90, 1),
( 5, 2, '2023-01-05 16:18:56', 'Sale', 89.01, 2);



-- CustomerAccounts
INSERT INTO CustomerAccounts ( CustomerID, LoyaltyProgramID, PointsBalance) VALUES
( 1, 1, 500.00),
( 2, 2, 750.00),
( 3, 3, 1000.00),
( 4, 4, 1250.00),
( 5, 5, 1500.00);


-- Recipes
INSERT INTO Recipes ( RecipeName, Instructions) VALUES
( 'Classic Cheeseburger', '1. Grill burger patties. 2. Assemble burgers with cheese, lettuce, tomato, and sauce.'),
( 'Veggie Pizza', '1. Roll out pizza dough. 2. Spread sauce and add vegetables. 3. Bake in oven.'),
( 'Chocolate Cake', '1. Mix cake batter. 2. Bake in cake pans. 3. Frost with chocolate frosting.'),
( 'Caesar Salad', '1. Chop lettuce. 2. Toss with dressing, croutons, and parmesan cheese.'),
( 'Buffalo Chicken Wings', '1. Fry chicken wings. 2. Toss in buffalo sauce. 3. Serve with blue cheese dip.');

-- InventoryItems
INSERT INTO InventoryItems ( ItemName, QuantityInStock, UnitOfMeasurement, ReorderThreshold, SupplierID) VALUES
( 'Tomatoes', 100, 'Kg', 20, 1),
( 'Flour', 200, 'Kg', 50, 2),
( 'Cheese', 150, 'Kg', 30, 3),
( 'Chicken', 75, 'Kg', 25, 4),
( 'Lettuce', 80, 'Kg', 15, 5);

-- Ingredients
INSERT INTO Ingredients (IngredientName, InventoryItemID, CostPerUnit) VALUES
( 'Tomato', 1, 0.50),
( 'Flour', 2, 0.75),
( 'Cheese', 3, 1.50),
( 'Chicken', 4, 2.00),
( 'Lettuce', 5, 0.30);

-- Instructions
INSERT INTO Instructions ( RecipeID, IngredientID, Instructions) VALUES
( 1, 4, 'Grill burger patties for 5 minutes on each side.'),
( 1, 5, 'Assemble burgers with lettuce, tomato, and sauce.'),
( 2, 2, 'Spread pizza sauce on rolled out dough.'),
( 2, 1, 'Top with bell peppers, onions, and olives.'),
( 3, 2, 'Mix cake batter according to instructions.')

-- Assuming there are transactions with IDs 1 and 2
-- and assuming product IDs follow the insertion order starting from 1
INSERT INTO TransactionItems (TransactionID, ProductID, Quantity, Price) VALUES
(1, 1, 2, 9.99),   -- 2 Cheeseburgers for Transaction 1
(1, 5, 4, 8.99),   -- 4 Chicken Wings for Transaction 1
(2, 2, 1, 12.99),  -- 1 Veggie Pizza for Transaction 2
(2, 3, 3, 4.99),   -- 3 Chocolate Cakes for Transaction 2
(1, 4, 1, 7.99);   -- 1 Caesar Salad for Transaction 1

--Cart
INSERT INTO Cart (CustomerID, datum, ProductID) VALUES (1, '2023-05-01', 1);
INSERT INTO Cart (CustomerID, datum, ProductID) VALUES (2, '2023-05-02', 4);
INSERT INTO Cart (CustomerID, datum, ProductID) VALUES (3, '2023-05-03', 2);
INSERT INTO Cart (CustomerID, datum, ProductID) VALUES (4, '2023-05-04', 1);
INSERT INTO Cart (CustomerID, datum, ProductID) VALUES (5, '2023-05-05', 2);

--Register
INSERT INTO Register (TransactionID, TransactionItemID) VALUES (1, 1);
INSERT INTO Register (TransactionID, TransactionItemID) VALUES (2, 2);
INSERT INTO Register (TransactionID, TransactionItemID) VALUES (3, 3);
INSERT INTO Register (TransactionID, TransactionItemID) VALUES (4, 4);
INSERT INTO Register (TransactionID, TransactionItemID) VALUES (5, 5);












