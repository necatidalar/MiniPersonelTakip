using MiniPersonelTakip.DTOs.Vardiya;

namespace MiniPersonelTakip.Services.Abstract
{
    public interface IVardiyaService
    {
        Task<List<VardiyaListDto>> GetFilteredAsync(VardiyaFilterDto filter, CancellationToken cancellationToken = default);
        Task<VardiyaUpdateDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task AddAsync(VardiyaCreateDto dto, CancellationToken cancellationToken = default);
        Task UpdateAsync(VardiyaUpdateDto dto, CancellationToken cancellationToken = default);
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}