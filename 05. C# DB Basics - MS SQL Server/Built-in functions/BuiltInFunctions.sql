SELECT N'Пешо' --nvarchar

USE Demo
GO
CREATE VIEW v_PublicPaymentsInfo AS
SELECT
	CustomerID,
	FirstName,
	LastName,
	CONCAT(LEFT(PaymentNumber, 6), REPLICATE('*', LEN(PaymentNumber) - 6)) AS PaymentNumber
FROM Customers

GO
SELECT * FROM v_PublicPaymentsInfo

SELECT LOWER ('BULGARIA')

SELECT REVERSE ('Pesho')

SELECT CHARINDEX ('is', 'This is a long text')

SELECT STUFF('This is a bad idea', 11, 0, 'very ')

SELECT FORMAT(67.23, 'C', 'bg-BG')

SELECT FORMAT(0.27, 'P', 'bg-BG')

SELECT FORMAT(CAST('2021-12-10' AS date), 'D', 'bg-BG')

SELECT TRANSLATE(N'проба', N'абвгдежзиклмнопрстуфхц', 'abvgdejziklmnoprstufhc')

SELECT IIF(LEN(LastName) < 6, LastName, 'Too long') FROM Customers

SELECT PI()

SELECT ABS(SQUARE(12) * - 1)

SELECT Id, X1, Y1, X2, Y2,
		SQRT(SQUARE(X1-X2) + SQUARE(Y1-Y2))
	AS Length
FROM Lines

SELECT ROUND (18.567, 2)

SELECT FLOOR(1.99)

SELECT CEILING(1.1)

SELECT [Name],CEILING(CEILING(CAST(Quantity AS float) / BoxCapacity) / PalletCapacity) AS Pallets FROM Products

SELECT SIGN(-365)

SELECT RAND()

SELECT DATEPART(DAY, '2021-10-13')

USE SoftUni
SELECT * FROM Projects WHERE DATEPART(QUARTER, StartDate) = 3

USE Orders

SELECT 
	ProductName,
	YEAR(OrderDate) AS [Year],
	MONTH(OrderDate) AS [Month],
	DAY(OrderDate) AS [Day],
	DATEPART(QUARTER, OrderDate) AS [Quarter]
FROM Orders

SELECT 
	DATEDIFF(SECOND, '2021-10-13T17:32:55', '2021-10-13T17:32:45')

USE SoftUni

SELECT 
	CONCAT_WS(', ', LastName, FirstName) AS Employee,
	DATEDIFF(year, HireDate, GETDATE()) AS YearsOfService
FROM Employees

SELECT DATENAME (WEEKDAY, GETDATE())

SELECT HireDate, DATEADD(DAY, 5, HireDate) AS Exp 
FROM Employees

SELECT EOMONTH(GETDATE(), 1)

SELECT CONVERT(date, '01/01/2021')

SELECT [Name], 
	ISNULL(CAST(EndDate AS varchar), 'Not Finished') 
FROM Projects

SELECT [Name], 
	COALESCE(CAST(EndDate AS varchar), 'Not Finished') 
FROM Projects

SELECT COALESCE(NULL, NULL, 'FirstValue', NULL, 'SecondValue')

SELECT EmployeeID, FirstName, LastName
	FROM Employees
ORDER BY EmployeeID
	OFFSET 10 ROWS
	FETCH NEXT 5 ROWS ONLY

SELECT EmployeeID, FirstName, LastName, ROW_NUMBER() OVER (ORDER BY FirstName)
FROM Employees

SELECT EmployeeID, FirstName, LastName, RANK() OVER (ORDER BY FirstName)
FROM Employees

SELECT EmployeeID, FirstName, LastName, DENSE_RANK() OVER (ORDER BY FirstName)
FROM Employees

SELECT EmployeeID, FirstName, LastName
FROM Employees
WHERE FirstName LIKE 'Ro%'


SELECT EmployeeID, FirstName, LastName
FROM Employees
WHERE FirstName LIKE '%nn%'

SELECT EmployeeID, FirstName, LastName
FROM Employees
WHERE FirstName LIKE 'And[yr]%'
ORDER BY FirstName