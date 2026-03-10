using Microsoft.EntityFrameworkCore;
using MiniPersonelTakip.Data;
using MiniPersonelTakip.Entities;
using MiniPersonelTakip.Repositories.Abstract;

namespace MiniPersonelTakip.Repositories.Concrete
{
    public class PozisyonRepository : Repository<Pozisyon>, IPozisyonRepository
    {
        public PozisyonRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Pozisyon>> GetAktifListAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Pozisyonlar
                .Where(x => x.AktifMi)
                .OrderBy(x => x.PozisyonAdi)
                .ToListAsync(cancellationToken);
        }
    }
}