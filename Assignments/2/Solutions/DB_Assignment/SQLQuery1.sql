--CREATE TABLE Categories (
--  category_id INT PRIMARY KEY,
--  name VARCHAR(50),
--  parent_category_id INT,
--  FOREIGN KEY (parent_category_id) REFERENCES Categories(category_id) ON DELETE NO ACTION ON UPDATE NO ACTION
--);

--CREATE TABLE Products (
--  product_id INT PRIMARY KEY,
--  name VARCHAR(50),
--  description TEXT,
--  price DECIMAL,
--  stock_level INT,
--  category_id INT,
--  FOREIGN KEY (category_id) REFERENCES Categories(category_id) ON DELETE CASCADE ON UPDATE CASCADE
--);


--CREATE TABLE Customers (
--  customer_id INT PRIMARY KEY,
--  first_name VARCHAR(50),
--  last_name VARCHAR(50) ,
--  email VARCHAR(255),
--  shipping_address TEXT,
--  billing_address TEXT
--);

--CREATE TABLE Reviews (
--  review_id INT PRIMARY KEY,
--  product_id INT,
--  customer_id INT,
--  rating INT,
--  review_text TEXT,
--  review_date DATE,
--  FOREIGN KEY (product_id) REFERENCES Products(product_id) ON DELETE CASCADE ON UPDATE CASCADE,
--  FOREIGN KEY (customer_id) REFERENCES Customers(customer_id) ON DELETE CASCADE ON UPDATE CASCADE
--);

--CREATE TABLE Promotions(
--promotion_id INT PRIMARY KEY,
--name VARCHAR(50),
--description TEXT,
--start_Date DATE,
--end_date DATE,
--discount_type VARCHAR(50),
--discount_value DECIMAL
--);

--CREATE TABLE Product_Promotions (
--  product_promotion_id INT PRIMARY KEY,
--  product_id INT,
--  promotion_id INT,
--  FOREIGN KEY (product_id) REFERENCES Products(product_id) ON DELETE CASCADE ON UPDATE CASCADE,
--  FOREIGN KEY (promotion_id) REFERENCES Promotions(promotion_id) ON DELETE CASCADE ON UPDATE CASCADE
--);

--CREATE TABLE Carts (
--  cart_id INT PRIMARY KEY,
--  customer_id INT,
--  creation_date DATE,
--  FOREIGN KEY (customer_id) REFERENCES Customers(customer_id) ON DELETE CASCADE ON UPDATE CASCADE
--);

--CREATE TABLE Cart_Items (
--  cart_item_id INT PRIMARY KEY,
--  cart_id INT,
--  product_id INT,
--  quantity INT,
--  FOREIGN KEY (cart_id) REFERENCES Carts(cart_id) ON DELETE CASCADE ON UPDATE CASCADE,
--  FOREIGN KEY (product_id) REFERENCES Products(product_id) ON DELETE CASCADE ON UPDATE CASCADE
--);

--CREATE TABLE Orders (
--  order_id INT PRIMARY KEY,
--  customer_id INT,
--  order_date DATE,
--  order_status VARCHAR(50),
--  FOREIGN KEY (customer_id) REFERENCES Customers(customer_id) ON DELETE CASCADE ON UPDATE CASCADE
--);

--CREATE TABLE Order_Items (
--  order_item_id INT PRIMARY KEY,
--  order_id INT,
--  product_id INT,
--  quantity INT,
--  FOREIGN KEY (order_id) REFERENCES Orders(order_id) ON DELETE CASCADE ON UPDATE CASCADE,
--  FOREIGN KEY (product_id) REFERENCES Products(product_id) ON DELETE CASCADE ON UPDATE CASCADE
--);


SELECT * FROM Categories;
SELECT * FROM Products;
SELECT * FROM Customers;
SELECT * FROM Reviews;
SELECT * FROM Promotions;
SELECT * FROM Product_Promotions;
SELECT * FROM Carts;
SELECT * FROM Cart_Items;
SELECT * FROM Orders;
SELECT * FROM Order_Items;


