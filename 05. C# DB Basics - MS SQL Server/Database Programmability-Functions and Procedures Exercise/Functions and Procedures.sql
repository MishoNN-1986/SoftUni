USE SoftUni

-- Problem 1. Employees with Salary Above 35000

GO
CREATE OR ALTER PROC usp_GetEmployeesSalaryAbove35000 
AS
BEGIN
		SELECT e.FirstName, e.LastName
		FROM Employees AS e
		WHERE e.Salary > 35000
END

--EXEC usp_GetEmployeesSalaryAbove35000 

GO

-- Problem 2. Employees with Salary Above Number

GO
CREATE OR ALTER PROC usp_GetEmployeesSalaryAboveNumber (@minSalary DECIMAL(18,4))
AS
BEGIN
		SELECT e.FirstName, e.LastName
		FROM Employees AS e
		WHERE e.Salary > @minSalary
END

GO

--EXEC usp_GetEmployeesSalaryAboveNumber 48100

GO

--Problem 3. Town Names Starting With

GO
CREATE OR ALTER PROC usp_GetTownsStartingWith (@inputString NVARCHAR(MAX))
AS
BEGIN
		SELECT t.[Name]
		FROM Towns AS t
		WHERE LEFT([Name], LEN(@inputString)) LIKE LEFT(@inputString, LEN(@inputString))
END

GO

--EXEC usp_GetTownsStartingWith 'b'

GO

--Problem 4. Employees from Town

GO
CREATE OR ALTER PROC usp_GetEmployeesFromTown (@townName NVARCHAR(MAX))
AS
BEGIN
		SELECT e.FirstName, e.LastName
		FROM Employees AS e
		JOIN Addresses AS a
		ON e.AddressID = a.AddressID
		JOIN Towns AS t
		ON t.TownID = a.TownID
		WHERE t.[Name] = @townName
END

GO

--EXEC usp_GetEmployeesFromTown 'Sofia'

GO

--Problem 5. Salary Level Function

GO
CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4)) 
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @salaryLevel NVARCHAR(10)
	IF(@salary < 30000)
	BEGIN
		SET @salaryLevel = 'Low'
	END
	ELSE IF(@salary < 50000)
	BEGIN
		SET @salaryLevel = 'Average'
	END
	ELSE
	BEGIN
		SET @salaryLevel = 'High'
	END
	RETURN @salaryLevel
END

/*SELECT Salary, dbo.ufn_GetSalaryLevel(Salary) AS SalaryLevel
FROM Employees
*/

-- Problem 6. Employees by Salary Level

GO
CREATE OR ALTER PROC usp_EmployeesBySalaryLevel (@levelOfSalary NVARCHAR(10))
AS
BEGIN
		SELECT e.FirstName, e.LastName
		FROM Employees AS e
		WHERE dbo.ufn_GetSalaryLevel(e.Salary) = @levelOfSalary
END
--EXEC usp_EmployeesBySalaryLevel [high]

-- Problem 7. Define Function

GO
CREATE FUNCTION ufn_IsWordComprised(@setOfLetters NVARCHAR(50), @word NVARCHAR(50))
RETURNS BIT
AS
BEGIN
    DECLARE @result BIT = 1
	DECLARE @COUNT INT = 1
	DECLARE @currentChar NVARCHAR(1) = NULL
	 
	WHILE @COUNT <= LEN(@word) 
	BEGIN
		SET @currentChar = SUBSTRING(@word, @COUNT, 1) 

		IF (@setOfLetters LIKE '%' + @currentChar + '%')
			BEGIN 
				SET @COUNT += 1;	
			END
		ELSE 
			BEGIN
				SET @result = 0
		        BREAK
			END
	END
	RETURN @result 
END
GO;

--SELECT dbo.ufn_IsWordComprised('bobr', 'bobr')

--Problem 8. *Delete Employees and Departments

GO
CREATE OR ALTER PROC usp_DeleteEmployeesFromDepartment (@departmentId INT)
AS
BEGIN
		DELETE FROM EmployeesProjects
		WHERE EmployeeID IN (
						  SELECT EmployeeID 
						  FROM Employees
						  WHERE DepartmentID = @departmentId
	                    )

		UPDATE Employees
		SET ManagerID = NULL
		WHERE ManagerID IN 
						(
						  SELECT EmployeeID 
						  FROM Employees
						  WHERE DepartmentID = @departmentId
	                    )

	ALTER TABLE Departments ALTER COLUMN ManagerID INT 

	UPDATE Departments
	SET ManagerID = NULL
	WHERE ManagerID IN 
						(
						  SELECT EmployeeID 
						  FROM Employees
						  WHERE DepartmentID = @departmentId
	                    )

	DELETE FROM Employees
	WHERE DepartmentID = @departmentId

	DELETE FROM Departments
	WHERE DepartmentID = @departmentId

	SELECT COUNT(*) AS [Count]
	FROM Employees
	WHERE DepartmentID = @departmentId
END

--EXEC usp_DeleteEmployeesFromDepartment 3

GO

USE Bank2

--Problem 9. Find Full Name

GO
CREATE OR ALTER PROC usp_GetHoldersFullName 
AS
BEGIN
		SELECT CONCAT(ah.FirstName, ' ', ah.LastName) AS [Full Name]
		FROM AccountHolders AS ah
END

--EXEC dbo.usp_GetHoldersFullName

--Problem 10. People with Balance Higher Than

GO
CREATE OR ALTER PROC usp_GetHoldersWithBalanceHigherThan (@balance MONEY)
AS
BEGIN
		SELECT ah.FirstName, ah.LastName
		FROM AccountHolders AS ah
		JOIN Accounts AS a
		ON a.AccountHolderId = ah.Id
		GROUP BY ah.FirstName, ah.LastName
		HAVING SUM(a.Balance) > @balance
		ORDER BY ah.FirstName, ah.LastName
END

--EXEC dbo.usp_GetHoldersWithBalanceHigherThan 1000

--Problem 11. Future Value Function

GO
CREATE FUNCTION ufn_CalculateFutureValue (@sum MONEY, @yearlyInterestRate FLOAT, @numberOfYears INT)
RETURNS MONEY
AS
BEGIN
		RETURN @sum*(POWER(1 + @yearlyInterestRate, @numberOfYears))
END

GO
--EXEC dbo.ufn_CalculateFutureValue 1000, 0.1, 5

GO

--Problem 12. Calculating Interest

GO
CREATE OR ALTER PROC usp_CalculateFutureValueForAccount (@accountId INT, @interestRate FLOAT)
AS
BEGIN
		SELECT a.Id,
				ah.FirstName,
				ah.LastName, a.Balance AS [Current Balance],
				dbo.ufn_CalculateFutureValue (a.Balance, 0.1, 5) AS [Balance in 5 years]
		FROM AccountHolders AS ah
			JOIN Accounts AS a
			ON a.AccountHolderId = ah.Id
		WHERE a.Id = @accountId
END

--EXEC usp_CalculateFutureValueForAccount 1, 0.1
GO
USE Diablo

--Problem 13. *Scalar Function: Cash in User Games Odd Rows

GO
CREATE OR ALTER FUNCTION ufn_CashInUsersGames (@gameName NVARCHAR(50))
RETURNS TABLE
AS
	RETURN
(
		SELECT SUM(ocbg.Cash) AS [SumCash]
		FROM 
		(
			SELECT g.[Name], ug.Cash, ROW_NUMBER() OVER(ORDER BY ug.Cash DESC) AS RowN 
			FROM Games AS g
			JOIN UsersGames AS ug
			ON g.Id = ug.GameId
			WHERE g.[Name] = @gameName
		) AS ocbg
		WHERE ocbg.RowN % 2 != 0		
)

GO
--SELECT * FROM dbo.ufn_CashInUsersGames ('Love in a mist')