CREATE TABLE People (
	Id INT
	UNIQUE IDENTITY NOT NULL,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY(MAX),
	Height NUMERIC(3,2),
	[Weight] NUMERIC(5,2),
	Gender CHAR(1) CHECK([Gender] IN('M', 'F')) NOT NULL,
	Birthdate DATE NOT NULL,
	Biography NVARCHAR(MAX)
); 

ALTER TABLE People
ADD PRIMARY KEY(Id);

ALTER TABLE People
ADD CONSTRAINT CH_PictureSize CHECK(DATALENGTH(Picture) <= 2* 1024 * 1024);

INSERT INTO People([Name],
					Gender,
					Birthdate
					)
VALUES
(
		'First Name',
		'M',
		'01-01-2000'
),
(
		'Second Name',
		'F',
		'05-03-2001'
),
(
		'Third Name',
		'F',
		'07-08-2005'
),
(
		'Fourth Name',
		'F',
		'03-05-2007'
),
(
		'Fifth Name',
		'M',
		'08-09-2003'
);

CREATE TABLE Users
(
			Id BIGINT 
			UNIQUE IDENTITY NOT NULL,
			Username VARCHAR(30)
			UNIQUE NOT NULL,
			[Password] VARCHAR(26) NOT NULL,
			ProfilePicture VARBINARY(MAX),
			LastLoginTime DATETIME2,
			IsDeleted BIT NOT NULL
							DEFAULT(0)
);

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY(ID);

ALTER TABLE Users
ADD CONSTRAINT CH_ProfilePicture CHECK(DATALENGTH(ProfilePicture) <= 900 * 1024);

/* ********* TEST ProfilePicture CONSTRAINT *************
DECLARE @C VARCHAR(MAX)= '|';
DECLARE @ProfilePicture VARBINARY(MAX)= CONVERT(VARBINARY(MAX), REPLICATE(@C, (921600))); -- Must throw an exception
-- DECLARE @ProfilePicture VARBINARY(MAX) = CONVERT(VARBINARY(MAX), REPLICATE(@C, (921599))); -- Must pass through the size check
INSERT INTO Users(Id,
                  Username,
                  Password,
                  ProfilePicture
                 )
VALUES
(
       1,
       'Name',
       'Pass123456',
       @ProfilePicture
);
 */

INSERT INTO Users(Username,
                  Password
                 )
VALUES
(
       'First',
       'FpAsS'
),
(
       'Second',
       'SpAsS'
),
(
       'Third',
       'TpAsS'
),
(
       'Fourth',
       'FpAsS'
),
(
       'Fifth',
       'FfTpAsS'
);

ALTER TABLE Users DROP CONSTRAINT PK_Users;

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY(Id, Username);

ALTER TABLE Users
ADD CONSTRAINT Password CHECK(LEN(Password) >= 5);

ALTER TABLE Users
ADD CONSTRAINT DF_Users DEFAULT GETDATE() FOR LastLoginTime;

ALTER TABLE Users DROP CONSTRAINT PK_Users;

ALTER TABLE Users
ADD CONSTRAINT PK_Person PRIMARY KEY(Id);

ALTER TABLE Users
ADD CONSTRAINT UC_Users UNIQUE(Username);

ALTER TABLE Users
ADD CONSTRAINT CHK_Users CHECK(LEN(Password) >= 3);

