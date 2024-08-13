-- Query 2
SELECT name, price FROM Products;

-- Query 4
SELECT * FROM Products WHERE stock_level <= 50;

-- Query 6
SELECT * FROM Products WHERE price BETWEEN 1000 AND 5000;
SELECT * FROM Products WHERE price >= 1000 AND price <= 5000;

-- Query 8
SELECT * FROM Products WHERE name LIKE '%Shoes%';

-- Query 10
SELECT DISTINCT category_id FROM Products;

-- Query 12
SELECT * FROM Products WHERE stock_level >= 10 AND stock_level <= 20;
SELECT * FROM Products WHERE stock_level BETWEEN 10 AND 20;

-- Query 14
SELECT * FROM Products 
WHERE description LIKE '%embroidered%' AND price < 3000;

-- Query 16
SELECT * FROM Products WHERE name NOT LIKE 'L%';

-- Query 18
SELECT * FROM Products 
WHERE stock_level < (SELECT MIN(stock_level) FROM Products);

-- Query 20
SELECT * FROM Products WHERE name LIKE '%Suit';

-- Query 22
SELECT AVG(price) AS average_price_of_all_products FROM Products;

-- Query 24
SELECT MIN(stock_level) AS min_stock_level FROM Products;

-- Query 26
SELECT (AVG(stock_level*1.0)) AS average_stock_level FROM Products;

-- Query 28
SELECT SUM(price * stock_level*1.0) AS total_value FROM Products;

-- Query 30
SELECT SUM(LEN(name)) AS total_characters FROM Products;

-- Query 32
SELECT * FROM Products 
WHERE stock_level = (SELECT MIN(stock_level) FROM Products);

-- Query 34
SELECT SUM(price*1.0) AS total_price_of_all_products FROM Products;

-- Query 36
SELECT (MAX(price) - MIN(price)) AS price_difference_max_min FROM Products;

-- Query 38
SELECT TOP 1 category_id, AVG(price) AS average_price 
FROM Products 
GROUP BY category_id 
ORDER BY average_price DESC;

-- Query 40
SELECT category_id, SUM(price * stock_level) AS total_value
FROM Products 
GROUP BY category_id;

-- Query 42
SELECT AVG(price * quantity) AS average_order_total FROM Order_Items;

-- Query 44
SELECT product_id, COUNT(*) AS total_reviews FROM Reviews GROUP BY product_id;

-- Query 46
SELECT customer_id, AVG(price) AS average_price FROM Order_Items JOIN Products ON Order_Items.product_id = Products.product_id GROUP BY customer_id;

-- Query 48
SELECT customer_id, COUNT(*) AS total_carts FROM Carts GROUP BY customer_id;

-- Query 50
SELECT customer_id, SUM(price * quantity) AS total_spending FROM Order_Items GROUP BY customer_id ORDER BY total_spending DESC LIMIT 1;

-- Query 52
SELECT customer_id, AVG(price * quantity) AS average_order_total FROM Order_Items GROUP BY customer_id;

-- Query 54
SELECT MONTH(order_date) AS month_num, COUNT(*) AS total_orders 
FROM Orders 
GROUP BY MONTH(order_date);

-- Query 56
SELECT category_id, COUNT(*) AS total_reviews FROM Reviews JOIN Products ON Reviews.product_id = Products.product_id GROUP BY category_id;

-- Query 58
SELECT YEAR(order_date) AS year_num, COUNT(*) AS total_orders 
FROM Orders 
GROUP BY YEAR(order_date);


-- Query 60
SELECT o.customer_id,SUM(p.price * oi.quantity) AS total_value
FROM Orders o
JOIN Order_Items oi ON o.order_id = oi.order_id
JOIN Products p ON oi.product_id = p.product_id
GROUP BY o.customer_id;

-- Query 62
SELECT category_id, AVG(price*1.0) AS average_price FROM Products GROUP BY category_id;

-- Query 64
SELECT category_id, AVG(stock_level) AS average_stock_level 
FROM Products 
GROUP BY category_id HAVING COUNT(*) > 10;
SELECT
    c.category_id,
    AVG(p.stock_level) AS average_stock_level
FROM
    Categories c
JOIN
    Products p ON c.category_id = p.category_id
GROUP BY
    c.category_id
HAVING
    COUNT(p.product_id) > 10;


-- Query 66
SELECT 
    customer_id, 
    AVG(price * quantity) AS average_order_value 
FROM 
    Order_Items 
GROUP BY 
    customer_id;


-- Query 68
SELECT TOP 1 customer_id, SUM(price * quantity) AS total_order_value FROM Order_Items GROUP BY customer_id ORDER BY total_order_value DESC;
SELECT top 1
    customer_id, 
    SUM(price * quantity) AS total_order_value 
FROM 
    Order_Items 
GROUP BY 
    customer_id 
ORDER BY 
    total_order_value DESC;

-- Query 70
SELECT TOP 1 product_id, AVG(rating) AS average_rating FROM Reviews GROUP BY product_id ORDER BY average_rating DESC;

-- Query 72
SELECT category_id, AVG(rating*1.0) AS average_rating FROM Reviews JOIN Products ON Reviews.product_id = Products.product_id GROUP BY category_id;

-- Query 74
SELECT TOP 1 customer_id, SUM(price * quantity) AS total_order_value FROM Order_Items GROUP BY customer_id ORDER BY total_order_value DESC;

-- Query 76
SELECT TOP 1 category_id, SUM(price * quantity) AS total_order_value 
FROM Order_Items JOIN Products ON Order_Items.product_id = Products.product_id GROUP BY category_id ORDER BY total_order_value DESC;

-- Query 78
SELECT TOP 1 product_id, SUM(quantity) AS total_order_quantity FROM Order_Items GROUP BY product_id ORDER BY total_order_quantity DESC;

-- Query 80
SELECT TOP 1 category_id, AVG(stock_level) AS average_stock_level FROM Products GROUP BY category_id ORDER BY average_stock_level DESC;
