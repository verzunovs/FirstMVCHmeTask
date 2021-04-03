namespace Cars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLinkBetweenTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "ShopId", "dbo.Shops");
            AddForeignKey("dbo.Cars", "ShopId", "dbo.Shops", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "ShopId", "dbo.Shops");
            AddForeignKey("dbo.Cars", "ShopId", "dbo.Shops", "Id", cascadeDelete: true);
        }
    }
}
