namespace MiniPersonelTakip.Entities
{
    public class Gorev
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public int DepartmanId { get; set; }
        public string Baslik { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public string Oncelik { get; set; } = string.Empty;
        public string Durum { get; set; } = string.Empty;
        public DateTime BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public DateTime? TamamlanmaTarihi { get; set; }
        public int? TahminiSureSaat { get; set; }
        public int? GerceklesenSureSaat { get; set; }

        public Personel? Personel { get; set; }
        public Departman? Departman { get; set; }
    }
}