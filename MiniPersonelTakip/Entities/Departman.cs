namespace MiniPersonelTakip.Entities
{
    public class Departman
    {
        public int Id { get; set; }
        public string DepartmanAdi { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public bool AktifMi {  get; set; }
        public ICollection<Personel> Personeller { get; set; } = new List<Personel>();
    }
}