using MiniPersonelTakip.DTOs.Gorev;

namespace MiniPersonelTakip.Services.Abstract
{
    public interface IGorevService
    {
        Task<List<GorevListDto>> GetFilteredAsync(GorevFilterDto filter, CancellationToken cancellationToken = default);
        Task<GorevUpdateDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task AddAsync(GorevCreateDto dto, CancellationToken cancellationToken = default);
        Task UpdateAsync(GorevUpdateDto dto, CancellationToken cancellationToken = default);
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}