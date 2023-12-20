namespace ViplataProject.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        CompanyID = c.Long(nullable: false, identity: true),
                        CompanyName = c.Long(nullable: false),
                        PhysAddress = c.String(nullable: false),
                        LegAddress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeID = c.Long(nullable: false, identity: true),
                        EmployeeSecondName = c.String(nullable: false),
                        EmployeeName = c.String(nullable: false),
                        EmployeePatronymic = c.String(nullable: false),
                        EmployeeDateOfBirth = c.String(nullable: false),
                        EmployeeGender = c.String(nullable: false),
                        EmployeeDisability = c.String(nullable: false),
                        EmployeeExpirience = c.String(nullable: false),
                        UserId = c.Long(nullable: false),
                        JobId = c.Long(nullable: false),
                        CompanyId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Job", t => t.JobId)
                .ForeignKey("dbo.User", t => t.UserId)
                .ForeignKey("dbo.Company", t => t.CompanyId)
                .Index(t => t.UserId)
                .Index(t => t.JobId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Job",
                c => new
                    {
                        JobID = c.Long(nullable: false, identity: true),
                        JobTitle = c.String(nullable: false),
                        JobWorkDay = c.String(),
                    })
                .PrimaryKey(t => t.JobID);
            
            CreateTable(
                "dbo.Payment",
                c => new
                    {
                        PaymentID = c.Long(nullable: false, identity: true),
                        PaymentEmployeeId = c.Long(nullable: false),
                        PaymentRate = c.String(nullable: false),
                        PaymentVacation = c.Decimal(nullable: false, precision: 18, scale: 0),
                        PaymentBonusForDisability = c.Decimal(precision: 18, scale: 0),
                        PaymentBonusForDoneWork = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => t.PaymentID)
                .ForeignKey("dbo.Employee", t => t.PaymentEmployeeId)
                .Index(t => t.PaymentEmployeeId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Long(nullable: false, identity: true),
                        UserLogin = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        UserRoleId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Role", t => t.UserRoleId)
                .Index(t => t.UserRoleId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleID = c.Long(nullable: false, identity: true),
                        RoleName = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.RoleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.User", "UserRoleId", "dbo.Role");
            DropForeignKey("dbo.Employee", "UserId", "dbo.User");
            DropForeignKey("dbo.Payment", "PaymentEmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Employee", "JobId", "dbo.Job");
            DropIndex("dbo.User", new[] { "UserRoleId" });
            DropIndex("dbo.Payment", new[] { "PaymentEmployeeId" });
            DropIndex("dbo.Employee", new[] { "CompanyId" });
            DropIndex("dbo.Employee", new[] { "JobId" });
            DropIndex("dbo.Employee", new[] { "UserId" });
            DropTable("dbo.Role");
            DropTable("dbo.User");
            DropTable("dbo.Payment");
            DropTable("dbo.Job");
            DropTable("dbo.Employee");
            DropTable("dbo.Company");
        }
    }
}
