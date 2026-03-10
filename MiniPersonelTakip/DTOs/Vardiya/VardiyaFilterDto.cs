namespace MiniPersonelTakip.DTOs.Vardiya
{
    public class VardiyaFilterDto
    {
        public int? PersonelId { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public string? VardiyaTipi { get; set; }
        public string? Durum { get; set; }
    }
}