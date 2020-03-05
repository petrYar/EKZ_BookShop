namespace EKZ_BoolShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class replacedoubleinpagestoint : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblBook", "GenreOf_Id", "dbo.tblGenre");
            DropIndex("dbo.tblBook", new[] { "GenreOf_Id" });
            DropColumn("dbo.tblBook", "Genre");
            RenameColumn(table: "dbo.tblBook", name: "GenreOf_Id", newName: "Genre");
            AlterColumn("dbo.tblBook", "Pages", c => c.Int(nullable: false));
            AlterColumn("dbo.tblBook", "Genre", c => c.Int(nullable: false));
            CreateIndex("dbo.tblBook", "Genre");
            AddForeignKey("dbo.tblBook", "Genre", "dbo.tblGenre", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblBook", "Genre", "dbo.tblGenre");
            DropIndex("dbo.tblBook", new[] { "Genre" });
            AlterColumn("dbo.tblBook", "Genre", c => c.Int());
            AlterColumn("dbo.tblBook", "Pages", c => c.Double(nullable: false));
            RenameColumn(table: "dbo.tblBook", name: "Genre", newName: "GenreOf_Id");
            AddColumn("dbo.tblBook", "Genre", c => c.Int(nullable: false));
            CreateIndex("dbo.tblBook", "GenreOf_Id");
            AddForeignKey("dbo.tblBook", "GenreOf_Id", "dbo.tblGenre", "Id");
        }
    }
}
