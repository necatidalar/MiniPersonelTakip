using Microsoft.EntityFrameworkCore;
using MiniPersonelTakip.Data;
using MiniPersonelTakip.DTOs.Personel;
using MiniPersonelTakip.Entities;
using MiniPersonelTakip.Repositories.Abstract;

namespace MiniPersonelTakip.Repositories.Concrete
{
    public class PersonelRepository : Repository<Personel>, IPersonelRepository
    {
        public PersonelRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<bool> AnyByPersonelKodAsync(string personelKod, int? excludeId = null, CancellationToken cancellationToken = default)
        {
            return await _context.Personeller.AnyAsync(x =>
                x.PersonelKod == personelKod &&
                (!excludeId.HasValue || x.Id != excludeId.Value),
                cancellationToken);
        }

        public async Task<List<PersonelListDto>> GetFilteredAsync(PersonelFilterDto filter, CancellationToken cancellationToken = default)
        {
            var query = _context.Personeller
                .Include(x => x.Departman)
                .Include(x => x.Pozisyon)
                .AsQueryable();

            if (filter.SadeceAktifler)
            {
                query = query.Where(x => x.AktifMi);
            }

            if (!string.IsNullOrWhiteSpace(filter.AramaMetni))
            {
                var arama = filter.AramaMetni.Trim();

                query = query.Where(x =>
                    x.Ad.Contains(arama) ||
                    x.Soyad.Contains(arama) ||
                    x.PersonelKod.Contains(arama) ||
                    x.Telefon.Contains(arama) ||
                    x.Eposta.Contains(arama));
            }

            if (filter.DepartmanId.HasValue && filter.DepartmanId.Value > 0)
            {
                query = query.Where(x => x.DepartmanId == filter.DepartmanId.Value);
            }

            if (filter.PozisyonId.HasValue && filter.PozisyonId.Value > 0)
            {
                query = query.Where(x => x.PozisyonId == filter.PozisyonId.Value);
            }

            return await query
                .OrderBy(x => x.Ad)
                .ThenBy(x => x.Soyad)
                .Select(x => new PersonelListDto
                {
                    Id = x.Id,
                    PersonelKod = x.PersonelKod,
                    Ad = x.Ad,
                    Soyad = x.Soyad,
                    DepartmanId = x.DepartmanId,
                    DepartmanAdi = x.Departman != null ? x.Departman.DepartmanAdi : string.Empty,
                    PozisyonId = x.PozisyonId,
                    PozisyonAdi = x.Pozisyon != null ? x.Pozisyon.PozisyonAdi : string.Empty,
                    Telefon = x.Telefon,
                    Eposta = x.Eposta,
                    IseGirisTarihi = x.IseGirisTarihi,
                    AktifMi = x.AktifMi
                })
                .ToListAsync(cancellationToken);
        }
    }
}