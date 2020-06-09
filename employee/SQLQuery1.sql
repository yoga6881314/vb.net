PRINT N'Creating employee...';  
GO  
CREATE SCHEMA [employee]  
    AUTHORIZATION [dbo];  
GO  
PRINT N'Creating employee.UsersData...';  
GO  
CREATE TABLE [employee].[UsersData] (  
    [UserID]   INT           IDENTITY (1, 1) NOT NULL,  
    [UserFullName] NVARCHAR (40) NOT NULL,  
    [UserKataName]    NVARCHAR (40)          NOT NULL,  
    [UserGender]     NVARCHAR (4)          NOT NULL,
    [UserDepart]    NVARCHAR (40)          NOT NULL, 
    [UserBirth]    DATE         NOT NULL, 
    [UserMail]    NVARCHAR (40)          NOT NULL, 
    [UserTele]    CHAR (13)          NOT NULL, 
    [UserAddress]    NVARCHAR (40)          NOT NULL, 
    [UserEdu]    NVARCHAR (40)          NOT NULL, 
    [UserSpecial]    NVARCHAR (40)          NULL, 
    [UserImage]    NVARCHAR (50)          NULL
);  
GO  
PRINT N'Creating employee.AuthorData...';  
GO  
CREATE TABLE [employee].[AuthorData] (  
    [UserID] INT      NOT NULL,  
    [AuthorMail]    NVARCHAR (40)          NOT NULL, 
    [AuthorPassword]    NVARCHAR (20)          NOT NULL
); 
PRINT N'Creating Sales.PK_UsersData_UserID...';
GO  
ALTER TABLE [employee].[UsersData]  ADD CONSTRAINT [PK_UsersData_UserID] 
    PRIMARY KEY CLUSTERED ([UserID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ;
PRINT N'Creating Sales.FK_AuthorData_UsersData_UserID...';  
GO  
ALTER TABLE [employee].[AuthorData] ADD CONSTRAINT [FK_AuthorData_UsersData_UserID] 
    FOREIGN KEY ([UserID]) REFERENCES [employee].[UsersData] ([UserID]) ON DELETE NO ACTION ON UPDATE NO ACTION;
