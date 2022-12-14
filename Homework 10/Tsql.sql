-- 1
SELECT contactname, city, orderDate 
FROM sales.customers AS c
JOIN Sales.Orders AS s ON s.custId = c.custId
WHERE city IN ('London', 'Madrid')

-- 2
SELECT UPPER(productname) AS productname, categoryname, unitprice
FROM Production.Products AS P
JOIN Production.Categories AS C 
ON P.categoryid = C.categoryid
where unitprice between 20 and 40

-- 3
SELECT firstname, lastname, orderid, freight
FROM HR.employees AS E
JOIN Sales.Orders AS S on E.empid = S.empid
WHERE freight > 50 and title = 'Sales Manager'

-- 4
SELECT contactname, orderdate, shipcity, shipaddress 
FROM Sales.orders AS O
JOIN Sales.customers AS C on O.custid = C.custid
WHERE year(orderdate) = '2007' and country = 'USA'

-- 5
SELECT DISTINCT c.city FROM Sales.Orders AS O
JOIN HR.Employees AS E ON E.empid = O.empid
JOIN Sales.Customers AS C ON O.custid = C.custid
WHERE lastname = 'Cameron'

-- 6
SELECT orderid, country, city FROM Sales.Orders AS O
JOIN Sales.Customers AS c ON o.custid = c.custid
WHERE country IN ('Germany', 'Austria')

-- 7
SELECT * FROM Production.Products AS P
JOIN Production.Suppliers AS S ON P.supplierId = S.supplierid
WHERE city = 'Tokyo' AND discontinued = 1

-- 8
SELECT categoryname, productName FROM Production.Products AS P
JOIN Production.Suppliers AS S ON P.supplierId = S.supplierId
JOIN Production.Categories AS C ON P.CategoryId = C.categoryId
WHERE country = 'Japan' AND categoryName IN ('Seafood', 'Beverages')

-- 9 
SELECT firstname, lastname, CompanyName FROM Sales.Orders AS O
JOIN HR.Employees AS E ON O.empid = E.empId
JOIN Sales.Shippers AS S ON O.shipperid = S.shipperid
WHERE orderdate = '2007' AND concat(firstname, ' ', lastname) IN ('Sara Davis', 'Maria Cameron')


-- 10
SELECT productName, categoryName FROM Production.Products AS p
JOIN Production.Suppliers AS s ON p.supplierId = s.supplierId
JOIN Production.Categories AS c ON p.CategoryId = c.categoryID
WHERE categoryName NOT IN ('Seafood', 'Beverages')

-- 11
SELECT orderId, firstname, lastname, e.City, c.city, contactname 
FROM Sales.Orders AS o
JOIN HR.Employees AS e ON o.empId = e.empId
JOIN Sales.Customers AS c ON o.custId = c.custid
WHERE c.city = e.city

-- 12
SELECT DISTINCT ContactName FROM Sales.Orders AS o
JOIN Sales.Customers AS cu ON o.custid = cu.custid
JOIN Sales.OrderDetails AS ord ON o.orderId = ord.OrderId
JOIN Production.Products AS p ON ord.ProductId = p.ProductId
JOIN Production.Categories AS ca ON p.categoryid = ca.categoryid
WHERE ca.categoryName IN ('Beverages', 'Dairy Products')