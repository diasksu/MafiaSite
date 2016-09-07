namespace MafiaDomain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateAddStaticPages : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StaticPages",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Header = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StaticPages");
        }
    }
}
