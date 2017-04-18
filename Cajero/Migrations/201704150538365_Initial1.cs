namespace Cajero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "UserRole");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserRole", c => c.Int(nullable: false));
        }
    }
}
