namespace MiniPersonelTakip.Entities
{
    public class Pozisyon
    {
        public int Id { get; set; }
        public string PozisyonAdi { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public bool AktifMi { get; set; } = true;

        public ICollection<Personel> Personeller { get; set; } = new List<Personel>();
    }
}