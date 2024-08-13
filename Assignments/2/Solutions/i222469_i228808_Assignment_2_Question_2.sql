--INSERT INTO Categories (category_id, name) VALUES (1, 'Clothing');
--INSERT INTO Categories (category_id, name) VALUES (2, 'Electronics');
--INSERT INTO Categories (category_id, name) VALUES (3, 'Beauty');
--INSERT INTO Categories (category_id, name) VALUES (4, 'Sports');
--INSERT INTO Categories (category_id, name) VALUES (5, 'Indoor');
--INSERT INTO Categories (category_id, name) VALUES (6, 'Drinks');
--INSERT INTO Categories (category_id, name) VALUES (7, 'Stationary');
--INSERT INTO Categories (category_id, name) VALUES (8, 'Games');
--INSERT INTO Categories (category_id, name) VALUES (9, 'Books');
--INSERT INTO Categories (category_id, name) VALUES (10, 'Food');



--INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (1, 'T-Shirt', 'Cotton T-Shirt For Adults', 20.00, 100, 1);
--INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (2, 'Laptop', 'Laptop with RTX 3060', 1299.50, 50, 2);
--INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (3, 'Lipstick', 'Red Colour Lipstick', 15.99, 75, 3);
--INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (4, 'Basketball', 'Outdoor Basketball', 35.50, 40, 4);
--INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (5, 'Board Game', 'Family Board Game', 49.99, 25, 5);
--INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (6, 'Coffee', 'Cappucinno Coffee', 10.00, 30, 6);
--INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (7, 'Pen', 'Blue Ink Pen', 5.00, 150, 7);
--INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (8, 'Gran Turismo 7', 'PS5 Game', 79.99, 60, 8);
--INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (9, 'Novel', 'Adventure Novel', 14.99, 80, 9);
--INSERT INTO Products (product_id, name, description, price, stock_level, category_id) VALUES (10, 'Pizza', 'Extra Large Pizza', 39.99, 45, 10);



--INSERT INTO Customers (customer_id, first_name, last_name , email , shipping_address , billing_address) VALUES (1, 'Ali', 'Khan', 'alikhan@gmail.com', 'Bahria Town Rawalpindi', 'Bahria Town Rawalpindi');
--INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (2, 'Ahmed', 'Ali', 'ahmed@gmail.com', 'Korangi Karachi', 'Korangi Karachi');
--INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (3, 'Fatima', 'Khan', 'fatima@gmail.com', 'G13 Islamabad', 'Kashmir');
--INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (4, 'Muhammad', 'Ahmed', 'muhammad@gmail.com', 'G10 Islamabad', 'Lahore');
--INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (5, 'Ayesha', 'Siddiqui', 'ayesha@gmail.com', 'Rawalakot Kashmir', 'Rawalakot Kashmir');
--INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (6, 'Hassan', 'Khan', 'hassan@gmail.com', 'Multan', 'Multan');
--INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (7, 'Zainab', 'Malik', 'zainab@gmail.com', 'Sawan Garden Rawalpindi', 'Multan');
--INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (8, 'Fatima', 'Raza', 'fatima@gmail.com', 'Phase 4 Bahria Town Rawalpindi', 'Phase 4 Bahria Town Rawalpindi');
--INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (9, 'Bilal', 'Khan', 'bilal@gmail.com', 'Phase 7 Bahria Town Rawalpindi', 'Phase 7 Bahria Town Rawalpindi');
--INSERT INTO Customers (customer_id, first_name, last_name, email, shipping_address, billing_address) VALUES (10, 'Sana', 'Ahmed', 'sana@gmail.com', 'H13 Islamabad', 'H13 Islamabad');

--UPDATE Customers
--SET city = 'Islamabad'
--WHERE customer_id BETWEEN 1 AND 3;

--UPDATE Customers
--SET city = 'Karachi'
--WHERE customer_id BETWEEN 4 AND 7;

--UPDATE Customers
--SET city = 'Lahore'
--WHERE customer_id BETWEEN 8 AND 10;


--INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (1,1, 1 , 5, 'Great T-Shirt!', '2024-03-25');
--INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (2,2, 2 , 4, 'Good Laptop!', '2024-03-20');
--INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (3,3, 3 , 3, 'Average Lipstick!', '2024-03-15');
--INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (4,4, 4 , 2, 'Not a good Basketball!', '2024-03-10');
--INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (5,5, 5 , 1, 'Poor Board Game!', '2024-03-05');
--INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (6,6, 6 , 5, 'Best Coffee!', '2024-03-01');
--INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (7,7, 7 , 4, 'Good Pen!', '2024-02-25');
--INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (8,8, 8 , 3, 'Average Game!', '2024-02-20');
--INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (9,9, 9 , 2, 'Not a good Novel!', '2024-02-15');
--INSERT INTO Reviews (review_id,product_id, customer_id, rating, review_text, review_date) VALUES (10,10, 10 , 1, 'Poor Pizza!', '2024-02-10');


--INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (1, 'Spring Sale', '20% off all clothing', '2024-04-01', '2024-04-30', 'percentage', 0.20);
--INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (2, 'Summer Sale', '10% off all electronics', '2024-06-01', '2024-06-30', 'percentage', 0.10);
--INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (3, 'Winter Sale', '30% off all beauty products', '2024-12-01', '2024-12-31', 'percentage', 0.30);
--INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (4, 'Back to School Sale', '15% off all stationary', '2024-08-01', '2024-08-31', 'percentage', 0.15);
--INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (5, 'Holiday Sale', '25% off all games', '2024-11-01', '2024-11-30', 'percentage', 0.25);
--INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (6, 'New Year Sale', '50% off all books', '2024-01-01', '2024-01-31', 'percentage', 0.50);
--INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (7, 'Valentine Sale', '5% off all food items', '2024-02-01', '2024-02-14', 'percentage', 0.05);
--INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (8, 'Eid Sale', '40% off all sports items', '2024-05-01', '2024-05-31', 'percentage', 0.40);
--INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (9, 'Independence Day Sale', '10% off all indoor items', '2024-08-14', '2024-08-14', 'percentage', 0.10);
--INSERT INTO Promotions (promotion_id, name, description, start_date, end_date, discount_type, discount_value) VALUES (10, 'Black Friday Sale', '75% off all drinks', '2024-11-29', '2024-11-29', 'percentage', 0.75);


--INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (1, 1, 1);
--INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (2, 2, 2);
--INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (3, 3, 3);
--INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (4, 4, 4);
--INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (5, 5, 5);
--INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (6, 6, 6);
--INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (7, 7, 7);
--INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (8, 8, 8);
--INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (9, 9, 9);
--INSERT INTO Product_Promotions (product_promotion_id, product_id, promotion_id) VALUES (10, 10, 10);

--INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (1, 1, '2024-03-25');
--INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (2, 2, '2024-03-20');
--INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (3, 3, '2024-03-15');
--INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (4, 4, '2024-03-10');
--INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (5, 5, '2024-03-05');
--INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (6, 6, '2024-03-01');
--INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (7, 7, '2024-02-25');
--INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (8, 8, '2024-02-20');
--INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (9, 9, '2024-02-15');
--INSERT INTO Carts (cart_id, customer_id, creation_date) VALUES (10, 10, '2024-02-10');

--INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (1, 1, 1, 2);
--INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (2, 2, 2, 1);
--INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (3, 3, 3, 3);
--INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (4, 4, 4, 1);
--INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (5, 5, 5, 2);
--INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (6, 6, 6, 5);
--INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (7, 7, 7, 1);
--INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (8, 8, 8, 2);
--INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (9, 9, 9, 3);
--INSERT INTO Cart_Items (cart_item_id, cart_id, product_id, quantity) VALUES (10, 10, 10, 1);

--INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (1, 1, '2024-03-25', 'Shipped');
--INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (2, 2, '2024-03-20', 'Delivered');
--INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (3, 3, '2024-03-15', 'Processing');
--INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (4, 4, '2024-03-10', 'Cancelled');
--INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (5, 5, '2024-03-05', 'Shipped');
--INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (6, 6, '2024-03-01', 'Delivered');
--INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (7, 7, '2024-02-25', 'Processing');
--INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (8, 8, '2024-02-20', 'Cancelled');
--INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (9, 9, '2024-02-15', 'Shipped');
--INSERT INTO Orders (order_id, customer_id, order_date, order_status) VALUES (10, 10, '2024-02-10', 'Delivered');

--INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (1, 1, 1, 2);
--INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (2, 2, 2, 11);
--INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (3, 3, 3, 15);
--INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (4, 4, 4, 4);
--INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (5, 5, 5, 9);
--INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (6, 6, 6, 17);
--INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (7, 7, 7, 6);
--INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (8, 8, 8, 5);
--INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (9, 9, 9, 3);
--INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity) VALUES (10, 10, 10, 1);