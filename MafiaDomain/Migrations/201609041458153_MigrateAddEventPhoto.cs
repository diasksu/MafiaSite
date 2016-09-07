namespace MafiaDomain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateAddEventPhoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Photo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "Photo");
        }
    }
}
