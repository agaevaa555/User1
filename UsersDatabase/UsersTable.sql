CREATE TABLE [dbo].[UsersTable]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [PasswordHash] BINARY(50) NOT NULL, 
    [PasswordSalt] BINARY(50) NOT NULL
)
