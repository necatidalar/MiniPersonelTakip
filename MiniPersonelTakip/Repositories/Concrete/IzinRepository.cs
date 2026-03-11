using Microsoft.EntityFrameworkCore;
using MiniPersonelTakip.Data;
using MiniPersonelTakip.DTOs.Izin;
using MiniPersonelTakip.Repositories.Abstract;
using MiniPersonelTakip.Entities;

namespace MiniPersonelTakip.Repositories.Concrete
{
    public class IzinRepository : Repository<Izin>, IIzinRepository
    {
        public IzinRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<IzinListDto>> GetFilteredAsync(IzinFilterDto filter, CancellationToken cancellationToken = default)
        {
            var query = _context.Izinler
                .Include(x => x.Personel)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter.AramaMetni))
            {
                var arama = filter.AramaMetni.Trim();

                query = query.Where(x =>
                    (x.Personel != null && (
                        EF.Functions.Like(x.Personel.PersonelKod, $"%{arama}%") ||
                        EF.Functions.Like(x.Personel.Ad, $"%{arama}%") ||
                        EF.Functions.Like(x.Personel.Soyad, $"%{arama}%"))) ||
                    EF.Functions.Like(x.IzinTuru, $"%{arama}%") ||
                    (x.Aciklama != null && EF.Functions.Like(x.Aciklama, $"%{arama}%")));
            }

            if (filter.PersonelId.HasValue && filter.PersonelId.Value > 0)
                query = query.Where(x => x.PersonelId == filter.PersonelId.Value);

            if (!string.IsNullOrWhiteSpace(filter.IzinTuru))
                query = query.Where(x => x.IzinTuru == filter.IzinTuru);

            if (!string.IsNullOrWhiteSpace(filter.Durum))
                query = query.Where(x => x.Durum == filter.Durum);

            if (filter.BaslangicTarihi.HasValue)
                query = query.Where(x => x.BitisTarihi >= filter.BaslangicTarihi.Value.Date);

            if (filter.BitisTarihi.HasValue)
                query = query.Where(x => x.BaslangicTarihi <= filter.BitisTarihi.Value.Date);

            return await query
                .OrderByDescending(x => x.BaslangicTarihi)
                .ThenBy(x => x.Personel != null ? x.Personel.Ad : string.Empty)
                .Select(x => new IzinListDto
                {
                    Id = x.Id,
                    PersonelId = x.PersonelId,
                    PersonelKod = x.Personel != null ? x.Personel.PersonelKod : string.Empty,
                    PersonelAdSoyad = x.Personel != null ? x.Personel.Ad + " " + x.Personel.Soyad : string.Empty,
                    IzinTuru = x.IzinTuru,
                    BaslangicTarihi = x.BaslangicTarihi,
                    BitisTarihi = x.BitisTarihi,
                    GunSayisi = x.GunSayisi,
                    Durum = x.Durum,
                    Aciklama = x.Aciklama,
                    KalanYillikIzinGun = x.Personel != null ? x.Personel.KalanYillikIzinGun : 0
                })
                .ToListAsync(cancellationToken);
        }

        public async Task<bool> HasDateOverlapAsync(
            int personelId,
            DateTime baslangicTarihi,
            DateTime bitisTarihi,
            int? excludeId = null,
            CancellationToken cancellationToken = default)
        {
            var baslangic = baslangicTarihi.Date;
            var bitis = bitisTarihi.Date;

            return await _context.Izinler.AnyAsync(x =>
                x.PersonelId == personelId &&
                x.BaslangicTarihi <= bitis &&
                x.BitisTarihi >= baslangic &&
                x.Durum != "Reddedildi" &&
                x.Durum != "İptal Edildi" &&
                (!excludeId.HasValue || x.Id != excludeId.Value),
                cancellationToken);
        }
    }
}