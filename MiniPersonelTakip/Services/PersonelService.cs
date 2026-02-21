using MiniPersonelTakip.Data;
using MiniPersonelTakip.Models;

namespace MiniPersonelTakip.Services
{
    public class PersonelService
    {
        public void Ekle(Personel personel)
        {
            using var db = new AppDbContext();

            if (db.Personeller.Any(p => p.TCKN == personel.TCKN))
                throw new Exception("Bu TCKN zaten kayıtlı.");

            db.Personeller.Add(personel);
            db.SaveChanges();
        }

        public void Guncelle(Personel model)
        {
            using var db = new AppDbContext();

            var p = db.Personeller.Find(model.Id);
            if (p == null)
                throw new Exception("Personel bulunamadı.");

            p.Ad = model.Ad;
            p.Soyad = model.Soyad;
            p.TCKN = model.TCKN;
            p.Telefon = model.Telefon;
            p.IseGirisTarihi = model.IseGirisTarihi;

            db.SaveChanges();
        }

        public void Sil(int id)
        {
            using var db = new AppDbContext();

            var p = db.Personeller.Find(id);
            if (p == null)
                throw new Exception("Personel bulunamadı.");

            p.AktifMi = false; // SOFT DELETE
            db.SaveChanges();
        }

        public List<Personel> Listele()
        {
            using var db = new AppDbContext();
            return db.Personeller
                     .Where(p => p.AktifMi)
                     .ToList();
        }

        public Personel Getir(int id)
        {
            using var db = new AppDbContext();
            return db.Personeller.Find(id);
        }
    }
}