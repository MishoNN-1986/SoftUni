USE Geography
CREATE VIEW v_HighestPeak AS
SELECT TOP(1) Elevation 
	FROM Peaks
	ORDER BY Elevation DESC

SELECT * 
	FROM v_HighestPeak

USE SoftUni

SELECT FirstName, LastName, JobTitle
	INTO MyFiredEmployees     -- create new table with information
	FROM Employees

SELECT * FROM MyFiredEmployees

CREATE SEQUENCE seq_MySequence2
	AS INT
	START WITH 10
	INCREMENT BY 10
	MINVALUE 10
	MAXVALUE 50
	CYCLE   -- започва от начало

SELECT NEXT VALUE FOR seq_MySequence2

UPDATE Addresses
SET TownID = NULL  -- за да изтрием трябва първо да сетнем на null, защото има и други колони с това име в други таблици
WHERE TownID = 1

DELETE FROM Towns
	WHERE TownID = 1

SELECT * FROM Towns

UPDATE Projects
SET EndDate = GETDATE()
WHERE EndDate IS NULL

CREATE TABLE MyTable
(
	MyDate DATE,
	MyTime TIME,
	MyDateTime DATETIME
)

INSERT INTO MyTable (MyDate, MyTime, MyDateTime) VALUES
	('01.01.2019', '20:41', '01.01.2019 12:45:33')

SELECT * FROM MyTable