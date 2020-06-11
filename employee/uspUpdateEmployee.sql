GO  
PRINT N'Creating employee.uspUpdateEmployee...';  
GO  
drop procedure [employee].[uspUpdateEmployee];
GO
CREATE PROCEDURE [employee].[uspUpdateEmployee]  
@UserID INT,
@UserFullName NVARCHAR (40),  
@UserKataName NVARCHAR (40),  
@UserGender NVARCHAR (4),  
@UserDepart NVARCHAR (40),  
@UserBirth DATE,
@UserMail NVARCHAR (40),
@UserTele CHAR (13),
@UserAddress NVARCHAR (50),
@UserEdu NVARCHAR (40),
@UserSpecial NVARCHAR (40)

AS  
BEGIN  

UPDATE [employee].[UsersData]  
set UserFullName=@UserFullName,UserKataName=@UserKataName,UserGender=@UserGender,UserDepart=@UserDepart,UserBirth=@UserBirth,UserMail=@UserMail,UserTele=@UserTele,UserAddress=@UserAddress,UserEdu=@UserEdu,UserSpecial=@UserSpecial
where UserID=@UserID

END