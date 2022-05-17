USE [Newmdb]
GO

INSERT INTO [dbo].[Actor]
           ([aID]
           ,[aName]
           ,[ActedM])
     VALUES
           (101,'Amir Khan','Lagaan'),
		  
		   (102,'Utpal Dutt','Agantuk'),
	
		   (103,'Darsheel Safary','Taare Zameen Par')

GO


SELECT * FROM Actor;