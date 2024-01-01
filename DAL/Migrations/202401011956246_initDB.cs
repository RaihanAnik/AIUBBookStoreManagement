namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Long(nullable: false, identity: true),
                        BookName = c.String(),
                        BookType = c.String(),
                        BookWriter = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BookId);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        InventoryId = c.Long(nullable: false, identity: true),
                        BookId = c.Long(nullable: false),
                        Quantity = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.InventoryId);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        PriceId = c.Long(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        BuyingPrice = c.Decimal(precision: 18, scale: 2),
                        SellingPrice = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PriceId);
            
            CreateTable(
                "dbo.sells",
                c => new
                    {
                        SellId = c.Long(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        InventoryId = c.Long(nullable: false),
                        SellDate = c.DateTime(nullable: false),
                        SellQuantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SellId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        IntUserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserType = c.String(),
                        UserEmail = c.String(),
                        Age = c.Long(nullable: false),
                        Address = c.String(),
                        Mobile = c.String(),
                        Password = c.String(),
                        IsActive = c.Boolean(),
                    })
                .PrimaryKey(t => t.IntUserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.sells");
            DropTable("dbo.Prices");
            DropTable("dbo.Inventories");
            DropTable("dbo.Books");
        }
    }
}
