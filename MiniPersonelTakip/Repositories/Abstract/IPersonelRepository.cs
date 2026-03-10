using MiniPersonelTakip.DTOs.Personel;
using MiniPersonelTakip.Entities;

namespace MiniPersonelTakip.Repositories.Abstract
{
    public interface IPersonelRepository : IRepository<Personel>
    {
        Task<bool> AnyByPersonelKodAsync(string personelKod, int? excludeId = null, CancellationToken cancellationToken = default);
        Task<List<PersonelListDto>> GetFilteredAsync(PersonelFilterDto filter, CancellationToken cancellationToken = default);
    }
}