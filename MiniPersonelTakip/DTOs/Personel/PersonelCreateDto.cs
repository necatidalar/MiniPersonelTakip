namespace MiniPersonelTakip.DTOs.Personel
{
    public class PersonelCreateDto
    {
        public string PersonelKod { get; set; } = string.Empty;
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public int DepartmanId { get; set; }
        public int PozisyonId { get; set; }
        public string Telefon { get; set; } = string.Empty;
        public string Eposta { get; set; } = string.Empty;
        public string Adres { get; set; } = string.Empty;
        public DateTime IseGirisTarihi { get; set; }
    }
}