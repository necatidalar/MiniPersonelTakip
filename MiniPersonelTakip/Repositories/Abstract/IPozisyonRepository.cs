using MiniPersonelTakip.Entities;

namespace MiniPersonelTakip.Repositories.Abstract
{
    public interface IPozisyonRepository : IRepository<Pozisyon>
    {
        Task<List<Pozisyon>> GetAktifListAsync(CancellationToken cancellationToken = default);
    }
}