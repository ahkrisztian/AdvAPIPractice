using AdvAPIPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvAPIPractice.Services
{
    public class AppDbContext : DbContext
    {
        public DbSet<Advertiser> Advertisers { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }

        public DbSet<SizeLookUp> SizeLookUp { get; set; }
        public AppDbContext() : base()
        {

        }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

       
    }
}
