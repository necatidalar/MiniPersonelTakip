namespace MiniPersonelTakip.DTOs.Gorev
{
    public class GorevCreateDto
    {
        public int PersonelId { get; set; }
        public string GorevBasligi { get; set; } = string.Empty;
        public string GorevDetayi { get; set; } = string.Empty;
        public DateTime BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public string Oncelik { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
    }
}