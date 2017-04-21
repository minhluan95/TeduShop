namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteParentIdInProduct : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "ParentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ParentID", c => c.Int());
        }
    }
}
