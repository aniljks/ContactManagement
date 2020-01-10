CREATE TABLE [dbo].[Contact]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [FirstName] NVARCHAR(100) NULL, 
    [LastName] NVARCHAR(100) NULL, 
    [Email] NVARCHAR(100) NULL, 
    [Phone] NUMERIC(12) NULL, 
    [Status] BIT NULL
)
