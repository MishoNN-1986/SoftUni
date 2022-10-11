CREATE DATABASE TableRelations
GO

USE TableRelations

-- Problem 1. One-To-One Relationship

CREATE TABLE Passports(
	[PassportID] INT PRIMARY KEY,
	[PassportNumber] NVARCHAR(50) NOT NULL
)

CREATE TABLE Persons(
	[PersonID] INT PRIMARY KEY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[Salary] DECIMAL(18, 2) NOT NULL,
	[PassportID] INT FOREIGN KEY REFERENCES Passports([PassportID]) UNIQUE
)

INSERT INTO Passports([PassportID], [PassportNumber])
	VALUES
		  (101, 'N34FG21B'),
		  (102, 'K65LO4R7'),
		  (103, 'ZE657QP2')

INSERT INTO Persons([FirstName], [Salary], [PassportID])
	VALUES
		  ('Roberto', 43300.00, 102),
		  ('Tom', 56100.00, 103),
		  ('Yana', 60200.00, 101)

-- Problem 2. One-To-Many Relationship

CREATE TABLE Manufacturers(
	[ManufacturerID] INT PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[EstablishedOn] DATE NOT NULL
)

CREATE TABLE Models(
	[ModelID] INT PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[ManufacturerID] INT FOREIGN KEY REFERENCES Manufacturers([ManufacturerID])
)

INSERT INTO Manufacturers([Name], [EstablishedOn])
	VALUES
		  ('BMW', '07/03/1916'),
		  ('Tesla', '01/01/2003'),
		  ('Lada', '01/05/1966')

INSERT INTO Models([ModelID], [Name], [ManufacturerID])
	VALUES
		  (101, 'X1', 1),
		  (102, 'i6', 1),
		  (103, 'Model S', 2),
		  (104, 'Model X', 2),
		  (105, 'Model 3', 2),
		  (106, 'Nova', 3)

-- Problem 3. Many-To-Many Relationship

CREATE TABLE Students(
	StudentID INT PRIMARY KEY,
	[Name] NVARCHAR(255) NOT NULL
)

CREATE TABLE Exams(
	ExamID INT PRIMARY KEY,
	[Name] NVARCHAR(255) NOT NULL 
)

CREATE TABLE StudentsExams
(
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
	ExamID INT FOREIGN KEY REFERENCES Exams(ExamID)
	CONSTRAINT PK_StudentsExams 
	PRIMARY KEY(StudentID, ExamID)             
)

INSERT INTO Students([Name])
	VALUES
		  ('Mila'),
		  ('Toni'),
		  ('Ron')

INSERT INTO Exams([ExamID], [Name])
	VALUES
		  (101, 'SpringMVC'),
		  (102, 'Neo4j'),
		  (103, 'Oracle 11g')

INSERT INTO StudentsExams([StudentID], [ExamID])
	VALUES
		  (1, 101),
		  (1, 102),
		  (2, 101),
		  (3, 103),
		  (2, 102),
		  (2, 103)

-- Problem 4. Self-Referencing 

CREATE TABLE Teachers(
	[TeacherID] INT PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[ManagerID] INT FOREIGN KEY REFERENCES Teachers([TeacherID])
)

INSERT INTO Teachers([TeacherID], [Name], [ManagerID])
	VALUES
		  (101, 'John', NULL ),
		  (102, 'Maya',106 ),
		  (103, 'Silvia', 106),
		  (104, 'Ted', 105),
		  (105, 'Mark', 101),
		  (106, 'Greta', 101)

-- Problem 5. Online Store Database

CREATE DATABASE OnlineStore

USE OnlineStore

CREATE TABLE Cities(
	[CityID] INT PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Customers(
	[CustomerID] INT PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[Birthday] DATE NOT NULL,
	[CityID] INT FOREIGN KEY REFERENCES Cities([CityID])
)

CREATE TABLE Orders(
	[OrderID] INT PRIMARY KEY,
	[CustomerID] INT FOREIGN KEY REFERENCES Customers([CustomerID])
)

CREATE TABLE ItemTypes (
	[ItemTypeID] INT PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Items(
	[ItemID] INT PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[ItemTypeID] INT FOREIGN KEY REFERENCES ItemTypes([ItemTypeID])
)

CREATE TABLE OrderItems(
	[OrderID] INT FOREIGN KEY REFERENCES Orders([OrderID]),
	[ItemID] INT FOREIGN KEY REFERENCES Items([ItemID])
	PRIMARY KEY ([OrderID], [ItemID])
)

-- Problem 6. University Database

CREATE DATABASE University 

USE University 

CREATE TABLE Majors(
	[MajorID] INT PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Students(
	[StudentID] INT PRIMARY KEY,
	[StudentNumber] NVARCHAR(50) NOT NULL,
	[StudentName] NVARCHAR(50) NOT NULL,
	[MajorID] INT FOREIGN KEY REFERENCES Majors([MajorID])
)

CREATE TABLE Payments(
	[PaymentID] INT PRIMARY KEY,
	[PaymentDate] DATETIME2 NOT NULL,
	[PaymentAmount] NVARCHAR(50) NOT NULL,
	[StudentID] INT FOREIGN KEY REFERENCES Students([StudentID])
)

CREATE TABLE Subjects(
	[SubjectID] INT PRIMARY KEY,
	[SubjectName] NVARCHAR(50) NOT NULL
)

CREATE TABLE Agenda(
	[StudentID] INT FOREIGN KEY REFERENCES Students([StudentID]),
	[SubjectID] INT FOREIGN KEY REFERENCES Subjects([SubjectID])
	PRIMARY KEY ([StudentID], [SubjectID])
)

-- Problem 9. *Peaks in Rila

USE [Geography]

SELECT m.MountainRange, p.PeakName, p.Elevation
FROM Mountains AS m
INNER JOIN Peaks AS p 
ON  m.Id = p.MountainId
WHERE MountainRange = 'Rila'
ORDER BY Elevation DESC

