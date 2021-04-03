namespace Cars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShopTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ciry = c.String(),
                        Adress = c.String(),
                        Manager = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "ShopId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "ShopId");
            AddForeignKey("dbo.Cars", "ShopId", "dbo.Shops", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "ShopId", "dbo.Shops");
            DropIndex("dbo.Cars", new[] { "ShopId" });
            DropColumn("dbo.Cars", "ShopId");
            DropTable("dbo.Shops");
        }
    }
}
