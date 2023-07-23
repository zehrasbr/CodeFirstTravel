namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_team : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "ImageUrl", c => c.String());
            AddColumn("dbo.Teams", "Title", c => c.String());
            AddColumn("dbo.Teams", "MediaUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "MediaUrl");
            DropColumn("dbo.Teams", "Title");
            DropColumn("dbo.Teams", "ImageUrl");
        }
    }
}
