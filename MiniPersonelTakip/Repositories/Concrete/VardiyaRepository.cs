using Microsoft.EntityFrameworkCore;
using MiniPersonelTakip.Data;
using MiniPersonelTakip.DTOs.Vardiya;
using MiniPersonelTakip.Entities;
using MiniPersonelTakip.Repositories.Abstract;

namespace MiniPersonelTakip.Repositories.Concrete
{
    public class VardiyaRepository : Repository<Vardiya>, IVardiyaRepository
    {
        public VardiyaRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<bool> AnyByPersonelAndTarihAsync(int personelId, DateTime tarih, int? excludeId = null, CancellationToken cancellationToken = default)
        {
            var onlyDate = tarih.Date;

            return await _context.Vardiyalar.AnyAsync(x =>
                x.PersonelId == personelId &&
                x.Tarih.Date == onlyDate &&
                (!excludeId.HasValue || x.Id != excludeId.Value),
                cancellationToken);
        }

        public async Task<List<VardiyaListDto>> GetFilteredAsync(VardiyaFilterDto filter, CancellationToken cancellationToken = default)
        {
            var query = _context.Vardiyalar
                .Include(x => x.Personel)
                .AsQueryable();

            if (filter.PersonelId.HasValue && filter.PersonelId.Value > 0)
                query = query.Where(x => x.PersonelId == filter.PersonelId.Value);

            if (filter.BaslangicTarihi.HasValue)
                query = query.Where(x => x.Tarih >= filter.BaslangicTarihi.Value.Date);

            if (filter.BitisTarihi.HasValue)
                query = query.Where(x => x.Tarih <= filter.BitisTarihi.Value.Date);

            if (!string.IsNullOrWhiteSpace(filter.VardiyaTipi))
                query = query.Where(x => x.VardiyaTipi == filter.VardiyaTipi);

            if (!string.IsNullOrWhiteSpace(filter.Durum))
                query = query.Where(x => x.Durum == filter.Durum);

            return await query
                .OrderByDescending(x => x.Tarih)
                .ThenBy(x => x.Personel != null ? x.Personel.Ad : string.Empty)
                .Select(x => new VardiyaListDto
                {
                    Id = x.Id,
                    PersonelId = x.PersonelId,
                    PersonelKod = x.Personel != null ? x.Personel.PersonelKod : string.Empty,
                    PersonelAdSoyad = x.Personel != null ? x.Personel.Ad + " " + x.Personel.Soyad : string.Empty,
                    Tarih = x.Tarih,
                    PlanlananGiris = x.PlanlananGiris,
                    PlanlananCikis = x.PlanlananCikis,
                    GercekGiris = x.GercekGiris,
                    GercekCikis = x.GercekCikis,
                    VardiyaTipi = x.VardiyaTipi,
                    Durum = x.Durum,
                    Aciklama = x.Aciklama,
                    PlanlananSureSaat = (x.PlanlananCikis - x.PlanlananGiris).TotalHours,
                    GerceklesenSureSaat = x.GercekGiris.HasValue && x.GercekCikis.HasValue
                        ? (x.GercekCikis.Value - x.GercekGiris.Value).TotalHours
                        : 0,
                    FarkSaat = x.GercekGiris.HasValue && x.GercekCikis.HasValue
                        ? (x.GercekCikis.Value - x.GercekGiris.Value).TotalHours - (x.PlanlananCikis - x.PlanlananGiris).TotalHours
                        : 0
                })
                .ToListAsync(cancellationToken);
        }
    }
}