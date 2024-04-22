namespace Itrs.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.CompanyUsers",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        CompanyAdminUsername = c.String(maxLength: 30, unicode: false),
                        CompanyAdminPassword = c.String(maxLength: 30, unicode: false),
                        CompanyAdminPhone = c.String(maxLength: 30, unicode: false),
                        AdminFullName = c.String(),
                        AdminMail = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.LogEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Timestamp = c.DateTime(nullable: false),
                        Description = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mails",
                c => new
                    {
                        MailId = c.Int(nullable: false, identity: true),
                        SenderMail = c.String(),
                        ReceiverMail = c.String(),
                        MailBody = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.MailId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 500, unicode: false),
                        ProductDescription = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockAmount = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Mails");
            DropTable("dbo.LogEntries");
            DropTable("dbo.CompanyUsers");
            DropTable("dbo.Category");
        }
    }
}
