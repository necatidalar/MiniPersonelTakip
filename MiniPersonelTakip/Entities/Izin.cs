namespace MiniPersonelTakip.Entities
{
    public class Izin
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }

        public string IzinTuru { get; set; } = string.Empty;
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

        public int GunSayisi { get; set; }

        public string Durum { get; set; } = string.Empty;
        public string? Aciklama { get; set; }

        public DateTime OlusturmaTarihi { get; set; }

        public Personel? Personel { get; set; }
    }
}