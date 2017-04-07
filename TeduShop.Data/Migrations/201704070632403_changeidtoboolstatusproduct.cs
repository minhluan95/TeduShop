namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeidtoboolstatusproduct : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "HotFlag", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "HotFlag", c => c.Int());
        }
    }
}
