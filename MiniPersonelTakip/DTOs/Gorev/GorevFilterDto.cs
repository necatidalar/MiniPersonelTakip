namespace MiniPersonelTakip.DTOs.Gorev
{
    public class GorevFilterDto
    {
        public string? AramaMetni { get; set; }
        public int? PersonelId { get; set; }
        public string? Oncelik { get; set; }
        public string? Durum { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
    }
}