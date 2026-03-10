using MiniPersonelTakip.DTOs.Vardiya;

namespace MiniPersonelTakip.Helpers
{
    public static class VardiyaValidationHelper
    {
        public static void ValidateCreate(VardiyaCreateDto dto)
        {
            if (dto.PersonelId <= 0)
                throw new ArgumentException("Personel seçimi zorunludur.");

            if (dto.Tarih == default)
                throw new ArgumentException("Tarih zorunludur.");

            if (dto.PlanlananCikis <= dto.PlanlananGiris)
                throw new ArgumentException("Planlanan çıkış saati, giriş saatinden büyük olmalıdır.");

            if (string.IsNullOrWhiteSpace(dto.VardiyaTipi))
                throw new ArgumentException("Vardiya tipi zorunludur.");

            if (string.IsNullOrWhiteSpace(dto.Durum))
                throw new ArgumentException("Durum zorunludur.");

            if (dto.GercekGiris.HasValue && dto.GercekCikis.HasValue && dto.GercekCikis <= dto.GercekGiris)
                throw new ArgumentException("Gerçek çıkış saati, gerçek giriş saatinden büyük olmalıdır.");
        }

        public static void ValidateUpdate(VardiyaUpdateDto dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("Geçersiz vardiya kaydı.");

            if (dto.PersonelId <= 0)
                throw new ArgumentException("Personel seçimi zorunludur.");

            if (dto.Tarih == default)
                throw new ArgumentException("Tarih zorunludur.");

            if (dto.PlanlananCikis <= dto.PlanlananGiris)
                throw new ArgumentException("Planlanan çıkış saati, giriş saatinden büyük olmalıdır.");

            if (string.IsNullOrWhiteSpace(dto.VardiyaTipi))
                throw new ArgumentException("Vardiya tipi zorunludur.");

            if (string.IsNullOrWhiteSpace(dto.Durum))
                throw new ArgumentException("Durum zorunludur.");

            if (dto.GercekGiris.HasValue && dto.GercekCikis.HasValue && dto.GercekCikis <= dto.GercekGiris)
                throw new ArgumentException("Gerçek çıkış saati, gerçek giriş saatinden büyük olmalıdır.");
        }
    }
}