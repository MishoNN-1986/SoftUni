USE SoftUni

-- Inner Join
SELECT * FROM Employees AS e        -- left table
	INNER JOIN Departments AS d     -- right table
	ON e.DepartmentID = d.DepartmentID

-- Left Join
SELECT * FROM Employees AS e       
	LEFT JOIN Departments AS d     
	ON e.DepartmentID = d.DepartmentID

-- Right Join
SELECT * FROM Employees AS e       
	RIGHT JOIN Departments AS d     
	ON e.DepartmentID = d.DepartmentID

-- Full Join
SELECT * FROM Employees AS e       
	FULL JOIN Departments AS d     
	ON e.DepartmentID = d.DepartmentID

-- Cross Join
SELECT * FROM Employees AS e       
	CROSS JOIN Departments AS d   


-- Example with Left Join
SELECT * FROM Employees AS e       
	LEFT JOIN Departments AS d     
	ON e.DepartmentID = d.DepartmentID
	WHERE d.DepartmentID IS NULL 

-- Examples
SELECT TOP 50 e.FirstName, e.LastName, t.[Name] AS Town, a.AddressText
	FROM Employees AS e
		LEFT JOIN Addresses AS a
		ON e.AddressID = a.AddressID
		LEFT Join Towns AS t
		ON a.TownID = t.TownID
	ORDER BY FirstName, LastName

SELECT e.EmployeeID, e.FirstName, e.LastName, d.[Name] AS DepartmentName
	FROM Employees AS e
		JOIN Departments AS d 
		ON e.DepartmentID = d.DepartmentID
		WHERE d.[Name] = 'Sales'
		ORDER BY e.EmployeeID

SELECT e.FirstName, e.LastName, e.HireDate, d.[Name] AS DeptName 
	FROM Employees AS e
		JOIN Departments AS d
		ON e.DepartmentID = d.DepartmentID
		AND d.[Name] IN ('Sales', 'Finance')
		WHERE e.HireDate > '1999-01-01'
		ORDER BY e.HireDate

SELECT TOP 50
	e.EmployeeID, 
	CONCAT(e.FirstName, ' ', e.LastName) AS EmployeeName, 
	CONCAT(m.FirstName, ' ', m.LastName) AS ManagerName, 
	d.[Name] AS DepartmentName
FROM Employees AS e
	JOIN Employees AS m
	ON e.ManagerID = m.EmployeeID
	JOIN Departments AS d
	ON e.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID

-- Subqueries 

SELECT * FROM Employees AS e
WHERE e.DepartmentID IN
(
SELECT d.DepartmentID
FROM Departments AS d
WHERE d.Name = 'Finance'
)

SELECT MIN(a.AverageSalary) AS MinAverageSalary
FROM 
(SELECT AVG(e.Salary) AS AverageSalary, DepartmentID 
FROM Employees AS e
GROUP BY DepartmentID) AS a

-- Temporary Table
CREATE TABLE #Employees  -- local table
(
Id INT PRIMARY KEY,
FirstName VARCHAR(50),
LastName VARCHAR(50),
Address VARCHAR(50)
)

SELECT * FROM #Employees

DROP TABLE #Employees

CREATE TABLE ##Employees  -- global table
(
Id INT PRIMARY KEY,
FirstName VARCHAR(50),
LastName VARCHAR(50),
Address VARCHAR(50)
)

SELECT * FROM ##Employees

