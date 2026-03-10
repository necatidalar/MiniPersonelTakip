namespace MiniPersonelTakip.DTOs.Personel
{
    public class PersonelListDto
    {
        public int Id { get; set; }
        public string PersonelKod { get; set; } = string.Empty;
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string AdSoyad => $"{Ad} {Soyad}";
        public int DepartmanId { get; set; }
        public string DepartmanAdi { get; set; } = string.Empty;
        public int PozisyonId { get; set; }
        public string PozisyonAdi { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public string Eposta { get; set; } = string.Empty;
        public DateTime IseGirisTarihi { get; set; }
        public bool AktifMi { get; set; }
    }
}