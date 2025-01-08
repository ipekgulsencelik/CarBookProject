using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Context
{
    public class CarBookContext : DbContext
    {
        public CarBookContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
    }
}