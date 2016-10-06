select * from AD_Users
INSERT dbo.AD_Users
        ( User_Id ,
          User_IsBan ,
          User_BannedReason ,
          User_BannedOn ,
          User_IsVerify ,
          User_IsActive ,
          User_IsAnonymous ,
          User_EmailConfirmationToken ,
          User_MobileConfirmationToken ,
          User_LastPasswordChangedOn ,
          User_LastLoginedOn ,
          User_IsSystemAccount ,
          User_LastIp ,
          User_Email ,
          User_EmailConfirmed ,
          User_PasswordHash ,
          User_SecurityStamp ,
          User_PhoneNumber ,
          User_PhoneNumberConfirmed ,
          User_TwoFactorEnabled ,
          User_LockoutEndDateUtc ,
          User_LockoutEnabled ,
          User_AccessFailedCount ,
          User_UserName
        )
VALUES  ( '9D2B0228-4D0D-4C23-8B49-01A698857709' , -- User_Id - uniqueidentifier
          0 , -- User_IsBan - bit
          N'' , -- User_BannedReason - nvarchar(max)
          GETDATE() , -- User_BannedOn - datetime
          1 , -- User_IsVerify - bit
          1 , -- User_IsActive - bit
          0 , -- User_IsAnonymous - bit
          N'' , -- User_EmailConfirmationToken - nvarchar(max)
          N'' , -- User_MobileConfirmationToken - nvarchar(max)
          GETDATE() , -- User_LastPasswordChangedOn - datetime
          GETDATE() , -- User_LastLoginedOn - datetime
          1 , -- User_IsSystemAccount - bit
          N'' , -- User_LastIp - nvarchar(max)
          N'' , -- User_Email - nvarchar(100)
          1 , -- User_EmailConfirmed - bit
          N'' , -- User_PasswordHash - nvarchar(max)
          N'' , -- User_SecurityStamp - nvarchar(max)
          N'' , -- User_PhoneNumber - nvarchar(10)
          1 , -- User_PhoneNumberConfirmed - bit
          1 , -- User_TwoFactorEnabled - bit
          GETDATE() , -- User_LockoutEndDateUtc - datetime
          0 , -- User_LockoutEnabled - bit
          0 , -- User_AccessFailedCount - int
          N''  -- User_UserName - nvarchar(100)
        )