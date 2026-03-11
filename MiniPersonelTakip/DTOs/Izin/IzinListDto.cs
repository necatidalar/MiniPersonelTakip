namespace MiniPersonelTakip.DTOs.Izin
{
    public class IzinListDto
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string PersonelKod { get; set; } = string.Empty;
        public string PersonelAdSoyad { get; set; } = string.Empty;
        public string IzinTuru { get; set; } = string.Empty;
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int GunSayisi { get; set; }
        public string Durum { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public int KalanYillikIzinGun { get; set; }
    }
}