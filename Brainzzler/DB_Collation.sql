USE [Brainzzler_DB]
GO

ALTER DATABASE Brainzzler_DB  
COLLATE Cyrillic_General_CS_AI ;  
GO  

ALTER TABLE dbo.ANSWERs ALTER COLUMN ANSWER  
            varchar(255)COLLATE Cyrillic_General_CS_AI NOT NULL;  
GO  

ALTER TABLE dbo.Questions ALTER COLUMN Question  
            varchar(255)COLLATE Cyrillic_General_CS_AI NOT NULL;  
GO  
ALTER TABLE dbo.Test ALTER COLUMN Test  
            varchar(100)COLLATE Cyrillic_General_CS_AI NOT NULL;  
GO  

