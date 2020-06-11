GO  
PRINT N'Creating employee.uspNewEmployee...';  
go 
drop PROCEDURE [employee].[uspNewEmployee] 
GO  
CREATE PROCEDURE [employee].[uspNewEmployee]  
@UserFullName NVARCHAR (40),  
@UserKataName NVARCHAR (40),  
@UserGender NVARCHAR (4),  
@UserDepart NVARCHAR (40),  
@UserBirth DATE,
@UserMail NVARCHAR (40),
@UserTele CHAR (13),
@UserAddress NVARCHAR (50),
@UserEdu NVARCHAR (40),
@UserSpecial NVARCHAR (40),
@UserImage nvarchar (100)
AS  
BEGIN  
INSERT INTO [employee].[UsersData] (UserFullName,UserKataName,UserGender,UserDepart,UserBirth,UserMail,UserTele,UserAddress,UserEdu,UserSpecial,UserImage) VALUES
(@UserFullName,@UserKataName,@UserGender,@UserDepart,@UserBirth,@UserMail,@UserTele,@UserAddress,@UserEdu,@UserSpecial,@UserImage);  
END