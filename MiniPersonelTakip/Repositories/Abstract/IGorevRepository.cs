using MiniPersonelTakip.DTOs.Gorev;
using MiniPersonelTakip.Entities;

namespace MiniPersonelTakip.Repositories.Abstract
{
    public interface IGorevRepository : IRepository<Gorev>
    {
        Task<List<GorevListDto>> GetFilteredAsync(GorevFilterDto filter, CancellationToken cancellationToken = default);
    }
}