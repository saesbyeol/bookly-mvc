namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOib : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Oib");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Oib", c => c.String(nullable: false, maxLength: 11));
        }
    }
}
