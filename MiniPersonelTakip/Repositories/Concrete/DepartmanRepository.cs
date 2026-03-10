using Microsoft.EntityFrameworkCore;
using MiniPersonelTakip.Data;
using MiniPersonelTakip.Entities;
using MiniPersonelTakip.Repositories.Abstract;

namespace MiniPersonelTakip.Repositories.Concrete
{
    public class DepartmanRepository : Repository<Departman>, IDepartmanRepository
    {
        public DepartmanRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Departman>> GetAktifListAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Departmanlar
                .Where(x => x.AktifMi)
                .OrderBy(x => x.DepartmanAdi)
                .ToListAsync(cancellationToken);
        }
    }
}