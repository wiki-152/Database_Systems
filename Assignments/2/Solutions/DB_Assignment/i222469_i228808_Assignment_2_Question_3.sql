-- Odd Queries

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


	-- Even Queries

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
SELECT AVG(order_total) AS average_order_total
FROM (
    SELECT o.order_id, SUM(p.price * oi.quantity) AS order_total
    FROM Orders o
    JOIN Order_Items oi ON o.order_id = oi.order_id
    JOIN Products p ON oi.product_id = p.product_id
    GROUP BY o.order_id
) AS order_totals;


-- Query 44
SELECT product_id, COUNT(*) AS total_reviews FROM Reviews GROUP BY product_id;

-- Query 46
SELECT c.customer_id, 
       AVG(p.price) AS average_price
FROM Customers c
JOIN Orders o ON c.customer_id = o.customer_id
JOIN Order_Items oi ON o.order_id = oi.order_id
JOIN Products p ON oi.product_id = p.product_id
GROUP BY c.customer_id;


-- Query 48
SELECT customer_id, COUNT(*) AS total_carts FROM Carts GROUP BY customer_id;

-- Query 50
SELECT TOP 1 c.customer_id, 
       SUM(p.price * oi.quantity) AS total_spending
FROM Customers c
JOIN Orders o ON c.customer_id = o.customer_id
JOIN Order_Items oi ON o.order_id = oi.order_id
JOIN Products p ON oi.product_id = p.product_id
GROUP BY c.customer_id
ORDER BY total_spending DESC;


-- Query 52
SELECT customer_id, 
       AVG(order_total) AS average_order_total
FROM (
    SELECT o.customer_id, SUM(p.price * oi.quantity) AS order_total
    FROM Orders o
    JOIN Order_Items oi ON o.order_id = oi.order_id
    JOIN Products p ON oi.product_id = p.product_id
    GROUP BY o.order_id, o.customer_id
) AS customer_orders
GROUP BY customer_id;



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
SELECT o.customer_id,
       SUM(p.price * oi.quantity) AS total_value_purchased
FROM Orders o
JOIN Order_Items oi ON o.order_id = oi.order_id
JOIN Products p ON oi.product_id = p.product_id
GROUP BY o.customer_id;

-- Query 62
SELECT category_id, AVG(price*1.0) AS average_price FROM Products GROUP BY category_id;

-- Query 64
SELECT category_id, AVG(stock_level) AS average_stock_level
FROM
    Products
GROUP BY
    category_id
HAVING
    COUNT(*) > 10;


-- Query 66
SELECT customer_id, 
       AVG(order_total) AS average_order_value
FROM (
    SELECT o.customer_id, SUM(p.price * oi.quantity) AS order_total
    FROM Orders o
    JOIN Order_Items oi ON o.order_id = oi.order_id
    JOIN Products p ON oi.product_id = p.product_id
    GROUP BY o.order_id, o.customer_id
) AS customer_orders
GROUP BY customer_id;



-- Query 68
SELECT 
    customer_id,
    total_order_value
FROM (
    SELECT 
        o.customer_id,
        SUM(p.price * oi.quantity) AS total_order_value
    FROM 
        Orders o 
    JOIN 
        Order_Items oi ON o.order_id = oi.order_id
    JOIN 
        Products p ON p.product_id = oi.product_id
    GROUP BY 
        o.customer_id
) AS customer_orders
WHERE 
    total_order_value = (
        SELECT MAX(total_order_value) 
        FROM (
            SELECT 
                SUM(p.price * oi.quantity) AS total_order_value
            FROM 
                Orders o 
            JOIN 
                Order_Items oi ON o.order_id = oi.order_id
            JOIN 
                Products p ON p.product_id = oi.product_id
            GROUP BY 
                o.customer_id
        ) AS max_order_value
    );


-- Query 70
SELECT TOP 1 product_id, AVG(rating) AS average_rating FROM Reviews GROUP BY product_id ORDER BY average_rating DESC;

-- Query 72
SELECT category_id, AVG(rating*1.0) AS average_rating FROM Reviews JOIN Products ON Reviews.product_id = Products.product_id GROUP BY category_id;

-- Query 74
SELECT 
    o.customer_id,
    SUM(p.price * oi.quantity) AS Highest_Total_Value
FROM 
    Orders o 
JOIN 
    Order_Items oi ON o.order_id = oi.order_id
JOIN 
    Products p ON oi.product_id = p.product_id
GROUP BY 
    o.customer_id
HAVING 
    SUM(p.price * oi.quantity) = (
        SELECT 
            MAX(total_order_value)
        FROM (
            SELECT 
                SUM(p.price * oi.quantity) AS total_order_value
            FROM 
                Orders o 
            JOIN 
                Order_Items oi ON o.order_id = oi.order_id
            JOIN 
                Products p ON oi.product_id = p.product_id
            GROUP BY 
                o.customer_id
        ) AS max_orders
    );

-- Query 76
SELECT TOP 1
    c.name AS category_name,
    SUM(p.price * oi.quantity) AS total_order_value
FROM 
    Order_Items oi 
JOIN 
    Products p ON oi.product_id = p.product_id
JOIN 
    Categories c ON p.category_id = c.category_id
GROUP BY 
    c.name
ORDER BY 
    total_order_value DESC;


-- Query 78
SELECT 
    p.name AS product_name,
    SUM(oi.quantity) AS total_order_quantity
FROM 
    Order_Items oi 
JOIN 
    Products p ON oi.product_id = p.product_id
GROUP BY 
    p.name
HAVING 
    SUM(oi.quantity) = (
        SELECT 
            MAX(total_quantity)
        FROM (
            SELECT 
                SUM(quantity) AS total_quantity 
            FROM 
                Order_Items 
            GROUP BY 
                product_id
        ) AS SubQuery
    );

-- Query 80
SELECT
    c.name AS category_name,
    AVG(p.stock_level) AS average_stock_level
FROM
    Products p
JOIN
    Categories c ON p.category_id = c.category_id
GROUP BY
    c.name
HAVING
    AVG(p.stock_level) = (
        SELECT
            MAX(avg_stock_level)
        FROM
            (SELECT
                AVG(stock_level) AS avg_stock_level
            FROM
                Products
            GROUP BY
                category_id) AS subquery
    );
