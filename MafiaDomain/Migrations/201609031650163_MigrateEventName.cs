namespace MafiaDomain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateEventName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Events", "Address", c => c.String(nullable: false));
            AddColumn("dbo.Events", "Beginner", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Events", "Country", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "City", c => c.String());
            AlterColumn("dbo.Events", "Country", c => c.String());
            DropColumn("dbo.Events", "Beginner");
            DropColumn("dbo.Events", "Address");
            DropColumn("dbo.Events", "Name");
        }
    }
}
