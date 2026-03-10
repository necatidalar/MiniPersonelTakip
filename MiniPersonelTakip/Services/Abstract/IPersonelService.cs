using MiniPersonelTakip.DTOs.Personel;

namespace MiniPersonelTakip.Services.Abstract
{
    public interface IPersonelService
    {
        Task<List<PersonelListDto>> GetFilteredAsync(PersonelFilterDto filter, CancellationToken cancellationToken = default);
        Task<PersonelUpdateDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task AddAsync(PersonelCreateDto dto, CancellationToken cancellationToken = default);
        Task UpdateAsync(PersonelUpdateDto dto, CancellationToken cancellationToken = default);
        Task SoftDeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}