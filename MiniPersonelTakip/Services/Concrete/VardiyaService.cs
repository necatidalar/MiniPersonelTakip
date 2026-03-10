using MiniPersonelTakip.Data;
using MiniPersonelTakip.DTOs.Vardiya;
using MiniPersonelTakip.Entities;
using MiniPersonelTakip.Helpers;
using MiniPersonelTakip.Repositories.Abstract;
using MiniPersonelTakip.Services.Abstract;

namespace MiniPersonelTakip.Services.Concrete
{
    public class VardiyaService : IVardiyaService
    {
        private readonly IVardiyaRepository _vardiyaRepository;
        private readonly IPersonelRepository _personelRepository;
        private readonly AppDbContext _context;

        public VardiyaService(
            IVardiyaRepository vardiyaRepository,
            IPersonelRepository personelRepository,
            AppDbContext context)
        {
            _vardiyaRepository = vardiyaRepository;
            _personelRepository = personelRepository;
            _context = context;
        }

        public async Task<List<VardiyaListDto>> GetFilteredAsync(VardiyaFilterDto filter, CancellationToken cancellationToken = default)
        {
            return await _vardiyaRepository.GetFilteredAsync(filter, cancellationToken);
        }

        public async Task<VardiyaUpdateDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await _vardiyaRepository.GetByIdAsync(id, cancellationToken);
            if (entity == null)
                return null;

            return new VardiyaUpdateDto
            {
                Id = entity.Id,
                PersonelId = entity.PersonelId,
                Tarih = entity.Tarih,
                PlanlananGiris = entity.PlanlananGiris,
                PlanlananCikis = entity.PlanlananCikis,
                GercekGiris = entity.GercekGiris,
                GercekCikis = entity.GercekCikis,
                VardiyaTipi = entity.VardiyaTipi,
                Durum = entity.Durum,
                Aciklama = entity.Aciklama
            };
        }

        public async Task AddAsync(VardiyaCreateDto dto, CancellationToken cancellationToken = default)
        {
            VardiyaValidationHelper.ValidateCreate(dto);

            var personel = await _personelRepository.GetByIdAsync(dto.PersonelId, cancellationToken);
            if (personel == null)
                throw new KeyNotFoundException("Seçilen personel bulunamadı.");

            var exists = await _vardiyaRepository.AnyByPersonelAndTarihAsync(dto.PersonelId, dto.Tarih, null, cancellationToken);
            if (exists)
                throw new InvalidOperationException("Bu personel için seçilen tarihte zaten vardiya kaydı var.");

            var entity = new Vardiya
            {
                PersonelId = dto.PersonelId,
                Tarih = dto.Tarih.Date,
                PlanlananGiris = dto.PlanlananGiris,
                PlanlananCikis = dto.PlanlananCikis,
                GercekGiris = dto.GercekGiris,
                GercekCikis = dto.GercekCikis,
                VardiyaTipi = dto.VardiyaTipi.Trim(),
                Durum = dto.Durum.Trim(),
                Aciklama = dto.Aciklama?.Trim(),
                OlusturmaTarihi = DateTime.Now
            };

            await _vardiyaRepository.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(VardiyaUpdateDto dto, CancellationToken cancellationToken = default)
        {
            VardiyaValidationHelper.ValidateUpdate(dto);

            var entity = await _vardiyaRepository.GetByIdAsync(dto.Id, cancellationToken);
            if (entity == null)
                throw new KeyNotFoundException("Vardiya kaydı bulunamadı.");

            var personel = await _personelRepository.GetByIdAsync(dto.PersonelId, cancellationToken);
            if (personel == null)
                throw new KeyNotFoundException("Seçilen personel bulunamadı.");

            var exists = await _vardiyaRepository.AnyByPersonelAndTarihAsync(dto.PersonelId, dto.Tarih, dto.Id, cancellationToken);
            if (exists)
                throw new InvalidOperationException("Bu personel için seçilen tarihte başka bir vardiya kaydı var.");

            entity.PersonelId = dto.PersonelId;
            entity.Tarih = dto.Tarih.Date;
            entity.PlanlananGiris = dto.PlanlananGiris;
            entity.PlanlananCikis = dto.PlanlananCikis;
            entity.GercekGiris = dto.GercekGiris;
            entity.GercekCikis = dto.GercekCikis;
            entity.VardiyaTipi = dto.VardiyaTipi.Trim();
            entity.Durum = dto.Durum.Trim();
            entity.Aciklama = dto.Aciklama?.Trim();

            _vardiyaRepository.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await _vardiyaRepository.GetByIdAsync(id, cancellationToken);
            if (entity == null)
                throw new KeyNotFoundException("Vardiya kaydı bulunamadı.");

            _context.Vardiyalar.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}