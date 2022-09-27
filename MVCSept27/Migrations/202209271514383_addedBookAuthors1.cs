namespace MVCSept27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBookAuthors1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Authors");
        }
    }
}
