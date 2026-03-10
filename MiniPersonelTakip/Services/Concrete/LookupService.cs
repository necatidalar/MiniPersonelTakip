using MiniPersonelTakip.DTOs.Common;
using MiniPersonelTakip.DTOs.Personel;
using MiniPersonelTakip.Repositories.Abstract;
using MiniPersonelTakip.Services.Abstract;

namespace MiniPersonelTakip.Services.Concrete
{
    public class LookupService : ILookupService
    {
        private readonly IDepartmanRepository _departmanRepository;
        private readonly IPozisyonRepository _pozisyonRepository;
        private readonly IPersonelRepository _personelRepository;

        public LookupService(
            IDepartmanRepository departmanRepository,
            IPozisyonRepository pozisyonRepository,
            IPersonelRepository personelRepository)
        {
            _departmanRepository = departmanRepository;
            _pozisyonRepository = pozisyonRepository;
            _personelRepository = personelRepository;
        }

        public async Task<List<LookupDto>> GetAktifDepartmanlarAsync(CancellationToken cancellationToken = default)
        {
            var list = await _departmanRepository.GetAktifListAsync(cancellationToken);

            return list
                .Select(x => new LookupDto
                {
                    Id = x.Id,
                    Ad = x.DepartmanAdi
                })
                .ToList();
        }

        public async Task<List<LookupDto>> GetAktifPozisyonlarAsync(CancellationToken cancellationToken = default)
        {
            var list = await _pozisyonRepository.GetAktifListAsync(cancellationToken);

            return list
                .Select(x => new LookupDto
                {
                    Id = x.Id,
                    Ad = x.PozisyonAdi
                })
                .ToList();
        }

        public async Task<List<LookupDto>> GetAktifPersonellerAsync(CancellationToken cancellationToken = default)
        {
            var list = await _personelRepository.GetFilteredAsync(
                new PersonelFilterDto
                {
                    SadeceAktifler = true
                },
                cancellationToken);

            return list
                .Select(x => new LookupDto
                {
                    Id = x.Id,
                    Ad = $"{x.PersonelKod} - {x.AdSoyad}"
                })
                .ToList();
        }
    }
}