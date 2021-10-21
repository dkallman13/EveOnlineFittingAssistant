namespace EveOnlineFittingAssistant_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fit",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShipId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ship", t => t.ShipId, cascadeDelete: true)
                .Index(t => t.ShipId);
            
            CreateTable(
                "dbo.Module",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Slot = c.Int(nullable: false),
                        Powergrid = c.Double(nullable: false),
                        CPU = c.Double(nullable: false),
                        CycleTime = c.Double(),
                        CapacitorUsage = c.Double(),
                        RepairType = c.Int(),
                        RepairAmount = c.Double(),
                        TypeOfWeapon = c.Int(),
                        DamageMultiplier = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Fit_Id = c.Int(),
                        Fit_Id1 = c.Int(),
                        Fit_Id2 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fit", t => t.Fit_Id)
                .ForeignKey("dbo.Fit", t => t.Fit_Id1)
                .ForeignKey("dbo.Fit", t => t.Fit_Id2)
                .Index(t => t.Fit_Id)
                .Index(t => t.Fit_Id1)
                .Index(t => t.Fit_Id2);
            
            CreateTable(
                "dbo.Ship",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LowSlotNumber = c.Int(nullable: false),
                        MidSlotNumber = c.Int(nullable: false),
                        HighSlotNumber = c.Int(nullable: false),
                        Powergrid = c.Double(nullable: false),
                        CPU = c.Double(nullable: false),
                        CapacitorCapacity = c.Double(nullable: false),
                        CapacitorRechargeTime = c.Double(nullable: false),
                        WeaponMounts = c.Int(nullable: false),
                        CargoSpace = c.Double(nullable: false),
                        Speed = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.Fit", "ShipId", "dbo.Ship");
            DropForeignKey("dbo.Module", "Fit_Id2", "dbo.Fit");
            DropForeignKey("dbo.Module", "Fit_Id1", "dbo.Fit");
            DropForeignKey("dbo.Module", "Fit_Id", "dbo.Fit");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.Module", new[] { "Fit_Id2" });
            DropIndex("dbo.Module", new[] { "Fit_Id1" });
            DropIndex("dbo.Module", new[] { "Fit_Id" });
            DropIndex("dbo.Fit", new[] { "ShipId" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.Ship");
            DropTable("dbo.Module");
            DropTable("dbo.Fit");
        }
    }
}
