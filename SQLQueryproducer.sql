USE [Newmdb]
GO

INSERT INTO [dbo].[Producer]
           ([pID]
           ,[pName]
           ,[producedM])
     VALUES
           (51,'Satyajit Ray','Aguntuk'),
		   (52,'Amir Khan','Lagaan'),
		   (53,'Govt. of WB','Hirak Rajar Deshe'); 

GO
SELECT * FROM Producer;

