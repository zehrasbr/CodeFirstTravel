namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutMes",
                c => new
                    {
                        AboutMeID = c.Int(nullable: false, identity: true),
                        Title1 = c.String(),
                        Description1 = c.String(),
                        ImageUrl1 = c.String(),
                        Title2 = c.String(),
                        Description2 = c.String(),
                        ImageUrl2 = c.String(),
                    })
                .PrimaryKey(t => t.AboutMeID);
            
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Destination = c.String(),
                        Duration = c.String(),
                        Mail = c.String(),
                        BookingDate = c.DateTime(nullable: false),
                        BookingStatus = c.String(),
                    })
                .PrimaryKey(t => t.BookingID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Mail = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.ContactSocials",
                c => new
                    {
                        ContactSocialID = c.Int(nullable: false, identity: true),
                        ContactSocialName = c.String(),
                        ContactSocialURL = c.String(),
                        ContactSocialIcon = c.String(),
                    })
                .PrimaryKey(t => t.ContactSocialID);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationID = c.Int(nullable: false, identity: true),
                        DestinationName = c.String(),
                        DayNight = c.String(),
                        Capacity = c.Byte(nullable: false),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DestinationID);
            
            CreateTable(
                "dbo.Explores",
                c => new
                    {
                        ExploreID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ExploreID);
            
            CreateTable(
                "dbo.FooterContacts",
                c => new
                    {
                        FooterID = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Phone = c.String(),
                        Mail = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.FooterID);
            
            CreateTable(
                "dbo.FooterGaleries",
                c => new
                    {
                        FooterGaleryID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.FooterGaleryID);
            
            CreateTable(
                "dbo.FooterTravelTrips",
                c => new
                    {
                        FooterTravelTripID = c.Int(nullable: false, identity: true),
                        FooterTravelTripName = c.String(),
                    })
                .PrimaryKey(t => t.FooterTravelTripID);
            
            CreateTable(
                "dbo.Galeries",
                c => new
                    {
                        GaleryID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.GaleryID);
            
            CreateTable(
                "dbo.Guides",
                c => new
                    {
                        GuideID = c.Int(nullable: false, identity: true),
                        GuideName = c.String(),
                        GuideTitle = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.GuideID);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaID = c.Int(nullable: false, identity: true),
                        SocialMediaName = c.String(),
                        SocialMediaUrl = c.String(),
                        Icon = c.String(),
                        GuideID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SocialMediaID)
                .ForeignKey("dbo.Guides", t => t.GuideID, cascadeDelete: true)
                .Index(t => t.GuideID);
            
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        PlaceID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PlaceID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.ServiceID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SocialMedias", "GuideID", "dbo.Guides");
            DropIndex("dbo.SocialMedias", new[] { "GuideID" });
            DropTable("dbo.Services");
            DropTable("dbo.Places");
            DropTable("dbo.SocialMedias");
            DropTable("dbo.Guides");
            DropTable("dbo.Galeries");
            DropTable("dbo.FooterTravelTrips");
            DropTable("dbo.FooterGaleries");
            DropTable("dbo.FooterContacts");
            DropTable("dbo.Explores");
            DropTable("dbo.Destinations");
            DropTable("dbo.ContactSocials");
            DropTable("dbo.Contacts");
            DropTable("dbo.Categories");
            DropTable("dbo.Bookings");
            DropTable("dbo.Admins");
            DropTable("dbo.Abouts");
            DropTable("dbo.AboutMes");
        }
    }
}
