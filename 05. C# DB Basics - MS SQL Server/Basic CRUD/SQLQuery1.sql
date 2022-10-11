SELECT d.Name AS DepartmentName FROM Departments AS d  -- Aliases

SELECT FirstName +' ' + LastName AS [Full Name]          -- [ ] or ' '
	FROM Employees

SELECT FirstName +' ' + LastName AS [Full Name],     -- Concatenation
		JobTitle,
		Salary
	FROM Employees

SELECT DISTINCT DepartmentId -- unique order values
	FROM Employees
 
SELECT * FROM Employees
		WHERE NOT (Salary BETWEEN 30000 AND 80000) -- OR

SELECT * 
		FROM Employees
		WHERE DepartmentID IN (1, 2 , 3) -- NOT IN

SELECT * 
	FROM Employees
	WHERE MiddleName IS NULL -- NOT NULL

SELECT TOP(5) *
	FROM Employees
	ORDER BY Salary DESC

CREATE VIEW v_EmpoyeesSalaryInfo AS                -- като метод
SELECT FirstName + ' ' + LastName AS [Full Name],    
		Salary
	FROM Employees

SELECT * FROM v_EmpoyeesSalaryInfo

