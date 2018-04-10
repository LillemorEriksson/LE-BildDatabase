namespace LE_BildDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Adress = c.String(),
                        Phone = c.Int(nullable: false),
                        Invoice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PicData = c.Binary(),
                        Name = c.String(),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        priser = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Portfolios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PricesPhotoes",
                c => new
                    {
                        Prices_Id = c.Int(nullable: false),
                        Photo_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Prices_Id, t.Photo_Id })
                .ForeignKey("dbo.Prices", t => t.Prices_Id, cascadeDelete: true)
                .ForeignKey("dbo.Photos", t => t.Photo_Id, cascadeDelete: true)
                .Index(t => t.Prices_Id)
                .Index(t => t.Photo_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photos", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.PricesPhotoes", "Photo_Id", "dbo.Photos");
            DropForeignKey("dbo.PricesPhotoes", "Prices_Id", "dbo.Prices");
            DropIndex("dbo.PricesPhotoes", new[] { "Photo_Id" });
            DropIndex("dbo.PricesPhotoes", new[] { "Prices_Id" });
            DropIndex("dbo.Photos", new[] { "Customer_Id" });
            DropTable("dbo.PricesPhotoes");
            DropTable("dbo.Portfolios");
            DropTable("dbo.Prices");
            DropTable("dbo.Photos");
            DropTable("dbo.Customers");
        }
    }
}
