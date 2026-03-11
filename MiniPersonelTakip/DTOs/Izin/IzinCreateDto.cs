namespace MiniPersonelTakip.DTOs.Izin
{
    public class IzinCreateDto
    {
        public int PersonelId { get; set; }
        public string IzinTuru { get; set; } = string.Empty;
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string Durum { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
    }
}