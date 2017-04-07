namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixbuginproduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ParentID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ParentID");
        }
    }
}
