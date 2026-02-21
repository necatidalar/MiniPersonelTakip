using Microsoft.EntityFrameworkCore;
using MiniPersonelTakip.Models;

namespace MiniPersonelTakip.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MiniPersonelTakipDB;Trusted_Connection=True;");
        }

        public DbSet<Personel> Personeller { get; set; }
    }
}