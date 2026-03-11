using Microsoft.EntityFrameworkCore;
using MiniPersonelTakip.Data;
using MiniPersonelTakip.DTOs.Gorev;
using MiniPersonelTakip.Entities;
using MiniPersonelTakip.Repositories.Abstract;

namespace MiniPersonelTakip.Repositories.Concrete
{
    public class GorevRepository : Repository<Gorev>, IGorevRepository
    {
        public GorevRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<GorevListDto>> GetFilteredAsync(GorevFilterDto filter, CancellationToken cancellationToken = default)
        {
            var query = _context.Gorevler
                .Include(x => x.Personel)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter.AramaMetni))
            {
                var arama = filter.AramaMetni.Trim();

                query = query.Where(x =>
                    EF.Functions.Like(x.GorevBasligi, $"%{arama}%") ||
                    EF.Functions.Like(x.GorevDetayi, $"%{arama}%") ||
                    (x.Personel != null && (
                        EF.Functions.Like(x.Personel.PersonelKod, $"%{arama}%") ||
                        EF.Functions.Like(x.Personel.Ad, $"%{arama}%") ||
                        EF.Functions.Like(x.Personel.Soyad, $"%{arama}%")
                    )));
            }

            if (filter.PersonelId.HasValue && filter.PersonelId.Value > 0)
                query = query.Where(x => x.PersonelId == filter.PersonelId.Value);

            if (!string.IsNullOrWhiteSpace(filter.Oncelik))
                query = query.Where(x => x.Oncelik == filter.Oncelik);

            if (!string.IsNullOrWhiteSpace(filter.Durum))
                query = query.Where(x => x.Durum == filter.Durum);

            if (filter.BaslangicTarihi.HasValue)
                query = query.Where(x => x.BaslangicTarihi.Date >= filter.BaslangicTarihi.Value.Date);

            if (filter.BitisTarihi.HasValue)
                query = query.Where(x => x.BaslangicTarihi.Date <= filter.BitisTarihi.Value.Date);

            return await query
                .OrderByDescending(x => x.OlusturmaTarihi)
                .Select(x => new GorevListDto
                {
                    Id = x.Id,
                    PersonelId = x.PersonelId,
                    PersonelKod = x.Personel != null ? x.Personel.PersonelKod : string.Empty,
                    PersonelAdSoyad = x.Personel != null ? x.Personel.Ad + " " + x.Personel.Soyad : string.Empty,
                    GorevBasligi = x.GorevBasligi,
                    GorevDetayi = x.GorevDetayi,
                    BaslangicTarihi = x.BaslangicTarihi,
                    BitisTarihi = x.BitisTarihi,
                    Oncelik = x.Oncelik,
                    Durum = x.Durum,
                    OlusturmaTarihi = x.OlusturmaTarihi
                })
                .ToListAsync(cancellationToken);
        }
    }
}