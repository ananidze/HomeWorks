select * from Products
select * from Manufacturers

-- 1
SELECT name, price FROM products 
WHERE manufacturerid 
    IN (
        SELECT manufacturerid 
        FROM manufacturers 
        WHERE name = 'Hewlett-Packard'
       )

-- 2
SELECT UPPER(name), price FROM products 
WHERE manufacturerid 
    IN 
	( 
        SELECT manufacturerid FROM manufacturers 
		WHERE name != 'Fujitsu'
	)

-- 3
SELECT name, price FROM products 
WHERE manufacturerid IN 
	(
		SELECT manufacturerid 
		FROM manufacturers 
		WHERE name IN  ( 'Fujitsu', 'IBM', 'Intel')
	)

-- 4
SELECT name FROM manufacturers 
WHERE manufacturerid IN 
	(
		SELECT manufacturerid 
		FROM products 
		WHERE price > 200
	)

-- 5
SELECT name, price FROM products 
WHERE manufacturerid IN 
	(
		SELECT manufacturerid 
		FROM manufacturers 
		WHERE name NOT IN ( 'Genius', 'Dell')
	)

-- 6
SELECT COUNT(name) FROM manufacturers 
WHERE manufacturerid IN 
	(
		SELECT manufacturerid 
		FROM products 
		WHERE name LIKE '%drive%'
	)

-- 7
SELECT COUNT(name) FROM products 
WHERE manufacturerid IN 
	(
		SELECT manufacturerid 
		FROM manufacturers 
		WHERE name = 'Intel' AND price > 
        (
            SELECT AVG(price)FROM products
        )
	)
