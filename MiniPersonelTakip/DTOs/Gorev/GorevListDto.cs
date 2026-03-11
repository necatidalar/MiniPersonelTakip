namespace MiniPersonelTakip.DTOs.Gorev
{
    public class GorevListDto
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string PersonelKod { get; set; } = string.Empty;
        public string PersonelAdSoyad { get; set; } = string.Empty;
        public string GorevBasligi { get; set; } = string.Empty;
        public string GorevDetayi { get; set; } = string.Empty;
        public DateTime BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public string Oncelik { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
        public DateTime OlusturmaTarihi { get; set; }
    }
}