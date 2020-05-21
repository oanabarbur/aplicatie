namespace Licenta2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'18a3061c-9279-4135-9fd7-b44503622a66', N'guest@Licenta2.com', 0, N'AM2YGNRFVHPdMJMazcTc6QnI7rBSm/AkFl/siWnZUu51VmdvVWFfpV/O0O4IZ2t85g==', N'8a016bd6-9f50-43c8-a34b-a61266b58940', NULL, 0, 0, NULL, 1, 0, N'guest@Licenta2.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'27c98429-0b4d-42f4-badf-a2bfbb6d8ad7', N'admin@Licenta2.com', 0, N'AKY2LrkudaX0RamShX/U0z+9U26qfD7FnUAGfC30Q/4DZhAjR9YK46Y8zdagOqkyWQ==', N'e054a173-6a7c-4740-bbbe-093c158d7073', NULL, 0, 0, NULL, 1, 0, N'admin@Licenta2.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e618b7a9-1275-452f-8ddb-9c105d22451b', N'CanManageEquipments')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'27c98429-0b4d-42f4-badf-a2bfbb6d8ad7', N'e618b7a9-1275-452f-8ddb-9c105d22451b')
                

");
        }
        
        public override void Down()
        {
        }
    }
}
