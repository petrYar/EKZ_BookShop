namespace EKZ_BoolShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initilize : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblBook", "Title", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.tblBook", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblBook", "Name", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.tblBook", "Title");
        }
    }
}
