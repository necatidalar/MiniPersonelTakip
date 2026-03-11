using MiniPersonelTakip.DTOs.Izin;

namespace MiniPersonelTakip.Helpers
{
    public static class IzinValidationHelper
    {
        public static void ValidateCreate(IzinCreateDto dto)
        {
            if (dto.PersonelId <= 0)
                throw new ArgumentException("Personel seçimi zorunludur.");

            if (string.IsNullOrWhiteSpace(dto.IzinTuru))
                throw new ArgumentException("İzin türü zorunludur.");

            if (dto.BaslangicTarihi == default)
                throw new ArgumentException("Başlangıç tarihi zorunludur.");

            if (dto.BitisTarihi == default)
                throw new ArgumentException("Bitiş tarihi zorunludur.");

            if (dto.BitisTarihi.Date < dto.BaslangicTarihi.Date)
                throw new ArgumentException("Bitiş tarihi başlangıç tarihinden küçük olamaz.");

            if (string.IsNullOrWhiteSpace(dto.Durum))
                throw new ArgumentException("Durum zorunludur.");
        }

        public static void ValidateUpdate(IzinUpdateDto dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("Geçersiz izin kaydı.");

            if (dto.PersonelId <= 0)
                throw new ArgumentException("Personel seçimi zorunludur.");

            if (string.IsNullOrWhiteSpace(dto.IzinTuru))
                throw new ArgumentException("İzin türü zorunludur.");

            if (dto.BaslangicTarihi == default)
                throw new ArgumentException("Başlangıç tarihi zorunludur.");

            if (dto.BitisTarihi == default)
                throw new ArgumentException("Bitiş tarihi zorunludur.");

            if (dto.BitisTarihi.Date < dto.BaslangicTarihi.Date)
                throw new ArgumentException("Bitiş tarihi başlangıç tarihinden küçük olamaz.");

            if (string.IsNullOrWhiteSpace(dto.Durum))
                throw new ArgumentException("Durum zorunludur.");
        }
    }
}