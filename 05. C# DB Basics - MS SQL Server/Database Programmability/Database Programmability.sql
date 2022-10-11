USE SoftUni

GO

CREATE FUNCTION udf_ProcessText(@text NVARCHAR(50))
RETURNS NVARCHAR(50)
AS
BEGIN
	RETURN @text + 'Some Text'
END

SELECT dbo.udf_ProcessText(e.FirstName)
FROM Employees AS e

GO

CREATE FUNCTION udf_GetSalaryLevel(@salary DECIMAL)
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @salaryLevel NVARCHAR(10)
	IF (@salary < 30000)
	BEGIN
		SET @salaryLevel = 'Low'
	END
	ELSE IF (@salary <= 50000)
	BEGIN
		SET @salaryLevel = 'Average'
	END
	ELSE
	BEGIN
		SET @salaryLevel = 'High'
	END
	RETURN @salaryLevel
END

GO

SELECT FirstName, LastName, dbo.udf_GetSalaryLevel(Salary) AS Salary
FROM Employees

GO

CREATE OR ALTER PROC usp_OldestEmployees
AS
SELECT * 
FROM Employees
ORDER BY HireDate DESC

EXEC dbo.usp_OldestEmployees


BEGIN TRY  
    -- Generate a divide-by-zero error.  
    SELECT 1/0
END TRY  
BEGIN CATCH  
    SELECT  
        ERROR_NUMBER() AS ErrorNumber  
        ,ERROR_SEVERITY() AS ErrorSeverity  
        ,ERROR_STATE() AS ErrorState  
        ,ERROR_PROCEDURE() AS ErrorProcedure  
        ,ERROR_LINE() AS ErrorLine  
        ,ERROR_MESSAGE() AS ErrorMessage;  
END CATCH  
GO

CREATE OR ALTER PROC usp_InsertProject(@employeeId INT, @projectId INT)
AS
BEGIN
	DECLARE @totalProjects INT
	SET @totalProjects =
	(
	SELECT COUNT(*) 
	FROM EmployeesProjects AS ep
	WHERE ep.EmployeeID = @employeeId
	)

	IF(@totalProjects > 3)
	BEGIN
		THROW 50001, 'Employees cannot have more than 3 projects', 1
	END

	INSERT INTO EmployeesProjects
VALUES (@employeeId, @projectId)
END

EXEC usp_InsertProject 1, 3