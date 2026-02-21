using Microsoft.EntityFrameworkCore;
using MiniPersonelTakip.Models;

namespace MiniPersonelTakip.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MiniPersonelTakipDB;Trusted_Connection=True;TrustServerCertificate=True;;");
        }

        public DbSet<Personel> Personeller { get; set; }
    }
}