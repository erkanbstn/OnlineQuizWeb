namespace OnlineTest.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StatusAdded_User : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Status");
        }
    }
}
