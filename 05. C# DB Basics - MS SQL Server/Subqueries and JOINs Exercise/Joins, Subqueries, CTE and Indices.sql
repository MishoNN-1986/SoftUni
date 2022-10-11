USE SoftUni

-- Problem 1. Employee Address

SELECT TOP (5) 
				e.EmployeeID, 
				e.JobTitle, 
				a.AddressID, 
				a.AddressText
	FROM Employees AS e
	JOIN Addresses AS a
	ON e.AddressID = a.AddressID
				ORDER BY AddressID

-- Problem 2. Addresses with Towns

SELECT TOP(50) 
				e.FirstName, 
				e.LastName, 
				t.[Name] AS Town, 
				a.AddressText  
	FROM Employees AS e
	JOIN Addresses AS a
	ON e.AddressID = a.AddressID
	JOIN Towns AS t
	ON a.TownID = t.TownID
				ORDER BY FirstName,
						LastName

-- Problem 3. Sales Employee

SELECT 
		e.EmployeeID, 
		e.FirstName, 
		e.LastName, 
		d.[Name]
	FROM Employees AS e
	JOIN Departments AS d
	ON e.DepartmentID = d.DepartmentID
		WHERE d.[Name] = 'Sales'
		ORDER BY e.EmployeeID

-- Problem 4. Employee Departments

SELECT TOP(5)
				e.EmployeeID,
				e.FirstName,
				e.Salary,
				d.[Name] AS DepartmentName
	FROM Employees AS e
	JOIN Departments AS d
	ON e.DepartmentID = d.DepartmentID
		WHERE e.Salary > 15000
		ORDER BY e.DepartmentID

-- Problem 5. Employees Without Project

SELECT TOP(3) 
				e.EmployeeID,
				e.FirstName
	FROM Employees AS e
	LEFT JOIN EmployeesProjects AS ep
	ON e.EmployeeID = ep.EmployeeID
		WHERE ep.EmployeeID IS NULL
		ORDER BY e.EmployeeID

-- Problem 6. Employees Hired After

SELECT 
		e.FirstName,
		e.LastName,
		e.HireDate,
		d.[Name]
	FROM Employees AS e
	JOIN Departments AS d
	ON e.DepartmentID = d.DepartmentID
		WHERE d.[Name] IN ('Sales', 'Finance')
		AND e.HireDate > 1999-01-01
		ORDER BY e.HireDate

-- Problem 7. Employees with Project

SELECT TOP(5) 
			e.EmployeeID, e.FirstName, p.[Name]
	FROM Employees AS e
	JOIN EmployeesProjects AS ep
	ON e.EmployeeID = ep.EmployeeID
	JOIN Projects AS p
	ON p.ProjectID = ep.ProjectID
		WHERE p.StartDate > 2002-08-13 
			AND p.EndDate IS NULL
		ORDER BY e.EmployeeID

-- Problem 8. Employee 24

SELECT e.EmployeeID, e.FirstName,
CASE 
	WHEN DATEPART(YEAR, p.StartDate) >= 2005
	THEN NULL
	ELSE p.[Name]
	END AS ProjectName
	FROM Employees AS e
		JOIN EmployeesProjects AS ep
		ON e.EmployeeID = ep.EmployeeID
		JOIN Projects AS p
		ON p.ProjectID = ep.ProjectID
			WHERE e.EmployeeID = 24 

-- Problem 9. Employee Manager

SELECT 
		e1.EmployeeID, e1.FirstName, e1.ManagerID, e2.FirstName AS [ManagerName]
	FROM Employees AS e1
	JOIN Employees AS e2
	ON e1.ManagerID = e2.EmployeeID
		WHERE e1.ManagerID IN (3,7)
		ORDER BY e1.EmployeeID

-- Problem 10. Employee Summary

SELECT TOP(50) 
		e1.EmployeeID,
		CONCAT(e1.FirstName, ' ', e1.LastName) AS EmployeeName,
		CONCAT(e2.FirstName, ' ', e2.LastName) AS ManagerName,  
		d.[Name]
	FROM Employees AS e1
	JOIN Employees AS e2
	ON e1.ManagerID = e2.EmployeeID
	JOIN Departments AS d
	ON e1.DepartmentID = d.DepartmentID
		ORDER BY e1.EmployeeID

-- Problem 11. Min Average Salary

SELECT 
		MIN(a.AverageSalary) AS MinAverageSalary
	FROM 
		(SELECT AVG(e.Salary) AS AverageSalary, DepartmentID 
			FROM Employees AS e	
	GROUP BY DepartmentID) AS a

USE [Geography]
	
-- Problem 12. Highest Peaks in Bulgaria

SELECT 
		mc.CountryCode,
		m.MountainRange,
		p.PeakName,
		p.Elevation
	FROM Countries AS c	
	JOIN MountainsCountries AS mc
	ON c.CountryCode = mc.CountryCode
	JOIN Mountains AS m
	ON mc.MountainId = m.Id
	JOIN Peaks AS p
	ON p.MountainId = m.Id
		WHERE p.Elevation > 2835
		AND c.CountryCode = 'BG'
		ORDER BY p.Elevation DESC

-- Problem 13. Count Mountain Ranges

SELECT c.CountryCode,
		COUNT(c.ContinentCode) AS CountryCode
	FROM Countries AS c
	JOIN MountainsCountries AS mc
	ON c.CountryCode = mc.CountryCode
	JOIN Mountains AS m
	ON mc.MountainId = m.Id
		WHERE c.CountryCode IN ('BG', 'RU', 'US')
		GROUP BY c.CountryCode 
		HAVING COUNT (c.ContinentCode) > 0

SELECT CountryCode,
	   COUNT(MountainId) AS MountainRanges
	FROM MountainsCountries
		WHERE CountryCode IN ('BG', 'RU', 'US')
		GROUP BY CountryCode

-- Problem 14. Countries with Rivers

SELECT TOP(5)
		c.CountryName,
		r.RiverName
	FROM Countries AS c
	LEFT JOIN CountriesRivers AS cr
	ON cr.CountryCode = c.CountryCode
	LEFT JOIN Rivers AS r
	ON cr.RiverId = r.Id
		WHERE c.ContinentCode = 'AF'
		ORDER BY c.CountryName

-- Problem 15. *Continents and Currencies

SELECT ContinentCode, 
        CurrencyCode, 
			CurrencyCount AS CurrencyUsage
				  FROM (
						SELECT ContinentCode,
							   CurrencyCode, 
							   CurrencyCount,
							   DENSE_RANK() OVER 
							    (
								  PARTITION BY ContinentCode
								  ORDER BY CurrencyCount DESC
								) AS [CurrencyRank]
								FROM (
									  SELECT ContinentCode, 
											 CurrencyCode,
											 COUNT(*) AS CurrencyCount
										   FROM Countries	
										   GROUP BY ContinentCode, CurrencyCode
									 ) AS [CurrencyCountQuery]
WHERE CurrencyCount > 1) AS [CurrencyRankingQuery]
	WHERE CurrencyRank = 1
		ORDER BY ContinentCode

-- Problem 16. Countries without any Mountains

SELECT 
		COUNT(*) AS [Count]
	FROM Countries AS c
	LEFT JOIN MountainsCountries AS mc
	ON c.CountryCode = mc.CountryCode
	LEFT JOIN Mountains AS m
	ON m.Id = mc.MountainId
	WHERE m.Id IS NULL

-- Problem 17. Highest Peak and Longest River by Country

SELECT TOP(5)
			c.CountryName,
			MAX(p.Elevation) AS HighestPeakElevation,
			MAX(r.Length) AS LongestRiverLength
		FROM Countries AS c
		LEFT JOIN MountainsCountries AS mc
		ON c.CountryCode = mc.CountryCode
		LEFT JOIN Mountains AS m
		ON m.Id = mc.MountainId
		LEFT JOIN Peaks AS p
		ON p.MountainId = m.Id
		LEFT JOIN CountriesRivers AS cr
		ON c.CountryCode = cr.CountryCode
		LEFT JOIN Rivers AS r
		ON r.Id = cr.RiverId
			GROUP BY c.CountryName
			ORDER BY HighestPeakElevation DESC,
					 LongestRiverLength DESC,
					 c.CountryName

-- Problem 18. * Highest Peak Name and Elevation by Country

SELECT TOP(5) [Country],
		CASE 
			WHEN PeakName IS NULL THEN '(no highest peak)'
			ELSE PeakName
		END AS [Highest Peak Name],
		CASE 
			WHEN Elevation IS NULL THEN 0
			ELSE Elevation
		END AS [Highest Peak Elevation],
		CASE
			WHEN MountainRange IS NULL THEN '(no mountain)' 
			ELSE MountainRange
		END AS [Mountain]
		   FROM (
				 SELECT *,
						DENSE_RANK() OVER
							(PARTITION BY [Country] ORDER BY Elevation DESC) AS [PeakRank]
					FROM (
						  SELECT Countries.CountryName AS [Country],
								 Peaks.PeakName,
								 Peaks.Elevation,
								 Mountains.MountainRange
							FROM Countries
							LEFT JOIN MountainsCountries ON Countries.CountryCode = MountainsCountries.CountryCode
							LEFT JOIN Mountains ON MountainsCountries.MountainId = Mountains.Id
							LEFT JOIN Peaks ON Mountains.Id = Peaks.MountainId
						 ) AS [FullInfoQuery] 
				) AS [PeakRankingQuery]
WHERE [PeakRank] = 1
ORDER BY [Country] ASC,
		 [Highest Peak Name] ASC
	
	

	


		
	