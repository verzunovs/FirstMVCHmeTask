namespace Cars.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeShopModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shops", "City", c => c.String());
            DropColumn("dbo.Shops", "Ciry");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shops", "Ciry", c => c.String());
            DropColumn("dbo.Shops", "City");
        }
    }
}
