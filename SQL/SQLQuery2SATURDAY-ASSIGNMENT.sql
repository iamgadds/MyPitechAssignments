-- table customers

SP_HELP CUSTOMERS

-- 1 Display the “Company Name” and “Contact Name” from Customers table 
SELECT COMPANYNAME, CONTACTNAME FROM Customers

--2 Find the Customers who are staying wither in USA, UK, Germany, France
SELECT * from Customers WHERE COUNTRY IN ('USA','UK','GERMANY','FRANCE')

--3Find the Customers whose “Company Name” starts with G 
SELECT * FROM CUSTOMERS WHERE CompanyName LIKE 'G%'

--4 List all the Customers who are located in Paris 
SELECT * FROM CUSTOMERS WHERE City = 'PARIS'

--5 List the Customer details whose postal code start with 4 
SELECT * FROM CUSTOMERS WHERE PostalCode LIKE '4%'

--6 List all the Customers who neither stay in Canada nor in Brazil
SELECT * FROM Customers WHERE Country NOT IN ('CANADA','BRAZIL')

--7 Print total number of Customers for each country. 
SELECT Country ,COUNT(CustomerID) FROM Customers GROUP BY Country

--8 List Customers detail based on Country and City 
SELECT ContactName, COUNTRY, City FROM Customers ORDER BY COUNTRY, CITY

--9 List all the manager from the Customers table 
SELECT * FROM Customers WHERE ContactTitle LIKE '%MANAGER%'

--10 List all Customers details where “company name” contains aphostophy (‘) 
SELECT * FROM Customers WHERE CompanyName like '%' + char(39) + '%';

--Products 
--11. List all the products for CategoryID 4 and UnitsInStock is more then 50 
select * from products WHERE CATEGORYID = 4 AND UnitsInStock >= 50

--12. List ProductName, UnitPrice, UnitsInStock, NetStock (i.e. UnitPrice * UnitsInStock) 
SELECT PRODUCTNAME, UnitPrice, UnitsInStock, UnitPrice*UnitsInStock AS NETSTOCK FROM PRODUCTS

--13. List Maximum and Minimum UnitPrice 
SELECT MAX(UNITPRICE), MIN(UNITPRICE) FROM PRODUCTS

--14 Count the number of products whose UnitPrice is more then 50 
SELECT COUNT(PRODUCTID) AS COUNT FROM Products WHERE UnitPrice >=50 
--15. List product count base on CategoryID. List the data where count is more then 10 
SELECT CategoryID ,COUNT(CATEGORYID) AS CATEGORYCOUNT FROM Products GROUP BY CategoryID HAVING COUNT(CATEGORYID)>10
--16. Find all the products where UnitsInStock in less than Reorder Level 
SELECT * FROM Products WHERE UnitsInStock<ReorderLevel
--17. List Category wise, Supplier wise product count 
SELECT CategoryID,SupplierID,COUNT(PRODUCTID) AS COUNT FROM Products GROUP BY CategoryID, SupplierID
--18. All Products whose UnitsInStock is less than 5 units are entitles for placing order by 50 units 
--for  others place the order by 30 units. Display ProductID, ProductName, UnitsInStock,  OrderedUnits. 
SELECT PRODUCTID, ProductName, UnitsInStock, CASE
	WHEN UnitsInStock < 5 THEN 50
	ELSE 30
	END AS ORDEREDUNITS 
 FROM PRODUCTS

--19. List 3 costliest product 
SELECT TOP 3 * FROM PRODUCTS ORDER BY UnitPrice DESC

--20. List all the products whose CategoryID is 1 and SupplierID is either 10 or 12 or CategoryID is 4  
--and SupplierID is either 14 or 15. 
 SELECT * FROM Products WHERE (CategoryID = 1 AND SupplierID IN (10,12)) OR (CategoryID=4 AND SupplierID IN (14,15))

 -- ORDERS
 --21. List all the orders placed in month of February 
 SELECT * FROM Orders WHERE MONTH(ORDERDATE) = 2 
--22. List year wise order count 
SELECT DATEPART(YY, ORDERDATE) AS DATE,COUNT(ORDERID) AS COUNT FROM ORDERS GROUP BY DATEPART(YY, ORDERDATE)
--23. List the ShipCountry for which total order placed is more than 100 
SELECT COUNT(OrderID) AS ORDERS, ShipCountry FROM ORDERS GROUP BY ShipCountry HAVING COUNT(OrderID) >= 100
--Example 
--ShipCountry OrderCount 
--USA 122 

--24. List the data as per the order month (Jan – Dec) 
SELECT * FROM ORDERS ORDER BY MONTH(ORDERDATE)
--25. List unique country name in ascending order where product is shipped 
SELECT DISTINCT SHIPCOUNTRY  FROM Orders ORDER BY ShipCountry
--26. List CustomerID, ShipCity, ShipCountry, ShipRegion from Ordrs table. If ShipRegion is null 
--than  display message as “No Region”
SELECT CustomerID, SHIPCITY, ShipCountry , ISNULL(SHIPREGION, 'NO REGION') AS SHIPREGION FROM Orders
--27. List the detail of first order placed 
SELECT TOP 1* FROM ORDERS ORDER BY OrderDate
--28. List Customer wise, Year wise (Order date) order placed 
--Example 
--CustomerID Year OrderCount 
--ANATR 1996 1 
--BONAP 1997 8 
 SELECT CUSTOMERID, DATEPART(YY, ORDERDATE) AS ORDERDATE, COUNT(CUSTOMERID) AS COUNT FROM Orders GROUP BY CustomerID, DATEPART(YY, ORDERDATE)

--29. List all the orders handled by employeeid 4 for the month of December 
SELECT * FROM ORDERS WHERE EmployeeID = 4 AND MONTH(ORDERDATE) = 12
--30. List employee wise , year wise, month wise ordercount 
SELECT EMPLOYEEID,DATEPART(YY,OrderDate) AS YEARWISE, DATEPART(MM, OrderDate) AS MONTHWISE, COUNT(EmployeeID) AS COUNT FROM ORDERS 
GROUP BY EMPLOYEEID,DATEPART(YY,OrderDate), DATEPART(MM, OrderDate)

--Table: [Order Details] 
--31. List all the data of [Order Details] table 
select * from [Order Details]
--32. List ProductID, UnitPrice, Qty and Total. Sort data on Total column with highest value on top 
SELECT ProductID, UnitPrice, Quantity, Quantity*UnitPrice AS TOTAL FROM [Order Details] ORDER BY TOTAL DESC
--33. In above query,  
--If Total is more than 10000 display 10% discount on Total cost 
--If Total is more than 5000 display 5% discount on Total cost 
--If Total is more than 3000 display 2% discount on Total cost 
--else Rs. 300 as discount if total is more than 1000 
--No discount for Total less than 1000 
SELECT ProductID, UnitPrice, Quantity, Quantity*UnitPrice AS TOTAL, CASE
	WHEN Quantity*UnitPrice > 10000 THEN 0.1*Quantity*UnitPrice
	WHEN Quantity*UnitPrice > 5000 THEN 0.5*Quantity*UnitPrice
	WHEN Quantity*UnitPrice > 3000 THEN 0.2*Quantity*UnitPrice
	WHEN Quantity*UnitPrice > 1000 THEN 300
	ELSE 0
END AS DISCOUNT
FROM [Order Details] ORDER BY TOTAL DESC
--34. List Total order placed for each OrderId 
SELECT ORDERID,SUM(QUANTITY) AS [TOTAL ORDER] FROM [Order Details] GROUP BY OrderID
--35. List minimum cost and maximum cost order value
SELECT MIN(UNITPRICE * Quantity) AS MIN, MAX(UNITPRICE * Quantity) AS MAX FROM [Order Details]