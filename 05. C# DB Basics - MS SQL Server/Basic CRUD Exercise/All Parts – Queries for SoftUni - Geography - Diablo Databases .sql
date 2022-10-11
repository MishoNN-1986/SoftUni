USE SoftUni

SELECT *
FROM Departments

SELECT [Name]
FROM Departments

SELECT FirstName,
		LastName,
		Salary 
FROM Employees

SELECT FirstName,
		MiddleName,
		LastName 
FROM Employees
		
SELECT FirstName + '.' + LastName + '@softuni.bg' 
	AS	FullEmailAddress 
FROM	Employees

SELECT DISTINCT Salary 
FROM Employees

SELECT * FROM Employees
WHERE JobTitle = 'Sales Representative'

SELECT FirstName,
		LastName,
		JobTitle 
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000

SELECT FirstName +' '+ MiddleName + ' '+ LastName AS 'Full Name' /* CONCAT OR ISNULL(MiddleName, '') */ 
FROM Employees
WHERE Salary = 25000 
	OR Salary = 14000 
	OR Salary = 12500 
	OR Salary = 23600
/* WHERE Salary IN (25000, 14000, 12500, 23600) */

SELECT FirstName,
		LastName
FROM Employees
WHERE ManagerID IS NULL

SELECT FirstName,
		LastName,
		Salary
FROM Employees
WHERE Salary > 50000 
ORDER BY Salary DESC

SELECT TOP(5) FirstName,
			  LastName
FROM Employees
ORDER BY Salary DESC

SELECT FirstName,
		LastName
FROM Employees
WHERE DepartmentID <> 4  /* NOT */

SELECT * FROM Employees
ORDER BY Salary DESC,
		FirstName ASC, 
		LastName DESC,
		MiddleName ASC

GO

CREATE VIEW V_EmployeesSalaries
AS
	SELECT FirstName,
			LastName,
			Salary
FROM Employees

GO

SELECT * FROM V_EmployeesSalaries

GO

CREATE VIEW V_EmployeeNameJobTitle 
		AS 
	SELECT FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName 
		AS 'Full Name',
			JobTitle 
		AS 'Job Title'
	FROM Employees
GO 
SELECT * FROM V_EmployeeNameJobTitle 
/*SELECT CONCAT(FirstName + ' ', MiddleName + ' ', LastName) AS 'Full Name',
       JobTitle AS 'Job Title'
FROM Employees; */

SELECT DISTINCT JobTitle 
FROM Employees

SELECT TOP (10) * 
FROM Projects
ORDER BY StartDate,
		[Name]

SELECT TOP (7) FirstName,
				LastName,
				HireDate
FROM Employees
ORDER BY HireDate DESC

/* *****************************************************
	21.	Increase Salaries
********************************************************/

/* Not for Judge - Making Backup
BACKUP DATABASE SoftUni TO DISK = 'D:\softuni-backup.bak';
*/

DECLARE @EngineeringID INT;

DECLARE @ToolDesignID INT;

DECLARE @MarketingID INT;

DECLARE @InformationServicesID INT;

SELECT TOP (1) @EngineeringID = DepartmentID
FROM Departments
WHERE [Name] = 'Engineering';

SELECT TOP (1) @ToolDesignID = DepartmentID
FROM Departments
WHERE [Name] = 'Tool Design';

SELECT TOP (1) @MarketingID = DepartmentID
FROM Departments
WHERE [Name] = 'Marketing';

SELECT TOP (1) @InformationServicesID = DepartmentID
FROM Departments
WHERE [Name] = 'Information Services';

UPDATE Employees  /* WHERE DepartmentId IN (1, 2, 4, 11) /DepartmentID/ */
  SET
      Salary *= 1.12
WHERE DepartmentID = @EngineeringID
      OR DepartmentID = @ToolDesignID
      OR DepartmentID = @MarketingID
      OR DepartmentID = @InformationServicesID;

UPDATE Employees
	SET Salary *= 1.12
WHERE DepartmentID IN(
	SELECT [DepartmentID]
	FROM Departments
	WHERE [Name] IN ('Engineering', 'Tool Design', 'Marketing', 'Information Services')
)

	
/* --- Works the same way as the one above ---
UPDATE Employees
  SET
      Salary*=1.12
WHERE DepartmentID IN(@EngineeringID, @ToolDesignID, @MarketingID, @InformationServicesID);
*/

SELECT Salary
FROM Employees;

/* Not for Judge - Restore from Backup
USE [Geography];
GO
ALTER DATABASE SoftUni SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
DROP DATABASE SoftUni;
GO
RESTORE DATABASE SoftUni FROM DISK = 'D:\softuni-backup.bak';
*/

USE [Geography]

SELECT PeakName
FROM Peaks
ORDER BY PeakName

SELECT TOP (30) CountryName,
				[Population]			
FROM Countries
WHERE ContinentCode = 'EU'
ORDER BY [Population] DESC,
		CountryName

SELECT CountryName,
		CountryCode,	
	CASE CurrencyCode
		WHEN 'EUR' 
		THEN 'Euro'
		ELSE 'Not Euro'
	END AS Currency
FROM Countries
ORDER BY CountryName

USE Diablo

SELECT [Name]
FROM Characters
ORDER BY [Name]










		 








