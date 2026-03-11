using Microsoft.EntityFrameworkCore;
using MiniPersonelTakip.Data;
using MiniPersonelTakip.DTOs.Gorev;
using MiniPersonelTakip.Entities;
using MiniPersonelTakip.Helpers;
using MiniPersonelTakip.Repositories.Abstract;
using MiniPersonelTakip.Services.Abstract;

namespace MiniPersonelTakip.Services.Concrete
{
    public class GorevService : IGorevService
    {
        private readonly IGorevRepository _gorevRepository;
        private readonly IPersonelRepository _personelRepository;
        private readonly AppDbContext _context;

        public GorevService(
            IGorevRepository gorevRepository,
            IPersonelRepository personelRepository,
            AppDbContext context)
        {
            _gorevRepository = gorevRepository;
            _personelRepository = personelRepository;
            _context = context;
        }

        public async Task<List<GorevListDto>> GetFilteredAsync(GorevFilterDto filter, CancellationToken cancellationToken = default)
        {
            return await _gorevRepository.GetFilteredAsync(filter, cancellationToken);
        }

        public async Task<GorevUpdateDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await _gorevRepository.GetByIdAsync(id, cancellationToken);
            if (entity == null)
                return null;

            return new GorevUpdateDto
            {
                Id = entity.Id,
                PersonelId = entity.PersonelId,
                GorevBasligi = entity.GorevBasligi,
                GorevDetayi = entity.GorevDetayi,
                BaslangicTarihi = entity.BaslangicTarihi,
                BitisTarihi = entity.BitisTarihi,
                Oncelik = entity.Oncelik,
                Durum = entity.Durum
            };
        }

        public async Task AddAsync(GorevCreateDto dto, CancellationToken cancellationToken = default)
        {
            GorevValidationHelper.ValidateCreate(dto);

            var personel = await _personelRepository.GetByIdAsync(dto.PersonelId, cancellationToken);
            if (personel == null)
                throw new KeyNotFoundException("Seçilen personel bulunamadı.");

            var entity = new Gorev
            {
                PersonelId = dto.PersonelId,
                GorevBasligi = dto.GorevBasligi.Trim(),
                GorevDetayi = dto.GorevDetayi.Trim(),
                BaslangicTarihi = dto.BaslangicTarihi.Date,
                BitisTarihi = dto.BitisTarihi?.Date,
                Oncelik = dto.Oncelik.Trim(),
                Durum = dto.Durum.Trim(),
                OlusturmaTarihi = DateTime.Now
            };

            try
            {
                await _gorevRepository.AddAsync(entity, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException(
                    "Görev kaydı veritabanına yazılırken hata oluştu. Tablo yapısı, kolon adları, foreign key ve zorunlu alanları kontrol edin.",
                    ex);
            }
        }

        public async Task UpdateAsync(GorevUpdateDto dto, CancellationToken cancellationToken = default)
        {
            GorevValidationHelper.ValidateUpdate(dto);

            var entity = await _gorevRepository.GetByIdAsync(dto.Id, cancellationToken);
            if (entity == null)
                throw new KeyNotFoundException("Görev kaydı bulunamadı.");

            var personel = await _personelRepository.GetByIdAsync(dto.PersonelId, cancellationToken);
            if (personel == null)
                throw new KeyNotFoundException("Seçilen personel bulunamadı.");

            entity.PersonelId = dto.PersonelId;
            entity.GorevBasligi = dto.GorevBasligi.Trim();
            entity.GorevDetayi = dto.GorevDetayi.Trim();
            entity.BaslangicTarihi = dto.BaslangicTarihi.Date;
            entity.BitisTarihi = dto.BitisTarihi?.Date;
            entity.Oncelik = dto.Oncelik.Trim();
            entity.Durum = dto.Durum.Trim();

            try
            {
                _gorevRepository.Update(entity);
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException(
                    "Görev güncellenirken veritabanı hatası oluştu. Tablo yapısı, kolon adları, foreign key ve zorunlu alanları kontrol edin.",
                    ex);
            }
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await _gorevRepository.GetByIdAsync(id, cancellationToken);
            if (entity == null)
                throw new KeyNotFoundException("Görev kaydı bulunamadı.");

            try
            {
                _context.Gorevler.Remove(entity);
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("Görev kaydı silinirken veritabanı hatası oluştu.", ex);
            }
        }
    }
}