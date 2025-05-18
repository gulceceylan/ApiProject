
using ApiProjectCamp.WebApi.Properties.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProjectCamp.WebApi.Context
{
    public class ApiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-KUCNJLV5\SQLEXPRESS;Database=ApiyummyDb;Integrated Security=True;TrustServerCertificate=True;");

        }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Chef> Chefs{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Feature> Features{ get; set; }
        public DbSet<Image> Images{ get; set; }
        public DbSet<Message> Messages{ get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Reservation> Reservations{ get; set; }
        public DbSet<Services> Services{ get; set; }
        public DbSet<TestImonial> Testimonials{ get; set; }
    }
}
