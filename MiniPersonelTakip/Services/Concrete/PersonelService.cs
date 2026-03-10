using MiniPersonelTakip.Data;
using MiniPersonelTakip.DTOs.Personel;
using MiniPersonelTakip.Entities;
using MiniPersonelTakip.Helpers;
using MiniPersonelTakip.Repositories.Abstract;
using MiniPersonelTakip.Services.Abstract;

namespace MiniPersonelTakip.Services.Concrete
{
    public class PersonelService : IPersonelService
    {
        private readonly IPersonelRepository _personelRepository;
        private readonly AppDbContext _context;

        public PersonelService(IPersonelRepository personelRepository, AppDbContext context)
        {
            _personelRepository = personelRepository;
            _context = context;
        }

        public async Task<List<PersonelListDto>> GetFilteredAsync(PersonelFilterDto filter, CancellationToken cancellationToken = default)
        {
            return await _personelRepository.GetFilteredAsync(filter, cancellationToken);
        }

        public async Task<PersonelUpdateDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await _personelRepository.GetByIdAsync(id, cancellationToken);
            if (entity == null)
                return null;

            return new PersonelUpdateDto
            {
                Id = entity.Id,
                PersonelKod = entity.PersonelKod,
                Ad = entity.Ad,
                Soyad = entity.Soyad,
                DepartmanId = entity.DepartmanId,
                PozisyonId = entity.PozisyonId,
                Telefon = entity.Telefon,
                Eposta = entity.Eposta,
                Adres = entity.Adres,
                IseGirisTarihi = entity.IseGirisTarihi,
                AktifMi = entity.AktifMi
            };
        }

        public async Task AddAsync(PersonelCreateDto dto, CancellationToken cancellationToken = default)
        {
            ValidationHelper.ValidatePersonelCreate(dto);

            var exists = await _personelRepository.AnyByPersonelKodAsync(dto.PersonelKod, null, cancellationToken);
            if (exists)
                throw new InvalidOperationException("Bu personel kodu zaten kayıtlı.");

            var entity = new Personel
            {
                PersonelKod = dto.PersonelKod.Trim(),
                Ad = dto.Ad.Trim(),
                Soyad = dto.Soyad.Trim(),
                DepartmanId = dto.DepartmanId,
                PozisyonId = dto.PozisyonId,
                Telefon = dto.Telefon?.Trim() ?? string.Empty,
                Eposta = dto.Eposta?.Trim() ?? string.Empty,
                Adres = dto.Adres?.Trim() ?? string.Empty,
                IseGirisTarihi = dto.IseGirisTarihi,
                AktifMi = true
            };

            await _personelRepository.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(PersonelUpdateDto dto, CancellationToken cancellationToken = default)
        {
            ValidationHelper.ValidatePersonelUpdate(dto);

            var entity = await _personelRepository.GetByIdAsync(dto.Id, cancellationToken);
            if (entity == null)
                throw new KeyNotFoundException("Personel bulunamadı.");

            var exists = await _personelRepository.AnyByPersonelKodAsync(dto.PersonelKod, dto.Id, cancellationToken);
            if (exists)
                throw new InvalidOperationException("Bu personel kodu başka bir kayıtta kullanılıyor.");

            entity.PersonelKod = dto.PersonelKod.Trim();
            entity.Ad = dto.Ad.Trim();
            entity.Soyad = dto.Soyad.Trim();
            entity.DepartmanId = dto.DepartmanId;
            entity.PozisyonId = dto.PozisyonId;
            entity.Telefon = dto.Telefon?.Trim() ?? string.Empty;
            entity.Eposta = dto.Eposta?.Trim() ?? string.Empty;
            entity.Adres = dto.Adres?.Trim() ?? string.Empty;
            entity.IseGirisTarihi = dto.IseGirisTarihi;
            entity.AktifMi = dto.AktifMi;

            _personelRepository.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task SoftDeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await _personelRepository.GetByIdAsync(id, cancellationToken);
            if (entity == null)
                throw new KeyNotFoundException("Personel bulunamadı.");

            entity.AktifMi = false;

            _personelRepository.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}