-- Query 1
SELECT * FROM Products;

-- Query 3
SELECT * FROM Products WHERE price > 1000;

-- Query 5
SELECT * FROM Products ORDER BY price DESC;

-- Query 7
SELECT * FROM Products WHERE name LIKE 'P%';

-- Query 9
SELECT * FROM Products ORDER BY name ASC;

-- Query 11
SELECT * FROM Products WHERE price <= 3000 AND category_id = 2;

-- Query 13
SELECT * FROM Products WHERE name LIKE 'M%' AND price > 5000;

-- Query 15
SELECT * FROM Products ORDER BY stock_level DESC;

-- Query 17
SELECT AVG(price*1.0) FROM Products;
SELECT * FROM Products WHERE price > (SELECT AVG(price) FROM Products);

-- Query 19
SELECT * FROM Products WHERE category_id IN (1, 3, 4);

-- Query 21
SELECT COUNT(*) AS total_products FROM Products;

-- Query 23
SELECT MAX(price) AS max_price FROM Products;

-- Query 25
SELECT SUM(stock_level) AS total_stock_levels_of_all_products FROM Products;

-- Query 27
SELECT category_id, COUNT(*) AS total_products FROM Products GROUP BY category_id;

-- Query 29
SELECT * FROM Products WHERE price = (SELECT MAX(price) FROM Products);

-- Query 31
SELECT category_id, AVG(price*1.0) AS average_price FROM Products GROUP BY category_id;

-- Query 33
SELECT COUNT(*) AS total_products_in_stock FROM Products WHERE stock_level > 0;

-- Query 35
SELECT TOP 1 category_id, COUNT(*) AS total_products FROM Products GROUP BY category_id ORDER BY total_products DESC;

-- Query 37
SELECT * FROM Products WHERE stock_level = (SELECT MAX(stock_level) FROM Products);

-- Query 39
SELECT COUNT(*) AS total_products_greater_than_5000 FROM Products WHERE price > 5000;

-- Query 41
SELECT COUNT(*) AS total_orders FROM Orders;

-- Query 43
SELECT TOP 1 customer_id, COUNT(*) AS total_orders FROM Orders GROUP BY customer_id ORDER BY total_orders DESC;

-- Query 45
SELECT category_id, SUM(price * quantity) AS total_revenue FROM Order_Items JOIN Products ON Order_Items.product_id = Products.product_id GROUP BY category_id;
SELECT p.category_id, SUM(p.price * oi.quantity) AS total_revenue FROM Order_Items oi JOIN Products p ON oi.product_id = p.product_id GROUP BY p.category_id;

-- Query 47
SELECT 
    pr.promotion_id,
    pr.name AS promotion_name,
    SUM((p.price * (pr.discount_value))) AS total_discounted_value,
	    SUM((p.price - (p.price * pr.discount_value))) AS new_discounted_price
FROM 
    Promotions pr
INNER JOIN 
    Product_Promotions pp ON pr.promotion_id = pp.promotion_id
INNER JOIN 
    Products p ON pp.product_id = p.product_id
GROUP BY 
    pr.promotion_id, pr.name;

-- Query 49
SELECT order_id, SUM(quantity) AS total_items FROM Order_Items GROUP BY order_id;

-- Query 51
SELECT customer_id, COUNT(*) AS total_reviews FROM Reviews GROUP BY customer_id;

-- Query 53
SELECT TOP 1 category_id, AVG(price) AS average_price FROM Products GROUP BY category_id ORDER BY average_price DESC;

-- Query 55
SELECT 
    o.customer_id,
    c.first_name,
    c.last_name,
    SUM(oi.quantity * p.price) AS total_revenue
FROM 
    Orders o
INNER JOIN 
    Order_Items oi ON o.order_id = oi.order_id
INNER JOIN 
    Products p ON oi.product_id = p.product_id
INNER JOIN 
    Customers c ON o.customer_id = c.customer_id
GROUP BY 
    o.customer_id, c.first_name, c.last_name;

-- Query 57
SELECT TOP 1 product_id, AVG(rating) AS average_rating FROM Reviews GROUP BY product_id ORDER BY average_rating DESC;

-- Query 59
SELECT TOP 1 
    o.customer_id,
    c.first_name,
    c.last_name,
    SUM(oi.quantity * p.price) AS total_order_value
FROM 
    Orders o
INNER JOIN 
    Order_Items oi ON o.order_id = oi.order_id
INNER JOIN 
    Products p ON oi.product_id = p.product_id
INNER JOIN 
    Customers c ON o.customer_id = c.customer_id
GROUP BY 
    o.customer_id, c.first_name, c.last_name
ORDER BY 
    total_order_value DESC;

-- Query 61
SELECT category_id, COUNT(*) AS total_products FROM Products GROUP BY category_id;

-- Query 63
SELECT TOP 1 category_id, SUM(price * stock_level) AS total_value FROM Products GROUP BY category_id ORDER BY total_value DESC;

-- Query 65
SELECT customer_id, COUNT(*) AS total_orders FROM Orders GROUP BY customer_id;

-- Query 67
SELECT 
    c.city,
    SUM(p.stock_level) AS total_products_in_stock
FROM 
    Customers c
JOIN 
    Carts ct ON c.customer_id = ct.customer_id
JOIN 
    Cart_Items ci ON ct.cart_id = ci.cart_id
JOIN 
    Products p ON ci.product_id = p.product_id
GROUP BY 
    c.city;

-- Query 69
SELECT TOP 1 category_id, AVG(price) AS average_price FROM Products GROUP BY category_id ORDER BY average_price DESC;

-- Query 71
SELECT
    c.customer_id,
    c.first_name,
	c.last_name,
    COUNT(oi.product_id) AS total_products_purchased
FROM
    Customers c
LEFT JOIN
    Orders o ON c.customer_id = o.customer_id
LEFT JOIN
    Order_Items oi ON o.order_id = oi.order_id
GROUP BY
    c.customer_id, c.first_name, c.last_name
ORDER BY
    total_products_purchased DESC;

-- Query 73
SELECT TOP 1 category_id, COUNT(*) AS total_products FROM Products GROUP BY category_id ORDER BY total_products DESC;

-- Query 75
SELECT TOP 1 product_id, SUM(quantity) AS total_orders FROM Order_Items GROUP BY product_id ORDER BY total_orders DESC;

-- Query 77
SELECT TOP 1
    c.customer_id,
	c.first_name,
	c.last_name,
    AVG(oi.quantity * p.price) AS avg_order_value
FROM
    Customers c
LEFT JOIN
    Orders o ON c.customer_id = o.customer_id
LEFT JOIN
    Order_Items oi ON o.order_id = oi.order_id
LEFT JOIN
    Products p ON oi.product_id = p.product_id
GROUP BY
    c.customer_id, c.first_name, c.last_name
ORDER BY
    avg_order_value DESC;

-- Query 79
SELECT TOP 1 
    c.customer_id,
    c.first_name,
	c.last_name,
    AVG(oi.quantity) AS avg_quantity_per_order
FROM
    Customers c
LEFT JOIN
    Orders o ON c.customer_id = o.customer_id
LEFT JOIN
    Order_Items oi ON o.order_id = oi.order_id
GROUP BY
    c.customer_id, c.first_name, c.last_name
ORDER BY
    avg_quantity_per_order DESC;

