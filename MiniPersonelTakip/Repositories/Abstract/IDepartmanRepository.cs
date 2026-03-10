using MiniPersonelTakip.Entities;

namespace MiniPersonelTakip.Repositories.Abstract
{
    public interface IDepartmanRepository : IRepository<Departman>
    {
        Task<List<Departman>> GetAktifListAsync(CancellationToken cancellationToken = default);
    }
}