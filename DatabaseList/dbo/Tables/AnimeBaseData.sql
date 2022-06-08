CREATE TABLE [dbo].[AnimeBaseData]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Image] IMAGE NULL , 
    [Tytuł] NVARCHAR(50) NOT NULL, 
    [GenresID] INT NOT NULL, 
    [DataWydania] DATE NOT NULL, 
    [Studio] NVARCHAR(50) NOT NULL
)
