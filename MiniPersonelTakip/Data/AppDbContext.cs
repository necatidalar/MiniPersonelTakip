using Microsoft.EntityFrameworkCore;
using MiniPersonelTakip.Entities;

namespace MiniPersonelTakip.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Personel> Personeller => Set<Personel>();
        public DbSet<Departman> Departmanlar => Set<Departman>();
        public DbSet<Pozisyon> Pozisyonlar => Set<Pozisyon>();
        public DbSet<Vardiya> Vardiyalar => Set<Vardiya>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Departman>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.DepartmanAdi)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(x => x.Aciklama)
                    .HasMaxLength(250);

                entity.HasIndex(x => x.DepartmanAdi)
                    .IsUnique();
            });

            modelBuilder.Entity<Pozisyon>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.PozisyonAdi)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(x => x.Aciklama)
                    .HasMaxLength(250);

                entity.HasIndex(x => x.PozisyonAdi)
                    .IsUnique();
            });

            modelBuilder.Entity<Personel>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.PersonelKod)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(x => x.Ad)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(x => x.Soyad)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(x => x.Telefon)
                    .HasMaxLength(20);

                entity.Property(x => x.Eposta)
                    .HasMaxLength(150);

                entity.Property(x => x.Adres)
                    .HasMaxLength(300);

                entity.HasIndex(x => x.PersonelKod)
                    .IsUnique();

                entity.HasOne(x => x.Departman)
                    .WithMany(x => x.Personeller)
                    .HasForeignKey(x => x.DepartmanId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(x => x.Pozisyon)
                    .WithMany(x => x.Personeller)
                    .HasForeignKey(x => x.PozisyonId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Vardiya>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.VardiyaTipi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(x => x.Durum)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(x => x.Aciklama)
                    .HasMaxLength(300);

                entity.HasOne(x => x.Personel)
                    .WithMany()
                    .HasForeignKey(x => x.PersonelId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}