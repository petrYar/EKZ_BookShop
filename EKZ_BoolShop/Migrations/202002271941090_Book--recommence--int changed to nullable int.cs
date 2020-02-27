namespace EKZ_BoolShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bookrecommenceintchangedtonullableint : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.tblBook", new[] { "Recommence" });
            AlterColumn("dbo.tblBook", "Recommence", c => c.Int());
            CreateIndex("dbo.tblBook", "Recommence");
        }
        
        public override void Down()
        {
            DropIndex("dbo.tblBook", new[] { "Recommence" });
            AlterColumn("dbo.tblBook", "Recommence", c => c.Int(nullable: false));
            CreateIndex("dbo.tblBook", "Recommence");
        }
    }
}
