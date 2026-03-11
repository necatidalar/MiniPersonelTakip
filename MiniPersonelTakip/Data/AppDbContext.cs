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
        public DbSet<Izin> Izinler => Set<Izin>();
        public DbSet<Gorev> Gorevler => Set<Gorev>();

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
                entity.ToTable("Personeller");

                entity.HasKey(x => x.Id);

                entity.Property(x => x.Id).HasColumnName("Id");

                entity.Property(x => x.PersonelKod)
                    .HasColumnName("PersonelKod")
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(x => x.Ad)
                    .HasColumnName("Ad")
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(x => x.Soyad)
                    .HasColumnName("Soyad")
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(x => x.DepartmanId)
                    .HasColumnName("DepartmanId");

                entity.Property(x => x.PozisyonId)
                    .HasColumnName("PozisyonId");

                entity.Property(x => x.Telefon)
                    .HasColumnName("Telefon")
                    .HasMaxLength(20);

                entity.Property(x => x.Eposta)
                    .HasColumnName("Eposta")
                    .HasMaxLength(150);

                entity.Property(x => x.Adres)
                    .HasColumnName("Adres")
                    .HasMaxLength(300);

                entity.Property(x => x.IseGirisTarihi)
                    .HasColumnName("IseGirisTarihi");

                entity.Property(x => x.KalanYillikIzinGun)
                    .HasColumnName("KalanYillikIzinGun")
                    .HasDefaultValue(14);

                entity.Property(x => x.AktifMi)
                    .HasColumnName("AktifMi");

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

            modelBuilder.Entity<Izin>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.IzinTuru)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(x => x.Durum)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(x => x.Aciklama)
                    .HasMaxLength(300);

                entity.Property(x => x.GunSayisi)
                    .IsRequired();

                entity.Property(x => x.OlusturmaTarihi)
                    .IsRequired();

                entity.HasIndex(x => new { x.PersonelId, x.BaslangicTarihi, x.BitisTarihi });

                entity.HasOne(x => x.Personel)
                    .WithMany(x => x.Izinler)
                    .HasForeignKey(x => x.PersonelId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Gorev>(entity =>
            {
                entity.ToTable("Gorevler");

                entity.HasKey(x => x.Id);

                entity.Property(x => x.Id).HasColumnName("Id");
                entity.Property(x => x.PersonelId).HasColumnName("PersonelId");

                entity.Property(x => x.GorevBasligi)
                       .HasMaxLength(150)
                       .IsRequired();

                entity.Property(x => x.GorevDetayi)
                    .HasMaxLength(1000)
                    .IsRequired();

                entity.Property(x => x.BaslangicTarihi)
                    .HasColumnName("BaslangicTarihi")
                    .IsRequired();

                entity.Property(x => x.BitisTarihi)
                    .HasColumnName("BitisTarihi");

                entity.Property(x => x.Oncelik)
                    .HasColumnName("Oncelik")
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(x => x.Durum)
                    .HasColumnName("Durum")
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(x => x.OlusturmaTarihi)
                    .HasColumnName("OlusturmaTarihi")
                    .IsRequired();

                entity.HasIndex(x => new { x.PersonelId, x.Durum, x.Oncelik });

                entity.HasOne(x => x.Personel)
                    .WithMany()
                    .HasForeignKey(x => x.PersonelId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}