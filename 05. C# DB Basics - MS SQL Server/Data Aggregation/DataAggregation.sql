USE SoftUni

SELECT DepartmentID,
		Salary
FROM Employees

SELECT e.DepartmentID, SUM(e.Salary) AS 'SalarySum' --MAX
FROM Employees AS e
GROUP BY e.DepartmentID
ORDER BY SalarySum DESC

SELECT DISTINCT DepartmentID
FROM Employees

SELECT e.DepartmentID, COUNT(e.DepartmentID) AS CountEmployees
FROM Employees AS e
GROUP BY e.DepartmentID
ORDER BY CountEmployees DESC

-- JOIN 3 Tables
SELECT e.FirstName + ' ' + e.LastName AS 'FullName',
		d.Name AS 'Department',
		a.AddressText AS 'Address'
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
JOIN Addresses AS a
ON e.AddressID = a.AddressID
ORDER BY [Name] 

SELECT
	e.DepartmentID,
	COUNT(e.DepartmentID) AS 'CountEmplloyees',
	AVG(e.Salary) AS 'AvgSalary',
	MAX(e.Salary) AS 'MaxSalary',
	MIN(e.Salary) AS 'MinSalary',
	SUM(e.Salary) AS 'TotalSalary',
	STRING_AGG(e.FirstName, ', ') AS 'Employees'
FROM Employees AS e
GROUP BY e.DepartmentID
HAVING SUM(e.Salary) > 200000