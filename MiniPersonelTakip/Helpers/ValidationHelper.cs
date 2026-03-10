using MiniPersonelTakip.DTOs.Personel;

namespace MiniPersonelTakip.Helpers
{
    public static class ValidationHelper
    {
        public static void ValidatePersonelCreate(PersonelCreateDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.PersonelKod))
                throw new ArgumentException("Personel kodu zorunludur.");

            if (string.IsNullOrWhiteSpace(dto.Ad))
                throw new ArgumentException("Ad zorunludur.");

            if (string.IsNullOrWhiteSpace(dto.Soyad))
                throw new ArgumentException("Soyad zorunludur.");

            if (dto.IseGirisTarihi > DateTime.Now)
                throw new ArgumentException("İşe giriş tarihi gelecekte olamaz.");
        }

        public static void ValidatePersonelUpdate(PersonelUpdateDto dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("Geçersiz personel id.");

            if (string.IsNullOrWhiteSpace(dto.PersonelKod))
                throw new ArgumentException("Personel kodu zorunludur.");

            if (string.IsNullOrWhiteSpace(dto.Ad))
                throw new ArgumentException("Ad zorunludur.");

            if (string.IsNullOrWhiteSpace(dto.Soyad))
                throw new ArgumentException("Soyad zorunludur.");
        }
    }
}