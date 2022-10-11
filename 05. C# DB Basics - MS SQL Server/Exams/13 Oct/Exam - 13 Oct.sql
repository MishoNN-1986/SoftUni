CREATE DATABASE Bitbucket

USE Bitbucket

--------------------------------------

CREATE TABLE [Users](
		[Id] INT PRIMARY KEY IDENTITY,
		[Username] NVARCHAR(30) NOT NULL,
		[Password] NVARCHAR(30) NOT NULL,
		[Email] NVARCHAR(50) NOT NULL
)

CREATE TABLE [Repositories](
		[Id] INT PRIMARY KEY IDENTITY,
		[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE [RepositoriesContributors](
		[RepositoryId] INT REFERENCES [Repositories](Id) NOT NULL,
		[ContributorId] INT REFERENCES [Users](Id) NOT NULL
		CONSTRAINT PK_RepositoriesContributors PRIMARY KEY([RepositoryId], [ContributorId])
)

CREATE TABLE [Issues](
		[Id] INT PRIMARY KEY IDENTITY,
		[Title] NVARCHAR(255) NOT NULL,
		[IssueStatus] VARCHAR(6),
		[RepositoryId] INT REFERENCES [Repositories](Id) NOT NULL,
		[AssigneeId] INT REFERENCES [Users](Id) NOT NULL
)

CREATE TABLE [Commits](
		[Id] INT PRIMARY KEY IDENTITY,
		[Message] NVARCHAR(255) NOT NULL,
		[IssueId] INT FOREIGN KEY REFERENCES [Issues](Id),
		[RepositoryId] INT REFERENCES [Repositories](Id) NOT NULL,
		[ContributorId] INT REFERENCES [Users](Id) NOT NULL
)

CREATE TABLE [Files](
		[Id] INT PRIMARY KEY IDENTITY,
		[Name] NVARCHAR(100) NOT NULL,
		[Size] DECIMAL(18, 2) NOT NULL,
		[ParentId] INT FOREIGN KEY REFERENCES [Files](Id),
		[CommitId] INT REFERENCES [Commits](Id)
)

--------------------------------------------------------------------
INSERT INTO [Files] ([Name], [Size], [ParentId], [CommitId]) VALUES
	('Trade.idk', 2598.0, 1, 1),
	('menu.net', 9238.31, 2, 2),
	('Administrate.soshy', 1246.93, 3, 3),
	('Controller.php', 7353.15, 4, 4),
	('Find.java', 9957.86, 5, 5),
	('Controller.json', 14034.87, 3, 6),
	('Operate.xix', 7662.92, 7, 7)

INSERT INTO [Issues] (Title, IssueStatus, RepositoryId, AssigneeId) VALUES
('Critical Problem with HomeController.cs file', 'open', 1, 4),
('Typo fix in Judge.html', 'open', 4, 3),
('Implement documentation for UsersService.cs', 'closed', 8, 2),
('Unreachable code in Index.cs', 'open', 9, 8)

---------------------------------------------------------------------
UPDATE Issues
SET IssueStatus = 'closed'
WHERE AssigneeId = '6'

---------------------------------------------------------------------

DELETE FROM RepositoriesContributors
	WHERE RepositoryId = 3

DELETE FROM Issues 
	WHERE RepositoryId = 3

---------------------------------------------------------------------

SELECT [Id], [Message], [RepositoryId], [ContributorId]
FROM Commits
ORDER  BY [Id], [Message], [RepositoryId], [ContributorId]
	
-----------------------------------------------------------------------

SELECT [Id], [Name], [Size]
FROM Files
WHERE [Size] > 1000 AND [Name] LIKE '%html%'
ORDER BY [Size] DESC, [Id], [Name]

----------------------------------------------------------------------

SELECT i.Id, CONCAT(u.Username, + ' : ' + i.Title) AS IssueAssignee
FROM Issues AS i
JOIN Users AS u
ON u.Id = i.AssigneeId
ORDER BY i.Id DESC, i.AssigneeId

----------------------------------------------------------------------

SELECT f.Id, f.[Name], CONVERT(VARCHAR, f.Size) + 'KB' AS Size
FROM Files AS f
LEFT JOIN Files AS fi
ON fi.ParentId = f.Id
WHERE fi.ParentId IS NULL
ORDER BY f.Id, f.[Name], f.Size DESC

-----------------------------------------------------------------------

SELECT TOP(5) r.Id, r.[Name], COUNT(*) AS Commits
FROM Commits AS c
JOIN Repositories AS r 
ON r.Id = c.RepositoryId
JOIN RepositoriesContributors 
AS rc ON rc.RepositoryId = r.Id
GROUP BY r.Id, r.[Name]
ORDER BY Commits DESC, r.Id, r.[Name]

-----------------------------------------------------------------------

SELECT u.Username, AVG(f.Size) AS Size 
FROM Users AS u 
	JOIN Commits AS c 
	ON c.ContributorId = u.Id
	JOIN Files AS f 
	ON f.CommitId = c.Id
	GROUP BY u.Username
	ORDER BY AVG(f.Size) DESC, u.Username

------------------------------------------------------------------------

GO
CREATE FUNCTION udf_UserTotalCommits(@username NVARCHAR(30)) 
RETURNS INT AS
BEGIN
	DECLARE @result INT;  

	SELECT @result = COUNT(c.Id) 
	FROM Users AS u 
	JOIN Commits AS c 
	ON c.ContributorId = u.Id
	WHERE u.Username = @username

	RETURN @result
END

--SELECT dbo.udf_UserTotalCommits('UnderSinduxrein')
 ----------------------------------------------------------------------

 GO
CREATE PROC usp_FindByExtension(@extension NVARCHAR(10)) AS
BEGIN
	SELECT Id, [Name], CONVERT(VARCHAR, Size) + 'KB' AS Size 
	FROM Files AS f
	WHERE f.[Name] LIKE '%'+ @extension
	ORDER BY Id, [Name], f.Size DESC
END

--EXEC usp_FindByExtension 'txt'