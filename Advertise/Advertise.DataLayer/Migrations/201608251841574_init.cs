using System.Data.Entity.Migrations;

namespace Advertise.DataLayer.Migrations
{
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AD_Roles",
                c => new
                {
                    Role_Id = c.Guid(false),
                    Role_Code = c.String(false, 50),
                    Role_RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    Role_Type = c.Int(false),
                    Role_IsSystemRole = c.Boolean(false),
                    Role_Name = c.String(false)
                })
                .PrimaryKey(t => t.Role_Id);

            CreateTable(
                "dbo.AD_RoleActions",
                c => new
                {
                    RoleAction_Id = c.Guid(false),
                    RoleAction_Title = c.String(false, 100),
                    RoleAction_ActionName = c.String(false, 100),
                    RoleAction_ControllerName = c.String(false, 100),
                    RoleAction_IsActive = c.Boolean(false),
                    RoleAction_RoleId = c.Guid(false),
                    RoleAction_RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    RoleAction_CreatedOn = c.DateTime(false),
                    RoleAction_ModifiedOn = c.DateTime(false),
                    RoleAction_CreatorIp = c.String(),
                    RoleAction_ModifierIp = c.String(),
                    RoleAction_ModifyLocked = c.Boolean(false),
                    RoleAction_IsDeleted = c.Boolean(false),
                    RoleAction_ModifierAgent = c.String(),
                    RoleAction_CreatorAgent = c.String(),
                    RoleAction_ReportedOn = c.DateTime(),
                    RoleAction_ReportCount = c.Int(false),
                    RoleAction_Version = c.Int(false),
                    RoleAction_Action = c.Int(false),
                    RoleAction_ModifiedById = c.Guid(false),
                    RoleAction_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.RoleAction_Id)
                .ForeignKey("dbo.AD_Users", t => t.RoleAction_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.RoleAction_ModifiedById, true)
                .ForeignKey("dbo.AD_Roles", t => t.RoleAction_RoleId, true)
                .Index(t => t.RoleAction_RoleId)
                .Index(t => t.RoleAction_ModifiedById)
                .Index(t => t.RoleAction_CreatedById);

            CreateTable(
                "dbo.AD_Users",
                c => new
                {
                    User_Id = c.Guid(false),
                    User_IsBanned = c.Boolean(false),
                    User_BannedReason = c.String(),
                    User_BannedOn = c.DateTime(),
                    User_IsVerified = c.Boolean(false),
                    User_IsActive = c.Boolean(false),
                    User_IsAnonymous = c.Boolean(false),
                    User_EmailConfirmationToken = c.String(maxLength: 200),
                    User_MobileConfirmationToken = c.String(false, 200),
                    User_LastPasswordChangedOn = c.DateTime(),
                    User_LastLoginOn = c.DateTime(),
                    User_IsSystemAccount = c.Boolean(false),
                    User_LastIp = c.String(),
                    User_RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    User_Email = c.String(maxLength: 75),
                    User_EmailConfirmed = c.Boolean(false),
                    User_PasswordHash = c.String(false, 200),
                    User_SecurityStamp = c.String(),
                    User_PhoneNumber = c.String(maxLength: 11),
                    User_PhoneNumberConfirmed = c.Boolean(false),
                    User_TwoFactorEnabled = c.Boolean(false),
                    User_LockoutEndDateUtc = c.DateTime(),
                    User_LockoutEnabled = c.Boolean(false),
                    User_AccessFailedCount = c.Int(false),
                    User_UserName = c.String(false, 50),
                    Profile_Id = c.Guid(),
                    Setting_Id = c.Guid(),
                    Social_Id = c.Guid()
                })
                .PrimaryKey(t => t.User_Id)
                .ForeignKey("dbo.AD_UserProfiles", t => t.Profile_Id)
                .ForeignKey("dbo.AD_UserSettings", t => t.Setting_Id)
                .ForeignKey("dbo.AD_UserSocials", t => t.Social_Id)
                .Index(t => t.Profile_Id)
                .Index(t => t.Setting_Id)
                .Index(t => t.Social_Id);

            CreateTable(
                "dbo.AD_UserBudgets",
                c => new
                {
                    UserBudget_Id = c.Guid(false),
                    UserBudget_RemainRialValue = c.Int(false),
                    UserBudget_IncDecValue = c.Int(false),
                    UserBudget_Description = c.String(),
                    UserBudget_OwnedById = c.Guid(false),
                    UserBudget_RowVersion = c.Binary(),
                    UserBudget_CreatedOn = c.DateTime(false),
                    UserBudget_ModifiedOn = c.DateTime(false),
                    UserBudget_CreatorIp = c.String(),
                    UserBudget_ModifierIp = c.String(),
                    UserBudget_ModifyLocked = c.Boolean(false),
                    UserBudget_IsDeleted = c.Boolean(false),
                    UserBudget_ModifierAgent = c.String(),
                    UserBudget_CreatorAgent = c.String(),
                    UserBudget_ReportedOn = c.DateTime(),
                    UserBudget_ReportCount = c.Int(false),
                    UserBudget_Version = c.Int(false),
                    UserBudget_Action = c.Int(false),
                    UserBudget_ModifiedById = c.Guid(false),
                    UserBudget_CreatedById = c.Guid(false),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.UserBudget_Id)
                .ForeignKey("dbo.AD_Users", t => t.UserBudget_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.UserBudget_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.UserBudget_OwnedById, true)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.UserBudget_OwnedById)
                .Index(t => t.UserBudget_ModifiedById)
                .Index(t => t.UserBudget_CreatedById)
                .Index(t => t.User_Id);

            CreateTable(
                "dbo.AD_FeatureOrders",
                c => new
                {
                    FeatureOrder_Id = c.Guid(false),
                    FeatureOrder_ExpiredOn = c.DateTime(false),
                    FeatureOrder_OrderedById = c.Guid(false),
                    FeatureOrder_UserBudgetId = c.Guid(false),
                    FeatureOrder_FeatureId = c.Guid(false),
                    FeatureOrder_RowVersion = c.Binary(),
                    FeatureOrder_CreatedOn = c.DateTime(false),
                    FeatureOrder_ModifiedOn = c.DateTime(false),
                    FeatureOrder_CreatorIp = c.String(),
                    FeatureOrder_ModifierIp = c.String(),
                    FeatureOrder_ModifyLocked = c.Boolean(false),
                    FeatureOrder_IsDeleted = c.Boolean(false),
                    FeatureOrder_ModifierAgent = c.String(),
                    FeatureOrder_CreatorAgent = c.String(),
                    FeatureOrder_ReportedOn = c.DateTime(),
                    FeatureOrder_ReportCount = c.Int(false),
                    FeatureOrder_Version = c.Int(false),
                    FeatureOrder_Action = c.Int(false),
                    FeatureOrder_ModifiedById = c.Guid(false),
                    FeatureOrder_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.FeatureOrder_Id)
                .ForeignKey("dbo.AD_Users", t => t.FeatureOrder_CreatedById, true)
                .ForeignKey("dbo.AD_Features", t => t.FeatureOrder_FeatureId, true)
                .ForeignKey("dbo.AD_Users", t => t.FeatureOrder_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.FeatureOrder_OrderedById, true)
                .ForeignKey("dbo.AD_UserBudgets", t => t.FeatureOrder_UserBudgetId, true)
                .Index(t => t.FeatureOrder_OrderedById)
                .Index(t => t.FeatureOrder_UserBudgetId)
                .Index(t => t.FeatureOrder_FeatureId)
                .Index(t => t.FeatureOrder_ModifiedById)
                .Index(t => t.FeatureOrder_CreatedById);

            CreateTable(
                "dbo.AD_Features",
                c => new
                {
                    Feature_Id = c.Guid(false),
                    Feature_Code = c.String(false, 50),
                    Feature_Title = c.String(false, 100),
                    Feature_Description = c.String(maxLength: 250),
                    Feature_DurationDay = c.String(false),
                    Feature_CostRialValue = c.Int(false),
                    Feature_CostUsdValue = c.Long(false),
                    Feature_IsActive = c.Boolean(false),
                    Feature_Type = c.Int(false),
                    Feature_StartedOn = c.DateTime(false),
                    Feature_ExpiredOn = c.DateTime(false),
                    Feature_RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    Feature_CreatedOn = c.DateTime(false),
                    Feature_ModifiedOn = c.DateTime(false),
                    Feature_CreatorIp = c.String(),
                    Feature_ModifierIp = c.String(),
                    Feature_ModifyLocked = c.Boolean(false),
                    Feature_IsDeleted = c.Boolean(false),
                    Feature_ModifierAgent = c.String(),
                    Feature_CreatorAgent = c.String(),
                    Feature_ReportedOn = c.DateTime(),
                    Feature_ReportCount = c.Int(false),
                    Feature_Version = c.Int(false),
                    Feature_Action = c.Int(false),
                    Feature_ModifiedById = c.Guid(false),
                    Feature_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.Feature_Id)
                .ForeignKey("dbo.AD_Users", t => t.Feature_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Feature_ModifiedById, true)
                .Index(t => t.Feature_ModifiedById)
                .Index(t => t.Feature_CreatedById);

            CreateTable(
                "dbo.AD_TagOrders",
                c => new
                {
                    TagOrder_Id = c.Guid(false),
                    TagOrder_ExpiredOn = c.DateTime(false),
                    TagOrder_OrderedById = c.Guid(false),
                    TagOrder_UserBudgetId = c.Guid(false),
                    TagOrder_TagId = c.Guid(false),
                    TagOrder_ProductId = c.Guid(false),
                    TagOrder_RowVersion = c.Binary(),
                    TagOrder_CreatedOn = c.DateTime(false),
                    TagOrder_ModifiedOn = c.DateTime(false),
                    TagOrder_CreatorIp = c.String(),
                    TagOrder_ModifierIp = c.String(),
                    TagOrder_ModifyLocked = c.Boolean(false),
                    TagOrder_IsDeleted = c.Boolean(false),
                    TagOrder_ModifierAgent = c.String(),
                    TagOrder_CreatorAgent = c.String(),
                    TagOrder_ReportedOn = c.DateTime(),
                    TagOrder_ReportCount = c.Int(false),
                    TagOrder_Version = c.Int(false),
                    TagOrder_Action = c.Int(false),
                    TagOrder_ModifiedById = c.Guid(false),
                    TagOrder_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.TagOrder_Id)
                .ForeignKey("dbo.AD_Users", t => t.TagOrder_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.TagOrder_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.TagOrder_OrderedById, true)
                .ForeignKey("dbo.AD_Products", t => t.TagOrder_ProductId, true)
                .ForeignKey("dbo.AD_Tags", t => t.TagOrder_TagId, true)
                .ForeignKey("dbo.AD_UserBudgets", t => t.TagOrder_UserBudgetId, true)
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
                    Product_Id = c.Guid(false),
                    Product_Code = c.String(false, 50),
                    Product_Title = c.String(false, 250),
                    Product_Body = c.String(maxLength: 500),
                    Product_MobileNumber = c.String(false, 10),
                    Product_PhoneNumber = c.String(maxLength: 10),
                    Product_Email = c.String(maxLength: 100),
                    Product_IsApproved = c.Boolean(false),
                    Product_IsAllowComment = c.Boolean(false),
                    Product_IsAllowCommentForAnonymous = c.Boolean(false),
                    Product_IsEnableForShare = c.Boolean(false),
                    Product_Status = c.Int(false),
                    Product_OwnedById = c.Guid(false),
                    Product_ApprovedById = c.Guid(false),
                    Product_AddressId = c.Guid(false),
                    Product_CategoryId = c.Guid(false),
                    Product_CompanyId = c.Guid(false),
                    Product_RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    Product_CreatedOn = c.DateTime(false),
                    Product_ModifiedOn = c.DateTime(false),
                    Product_CreatorIp = c.String(),
                    Product_ModifierIp = c.String(),
                    Product_ModifyLocked = c.Boolean(false),
                    Product_IsDeleted = c.Boolean(false),
                    Product_ModifierAgent = c.String(),
                    Product_CreatorAgent = c.String(),
                    Product_ReportedOn = c.DateTime(),
                    Product_ReportCount = c.Int(false),
                    Product_Version = c.Int(false),
                    Product_Action = c.Int(false),
                    Product_ModifiedById = c.Guid(false),
                    Product_CreatedById = c.Guid(false),
                    Review_Id = c.Guid(),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.Product_Id)
                .ForeignKey("dbo.AD_Addresses", t => t.Product_AddressId, true)
                .ForeignKey("dbo.AD_Users", t => t.Product_ApprovedById, true)
                .ForeignKey("dbo.AD_Categories", t => t.Product_CategoryId, true)
                .ForeignKey("dbo.AD_Companies", t => t.Product_CompanyId, true)
                .ForeignKey("dbo.AD_Users", t => t.Product_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Product_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Product_OwnedById, true)
                .ForeignKey("dbo.AD_CompanyReviews", t => t.Review_Id)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.Product_OwnedById)
                .Index(t => t.Product_ApprovedById)
                .Index(t => t.Product_AddressId)
                .Index(t => t.Product_CategoryId)
                .Index(t => t.Product_CompanyId)
                .Index(t => t.Product_ModifiedById)
                .Index(t => t.Product_CreatedById)
                .Index(t => t.Review_Id)
                .Index(t => t.User_Id);

            CreateTable(
                "dbo.AD_Addresses",
                c => new
                {
                    Address_Id = c.Guid(false),
                    Address_Gps = c.String(),
                    Address_Street = c.String(),
                    Address_Extra = c.String(),
                    Address_PostalCode = c.String(),
                    Address_CityId = c.Guid(false),
                    Address_RowVersion = c.Binary(),
                    Address_CreatedOn = c.DateTime(false),
                    Address_ModifiedOn = c.DateTime(false),
                    Address_CreatorIp = c.String(),
                    Address_ModifierIp = c.String(),
                    Address_ModifyLocked = c.Boolean(false),
                    Address_IsDeleted = c.Boolean(false),
                    Address_ModifierAgent = c.String(),
                    Address_CreatorAgent = c.String(),
                    Address_ReportedOn = c.DateTime(),
                    Address_ReportCount = c.Int(false),
                    Address_Version = c.Int(false),
                    Address_Action = c.Int(false),
                    Address_ModifiedById = c.Guid(false),
                    Address_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.Address_Id)
                .ForeignKey("dbo.AD_Cities", t => t.Address_CityId, true)
                .ForeignKey("dbo.AD_Users", t => t.Address_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Address_ModifiedById, true)
                .Index(t => t.Address_CityId)
                .Index(t => t.Address_ModifiedById)
                .Index(t => t.Address_CreatedById);

            CreateTable(
                "dbo.AD_Cities",
                c => new
                {
                    City_Id = c.Guid(false),
                    City_IsState = c.Boolean(false),
                    City_Name = c.String(false, 100),
                    City_IsActive = c.Boolean(false),
                    City_ParentPath = c.String(),
                    City_ParentId = c.Guid(false),
                    City_RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    City_CreatedOn = c.DateTime(false),
                    City_ModifiedOn = c.DateTime(false),
                    City_CreatorIp = c.String(),
                    City_ModifierIp = c.String(),
                    City_ModifyLocked = c.Boolean(false),
                    City_IsDeleted = c.Boolean(false),
                    City_ModifierAgent = c.String(),
                    City_CreatorAgent = c.String(),
                    City_ReportedOn = c.DateTime(),
                    City_ReportCount = c.Int(false),
                    City_Version = c.Int(false),
                    City_Action = c.Int(false),
                    City_ModifiedById = c.Guid(false),
                    City_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.City_Id)
                .ForeignKey("dbo.AD_Cities", t => t.City_ParentId)
                .ForeignKey("dbo.AD_Users", t => t.City_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.City_ModifiedById, true)
                .Index(t => t.City_ParentId)
                .Index(t => t.City_ModifiedById)
                .Index(t => t.City_CreatedById);

            CreateTable(
                "dbo.AD_Categories",
                c => new
                {
                    Category_Id = c.Guid(false),
                    Category_Code = c.String(false, 100),
                    Category_Title = c.String(false, 100),
                    Category_Description = c.String(false, 1000),
                    Category_ImageFileName = c.String(),
                    Category_ParentPath = c.String(),
                    Category_IsActive = c.Boolean(false),
                    Category_ParentId = c.Guid(false),
                    Category_RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    Category_CreatedOn = c.DateTime(false),
                    Category_ModifiedOn = c.DateTime(false),
                    Category_CreatorIp = c.String(),
                    Category_ModifierIp = c.String(),
                    Category_ModifyLocked = c.Boolean(false),
                    Category_IsDeleted = c.Boolean(false),
                    Category_ModifierAgent = c.String(),
                    Category_CreatorAgent = c.String(),
                    Category_ReportedOn = c.DateTime(),
                    Category_ReportCount = c.Int(false),
                    Category_Version = c.Int(false),
                    Category_Action = c.Int(false),
                    Category_ModifiedById = c.Guid(false),
                    Category_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.Category_Id)
                .ForeignKey("dbo.AD_Categories", t => t.Category_ParentId)
                .ForeignKey("dbo.AD_Users", t => t.Category_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Category_ModifiedById, true)
                .Index(t => t.Category_ParentId)
                .Index(t => t.Category_ModifiedById)
                .Index(t => t.Category_CreatedById);

            CreateTable(
                "dbo.AD_Companies",
                c => new
                {
                    Company_Id = c.Guid(false),
                    Company_Code = c.String(false, 75),
                    Company_BrandName = c.String(false, 200),
                    Company_Description = c.String(false),
                    Company_LogoFileName = c.String(maxLength: 75),
                    Company_BackgroundFileName = c.String(maxLength: 75),
                    Company_PhoneNumber = c.String(false, 50),
                    Company_MobileNumber = c.String(false, 11),
                    Company_Email = c.String(maxLength: 75),
                    Company_WebSite = c.String(maxLength: 100),
                    Company_EmployeeCount = c.Long(false),
                    Company_EstablishedOn = c.DateTime(false),
                    Company_OwnedById = c.Guid(false),
                    Company_AddressId = c.Guid(false),
                    Company_RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    Company_CreatedOn = c.DateTime(false),
                    Company_ModifiedOn = c.DateTime(false),
                    Company_CreatorIp = c.String(),
                    Company_ModifierIp = c.String(),
                    Company_ModifyLocked = c.Boolean(false),
                    Company_IsDeleted = c.Boolean(false),
                    Company_ModifierAgent = c.String(),
                    Company_CreatorAgent = c.String(),
                    Company_ReportedOn = c.DateTime(),
                    Company_ReportCount = c.Int(false),
                    Company_Version = c.Int(false),
                    Company_Action = c.Int(false),
                    Company_ModifiedById = c.Guid(false),
                    Company_CreatedById = c.Guid(false),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.Company_Id)
                .ForeignKey("dbo.AD_Addresses", t => t.Company_AddressId, true)
                .ForeignKey("dbo.AD_Users", t => t.Company_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Company_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Company_OwnedById, true)
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
                    CompanyAttachment_Id = c.Guid(false),
                    CompanyAttachment_FileName = c.String(),
                    CompanyAttachment_FileSize = c.String(),
                    CompanyAttachment_FileExtension = c.String(),
                    CompanyAttachment_DownloadCount = c.Long(false),
                    CompanyAttachment_Title = c.String(),
                    CompanyAttachment_Description = c.String(),
                    CompanyAttachment_Type = c.Int(false),
                    CompanyAttachment_IsApproved = c.Boolean(false),
                    CompanyAttachment_OwnedById = c.Guid(false),
                    CompanyAttachment_CompanyId = c.Guid(false),
                    CompanyAttachment_RowVersion = c.Binary(),
                    CompanyAttachment_CreatedOn = c.DateTime(false),
                    CompanyAttachment_ModifiedOn = c.DateTime(false),
                    CompanyAttachment_CreatorIp = c.String(),
                    CompanyAttachment_ModifierIp = c.String(),
                    CompanyAttachment_ModifyLocked = c.Boolean(false),
                    CompanyAttachment_IsDeleted = c.Boolean(false),
                    CompanyAttachment_ModifierAgent = c.String(),
                    CompanyAttachment_CreatorAgent = c.String(),
                    CompanyAttachment_ReportedOn = c.DateTime(),
                    CompanyAttachment_ReportCount = c.Int(false),
                    CompanyAttachment_Version = c.Int(false),
                    CompanyAttachment_Action = c.Int(false),
                    CompanyAttachment_ModifiedById = c.Guid(false),
                    CompanyAttachment_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.CompanyAttachment_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyAttachment_CompanyId, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyAttachment_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyAttachment_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyAttachment_OwnedById, true)
                .Index(t => t.CompanyAttachment_OwnedById)
                .Index(t => t.CompanyAttachment_CompanyId)
                .Index(t => t.CompanyAttachment_ModifiedById)
                .Index(t => t.CompanyAttachment_CreatedById);

            CreateTable(
                "dbo.AD_CompanyFollows",
                c => new
                {
                    CompanyFollow_Id = c.Guid(false),
                    CompanyFollow_IsFollow = c.Boolean(false),
                    CompanyFollow_FollowedById = c.Guid(false),
                    CompanyFollow_CompanyId = c.Guid(false),
                    CompanyFollow_RowVersion = c.Binary(),
                    CompanyFollow_CreatedOn = c.DateTime(false),
                    CompanyFollow_ModifiedOn = c.DateTime(false),
                    CompanyFollow_CreatorIp = c.String(),
                    CompanyFollow_ModifierIp = c.String(),
                    CompanyFollow_ModifyLocked = c.Boolean(false),
                    CompanyFollow_IsDeleted = c.Boolean(false),
                    CompanyFollow_ModifierAgent = c.String(),
                    CompanyFollow_CreatorAgent = c.String(),
                    CompanyFollow_ReportedOn = c.DateTime(),
                    CompanyFollow_ReportCount = c.Int(false),
                    CompanyFollow_Version = c.Int(false),
                    CompanyFollow_Action = c.Int(false),
                    CompanyFollow_ModifiedById = c.Guid(false),
                    CompanyFollow_CreatedById = c.Guid(false),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.CompanyFollow_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyFollow_CompanyId, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyFollow_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyFollow_FollowedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyFollow_ModifiedById, true)
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
                    CompanyImage_Id = c.Guid(false),
                    CompanyImage_Title = c.String(maxLength: 100),
                    CompanyImage_FileName = c.String(false, 100),
                    CompanyImage_FileSize = c.String(false, 10),
                    CompanyImage_FileDimension = c.String(false, 10),
                    CompanyImage_Order = c.Int(false),
                    CompanyImage_CompanyId = c.Guid(false),
                    CompanyImage_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    CompanyImage_CreatedOn = c.DateTime(false),
                    CompanyImage_ModifiedOn = c.DateTime(false),
                    CompanyImage_CreatorIp = c.String(),
                    CompanyImage_ModifierIp = c.String(),
                    CompanyImage_ModifyLocked = c.Boolean(false),
                    CompanyImage_IsDeleted = c.Boolean(false),
                    CompanyImage_ModifierAgent = c.String(),
                    CompanyImage_CreatorAgent = c.String(),
                    CompanyImage_ReportedOn = c.DateTime(),
                    CompanyImage_ReportCount = c.Int(false),
                    CompanyImage_Version = c.Int(false),
                    CompanyImage_Action = c.Int(false),
                    CompanyImage_ModifiedById = c.Guid(false),
                    CompanyImage_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.CompanyImage_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyImage_CompanyId, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyImage_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyImage_ModifiedById, true)
                .Index(t => t.CompanyImage_CompanyId)
                .Index(t => t.CompanyImage_ModifiedById)
                .Index(t => t.CompanyImage_CreatedById);

            CreateTable(
                "dbo.AD_CompanyModerators",
                c => new
                {
                    CompanyModerator_Id = c.Guid(false),
                    CompanyModerator_IsActive = c.Boolean(false),
                    CompanyModerator_ModeratedById = c.Guid(false),
                    CompanyModerator_CompanyId = c.Guid(false),
                    CompanyModerator_RowVersion = c.Binary(),
                    CompanyModerator_CreatedOn = c.DateTime(false),
                    CompanyModerator_ModifiedOn = c.DateTime(false),
                    CompanyModerator_CreatorIp = c.String(),
                    CompanyModerator_ModifierIp = c.String(),
                    CompanyModerator_ModifyLocked = c.Boolean(false),
                    CompanyModerator_IsDeleted = c.Boolean(false),
                    CompanyModerator_ModifierAgent = c.String(),
                    CompanyModerator_CreatorAgent = c.String(),
                    CompanyModerator_ReportedOn = c.DateTime(),
                    CompanyModerator_ReportCount = c.Int(false),
                    CompanyModerator_Version = c.Int(false),
                    CompanyModerator_Action = c.Int(false),
                    CompanyModerator_ModifiedById = c.Guid(false),
                    CompanyModerator_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.CompanyModerator_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyModerator_CompanyId, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyModerator_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyModerator_ModeratedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyModerator_ModifiedById, true)
                .Index(t => t.CompanyModerator_ModeratedById)
                .Index(t => t.CompanyModerator_CompanyId)
                .Index(t => t.CompanyModerator_ModifiedById)
                .Index(t => t.CompanyModerator_CreatedById);

            CreateTable(
                "dbo.AD_CompanyQuestions",
                c => new
                {
                    CompanyQuestion_Id = c.Guid(false),
                    CompanyQuestion_Title = c.String(false, 255),
                    CompanyQuestion_Body = c.String(false, 700),
                    CompanyQuestion_IsApproved = c.Boolean(false),
                    CompanyQuestion_ReplyId = c.Guid(false),
                    CompanyQuestion_CompanyId = c.Guid(false),
                    CompanyQuestion_QuestionedById = c.Guid(false),
                    CompanyQuestion_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    CompanyQuestion_CreatedOn = c.DateTime(false),
                    CompanyQuestion_ModifiedOn = c.DateTime(false),
                    CompanyQuestion_CreatorIp = c.String(),
                    CompanyQuestion_ModifierIp = c.String(),
                    CompanyQuestion_ModifyLocked = c.Boolean(false),
                    CompanyQuestion_IsDeleted = c.Boolean(false),
                    CompanyQuestion_ModifierAgent = c.String(),
                    CompanyQuestion_CreatorAgent = c.String(),
                    CompanyQuestion_ReportedOn = c.DateTime(),
                    CompanyQuestion_ReportCount = c.Int(false),
                    CompanyQuestion_Version = c.Int(false),
                    CompanyQuestion_Action = c.Int(false),
                    CompanyQuestion_ModifiedById = c.Guid(false),
                    CompanyQuestion_CreatedById = c.Guid(false),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.CompanyQuestion_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyQuestion_CompanyId, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestion_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestion_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestion_QuestionedById, true)
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
                    CompanyQuestionLike_Id = c.Guid(false),
                    CompanyQuestionLike_IsLiked = c.Boolean(false),
                    CompanyQuestionLike_IsDisLiked = c.Boolean(false),
                    CompanyQuestionLike_LikedById = c.Guid(false),
                    CompanyQuestionLike_QuestionId = c.Guid(false),
                    CompanyQuestionLike_RowVersion = c.Binary(),
                    CompanyQuestionLike_CreatedOn = c.DateTime(false),
                    CompanyQuestionLike_ModifiedOn = c.DateTime(false),
                    CompanyQuestionLike_CreatorIp = c.String(),
                    CompanyQuestionLike_ModifierIp = c.String(),
                    CompanyQuestionLike_ModifyLocked = c.Boolean(false),
                    CompanyQuestionLike_IsDeleted = c.Boolean(false),
                    CompanyQuestionLike_ModifierAgent = c.String(),
                    CompanyQuestionLike_CreatorAgent = c.String(),
                    CompanyQuestionLike_ReportedOn = c.DateTime(),
                    CompanyQuestionLike_ReportCount = c.Int(false),
                    CompanyQuestionLike_Version = c.Int(false),
                    CompanyQuestionLike_Action = c.Int(false),
                    CompanyQuestionLike_ModifiedById = c.Guid(false),
                    CompanyQuestionLike_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.CompanyQuestionLike_Id)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestionLike_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestionLike_LikedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestionLike_ModifiedById, true)
                .ForeignKey("dbo.AD_CompanyQuestions", t => t.CompanyQuestionLike_QuestionId, true)
                .Index(t => t.CompanyQuestionLike_LikedById)
                .Index(t => t.CompanyQuestionLike_QuestionId)
                .Index(t => t.CompanyQuestionLike_ModifiedById)
                .Index(t => t.CompanyQuestionLike_CreatedById);

            CreateTable(
                "dbo.AD_CompanyQuestionReports",
                c => new
                {
                    CompanyQuestionReport_Id = c.Guid(false),
                    CompanyQuestionReport_Type = c.Int(false),
                    CompanyQuestionReport_Reason = c.String(),
                    CompanyQuestionReport_IsRead = c.Boolean(false),
                    CompanyQuestionReport_ReportedById = c.Guid(false),
                    CompanyQuestionReport_ReportedForId = c.Guid(false),
                    CompanyQuestionReport_RowVersion = c.Binary(),
                    CompanyQuestionReport_CreatedOn = c.DateTime(false),
                    CompanyQuestionReport_ModifiedOn = c.DateTime(false),
                    CompanyQuestionReport_CreatorIp = c.String(),
                    CompanyQuestionReport_ModifierIp = c.String(),
                    CompanyQuestionReport_ModifyLocked = c.Boolean(false),
                    CompanyQuestionReport_IsDeleted = c.Boolean(false),
                    CompanyQuestionReport_ModifierAgent = c.String(),
                    CompanyQuestionReport_CreatorAgent = c.String(),
                    CompanyQuestionReport_ReportedOn = c.DateTime(),
                    CompanyQuestionReport_ReportCount = c.Int(false),
                    CompanyQuestionReport_Version = c.Int(false),
                    CompanyQuestionReport_Action = c.Int(false),
                    CompanyQuestionReport_ModifiedById = c.Guid(false),
                    CompanyQuestionReport_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.CompanyQuestionReport_Id)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestionReport_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestionReport_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyQuestionReport_ReportedById, true)
                .ForeignKey("dbo.AD_CompanyQuestions", t => t.CompanyQuestionReport_ReportedForId, true)
                .Index(t => t.CompanyQuestionReport_ReportedById)
                .Index(t => t.CompanyQuestionReport_ReportedForId)
                .Index(t => t.CompanyQuestionReport_ModifiedById)
                .Index(t => t.CompanyQuestionReport_CreatedById);

            CreateTable(
                "dbo.AD_CompanyReports",
                c => new
                {
                    CompanyReport_Id = c.Guid(false),
                    CompanyReport_Type = c.Int(false),
                    CompanyReport_Reason = c.String(),
                    CompanyReport_IsRead = c.Boolean(false),
                    CompanyReport_ReportedById = c.Guid(false),
                    CompanyReport_ReportedForId = c.Guid(false),
                    CompanyReport_RowVersion = c.Binary(),
                    CompanyReport_CreatedOn = c.DateTime(false),
                    CompanyReport_ModifiedOn = c.DateTime(false),
                    CompanyReport_CreatorIp = c.String(),
                    CompanyReport_ModifierIp = c.String(),
                    CompanyReport_ModifyLocked = c.Boolean(false),
                    CompanyReport_IsDeleted = c.Boolean(false),
                    CompanyReport_ModifierAgent = c.String(),
                    CompanyReport_CreatorAgent = c.String(),
                    CompanyReport_ReportedOn = c.DateTime(),
                    CompanyReport_ReportCount = c.Int(false),
                    CompanyReport_Version = c.Int(false),
                    CompanyReport_Action = c.Int(false),
                    CompanyReport_ModifiedById = c.Guid(false),
                    CompanyReport_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.CompanyReport_Id)
                .ForeignKey("dbo.AD_Users", t => t.CompanyReport_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyReport_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyReport_ReportedById, true)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyReport_ReportedForId, true)
                .Index(t => t.CompanyReport_ReportedById)
                .Index(t => t.CompanyReport_ReportedForId)
                .Index(t => t.CompanyReport_ModifiedById)
                .Index(t => t.CompanyReport_CreatedById);

            CreateTable(
                "dbo.AD_CompanyReviews",
                c => new
                {
                    CompanyReview_Id = c.Guid(false),
                    CompanyReview_Body = c.String(),
                    CompanyReview_IsActive = c.Boolean(false),
                    CompanyReview_CompanyId = c.Guid(false),
                    CompanyReview_RowVersion = c.Binary(),
                    CompanyReview_CreatedOn = c.DateTime(false),
                    CompanyReview_ModifiedOn = c.DateTime(false),
                    CompanyReview_CreatorIp = c.String(),
                    CompanyReview_ModifierIp = c.String(),
                    CompanyReview_ModifyLocked = c.Boolean(false),
                    CompanyReview_IsDeleted = c.Boolean(false),
                    CompanyReview_ModifierAgent = c.String(),
                    CompanyReview_CreatorAgent = c.String(),
                    CompanyReview_ReportedOn = c.DateTime(),
                    CompanyReview_ReportCount = c.Int(false),
                    CompanyReview_Version = c.Int(false),
                    CompanyReview_Action = c.Int(false),
                    CompanyReview_ModifiedById = c.Guid(false),
                    CompanyReview_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.CompanyReview_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyReview_CompanyId, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyReview_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyReview_ModifiedById, true)
                .Index(t => t.CompanyReview_CompanyId)
                .Index(t => t.CompanyReview_ModifiedById)
                .Index(t => t.CompanyReview_CreatedById);

            CreateTable(
                "dbo.AD_CompanySocials",
                c => new
                {
                    CompanySocial_Id = c.Guid(false),
                    CompanySocial_TwitterLink = c.String(maxLength: 100),
                    CompanySocial_FacebookLink = c.String(maxLength: 100),
                    CompanySocial_GooglePlusLink = c.String(maxLength: 100),
                    CompanySocial_YoutubeLink = c.String(maxLength: 100),
                    CompanySocial_CompanyId = c.Guid(false),
                    CompanySocial_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    CompanySocial_CreatedOn = c.DateTime(false),
                    CompanySocial_ModifiedOn = c.DateTime(false),
                    CompanySocial_CreatorIp = c.String(),
                    CompanySocial_ModifierIp = c.String(),
                    CompanySocial_ModifyLocked = c.Boolean(false),
                    CompanySocial_IsDeleted = c.Boolean(false),
                    CompanySocial_ModifierAgent = c.String(),
                    CompanySocial_CreatorAgent = c.String(),
                    CompanySocial_ReportedOn = c.DateTime(),
                    CompanySocial_ReportCount = c.Int(false),
                    CompanySocial_Version = c.Int(false),
                    CompanySocial_Action = c.Int(false),
                    CompanySocial_ModifiedById = c.Guid(false),
                    CompanySocial_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.CompanySocial_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanySocial_CompanyId, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanySocial_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanySocial_ModifiedById, true)
                .Index(t => t.CompanySocial_CompanyId)
                .Index(t => t.CompanySocial_ModifiedById)
                .Index(t => t.CompanySocial_CreatedById);

            CreateTable(
                "dbo.AD_CompanyVisits",
                c => new
                {
                    CompanyVisit_Id = c.Guid(false),
                    CompanyVisit_IsVisit = c.Boolean(false),
                    CompanyVisit_VisitedById = c.Guid(false),
                    CompanyVisit_CompanyId = c.Guid(false),
                    CompanyVisit_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    CompanyVisit_CreatedOn = c.DateTime(false),
                    CompanyVisit_ModifiedOn = c.DateTime(false),
                    CompanyVisit_CreatorIp = c.String(),
                    CompanyVisit_ModifierIp = c.String(),
                    CompanyVisit_ModifyLocked = c.Boolean(false),
                    CompanyVisit_IsDeleted = c.Boolean(false),
                    CompanyVisit_ModifierAgent = c.String(),
                    CompanyVisit_CreatorAgent = c.String(),
                    CompanyVisit_ReportedOn = c.DateTime(),
                    CompanyVisit_ReportCount = c.Int(false),
                    CompanyVisit_Version = c.Int(false),
                    CompanyVisit_Action = c.Int(false),
                    CompanyVisit_ModifiedById = c.Guid(false),
                    CompanyVisit_CreatedById = c.Guid(false),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.CompanyVisit_Id)
                .ForeignKey("dbo.AD_Companies", t => t.CompanyVisit_CompanyId, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyVisit_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyVisit_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CompanyVisit_VisitedById, true)
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
                    CategoryFollow_Id = c.Guid(false),
                    CategoryFollow_IsFollow = c.Boolean(false),
                    CategoryFollow_FollowedById = c.Guid(false),
                    CategoryFollow_CategoryId = c.Guid(false),
                    CategoryFollow_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    CategoryFollow_CreatedOn = c.DateTime(false),
                    CategoryFollow_ModifiedOn = c.DateTime(false),
                    CategoryFollow_CreatorIp = c.String(),
                    CategoryFollow_ModifierIp = c.String(),
                    CategoryFollow_ModifyLocked = c.Boolean(false),
                    CategoryFollow_IsDeleted = c.Boolean(false),
                    CategoryFollow_ModifierAgent = c.String(),
                    CategoryFollow_CreatorAgent = c.String(),
                    CategoryFollow_ReportedOn = c.DateTime(),
                    CategoryFollow_ReportCount = c.Int(false),
                    CategoryFollow_Version = c.Int(false),
                    CategoryFollow_Action = c.Int(false),
                    CategoryFollow_ModifiedById = c.Guid(false),
                    CategoryFollow_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.CategoryFollow_Id)
                .ForeignKey("dbo.AD_Categories", t => t.CategoryFollow_CategoryId, true)
                .ForeignKey("dbo.AD_Users", t => t.CategoryFollow_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CategoryFollow_FollowedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CategoryFollow_ModifiedById, true)
                .Index(t => t.CategoryFollow_FollowedById)
                .Index(t => t.CategoryFollow_CategoryId)
                .Index(t => t.CategoryFollow_ModifiedById)
                .Index(t => t.CategoryFollow_CreatedById);

            CreateTable(
                "dbo.AD_CategoryReviews",
                c => new
                {
                    CategoryReview_Id = c.Guid(false),
                    CategoryReview_Body = c.String(false, 1000),
                    CategoryReview_IsActive = c.Boolean(false),
                    CategoryReview_AuthoredById = c.Guid(false),
                    CategoryReview_CategoryId = c.Guid(false),
                    CategoryReview_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    CategoryReview_CreatedOn = c.DateTime(false),
                    CategoryReview_ModifiedOn = c.DateTime(false),
                    CategoryReview_CreatorIp = c.String(),
                    CategoryReview_ModifierIp = c.String(),
                    CategoryReview_ModifyLocked = c.Boolean(false),
                    CategoryReview_IsDeleted = c.Boolean(false),
                    CategoryReview_ModifierAgent = c.String(),
                    CategoryReview_CreatorAgent = c.String(),
                    CategoryReview_ReportedOn = c.DateTime(),
                    CategoryReview_ReportCount = c.Int(false),
                    CategoryReview_Version = c.Int(false),
                    CategoryReview_Action = c.Int(false),
                    CategoryReview_ModifiedById = c.Guid(false),
                    CategoryReview_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.CategoryReview_Id)
                .ForeignKey("dbo.AD_Users", t => t.CategoryReview_AuthoredById, true)
                .ForeignKey("dbo.AD_Categories", t => t.CategoryReview_CategoryId, true)
                .ForeignKey("dbo.AD_Users", t => t.CategoryReview_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.CategoryReview_ModifiedById, true)
                .Index(t => t.CategoryReview_AuthoredById)
                .Index(t => t.CategoryReview_CategoryId)
                .Index(t => t.CategoryReview_ModifiedById)
                .Index(t => t.CategoryReview_CreatedById);

            CreateTable(
                "dbo.AD_ProductComments",
                c => new
                {
                    ProductComment_Id = c.Guid(false),
                    ProductComment_Body = c.String(false, 500),
                    ProductComment_IsApproved = c.Boolean(false),
                    ProductComment_Status = c.Int(false),
                    ProductComment_CommentedById = c.Guid(false),
                    ProductComment_ApprovedById = c.Guid(false),
                    ProductComment_ProductId = c.Guid(false),
                    ProductComment_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    ProductComment_CreatedOn = c.DateTime(false),
                    ProductComment_ModifiedOn = c.DateTime(false),
                    ProductComment_CreatorIp = c.String(),
                    ProductComment_ModifierIp = c.String(),
                    ProductComment_ModifyLocked = c.Boolean(false),
                    ProductComment_IsDeleted = c.Boolean(false),
                    ProductComment_ModifierAgent = c.String(),
                    ProductComment_CreatorAgent = c.String(),
                    ProductComment_ReportedOn = c.DateTime(),
                    ProductComment_ReportCount = c.Int(false),
                    ProductComment_Version = c.Int(false),
                    ProductComment_Action = c.Int(false),
                    ProductComment_ModifiedById = c.Guid(false),
                    ProductComment_CreatedById = c.Guid(false),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.ProductComment_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductComment_ApprovedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ProductComment_CommentedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ProductComment_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ProductComment_ModifiedById, true)
                .ForeignKey("dbo.AD_Products", t => t.ProductComment_ProductId, true)
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
                    ProductImage_Id = c.Guid(false),
                    ProductImage_Title = c.String(maxLength: 100),
                    ProductImage_FileName = c.String(false, 100),
                    ProductImage_FileSize = c.String(false, 10),
                    ProductImage_FileDimension = c.String(false, 10),
                    ProductImage_Order = c.Int(false),
                    ProductImage_IsWatermarked = c.Boolean(false),
                    ProductImage_ProductId = c.Guid(false),
                    ProductImage_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    ProductImage_CreatedOn = c.DateTime(false),
                    ProductImage_ModifiedOn = c.DateTime(false),
                    ProductImage_CreatorIp = c.String(),
                    ProductImage_ModifierIp = c.String(),
                    ProductImage_ModifyLocked = c.Boolean(false),
                    ProductImage_IsDeleted = c.Boolean(false),
                    ProductImage_ModifierAgent = c.String(),
                    ProductImage_CreatorAgent = c.String(),
                    ProductImage_ReportedOn = c.DateTime(),
                    ProductImage_ReportCount = c.Int(false),
                    ProductImage_Version = c.Int(false),
                    ProductImage_Action = c.Int(false),
                    ProductImage_ModifiedById = c.Guid(false),
                    ProductImage_CreatedById = c.Guid(false),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.ProductImage_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductImage_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ProductImage_ModifiedById, true)
                .ForeignKey("dbo.AD_Products", t => t.ProductImage_ProductId, true)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.ProductImage_ProductId)
                .Index(t => t.ProductImage_ModifiedById)
                .Index(t => t.ProductImage_CreatedById)
                .Index(t => t.User_Id);

            CreateTable(
                "dbo.AD_ProduectLikes",
                c => new
                {
                    ProduectLike_Id = c.Guid(false),
                    ProduectLike_IsLike = c.Boolean(false),
                    ProduectLike_IsDisLike = c.Boolean(false),
                    ProduectLike_LikedById = c.Guid(false),
                    ProduectLike_ProductId = c.Guid(false),
                    ProduectLike_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    ProduectLike_CreatedOn = c.DateTime(false),
                    ProduectLike_ModifiedOn = c.DateTime(false),
                    ProduectLike_CreatorIp = c.String(),
                    ProduectLike_ModifierIp = c.String(),
                    ProduectLike_ModifyLocked = c.Boolean(false),
                    ProduectLike_IsDeleted = c.Boolean(false),
                    ProduectLike_ModifierAgent = c.String(),
                    ProduectLike_CreatorAgent = c.String(),
                    ProduectLike_ReportedOn = c.DateTime(),
                    ProduectLike_ReportCount = c.Int(false),
                    ProduectLike_Version = c.Int(false),
                    ProduectLike_Action = c.Int(false),
                    ProduectLike_ModifiedById = c.Guid(false),
                    ProduectLike_CreatedById = c.Guid(false),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.ProduectLike_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProduectLike_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ProduectLike_LikedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ProduectLike_ModifiedById, true)
                .ForeignKey("dbo.AD_Products", t => t.ProduectLike_ProductId, true)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.ProduectLike_LikedById)
                .Index(t => t.ProduectLike_ProductId)
                .Index(t => t.ProduectLike_ModifiedById)
                .Index(t => t.ProduectLike_CreatedById)
                .Index(t => t.User_Id);

            CreateTable(
                "dbo.AD_ProductProperties",
                c => new
                {
                    ProductProperty_Id = c.Guid(false),
                    ProductProperty_Value = c.String(false, 100),
                    ProductProperty_ProductId = c.Guid(false),
                    ProductProperty_PropertyId = c.Guid(false),
                    ProductProperty_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    ProductProperty_CreatedOn = c.DateTime(false),
                    ProductProperty_ModifiedOn = c.DateTime(false),
                    ProductProperty_CreatorIp = c.String(),
                    ProductProperty_ModifierIp = c.String(),
                    ProductProperty_ModifyLocked = c.Boolean(false),
                    ProductProperty_IsDeleted = c.Boolean(false),
                    ProductProperty_ModifierAgent = c.String(),
                    ProductProperty_CreatorAgent = c.String(),
                    ProductProperty_ReportedOn = c.DateTime(),
                    ProductProperty_ReportCount = c.Int(false),
                    ProductProperty_Version = c.Int(false),
                    ProductProperty_Action = c.Int(false),
                    ProductProperty_ModifiedById = c.Guid(false),
                    ProductProperty_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.ProductProperty_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductProperty_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ProductProperty_ModifiedById, true)
                .ForeignKey("dbo.AD_Products", t => t.ProductProperty_ProductId, true)
                .ForeignKey("dbo.AD_Properties", t => t.ProductProperty_PropertyId, true)
                .Index(t => t.ProductProperty_ProductId)
                .Index(t => t.ProductProperty_PropertyId)
                .Index(t => t.ProductProperty_ModifiedById)
                .Index(t => t.ProductProperty_CreatedById);

            CreateTable(
                "dbo.AD_Properties",
                c => new
                {
                    Property_Id = c.Guid(false),
                    Property_Title = c.String(false, 50),
                    Property_Type = c.Int(false),
                    Property_Description = c.String(),
                    Property_Order = c.Int(false),
                    Property_CategoryId = c.Guid(false),
                    Property_RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    Property_CreatedOn = c.DateTime(false),
                    Property_ModifiedOn = c.DateTime(false),
                    Property_CreatorIp = c.String(),
                    Property_ModifierIp = c.String(),
                    Property_ModifyLocked = c.Boolean(false),
                    Property_IsDeleted = c.Boolean(false),
                    Property_ModifierAgent = c.String(),
                    Property_CreatorAgent = c.String(),
                    Property_ReportedOn = c.DateTime(),
                    Property_ReportCount = c.Int(false),
                    Property_Version = c.Int(false),
                    Property_Action = c.Int(false),
                    Property_ModifiedById = c.Guid(false),
                    Property_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.Property_Id)
                .ForeignKey("dbo.AD_Categories", t => t.Property_CategoryId, true)
                .ForeignKey("dbo.AD_Users", t => t.Property_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Property_ModifiedById, true)
                .Index(t => t.Property_CategoryId)
                .Index(t => t.Property_ModifiedById)
                .Index(t => t.Property_CreatedById);

            CreateTable(
                "dbo.AD_ProductReports",
                c => new
                {
                    ProductReport_Id = c.Guid(false),
                    ProductReport_Type = c.Int(false),
                    ProductReport_Reason = c.String(),
                    ProductReport_IsRead = c.Boolean(false),
                    ProductReport_ReportedById = c.Guid(false),
                    ProductReport_ReportedForId = c.Guid(false),
                    ProductReport_RowVersion = c.Binary(),
                    ProductReport_CreatedOn = c.DateTime(false),
                    ProductReport_ModifiedOn = c.DateTime(false),
                    ProductReport_CreatorIp = c.String(),
                    ProductReport_ModifierIp = c.String(),
                    ProductReport_ModifyLocked = c.Boolean(false),
                    ProductReport_IsDeleted = c.Boolean(false),
                    ProductReport_ModifierAgent = c.String(),
                    ProductReport_CreatorAgent = c.String(),
                    ProductReport_ReportedOn = c.DateTime(),
                    ProductReport_ReportCount = c.Int(false),
                    ProductReport_Version = c.Int(false),
                    ProductReport_Action = c.Int(false),
                    ProductReport_ModifiedById = c.Guid(false),
                    ProductReport_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.ProductReport_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductReport_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ProductReport_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ProductReport_ReportedById, true)
                .ForeignKey("dbo.AD_Products", t => t.ProductReport_ReportedForId, true)
                .Index(t => t.ProductReport_ReportedById)
                .Index(t => t.ProductReport_ReportedForId)
                .Index(t => t.ProductReport_ModifiedById)
                .Index(t => t.ProductReport_CreatedById);

            CreateTable(
                "dbo.AD_ProductShares",
                c => new
                {
                    ProductShare_Id = c.Guid(false),
                    ProductShare_RowVersion = c.Binary(),
                    ProductShare_CreatedOn = c.DateTime(false),
                    ProductShare_ModifiedOn = c.DateTime(false),
                    ProductShare_CreatorIp = c.String(),
                    ProductShare_ModifierIp = c.String(),
                    ProductShare_ModifyLocked = c.Boolean(false),
                    ProductShare_IsDeleted = c.Boolean(false),
                    ProductShare_ModifierAgent = c.String(),
                    ProductShare_CreatorAgent = c.String(),
                    ProductShare_ReportedOn = c.DateTime(),
                    ProductShare_ReportCount = c.Int(false),
                    ProductShare_Version = c.Int(false),
                    ProductShare_Action = c.Int(false),
                    ProductShare_ModifiedById = c.Guid(false),
                    ProductShare_CreatedById = c.Guid(false),
                    Product_Id = c.Guid()
                })
                .PrimaryKey(t => t.ProductShare_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductShare_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ProductShare_ModifiedById, true)
                .ForeignKey("dbo.AD_Products", t => t.Product_Id)
                .Index(t => t.ProductShare_ModifiedById)
                .Index(t => t.ProductShare_CreatedById)
                .Index(t => t.Product_Id);

            CreateTable(
                "dbo.AD_ProductVisits",
                c => new
                {
                    ProductVisit_Id = c.Guid(false),
                    ProductVisit_IsVisit = c.Boolean(false),
                    ProductVisit_VisitedById = c.Guid(false),
                    ProductVisit_ProductId = c.Guid(false),
                    ProductVisit_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    ProductVisit_CreatedOn = c.DateTime(false),
                    ProductVisit_ModifiedOn = c.DateTime(false),
                    ProductVisit_CreatorIp = c.String(),
                    ProductVisit_ModifierIp = c.String(),
                    ProductVisit_ModifyLocked = c.Boolean(false),
                    ProductVisit_IsDeleted = c.Boolean(false),
                    ProductVisit_ModifierAgent = c.String(),
                    ProductVisit_CreatorAgent = c.String(),
                    ProductVisit_ReportedOn = c.DateTime(),
                    ProductVisit_ReportCount = c.Int(false),
                    ProductVisit_Version = c.Int(false),
                    ProductVisit_Action = c.Int(false),
                    ProductVisit_ModifiedById = c.Guid(false),
                    ProductVisit_CreatedById = c.Guid(false),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.ProductVisit_Id)
                .ForeignKey("dbo.AD_Users", t => t.ProductVisit_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ProductVisit_ModifiedById, true)
                .ForeignKey("dbo.AD_Products", t => t.ProductVisit_ProductId, true)
                .ForeignKey("dbo.AD_Users", t => t.ProductVisit_VisitedById, true)
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
                    Tag_Id = c.Guid(false),
                    Tag_Code = c.String(),
                    Tag_Title = c.String(),
                    Tag_Description = c.String(),
                    Tag_CostRialValue = c.String(),
                    Tag_CostUsdValue = c.Long(false),
                    Tag_DurationDay = c.String(),
                    Tag_Type = c.Int(false),
                    Tag_IsActive = c.Boolean(false),
                    Tag_StartedOn = c.DateTime(false),
                    Tag_ExpiredOn = c.DateTime(false),
                    Tag_RowVersion = c.Binary(),
                    Tag_CreatedOn = c.DateTime(false),
                    Tag_ModifiedOn = c.DateTime(false),
                    Tag_CreatorIp = c.String(),
                    Tag_ModifierIp = c.String(),
                    Tag_ModifyLocked = c.Boolean(false),
                    Tag_IsDeleted = c.Boolean(false),
                    Tag_ModifierAgent = c.String(),
                    Tag_CreatorAgent = c.String(),
                    Tag_ReportedOn = c.DateTime(),
                    Tag_ReportCount = c.Int(false),
                    Tag_Version = c.Int(false),
                    Tag_Action = c.Int(false),
                    Tag_ModifiedById = c.Guid(false),
                    Tag_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.Tag_Id)
                .ForeignKey("dbo.AD_Users", t => t.Tag_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Tag_ModifiedById, true)
                .Index(t => t.Tag_ModifiedById)
                .Index(t => t.Tag_CreatedById);

            CreateTable(
                "dbo.AD_UserClaims",
                c => new
                {
                    UserClaim_Id = c.Int(false, true),
                    UserClaim_RowVersion = c.Binary(),
                    UserClaim_UserId = c.Guid(false),
                    UserClaim_ClaimType = c.String(),
                    UserClaim_ClaimValue = c.String()
                })
                .PrimaryKey(t => t.UserClaim_Id)
                .ForeignKey("dbo.AD_Users", t => t.UserClaim_UserId, true)
                .Index(t => t.UserClaim_UserId);

            CreateTable(
                "dbo.AD_UserLogins",
                c => new
                {
                    UserLogin_UserId = c.Guid(false),
                    UserLogin_RowVersion = c.Binary(),
                    UserLogin_LoginProvider = c.String(),
                    UserLogin_ProviderKey = c.String(),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.UserLogin_UserId)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.User_Id);

            CreateTable(
                "dbo.AD_ProductCommentLikes",
                c => new
                {
                    ProductCommentLike_Id = c.Guid(false),
                    ProductCommentLike_IsLike = c.Boolean(false),
                    ProductCommentLike_IsDisLike = c.Boolean(false),
                    ProductCommentLike_LikedById = c.Guid(false),
                    ProductCommentLike_CommentId = c.Guid(false),
                    ProductCommentLike_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    ProductCommentLike_CreatedOn = c.DateTime(false),
                    ProductCommentLike_ModifiedOn = c.DateTime(false),
                    ProductCommentLike_CreatorIp = c.String(),
                    ProductCommentLike_ModifierIp = c.String(),
                    ProductCommentLike_ModifyLocked = c.Boolean(false),
                    ProductCommentLike_IsDeleted = c.Boolean(false),
                    ProductCommentLike_ModifierAgent = c.String(),
                    ProductCommentLike_CreatorAgent = c.String(),
                    ProductCommentLike_ReportedOn = c.DateTime(),
                    ProductCommentLike_ReportCount = c.Int(false),
                    ProductCommentLike_Version = c.Int(false),
                    ProductCommentLike_Action = c.Int(false),
                    ProductCommentLike_ModifiedById = c.Guid(false),
                    ProductCommentLike_CreatedById = c.Guid(false),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.ProductCommentLike_Id)
                .ForeignKey("dbo.AD_ProductComments", t => t.ProductCommentLike_CommentId, true)
                .ForeignKey("dbo.AD_Users", t => t.ProductCommentLike_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ProductCommentLike_LikedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ProductCommentLike_ModifiedById, true)
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
                    UserProfile_Id = c.Guid(false),
                    UserProfile_Code = c.String(),
                    UserProfile_FirstName = c.String(),
                    UserProfile_LastName = c.String(),
                    UserProfile_DisplayName = c.String(),
                    UserProfile_NationalCode = c.String(),
                    UserProfile_BirthDate = c.DateTime(),
                    UserProfile_MarriedDate = c.DateTime(),
                    UserProfile_AvatarFileName = c.String(),
                    UserProfile_IsActive = c.Boolean(false),
                    UserProfile_Gender = c.Int(),
                    UserProfile_AboutMe = c.String(),
                    UserProfile_OwnedById = c.Guid(false),
                    UserProfile_AddressId = c.Guid(false),
                    UserProfile_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    UserProfile_CreatedOn = c.DateTime(false),
                    UserProfile_ModifiedOn = c.DateTime(false),
                    UserProfile_CreatorIp = c.String(),
                    UserProfile_ModifierIp = c.String(),
                    UserProfile_ModifyLocked = c.Boolean(false),
                    UserProfile_IsDeleted = c.Boolean(false),
                    UserProfile_ModifierAgent = c.String(),
                    UserProfile_CreatorAgent = c.String(),
                    UserProfile_ReportedOn = c.DateTime(),
                    UserProfile_ReportCount = c.Int(false),
                    UserProfile_Version = c.Int(false),
                    UserProfile_Action = c.Int(false),
                    UserProfile_ModifiedById = c.Guid(false),
                    UserProfile_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.UserProfile_Id)
                .ForeignKey("dbo.AD_Addresses", t => t.UserProfile_AddressId, true)
                .ForeignKey("dbo.AD_Users", t => t.UserProfile_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.UserProfile_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.UserProfile_OwnedById, true)
                .Index(t => t.UserProfile_OwnedById)
                .Index(t => t.UserProfile_AddressId)
                .Index(t => t.UserProfile_ModifiedById)
                .Index(t => t.UserProfile_CreatedById);

            CreateTable(
                "dbo.AD_UserReports",
                c => new
                {
                    UserReport_Id = c.Guid(false),
                    UserReport_Type = c.Int(false),
                    UserReport_Reason = c.String(),
                    UserReport_IsRead = c.Boolean(false),
                    UserReport_ReportedById = c.Guid(false),
                    UserReport_ReportedForId = c.Guid(false),
                    UserReport_RowVersion = c.Binary(),
                    UserReport_CreatedOn = c.DateTime(false),
                    UserReport_ModifiedOn = c.DateTime(false),
                    UserReport_CreatorIp = c.String(),
                    UserReport_ModifierIp = c.String(),
                    UserReport_ModifyLocked = c.Boolean(false),
                    UserReport_IsDeleted = c.Boolean(false),
                    UserReport_ModifierAgent = c.String(),
                    UserReport_CreatorAgent = c.String(),
                    UserReport_ReportedOn = c.DateTime(),
                    UserReport_ReportCount = c.Int(false),
                    UserReport_Version = c.Int(false),
                    UserReport_Action = c.Int(false),
                    UserReport_ModifiedById = c.Guid(false),
                    UserReport_CreatedById = c.Guid(false),
                    User_Id = c.Guid()
                })
                .PrimaryKey(t => t.UserReport_Id)
                .ForeignKey("dbo.AD_Users", t => t.UserReport_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.UserReport_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.UserReport_ReportedById, true)
                .ForeignKey("dbo.AD_Users", t => t.UserReport_ReportedForId, true)
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
                    UserRole_RoleId = c.Guid(false),
                    UserRole_RowVersion = c.Binary(),
                    UserRole_UserId = c.Guid(false),
                    Role_Id = c.Guid()
                })
                .PrimaryKey(t => t.UserRole_RoleId)
                .ForeignKey("dbo.AD_Users", t => t.UserRole_UserId, true)
                .ForeignKey("dbo.AD_Roles", t => t.Role_Id)
                .Index(t => t.UserRole_UserId)
                .Index(t => t.Role_Id);

            CreateTable(
                "dbo.AD_UserSettings",
                c => new
                {
                    UserSetting_Id = c.Guid(false),
                    UserSetting_Language = c.Int(),
                    UserSetting_Theme = c.Int(),
                    UserSetting_OwnedById = c.Guid(false),
                    UserSetting_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    UserSetting_CreatedOn = c.DateTime(false),
                    UserSetting_ModifiedOn = c.DateTime(false),
                    UserSetting_CreatorIp = c.String(),
                    UserSetting_ModifierIp = c.String(),
                    UserSetting_ModifyLocked = c.Boolean(false),
                    UserSetting_IsDeleted = c.Boolean(false),
                    UserSetting_ModifierAgent = c.String(),
                    UserSetting_CreatorAgent = c.String(),
                    UserSetting_ReportedOn = c.DateTime(),
                    UserSetting_ReportCount = c.Int(false),
                    UserSetting_Version = c.Int(false),
                    UserSetting_Action = c.Int(false),
                    UserSetting_ModifiedById = c.Guid(false),
                    UserSetting_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.UserSetting_Id)
                .ForeignKey("dbo.AD_Users", t => t.UserSetting_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.UserSetting_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.UserSetting_OwnedById, true)
                .Index(t => t.UserSetting_OwnedById)
                .Index(t => t.UserSetting_ModifiedById)
                .Index(t => t.UserSetting_CreatedById);

            CreateTable(
                "dbo.AD_UserSocials",
                c => new
                {
                    UserSocial_Id = c.Guid(false),
                    UserSocial_TwitterLink = c.String(maxLength: 100),
                    UserSocial_FacebookLink = c.String(maxLength: 100),
                    UserSocial_GooglePlusLink = c.String(maxLength: 100),
                    UserSocial_YoutubeLink = c.String(maxLength: 100),
                    UserSocial_OwnedById = c.Guid(false),
                    UserSocial_RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    UserSocial_CreatedOn = c.DateTime(false),
                    UserSocial_ModifiedOn = c.DateTime(false),
                    UserSocial_CreatorIp = c.String(),
                    UserSocial_ModifierIp = c.String(),
                    UserSocial_ModifyLocked = c.Boolean(false),
                    UserSocial_IsDeleted = c.Boolean(false),
                    UserSocial_ModifierAgent = c.String(),
                    UserSocial_CreatorAgent = c.String(),
                    UserSocial_ReportedOn = c.DateTime(),
                    UserSocial_ReportCount = c.Int(false),
                    UserSocial_Version = c.Int(false),
                    UserSocial_Action = c.Int(false),
                    UserSocial_ModifiedById = c.Guid(false),
                    UserSocial_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.UserSocial_Id)
                .ForeignKey("dbo.AD_Users", t => t.UserSocial_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.UserSocial_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.UserSocial_OwnedById, true)
                .Index(t => t.UserSocial_OwnedById)
                .Index(t => t.UserSocial_ModifiedById)
                .Index(t => t.UserSocial_CreatedById);

            CreateTable(
                "dbo.AD_Conversations",
                c => new
                {
                    Conversation_Id = c.Guid(false),
                    Conversation_Title = c.String(maxLength: 200),
                    Conversation_Body = c.String(false, 2000),
                    Conversation_IsRead = c.Boolean(false),
                    Conversation_IsDeletedBySender = c.Boolean(false),
                    Conversation_IsDeletedByReceiver = c.Boolean(false),
                    Conversation_SentOn = c.DateTime(false),
                    Conversation_SendedById = c.Guid(false),
                    Conversation_ReceivedById = c.Guid(false),
                    Conversation_ReplyId = c.Guid(false),
                    Conversation_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    Conversation_CreatedOn = c.DateTime(false),
                    Conversation_ModifiedOn = c.DateTime(false),
                    Conversation_CreatorIp = c.String(),
                    Conversation_ModifierIp = c.String(),
                    Conversation_ModifyLocked = c.Boolean(false),
                    Conversation_IsDeleted = c.Boolean(false),
                    Conversation_ModifierAgent = c.String(),
                    Conversation_CreatorAgent = c.String(),
                    Conversation_ReportedOn = c.DateTime(),
                    Conversation_ReportCount = c.Int(false),
                    Conversation_Version = c.Int(false),
                    Conversation_Action = c.Int(false),
                    Conversation_ModifiedById = c.Guid(false),
                    Conversation_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.Conversation_Id)
                .ForeignKey("dbo.AD_Conversations", t => t.Conversation_ReplyId)
                .ForeignKey("dbo.AD_Users", t => t.Conversation_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Conversation_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Conversation_ReceivedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Conversation_SendedById, true)
                .Index(t => t.Conversation_SendedById)
                .Index(t => t.Conversation_ReceivedById)
                .Index(t => t.Conversation_ReplyId)
                .Index(t => t.Conversation_ModifiedById)
                .Index(t => t.Conversation_CreatedById);

            CreateTable(
                "dbo.AD_News",
                c => new
                {
                    News_Id = c.Guid(false),
                    News_Title = c.String(maxLength: 200),
                    News_Message = c.String(false, 2000),
                    News_IsActive = c.Boolean(false),
                    News_ExpiredOn = c.DateTime(),
                    News_OwnedById = c.Guid(false),
                    News_RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    News_CreatedOn = c.DateTime(false),
                    News_ModifiedOn = c.DateTime(false),
                    News_CreatorIp = c.String(),
                    News_ModifierIp = c.String(),
                    News_ModifyLocked = c.Boolean(false),
                    News_IsDeleted = c.Boolean(false),
                    News_ModifierAgent = c.String(),
                    News_CreatorAgent = c.String(),
                    News_ReportedOn = c.DateTime(),
                    News_ReportCount = c.Int(false),
                    News_Version = c.Int(false),
                    News_Action = c.Int(false),
                    News_ModifiedById = c.Guid(false),
                    News_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.News_Id)
                .ForeignKey("dbo.AD_Users", t => t.News_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.News_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.News_OwnedById, true)
                .Index(t => t.News_OwnedById)
                .Index(t => t.News_ModifiedById)
                .Index(t => t.News_CreatedById);

            CreateTable(
                "dbo.AD_Notifications",
                c => new
                {
                    Notification_Id = c.Guid(false),
                    Notification_IsRead = c.Boolean(false),
                    Notification_Url = c.String(),
                    Notification_Message = c.String(),
                    Notification_ReadOn = c.DateTime(),
                    Notification_Type = c.Int(false),
                    Notification_OwnerId = c.Guid(false),
                    Notification_RowVersion =
                        c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    Notification_CreatedOn = c.DateTime(false),
                    Notification_ModifiedOn = c.DateTime(false),
                    Notification_CreatorIp = c.String(),
                    Notification_ModifierIp = c.String(),
                    Notification_ModifyLocked = c.Boolean(false),
                    Notification_IsDeleted = c.Boolean(false),
                    Notification_ModifierAgent = c.String(),
                    Notification_CreatorAgent = c.String(),
                    Notification_ReportedOn = c.DateTime(),
                    Notification_ReportCount = c.Int(false),
                    Notification_Version = c.Int(false),
                    Notification_Action = c.Int(false),
                    Notification_ModifiedById = c.Guid(false),
                    Notification_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.Notification_Id)
                .ForeignKey("dbo.AD_Users", t => t.Notification_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Notification_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Notification_OwnerId, true)
                .Index(t => t.Notification_OwnerId)
                .Index(t => t.Notification_ModifiedById)
                .Index(t => t.Notification_CreatedById);

            CreateTable(
                "dbo.AD_Payments",
                c => new
                {
                    Payment_Id = c.Guid(false),
                    Payment_Status = c.Int(false),
                    Payment_RowVersion = c.Binary(),
                    Payment_CreatedOn = c.DateTime(false),
                    Payment_ModifiedOn = c.DateTime(false),
                    Payment_CreatorIp = c.String(),
                    Payment_ModifierIp = c.String(),
                    Payment_ModifyLocked = c.Boolean(false),
                    Payment_IsDeleted = c.Boolean(false),
                    Payment_ModifierAgent = c.String(),
                    Payment_CreatorAgent = c.String(),
                    Payment_ReportedOn = c.DateTime(),
                    Payment_ReportCount = c.Int(false),
                    Payment_Version = c.Int(false),
                    Payment_Action = c.Int(false),
                    Payment_ModifiedById = c.Guid(false),
                    Payment_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.Payment_Id)
                .ForeignKey("dbo.AD_Users", t => t.Payment_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Payment_ModifiedById, true)
                .Index(t => t.Payment_ModifiedById)
                .Index(t => t.Payment_CreatedById);

            CreateTable(
                "dbo.AD_PaymentTransactions",
                c => new
                {
                    PaymentTransaction_Id = c.Guid(false),
                    PaymentTransaction_ReferenceCode = c.String(),
                    PaymentTransaction_Value = c.Long(false),
                    PaymentTransaction_IsSuccess = c.Boolean(false),
                    PaymentTransaction_PayedById = c.Guid(false),
                    PaymentTransaction_BudgetId = c.Guid(false),
                    PaymentTransaction_RowVersion = c.Binary(),
                    PaymentTransaction_CreatedOn = c.DateTime(false),
                    PaymentTransaction_ModifiedOn = c.DateTime(false),
                    PaymentTransaction_CreatorIp = c.String(),
                    PaymentTransaction_ModifierIp = c.String(),
                    PaymentTransaction_ModifyLocked = c.Boolean(false),
                    PaymentTransaction_IsDeleted = c.Boolean(false),
                    PaymentTransaction_ModifierAgent = c.String(),
                    PaymentTransaction_CreatorAgent = c.String(),
                    PaymentTransaction_ReportedOn = c.DateTime(),
                    PaymentTransaction_ReportCount = c.Int(false),
                    PaymentTransaction_Version = c.Int(false),
                    PaymentTransaction_Action = c.Int(false),
                    PaymentTransaction_ModifiedById = c.Guid(false),
                    PaymentTransaction_CreatedById = c.Guid(false),
                    Payment_Id = c.Guid()
                })
                .PrimaryKey(t => t.PaymentTransaction_Id)
                .ForeignKey("dbo.AD_UserBudgets", t => t.PaymentTransaction_BudgetId, true)
                .ForeignKey("dbo.AD_Users", t => t.PaymentTransaction_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.PaymentTransaction_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.PaymentTransaction_PayedById, true)
                .ForeignKey("dbo.AD_Payments", t => t.Payment_Id)
                .Index(t => t.PaymentTransaction_PayedById)
                .Index(t => t.PaymentTransaction_BudgetId)
                .Index(t => t.PaymentTransaction_ModifiedById)
                .Index(t => t.PaymentTransaction_CreatedById)
                .Index(t => t.Payment_Id);

            CreateTable(
                "dbo.AD_Statistics",
                c => new
                {
                    Statistic_Id = c.Guid(false),
                    Statistic_Ip = c.String(false),
                    Statistic_Date = c.DateTime(false),
                    Statistic_Browser = c.String(false),
                    Statistic_SearchEngine = c.String(),
                    Statistic_Keyword = c.String(),
                    Statistic_RowVersion = c.Binary(),
                    Statistic_CreatedOn = c.DateTime(false),
                    Statistic_ModifiedOn = c.DateTime(false),
                    Statistic_CreatorIp = c.String(),
                    Statistic_ModifierIp = c.String(),
                    Statistic_ModifyLocked = c.Boolean(false),
                    Statistic_IsDeleted = c.Boolean(false),
                    Statistic_ModifierAgent = c.String(),
                    Statistic_CreatorAgent = c.String(),
                    Statistic_ReportedOn = c.DateTime(),
                    Statistic_ReportCount = c.Int(false),
                    Statistic_Version = c.Int(false),
                    Statistic_Action = c.Int(false),
                    Statistic_ModifiedById = c.Guid(false),
                    Statistic_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.Statistic_Id)
                .ForeignKey("dbo.AD_Users", t => t.Statistic_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.Statistic_ModifiedById, true)
                .Index(t => t.Statistic_ModifiedById)
                .Index(t => t.Statistic_CreatedById);

            CreateTable(
                "dbo.AD_ActivityLogs",
                c => new
                {
                    ActivityLog_Id = c.Guid(false),
                    ActivityLog_Comment = c.String(),
                    ActivityLog_OperatedOn = c.DateTime(false),
                    ActivityLog_Url = c.String(),
                    ActivityLog_Title = c.String(),
                    ActivityLog_Agent = c.String(),
                    ActivityLog_OperantIp = c.String(),
                    ActivityLog_Type = c.Int(false),
                    ActivityLog_OperantedById = c.Guid(false),
                    ActivityLog_RowVersion = c.Binary(),
                    ActivityLog_CreatedOn = c.DateTime(false),
                    ActivityLog_ModifiedOn = c.DateTime(false),
                    ActivityLog_CreatorIp = c.String(),
                    ActivityLog_ModifierIp = c.String(),
                    ActivityLog_ModifyLocked = c.Boolean(false),
                    ActivityLog_IsDeleted = c.Boolean(false),
                    ActivityLog_ModifierAgent = c.String(),
                    ActivityLog_CreatorAgent = c.String(),
                    ActivityLog_ReportedOn = c.DateTime(),
                    ActivityLog_ReportCount = c.Int(false),
                    ActivityLog_Version = c.Int(false),
                    ActivityLog_Action = c.Int(false),
                    ActivityLog_ModifiedById = c.Guid(false),
                    ActivityLog_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.ActivityLog_Id)
                .ForeignKey("dbo.AD_Users", t => t.ActivityLog_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ActivityLog_ModifiedById, true)
                .ForeignKey("dbo.AD_Users", t => t.ActivityLog_OperantedById, true)
                .Index(t => t.ActivityLog_OperantedById)
                .Index(t => t.ActivityLog_ModifiedById)
                .Index(t => t.ActivityLog_CreatedById);

            CreateTable(
                "dbo.AD_AuditLogs",
                c => new
                {
                    AuditLog_Id = c.Guid(false),
                    AuditLog_RowVersion = c.Binary(false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    AuditLog_CreatedOn = c.DateTime(false),
                    AuditLog_ModifiedOn = c.DateTime(false),
                    AuditLog_CreatorIp = c.String(),
                    AuditLog_ModifierIp = c.String(),
                    AuditLog_ModifyLocked = c.Boolean(false),
                    AuditLog_IsDeleted = c.Boolean(false),
                    AuditLog_ModifierAgent = c.String(),
                    AuditLog_CreatorAgent = c.String(),
                    AuditLog_ReportedOn = c.DateTime(),
                    AuditLog_ReportCount = c.Int(false),
                    AuditLog_Version = c.Int(false),
                    AuditLog_Action = c.Int(false),
                    AuditLog_ModifiedById = c.Guid(false),
                    AuditLog_CreatedById = c.Guid(false)
                })
                .PrimaryKey(t => t.AuditLog_Id)
                .ForeignKey("dbo.AD_Users", t => t.AuditLog_CreatedById, true)
                .ForeignKey("dbo.AD_Users", t => t.AuditLog_ModifiedById, true)
                .Index(t => t.AuditLog_ModifiedById)
                .Index(t => t.AuditLog_CreatedById);

            CreateTable(
                "dbo.CompanyCategories",
                c => new
                {
                    Company_Id = c.Guid(false),
                    Category_Id = c.Guid(false)
                })
                .PrimaryKey(t => new {t.Company_Id, t.Category_Id})
                .ForeignKey("dbo.AD_Companies", t => t.Company_Id, true)
                .ForeignKey("dbo.AD_Categories", t => t.Category_Id, true)
                .Index(t => t.Company_Id)
                .Index(t => t.Category_Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.AD_AuditLogs", "AuditLog_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_AuditLogs", "AuditLog_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ActivityLogs", "ActivityLog_OperantedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ActivityLogs", "ActivityLog_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ActivityLogs", "ActivityLog_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Statistics", "Statistic_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Statistics", "Statistic_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_PaymentTransactions", "Payment_Id", "dbo.AD_Payments");
            DropForeignKey("dbo.AD_PaymentTransactions", "PaymentTransaction_PayedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_PaymentTransactions", "PaymentTransaction_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_PaymentTransactions", "PaymentTransaction_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_PaymentTransactions", "PaymentTransaction_BudgetId", "dbo.AD_UserBudgets");
            DropForeignKey("dbo.AD_Payments", "Payment_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Payments", "Payment_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Notifications", "Notification_OwnerId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Notifications", "Notification_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Notifications", "Notification_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_News", "News_OwnedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_News", "News_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_News", "News_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Conversations", "Conversation_SendedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Conversations", "Conversation_ReceivedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Conversations", "Conversation_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Conversations", "Conversation_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Conversations", "Conversation_ReplyId", "dbo.AD_Conversations");
            DropForeignKey("dbo.AD_UserRoles", "Role_Id", "dbo.AD_Roles");
            DropForeignKey("dbo.AD_RoleActions", "RoleAction_RoleId", "dbo.AD_Roles");
            DropForeignKey("dbo.AD_RoleActions", "RoleAction_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_RoleActions", "RoleAction_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Users", "Social_Id", "dbo.AD_UserSocials");
            DropForeignKey("dbo.AD_UserSocials", "UserSocial_OwnedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserSocials", "UserSocial_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserSocials", "UserSocial_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Users", "Setting_Id", "dbo.AD_UserSettings");
            DropForeignKey("dbo.AD_UserSettings", "UserSetting_OwnedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserSettings", "UserSetting_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserSettings", "UserSetting_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserRoles", "UserRole_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserReports", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserReports", "UserReport_ReportedForId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserReports", "UserReport_ReportedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserReports", "UserReport_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_UserReports", "UserReport_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Users", "Profile_Id", "dbo.AD_UserProfiles");
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
            DropForeignKey("dbo.AD_ProduectLikes", "User_Id", "dbo.AD_Users");
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
            DropForeignKey("dbo.AD_ProductShares", "Product_Id", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProductShares", "ProductShare_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductShares", "ProductShare_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Products", "Review_Id", "dbo.AD_CompanyReviews");
            DropForeignKey("dbo.AD_ProductReports", "ProductReport_ReportedForId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProductReports", "ProductReport_ReportedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductReports", "ProductReport_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductReports", "ProductReport_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductProperties", "ProductProperty_PropertyId", "dbo.AD_Properties");
            DropForeignKey("dbo.AD_Properties", "Property_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Properties", "Property_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Properties", "Property_CategoryId", "dbo.AD_Categories");
            DropForeignKey("dbo.AD_ProductProperties", "ProductProperty_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProductProperties", "ProductProperty_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProductProperties", "ProductProperty_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Products", "Product_OwnedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Products", "Product_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProduectLikes", "ProduectLike_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_ProduectLikes", "ProduectLike_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProduectLikes", "ProduectLike_LikedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_ProduectLikes", "ProduectLike_CreatedById", "dbo.AD_Users");
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
            DropForeignKey("dbo.AD_CompanyQuestionReports", "CompanyQuestionReport_ReportedForId",
                "dbo.AD_CompanyQuestions");
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
            DropForeignKey("dbo.AD_Addresses", "Address_CityId", "dbo.AD_Cities");
            DropForeignKey("dbo.AD_Cities", "City_ModifiedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Cities", "City_CreatedById", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Cities", "City_ParentId", "dbo.AD_Cities");
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
            DropIndex("dbo.CompanyCategories", new[] {"Category_Id"});
            DropIndex("dbo.CompanyCategories", new[] {"Company_Id"});
            DropIndex("dbo.AD_AuditLogs", new[] {"AuditLog_CreatedById"});
            DropIndex("dbo.AD_AuditLogs", new[] {"AuditLog_ModifiedById"});
            DropIndex("dbo.AD_ActivityLogs", new[] {"ActivityLog_CreatedById"});
            DropIndex("dbo.AD_ActivityLogs", new[] {"ActivityLog_ModifiedById"});
            DropIndex("dbo.AD_ActivityLogs", new[] {"ActivityLog_OperantedById"});
            DropIndex("dbo.AD_Statistics", new[] {"Statistic_CreatedById"});
            DropIndex("dbo.AD_Statistics", new[] {"Statistic_ModifiedById"});
            DropIndex("dbo.AD_PaymentTransactions", new[] {"Payment_Id"});
            DropIndex("dbo.AD_PaymentTransactions", new[] {"PaymentTransaction_CreatedById"});
            DropIndex("dbo.AD_PaymentTransactions", new[] {"PaymentTransaction_ModifiedById"});
            DropIndex("dbo.AD_PaymentTransactions", new[] {"PaymentTransaction_BudgetId"});
            DropIndex("dbo.AD_PaymentTransactions", new[] {"PaymentTransaction_PayedById"});
            DropIndex("dbo.AD_Payments", new[] {"Payment_CreatedById"});
            DropIndex("dbo.AD_Payments", new[] {"Payment_ModifiedById"});
            DropIndex("dbo.AD_Notifications", new[] {"Notification_CreatedById"});
            DropIndex("dbo.AD_Notifications", new[] {"Notification_ModifiedById"});
            DropIndex("dbo.AD_Notifications", new[] {"Notification_OwnerId"});
            DropIndex("dbo.AD_News", new[] {"News_CreatedById"});
            DropIndex("dbo.AD_News", new[] {"News_ModifiedById"});
            DropIndex("dbo.AD_News", new[] {"News_OwnedById"});
            DropIndex("dbo.AD_Conversations", new[] {"Conversation_CreatedById"});
            DropIndex("dbo.AD_Conversations", new[] {"Conversation_ModifiedById"});
            DropIndex("dbo.AD_Conversations", new[] {"Conversation_ReplyId"});
            DropIndex("dbo.AD_Conversations", new[] {"Conversation_ReceivedById"});
            DropIndex("dbo.AD_Conversations", new[] {"Conversation_SendedById"});
            DropIndex("dbo.AD_UserSocials", new[] {"UserSocial_CreatedById"});
            DropIndex("dbo.AD_UserSocials", new[] {"UserSocial_ModifiedById"});
            DropIndex("dbo.AD_UserSocials", new[] {"UserSocial_OwnedById"});
            DropIndex("dbo.AD_UserSettings", new[] {"UserSetting_CreatedById"});
            DropIndex("dbo.AD_UserSettings", new[] {"UserSetting_ModifiedById"});
            DropIndex("dbo.AD_UserSettings", new[] {"UserSetting_OwnedById"});
            DropIndex("dbo.AD_UserRoles", new[] {"Role_Id"});
            DropIndex("dbo.AD_UserRoles", new[] {"UserRole_UserId"});
            DropIndex("dbo.AD_UserReports", new[] {"User_Id"});
            DropIndex("dbo.AD_UserReports", new[] {"UserReport_CreatedById"});
            DropIndex("dbo.AD_UserReports", new[] {"UserReport_ModifiedById"});
            DropIndex("dbo.AD_UserReports", new[] {"UserReport_ReportedForId"});
            DropIndex("dbo.AD_UserReports", new[] {"UserReport_ReportedById"});
            DropIndex("dbo.AD_UserProfiles", new[] {"UserProfile_CreatedById"});
            DropIndex("dbo.AD_UserProfiles", new[] {"UserProfile_ModifiedById"});
            DropIndex("dbo.AD_UserProfiles", new[] {"UserProfile_AddressId"});
            DropIndex("dbo.AD_UserProfiles", new[] {"UserProfile_OwnedById"});
            DropIndex("dbo.AD_ProductCommentLikes", new[] {"User_Id"});
            DropIndex("dbo.AD_ProductCommentLikes", new[] {"ProductCommentLike_CreatedById"});
            DropIndex("dbo.AD_ProductCommentLikes", new[] {"ProductCommentLike_ModifiedById"});
            DropIndex("dbo.AD_ProductCommentLikes", new[] {"ProductCommentLike_CommentId"});
            DropIndex("dbo.AD_ProductCommentLikes", new[] {"ProductCommentLike_LikedById"});
            DropIndex("dbo.AD_UserLogins", new[] {"User_Id"});
            DropIndex("dbo.AD_UserClaims", new[] {"UserClaim_UserId"});
            DropIndex("dbo.AD_Tags", new[] {"Tag_CreatedById"});
            DropIndex("dbo.AD_Tags", new[] {"Tag_ModifiedById"});
            DropIndex("dbo.AD_ProductVisits", new[] {"User_Id"});
            DropIndex("dbo.AD_ProductVisits", new[] {"ProductVisit_CreatedById"});
            DropIndex("dbo.AD_ProductVisits", new[] {"ProductVisit_ModifiedById"});
            DropIndex("dbo.AD_ProductVisits", new[] {"ProductVisit_ProductId"});
            DropIndex("dbo.AD_ProductVisits", new[] {"ProductVisit_VisitedById"});
            DropIndex("dbo.AD_ProductShares", new[] {"Product_Id"});
            DropIndex("dbo.AD_ProductShares", new[] {"ProductShare_CreatedById"});
            DropIndex("dbo.AD_ProductShares", new[] {"ProductShare_ModifiedById"});
            DropIndex("dbo.AD_ProductReports", new[] {"ProductReport_CreatedById"});
            DropIndex("dbo.AD_ProductReports", new[] {"ProductReport_ModifiedById"});
            DropIndex("dbo.AD_ProductReports", new[] {"ProductReport_ReportedForId"});
            DropIndex("dbo.AD_ProductReports", new[] {"ProductReport_ReportedById"});
            DropIndex("dbo.AD_Properties", new[] {"Property_CreatedById"});
            DropIndex("dbo.AD_Properties", new[] {"Property_ModifiedById"});
            DropIndex("dbo.AD_Properties", new[] {"Property_CategoryId"});
            DropIndex("dbo.AD_ProductProperties", new[] {"ProductProperty_CreatedById"});
            DropIndex("dbo.AD_ProductProperties", new[] {"ProductProperty_ModifiedById"});
            DropIndex("dbo.AD_ProductProperties", new[] {"ProductProperty_PropertyId"});
            DropIndex("dbo.AD_ProductProperties", new[] {"ProductProperty_ProductId"});
            DropIndex("dbo.AD_ProduectLikes", new[] {"User_Id"});
            DropIndex("dbo.AD_ProduectLikes", new[] {"ProduectLike_CreatedById"});
            DropIndex("dbo.AD_ProduectLikes", new[] {"ProduectLike_ModifiedById"});
            DropIndex("dbo.AD_ProduectLikes", new[] {"ProduectLike_ProductId"});
            DropIndex("dbo.AD_ProduectLikes", new[] {"ProduectLike_LikedById"});
            DropIndex("dbo.AD_ProductImages", new[] {"User_Id"});
            DropIndex("dbo.AD_ProductImages", new[] {"ProductImage_CreatedById"});
            DropIndex("dbo.AD_ProductImages", new[] {"ProductImage_ModifiedById"});
            DropIndex("dbo.AD_ProductImages", new[] {"ProductImage_ProductId"});
            DropIndex("dbo.AD_ProductComments", new[] {"User_Id"});
            DropIndex("dbo.AD_ProductComments", new[] {"ProductComment_CreatedById"});
            DropIndex("dbo.AD_ProductComments", new[] {"ProductComment_ModifiedById"});
            DropIndex("dbo.AD_ProductComments", new[] {"ProductComment_ProductId"});
            DropIndex("dbo.AD_ProductComments", new[] {"ProductComment_ApprovedById"});
            DropIndex("dbo.AD_ProductComments", new[] {"ProductComment_CommentedById"});
            DropIndex("dbo.AD_CategoryReviews", new[] {"CategoryReview_CreatedById"});
            DropIndex("dbo.AD_CategoryReviews", new[] {"CategoryReview_ModifiedById"});
            DropIndex("dbo.AD_CategoryReviews", new[] {"CategoryReview_CategoryId"});
            DropIndex("dbo.AD_CategoryReviews", new[] {"CategoryReview_AuthoredById"});
            DropIndex("dbo.AD_CategoryFollows", new[] {"CategoryFollow_CreatedById"});
            DropIndex("dbo.AD_CategoryFollows", new[] {"CategoryFollow_ModifiedById"});
            DropIndex("dbo.AD_CategoryFollows", new[] {"CategoryFollow_CategoryId"});
            DropIndex("dbo.AD_CategoryFollows", new[] {"CategoryFollow_FollowedById"});
            DropIndex("dbo.AD_CompanyVisits", new[] {"User_Id"});
            DropIndex("dbo.AD_CompanyVisits", new[] {"CompanyVisit_CreatedById"});
            DropIndex("dbo.AD_CompanyVisits", new[] {"CompanyVisit_ModifiedById"});
            DropIndex("dbo.AD_CompanyVisits", new[] {"CompanyVisit_CompanyId"});
            DropIndex("dbo.AD_CompanyVisits", new[] {"CompanyVisit_VisitedById"});
            DropIndex("dbo.AD_CompanySocials", new[] {"CompanySocial_CreatedById"});
            DropIndex("dbo.AD_CompanySocials", new[] {"CompanySocial_ModifiedById"});
            DropIndex("dbo.AD_CompanySocials", new[] {"CompanySocial_CompanyId"});
            DropIndex("dbo.AD_CompanyReviews", new[] {"CompanyReview_CreatedById"});
            DropIndex("dbo.AD_CompanyReviews", new[] {"CompanyReview_ModifiedById"});
            DropIndex("dbo.AD_CompanyReviews", new[] {"CompanyReview_CompanyId"});
            DropIndex("dbo.AD_CompanyReports", new[] {"CompanyReport_CreatedById"});
            DropIndex("dbo.AD_CompanyReports", new[] {"CompanyReport_ModifiedById"});
            DropIndex("dbo.AD_CompanyReports", new[] {"CompanyReport_ReportedForId"});
            DropIndex("dbo.AD_CompanyReports", new[] {"CompanyReport_ReportedById"});
            DropIndex("dbo.AD_CompanyQuestionReports", new[] {"CompanyQuestionReport_CreatedById"});
            DropIndex("dbo.AD_CompanyQuestionReports", new[] {"CompanyQuestionReport_ModifiedById"});
            DropIndex("dbo.AD_CompanyQuestionReports", new[] {"CompanyQuestionReport_ReportedForId"});
            DropIndex("dbo.AD_CompanyQuestionReports", new[] {"CompanyQuestionReport_ReportedById"});
            DropIndex("dbo.AD_CompanyQuestionLikes", new[] {"CompanyQuestionLike_CreatedById"});
            DropIndex("dbo.AD_CompanyQuestionLikes", new[] {"CompanyQuestionLike_ModifiedById"});
            DropIndex("dbo.AD_CompanyQuestionLikes", new[] {"CompanyQuestionLike_QuestionId"});
            DropIndex("dbo.AD_CompanyQuestionLikes", new[] {"CompanyQuestionLike_LikedById"});
            DropIndex("dbo.AD_CompanyQuestions", new[] {"User_Id"});
            DropIndex("dbo.AD_CompanyQuestions", new[] {"CompanyQuestion_CreatedById"});
            DropIndex("dbo.AD_CompanyQuestions", new[] {"CompanyQuestion_ModifiedById"});
            DropIndex("dbo.AD_CompanyQuestions", new[] {"CompanyQuestion_QuestionedById"});
            DropIndex("dbo.AD_CompanyQuestions", new[] {"CompanyQuestion_CompanyId"});
            DropIndex("dbo.AD_CompanyQuestions", new[] {"CompanyQuestion_ReplyId"});
            DropIndex("dbo.AD_CompanyModerators", new[] {"CompanyModerator_CreatedById"});
            DropIndex("dbo.AD_CompanyModerators", new[] {"CompanyModerator_ModifiedById"});
            DropIndex("dbo.AD_CompanyModerators", new[] {"CompanyModerator_CompanyId"});
            DropIndex("dbo.AD_CompanyModerators", new[] {"CompanyModerator_ModeratedById"});
            DropIndex("dbo.AD_CompanyImages", new[] {"CompanyImage_CreatedById"});
            DropIndex("dbo.AD_CompanyImages", new[] {"CompanyImage_ModifiedById"});
            DropIndex("dbo.AD_CompanyImages", new[] {"CompanyImage_CompanyId"});
            DropIndex("dbo.AD_CompanyFollows", new[] {"User_Id"});
            DropIndex("dbo.AD_CompanyFollows", new[] {"CompanyFollow_CreatedById"});
            DropIndex("dbo.AD_CompanyFollows", new[] {"CompanyFollow_ModifiedById"});
            DropIndex("dbo.AD_CompanyFollows", new[] {"CompanyFollow_CompanyId"});
            DropIndex("dbo.AD_CompanyFollows", new[] {"CompanyFollow_FollowedById"});
            DropIndex("dbo.AD_CompanyAttachments", new[] {"CompanyAttachment_CreatedById"});
            DropIndex("dbo.AD_CompanyAttachments", new[] {"CompanyAttachment_ModifiedById"});
            DropIndex("dbo.AD_CompanyAttachments", new[] {"CompanyAttachment_CompanyId"});
            DropIndex("dbo.AD_CompanyAttachments", new[] {"CompanyAttachment_OwnedById"});
            DropIndex("dbo.AD_Companies", new[] {"User_Id"});
            DropIndex("dbo.AD_Companies", new[] {"Company_CreatedById"});
            DropIndex("dbo.AD_Companies", new[] {"Company_ModifiedById"});
            DropIndex("dbo.AD_Companies", new[] {"Company_AddressId"});
            DropIndex("dbo.AD_Companies", new[] {"Company_OwnedById"});
            DropIndex("dbo.AD_Categories", new[] {"Category_CreatedById"});
            DropIndex("dbo.AD_Categories", new[] {"Category_ModifiedById"});
            DropIndex("dbo.AD_Categories", new[] {"Category_ParentId"});
            DropIndex("dbo.AD_Cities", new[] {"City_CreatedById"});
            DropIndex("dbo.AD_Cities", new[] {"City_ModifiedById"});
            DropIndex("dbo.AD_Cities", new[] {"City_ParentId"});
            DropIndex("dbo.AD_Addresses", new[] {"Address_CreatedById"});
            DropIndex("dbo.AD_Addresses", new[] {"Address_ModifiedById"});
            DropIndex("dbo.AD_Addresses", new[] {"Address_CityId"});
            DropIndex("dbo.AD_Products", new[] {"User_Id"});
            DropIndex("dbo.AD_Products", new[] {"Review_Id"});
            DropIndex("dbo.AD_Products", new[] {"Product_CreatedById"});
            DropIndex("dbo.AD_Products", new[] {"Product_ModifiedById"});
            DropIndex("dbo.AD_Products", new[] {"Product_CompanyId"});
            DropIndex("dbo.AD_Products", new[] {"Product_CategoryId"});
            DropIndex("dbo.AD_Products", new[] {"Product_AddressId"});
            DropIndex("dbo.AD_Products", new[] {"Product_ApprovedById"});
            DropIndex("dbo.AD_Products", new[] {"Product_OwnedById"});
            DropIndex("dbo.AD_TagOrders", new[] {"TagOrder_CreatedById"});
            DropIndex("dbo.AD_TagOrders", new[] {"TagOrder_ModifiedById"});
            DropIndex("dbo.AD_TagOrders", new[] {"TagOrder_ProductId"});
            DropIndex("dbo.AD_TagOrders", new[] {"TagOrder_TagId"});
            DropIndex("dbo.AD_TagOrders", new[] {"TagOrder_UserBudgetId"});
            DropIndex("dbo.AD_TagOrders", new[] {"TagOrder_OrderedById"});
            DropIndex("dbo.AD_Features", new[] {"Feature_CreatedById"});
            DropIndex("dbo.AD_Features", new[] {"Feature_ModifiedById"});
            DropIndex("dbo.AD_FeatureOrders", new[] {"FeatureOrder_CreatedById"});
            DropIndex("dbo.AD_FeatureOrders", new[] {"FeatureOrder_ModifiedById"});
            DropIndex("dbo.AD_FeatureOrders", new[] {"FeatureOrder_FeatureId"});
            DropIndex("dbo.AD_FeatureOrders", new[] {"FeatureOrder_UserBudgetId"});
            DropIndex("dbo.AD_FeatureOrders", new[] {"FeatureOrder_OrderedById"});
            DropIndex("dbo.AD_UserBudgets", new[] {"User_Id"});
            DropIndex("dbo.AD_UserBudgets", new[] {"UserBudget_CreatedById"});
            DropIndex("dbo.AD_UserBudgets", new[] {"UserBudget_ModifiedById"});
            DropIndex("dbo.AD_UserBudgets", new[] {"UserBudget_OwnedById"});
            DropIndex("dbo.AD_Users", new[] {"Social_Id"});
            DropIndex("dbo.AD_Users", new[] {"Setting_Id"});
            DropIndex("dbo.AD_Users", new[] {"Profile_Id"});
            DropIndex("dbo.AD_RoleActions", new[] {"RoleAction_CreatedById"});
            DropIndex("dbo.AD_RoleActions", new[] {"RoleAction_ModifiedById"});
            DropIndex("dbo.AD_RoleActions", new[] {"RoleAction_RoleId"});
            DropTable("dbo.CompanyCategories");
            DropTable("dbo.AD_AuditLogs");
            DropTable("dbo.AD_ActivityLogs");
            DropTable("dbo.AD_Statistics");
            DropTable("dbo.AD_PaymentTransactions");
            DropTable("dbo.AD_Payments");
            DropTable("dbo.AD_Notifications");
            DropTable("dbo.AD_News");
            DropTable("dbo.AD_Conversations");
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
            DropTable("dbo.AD_Properties");
            DropTable("dbo.AD_ProductProperties");
            DropTable("dbo.AD_ProduectLikes");
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