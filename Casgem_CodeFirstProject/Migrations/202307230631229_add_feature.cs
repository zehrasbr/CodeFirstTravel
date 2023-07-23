namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_feature : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Title = c.String(),
                        ImageUrl = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.FeatureID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Features");
        }
    }
}
