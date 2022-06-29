namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7a789fe2-36d9-4f74-b736-4f5b17551a1b', N'guest@algebra.hr', 0, N'AIh8+dYupUs5lbkX/YCwk+Y0usQELDUGWm3xqCkzrc5BOanUARNaY5LrCc/hN5dB3w==', N'ba06600d-09cf-473c-b201-3539b9604b7b', NULL, 0, 0, NULL, 1, 0, N'guest@algebra.hr')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f55f1913-5e59-4611-a6f7-65e81e81196e', N'admin@algebra.hr', 0, N'ALCBUWiuBY2ptObkms7xcje96NfHS5Hm4Yt5/ZE34htEJlARVhCbBoAa07qkl7DxDw==', N'ef99fe82-886e-459e-91c2-c7ed87dd64a7', NULL, 0, 0, NULL, 1, 0, N'admin@algebra.hr')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'61eac1e0-ff28-41ec-a9d2-33535be4dde4', N'CanManageBooks')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f55f1913-5e59-4611-a6f7-65e81e81196e', N'61eac1e0-ff28-41ec-a9d2-33535be4dde4')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
