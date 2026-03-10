using MiniPersonelTakip.DTOs.Vardiya;
using MiniPersonelTakip.Entities;

namespace MiniPersonelTakip.Repositories.Abstract
{
    public interface IVardiyaRepository : IRepository<Vardiya>
    {
        Task<List<VardiyaListDto>> GetFilteredAsync(VardiyaFilterDto filter, CancellationToken cancellationToken = default);
        Task<bool> AnyByPersonelAndTarihAsync(int personelId, DateTime tarih, int? excludeId = null, CancellationToken cancellationToken = default);
    }
}