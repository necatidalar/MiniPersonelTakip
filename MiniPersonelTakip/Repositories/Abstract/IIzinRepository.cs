using MiniPersonelTakip.DTOs.Izin;
using MiniPersonelTakip.Entities;

namespace MiniPersonelTakip.Repositories.Abstract
{
    public interface IIzinRepository : IRepository<Izin>
    {
        Task<List<IzinListDto>> GetFilteredAsync(IzinFilterDto filter, CancellationToken cancellationToken = default);
        Task<bool> HasDateOverlapAsync(
            int personelId,
            DateTime baslangicTarihi,
            DateTime bitisTarihi,
            int? excludeId = null,
            CancellationToken cancellationToken = default);
    }
}