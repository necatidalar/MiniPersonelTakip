using MiniPersonelTakip.Data;
using MiniPersonelTakip.DTOs.Izin;
using MiniPersonelTakip.Entities;
using MiniPersonelTakip.Helpers;
using MiniPersonelTakip.Repositories.Abstract;
using MiniPersonelTakip.Services.Abstract;

namespace MiniPersonelTakip.Services.Concrete
{
    public class IzinService : IIzinService
    {
        private readonly IIzinRepository _izinRepository;
        private readonly IPersonelRepository _personelRepository;
        private readonly AppDbContext _context;

        public IzinService(
            IIzinRepository izinRepository,
            IPersonelRepository personelRepository,
            AppDbContext context)
        {
            _izinRepository = izinRepository;
            _personelRepository = personelRepository;
            _context = context;
        }

        public async Task<List<IzinListDto>> GetFilteredAsync(IzinFilterDto filter, CancellationToken cancellationToken = default)
        {
            return await _izinRepository.GetFilteredAsync(filter, cancellationToken);
        }

        public async Task<IzinUpdateDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await _izinRepository.GetByIdAsync(id, cancellationToken);
            if (entity == null)
                return null;

            return new IzinUpdateDto
            {
                Id = entity.Id,
                PersonelId = entity.PersonelId,
                IzinTuru = entity.IzinTuru,
                BaslangicTarihi = entity.BaslangicTarihi,
                BitisTarihi = entity.BitisTarihi,
                Durum = entity.Durum,
                Aciklama = entity.Aciklama
            };
        }

        public async Task AddAsync(IzinCreateDto dto, CancellationToken cancellationToken = default)
        {
            IzinValidationHelper.ValidateCreate(dto);

            var personel = await _personelRepository.GetByIdAsync(dto.PersonelId, cancellationToken);
            if (personel == null)
                throw new KeyNotFoundException("Seçilen personel bulunamadı.");

            var cakismaVar = await _izinRepository.HasDateOverlapAsync(
                dto.PersonelId,
                dto.BaslangicTarihi,
                dto.BitisTarihi,
                null,
                cancellationToken);

            if (cakismaVar)
                throw new InvalidOperationException("Bu personel için seçilen tarih aralığında başka bir izin kaydı var.");

            var gunSayisi = HesaplaGunSayisi(dto.BaslangicTarihi, dto.BitisTarihi);

            await using var transaction = await _context.Database.BeginTransactionAsync(cancellationToken);

            try
            {
                if (BakiyeDusururMu(dto.IzinTuru, dto.Durum))
                {
                    if (personel.KalanYillikIzinGun < gunSayisi)
                        throw new InvalidOperationException("Personelin yeterli yıllık izin bakiyesi yok.");

                    personel.KalanYillikIzinGun -= gunSayisi;
                    _personelRepository.Update(personel);
                }

                var entity = new Izin
                {
                    PersonelId = dto.PersonelId,
                    IzinTuru = dto.IzinTuru.Trim(),
                    BaslangicTarihi = dto.BaslangicTarihi.Date,
                    BitisTarihi = dto.BitisTarihi.Date,
                    GunSayisi = gunSayisi,
                    Durum = dto.Durum.Trim(),
                    Aciklama = dto.Aciklama?.Trim(),
                    OlusturmaTarihi = DateTime.Now
                };

                await _izinRepository.AddAsync(entity, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
            }
            catch
            {
                await transaction.RollbackAsync(cancellationToken);
                throw;
            }
        }

        public async Task UpdateAsync(IzinUpdateDto dto, CancellationToken cancellationToken = default)
        {
            IzinValidationHelper.ValidateUpdate(dto);

            var entity = await _izinRepository.GetByIdAsync(dto.Id, cancellationToken);
            if (entity == null)
                throw new KeyNotFoundException("İzin kaydı bulunamadı.");

            var personel = await _personelRepository.GetByIdAsync(dto.PersonelId, cancellationToken);
            if (personel == null)
                throw new KeyNotFoundException("Seçilen personel bulunamadı.");

            var cakismaVar = await _izinRepository.HasDateOverlapAsync(
                dto.PersonelId,
                dto.BaslangicTarihi,
                dto.BitisTarihi,
                dto.Id,
                cancellationToken);

            if (cakismaVar)
                throw new InvalidOperationException("Bu personel için seçilen tarih aralığında başka bir izin kaydı var.");

            var yeniGunSayisi = HesaplaGunSayisi(dto.BaslangicTarihi, dto.BitisTarihi);
            var eskiGunSayisi = entity.GunSayisi;

            await using var transaction = await _context.Database.BeginTransactionAsync(cancellationToken);

            try
            {
                if (BakiyeDusururMu(entity.IzinTuru, entity.Durum))
                {
                    personel.KalanYillikIzinGun += eskiGunSayisi;
                }

                if (BakiyeDusururMu(dto.IzinTuru, dto.Durum))
                {
                    if (personel.KalanYillikIzinGun < yeniGunSayisi)
                        throw new InvalidOperationException("Personelin yeterli yıllık izin bakiyesi yok.");

                    personel.KalanYillikIzinGun -= yeniGunSayisi;
                }

                entity.PersonelId = dto.PersonelId;
                entity.IzinTuru = dto.IzinTuru.Trim();
                entity.BaslangicTarihi = dto.BaslangicTarihi.Date;
                entity.BitisTarihi = dto.BitisTarihi.Date;
                entity.GunSayisi = yeniGunSayisi;
                entity.Durum = dto.Durum.Trim();
                entity.Aciklama = dto.Aciklama?.Trim();

                _personelRepository.Update(personel);
                _izinRepository.Update(entity);

                await _context.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
            }
            catch
            {
                await transaction.RollbackAsync(cancellationToken);
                throw;
            }
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await _izinRepository.GetByIdAsync(id, cancellationToken);
            if (entity == null)
                throw new KeyNotFoundException("İzin kaydı bulunamadı.");

            var personel = await _personelRepository.GetByIdAsync(entity.PersonelId, cancellationToken);
            if (personel == null)
                throw new KeyNotFoundException("İzin kaydına ait personel bulunamadı.");

            await using var transaction = await _context.Database.BeginTransactionAsync(cancellationToken);

            try
            {
                if (BakiyeDusururMu(entity.IzinTuru, entity.Durum))
                {
                    personel.KalanYillikIzinGun += entity.GunSayisi;
                    _personelRepository.Update(personel);
                }

                _context.Izinler.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
            }
            catch
            {
                await transaction.RollbackAsync(cancellationToken);
                throw;
            }
        }

        private static int HesaplaGunSayisi(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            return (bitisTarihi.Date - baslangicTarihi.Date).Days + 1;
        }

        private static bool BakiyeDusururMu(string izinTuru, string durum)
        {
            return izinTuru == "Yıllık İzin" && durum == "Onaylandı";
        }
    }
}