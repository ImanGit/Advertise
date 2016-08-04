namespace Advertise.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AD_Users",
                c => new
                    {
                        User_Id = c.Guid(nullable: false),
                        User_Code = c.String(nullable: false, maxLength: 50),
                        User_FirstName = c.String(maxLength: 50),
                        User_LastName = c.String(maxLength: 50),
                        User_DisplayName = c.String(maxLength: 255),
                        User_NationalCode = c.String(maxLength: 10),
                        User_BirthDate = c.DateTime(),
                        User_MarriedDate = c.DateTime(),
                        User_Address = c.String(maxLength: 255),
                        User_AvatarFileName = c.String(),
                        User_IsDeleted = c.Boolean(nullable: false),
                        User_IsActive = c.Boolean(nullable: false),
                        User_Gender = c.Int(nullable: false),
                        User_CityId = c.Guid(nullable: false),
                        User_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.User_Id)
                .ForeignKey("dbo.AD_Cities", t => t.User_CityId, cascadeDelete: true)
                .Index(t => t.User_CityId);
            
            CreateTable(
                "dbo.AD_Accounts",
                c => new
                    {
                        Account_Id = c.Guid(nullable: false),
                        Account_Email = c.String(),
                        Account_MobileNumber = c.String(),
                        Account_Password = c.String(),
                        Account_CreateDate = c.DateTime(nullable: false),
                        Account_UserName = c.String(),
                        Account_LastLoginDate = c.DateTime(nullable: false),
                        Account_IsBanned = c.Boolean(nullable: false),
                        Account_IsVerified = c.Boolean(nullable: false),
                        Account_IsActive = c.Boolean(nullable: false),
                        Account_IsEmailConfirmed = c.Boolean(nullable: false),
                        Account_IsMobileConfirmed = c.Boolean(nullable: false),
                        Account_RoleId = c.Guid(nullable: false),
                        Account_UserId = c.Guid(nullable: false),
                        Account_RowVersion = c.Binary(),
                    })
                .PrimaryKey(t => t.Account_Id)
                .ForeignKey("dbo.AD_Roles", t => t.Account_RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Users", t => t.Account_UserId, cascadeDelete: true)
                .Index(t => t.Account_RoleId)
                .Index(t => t.Account_UserId);
            
            CreateTable(
                "dbo.AD_Roles",
                c => new
                    {
                        Role_Id = c.Guid(nullable: false),
                        Role_Code = c.String(nullable: false, maxLength: 50),
                        Role_Title = c.String(nullable: false),
                        Role_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Role_Id);
            
            CreateTable(
                "dbo.AD_Actions",
                c => new
                    {
                        Action_Id = c.Guid(nullable: false),
                        Action_Title = c.String(),
                        Action_ActionName = c.String(),
                        Action_ControllerName = c.String(),
                        Action_IsEnable = c.Boolean(nullable: false),
                        Action_RoleId = c.Guid(nullable: false),
                        Action_RowVersion = c.Binary(),
                    })
                .PrimaryKey(t => t.Action_Id)
                .ForeignKey("dbo.AD_Roles", t => t.Action_RoleId, cascadeDelete: true)
                .Index(t => t.Action_RoleId);
            
            CreateTable(
                "dbo.AD_Budgets",
                c => new
                    {
                        Budget_Id = c.Guid(nullable: false),
                        Budget_RemainValue = c.Int(nullable: false),
                        Budget_IncDecValue = c.Int(nullable: false),
                        Budget_ReffrenceCode = c.String(),
                        Budget_CreateDate = c.DateTime(nullable: false),
                        Budget_UserId = c.Guid(nullable: false),
                        Budget_RowVersion = c.Binary(),
                    })
                .PrimaryKey(t => t.Budget_Id)
                .ForeignKey("dbo.AD_Users", t => t.Budget_UserId, cascadeDelete: true)
                .Index(t => t.Budget_UserId);
            
            CreateTable(
                "dbo.AD_Cities",
                c => new
                    {
                        City_Id = c.Guid(nullable: false),
                        City_IsState = c.Boolean(nullable: false),
                        City_CityName = c.String(nullable: false, maxLength: 100),
                        City_ParentId = c.Guid(nullable: false),
                        City_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.City_Id)
                .ForeignKey("dbo.AD_Cities", t => t.City_ParentId)
                .Index(t => t.City_ParentId);
            
            CreateTable(
                "dbo.AD_Comments",
                c => new
                    {
                        Comment_Id = c.Guid(nullable: false),
                        Comment_Content = c.String(),
                        Comment_CreateDate = c.DateTime(nullable: false),
                        Comment_LikedCount = c.Int(),
                        Comment_IsAccepted = c.Boolean(nullable: false),
                        Comment_UserId = c.Guid(nullable: false),
                        Comment_ProductId = c.Guid(nullable: false),
                        Comment_AcceptUserId = c.Guid(nullable: false),
                        Comment_RowVersion = c.Binary(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Comment_Id)
                .ForeignKey("dbo.AD_Users", t => t.Comment_AcceptUserId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Products", t => t.Comment_ProductId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Users", t => t.Comment_UserId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Users", t => t.User_Id)
                .Index(t => t.Comment_UserId)
                .Index(t => t.Comment_ProductId)
                .Index(t => t.Comment_AcceptUserId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AD_Products",
                c => new
                    {
                        Product_Id = c.Guid(nullable: false),
                        Product_Code = c.String(nullable: false, maxLength: 50),
                        Product_Title = c.String(nullable: false, maxLength: 250),
                        Product_CreateDate = c.DateTime(nullable: false),
                        Product_Address = c.String(maxLength: 255),
                        Product_MobileNumber = c.String(nullable: false, maxLength: 10),
                        Product_PhoneNumber = c.String(maxLength: 10),
                        Product_Email = c.String(maxLength: 100),
                        Product_Description = c.String(maxLength: 500),
                        Product_VisitedCount = c.Int(),
                        Product_LikedCount = c.Int(),
                        Product_IsAccepted = c.Boolean(nullable: false),
                        Product_IsEdited = c.Boolean(nullable: false),
                        Product_IsDeleted = c.Boolean(nullable: false),
                        Product_DeleteDate = c.DateTime(),
                        Product_EditDate = c.DateTime(),
                        Product_CategoryId = c.Guid(nullable: false),
                        Product_CityId = c.Guid(nullable: false),
                        Product_CompanyId = c.Guid(nullable: false),
                        Product_CreateUserId = c.Guid(nullable: false),
                        Product_AcceptUserId = c.Guid(nullable: false),
                        Product_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Product_Id)
                .ForeignKey("dbo.AD_Users", t => t.Product_AcceptUserId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Categories", t => t.Product_CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Cities", t => t.Product_CityId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Companies", t => t.Product_CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Users", t => t.Product_CreateUserId, cascadeDelete: true)
                .Index(t => t.Product_CategoryId)
                .Index(t => t.Product_CityId)
                .Index(t => t.Product_CompanyId)
                .Index(t => t.Product_CreateUserId)
                .Index(t => t.Product_AcceptUserId);
            
            CreateTable(
                "dbo.AD_Categories",
                c => new
                    {
                        Category_Id = c.Guid(nullable: false),
                        Category_Code = c.String(),
                        Category_Title = c.String(),
                        Category_Description = c.String(),
                        Category_ParentId = c.Guid(nullable: false),
                        Category_RowVersion = c.Binary(),
                    })
                .PrimaryKey(t => t.Category_Id)
                .ForeignKey("dbo.AD_Categories", t => t.Category_ParentId)
                .Index(t => t.Category_ParentId);
            
            CreateTable(
                "dbo.AD_Companies",
                c => new
                    {
                        Company_Id = c.Guid(nullable: false),
                        Company_Code = c.String(),
                        Company_Title = c.String(),
                        Company_Description = c.String(),
                        Company_BrandFileName = c.String(),
                        Company_BackgroundFileName = c.String(),
                        Company_VisitedCount = c.Int(),
                        Company_PostalCode = c.String(),
                        Company_Address = c.String(),
                        Company_PhoneNumber = c.String(),
                        Company_MobileNumber = c.String(),
                        Company_Email = c.String(),
                        Company_WebSite = c.String(),
                        Company_UserId = c.Guid(nullable: false),
                        Company_CityId = c.Guid(nullable: false),
                        Company_RowVersion = c.Binary(),
                    })
                .PrimaryKey(t => t.Company_Id)
                .ForeignKey("dbo.AD_Cities", t => t.Company_CityId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Users", t => t.Company_UserId, cascadeDelete: true)
                .Index(t => t.Company_UserId)
                .Index(t => t.Company_CityId);
            
            CreateTable(
                "dbo.AD_Follows",
                c => new
                    {
                        Follow_Id = c.Guid(nullable: false),
                        Follow_RegisterDate = c.DateTime(nullable: false),
                        Follow_Type = c.Int(nullable: false),
                        Follow_UserId = c.Guid(nullable: false),
                        Follow_CategoryId = c.Guid(nullable: false),
                        Follow_CompanyId = c.Guid(nullable: false),
                        Follow_RowVersion = c.Binary(),
                    })
                .PrimaryKey(t => t.Follow_Id)
                .ForeignKey("dbo.AD_Categories", t => t.Follow_CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Companies", t => t.Follow_CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Users", t => t.Follow_UserId, cascadeDelete: true)
                .Index(t => t.Follow_UserId)
                .Index(t => t.Follow_CategoryId)
                .Index(t => t.Follow_CompanyId);
            
            CreateTable(
                "dbo.AD_Likes",
                c => new
                    {
                        Like_Id = c.Guid(nullable: false),
                        Like_Type = c.Int(nullable: false),
                        Like_RegisterDate = c.DateTime(nullable: false),
                        Like_UserId = c.Guid(nullable: false),
                        Like_CommentId = c.Guid(nullable: false),
                        Like_ProductId = c.Guid(nullable: false),
                        Like_RowVersion = c.Binary(),
                    })
                .PrimaryKey(t => t.Like_Id)
                .ForeignKey("dbo.AD_Comments", t => t.Like_CommentId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Products", t => t.Like_ProductId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Users", t => t.Like_UserId, cascadeDelete: true)
                .Index(t => t.Like_UserId)
                .Index(t => t.Like_CommentId)
                .Index(t => t.Like_ProductId);
            
            CreateTable(
                "dbo.AD_Logs",
                c => new
                    {
                        Log_Id = c.Guid(nullable: false),
                        Log_Message = c.String(),
                        Log_Action = c.String(),
                        Log_LogLevel = c.Int(nullable: false),
                        Log_Date = c.DateTime(nullable: false),
                        Log_UserId = c.Guid(nullable: false),
                        Log_RowVersion = c.Binary(),
                    })
                .PrimaryKey(t => t.Log_Id)
                .ForeignKey("dbo.AD_Users", t => t.Log_UserId, cascadeDelete: true)
                .Index(t => t.Log_UserId);
            
            CreateTable(
                "dbo.AD_Messages",
                c => new
                    {
                        Message_Id = c.Guid(nullable: false),
                        Message_Title = c.String(),
                        Message_Content = c.String(),
                        Message_IsViewed = c.Boolean(nullable: false),
                        Message_FromUserId = c.Guid(nullable: false),
                        Message_ToUserId = c.Guid(nullable: false),
                        Message_ReplyId = c.Guid(nullable: false),
                        Message_RowVersion = c.Binary(),
                    })
                .PrimaryKey(t => t.Message_Id)
                .ForeignKey("dbo.AD_Users", t => t.Message_FromUserId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Messages", t => t.Message_ReplyId)
                .ForeignKey("dbo.AD_Users", t => t.Message_ToUserId, cascadeDelete: true)
                .Index(t => t.Message_FromUserId)
                .Index(t => t.Message_ToUserId)
                .Index(t => t.Message_ReplyId);
            
            CreateTable(
                "dbo.AD_Notices",
                c => new
                    {
                        Notice_Id = c.Guid(nullable: false),
                        Notice_Title = c.String(),
                        Notice_Content = c.String(),
                        Notice_CreateDate = c.DateTime(nullable: false),
                        Notice_IsVisible = c.Boolean(nullable: false),
                        Notice_UserId = c.Guid(nullable: false),
                        Notice_RowVersion = c.Binary(),
                    })
                .PrimaryKey(t => t.Notice_Id)
                .ForeignKey("dbo.AD_Users", t => t.Notice_UserId, cascadeDelete: true)
                .Index(t => t.Notice_UserId);
            
            CreateTable(
                "dbo.AD_Notifications",
                c => new
                    {
                        Notification_Id = c.Guid(nullable: false),
                        Notification_IsViewed = c.Boolean(nullable: false),
                        Notification_CreateDate = c.DateTime(nullable: false),
                        Notification_UserId = c.Guid(nullable: false),
                        Notification_ProductId = c.Guid(nullable: false),
                        Notification_RowVersion = c.Binary(),
                    })
                .PrimaryKey(t => t.Notification_Id)
                .ForeignKey("dbo.AD_Products", t => t.Notification_ProductId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Users", t => t.Notification_UserId, cascadeDelete: true)
                .Index(t => t.Notification_UserId)
                .Index(t => t.Notification_ProductId);
            
            CreateTable(
                "dbo.AD_Payments",
                c => new
                    {
                        Payment_Id = c.Guid(nullable: false),
                        Payment_CreateDate = c.DateTime(nullable: false),
                        Payment_FromDate = c.DateTime(nullable: false),
                        Payment_ToDate = c.DateTime(nullable: false),
                        Payment_PlanId = c.Guid(nullable: false),
                        Payment_UserId = c.Guid(nullable: false),
                        Payment_BudgetId = c.Guid(nullable: false),
                        Payment_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Payment_Id)
                .ForeignKey("dbo.AD_Budgets", t => t.Payment_BudgetId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Plans", t => t.Payment_PlanId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Users", t => t.Payment_UserId, cascadeDelete: true)
                .Index(t => t.Payment_PlanId)
                .Index(t => t.Payment_UserId)
                .Index(t => t.Payment_BudgetId);
            
            CreateTable(
                "dbo.AD_Plans",
                c => new
                    {
                        Plan_Id = c.Guid(nullable: false),
                        Plan_Code = c.String(nullable: false, maxLength: 50),
                        Plan_Title = c.String(nullable: false, maxLength: 100),
                        Plan_Description = c.String(maxLength: 250),
                        Plan_DurationDay = c.String(nullable: false),
                        Plan_CostValue = c.Int(nullable: false),
                        Plan_IsEnabled = c.Boolean(nullable: false),
                        Plan_FromDate = c.DateTime(nullable: false),
                        Plan_ToDate = c.DateTime(nullable: false),
                        Plan_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Plan_Id);
            
            CreateTable(
                "dbo.AD_Questions",
                c => new
                    {
                        Question_Id = c.Guid(nullable: false),
                        Question_Title = c.String(nullable: false, maxLength: 255),
                        Question_Content = c.String(nullable: false, maxLength: 700),
                        Question_CreateDate = c.DateTime(nullable: false),
                        Question_LikedCount = c.Int(),
                        Question_IsAccepted = c.Boolean(nullable: false),
                        Question_ReplyId = c.Guid(nullable: false),
                        Question_CompanyId = c.Guid(nullable: false),
                        Question_UserId = c.Guid(nullable: false),
                        Question_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Question_Id)
                .ForeignKey("dbo.AD_Companies", t => t.Question_CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.AD_Questions", t => t.Question_ReplyId)
                .ForeignKey("dbo.AD_Users", t => t.Question_UserId, cascadeDelete: true)
                .Index(t => t.Question_ReplyId)
                .Index(t => t.Question_CompanyId)
                .Index(t => t.Question_UserId);
            
            CreateTable(
                "dbo.AD_Settings",
                c => new
                    {
                        Setting_Id = c.Guid(nullable: false),
                        Setting_Language = c.Int(),
                        Setting_Theme = c.Int(),
                        Setting_UserId = c.Guid(nullable: false),
                        Setting_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Setting_Id)
                .ForeignKey("dbo.AD_Users", t => t.Setting_UserId, cascadeDelete: true)
                .Index(t => t.Setting_UserId);
            
            CreateTable(
                "dbo.AD_Properties",
                c => new
                    {
                        Property_Id = c.Guid(nullable: false),
                        Property_Value = c.String(nullable: false, maxLength: 100),
                        Property_ProductId = c.Guid(nullable: false),
                        Property_PropertyTemplateId = c.Guid(nullable: false),
                        Property_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Property_Id)
                .ForeignKey("dbo.AD_Products", t => t.Property_ProductId, cascadeDelete: true)
                .ForeignKey("dbo.AD_PropertyTemplates", t => t.Property_PropertyTemplateId, cascadeDelete: true)
                .Index(t => t.Property_ProductId)
                .Index(t => t.Property_PropertyTemplateId);
            
            CreateTable(
                "dbo.AD_PropertyTemplates",
                c => new
                    {
                        PropertyTemplate_Id = c.Guid(nullable: false),
                        PropertyTemplate_Title = c.String(nullable: false, maxLength: 50),
                        PropertyTemplate_Property = c.Int(nullable: false),
                        PropertyTemplate_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Category_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.PropertyTemplate_Id)
                .ForeignKey("dbo.AD_Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.AD_Socials",
                c => new
                    {
                        Social_Id = c.Guid(nullable: false),
                        Social_TwitterLink = c.String(maxLength: 100),
                        Social_FacebookLink = c.String(maxLength: 100),
                        Social_GooglePlusLink = c.String(maxLength: 100),
                        Social_AparatLink = c.String(maxLength: 100),
                        Social_CompanyId = c.Guid(nullable: false),
                        Social_RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Social_Id)
                .ForeignKey("dbo.AD_Companies", t => t.Social_CompanyId, cascadeDelete: true)
                .Index(t => t.Social_CompanyId);
            
            CreateTable(
                "dbo.AD_Statistics",
                c => new
                    {
                        Statistic_Id = c.Guid(nullable: false),
                        Statistic_Ip = c.String(nullable: false),
                        Statistic_Date = c.DateTime(nullable: false),
                        Statistic_Browser = c.String(nullable: false),
                        Statistic_SearchEngine = c.String(),
                        Statistic_Keyword = c.String(),
                        Statistic_RowVersion = c.Binary(),
                    })
                .PrimaryKey(t => t.Statistic_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AD_Socials", "Social_CompanyId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_Properties", "Property_PropertyTemplateId", "dbo.AD_PropertyTemplates");
            DropForeignKey("dbo.AD_PropertyTemplates", "Category_Id", "dbo.AD_Categories");
            DropForeignKey("dbo.AD_Properties", "Property_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_Settings", "Setting_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Questions", "Question_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Questions", "Question_ReplyId", "dbo.AD_Questions");
            DropForeignKey("dbo.AD_Questions", "Question_CompanyId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_Products", "Product_CreateUserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Payments", "Payment_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Payments", "Payment_PlanId", "dbo.AD_Plans");
            DropForeignKey("dbo.AD_Payments", "Payment_BudgetId", "dbo.AD_Budgets");
            DropForeignKey("dbo.AD_Notifications", "Notification_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Notifications", "Notification_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_Notices", "Notice_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Messages", "Message_ToUserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Messages", "Message_ReplyId", "dbo.AD_Messages");
            DropForeignKey("dbo.AD_Messages", "Message_FromUserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Logs", "Log_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Likes", "Like_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Likes", "Like_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_Likes", "Like_CommentId", "dbo.AD_Comments");
            DropForeignKey("dbo.AD_Follows", "Follow_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Follows", "Follow_CompanyId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_Follows", "Follow_CategoryId", "dbo.AD_Categories");
            DropForeignKey("dbo.AD_Companies", "Company_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Comments", "User_Id", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Comments", "Comment_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Comments", "Comment_ProductId", "dbo.AD_Products");
            DropForeignKey("dbo.AD_Products", "Product_CompanyId", "dbo.AD_Companies");
            DropForeignKey("dbo.AD_Companies", "Company_CityId", "dbo.AD_Cities");
            DropForeignKey("dbo.AD_Products", "Product_CityId", "dbo.AD_Cities");
            DropForeignKey("dbo.AD_Products", "Product_CategoryId", "dbo.AD_Categories");
            DropForeignKey("dbo.AD_Categories", "Category_ParentId", "dbo.AD_Categories");
            DropForeignKey("dbo.AD_Products", "Product_AcceptUserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Comments", "Comment_AcceptUserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Users", "User_CityId", "dbo.AD_Cities");
            DropForeignKey("dbo.AD_Cities", "City_ParentId", "dbo.AD_Cities");
            DropForeignKey("dbo.AD_Budgets", "Budget_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Accounts", "Account_UserId", "dbo.AD_Users");
            DropForeignKey("dbo.AD_Accounts", "Account_RoleId", "dbo.AD_Roles");
            DropForeignKey("dbo.AD_Actions", "Action_RoleId", "dbo.AD_Roles");
            DropIndex("dbo.AD_Socials", new[] { "Social_CompanyId" });
            DropIndex("dbo.AD_PropertyTemplates", new[] { "Category_Id" });
            DropIndex("dbo.AD_Properties", new[] { "Property_PropertyTemplateId" });
            DropIndex("dbo.AD_Properties", new[] { "Property_ProductId" });
            DropIndex("dbo.AD_Settings", new[] { "Setting_UserId" });
            DropIndex("dbo.AD_Questions", new[] { "Question_UserId" });
            DropIndex("dbo.AD_Questions", new[] { "Question_CompanyId" });
            DropIndex("dbo.AD_Questions", new[] { "Question_ReplyId" });
            DropIndex("dbo.AD_Payments", new[] { "Payment_BudgetId" });
            DropIndex("dbo.AD_Payments", new[] { "Payment_UserId" });
            DropIndex("dbo.AD_Payments", new[] { "Payment_PlanId" });
            DropIndex("dbo.AD_Notifications", new[] { "Notification_ProductId" });
            DropIndex("dbo.AD_Notifications", new[] { "Notification_UserId" });
            DropIndex("dbo.AD_Notices", new[] { "Notice_UserId" });
            DropIndex("dbo.AD_Messages", new[] { "Message_ReplyId" });
            DropIndex("dbo.AD_Messages", new[] { "Message_ToUserId" });
            DropIndex("dbo.AD_Messages", new[] { "Message_FromUserId" });
            DropIndex("dbo.AD_Logs", new[] { "Log_UserId" });
            DropIndex("dbo.AD_Likes", new[] { "Like_ProductId" });
            DropIndex("dbo.AD_Likes", new[] { "Like_CommentId" });
            DropIndex("dbo.AD_Likes", new[] { "Like_UserId" });
            DropIndex("dbo.AD_Follows", new[] { "Follow_CompanyId" });
            DropIndex("dbo.AD_Follows", new[] { "Follow_CategoryId" });
            DropIndex("dbo.AD_Follows", new[] { "Follow_UserId" });
            DropIndex("dbo.AD_Companies", new[] { "Company_CityId" });
            DropIndex("dbo.AD_Companies", new[] { "Company_UserId" });
            DropIndex("dbo.AD_Categories", new[] { "Category_ParentId" });
            DropIndex("dbo.AD_Products", new[] { "Product_AcceptUserId" });
            DropIndex("dbo.AD_Products", new[] { "Product_CreateUserId" });
            DropIndex("dbo.AD_Products", new[] { "Product_CompanyId" });
            DropIndex("dbo.AD_Products", new[] { "Product_CityId" });
            DropIndex("dbo.AD_Products", new[] { "Product_CategoryId" });
            DropIndex("dbo.AD_Comments", new[] { "User_Id" });
            DropIndex("dbo.AD_Comments", new[] { "Comment_AcceptUserId" });
            DropIndex("dbo.AD_Comments", new[] { "Comment_ProductId" });
            DropIndex("dbo.AD_Comments", new[] { "Comment_UserId" });
            DropIndex("dbo.AD_Cities", new[] { "City_ParentId" });
            DropIndex("dbo.AD_Budgets", new[] { "Budget_UserId" });
            DropIndex("dbo.AD_Actions", new[] { "Action_RoleId" });
            DropIndex("dbo.AD_Accounts", new[] { "Account_UserId" });
            DropIndex("dbo.AD_Accounts", new[] { "Account_RoleId" });
            DropIndex("dbo.AD_Users", new[] { "User_CityId" });
            DropTable("dbo.AD_Statistics");
            DropTable("dbo.AD_Socials");
            DropTable("dbo.AD_PropertyTemplates");
            DropTable("dbo.AD_Properties");
            DropTable("dbo.AD_Settings");
            DropTable("dbo.AD_Questions");
            DropTable("dbo.AD_Plans");
            DropTable("dbo.AD_Payments");
            DropTable("dbo.AD_Notifications");
            DropTable("dbo.AD_Notices");
            DropTable("dbo.AD_Messages");
            DropTable("dbo.AD_Logs");
            DropTable("dbo.AD_Likes");
            DropTable("dbo.AD_Follows");
            DropTable("dbo.AD_Companies");
            DropTable("dbo.AD_Categories");
            DropTable("dbo.AD_Products");
            DropTable("dbo.AD_Comments");
            DropTable("dbo.AD_Cities");
            DropTable("dbo.AD_Budgets");
            DropTable("dbo.AD_Actions");
            DropTable("dbo.AD_Roles");
            DropTable("dbo.AD_Accounts");
            DropTable("dbo.AD_Users");
        }
    }
}
