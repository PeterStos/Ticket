CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Store] INT NOT NULL, 
    [Country] NCHAR(10) NOT NULL, 
    [Province] NCHAR(30) NOT NULL, 
    [City] NCHAR(30) NOT NULL
)
