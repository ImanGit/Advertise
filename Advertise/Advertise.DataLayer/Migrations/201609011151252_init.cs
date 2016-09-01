namespace Advertise.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AD_Roles",
                c => new
                    {
                        Role_Id = c.Guid(nullable: false),
                        Role_Code = c.String(nullable: false, maxLength: 100),
                        Role_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Role_Type = c.Int(nullable: false),
                        Role_IsSystemRole = c.Boolean(nullable: false),
                        Role_Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Role_Id);
            
            CreateTable(
                "dbo.AD_RoleActions",
                c => new
                    {
                        RoleAction_Id = c.Guid(nullable: false),
                        RoleAction_Title = c.String(nullable: false, maxLength: 100),
                        RoleAction_ActionName = c.String(nullable: false, maxLength: 100),
                        RoleAction_ControllerName = c.String(nullable: false, maxLength: 100),
                        RoleAction_IsActive = c.Boolean(nullable: false),
                        RoleAction_RoleId = c.Guid(nullable: false),
                        RoleAction_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        RoleAction_CreatedOn = c.DateTime(nullable: false),
                        RoleAction_ModifiedOn = c.DateTime(nullable: false),
                        RoleAction_CreatorIp = c.String(),
                        RoleAction_ModifierIp = c.String(),
                        RoleAction_ModifyLocked = c.Boolean(nullable: false),
                        RoleAction_IsDeleted = c.Boolean(nullable: false),
                        RoleAction_ModifierAgent = c.String(),
                        RoleAction_CreatorAgent = c.String(),
                        RoleAction_Version = c.Int(nullable: false),
                        RoleAction_Action = c.Int(nullable: false),
                        RoleAction_ModifiedById = c.Guid(),
                        RoleAction_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.RoleAction_Id)
                .ForeignKey("dbo.AD_Users", t => t.RoleAction_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.RoleAction_ModifiedById)
                .ForeignKey("dbo.AD_Roles", t => t.RoleAction_RoleId)
                .Index(t => t.RoleAction_RoleId)
                .Index(t => t.RoleAction_ModifiedById)
                .Index(t => t.RoleAction_CreatedById);
            
            CreateTable(
                "dbo.AD_Users",
                c => new
                    {
                        User_Id = c.Guid(nullable: false),
                        User_IsBan = c.Boolean(nullable: false),
                        User_BannedReason = c.String(),
                        User_BannedOn = c.DateTime(),
                        User_IsVerify = c.Boolean(nullable: false),
                        User_IsActive = c.Boolean(nullable: false),
                        User_IsAnonymous = c.Boolean(nullable: false),
                        User_EmailConfirmationToken = c.String(),
                        User_MobileConfirmationToken = c.String(),
                        User_LastPasswordChangedOn = c.DateTime(),
                        User_LastLoginedOn = c.DateTime(),
                        User_IsSystemAccount = c.Boolean(nullable: false),
                        User_LastIp = c.String(),
                        User_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        User_Email = c.String(maxLength: 100),
                        User_EmailConfirmed = c.Boolean(nullable: false),
                        User_PasswordHash = c.String(),
                        User_SecurityStamp = c.String(),
                        User_PhoneNumber = c.String(maxLength: 10),
                        User_PhoneNumberConfirmed = c.Boolean(nullable: false),
                        User_TwoFactorEnabled = c.Boolean(nullable: false),
                        User_LockoutEndDateUtc = c.DateTime(),
                        User_LockoutEnabled = c.Boolean(nullable: false),
                        User_AccessFailedCount = c.Int(nullable: false),
                        User_UserName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_UserBudgets",
                c => new
                    {
                        UserBudget_Id = c.Guid(nullable: false),
                        UserBudget_RemainRialValue = c.Int(nullable: false),
                        UserBudget_IncDecValue = c.Int(nullable: false),
                        UserBudget_Description = c.String(),
                        UserBudget_OwnedById = c.Guid(nullable: false),
                        UserBudget_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        UserBudget_CreatedOn = c.DateTime(nullable: false),
                        UserBudget_ModifiedOn = c.DateTime(nullable: false),
                        UserBudget_CreatorIp = c.String(),
                        UserBudget_ModifierIp = c.String(),
                        UserBudget_ModifyLocked = c.Boolean(nullable: false),
                        UserBudget_IsDeleted = c.Boolean(nullable: false),
                        UserBudget_ModifierAgent = c.String(),
                        UserBudget_CreatorAgent = c.String(),
                        UserBudget_Version = c.Int(nullable: false),
                        UserBudget_Action = c.Int(nullable: false),
                        UserBudget_ModifiedById = c.Guid(),
                        UserBudget_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.UserBudget_Id)
                .ForeignKey("dbo.AD_Users", t => t.UserBudget_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.UserBudget_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.UserBudget_OwnedById)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.UserBudget_OwnedById)
                .Index(t => t.UserBudget_ModifiedById)
                .Index(t => t.UserBudget_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_FeatureOrders",
                c => new
                    {
                        FeatureOrder_Id = c.Guid(nullable: false),
                        FeatureOrder_ExpiredOn = c.DateTime(nullable: false),
                        FeatureOrder_OrderedById = c.Guid(nullable: false),
                        FeatureOrder_UserBudgetId = c.Guid(nullable: false),
                        FeatureOrder_FeatureId = c.Guid(nullable: false),
                        FeatureOrder_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        FeatureOrder_CreatedOn = c.DateTime(nullable: false),
                        FeatureOrder_ModifiedOn = c.DateTime(nullable: false),
                        FeatureOrder_CreatorIp = c.String(),
                        FeatureOrder_ModifierIp = c.String(),
                        FeatureOrder_ModifyLocked = c.Boolean(nullable: false),
                        FeatureOrder_IsDeleted = c.Boolean(nullable: false),
                        FeatureOrder_ModifierAgent = c.String(),
                        FeatureOrder_CreatorAgent = c.String(),
                        FeatureOrder_Version = c.Int(nullable: false),
                        FeatureOrder_Action = c.Int(nullable: false),
                        FeatureOrder_ModifiedById = c.Guid(),
                        FeatureOrder_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.FeatureOrder_Id)
                .ForeignKey("dbo.AD_Users", t => t.FeatureOrder_CreatedById)
                .ForeignKey("dbo.AD_Features", t => t.FeatureOrder_FeatureId)
                .ForeignKey("dbo.AD_Users", t => t.FeatureOrder_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.FeatureOrder_OrderedById)
                .ForeignKey("dbo.AD_UserBudgets", t => t.FeatureOrder_UserBudgetId)
                .Index(t => t.FeatureOrder_OrderedById)
                .Index(t => t.FeatureOrder_UserBudgetId)
                .Index(t => t.FeatureOrder_FeatureId)
                .Index(t => t.FeatureOrder_ModifiedById)
                .Index(t => t.FeatureOrder_CreatedById);
            
            CreateTable(
                "dbo.AD_Features",
                c => new
                    {
                        Feature_Id = c.Guid(nullable: false),
                        Feature_Code = c.String(nullable: false, maxLength: 100),
                        Feature_Title = c.String(),
                        Feature_Description = c.String(),
                        Feature_DurationDay = c.String(),
                        Feature_CostRialValue = c.Int(nullable: false),
                        Feature_CostUsdValue = c.Long(nullable: false),
                        Feature_IsActive = c.Boolean(nullable: false),
                        Feature_Type = c.Int(nullable: false),
                        Feature_StartedOn = c.DateTime(nullable: false),
                        Feature_ExpiredOn = c.DateTime(nullable: false),
                        Feature_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Feature_CreatedOn = c.DateTime(nullable: false),
                        Feature_ModifiedOn = c.DateTime(nullable: false),
                        Feature_CreatorIp = c.String(),
                        Feature_ModifierIp = c.String(),
                        Feature_ModifyLocked = c.Boolean(nullable: false),
                        Feature_IsDeleted = c.Boolean(nullable: false),
                        Feature_ModifierAgent = c.String(),
                        Feature_CreatorAgent = c.String(),
                        Feature_Version = c.Int(nullable: false),
                        Feature_Action = c.Int(nullable: false),
                        Feature_ModifiedById = c.Guid(),
                        Feature_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.Feature_Id)
                .ForeignKey("dbo.AD_Users", t => t.Feature_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Feature_ModifiedById)
                .Index(t => t.Feature_ModifiedById)
                .Index(t => t.Feature_CreatedById);
            
            CreateTable(
                "dbo.AD_TagOrders",
                c => new
                    {
                        TagOrder_Id = c.Guid(nullable: false),
                        TagOrder_ExpiredOn = c.DateTime(nullable: false),
                        TagOrder_OrderedById = c.Guid(nullable: false),
                        TagOrder_UserBudgetId = c.Guid(nullable: false),
                        TagOrder_TagId = c.Guid(nullable: false),
                        TagOrder_ProductId = c.Guid(nullable: false),
                        TagOrder_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        TagOrder_CreatedOn = c.DateTime(nullable: false),
                        TagOrder_ModifiedOn = c.DateTime(nullable: false),
                        TagOrder_CreatorIp = c.String(),
                        TagOrder_ModifierIp = c.String(),
                        TagOrder_ModifyLocked = c.Boolean(nullable: false),
                        TagOrder_IsDeleted = c.Boolean(nullable: false),
                        TagOrder_ModifierAgent = c.String(),
                        TagOrder_CreatorAgent = c.String(),
                        TagOrder_Version = c.Int(nullable: false),
                        TagOrder_Action = c.Int(nullable: false),
                        TagOrder_ModifiedById = c.Guid(),
                        TagOrder_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.TagOrder_Id)
                .ForeignKey("dbo.AD_Users", t => t.TagOrder_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.TagOrder_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.TagOrder_OrderedById)
                .ForeignKey("dbo.AD_Products", t => t.TagOrder_ProductId)
                .ForeignKey("dbo.AD_Tags", t => t.TagOrder_TagId)
                .ForeignKey("dbo.AD_UserBudgets", t => t.TagOrder_UserBudgetId)
                .Index(t => t.TagOrder_OrderedById)
                .Index(t => t.TagOrder_UserBudgetId)
                .Index(t => t.TagOrder_TagId)
                .Index(t => t.TagOrder_ProductId)
                .Index(t => t.TagOrder_ModifiedById)
                .Index(t => t.TagOrder_CreatedById);
            
            CreateTable(
                "dbo.AD_Products",
                c => new
                    {
                        Product_Id = c.Guid(nullable: false),
                        Product_Code = c.String(nullable: false, maxLength: 100),
                        Product_Title = c.String(nullable: false, maxLength: 100),
                        Product_Body = c.String(maxLength: 1000),
                        Product_MobileNumber = c.String(nullable: false, maxLength: 10),
                        Product_PhoneNumber = c.String(maxLength: 10),
                        Product_Email = c.String(maxLength: 100),
                        Product_IsApproved = c.Boolean(nullable: false),
                        Product_IsAllowComment = c.Boolean(nullable: false),
                        Product_IsAllowCommentForAnonymous = c.Boolean(nullable: false),
                        Product_IsEnableForShare = c.Boolean(nullable: false),
                        Product_Status = c.Int(nullable: false),
                        Product_OwnedById = c.Guid(nullable: false),
                        Product_ApprovedById = c.Guid(nullable: false),
                        Product_AddressId = c.Guid(nullable: false),
                        Product_CategoryId = c.Guid(nullable: false),
                        Product_CompanyId = c.Guid(nullable: false),
                        Product_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Product_CreatedOn = c.DateTime(nullable: false),
                        Product_ModifiedOn = c.DateTime(nullable: false),
                        Product_CreatorIp = c.String(),
                        Product_ModifierIp = c.String(),
                        Product_ModifyLocked = c.Boolean(nullable: false),
                        Product_IsDeleted = c.Boolean(nullable: false),
                        Product_ModifierAgent = c.String(),
                        Product_CreatorAgent = c.String(),
                        Product_Version = c.Int(nullable: false),
                        Product_Action = c.Int(nullable: false),
                        Product_ModifiedById = c.Guid(),
                        Product_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Product_Id)
                .ForeignKey("dbo.AD_Addresses", t => t.Product_AddressId)
                .ForeignKey("dbo.AD_Users", t => t.Product_ApprovedById)
                .ForeignKey("dbo.AD_Categories", t => t.Product_CategoryId)
                .ForeignKey("dbo.AD_Companies", t => t.Product_CompanyId)
                .ForeignKey("dbo.AD_Users", t => t.Product_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Product_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.Product_OwnedById)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.Product_OwnedById)
                .Index(t => t.Product_ApprovedById)
                .Index(t => t.Product_AddressId)
                .Index(t => t.Product_CategoryId)
                .Index(t => t.Product_CompanyId)
                .Index(t => t.Product_ModifiedById)
                .Index(t => t.Product_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_Addresses",
                c => new
                    {
                        Address_Id = c.Guid(nullable: false),
                        Address_Gps = c.String(),
                        Address_Street = c.String(),
                        Address_Extra = c.String(),
                        Address_PostalCode = c.String(),
                        Address_CityId = c.Guid(nullable: false),
                        Address_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Address_CreatedOn = c.DateTime(nullable: false),
                        Address_ModifiedOn = c.DateTime(nullable: false),
                        Address_CreatorIp = c.String(),
                        Address_ModifierIp = c.String(),
                        Address_ModifyLocked = c.Boolean(nullable: false),
                        Address_IsDeleted = c.Boolean(nullable: false),
                        Address_ModifierAgent = c.String(),
                        Address_CreatorAgent = c.String(),
                        Address_Version = c.Int(nullable: false),
                        Address_Action = c.Int(nullable: false),
                        Address_ModifiedById = c.Guid(),
                        Address_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.Address_Id)
                .ForeignKey("dbo.AD_Cities", t => t.Address_CityId)
                .ForeignKey("dbo.AD_Users", t => t.Address_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Address_ModifiedById)
                .Index(t => t.Address_CityId)
                .Index(t => t.Address_ModifiedById)
                .Index(t => t.Address_CreatedById);
            
            CreateTable(
                "dbo.AD_Cities",
                c => new
                    {
                        City_Id = c.Guid(nullable: false),
                        City_IsState = c.Boolean(nullable: false),
                        City_Name = c.String(nullable: false, maxLength: 100),
                        City_IsActive = c.Boolean(nullable: false),
                        City_ParentPath = c.String(),
                        City_ParentId = c.Guid(nullable: false),
                        City_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        City_CreatedOn = c.DateTime(nullable: false),
                        City_ModifiedOn = c.DateTime(nullable: false),
                        City_CreatorIp = c.String(),
                        City_ModifierIp = c.String(),
                        City_ModifyLocked = c.Boolean(nullable: false),
                        City_IsDeleted = c.Boolean(nullable: false),
                        City_ModifierAgent = c.String(),
                        City_CreatorAgent = c.String(),
                        City_Version = c.Int(nullable: false),
                        City_Action = c.Int(nullable: false),
                        City_ModifiedById = c.Guid(),
                        City_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.City_Id)
                .ForeignKey("dbo.AD_Cities", t => t.City_ParentId)
                .ForeignKey("dbo.AD_Users", t => t.City_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.City_ModifiedById)
                .Index(t => t.City_ParentId)
                .Index(t => t.City_ModifiedById)
                .Index(t => t.City_CreatedById);
            
            CreateTable(
                "dbo.AD_Categories",
                c => new
                    {
                        Category_Id = c.Guid(nullable: false),
                        Category_Code = c.String(nullable: false, maxLength: 100),
                        Category_Title = c.String(nullable: false, maxLength: 100),
                        Category_Description = c.String(nullable: false, maxLength: 1000),
                        Category_ImageFileName = c.String(),
                        Category_ParentPath = c.String(),
                        Category_IsActive = c.Boolean(nullable: false),
                        Category_ParentId = c.Guid(nullable: false),
                        Category_RowVersion = c.Binary(),
                        Category_CreatedOn = c.DateTime(nullable: false),
                        Category_ModifiedOn = c.DateTime(nullable: false),
                        Category_CreatorIp = c.String(),
                        Category_ModifierIp = c.String(),
                        Category_ModifyLocked = c.Boolean(nullable: false),
                        Category_IsDeleted = c.Boolean(nullable: false),
                        Category_ModifierAgent = c.String(),
                        Category_CreatorAgent = c.String(),
                        Category_Version = c.Int(nullable: false),
                        Category_Action = c.Int(nullable: false),
                        Category_ModifiedById = c.Guid(),
                        Category_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.Category_Id)
                .ForeignKey("dbo.AD_Categories", t => t.Category_ParentId)
                .ForeignKey("dbo.AD_Users", t => t.Category_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Category_ModifiedById)
                .Index(t => t.Category_ParentId)
                .Index(t => t.Category_ModifiedById)
                .Index(t => t.Category_CreatedById);
            
            CreateTable(
                "dbo.AD_Companies",
                c => new
                    {
                        Company_Id = c.Guid(nullable: false),
                        Company_Code = c.String(nullable: false, maxLength: 100),
                        Company_BrandName = c.String(nullable: false, maxLength: 100),
                        Company_Description = c.String(nullable: false, maxLength: 1000),
                        Company_LogoFileName = c.String(maxLength: 100),
                        Company_BackgroundFileName = c.String(maxLength: 100),
                        Company_PhoneNumber = c.String(nullable: false, maxLength: 10),
                        Company_MobileNumber = c.String(nullable: false, maxLength: 10),
                        Company_Email = c.String(maxLength: 100),
                        Company_WebSite = c.String(maxLength: 100),
                        Company_EmployeeCount = c.Long(nullable: false),
                        Company_EstablishedOn = c.DateTime(nullable: false),
                        Company_OwnedById = c.Guid(nullable: false),
                        Company_AddressId = c.Guid(nullable: false),
                        Company_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Company_CreatedOn = c.DateTime(nullable: false),
                        Company_ModifiedOn = c.DateTime(nullable: false),
                        Company_CreatorIp = c.String(),
                        Company_ModifierIp = c.String(),
                        Company_ModifyLocked = c.Boolean(nullable: false),
                        Company_IsDeleted = c.Boolean(nullable: false),
                        Company_ModifierAgent = c.String(),
                        Company_CreatorAgent = c.String(),
                        Company_Version = c.Int(nullable: false),
                        Company_Action = c.Int(nullable: false),
                        Company_ModifiedById = c.Guid(),
                        Company_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Company_Id)
                .ForeignKey("dbo.AD_Addresses", t => t.Company_AddressId)
                .ForeignKey("dbo.AD_Users", t => t.Company_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Company_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.Company_OwnedById)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.Company_OwnedById)
                .Index(t => t.Company_AddressId)
                .Index(t => t.Company_ModifiedById)
                .Index(t => t.Company_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_CompanyAttachments",
                c => new
                    {
                        CompanyAttachment_Id = c.Guid(nullable: false),
                        CompanyAttachment_FileName = c.String(nullable: false, maxLength: 100),
                        CompanyAttachment_FileSize = c.String(),
                        CompanyAttachment_FileExtension = c.String(),
                        CompanyAttachment_DownloadCount = c.Long(nullable: false),
                        CompanyAttachment_Title = c.String(),
                        CompanyAttachment_Description = c.String(),
                        CompanyAttachment_Type = c.Int(nullable: false),
                        CompanyAttachment_IsApproved = c.Boolean(nullable: false),
                        CompanyAttachment_OwnedById = c.Guid(nullable: false),
                        CompanyAttachment_CompanyId = c.Guid(nullable: false),
                        CompanyAttachment_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CompanyAttachment_CreatedOn = c.DateTime(nullable: false),
                        CompanyAttachment_ModifiedOn = c.DateTime(nullable: false),
                        CompanyAttachment_CreatorIp = c.String(),
                        CompanyAttachment_ModifierIp = c.String(),
                        CompanyAttachment_ModifyLocked = c.Boolean(nullable: false),
                        CompanyAttachment_IsDeleted = c.Boolean(nullable: false),
                        CompanyAttachment_ModifierAgent = c.String(),
                        CompanyAttachment_CreatorAgent = c.String(),
                        CompanyAttachment_Version = c.Int(nullable: false),
                        CompanyAttachment_Action = c.Int(nullable: false),
                        CompanyAttachment_ModifiedById = c.Guid(),
                        CompanyAttachment_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.CompanyAttachment_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyAttachment_CompanyId)
                .ForeignKey("dbo.AD_Users", t => t.CompanyAttachment_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyAttachment_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyAttachment_OwnedById)
                .Index(t => t.CompanyAttachment_OwnedById)
                .Index(t => t.CompanyAttachment_CompanyId)
                .Index(t => t.CompanyAttachment_ModifiedById)
                .Index(t => t.CompanyAttachment_CreatedById);
            
            CreateTable(
                "dbo.AD_CompanyFollows",
                c => new
                    {
                        CompanyFollow_Id = c.Guid(nullable: false),
                        CompanyFollow_IsFollow = c.Boolean(nullable: false),
                        CompanyFollow_FollowedById = c.Guid(nullable: false),
                        CompanyFollow_CompanyId = c.Guid(nullable: false),
                        CompanyFollow_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CompanyFollow_CreatedOn = c.DateTime(nullable: false),
                        CompanyFollow_ModifiedOn = c.DateTime(nullable: false),
                        CompanyFollow_CreatorIp = c.String(),
                        CompanyFollow_ModifierIp = c.String(),
                        CompanyFollow_ModifyLocked = c.Boolean(nullable: false),
                        CompanyFollow_IsDeleted = c.Boolean(nullable: false),
                        CompanyFollow_ModifierAgent = c.String(),
                        CompanyFollow_CreatorAgent = c.String(),
                        CompanyFollow_Version = c.Int(nullable: false),
                        CompanyFollow_Action = c.Int(nullable: false),
                        CompanyFollow_ModifiedById = c.Guid(),
                        CompanyFollow_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.CompanyFollow_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyFollow_CompanyId)
                .ForeignKey("dbo.AD_Users", t => t.CompanyFollow_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyFollow_FollowedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyFollow_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.CompanyFollow_FollowedById)
                .Index(t => t.CompanyFollow_CompanyId)
                .Index(t => t.CompanyFollow_ModifiedById)
                .Index(t => t.CompanyFollow_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_CompanyImages",
                c => new
                    {
                        CompanyImage_Id = c.Guid(nullable: false),
                        CompanyImage_Title = c.String(maxLength: 100),
                        CompanyImage_FileName = c.String(nullable: false, maxLength: 100),
                        CompanyImage_FileSize = c.String(nullable: false, maxLength: 10),
                        CompanyImage_FileDimension = c.String(nullable: false, maxLength: 10),
                        CompanyImage_Order = c.Int(nullable: false),
                        CompanyImage_CompanyId = c.Guid(nullable: false),
                        CompanyImage_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CompanyImage_CreatedOn = c.DateTime(nullable: false),
                        CompanyImage_ModifiedOn = c.DateTime(nullable: false),
                        CompanyImage_CreatorIp = c.String(),
                        CompanyImage_ModifierIp = c.String(),
                        CompanyImage_ModifyLocked = c.Boolean(nullable: false),
                        CompanyImage_IsDeleted = c.Boolean(nullable: false),
                        CompanyImage_ModifierAgent = c.String(),
                        CompanyImage_CreatorAgent = c.String(),
                        CompanyImage_Version = c.Int(nullable: false),
                        CompanyImage_Action = c.Int(nullable: false),
                        CompanyImage_ModifiedById = c.Guid(),
                        CompanyImage_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.CompanyImage_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyImage_CompanyId)
                .ForeignKey("dbo.AD_Users", t => t.CompanyImage_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyImage_ModifiedById)
                .Index(t => t.CompanyImage_CompanyId)
                .Index(t => t.CompanyImage_ModifiedById)
                .Index(t => t.CompanyImage_CreatedById);
            
            CreateTable(
                "dbo.AD_CompanyModerators",
                c => new
                    {
                        CompanyModerator_Id = c.Guid(nullable: false),
                        CompanyModerator_IsActive = c.Boolean(nullable: false),
                        CompanyModerator_ModeratedById = c.Guid(nullable: false),
                        CompanyModerator_CompanyId = c.Guid(nullable: false),
                        CompanyModerator_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CompanyModerator_CreatedOn = c.DateTime(nullable: false),
                        CompanyModerator_ModifiedOn = c.DateTime(nullable: false),
                        CompanyModerator_CreatorIp = c.String(),
                        CompanyModerator_ModifierIp = c.String(),
                        CompanyModerator_ModifyLocked = c.Boolean(nullable: false),
                        CompanyModerator_IsDeleted = c.Boolean(nullable: false),
                        CompanyModerator_ModifierAgent = c.String(),
                        CompanyModerator_CreatorAgent = c.String(),
                        CompanyModerator_Version = c.Int(nullable: false),
                        CompanyModerator_Action = c.Int(nullable: false),
                        CompanyModerator_ModifiedById = c.Guid(),
                        CompanyModerator_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.CompanyModerator_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyModerator_CompanyId)
                .ForeignKey("dbo.AD_Users", t => t.CompanyModerator_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyModerator_ModeratedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyModerator_ModifiedById)
                .Index(t => t.CompanyModerator_ModeratedById)
                .Index(t => t.CompanyModerator_CompanyId)
                .Index(t => t.CompanyModerator_ModifiedById)
                .Index(t => t.CompanyModerator_CreatedById);
            
            CreateTable(
                "dbo.AD_CompanyQuestions",
                c => new
                    {
                        CompanyQuestion_Id = c.Guid(nullable: false),
                        CompanyQuestion_Title = c.String(nullable: false, maxLength: 100),
                        CompanyQuestion_Body = c.String(nullable: false, maxLength: 1000),
                        CompanyQuestion_IsApproved = c.Boolean(nullable: false),
                        CompanyQuestion_ReplyId = c.Guid(nullable: false),
                        CompanyQuestion_CompanyId = c.Guid(nullable: false),
                        CompanyQuestion_QuestionedById = c.Guid(nullable: false),
                        CompanyQuestion_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CompanyQuestion_CreatedOn = c.DateTime(nullable: false),
                        CompanyQuestion_ModifiedOn = c.DateTime(nullable: false),
                        CompanyQuestion_CreatorIp = c.String(),
                        CompanyQuestion_ModifierIp = c.String(),
                        CompanyQuestion_ModifyLocked = c.Boolean(nullable: false),
                        CompanyQuestion_IsDeleted = c.Boolean(nullable: false),
                        CompanyQuestion_ModifierAgent = c.String(),
                        CompanyQuestion_CreatorAgent = c.String(),
                        CompanyQuestion_Version = c.Int(nullable: false),
                        CompanyQuestion_Action = c.Int(nullable: false),
                        CompanyQuestion_ModifiedById = c.Guid(),
                        CompanyQuestion_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.CompanyQuestion_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyQuestion_CompanyId)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestion_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestion_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestion_QuestionedById)
                .ForeignKey("dbo.AD_CompanyQuestions", t => t.CompanyQuestion_ReplyId)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.CompanyQuestion_ReplyId)
                .Index(t => t.CompanyQuestion_CompanyId)
                .Index(t => t.CompanyQuestion_QuestionedById)
                .Index(t => t.CompanyQuestion_ModifiedById)
                .Index(t => t.CompanyQuestion_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_CompanyQuestionLikes",
                c => new
                    {
                        CompanyQuestionLike_Id = c.Guid(nullable: false),
                        CompanyQuestionLike_IsLiked = c.Boolean(nullable: false),
                        CompanyQuestionLike_IsDisLiked = c.Boolean(nullable: false),
                        CompanyQuestionLike_LikedById = c.Guid(nullable: false),
                        CompanyQuestionLike_QuestionId = c.Guid(nullable: false),
                        CompanyQuestionLike_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CompanyQuestionLike_CreatedOn = c.DateTime(nullable: false),
                        CompanyQuestionLike_ModifiedOn = c.DateTime(nullable: false),
                        CompanyQuestionLike_CreatorIp = c.String(),
                        CompanyQuestionLike_ModifierIp = c.String(),
                        CompanyQuestionLike_ModifyLocked = c.Boolean(nullable: false),
                        CompanyQuestionLike_IsDeleted = c.Boolean(nullable: false),
                        CompanyQuestionLike_ModifierAgent = c.String(),
                        CompanyQuestionLike_CreatorAgent = c.String(),
                        CompanyQuestionLike_Version = c.Int(nullable: false),
                        CompanyQuestionLike_Action = c.Int(nullable: false),
                        CompanyQuestionLike_ModifiedById = c.Guid(),
                        CompanyQuestionLike_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.CompanyQuestionLike_Id)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestionLike_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestionLike_LikedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestionLike_ModifiedById)
                .ForeignKey("dbo.AD_CompanyQuestions", t => t.CompanyQuestionLike_QuestionId)
                .Index(t => t.CompanyQuestionLike_LikedById)
                .Index(t => t.CompanyQuestionLike_QuestionId)
                .Index(t => t.CompanyQuestionLike_ModifiedById)
                .Index(t => t.CompanyQuestionLike_CreatedById);
            
            CreateTable(
                "dbo.AD_CompanyQuestionReports",
                c => new
                    {
                        CompanyQuestionReport_Id = c.Guid(nullable: false),
                        CompanyQuestionReport_Type = c.Int(nullable: false),
                        CompanyQuestionReport_Reason = c.String(maxLength: 1000),
                        CompanyQuestionReport_IsRead = c.Boolean(nullable: false),
                        CompanyQuestionReport_ReportedById = c.Guid(nullable: false),
                        CompanyQuestionReport_ReportedForId = c.Guid(nullable: false),
                        CompanyQuestionReport_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CompanyQuestionReport_CreatedOn = c.DateTime(nullable: false),
                        CompanyQuestionReport_ModifiedOn = c.DateTime(nullable: false),
                        CompanyQuestionReport_CreatorIp = c.String(),
                        CompanyQuestionReport_ModifierIp = c.String(),
                        CompanyQuestionReport_ModifyLocked = c.Boolean(nullable: false),
                        CompanyQuestionReport_IsDeleted = c.Boolean(nullable: false),
                        CompanyQuestionReport_ModifierAgent = c.String(),
                        CompanyQuestionReport_CreatorAgent = c.String(),
                        CompanyQuestionReport_Version = c.Int(nullable: false),
                        CompanyQuestionReport_Action = c.Int(nullable: false),
                        CompanyQuestionReport_ModifiedById = c.Guid(),
                        CompanyQuestionReport_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.CompanyQuestionReport_Id)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestionReport_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestionReport_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestionReport_ReportedById)
                .ForeignKey("dbo.AD_CompanyQuestions", t => t.CompanyQuestionReport_ReportedForId)
                .Index(t => t.CompanyQuestionReport_ReportedById)
                .Index(t => t.CompanyQuestionReport_ReportedForId)
                .Index(t => t.CompanyQuestionReport_ModifiedById)
                .Index(t => t.CompanyQuestionReport_CreatedById);
            
            CreateTable(
                "dbo.AD_CompanyReports",
                c => new
                    {
                        CompanyReport_Id = c.Guid(nullable: false),
                        CompanyReport_Type = c.Int(nullable: false),
                        CompanyReport_Reason = c.String(),
                        CompanyReport_IsRead = c.Boolean(nullable: false),
                        CompanyReport_ReportedById = c.Guid(nullable: false),
                        CompanyReport_ReportedForId = c.Guid(nullable: false),
                        CompanyReport_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CompanyReport_CreatedOn = c.DateTime(nullable: false),
                        CompanyReport_ModifiedOn = c.DateTime(nullable: false),
                        CompanyReport_CreatorIp = c.String(),
                        CompanyReport_ModifierIp = c.String(),
                        CompanyReport_ModifyLocked = c.Boolean(nullable: false),
                        CompanyReport_IsDeleted = c.Boolean(nullable: false),
                        CompanyReport_ModifierAgent = c.String(),
                        CompanyReport_CreatorAgent = c.String(),
                        CompanyReport_Version = c.Int(nullable: false),
                        CompanyReport_Action = c.Int(nullable: false),
                        CompanyReport_ModifiedById = c.Guid(),
                        CompanyReport_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.CompanyReport_Id)
                .ForeignKey("dbo.AD_Users", t => t.CompanyReport_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyReport_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyReport_ReportedById)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyReport_ReportedForId)
                .Index(t => t.CompanyReport_ReportedById)
                .Index(t => t.CompanyReport_ReportedForId)
                .Index(t => t.CompanyReport_ModifiedById)
                .Index(t => t.CompanyReport_CreatedById);
            
            CreateTable(
                "dbo.AD_CompanyReviews",
                c => new
                    {
                        CompanyReview_Id = c.Guid(nullable: false),
                        CompanyReview_Body = c.String(nullable: false, maxLength: 1000),
                        CompanyReview_IsActive = c.Boolean(nullable: false),
                        CompanyReview_CompanyId = c.Guid(nullable: false),
                        CompanyReview_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CompanyReview_CreatedOn = c.DateTime(nullable: false),
                        CompanyReview_ModifiedOn = c.DateTime(nullable: false),
                        CompanyReview_CreatorIp = c.String(),
                        CompanyReview_ModifierIp = c.String(),
                        CompanyReview_ModifyLocked = c.Boolean(nullable: false),
                        CompanyReview_IsDeleted = c.Boolean(nullable: false),
                        CompanyReview_ModifierAgent = c.String(),
                        CompanyReview_CreatorAgent = c.String(),
                        CompanyReview_Version = c.Int(nullable: false),
                        CompanyReview_Action = c.Int(nullable: false),
                        CompanyReview_ModifiedById = c.Guid(),
                        CompanyReview_CreatedById = c.Guid(),
                        Product_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.CompanyReview_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyReview_CompanyId)
                .ForeignKey("dbo.AD_Users", t => t.CompanyReview_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyReview_ModifiedById)
                .ForeignKey("dbo.AD_Products", t => t.Product_Id)
                .Index(t => t.CompanyReview_CompanyId)
                .Index(t => t.CompanyReview_ModifiedById)
                .Index(t => t.CompanyReview_CreatedById)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.AD_CompanySocials",
                c => new
                    {
                        CompanySocial_Id = c.Guid(nullable: false),
                        CompanySocial_TwitterLink = c.String(maxLength: 100),
                        CompanySocial_FacebookLink = c.String(maxLength: 100),
                        CompanySocial_GooglePlusLink = c.String(maxLength: 100),
                        CompanySocial_YoutubeLink = c.String(maxLength: 100),
                        CompanySocial_CompanyId = c.Guid(nullable: false),
                        CompanySocial_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CompanySocial_CreatedOn = c.DateTime(nullable: false),
                        CompanySocial_ModifiedOn = c.DateTime(nullable: false),
                        CompanySocial_CreatorIp = c.String(),
                        CompanySocial_ModifierIp = c.String(),
                        CompanySocial_ModifyLocked = c.Boolean(nullable: false),
                        CompanySocial_IsDeleted = c.Boolean(nullable: false),
                        CompanySocial_ModifierAgent = c.String(),
                        CompanySocial_CreatorAgent = c.String(),
                        CompanySocial_Version = c.Int(nullable: false),
                        CompanySocial_Action = c.Int(nullable: false),
                        CompanySocial_ModifiedById = c.Guid(),
                        CompanySocial_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.CompanySocial_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanySocial_CompanyId)
                .ForeignKey("dbo.AD_Users", t => t.CompanySocial_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanySocial_ModifiedById)
                .Index(t => t.CompanySocial_CompanyId)
                .Index(t => t.CompanySocial_ModifiedById)
                .Index(t => t.CompanySocial_CreatedById);
            
            CreateTable(
                "dbo.AD_CompanyVisits",
                c => new
                    {
                        CompanyVisit_Id = c.Guid(nullable: false),
                        CompanyVisit_IsVisit = c.Boolean(nullable: false),
                        CompanyVisit_VisitedById = c.Guid(nullable: false),
                        CompanyVisit_CompanyId = c.Guid(nullable: false),
                        CompanyVisit_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CompanyVisit_CreatedOn = c.DateTime(nullable: false),
                        CompanyVisit_ModifiedOn = c.DateTime(nullable: false),
                        CompanyVisit_CreatorIp = c.String(),
                        CompanyVisit_ModifierIp = c.String(),
                        CompanyVisit_ModifyLocked = c.Boolean(nullable: false),
                        CompanyVisit_IsDeleted = c.Boolean(nullable: false),
                        CompanyVisit_ModifierAgent = c.String(),
                        CompanyVisit_CreatorAgent = c.String(),
                        CompanyVisit_Version = c.Int(nullable: false),
                        CompanyVisit_Action = c.Int(nullable: false),
                        CompanyVisit_ModifiedById = c.Guid(),
                        CompanyVisit_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.CompanyVisit_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyVisit_CompanyId)
                .ForeignKey("dbo.AD_Users", t => t.CompanyVisit_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyVisit_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.CompanyVisit_VisitedById)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.CompanyVisit_VisitedById)
                .Index(t => t.CompanyVisit_CompanyId)
                .Index(t => t.CompanyVisit_ModifiedById)
                .Index(t => t.CompanyVisit_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_CategoryFollows",
                c => new
                    {
                        CategoryFollow_Id = c.Guid(nullable: false),
                        CategoryFollow_IsFollow = c.Boolean(nullable: false),
                        CategoryFollow_FollowedById = c.Guid(nullable: false),
                        CategoryFollow_CategoryId = c.Guid(nullable: false),
                        CategoryFollow_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CategoryFollow_CreatedOn = c.DateTime(nullable: false),
                        CategoryFollow_ModifiedOn = c.DateTime(nullable: false),
                        CategoryFollow_CreatorIp = c.String(),
                        CategoryFollow_ModifierIp = c.String(),
                        CategoryFollow_ModifyLocked = c.Boolean(nullable: false),
                        CategoryFollow_IsDeleted = c.Boolean(nullable: false),
                        CategoryFollow_ModifierAgent = c.String(),
                        CategoryFollow_CreatorAgent = c.String(),
                        CategoryFollow_Version = c.Int(nullable: false),
                        CategoryFollow_Action = c.Int(nullable: false),
                        CategoryFollow_ModifiedById = c.Guid(),
                        CategoryFollow_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.CategoryFollow_Id)
                .ForeignKey("dbo.AD_Categories", t => t.CategoryFollow_CategoryId)
                .ForeignKey("dbo.AD_Users", t => t.CategoryFollow_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.CategoryFollow_FollowedById)
                .ForeignKey("dbo.AD_Users", t => t.CategoryFollow_ModifiedById)
                .Index(t => t.CategoryFollow_FollowedById)
                .Index(t => t.CategoryFollow_CategoryId)
                .Index(t => t.CategoryFollow_ModifiedById)
                .Index(t => t.CategoryFollow_CreatedById);
            
            CreateTable(
                "dbo.AD_CategoryReviews",
                c => new
                    {
                        CategoryReview_Id = c.Guid(nullable: false),
                        CategoryReview_Body = c.String(nullable: false, maxLength: 1000),
                        CategoryReview_IsActive = c.Boolean(nullable: false),
                        CategoryReview_AuthoredById = c.Guid(nullable: false),
                        CategoryReview_CategoryId = c.Guid(nullable: false),
                        CategoryReview_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CategoryReview_CreatedOn = c.DateTime(nullable: false),
                        CategoryReview_ModifiedOn = c.DateTime(nullable: false),
                        CategoryReview_CreatorIp = c.String(),
                        CategoryReview_ModifierIp = c.String(),
                        CategoryReview_ModifyLocked = c.Boolean(nullable: false),
                        CategoryReview_IsDeleted = c.Boolean(nullable: false),
                        CategoryReview_ModifierAgent = c.String(),
                        CategoryReview_CreatorAgent = c.String(),
                        CategoryReview_Version = c.Int(nullable: false),
                        CategoryReview_Action = c.Int(nullable: false),
                        CategoryReview_ModifiedById = c.Guid(),
                        CategoryReview_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.CategoryReview_Id)
                .ForeignKey("dbo.AD_Users", t => t.CategoryReview_AuthoredById)
                .ForeignKey("dbo.AD_Categories", t => t.CategoryReview_CategoryId)
                .ForeignKey("dbo.AD_Users", t => t.CategoryReview_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.CategoryReview_ModifiedById)
                .Index(t => t.CategoryReview_AuthoredById)
                .Index(t => t.CategoryReview_CategoryId)
                .Index(t => t.CategoryReview_ModifiedById)
                .Index(t => t.CategoryReview_CreatedById);
            
            CreateTable(
                "dbo.AD_ProductComments",
                c => new
                    {
                        ProductComment_Id = c.Guid(nullable: false),
                        ProductComment_Body = c.String(nullable: false, maxLength: 1000),
                        ProductComment_IsApproved = c.Boolean(nullable: false),
                        ProductComment_Status = c.Int(nullable: false),
                        ProductComment_CommentedById = c.Guid(nullable: false),
                        ProductComment_ApprovedById = c.Guid(nullable: false),
                        ProductComment_ProductId = c.Guid(nullable: false),
                        ProductComment_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        ProductComment_CreatedOn = c.DateTime(nullable: false),
                        ProductComment_ModifiedOn = c.DateTime(nullable: false),
                        ProductComment_CreatorIp = c.String(),
                        ProductComment_ModifierIp = c.String(),
                        ProductComment_ModifyLocked = c.Boolean(nullable: false),
                        ProductComment_IsDeleted = c.Boolean(nullable: false),
                        ProductComment_ModifierAgent = c.String(),
                        ProductComment_CreatorAgent = c.String(),
                        ProductComment_Version = c.Int(nullable: false),
                        ProductComment_Action = c.Int(nullable: false),
                        ProductComment_ModifiedById = c.Guid(),
                        ProductComment_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.ProductComment_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductComment_ApprovedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductComment_CommentedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductComment_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductComment_ModifiedById)
                .ForeignKey("dbo.AD_Products", t => t.ProductComment_ProductId)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.ProductComment_CommentedById)
                .Index(t => t.ProductComment_ApprovedById)
                .Index(t => t.ProductComment_ProductId)
                .Index(t => t.ProductComment_ModifiedById)
                .Index(t => t.ProductComment_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_ProductImages",
                c => new
                    {
                        ProductImage_Id = c.Guid(nullable: false),
                        ProductImage_Title = c.String(maxLength: 100),
                        ProductImage_FileName = c.String(nullable: false, maxLength: 100),
                        ProductImage_FileSize = c.String(nullable: false, maxLength: 10),
                        ProductImage_FileDimension = c.String(nullable: false, maxLength: 10),
                        ProductImage_Order = c.Int(nullable: false),
                        ProductImage_IsWatermarked = c.Boolean(nullable: false),
                        ProductImage_ProductId = c.Guid(nullable: false),
                        ProductImage_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        ProductImage_CreatedOn = c.DateTime(nullable: false),
                        ProductImage_ModifiedOn = c.DateTime(nullable: false),
                        ProductImage_CreatorIp = c.String(),
                        ProductImage_ModifierIp = c.String(),
                        ProductImage_ModifyLocked = c.Boolean(nullable: false),
                        ProductImage_IsDeleted = c.Boolean(nullable: false),
                        ProductImage_ModifierAgent = c.String(),
                        ProductImage_CreatorAgent = c.String(),
                        ProductImage_Version = c.Int(nullable: false),
                        ProductImage_Action = c.Int(nullable: false),
                        ProductImage_ModifiedById = c.Guid(),
                        ProductImage_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.ProductImage_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductImage_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductImage_ModifiedById)
                .ForeignKey("dbo.AD_Products", t => t.ProductImage_ProductId)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.ProductImage_ProductId)
                .Index(t => t.ProductImage_ModifiedById)
                .Index(t => t.ProductImage_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_ProductLikes",
                c => new
                    {
                        ProductLike_Id = c.Guid(nullable: false),
                        ProductLike_IsLike = c.Boolean(nullable: false),
                        ProductLike_IsDisLike = c.Boolean(nullable: false),
                        ProductLike_LikedById = c.Guid(nullable: false),
                        ProductLike_ProductId = c.Guid(nullable: false),
                        ProductLike_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        ProductLike_CreatedOn = c.DateTime(nullable: false),
                        ProductLike_ModifiedOn = c.DateTime(nullable: false),
                        ProductLike_CreatorIp = c.String(),
                        ProductLike_ModifierIp = c.String(),
                        ProductLike_ModifyLocked = c.Boolean(nullable: false),
                        ProductLike_IsDeleted = c.Boolean(nullable: false),
                        ProductLike_ModifierAgent = c.String(),
                        ProductLike_CreatorAgent = c.String(),
                        ProductLike_Version = c.Int(nullable: false),
                        ProductLike_Action = c.Int(nullable: false),
                        ProductLike_ModifiedById = c.Guid(),
                        ProductLike_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.ProductLike_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductLike_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductLike_LikedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductLike_ModifiedById)
                .ForeignKey("dbo.AD_Products", t => t.ProductLike_ProductId)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.ProductLike_LikedById)
                .Index(t => t.ProductLike_ProductId)
                .Index(t => t.ProductLike_ModifiedById)
                .Index(t => t.ProductLike_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_ProductSpecifications",
                c => new
                    {
                        ProductSpecification_Id = c.Guid(nullable: false),
                        ProductSpecification_Value = c.String(),
                        ProductSpecification_ProductId = c.Guid(nullable: false),
                        ProductSpecification_SpecificationId = c.Guid(nullable: false),
                        ProductSpecification_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        ProductSpecification_CreatedOn = c.DateTime(nullable: false),
                        ProductSpecification_ModifiedOn = c.DateTime(nullable: false),
                        ProductSpecification_CreatorIp = c.String(),
                        ProductSpecification_ModifierIp = c.String(),
                        ProductSpecification_ModifyLocked = c.Boolean(nullable: false),
                        ProductSpecification_IsDeleted = c.Boolean(nullable: false),
                        ProductSpecification_ModifierAgent = c.String(),
                        ProductSpecification_CreatorAgent = c.String(),
                        ProductSpecification_Version = c.Int(nullable: false),
                        ProductSpecification_Action = c.Int(nullable: false),
                        ProductSpecification_ModifiedById = c.Guid(),
                        ProductSpecification_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.ProductSpecification_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductSpecification_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductSpecification_ModifiedById)
                .ForeignKey("dbo.AD_Products", t => t.ProductSpecification_ProductId)
                .ForeignKey("dbo.AD_Specifications", t => t.ProductSpecification_SpecificationId)
                .Index(t => t.ProductSpecification_ProductId)
                .Index(t => t.ProductSpecification_SpecificationId)
                .Index(t => t.ProductSpecification_ModifiedById)
                .Index(t => t.ProductSpecification_CreatedById);
            
            CreateTable(
                "dbo.AD_Specifications",
                c => new
                    {
                        Specification_Id = c.Guid(nullable: false),
                        Specification_Title = c.String(nullable: false, maxLength: 100),
                        Specification_Type = c.Int(nullable: false),
                        Specification_Description = c.String(),
                        Specification_Order = c.Int(nullable: false),
                        Specification_CategoryId = c.Guid(nullable: false),
                        Specification_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Specification_CreatedOn = c.DateTime(nullable: false),
                        Specification_ModifiedOn = c.DateTime(nullable: false),
                        Specification_CreatorIp = c.String(),
                        Specification_ModifierIp = c.String(),
                        Specification_ModifyLocked = c.Boolean(nullable: false),
                        Specification_IsDeleted = c.Boolean(nullable: false),
                        Specification_ModifierAgent = c.String(),
                        Specification_CreatorAgent = c.String(),
                        Specification_Version = c.Int(nullable: false),
                        Specification_Action = c.Int(nullable: false),
                        Specification_ModifiedById = c.Guid(),
                        Specification_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.Specification_Id)
                .ForeignKey("dbo.AD_Categories", t => t.Specification_CategoryId)
                .ForeignKey("dbo.AD_Users", t => t.Specification_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Specification_ModifiedById)
                .Index(t => t.Specification_CategoryId)
                .Index(t => t.Specification_ModifiedById)
                .Index(t => t.Specification_CreatedById);
            
            CreateTable(
                "dbo.AD_ProductReports",
                c => new
                    {
                        ProductReport_Id = c.Guid(nullable: false),
                        ProductReport_Type = c.Int(nullable: false),
                        ProductReport_Reason = c.String(maxLength: 100),
                        ProductReport_IsRead = c.Boolean(nullable: false),
                        ProductReport_ReportedById = c.Guid(nullable: false),
                        ProductReport_ReportedForId = c.Guid(nullable: false),
                        ProductReport_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        ProductReport_CreatedOn = c.DateTime(nullable: false),
                        ProductReport_ModifiedOn = c.DateTime(nullable: false),
                        ProductReport_CreatorIp = c.String(),
                        ProductReport_ModifierIp = c.String(),
                        ProductReport_ModifyLocked = c.Boolean(nullable: false),
                        ProductReport_IsDeleted = c.Boolean(nullable: false),
                        ProductReport_ModifierAgent = c.String(),
                        ProductReport_CreatorAgent = c.String(),
                        ProductReport_Version = c.Int(nullable: false),
                        ProductReport_Action = c.Int(nullable: false),
                        ProductReport_ModifiedById = c.Guid(),
                        ProductReport_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.ProductReport_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductReport_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductReport_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductReport_ReportedById)
                .ForeignKey("dbo.AD_Products", t => t.ProductReport_ReportedForId)
                .Index(t => t.ProductReport_ReportedById)
                .Index(t => t.ProductReport_ReportedForId)
                .Index(t => t.ProductReport_ModifiedById)
                .Index(t => t.ProductReport_CreatedById);
            
            CreateTable(
                "dbo.AD_ProductShares",
                c => new
                    {
                        ProductShare_Id = c.Guid(nullable: false),
                        ProductShare_IsShare = c.Boolean(nullable: false),
                        ProductShare_Type = c.Int(nullable: false),
                        ProductShare_SharedById = c.Guid(nullable: false),
                        ProductShare_ProductId = c.Guid(nullable: false),
                        ProductShare_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        ProductShare_CreatedOn = c.DateTime(nullable: false),
                        ProductShare_ModifiedOn = c.DateTime(nullable: false),
                        ProductShare_CreatorIp = c.String(),
                        ProductShare_ModifierIp = c.String(),
                        ProductShare_ModifyLocked = c.Boolean(nullable: false),
                        ProductShare_IsDeleted = c.Boolean(nullable: false),
                        ProductShare_ModifierAgent = c.String(),
                        ProductShare_CreatorAgent = c.String(),
                        ProductShare_Version = c.Int(nullable: false),
                        ProductShare_Action = c.Int(nullable: false),
                        ProductShare_ModifiedById = c.Guid(),
                        ProductShare_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.ProductShare_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductShare_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductShare_ModifiedById)
                .ForeignKey("dbo.AD_Products", t => t.ProductShare_ProductId)
                .ForeignKey("dbo.AD_Users", t => t.ProductShare_SharedById)
                .Index(t => t.ProductShare_SharedById)
                .Index(t => t.ProductShare_ProductId)
                .Index(t => t.ProductShare_ModifiedById)
                .Index(t => t.ProductShare_CreatedById);
            
            CreateTable(
                "dbo.AD_ProductVisits",
                c => new
                    {
                        ProductVisit_Id = c.Guid(nullable: false),
                        ProductVisit_IsVisit = c.Boolean(nullable: false),
                        ProductVisit_VisitedById = c.Guid(nullable: false),
                        ProductVisit_ProductId = c.Guid(nullable: false),
                        ProductVisit_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        ProductVisit_CreatedOn = c.DateTime(nullable: false),
                        ProductVisit_ModifiedOn = c.DateTime(nullable: false),
                        ProductVisit_CreatorIp = c.String(),
                        ProductVisit_ModifierIp = c.String(),
                        ProductVisit_ModifyLocked = c.Boolean(nullable: false),
                        ProductVisit_IsDeleted = c.Boolean(nullable: false),
                        ProductVisit_ModifierAgent = c.String(),
                        ProductVisit_CreatorAgent = c.String(),
                        ProductVisit_Version = c.Int(nullable: false),
                        ProductVisit_Action = c.Int(nullable: false),
                        ProductVisit_ModifiedById = c.Guid(),
                        ProductVisit_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.ProductVisit_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductVisit_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductVisit_ModifiedById)
                .ForeignKey("dbo.AD_Products", t => t.ProductVisit_ProductId)
                .ForeignKey("dbo.AD_Users", t => t.ProductVisit_VisitedById)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.ProductVisit_VisitedById)
                .Index(t => t.ProductVisit_ProductId)
                .Index(t => t.ProductVisit_ModifiedById)
                .Index(t => t.ProductVisit_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_Tags",
                c => new
                    {
                        Tag_Id = c.Guid(nullable: false),
                        Tag_Code = c.String(nullable: false, maxLength: 100),
                        Tag_Title = c.String(),
                        Tag_Description = c.String(),
                        Tag_CostRialValue = c.String(),
                        Tag_CostUsdValue = c.Long(nullable: false),
                        Tag_DurationDay = c.String(),
                        Tag_Type = c.Int(nullable: false),
                        Tag_IsActive = c.Boolean(nullable: false),
                        Tag_StartedOn = c.DateTime(nullable: false),
                        Tag_ExpiredOn = c.DateTime(nullable: false),
                        Tag_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Tag_CreatedOn = c.DateTime(nullable: false),
                        Tag_ModifiedOn = c.DateTime(nullable: false),
                        Tag_CreatorIp = c.String(),
                        Tag_ModifierIp = c.String(),
                        Tag_ModifyLocked = c.Boolean(nullable: false),
                        Tag_IsDeleted = c.Boolean(nullable: false),
                        Tag_ModifierAgent = c.String(),
                        Tag_CreatorAgent = c.String(),
                        Tag_Version = c.Int(nullable: false),
                        Tag_Action = c.Int(nullable: false),
                        Tag_ModifiedById = c.Guid(),
                        Tag_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.Tag_Id)
                .ForeignKey("dbo.AD_Users", t => t.Tag_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Tag_ModifiedById)
                .Index(t => t.Tag_ModifiedById)
                .Index(t => t.Tag_CreatedById);
            
            CreateTable(
                "dbo.AD_UserClaims",
                c => new
                    {
                        UserClaim_Id = c.Int(nullable: false, identity: true),
                        UserClaim_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        UserClaim_UserId = c.Guid(nullable: false),
                        UserClaim_ClaimType = c.String(),
                        UserClaim_ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.UserClaim_Id)
                .ForeignKey("dbo.AD_Users", t => t.UserClaim_UserId)
                .Index(t => t.UserClaim_UserId);
            
            CreateTable(
                "dbo.AD_UserLogins",
                c => new
                    {
                        UserLogin_UserId = c.Guid(nullable: false),
                        UserLogin_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        UserLogin_LoginProvider = c.String(),
                        UserLogin_ProviderKey = c.String(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.UserLogin_UserId)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_ProductCommentLikes",
                c => new
                    {
                        ProductCommentLike_Id = c.Guid(nullable: false),
                        ProductCommentLike_IsLike = c.Boolean(nullable: false),
                        ProductCommentLike_IsDisLike = c.Boolean(nullable: false),
                        ProductCommentLike_LikedById = c.Guid(nullable: false),
                        ProductCommentLike_CommentId = c.Guid(nullable: false),
                        ProductCommentLike_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        ProductCommentLike_CreatedOn = c.DateTime(nullable: false),
                        ProductCommentLike_ModifiedOn = c.DateTime(nullable: false),
                        ProductCommentLike_CreatorIp = c.String(),
                        ProductCommentLike_ModifierIp = c.String(),
                        ProductCommentLike_ModifyLocked = c.Boolean(nullable: false),
                        ProductCommentLike_IsDeleted = c.Boolean(nullable: false),
                        ProductCommentLike_ModifierAgent = c.String(),
                        ProductCommentLike_CreatorAgent = c.String(),
                        ProductCommentLike_Version = c.Int(nullable: false),
                        ProductCommentLike_Action = c.Int(nullable: false),
                        ProductCommentLike_ModifiedById = c.Guid(),
                        ProductCommentLike_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.ProductCommentLike_Id)
                .ForeignKey("dbo.AD_ProductComments", t => t.ProductCommentLike_CommentId)
                .ForeignKey("dbo.AD_Users", t => t.ProductCommentLike_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductCommentLike_LikedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductCommentLike_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.ProductCommentLike_LikedById)
                .Index(t => t.ProductCommentLike_CommentId)
                .Index(t => t.ProductCommentLike_ModifiedById)
                .Index(t => t.ProductCommentLike_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_UserProfiles",
                c => new
                    {
                        UserProfile_Id = c.Guid(nullable: false),
                        UserProfile_Code = c.String(),
                        UserProfile_FirstName = c.String(),
                        UserProfile_LastName = c.String(),
                        UserProfile_DisplayName = c.String(),
                        UserProfile_NationalCode = c.String(),
                        UserProfile_BirthOn = c.DateTime(),
                        UserProfile_MarriedOn = c.DateTime(),
                        UserProfile_AvatarFileName = c.String(),
                        UserProfile_IsActive = c.Boolean(nullable: false),
                        UserProfile_Gender = c.Int(),
                        UserProfile_AboutMe = c.String(maxLength: 1000),
                        UserProfile_OwnedById = c.Guid(nullable: false),
                        UserProfile_AddressId = c.Guid(nullable: false),
                        UserProfile_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        UserProfile_CreatedOn = c.DateTime(nullable: false),
                        UserProfile_ModifiedOn = c.DateTime(nullable: false),
                        UserProfile_CreatorIp = c.String(),
                        UserProfile_ModifierIp = c.String(),
                        UserProfile_ModifyLocked = c.Boolean(nullable: false),
                        UserProfile_IsDeleted = c.Boolean(nullable: false),
                        UserProfile_ModifierAgent = c.String(),
                        UserProfile_CreatorAgent = c.String(),
                        UserProfile_Version = c.Int(nullable: false),
                        UserProfile_Action = c.Int(nullable: false),
                        UserProfile_ModifiedById = c.Guid(),
                        UserProfile_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.UserProfile_Id)
                .ForeignKey("dbo.AD_Addresses", t => t.UserProfile_AddressId)
                .ForeignKey("dbo.AD_Users", t => t.UserProfile_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.UserProfile_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.UserProfile_OwnedById)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.UserProfile_OwnedById)
                .Index(t => t.UserProfile_AddressId)
                .Index(t => t.UserProfile_ModifiedById)
                .Index(t => t.UserProfile_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_UserReports",
                c => new
                    {
                        UserReport_Id = c.Guid(nullable: false),
                        UserReport_Type = c.Int(nullable: false),
                        UserReport_Reason = c.String(),
                        UserReport_IsRead = c.Boolean(nullable: false),
                        UserReport_ReportedById = c.Guid(nullable: false),
                        UserReport_ReportedForId = c.Guid(nullable: false),
                        UserReport_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        UserReport_CreatedOn = c.DateTime(nullable: false),
                        UserReport_ModifiedOn = c.DateTime(nullable: false),
                        UserReport_CreatorIp = c.String(),
                        UserReport_ModifierIp = c.String(),
                        UserReport_ModifyLocked = c.Boolean(nullable: false),
                        UserReport_IsDeleted = c.Boolean(nullable: false),
                        UserReport_ModifierAgent = c.String(),
                        UserReport_CreatorAgent = c.String(),
                        UserReport_Version = c.Int(nullable: false),
                        UserReport_Action = c.Int(nullable: false),
                        UserReport_ModifiedById = c.Guid(),
                        UserReport_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.UserReport_Id)
                .ForeignKey("dbo.AD_Users", t => t.UserReport_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.UserReport_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.UserReport_ReportedById)
                .ForeignKey("dbo.AD_Users", t => t.UserReport_ReportedForId)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.UserReport_ReportedById)
                .Index(t => t.UserReport_ReportedForId)
                .Index(t => t.UserReport_ModifiedById)
                .Index(t => t.UserReport_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_UserRoles",
                c => new
                    {
                        UserRole_RoleId = c.Guid(nullable: false),
                        UserRole_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        UserRole_UserId = c.Guid(nullable: false),
                        Role_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.UserRole_RoleId)
                .ForeignKey("dbo.AD_Users", t => t.UserRole_UserId)
                .ForeignKey("dbo.AD_Roles", t => t.Role_Id)
                .Index(t => t.UserRole_UserId)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.AD_UserSettings",
                c => new
                    {
                        UserSetting_Id = c.Guid(nullable: false),
                        UserSetting_Language = c.Int(nullable: false),
                        UserSetting_Theme = c.Int(nullable: false),
                        UserSetting_OwnedById = c.Guid(nullable: false),
                        UserSetting_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        UserSetting_CreatedOn = c.DateTime(nullable: false),
                        UserSetting_ModifiedOn = c.DateTime(nullable: false),
                        UserSetting_CreatorIp = c.String(),
                        UserSetting_ModifierIp = c.String(),
                        UserSetting_ModifyLocked = c.Boolean(nullable: false),
                        UserSetting_IsDeleted = c.Boolean(nullable: false),
                        UserSetting_ModifierAgent = c.String(),
                        UserSetting_CreatorAgent = c.String(),
                        UserSetting_Version = c.Int(nullable: false),
                        UserSetting_Action = c.Int(nullable: false),
                        UserSetting_ModifiedById = c.Guid(),
                        UserSetting_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.UserSetting_Id)
                .ForeignKey("dbo.AD_Users", t => t.UserSetting_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.UserSetting_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.UserSetting_OwnedById)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.UserSetting_OwnedById)
                .Index(t => t.UserSetting_ModifiedById)
                .Index(t => t.UserSetting_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_UserSocials",
                c => new
                    {
                        UserSocial_Id = c.Guid(nullable: false),
                        UserSocial_TwitterLink = c.String(maxLength: 100),
                        UserSocial_FacebookLink = c.String(maxLength: 100),
                        UserSocial_GooglePlusLink = c.String(maxLength: 100),
                        UserSocial_YoutubeLink = c.String(maxLength: 100),
                        UserSocial_OwnedById = c.Guid(nullable: false),
                        UserSocial_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        UserSocial_CreatedOn = c.DateTime(nullable: false),
                        UserSocial_ModifiedOn = c.DateTime(nullable: false),
                        UserSocial_CreatorIp = c.String(),
                        UserSocial_ModifierIp = c.String(),
                        UserSocial_ModifyLocked = c.Boolean(nullable: false),
                        UserSocial_IsDeleted = c.Boolean(nullable: false),
                        UserSocial_ModifierAgent = c.String(),
                        UserSocial_CreatorAgent = c.String(),
                        UserSocial_Version = c.Int(nullable: false),
                        UserSocial_Action = c.Int(nullable: false),
                        UserSocial_ModifiedById = c.Guid(),
                        UserSocial_CreatedById = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.UserSocial_Id)
                .ForeignKey("dbo.AD_Users", t => t.UserSocial_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.UserSocial_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.UserSocial_OwnedById)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.UserSocial_OwnedById)
                .Index(t => t.UserSocial_ModifiedById)
                .Index(t => t.UserSocial_CreatedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_SpecificationOptions",
                c => new
                    {
                        SpecificationOption_Id = c.Guid(nullable: false),
                        SpecificationOption_Title = c.String(nullable: false, maxLength: 100),
                        SpecificationOption_Description = c.String(),
                        SpecificationOption_SpecificationId = c.Guid(nullable: false),
                        SpecificationOption_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        SpecificationOption_CreatedOn = c.DateTime(nullable: false),
                        SpecificationOption_ModifiedOn = c.DateTime(nullable: false),
                        SpecificationOption_CreatorIp = c.String(),
                        SpecificationOption_ModifierIp = c.String(),
                        SpecificationOption_ModifyLocked = c.Boolean(nullable: false),
                        SpecificationOption_IsDeleted = c.Boolean(nullable: false),
                        SpecificationOption_ModifierAgent = c.String(),
                        SpecificationOption_CreatorAgent = c.String(),
                        SpecificationOption_Version = c.Int(nullable: false),
                        SpecificationOption_Action = c.Int(nullable: false),
                        SpecificationOption_ModifiedById = c.Guid(),
                        SpecificationOption_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.SpecificationOption_Id)
                .ForeignKey("dbo.AD_Users", t => t.SpecificationOption_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.SpecificationOption_ModifiedById)
                .ForeignKey("dbo.AD_Specifications", t => t.SpecificationOption_SpecificationId)
                .Index(t => t.SpecificationOption_SpecificationId)
                .Index(t => t.SpecificationOption_ModifiedById)
                .Index(t => t.SpecificationOption_CreatedById);
            
            CreateTable(
                "dbo.AD_Payments",
                c => new
                    {
                        Payment_Id = c.Guid(nullable: false),
                        Payment_Status = c.Int(nullable: false),
                        Payment_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Payment_CreatedOn = c.DateTime(nullable: false),
                        Payment_ModifiedOn = c.DateTime(nullable: false),
                        Payment_CreatorIp = c.String(),
                        Payment_ModifierIp = c.String(),
                        Payment_ModifyLocked = c.Boolean(nullable: false),
                        Payment_IsDeleted = c.Boolean(nullable: false),
                        Payment_ModifierAgent = c.String(),
                        Payment_CreatorAgent = c.String(),
                        Payment_Version = c.Int(nullable: false),
                        Payment_Action = c.Int(nullable: false),
                        Payment_ModifiedById = c.Guid(),
                        Payment_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.Payment_Id)
                .ForeignKey("dbo.AD_Users", t => t.Payment_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Payment_ModifiedById)
                .Index(t => t.Payment_ModifiedById)
                .Index(t => t.Payment_CreatedById);
            
            CreateTable(
                "dbo.AD_PaymentTransactions",
                c => new
                    {
                        PaymentTransaction_Id = c.Guid(nullable: false),
                        PaymentTransaction_ReferenceCode = c.String(),
                        PaymentTransaction_Value = c.Long(nullable: false),
                        PaymentTransaction_IsSuccess = c.Boolean(nullable: false),
                        PaymentTransaction_PayedById = c.Guid(nullable: false),
                        PaymentTransaction_BudgetId = c.Guid(nullable: false),
                        PaymentTransaction_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        PaymentTransaction_CreatedOn = c.DateTime(nullable: false),
                        PaymentTransaction_ModifiedOn = c.DateTime(nullable: false),
                        PaymentTransaction_CreatorIp = c.String(),
                        PaymentTransaction_ModifierIp = c.String(),
                        PaymentTransaction_ModifyLocked = c.Boolean(nullable: false),
                        PaymentTransaction_IsDeleted = c.Boolean(nullable: false),
                        PaymentTransaction_ModifierAgent = c.String(),
                        PaymentTransaction_CreatorAgent = c.String(),
                        PaymentTransaction_Version = c.Int(nullable: false),
                        PaymentTransaction_Action = c.Int(nullable: false),
                        PaymentTransaction_ModifiedById = c.Guid(),
                        PaymentTransaction_CreatedById = c.Guid(),
                        Payment_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.PaymentTransaction_Id)
                .ForeignKey("dbo.AD_UserBudgets", t => t.PaymentTransaction_BudgetId)
                .ForeignKey("dbo.AD_Users", t => t.PaymentTransaction_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.PaymentTransaction_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.PaymentTransaction_PayedById)
                .ForeignKey("dbo.AD_Payments", t => t.Payment_Id)
                .Index(t => t.PaymentTransaction_PayedById)
                .Index(t => t.PaymentTransaction_BudgetId)
                .Index(t => t.PaymentTransaction_ModifiedById)
                .Index(t => t.PaymentTransaction_CreatedById)
                .Index(t => t.Payment_Id);
            
            CreateTable(
                "dbo.AD_BannedWords",
                c => new
                    {
                        BannedWord_Id = c.Guid(nullable: false),
                        BannedWord_BadWord = c.String(),
                        BannedWord_GoodWord = c.String(),
                        BannedWord_IsStopWord = c.Boolean(nullable: false),
                        BannedWord_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        BannedWord_CreatedOn = c.DateTime(nullable: false),
                        BannedWord_ModifiedOn = c.DateTime(nullable: false),
                        BannedWord_CreatorIp = c.String(),
                        BannedWord_ModifierIp = c.String(),
                        BannedWord_ModifyLocked = c.Boolean(nullable: false),
                        BannedWord_IsDeleted = c.Boolean(nullable: false),
                        BannedWord_ModifierAgent = c.String(),
                        BannedWord_CreatorAgent = c.String(),
                        BannedWord_Version = c.Int(nullable: false),
                        BannedWord_Action = c.Int(nullable: false),
                        BannedWord_ModifiedById = c.Guid(),
                        BannedWord_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.BannedWord_Id)
                .ForeignKey("dbo.AD_Users", t => t.BannedWord_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.BannedWord_ModifiedById)
                .Index(t => t.BannedWord_ModifiedById)
                .Index(t => t.BannedWord_CreatedById);
            
            CreateTable(
                "dbo.AD_Emails",
                c => new
                    {
                        Email_Id = c.Guid(nullable: false),
                        Email_Subject = c.String(nullable: false, maxLength: 100),
                        Email_Body = c.String(nullable: false, maxLength: 1000),
                        Email_IsSend = c.Boolean(nullable: false),
                        Email_SentById = c.Guid(nullable: false),
                        Email_RecievedById = c.Guid(nullable: false),
                        Email_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Email_CreatedOn = c.DateTime(nullable: false),
                        Email_ModifiedOn = c.DateTime(nullable: false),
                        Email_CreatorIp = c.String(),
                        Email_ModifierIp = c.String(),
                        Email_ModifyLocked = c.Boolean(nullable: false),
                        Email_IsDeleted = c.Boolean(nullable: false),
                        Email_ModifierAgent = c.String(),
                        Email_CreatorAgent = c.String(),
                        Email_Version = c.Int(nullable: false),
                        Email_Action = c.Int(nullable: false),
                        Email_ModifiedById = c.Guid(),
                        Email_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.Email_Id)
                .ForeignKey("dbo.AD_Users", t => t.Email_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Email_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.Email_RecievedById)
                .ForeignKey("dbo.AD_Users", t => t.Email_SentById)
                .Index(t => t.Email_SentById)
                .Index(t => t.Email_RecievedById)
                .Index(t => t.Email_ModifiedById)
                .Index(t => t.Email_CreatedById);
            
            CreateTable(
                "dbo.AD_Ratings",
                c => new
                    {
                        Rating_Id = c.Guid(nullable: false),
                        Rating_Status = c.Int(nullable: false),
                        Rating_RatedById = c.Guid(nullable: false),
                        Rating_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Rating_CreatedOn = c.DateTime(nullable: false),
                        Rating_ModifiedOn = c.DateTime(nullable: false),
                        Rating_CreatorIp = c.String(),
                        Rating_ModifierIp = c.String(),
                        Rating_ModifyLocked = c.Boolean(nullable: false),
                        Rating_IsDeleted = c.Boolean(nullable: false),
                        Rating_ModifierAgent = c.String(),
                        Rating_CreatorAgent = c.String(),
                        Rating_Version = c.Int(nullable: false),
                        Rating_Action = c.Int(nullable: false),
                        Rating_ModifiedById = c.Guid(),
                        Rating_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.Rating_Id)
                .ForeignKey("dbo.AD_Users", t => t.Rating_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Rating_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.Rating_RatedById)
                .Index(t => t.Rating_RatedById)
                .Index(t => t.Rating_ModifiedById)
                .Index(t => t.Rating_CreatedById);
            
            CreateTable(
                "dbo.AD_Sms",
                c => new
                    {
                        Sms_Id = c.Guid(nullable: false),
                        Sms_Subject = c.String(),
                        Sms_Body = c.String(nullable: false, maxLength: 1000),
                        Sms_IsSend = c.Boolean(nullable: false),
                        Sms_SentById = c.Guid(nullable: false),
                        Sms_RecievedById = c.Guid(nullable: false),
                        Sms_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Sms_CreatedOn = c.DateTime(nullable: false),
                        Sms_ModifiedOn = c.DateTime(nullable: false),
                        Sms_CreatorIp = c.String(),
                        Sms_ModifierIp = c.String(),
                        Sms_ModifyLocked = c.Boolean(nullable: false),
                        Sms_IsDeleted = c.Boolean(nullable: false),
                        Sms_ModifierAgent = c.String(),
                        Sms_CreatorAgent = c.String(),
                        Sms_Version = c.Int(nullable: false),
                        Sms_Action = c.Int(nullable: false),
                        Sms_ModifiedById = c.Guid(),
                        Sms_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.Sms_Id)
                .ForeignKey("dbo.AD_Users", t => t.Sms_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Sms_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.Sms_RecievedById)
                .ForeignKey("dbo.AD_Users", t => t.Sms_SentById)
                .Index(t => t.Sms_SentById)
                .Index(t => t.Sms_RecievedById)
                .Index(t => t.Sms_ModifiedById)
                .Index(t => t.Sms_CreatedById);
            
            CreateTable(
                "dbo.AD_Conversations",
                c => new
                    {
                        Conversation_Id = c.Guid(nullable: false),
                        Conversation_Title = c.String(maxLength: 100),
                        Conversation_Body = c.String(nullable: false, maxLength: 1000),
                        Conversation_IsRead = c.Boolean(nullable: false),
                        Conversation_IsDeletedBySender = c.Boolean(nullable: false),
                        Conversation_IsDeletedByReceiver = c.Boolean(nullable: false),
                        Conversation_SentOn = c.DateTime(nullable: false),
                        Conversation_SentById = c.Guid(nullable: false),
                        Conversation_ReceivedById = c.Guid(nullable: false),
                        Conversation_ReplyId = c.Guid(nullable: false),
                        Conversation_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Conversation_CreatedOn = c.DateTime(nullable: false),
                        Conversation_ModifiedOn = c.DateTime(nullable: false),
                        Conversation_CreatorIp = c.String(),
                        Conversation_ModifierIp = c.String(),
                        Conversation_ModifyLocked = c.Boolean(nullable: false),
                        Conversation_IsDeleted = c.Boolean(nullable: false),
                        Conversation_ModifierAgent = c.String(),
                        Conversation_CreatorAgent = c.String(),
                        Conversation_Version = c.Int(nullable: false),
                        Conversation_Action = c.Int(nullable: false),
                        Conversation_ModifiedById = c.Guid(),
                        Conversation_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.Conversation_Id)
                .ForeignKey("dbo.AD_Conversations", t => t.Conversation_ReplyId)
                .ForeignKey("dbo.AD_Users", t => t.Conversation_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Conversation_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.Conversation_ReceivedById)
                .ForeignKey("dbo.AD_Users", t => t.Conversation_SentById)
                .Index(t => t.Conversation_SentById)
                .Index(t => t.Conversation_ReceivedById)
                .Index(t => t.Conversation_ReplyId)
                .Index(t => t.Conversation_ModifiedById)
                .Index(t => t.Conversation_CreatedById);
            
            CreateTable(
                "dbo.AD_News",
                c => new
                    {
                        News_Id = c.Guid(nullable: false),
                        News_Title = c.String(maxLength: 100),
                        News_Message = c.String(nullable: false, maxLength: 1000),
                        News_IsActive = c.Boolean(nullable: false),
                        News_ExpiredOn = c.DateTime(),
                        News_OwnedById = c.Guid(nullable: false),
                        News_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        News_CreatedOn = c.DateTime(nullable: false),
                        News_ModifiedOn = c.DateTime(nullable: false),
                        News_CreatorIp = c.String(),
                        News_ModifierIp = c.String(),
                        News_ModifyLocked = c.Boolean(nullable: false),
                        News_IsDeleted = c.Boolean(nullable: false),
                        News_ModifierAgent = c.String(),
                        News_CreatorAgent = c.String(),
                        News_Version = c.Int(nullable: false),
                        News_Action = c.Int(nullable: false),
                        News_ModifiedById = c.Guid(),
                        News_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.News_Id)
                .ForeignKey("dbo.AD_Users", t => t.News_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.News_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.News_OwnedById)
                .Index(t => t.News_OwnedById)
                .Index(t => t.News_ModifiedById)
                .Index(t => t.News_CreatedById);
            
            CreateTable(
                "dbo.AD_Statistics",
                c => new
                    {
                        Statistic_Id = c.Guid(nullable: false),
                        Statistic_Ip = c.String(nullable: false, maxLength: 100),
                        Statistic_Browser = c.String(nullable: false, maxLength: 100),
                        Statistic_Agent = c.String(nullable: false, maxLength: 100),
                        Statistic_SearchEngine = c.String(maxLength: 100),
                        Statistic_Keyword = c.String(maxLength: 100),
                        Statistic_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Statistic_CreatedOn = c.DateTime(nullable: false),
                        Statistic_ModifiedOn = c.DateTime(nullable: false),
                        Statistic_CreatorIp = c.String(),
                        Statistic_ModifierIp = c.String(),
                        Statistic_ModifyLocked = c.Boolean(nullable: false),
                        Statistic_IsDeleted = c.Boolean(nullable: false),
                        Statistic_ModifierAgent = c.String(),
                        Statistic_CreatorAgent = c.String(),
                        Statistic_Version = c.Int(nullable: false),
                        Statistic_Action = c.Int(nullable: false),
                        Statistic_ModifiedById = c.Guid(),
                        Statistic_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.Statistic_Id)
                .ForeignKey("dbo.AD_Users", t => t.Statistic_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Statistic_ModifiedById)
                .Index(t => t.Statistic_ModifiedById)
                .Index(t => t.Statistic_CreatedById);
            
            CreateTable(
                "dbo.AD_ProductCommentReports",
                c => new
                    {
                        ProductCommentReport_Id = c.Guid(nullable: false),
                        ProductCommentReport_Type = c.Int(nullable: false),
                        ProductCommentReport_Reason = c.String(maxLength: 100),
                        ProductCommentReport_IsRead = c.Boolean(nullable: false),
                        ProductCommentReport_ReportedById = c.Guid(nullable: false),
                        ProductCommentReport_ReportedForId = c.Guid(nullable: false),
                        ProductCommentReport_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        ProductCommentReport_CreatedOn = c.DateTime(nullable: false),
                        ProductCommentReport_ModifiedOn = c.DateTime(nullable: false),
                        ProductCommentReport_CreatorIp = c.String(),
                        ProductCommentReport_ModifierIp = c.String(),
                        ProductCommentReport_ModifyLocked = c.Boolean(nullable: false),
                        ProductCommentReport_IsDeleted = c.Boolean(nullable: false),
                        ProductCommentReport_ModifierAgent = c.String(),
                        ProductCommentReport_CreatorAgent = c.String(),
                        ProductCommentReport_Version = c.Int(nullable: false),
                        ProductCommentReport_Action = c.Int(nullable: false),
                        ProductCommentReport_ModifiedById = c.Guid(),
                        ProductCommentReport_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.ProductCommentReport_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductCommentReport_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductCommentReport_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductCommentReport_ReportedById)
                .ForeignKey("dbo.AD_ProductComments", t => t.ProductCommentReport_ReportedForId)
                .Index(t => t.ProductCommentReport_ReportedById)
                .Index(t => t.ProductCommentReport_ReportedForId)
                .Index(t => t.ProductCommentReport_ModifiedById)
                .Index(t => t.ProductCommentReport_CreatedById);
            
            CreateTable(
                "dbo.AD_ProductReviews",
                c => new
                    {
                        ProductReview_Id = c.Guid(nullable: false),
                        ProductReview_Body = c.String(nullable: false, maxLength: 1000),
                        ProductReview_IsActive = c.Boolean(nullable: false),
                        ProductReview_ProductId = c.Guid(nullable: false),
                        ProductReview_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        ProductReview_CreatedOn = c.DateTime(nullable: false),
                        ProductReview_ModifiedOn = c.DateTime(nullable: false),
                        ProductReview_CreatorIp = c.String(),
                        ProductReview_ModifierIp = c.String(),
                        ProductReview_ModifyLocked = c.Boolean(nullable: false),
                        ProductReview_IsDeleted = c.Boolean(nullable: false),
                        ProductReview_ModifierAgent = c.String(),
                        ProductReview_CreatorAgent = c.String(),
                        ProductReview_Version = c.Int(nullable: false),
                        ProductReview_Action = c.Int(nullable: false),
                        ProductReview_ModifiedById = c.Guid(),
                        ProductReview_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.ProductReview_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductReview_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.ProductReview_ModifiedById)
                .ForeignKey("dbo.AD_Products", t => t.ProductReview_ProductId)
                .Index(t => t.ProductReview_ProductId)
                .Index(t => t.ProductReview_ModifiedById)
                .Index(t => t.ProductReview_CreatedById);
            
            CreateTable(
                "dbo.AD_Notifications",
                c => new
                    {
                        Notification_Id = c.Guid(nullable: false),
                        Notification_IsRead = c.Boolean(nullable: false),
                        Notification_Url = c.String(),
                        Notification_Message = c.String(nullable: false, maxLength: 100),
                        Notification_ReadOn = c.DateTime(),
                        Notification_Type = c.Int(nullable: false),
                        Notification_OwnerId = c.Guid(nullable: false),
                        Notification_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Notification_CreatedOn = c.DateTime(nullable: false),
                        Notification_ModifiedOn = c.DateTime(nullable: false),
                        Notification_CreatorIp = c.String(),
                        Notification_ModifierIp = c.String(),
                        Notification_ModifyLocked = c.Boolean(nullable: false),
                        Notification_IsDeleted = c.Boolean(nullable: false),
                        Notification_ModifierAgent = c.String(),
                        Notification_CreatorAgent = c.String(),
                        Notification_Version = c.Int(nullable: false),
                        Notification_Action = c.Int(nullable: false),
                        Notification_ModifiedById = c.Guid(),
                        Notification_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.Notification_Id)
                .ForeignKey("dbo.AD_Users", t => t.Notification_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.Notification_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.Notification_OwnerId)
                .Index(t => t.Notification_OwnerId)
                .Index(t => t.Notification_ModifiedById)
                .Index(t => t.Notification_CreatedById);
            
            CreateTable(
                "dbo.AD_ActivityLogs",
                c => new
                    {
                        ActivityLog_Id = c.Guid(nullable: false),
                        ActivityLog_Comment = c.String(),
                        ActivityLog_OperatedOn = c.DateTime(nullable: false),
                        ActivityLog_Url = c.String(),
                        ActivityLog_Title = c.String(),
                        ActivityLog_Agent = c.String(),
                        ActivityLog_OperantIp = c.String(),
                        ActivityLog_Type = c.Int(nullable: false),
                        ActivityLog_OperantedById = c.Guid(nullable: false),
                        ActivityLog_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        ActivityLog_CreatedOn = c.DateTime(nullable: false),
                        ActivityLog_ModifiedOn = c.DateTime(nullable: false),
                        ActivityLog_CreatorIp = c.String(),
                        ActivityLog_ModifierIp = c.String(),
                        ActivityLog_ModifyLocked = c.Boolean(nullable: false),
                        ActivityLog_IsDeleted = c.Boolean(nullable: false),
                        ActivityLog_ModifierAgent = c.String(),
                        ActivityLog_CreatorAgent = c.String(),
                        ActivityLog_Version = c.Int(nullable: false),
                        ActivityLog_Action = c.Int(nullable: false),
                        ActivityLog_ModifiedById = c.Guid(),
                        ActivityLog_CreatedById = c.Guid(),
                    })
                .PrimaryKey(t => t.ActivityLog_Id)
                .ForeignKey("dbo.AD_Users", t => t.ActivityLog_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.ActivityLog_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.ActivityLog_OperantedById)
                .Index(t => t.ActivityLog_OperantedById)
                .Index(t => t.ActivityLog_ModifiedById)
                .Index(t => t.ActivityLog_CreatedById);
            
            CreateTable(
                "dbo.AD_AuditLogs",
                c => new
                    {
                        AuditLog_Id = c.Guid(nullable: false),
                        AuditLog_Description = c.String(),
                        AuditLog_OperatedOn = c.DateTime(nullable: false),
                        AuditLog_Entity = c.String(),
                        AuditLog_XmlOldValue = c.String(),
                        AuditLog_XmlNewValue = c.String(),
                        AuditLog_EntityId = c.String(),
                        AuditLog_Agent = c.String(),
                        AuditLog_OperantIp = c.String(),
                        AuditLog_OperantedById = c.Long(nullable: false),
                        AuditLog_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        AuditLog_CreatedOn = c.DateTime(nullable: false),
                        AuditLog_ModifiedOn = c.DateTime(nullable: false),
                        AuditLog_CreatorIp = c.String(),
                        AuditLog_ModifierIp = c.String(),
                        AuditLog_ModifyLocked = c.Boolean(nullable: false),
                        AuditLog_IsDeleted = c.Boolean(nullable: false),
                        AuditLog_ModifierAgent = c.String(),
                        AuditLog_CreatorAgent = c.String(),
                        AuditLog_Version = c.Int(nullable: false),
                        AuditLog_Action = c.Int(nullable: false),
                        AuditLog_ModifiedById = c.Guid(),
                        AuditLog_CreatedById = c.Guid(),
                        OperantedBy_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.AuditLog_Id)
                .ForeignKey("dbo.AD_Users", t => t.AuditLog_CreatedById)
                .ForeignKey("dbo.AD_Users", t => t.AuditLog_ModifiedById)
                .ForeignKey("dbo.AD_Users", t => t.OperantedBy_Id)
                .Index(t => t.AuditLog_ModifiedById)
                .Index(t => t.AuditLog_CreatedById)
                .Index(t => t.OperantedBy_Id);
            
            CreateTable(
                "dbo.CompanyCategories",
                c => new
                    {
                        Company_Id = c.Guid(nullable: false),
                        Category_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Company_Id, t.Category_Id })
                .ForeignKey("dbo.AD_Companies", t => t.Company_Id)
                .ForeignKey("dbo.AD_Categories", t => t.Category_Id)
                .Index(t => t.Company_Id)
                .Index(t => t.Category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AD_AuditLogs", "OperantedBy_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_AuditLogs", "AuditLog_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_AuditLogs", "AuditLog_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ActivityLogs", "ActivityLog_OperantedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ActivityLogs", "ActivityLog_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ActivityLogs", "ActivityLog_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Notifications", "Notification_OwnerId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Notifications", "Notification_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Notifications", "Notification_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductReviews", "ProductReview_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProductReviews", "ProductReview_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductReviews", "ProductReview_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductCommentReports", "ProductCommentReport_ReportedForId", "dbo.AD_ProductComments");
            DropForeignKey("dbo.AD_ProductCommentReports", "ProductCommentReport_ReportedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductCommentReports", "ProductCommentReport_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductCommentReports", "ProductCommentReport_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Statistics", "Statistic_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Statistics", "Statistic_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_News", "News_OwnedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_News", "News_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_News", "News_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Conversations", "Conversation_SentById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Conversations", "Conversation_ReceivedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Conversations", "Conversation_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Conversations", "Conversation_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Conversations", "Conversation_ReplyId", "dbo.AD_Conversations");
            DropForeignKey("dbo.AD_Sms", "Sms_SentById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Sms", "Sms_RecievedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Sms", "Sms_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Sms", "Sms_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Ratings", "Rating_RatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Ratings", "Rating_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Ratings", "Rating_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Emails", "Email_SentById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Emails", "Email_RecievedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Emails", "Email_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Emails", "Email_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_BannedWords", "BannedWord_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_BannedWords", "BannedWord_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_PaymentTransactions", "Payment_Id", "dbo.AD_Payments");
            DropForeignKey("dbo.AD_PaymentTransactions", "PaymentTransaction_PayedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_PaymentTransactions", "PaymentTransaction_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_PaymentTransactions", "PaymentTransaction_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_PaymentTransactions", "PaymentTransaction_BudgetId", "dbo.AD_UserBudgets");
            DropForeignKey("dbo.AD_Payments", "Payment_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Payments", "Payment_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_SpecificationOptions", "SpecificationOption_SpecificationId", "dbo.AD_Specifications");
            DropForeignKey("dbo.AD_SpecificationOptions", "SpecificationOption_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_SpecificationOptions", "SpecificationOption_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserRoles", "Role_Id", "dbo.AD_Roles");
            DropForeignKey("dbo.AD_RoleActions", "RoleAction_RoleId", "dbo.AD_Roles");
            DropForeignKey("dbo.AD_RoleActions", "RoleAction_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_RoleActions", "RoleAction_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserSocials", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserSocials", "UserSocial_OwnedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserSocials", "UserSocial_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserSocials", "UserSocial_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserSettings", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserSettings", "UserSetting_OwnedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserSettings", "UserSetting_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserSettings", "UserSetting_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserRoles", "UserRole_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserReports", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserReports", "UserReport_ReportedForId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserReports", "UserReport_ReportedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserReports", "UserReport_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserReports", "UserReport_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserProfiles", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserProfiles", "UserProfile_OwnedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserProfiles", "UserProfile_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserProfiles", "UserProfile_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserProfiles", "UserProfile_AddressId", "dbo.AD_Addresses");
            DropForeignKey("dbo.AD_ProductVisits", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductCommentLikes", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductCommentLikes", "ProductCommentLike_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductCommentLikes", "ProductCommentLike_LikedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductCommentLikes", "ProductCommentLike_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductCommentLikes", "ProductCommentLike_CommentId", "dbo.AD_ProductComments");
            DropForeignKey("dbo.AD_Products", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductLikes", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductImages", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductComments", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserLogins", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyVisits", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyQuestions", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyFollows", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Companies", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserClaims", "UserClaim_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserBudgets", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_TagOrders", "TagOrder_UserBudgetId", "dbo.AD_UserBudgets");
            DropForeignKey("dbo.AD_TagOrders", "TagOrder_TagId", "dbo.AD_Tags");
            DropForeignKey("dbo.AD_Tags", "Tag_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Tags", "Tag_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_TagOrders", "TagOrder_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProductVisits", "ProductVisit_VisitedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductVisits", "ProductVisit_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProductVisits", "ProductVisit_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductVisits", "ProductVisit_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductShares", "ProductShare_SharedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductShares", "ProductShare_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProductShares", "ProductShare_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductShares", "ProductShare_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyReviews", "Product_Id", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProductReports", "ProductReport_ReportedForId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProductReports", "ProductReport_ReportedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductReports", "ProductReport_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductReports", "ProductReport_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductSpecifications", "ProductSpecification_SpecificationId", "dbo.AD_Specifications");
            DropForeignKey("dbo.AD_Specifications", "Specification_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Specifications", "Specification_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Specifications", "Specification_CategoryId", "dbo.AD_Categories");
            DropForeignKey("dbo.AD_ProductSpecifications", "ProductSpecification_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProductSpecifications", "ProductSpecification_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductSpecifications", "ProductSpecification_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Products", "Product_OwnedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Products", "Product_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductLikes", "ProductLike_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProductLikes", "ProductLike_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductLikes", "ProductLike_LikedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductLikes", "ProductLike_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductImages", "ProductImage_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProductImages", "ProductImage_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductImages", "ProductImage_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Products", "Product_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Products", "Product_CompanyId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_ProductComments", "ProductComment_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProductComments", "ProductComment_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductComments", "ProductComment_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductComments", "ProductComment_CommentedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductComments", "ProductComment_ApprovedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Products", "Product_CategoryId", "dbo.AD_Categories");
            DropForeignKey("dbo.AD_CategoryReviews", "CategoryReview_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CategoryReviews", "CategoryReview_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CategoryReviews", "CategoryReview_CategoryId", "dbo.AD_Categories");
            DropForeignKey("dbo.AD_CategoryReviews", "CategoryReview_AuthoredById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Categories", "Category_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CategoryFollows", "CategoryFollow_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CategoryFollows", "CategoryFollow_FollowedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CategoryFollows", "CategoryFollow_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CategoryFollows", "CategoryFollow_CategoryId", "dbo.AD_Categories");
            DropForeignKey("dbo.AD_Categories", "Category_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyVisits", "CompanyVisit_VisitedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyVisits", "CompanyVisit_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyVisits", "CompanyVisit_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyVisits", "CompanyVisit_CompanyId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_CompanySocials", "CompanySocial_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanySocials", "CompanySocial_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanySocials", "CompanySocial_CompanyId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_CompanyReviews", "CompanyReview_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyReviews", "CompanyReview_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyReviews", "CompanyReview_CompanyId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_CompanyReports", "CompanyReport_ReportedForId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_CompanyReports", "CompanyReport_ReportedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyReports", "CompanyReport_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyReports", "CompanyReport_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyQuestionReports", "CompanyQuestionReport_ReportedForId", "dbo.AD_CompanyQuestions");
            DropForeignKey("dbo.AD_CompanyQuestionReports", "CompanyQuestionReport_ReportedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyQuestionReports", "CompanyQuestionReport_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyQuestionReports", "CompanyQuestionReport_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyQuestions", "CompanyQuestion_ReplyId", "dbo.AD_CompanyQuestions");
            DropForeignKey("dbo.AD_CompanyQuestions", "CompanyQuestion_QuestionedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyQuestions", "CompanyQuestion_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyQuestionLikes", "CompanyQuestionLike_QuestionId", "dbo.AD_CompanyQuestions");
            DropForeignKey("dbo.AD_CompanyQuestionLikes", "CompanyQuestionLike_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyQuestionLikes", "CompanyQuestionLike_LikedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyQuestionLikes", "CompanyQuestionLike_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyQuestions", "CompanyQuestion_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyQuestions", "CompanyQuestion_CompanyId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_Companies", "Company_OwnedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Companies", "Company_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyModerators", "CompanyModerator_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyModerators", "CompanyModerator_ModeratedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyModerators", "CompanyModerator_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyModerators", "CompanyModerator_CompanyId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_CompanyImages", "CompanyImage_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyImages", "CompanyImage_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyImages", "CompanyImage_CompanyId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_CompanyFollows", "CompanyFollow_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyFollows", "CompanyFollow_FollowedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyFollows", "CompanyFollow_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyFollows", "CompanyFollow_CompanyId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_Companies", "Company_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.CompanyCategories", "Category_Id", "dbo.AD_Categories");
            DropForeignKey("dbo.CompanyCategories", "Company_Id", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_CompanyAttachments", "CompanyAttachment_OwnedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyAttachments", "CompanyAttachment_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyAttachments", "CompanyAttachment_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_CompanyAttachments", "CompanyAttachment_CompanyId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_Companies", "Company_AddressId", "dbo.AD_Addresses");
            DropForeignKey("dbo.AD_Categories", "Category_ParentId", "dbo.AD_Categories");
            DropForeignKey("dbo.AD_Products", "Product_ApprovedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Products", "Product_AddressId", "dbo.AD_Addresses");
            DropForeignKey("dbo.AD_Addresses", "Address_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Addresses", "Address_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Cities", "City_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Cities", "City_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Cities", "City_ParentId", "dbo.AD_Cities");
            DropForeignKey("dbo.AD_Addresses", "Address_CityId", "dbo.AD_Cities");
            DropForeignKey("dbo.AD_TagOrders", "TagOrder_OrderedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_TagOrders", "TagOrder_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_TagOrders", "TagOrder_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserBudgets", "UserBudget_OwnedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserBudgets", "UserBudget_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_FeatureOrders", "FeatureOrder_UserBudgetId", "dbo.AD_UserBudgets");
            DropForeignKey("dbo.AD_FeatureOrders", "FeatureOrder_OrderedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_FeatureOrders", "FeatureOrder_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_FeatureOrders", "FeatureOrder_FeatureId", "dbo.AD_Features");
            DropForeignKey("dbo.AD_Features", "Feature_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Features", "Feature_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_FeatureOrders", "FeatureOrder_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserBudgets", "UserBudget_CreatedById", "dbo.AD_Users");
            DropIndex("dbo.CompanyCategories", new[] { "Category_Id" });
            DropIndex("dbo.CompanyCategories", new[] { "Company_Id" });
            DropIndex("dbo.AD_AuditLogs", new[] { "OperantedBy_Id" });
            DropIndex("dbo.AD_AuditLogs", new[] { "AuditLog_CreatedById" });
            DropIndex("dbo.AD_AuditLogs", new[] { "AuditLog_ModifiedById" });
            DropIndex("dbo.AD_ActivityLogs", new[] { "ActivityLog_CreatedById" });
            DropIndex("dbo.AD_ActivityLogs", new[] { "ActivityLog_ModifiedById" });
            DropIndex("dbo.AD_ActivityLogs", new[] { "ActivityLog_OperantedById" });
            DropIndex("dbo.AD_Notifications", new[] { "Notification_CreatedById" });
            DropIndex("dbo.AD_Notifications", new[] { "Notification_ModifiedById" });
            DropIndex("dbo.AD_Notifications", new[] { "Notification_OwnerId" });
            DropIndex("dbo.AD_ProductReviews", new[] { "ProductReview_CreatedById" });
            DropIndex("dbo.AD_ProductReviews", new[] { "ProductReview_ModifiedById" });
            DropIndex("dbo.AD_ProductReviews", new[] { "ProductReview_ProductId" });
            DropIndex("dbo.AD_ProductCommentReports", new[] { "ProductCommentReport_CreatedById" });
            DropIndex("dbo.AD_ProductCommentReports", new[] { "ProductCommentReport_ModifiedById" });
            DropIndex("dbo.AD_ProductCommentReports", new[] { "ProductCommentReport_ReportedForId" });
            DropIndex("dbo.AD_ProductCommentReports", new[] { "ProductCommentReport_ReportedById" });
            DropIndex("dbo.AD_Statistics", new[] { "Statistic_CreatedById" });
            DropIndex("dbo.AD_Statistics", new[] { "Statistic_ModifiedById" });
            DropIndex("dbo.AD_News", new[] { "News_CreatedById" });
            DropIndex("dbo.AD_News", new[] { "News_ModifiedById" });
            DropIndex("dbo.AD_News", new[] { "News_OwnedById" });
            DropIndex("dbo.AD_Conversations", new[] { "Conversation_CreatedById" });
            DropIndex("dbo.AD_Conversations", new[] { "Conversation_ModifiedById" });
            DropIndex("dbo.AD_Conversations", new[] { "Conversation_ReplyId" });
            DropIndex("dbo.AD_Conversations", new[] { "Conversation_ReceivedById" });
            DropIndex("dbo.AD_Conversations", new[] { "Conversation_SentById" });
            DropIndex("dbo.AD_Sms", new[] { "Sms_CreatedById" });
            DropIndex("dbo.AD_Sms", new[] { "Sms_ModifiedById" });
            DropIndex("dbo.AD_Sms", new[] { "Sms_RecievedById" });
            DropIndex("dbo.AD_Sms", new[] { "Sms_SentById" });
            DropIndex("dbo.AD_Ratings", new[] { "Rating_CreatedById" });
            DropIndex("dbo.AD_Ratings", new[] { "Rating_ModifiedById" });
            DropIndex("dbo.AD_Ratings", new[] { "Rating_RatedById" });
            DropIndex("dbo.AD_Emails", new[] { "Email_CreatedById" });
            DropIndex("dbo.AD_Emails", new[] { "Email_ModifiedById" });
            DropIndex("dbo.AD_Emails", new[] { "Email_RecievedById" });
            DropIndex("dbo.AD_Emails", new[] { "Email_SentById" });
            DropIndex("dbo.AD_BannedWords", new[] { "BannedWord_CreatedById" });
            DropIndex("dbo.AD_BannedWords", new[] { "BannedWord_ModifiedById" });
            DropIndex("dbo.AD_PaymentTransactions", new[] { "Payment_Id" });
            DropIndex("dbo.AD_PaymentTransactions", new[] { "PaymentTransaction_CreatedById" });
            DropIndex("dbo.AD_PaymentTransactions", new[] { "PaymentTransaction_ModifiedById" });
            DropIndex("dbo.AD_PaymentTransactions", new[] { "PaymentTransaction_BudgetId" });
            DropIndex("dbo.AD_PaymentTransactions", new[] { "PaymentTransaction_PayedById" });
            DropIndex("dbo.AD_Payments", new[] { "Payment_CreatedById" });
            DropIndex("dbo.AD_Payments", new[] { "Payment_ModifiedById" });
            DropIndex("dbo.AD_SpecificationOptions", new[] { "SpecificationOption_CreatedById" });
            DropIndex("dbo.AD_SpecificationOptions", new[] { "SpecificationOption_ModifiedById" });
            DropIndex("dbo.AD_SpecificationOptions", new[] { "SpecificationOption_SpecificationId" });
            DropIndex("dbo.AD_UserSocials", new[] { "User_Id" });
            DropIndex("dbo.AD_UserSocials", new[] { "UserSocial_CreatedById" });
            DropIndex("dbo.AD_UserSocials", new[] { "UserSocial_ModifiedById" });
            DropIndex("dbo.AD_UserSocials", new[] { "UserSocial_OwnedById" });
            DropIndex("dbo.AD_UserSettings", new[] { "User_Id" });
            DropIndex("dbo.AD_UserSettings", new[] { "UserSetting_CreatedById" });
            DropIndex("dbo.AD_UserSettings", new[] { "UserSetting_ModifiedById" });
            DropIndex("dbo.AD_UserSettings", new[] { "UserSetting_OwnedById" });
            DropIndex("dbo.AD_UserRoles", new[] { "Role_Id" });
            DropIndex("dbo.AD_UserRoles", new[] { "UserRole_UserId" });
            DropIndex("dbo.AD_UserReports", new[] { "User_Id" });
            DropIndex("dbo.AD_UserReports", new[] { "UserReport_CreatedById" });
            DropIndex("dbo.AD_UserReports", new[] { "UserReport_ModifiedById" });
            DropIndex("dbo.AD_UserReports", new[] { "UserReport_ReportedForId" });
            DropIndex("dbo.AD_UserReports", new[] { "UserReport_ReportedById" });
            DropIndex("dbo.AD_UserProfiles", new[] { "User_Id" });
            DropIndex("dbo.AD_UserProfiles", new[] { "UserProfile_CreatedById" });
            DropIndex("dbo.AD_UserProfiles", new[] { "UserProfile_ModifiedById" });
            DropIndex("dbo.AD_UserProfiles", new[] { "UserProfile_AddressId" });
            DropIndex("dbo.AD_UserProfiles", new[] { "UserProfile_OwnedById" });
            DropIndex("dbo.AD_ProductCommentLikes", new[] { "User_Id" });
            DropIndex("dbo.AD_ProductCommentLikes", new[] { "ProductCommentLike_CreatedById" });
            DropIndex("dbo.AD_ProductCommentLikes", new[] { "ProductCommentLike_ModifiedById" });
            DropIndex("dbo.AD_ProductCommentLikes", new[] { "ProductCommentLike_CommentId" });
            DropIndex("dbo.AD_ProductCommentLikes", new[] { "ProductCommentLike_LikedById" });
            DropIndex("dbo.AD_UserLogins", new[] { "User_Id" });
            DropIndex("dbo.AD_UserClaims", new[] { "UserClaim_UserId" });
            DropIndex("dbo.AD_Tags", new[] { "Tag_CreatedById" });
            DropIndex("dbo.AD_Tags", new[] { "Tag_ModifiedById" });
            DropIndex("dbo.AD_ProductVisits", new[] { "User_Id" });
            DropIndex("dbo.AD_ProductVisits", new[] { "ProductVisit_CreatedById" });
            DropIndex("dbo.AD_ProductVisits", new[] { "ProductVisit_ModifiedById" });
            DropIndex("dbo.AD_ProductVisits", new[] { "ProductVisit_ProductId" });
            DropIndex("dbo.AD_ProductVisits", new[] { "ProductVisit_VisitedById" });
            DropIndex("dbo.AD_ProductShares", new[] { "ProductShare_CreatedById" });
            DropIndex("dbo.AD_ProductShares", new[] { "ProductShare_ModifiedById" });
            DropIndex("dbo.AD_ProductShares", new[] { "ProductShare_ProductId" });
            DropIndex("dbo.AD_ProductShares", new[] { "ProductShare_SharedById" });
            DropIndex("dbo.AD_ProductReports", new[] { "ProductReport_CreatedById" });
            DropIndex("dbo.AD_ProductReports", new[] { "ProductReport_ModifiedById" });
            DropIndex("dbo.AD_ProductReports", new[] { "ProductReport_ReportedForId" });
            DropIndex("dbo.AD_ProductReports", new[] { "ProductReport_ReportedById" });
            DropIndex("dbo.AD_Specifications", new[] { "Specification_CreatedById" });
            DropIndex("dbo.AD_Specifications", new[] { "Specification_ModifiedById" });
            DropIndex("dbo.AD_Specifications", new[] { "Specification_CategoryId" });
            DropIndex("dbo.AD_ProductSpecifications", new[] { "ProductSpecification_CreatedById" });
            DropIndex("dbo.AD_ProductSpecifications", new[] { "ProductSpecification_ModifiedById" });
            DropIndex("dbo.AD_ProductSpecifications", new[] { "ProductSpecification_SpecificationId" });
            DropIndex("dbo.AD_ProductSpecifications", new[] { "ProductSpecification_ProductId" });
            DropIndex("dbo.AD_ProductLikes", new[] { "User_Id" });
            DropIndex("dbo.AD_ProductLikes", new[] { "ProductLike_CreatedById" });
            DropIndex("dbo.AD_ProductLikes", new[] { "ProductLike_ModifiedById" });
            DropIndex("dbo.AD_ProductLikes", new[] { "ProductLike_ProductId" });
            DropIndex("dbo.AD_ProductLikes", new[] { "ProductLike_LikedById" });
            DropIndex("dbo.AD_ProductImages", new[] { "User_Id" });
            DropIndex("dbo.AD_ProductImages", new[] { "ProductImage_CreatedById" });
            DropIndex("dbo.AD_ProductImages", new[] { "ProductImage_ModifiedById" });
            DropIndex("dbo.AD_ProductImages", new[] { "ProductImage_ProductId" });
            DropIndex("dbo.AD_ProductComments", new[] { "User_Id" });
            DropIndex("dbo.AD_ProductComments", new[] { "ProductComment_CreatedById" });
            DropIndex("dbo.AD_ProductComments", new[] { "ProductComment_ModifiedById" });
            DropIndex("dbo.AD_ProductComments", new[] { "ProductComment_ProductId" });
            DropIndex("dbo.AD_ProductComments", new[] { "ProductComment_ApprovedById" });
            DropIndex("dbo.AD_ProductComments", new[] { "ProductComment_CommentedById" });
            DropIndex("dbo.AD_CategoryReviews", new[] { "CategoryReview_CreatedById" });
            DropIndex("dbo.AD_CategoryReviews", new[] { "CategoryReview_ModifiedById" });
            DropIndex("dbo.AD_CategoryReviews", new[] { "CategoryReview_CategoryId" });
            DropIndex("dbo.AD_CategoryReviews", new[] { "CategoryReview_AuthoredById" });
            DropIndex("dbo.AD_CategoryFollows", new[] { "CategoryFollow_CreatedById" });
            DropIndex("dbo.AD_CategoryFollows", new[] { "CategoryFollow_ModifiedById" });
            DropIndex("dbo.AD_CategoryFollows", new[] { "CategoryFollow_CategoryId" });
            DropIndex("dbo.AD_CategoryFollows", new[] { "CategoryFollow_FollowedById" });
            DropIndex("dbo.AD_CompanyVisits", new[] { "User_Id" });
            DropIndex("dbo.AD_CompanyVisits", new[] { "CompanyVisit_CreatedById" });
            DropIndex("dbo.AD_CompanyVisits", new[] { "CompanyVisit_ModifiedById" });
            DropIndex("dbo.AD_CompanyVisits", new[] { "CompanyVisit_CompanyId" });
            DropIndex("dbo.AD_CompanyVisits", new[] { "CompanyVisit_VisitedById" });
            DropIndex("dbo.AD_CompanySocials", new[] { "CompanySocial_CreatedById" });
            DropIndex("dbo.AD_CompanySocials", new[] { "CompanySocial_ModifiedById" });
            DropIndex("dbo.AD_CompanySocials", new[] { "CompanySocial_CompanyId" });
            DropIndex("dbo.AD_CompanyReviews", new[] { "Product_Id" });
            DropIndex("dbo.AD_CompanyReviews", new[] { "CompanyReview_CreatedById" });
            DropIndex("dbo.AD_CompanyReviews", new[] { "CompanyReview_ModifiedById" });
            DropIndex("dbo.AD_CompanyReviews", new[] { "CompanyReview_CompanyId" });
            DropIndex("dbo.AD_CompanyReports", new[] { "CompanyReport_CreatedById" });
            DropIndex("dbo.AD_CompanyReports", new[] { "CompanyReport_ModifiedById" });
            DropIndex("dbo.AD_CompanyReports", new[] { "CompanyReport_ReportedForId" });
            DropIndex("dbo.AD_CompanyReports", new[] { "CompanyReport_ReportedById" });
            DropIndex("dbo.AD_CompanyQuestionReports", new[] { "CompanyQuestionReport_CreatedById" });
            DropIndex("dbo.AD_CompanyQuestionReports", new[] { "CompanyQuestionReport_ModifiedById" });
            DropIndex("dbo.AD_CompanyQuestionReports", new[] { "CompanyQuestionReport_ReportedForId" });
            DropIndex("dbo.AD_CompanyQuestionReports", new[] { "CompanyQuestionReport_ReportedById" });
            DropIndex("dbo.AD_CompanyQuestionLikes", new[] { "CompanyQuestionLike_CreatedById" });
            DropIndex("dbo.AD_CompanyQuestionLikes", new[] { "CompanyQuestionLike_ModifiedById" });
            DropIndex("dbo.AD_CompanyQuestionLikes", new[] { "CompanyQuestionLike_QuestionId" });
            DropIndex("dbo.AD_CompanyQuestionLikes", new[] { "CompanyQuestionLike_LikedById" });
            DropIndex("dbo.AD_CompanyQuestions", new[] { "User_Id" });
            DropIndex("dbo.AD_CompanyQuestions", new[] { "CompanyQuestion_CreatedById" });
            DropIndex("dbo.AD_CompanyQuestions", new[] { "CompanyQuestion_ModifiedById" });
            DropIndex("dbo.AD_CompanyQuestions", new[] { "CompanyQuestion_QuestionedById" });
            DropIndex("dbo.AD_CompanyQuestions", new[] { "CompanyQuestion_CompanyId" });
            DropIndex("dbo.AD_CompanyQuestions", new[] { "CompanyQuestion_ReplyId" });
            DropIndex("dbo.AD_CompanyModerators", new[] { "CompanyModerator_CreatedById" });
            DropIndex("dbo.AD_CompanyModerators", new[] { "CompanyModerator_ModifiedById" });
            DropIndex("dbo.AD_CompanyModerators", new[] { "CompanyModerator_CompanyId" });
            DropIndex("dbo.AD_CompanyModerators", new[] { "CompanyModerator_ModeratedById" });
            DropIndex("dbo.AD_CompanyImages", new[] { "CompanyImage_CreatedById" });
            DropIndex("dbo.AD_CompanyImages", new[] { "CompanyImage_ModifiedById" });
            DropIndex("dbo.AD_CompanyImages", new[] { "CompanyImage_CompanyId" });
            DropIndex("dbo.AD_CompanyFollows", new[] { "User_Id" });
            DropIndex("dbo.AD_CompanyFollows", new[] { "CompanyFollow_CreatedById" });
            DropIndex("dbo.AD_CompanyFollows", new[] { "CompanyFollow_ModifiedById" });
            DropIndex("dbo.AD_CompanyFollows", new[] { "CompanyFollow_CompanyId" });
            DropIndex("dbo.AD_CompanyFollows", new[] { "CompanyFollow_FollowedById" });
            DropIndex("dbo.AD_CompanyAttachments", new[] { "CompanyAttachment_CreatedById" });
            DropIndex("dbo.AD_CompanyAttachments", new[] { "CompanyAttachment_ModifiedById" });
            DropIndex("dbo.AD_CompanyAttachments", new[] { "CompanyAttachment_CompanyId" });
            DropIndex("dbo.AD_CompanyAttachments", new[] { "CompanyAttachment_OwnedById" });
            DropIndex("dbo.AD_Companies", new[] { "User_Id" });
            DropIndex("dbo.AD_Companies", new[] { "Company_CreatedById" });
            DropIndex("dbo.AD_Companies", new[] { "Company_ModifiedById" });
            DropIndex("dbo.AD_Companies", new[] { "Company_AddressId" });
            DropIndex("dbo.AD_Companies", new[] { "Company_OwnedById" });
            DropIndex("dbo.AD_Categories", new[] { "Category_CreatedById" });
            DropIndex("dbo.AD_Categories", new[] { "Category_ModifiedById" });
            DropIndex("dbo.AD_Categories", new[] { "Category_ParentId" });
            DropIndex("dbo.AD_Cities", new[] { "City_CreatedById" });
            DropIndex("dbo.AD_Cities", new[] { "City_ModifiedById" });
            DropIndex("dbo.AD_Cities", new[] { "City_ParentId" });
            DropIndex("dbo.AD_Addresses", new[] { "Address_CreatedById" });
            DropIndex("dbo.AD_Addresses", new[] { "Address_ModifiedById" });
            DropIndex("dbo.AD_Addresses", new[] { "Address_CityId" });
            DropIndex("dbo.AD_Products", new[] { "User_Id" });
            DropIndex("dbo.AD_Products", new[] { "Product_CreatedById" });
            DropIndex("dbo.AD_Products", new[] { "Product_ModifiedById" });
            DropIndex("dbo.AD_Products", new[] { "Product_CompanyId" });
            DropIndex("dbo.AD_Products", new[] { "Product_CategoryId" });
            DropIndex("dbo.AD_Products", new[] { "Product_AddressId" });
            DropIndex("dbo.AD_Products", new[] { "Product_ApprovedById" });
            DropIndex("dbo.AD_Products", new[] { "Product_OwnedById" });
            DropIndex("dbo.AD_TagOrders", new[] { "TagOrder_CreatedById" });
            DropIndex("dbo.AD_TagOrders", new[] { "TagOrder_ModifiedById" });
            DropIndex("dbo.AD_TagOrders", new[] { "TagOrder_ProductId" });
            DropIndex("dbo.AD_TagOrders", new[] { "TagOrder_TagId" });
            DropIndex("dbo.AD_TagOrders", new[] { "TagOrder_UserBudgetId" });
            DropIndex("dbo.AD_TagOrders", new[] { "TagOrder_OrderedById" });
            DropIndex("dbo.AD_Features", new[] { "Feature_CreatedById" });
            DropIndex("dbo.AD_Features", new[] { "Feature_ModifiedById" });
            DropIndex("dbo.AD_FeatureOrders", new[] { "FeatureOrder_CreatedById" });
            DropIndex("dbo.AD_FeatureOrders", new[] { "FeatureOrder_ModifiedById" });
            DropIndex("dbo.AD_FeatureOrders", new[] { "FeatureOrder_FeatureId" });
            DropIndex("dbo.AD_FeatureOrders", new[] { "FeatureOrder_UserBudgetId" });
            DropIndex("dbo.AD_FeatureOrders", new[] { "FeatureOrder_OrderedById" });
            DropIndex("dbo.AD_UserBudgets", new[] { "User_Id" });
            DropIndex("dbo.AD_UserBudgets", new[] { "UserBudget_CreatedById" });
            DropIndex("dbo.AD_UserBudgets", new[] { "UserBudget_ModifiedById" });
            DropIndex("dbo.AD_UserBudgets", new[] { "UserBudget_OwnedById" });
            DropIndex("dbo.AD_RoleActions", new[] { "RoleAction_CreatedById" });
            DropIndex("dbo.AD_RoleActions", new[] { "RoleAction_ModifiedById" });
            DropIndex("dbo.AD_RoleActions", new[] { "RoleAction_RoleId" });
            DropTable("dbo.CompanyCategories");
            DropTable("dbo.AD_AuditLogs");
            DropTable("dbo.AD_ActivityLogs");
            DropTable("dbo.AD_Notifications");
            DropTable("dbo.AD_ProductReviews");
            DropTable("dbo.AD_ProductCommentReports");
            DropTable("dbo.AD_Statistics");
            DropTable("dbo.AD_News");
            DropTable("dbo.AD_Conversations");
            DropTable("dbo.AD_Sms");
            DropTable("dbo.AD_Ratings");
            DropTable("dbo.AD_Emails");
            DropTable("dbo.AD_BannedWords");
            DropTable("dbo.AD_PaymentTransactions");
            DropTable("dbo.AD_Payments");
            DropTable("dbo.AD_SpecificationOptions");
            DropTable("dbo.AD_UserSocials");
            DropTable("dbo.AD_UserSettings");
            DropTable("dbo.AD_UserRoles");
            DropTable("dbo.AD_UserReports");
            DropTable("dbo.AD_UserProfiles");
            DropTable("dbo.AD_ProductCommentLikes");
            DropTable("dbo.AD_UserLogins");
            DropTable("dbo.AD_UserClaims");
            DropTable("dbo.AD_Tags");
            DropTable("dbo.AD_ProductVisits");
            DropTable("dbo.AD_ProductShares");
            DropTable("dbo.AD_ProductReports");
            DropTable("dbo.AD_Specifications");
            DropTable("dbo.AD_ProductSpecifications");
            DropTable("dbo.AD_ProductLikes");
            DropTable("dbo.AD_ProductImages");
            DropTable("dbo.AD_ProductComments");
            DropTable("dbo.AD_CategoryReviews");
            DropTable("dbo.AD_CategoryFollows");
            DropTable("dbo.AD_CompanyVisits");
            DropTable("dbo.AD_CompanySocials");
            DropTable("dbo.AD_CompanyReviews");
            DropTable("dbo.AD_CompanyReports");
            DropTable("dbo.AD_CompanyQuestionReports");
            DropTable("dbo.AD_CompanyQuestionLikes");
            DropTable("dbo.AD_CompanyQuestions");
            DropTable("dbo.AD_CompanyModerators");
            DropTable("dbo.AD_CompanyImages");
            DropTable("dbo.AD_CompanyFollows");
            DropTable("dbo.AD_CompanyAttachments");
            DropTable("dbo.AD_Companies");
            DropTable("dbo.AD_Categories");
            DropTable("dbo.AD_Cities");
            DropTable("dbo.AD_Addresses");
            DropTable("dbo.AD_Products");
            DropTable("dbo.AD_TagOrders");
            DropTable("dbo.AD_Features");
            DropTable("dbo.AD_FeatureOrders");
            DropTable("dbo.AD_UserBudgets");
            DropTable("dbo.AD_Users");
            DropTable("dbo.AD_RoleActions");
            DropTable("dbo.AD_Roles");
        }
    }
}
