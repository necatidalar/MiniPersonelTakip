namespace MiniPersonelTakip.DTOs.Vardiya
{
    public class VardiyaListDto
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string PersonelKod { get; set; } = string.Empty;
        public string PersonelAdSoyad { get; set; } = string.Empty;

        public DateTime Tarih { get; set; }

        public TimeSpan PlanlananGiris { get; set; }
        public TimeSpan PlanlananCikis { get; set; }

        public TimeSpan? GercekGiris { get; set; }
        public TimeSpan? GercekCikis { get; set; }

        public string VardiyaTipi { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
        public string? Aciklama { get; set; }

        public double PlanlananSureSaat { get; set; }
        public double GerceklesenSureSaat { get; set; }
        public double FarkSaat { get; set; }
    }
}