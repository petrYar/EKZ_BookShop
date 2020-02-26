namespace EKZ_BoolShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAccount",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblAuthor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Patronymic = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblBook",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Recommence = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Category = c.Int(nullable: false),
                        Price = c.String(),
                        SelfPrice = c.String(),
                        Author = c.Int(nullable: false),
                        Description = c.String(),
                        Publisher = c.Int(nullable: false),
                        Pages = c.Double(nullable: false),
                        Genre = c.Int(nullable: false),
                        DateOfPublishing = c.DateTime(nullable: false),
                        Genre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblAuthor", t => t.Author, cascadeDelete: true)
                .ForeignKey("dbo.tblCategory", t => t.Category, cascadeDelete: true)
                .ForeignKey("dbo.tblPublisher", t => t.Publisher, cascadeDelete: true)
                .ForeignKey("dbo.tblBook", t => t.Recommence)
                .ForeignKey("dbo.tblGenre", t => t.Genre_Id)
                .Index(t => t.Recommence)
                .Index(t => t.Category)
                .Index(t => t.Author)
                .Index(t => t.Publisher)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.tblCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblPublisher",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblGenre",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblBook", "Genre_Id", "dbo.tblGenre");
            DropForeignKey("dbo.tblBook", "Recommence", "dbo.tblBook");
            DropForeignKey("dbo.tblBook", "Publisher", "dbo.tblPublisher");
            DropForeignKey("dbo.tblBook", "Category", "dbo.tblCategory");
            DropForeignKey("dbo.tblBook", "Author", "dbo.tblAuthor");
            DropIndex("dbo.tblBook", new[] { "Genre_Id" });
            DropIndex("dbo.tblBook", new[] { "Publisher" });
            DropIndex("dbo.tblBook", new[] { "Author" });
            DropIndex("dbo.tblBook", new[] { "Category" });
            DropIndex("dbo.tblBook", new[] { "Recommence" });
            DropTable("dbo.tblGenre");
            DropTable("dbo.tblPublisher");
            DropTable("dbo.tblCategory");
            DropTable("dbo.tblBook");
            DropTable("dbo.tblAuthor");
            DropTable("dbo.tblAccount");
        }
    }
}
