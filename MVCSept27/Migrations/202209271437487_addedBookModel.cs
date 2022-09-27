namespace MVCSept27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBookModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookPKID = c.Int(nullable: false, identity: true),
                        ISBN = c.String(nullable: false, maxLength: 11),
                        Title = c.String(nullable: false, maxLength: 100),
                        AuthorName = c.String(nullable: false),
                        PublishedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BookPKID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
