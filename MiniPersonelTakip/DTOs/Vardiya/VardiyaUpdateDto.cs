namespace MiniPersonelTakip.DTOs.Vardiya
{
    public class VardiyaUpdateDto
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public DateTime Tarih { get; set; }
        public TimeSpan PlanlananGiris { get; set; }
        public TimeSpan PlanlananCikis { get; set; }
        public TimeSpan? GercekGiris { get; set; }
        public TimeSpan? GercekCikis { get; set; }
        public string VardiyaTipi { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
    }
}