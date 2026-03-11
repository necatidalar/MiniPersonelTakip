using MiniPersonelTakip.DTOs.Izin;

namespace MiniPersonelTakip.Services.Abstract
{
    public interface IIzinService
    {
        Task<List<IzinListDto>> GetFilteredAsync(IzinFilterDto filter, CancellationToken cancellationToken = default);
        Task<IzinUpdateDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task AddAsync(IzinCreateDto dto, CancellationToken cancellationToken = default);
        Task UpdateAsync(IzinUpdateDto dto, CancellationToken cancellationToken = default);
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}