namespace EKZ_BoolShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Repairingdefects : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.tblBook", name: "Genre_Id", newName: "GenreOf_Id");
            RenameIndex(table: "dbo.tblBook", name: "IX_Genre_Id", newName: "IX_GenreOf_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.tblBook", name: "IX_GenreOf_Id", newName: "IX_Genre_Id");
            RenameColumn(table: "dbo.tblBook", name: "GenreOf_Id", newName: "Genre_Id");
        }
    }
}
