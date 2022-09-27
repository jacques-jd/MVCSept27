namespace MVCSept27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBookAuthors : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Genre", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Genre");
        }
    }
}
