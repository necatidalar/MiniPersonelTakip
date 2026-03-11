namespace MiniPersonelTakip.DTOs.Izin
{
    public class IzinFilterDto
    {
        public string? AramaMetni { get; set; }
        public int? PersonelId { get; set; }
        public string? IzinTuru { get; set; }
        public string? Durum { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
    }
}