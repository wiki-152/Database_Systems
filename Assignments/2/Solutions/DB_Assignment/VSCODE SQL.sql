INSERT INTO Categories (category_id, name) VALUES (1, 'Clothing');
INSERT INTO Categories (category_id, name) VALUES (2, 'Electronics');
INSERT INTO Categories (category_id, name) VALUES (3, 'Beauty');
INSERT INTO Categories (category_id, name) VALUES (4, 'Sports');
INSERT INTO Categories (category_id, name) VALUES (5, 'Indoor');
INSERT INTO Categories (category_id, name) VALUES (6, 'Drinks');
INSERT INTO Categories (category_id, name) VALUES (7, 'Stationary');
INSERT INTO Categories (category_id, name) VALUES (8, 'Games');
INSERT INTO Categories (category_id, name) VALUES (9, 'Books');
INSERT INTO Categories (category_id, name) VALUES (10, 'Food');



INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (1, 'T-Shirt', 'Cotton T-Shirt For Adults', 20.00, 100, 1);
INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (2, 'Laptop', 'Laptop with RTX 3060', 1299.50, 50, 2);
INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (3, 'Lipstick', 'Red Colour Lipstick', 15.99, 75, 3);
INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (4, 'Basketball', 'Outdoor Basketball', 35.50, 40, 4);
INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (5, 'Board Game', 'Family Board Game', 49.99, 25, 5);
INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (6, 'Coffee', 'Cappucinno Coffee', 10.00, 30, 6);
INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (7, 'Pen', 'Blue Ink Pen', 5.00, 150, 7);
INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (8, 'Gran Turismo 7', 'PS5 Game', 79.99, 60, 8);
INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (9, 'Novel', 'Adventure Novel', 14.99, 80, 9);
INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (10, 'Pizza', 'Extra Large Pizza', 39.99, 45, 10);



INSERT INTO Customers (customer_id, first_name, last_name , email , shipping_address , billing_address) VALUES (1, 'Ali', 'Khan', 'alikhan@gmail.com', 'Bahria Town Rawalpindi', 'Bahria Town Rawalpindi');
INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (2, 'Ahmed', 'Ali', 'ahmed@gmail.com', 'Korangi Karachi', 'Korangi Karachi');
INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (3, 'Fatima', 'Khan', 'fatima@gmail.com', 'G13 Islamabad', 'Kashmir');
INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (4, 'Muhammad', 'Ahmed', 'muhammad@gmail.com', 'G10 Islamabad', 'Lahore');
INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (5, 'Ayesha', 'Siddiqui', 'ayesha@gmail.com', 'Rawalakot Kashmir', 'Rawalakot Kashmir');
INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (6, 'Hassan', 'Khan', 'hassan@gmail.com', 'Multan', 'Multan');
INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (7, 'Zainab', 'Malik', 'zainab@gmail.com', 'Sawan Garden Rawalpindi', 'Multan');
INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (8, 'Fatima', 'Raza', 'fatima@gmail.com', 'Phase 4 Bahria Town Rawalpindi', 'Phase 4 Bahria Town Rawalpindi');
INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (9, 'Bilal', 'Khan', 'bilal@gmail.com', 'Phase 7 Bahria Town Rawalpindi', 'Phase 7 Bahria Town Rawalpindi');
INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (10, 'Sana', 'Ahmed', 'sana@gmail.com', 'H13 Islamabad', 'H13 Islamabad');


INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (1,1, 1 , 5, 'Great T-Shirt!', '2024-03-25');
INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (2,2, 2 , 4, 'Good Laptop!', '2024-03-20');
INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (3,3, 3 , 3, 'Average Lipstick!', '2024-03-15');
INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (4,4, 4 , 2, 'Not a good Basketball!', '2024-03-10');
INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (5,5, 5 , 1, 'Poor Board Game!', '2024-03-05');
INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (6,6, 6 , 5, 'Best Coffee!', '2024-03-01');
INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (7,7, 7 , 4, 'Good Pen!', '2024-02-25');
INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (8,8, 8 , 3, 'Average Game!', '2024-02-20');
INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (9,9, 9 , 2, 'Not a good Novel!', '2024-02-15');
INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (10,10, 10 , 1, 'Poor Pizza!', '2024-02-10');


INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (1, 'Spring Sale', '20% off all clothing', '2024-04-01', '2024-04-30', 'percentage', 0.20);
INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (2, 'Summer Sale', '10% off all electronics', '2024-06-01', '2024-06-30', 'percentage', 0.10);
INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (3, 'Winter Sale', '30% off all beauty products', '2024-12-01', '2024-12-31', 'percentage', 0.30);
INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (4, 'Back to School Sale', '15% off all stationary', '2024-08-01', '2024-08-31', 'percentage', 0.15);
INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (5, 'Holiday Sale', '25% off all games', '2024-11-01', '2024-11-30', 'percentage', 0.25);
INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (6, 'New Year Sale', '50% off all books', '2024-01-01', '2024-01-31', 'percentage', 0.50);
INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (7, 'Valentine Sale', '5% off all food items', '2024-02-01', '2024-02-14', 'percentage', 0.05);
INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (8, 'Eid Sale', '40% off all sports items', '2024-05-01', '2024-05-31', 'percentage', 0.40);
INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (9, 'Independence Day Sale', '10% off all indoor items', '2024-08-14', '2024-08-14', 'percentage', 0.10);
INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (10, 'Black Friday Sale', '75% off all drinks', '2024-11-29', '2024-11-29', 'percentage', 0.75);


CREATE TABLE Product_Promotions (
 product_promotion_id INT PRIMARY KEY,
 product_id INT,
 promotion_id INT,
 FOREIGN KEY (product_id) REFERENCES Products(product_id) ON DELETE CASCADE ON UPDATE CASCADE,
 FOREIGN KEY (promotion_id) REFERENCES Promotions(promotion_id) ON DELETE CASCADE ON UPDATE CASCADE
);

INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (1, 1, 1);
INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (2, 2, 2);
INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (3, 3, 3);
INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (4, 4, 4);
INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (5, 5, 5);
INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (6, 6, 6);
INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (7, 7, 7);
INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (8, 8, 8);
INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (9, 9, 9);
INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (10, 10, 10);

CREATE TABLE Carts (
 cart_id INT PRIMARY KEY,
 customer_id INT,
 creation_date DATE,
 FOREIGN KEY (customer_id) REFERENCES Customers(customer_id) ON DELETE CASCADE ON UPDATE CASCADE
);

INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (1, 1, '2024-03-25');
INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (2, 2, '2024-03-20');
INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (3, 3, '2024-03-15');
INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (4, 4, '2024-03-10');
INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (5, 5, '2024-03-05');
INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (6, 6, '2024-03-01');
INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (7, 7, '2024-02-25');
INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (8, 8, '2024-02-20');
INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (9, 9, '2024-02-15');
INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (10, 10, '2024-02-10');

CREATE TABLE Cart_Items (
 cart_item_id INT PRIMARY KEY,
 cart_id INT,
 product_id INT,
 quantity INT,
 FOREIGN KEY (cart_id) REFERENCES Carts(cart_id) ON DELETE CASCADE ON UPDATE CASCADE,
 FOREIGN KEY (product_id) REFERENCES Products(product_id) ON DELETE CASCADE ON UPDATE CASCADE
);

INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (1, 1, 1, 2);
INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (2, 2, 2, 1);
INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (3, 3, 3, 3);
INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (4, 4, 4, 1);
INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (5, 5, 5, 2);
INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (6, 6, 6, 5);
INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (7, 7, 7, 1);
INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (8, 8, 8, 2);
INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (9, 9, 9, 3);
INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (10, 10, 10, 1);

CREATE TABLE Orders (
 order_id INT PRIMARY KEY,
 customer_id INT,
 order_date DATE,
 order_status VARCHAR(50),
 FOREIGN KEY (customer_id) REFERENCES Customers(customer_id) ON DELETE CASCADE ON UPDATE CASCADE
);

INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (1, 1, '2024-03-25', 'Shipped');
INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (2, 2, '2024-03-20', 'Delivered');
INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (3, 3, '2024-03-15', 'Processing');
INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (4, 4, '2024-03-10', 'Cancelled');
INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (5, 5, '2024-03-05', 'Shipped');
INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (6, 6, '2024-03-01', 'Delivered');
INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (7, 7, '2024-02-25', 'Processing');
INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (8, 8, '2024-02-20', 'Cancelled');
INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (9, 9, '2024-02-15', 'Shipped');
INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (10, 10, '2024-02-10', 'Delivered');

CREATE TABLE Order_Items (
  order_item_id INT PRIMARY KEY,
  order_id INT,
  product_id INT,
  quantity INT,
  FOREIGN KEY (order_id) REFERENCES Orders(order_id) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (product_id) REFERENCES Products(product_id) ON DELETE CASCADE ON UPDATE CASCADE
);

INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (1, 1, 1, 2);
INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (2, 2, 2, 1);
INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (3, 3, 3, 3);
INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (4, 4, 4, 1);
INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (5, 5, 5, 2);
INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (6, 6, 6, 5);
INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (7, 7, 7, 1);
INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (8, 8, 8, 5);
INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (9, 9, 9, 3);
INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (10, 10, 10, 1);

-- 1. Select all columns from the Products table.
-- 2. Select specific columns (name, price) from the Products table.
-- 3. Select products with a price greater than 1000.
-- 4. Select products with a stock level less than or equal to 50.
-- 5. Select products sorted by price in descending order.
-- 6. Select products with a price between 1000 and 5000.
-- 7. Select products with a name starting with 'P'.
-- 8. Select products with a name containing 'Shoes'.
-- 9. Select products sorted by name in ascending order.
-- 10. Select distinct categories from the Products table.
-- 11. Select products with a price less than or equal to 3000 and in category 2.
-- 12. Select products with a stock level greater than or equal to 10 and less than or equal to 20.
-- 13. Select products with a name starting with 'M' and price greater than 5000.
-- 14. Select products with a description containing 'embroidered' and price less than 3000.
-- 15. Select products sorted by stock level in descending order.
-- 16. Select products with a name not starting with 'L'.
-- 17. Select products with a price greater than the average price.
-- 18. Select products with a stock level less than the minimum stock level.
-- 19. Select products with a category ID in a list (1, 3, 4).
-- 20. Select products with a name ending with 'Suit'.

--Query 1
SELECT * FROM Products;

--Query 2
SELECT name, price FROM Products;

--Query 3
SELECT * FROM Products WHERE price > 1000;

--Query 4
SELECT * FROM Products WHERE stock_level <= 50;

--Query 5
SELECT * FROM Products ORDER BY price DESC;

--Query 6
SELECT * FROM Products WHERE price BETWEEN 1000 AND 5000;

--Query 7
SELECT * FROM Products WHERE name LIKE 'P%';

--Query 8
SELECT * FROM Products WHERE name LIKE '%Shoes%';

--Query 9
SELECT * FROM Products ORDER BY name ASC;

--Query 10
SELECT DISTINCT category_id FROM Products;

--Query 11
SELECT * FROM Products WHERE price <= 3000 AND category_id = 2;

--Query 12
SELECT * FROM Products WHERE stock_level >= 10 AND stock_level <= 20;

--Query 13
SELECT * FROM Products WHERE name LIKE 'M%' AND price > 5000;

--Query 14
SELECT * FROM Products WHERE description LIKE '%embroidered%' AND price < 3000;

--Query 15
SELECT * FROM Products ORDER BY stock_level DESC;

--Query 16
SELECT * FROM Products WHERE name NOT LIKE 'L%';

--Query 17
SELECT * FROM Products WHERE price > (SELECT AVG(price) FROM Products);

--Query 18
SELECT * FROM Products WHERE stock_level < (SELECT MIN(stock_level) FROM Products);

--Query 19
SELECT * FROM Products WHERE category_id IN (1, 3, 4);

--Query 20
SELECT * FROM Products WHERE name LIKE '%Suit';

-- 21. Count the total number of products.
-- 22. Calculate the average price of products.
-- 23. Find the maximum price among products.
-- 24. Find the minimum stock level among products.
-- 25. Sum up the total stock levels of all products.
-- 26. Calculate the average stock level of products.
-- 27. Count the number of products in each category.
-- 28. Calculate the total value of all products (price * stock_level).
-- 29. Find the product with the highest price.
-- 30. Calculate the total number of characters in all product names.
-- 31. Find the average price of products in each category.
-- 32. Find the product with the lowest stock level.
-- 33. Calculate the total number of products in stock (stock_level > 0).
-- 34. Calculate the total price of all products.
-- 35. Find the category with the most products.
-- 36. Calculate the difference between the highest and lowest prices.

-- 37. Find the product with the highest stock level.
-- 38. Find the category with the highest average price.
-- 39. Calculate the total number of products with prices greater than 5000.
-- 40. Calculate the total value of products in each category (price * stock_level).

--Query 21
SELECT COUNT(*) AS total_products FROM Products;

--Query 22
SELECT AVG(price) AS average_price FROM Products;

--Query 23
SELECT MAX(price) AS max_price FROM Products;

--Query 24
SELECT MIN(stock_level) AS min_stock_level FROM Products;

--Query 25
SELECT SUM(stock_level) AS total_stock_levels FROM Products;

--Query 26
SELECT AVG(stock_level) AS average_stock_level FROM Products;

--Query 27
SELECT category_id, COUNT(*) AS total_products FROM Products GROUP BY category_id;

--Query 28
SELECT SUM(price * stock_level) AS total_value FROM Products;

--Query 29
SELECT * FROM Products WHERE price = (SELECT MAX(price) FROM Products);

--Query 30
SELECT SUM(LENGTH(name)) AS total_characters FROM Products;

--Query 31
SELECT category_id, AVG(price) AS average_price FROM Products GROUP BY category_id;

--Query 32
SELECT * FROM Products WHERE stock_level = (SELECT MIN(stock_level) FROM Products);

--Query 33
SELECT COUNT(*) AS total_products_in_stock FROM Products WHERE stock_level > 0;

--Query 34
SELECT SUM(price) AS total_price FROM Products;

--Query 35
SELECT category_id, COUNT(*) AS total_products FROM Products GROUP BY category_id ORDER BY total_products DESC LIMIT 1;

--Query 36
SELECT MAX(price) - MIN(price) AS price_difference FROM Products;

--Query 37
SELECT * FROM Products WHERE stock_level = (SELECT MAX(stock_level) FROM Products);

--Query 38
SELECT category_id, AVG(price) AS average_price FROM Products GROUP BY category_id ORDER BY average_price DESC LIMIT 1;

--Query 39
SELECT COUNT(*) AS total_products_gt_5000 FROM Products WHERE price > 5000;

--Query 40
SELECT category_id, SUM(price * stock_level) AS total_value FROM Products GROUP BY category_id;

-- 41. Calculate the total number of orders.
-- 42. Calculate the average order total.
-- 43. Find the customer who made the most orders.
-- 44. Calculate the total number of reviews for each product.
-- 45. Calculate the total revenue generated from each category.
-- 46. Find the average price of products purchased by each customer.
-- 47. Calculate the total value of products in each promotion.
-- 48. Count the total number of carts for each customer.
-- 49. Calculate the total number of items in each order.
-- 50. Find the customer with the highest total spending.
-- 51. Calculate the total number of reviews written by each customer.
-- 52. Calculate the average order total for each customer.
-- 53. Find the category with the highest average price of products.
-- 54. Count the total number of orders placed in each month.
-- 55. Calculate the total revenue generated by each customer.
-- 56. Calculate the total number of reviews for each product category.
-- 57. Find the product with the highest average rating.
-- 58. Calculate the total number of orders per year.
-- 59. Find the customer who made the highest single order.
-- 60. Calculate the total value of products purchased by each customer.

--Query 41
SELECT COUNT(*) AS total_orders FROM Orders;

--Query 42
SELECT AVG(price * quantity) AS average_order_total FROM Order_Items;

--Query 43
SELECT customer_id, COUNT(*) AS total_orders FROM Orders GROUP BY customer_id ORDER BY total_orders DESC LIMIT 1;

--Query 44
SELECT product_id, COUNT(*) AS total_reviews FROM Reviews GROUP BY product_id;

--Query 45
SELECT category_id, SUM(price * quantity) AS total_revenue FROM Order_Items JOIN Products ON Order_Items.product_id = Products.product_id GROUP BY category_id;

--Query 46
SELECT customer_id, AVG(price) AS average_price FROM Order_Items JOIN Products ON Order_Items.product_id = Products.product_id GROUP BY customer_id;

--Query 47
SELECT promotion_id, SUM(price * quantity) AS total_value FROM Order_Items JOIN Products ON Order_Items.product_id = Products.product_id JOIN Product_Promotions ON Products.product_id = Product_Promotions.product_id GROUP BY promotion_id;

--Query 48
SELECT customer_id, COUNT(*) AS total_carts FROM Carts GROUP BY customer_id;

--Query 49
SELECT order_id, SUM(quantity) AS total_items FROM Order_Items GROUP BY order_id;

--Query 50
SELECT customer_id, SUM(price * quantity) AS total_spending FROM Order_Items JOIN Products ON Order_Items.product_id = Products.product_id GROUP BY customer_id ORDER BY total_spending DESC LIMIT 1;

--Query 51
SELECT customer_id, COUNT(*) AS total_reviews FROM Reviews GROUP BY customer_id;

--Query 52
SELECT customer_id, AVG(price * quantity) AS average_order_total FROM Order_Items GROUP BY customer_id;

--Query 53
SELECT category_id, AVG(price) AS average_price FROM Products GROUP BY category_id ORDER BY average_price DESC LIMIT 1;

--Query 54
SELECT EXTRACT(MONTH FROM order_date) AS month, COUNT(*) AS total_orders FROM Orders GROUP BY month;

--Query 55
SELECT customer_id, SUM(price * quantity) AS total_revenue FROM Order_Items JOIN Products ON Order_Items.product_id = Products.product_id GROUP BY customer_id;

--Query 56
SELECT category_id, COUNT(*) AS total_reviews FROM Reviews JOIN Products ON Reviews.product_id = Products.product_id GROUP BY category_id;

--Query 57
SELECT product_id, AVG(rating) AS average_rating FROM Reviews GROUP BY product_id ORDER BY average_rating DESC LIMIT 1;

--Query 58
SELECT EXTRACT(YEAR FROM order_date) AS year, COUNT(*) AS total_orders FROM Orders GROUP BY year;

--Query 59
SELECT customer_id, SUM(price * quantity) AS total_spending FROM Order_Items GROUP BY customer_id ORDER BY total_spending DESC LIMIT 1;

--Query 60
SELECT customer_id, SUM(price * quantity) AS total_value FROM Order_Items JOIN Products ON Order_Items.product_id = Products.product_id GROUP BY customer_id;

-- 61. Find the total number of products in each category.
-- 62. Find the average price of products in each category.
-- 63. Find the category with the highest total value of products (price * stock_level).
-- 64. Find the average stock level of products in categories with more than 10 products.
-- 65. Find the total number of orders for each customer.
-- 66. Find the average order value (total price of order) for each customer.
-- 67. Find the total number of products in stock in each city where customers are located.
-- 68. Find the customer(s) with the highest total order value.
-- 69. Find the category with the highest average price.
-- 70. Find the product with the highest rating.
-- 71. Find the total number of products purchased by each customer.
-- 72. Find the average rating of products in each category.
-- 73. Find the category with the highest total number of products.
-- 74. Find the customer(s) who have placed orders with the highest total value.
-- 75. Find the product(s) with the highest total number of orders.
-- 76. Find the category with the highest total order value.
-- 77. Find the customer(s) with the highest average order value.
-- 78. Find the product(s) with the highest total order quantity.

-- 79. Find the customer(s) who have placed orders with the highest average quantity per order.
-- 80. Find the category with the highest average stock level.

--Query 61
SELECT category_id, COUNT(*) AS total_products FROM Products GROUP BY category_id;

--Query 62
SELECT category_id, AVG(price) AS average_price FROM Products GROUP BY category_id;

--Query 63
SELECT category_id, SUM(price * stock_level) AS total_value FROM Products GROUP BY category_id ORDER BY total_value DESC LIMIT 1;

--Query 64
SELECT category_id, AVG(stock_level) AS average_stock_level FROM Products GROUP BY category_id HAVING COUNT(*) > 10;

--Query 65
SELECT customer_id, COUNT(*) AS total_orders FROM Orders GROUP BY customer_id;

--Query 66
SELECT customer_id, SUM(price * quantity) AS total_order_value FROM Order_Items GROUP BY customer_id;

--Query 67
SELECT shipping_address, SUM(stock_level) AS total_stock FROM Products JOIN Customers ON Products.customer_id = Customers.customer_id GROUP BY shipping_address;

--Query 68
SELECT customer_id, SUM(price * quantity) AS total_order_value FROM Order_Items GROUP BY customer_id ORDER BY total_order_value DESC LIMIT 1;

--Query 69
SELECT category_id, AVG(price) AS average_price FROM Products GROUP BY category_id ORDER BY average_price DESC LIMIT 1;

--Query 70
SELECT product_id, AVG(rating) AS average_rating FROM Reviews GROUP BY product_id ORDER BY average_rating DESC LIMIT 1;

--Query 71
SELECT customer_id, SUM(quantity) AS total_products_purchased FROM Order_Items GROUP BY customer_id;

--Query 72
SELECT category_id, AVG(rating) AS average_rating FROM Reviews JOIN Products ON Reviews.product_id = Products.product_id GROUP BY category_id;

--Query 73
SELECT category_id, COUNT(*) AS total_products FROM Products GROUP BY category_id ORDER BY total_products DESC LIMIT 1;

--Query 74
SELECT customer_id, SUM(price * quantity) AS total_order_value FROM Order_Items GROUP BY customer_id ORDER BY total_order_value DESC LIMIT 1;

--Query 75
SELECT product_id, SUM(quantity) AS total_orders FROM Order_Items GROUP BY product_id ORDER BY total_orders DESC LIMIT 1;

--Query 76
SELECT category_id, SUM(price * quantity) AS total_order_value FROM Order_Items JOIN Products ON Order_Items.product_id = Products.product_id GROUP BY category_id ORDER BY total_order_value DESC LIMIT 1;

--Query 77
SELECT customer_id, AVG(price * quantity) AS average_order_value FROM Order_Items GROUP BY customer_id ORDER BY average_order_value DESC LIMIT 1;

--Query 78
SELECT product_id, SUM(quantity) AS total_order_quantity FROM Order_Items GROUP BY product_id ORDER BY total_order_quantity DESC LIMIT 1;

--Query 79
SELECT customer_id, AVG(quantity) AS average_quantity_per_order FROM Order_Items GROUP BY customer_id ORDER BY average_quantity_per_order DESC LIMIT 1;

--Query 80
SELECT category_id, AVG(stock_level) AS average_stock_level FROM Products GROUP BY category_id ORDER BY average_stock_level DESC LIMIT 1;