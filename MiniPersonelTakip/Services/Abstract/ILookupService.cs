using MiniPersonelTakip.DTOs.Common;

namespace MiniPersonelTakip.Services.Abstract
{
    public interface ILookupService
    {
        Task<List<LookupDto>> GetAktifDepartmanlarAsync(CancellationToken cancellationToken = default);
        Task<List<LookupDto>> GetAktifPozisyonlarAsync(CancellationToken cancellationToken = default);
        Task<List<LookupDto>> GetAktifPersonellerAsync(CancellationToken cancellationToken = default);
    }
}