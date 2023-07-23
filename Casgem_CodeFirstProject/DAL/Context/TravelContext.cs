using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Context
{
    public class TravelContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Explore> Explores { get; set; }
        public DbSet<FooterContact> FooterContacts { get; set; }
        public DbSet<ContactSocial> ContactSocials { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FooterGalery> FooterGaleries { get; set; }
        public DbSet<FooterTravelTrip> FooterTravelTrips { get; set; }
        public DbSet<AboutMe> AboutMes { get; set; }
        public DbSet<Galery> Galeries { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}