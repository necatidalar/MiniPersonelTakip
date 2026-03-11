using MiniPersonelTakip.DTOs.Gorev;

namespace MiniPersonelTakip.Helpers
{
    public static class GorevValidationHelper
    {
        public static void ValidateCreate(GorevCreateDto dto)
        {
            if (dto.PersonelId <= 0)
                throw new ArgumentException("Personel seçimi zorunludur.");

            if (string.IsNullOrWhiteSpace(dto.GorevBasligi))
                throw new ArgumentException("Görev başlığı zorunludur.");

            if (dto.GorevBasligi.Trim().Length > 150)
                throw new ArgumentException("Görev başlığı en fazla 150 karakter olabilir.");

            if (string.IsNullOrWhiteSpace(dto.GorevDetayi))
                throw new ArgumentException("Görev detayı zorunludur.");

            if (dto.GorevDetayi.Trim().Length > 1000)
                throw new ArgumentException("Görev detayı en fazla 1000 karakter olabilir.");

            if (dto.BaslangicTarihi == default)
                throw new ArgumentException("Başlangıç tarihi zorunludur.");

            if (dto.BitisTarihi.HasValue && dto.BitisTarihi.Value.Date < dto.BaslangicTarihi.Date)
                throw new ArgumentException("Bitiş tarihi başlangıç tarihinden küçük olamaz.");

            if (string.IsNullOrWhiteSpace(dto.Oncelik))
                throw new ArgumentException("Öncelik seçimi zorunludur.");

            if (string.IsNullOrWhiteSpace(dto.Durum))
                throw new ArgumentException("Durum seçimi zorunludur.");
        }

        public static void ValidateUpdate(GorevUpdateDto dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("Geçersiz görev kaydı.");

            if (dto.PersonelId <= 0)
                throw new ArgumentException("Personel seçimi zorunludur.");

            if (string.IsNullOrWhiteSpace(dto.GorevBasligi))
                throw new ArgumentException("Görev başlığı zorunludur.");

            if (dto.GorevBasligi.Trim().Length > 150)
                throw new ArgumentException("Görev başlığı en fazla 150 karakter olabilir.");

            if (string.IsNullOrWhiteSpace(dto.GorevDetayi))
                throw new ArgumentException("Görev detayı zorunludur.");

            if (dto.GorevDetayi.Trim().Length > 1000)
                throw new ArgumentException("Görev detayı en fazla 1000 karakter olabilir.");

            if (dto.BaslangicTarihi == default)
                throw new ArgumentException("Başlangıç tarihi zorunludur.");

            if (dto.BitisTarihi.HasValue && dto.BitisTarihi.Value.Date < dto.BaslangicTarihi.Date)
                throw new ArgumentException("Bitiş tarihi başlangıç tarihinden küçük olamaz.");

            if (string.IsNullOrWhiteSpace(dto.Oncelik))
                throw new ArgumentException("Öncelik seçimi zorunludur.");

            if (string.IsNullOrWhiteSpace(dto.Durum))
                throw new ArgumentException("Durum seçimi zorunludur.");
        }
    }
}