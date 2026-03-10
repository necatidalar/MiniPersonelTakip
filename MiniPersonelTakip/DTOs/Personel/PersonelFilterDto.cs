namespace MiniPersonelTakip.DTOs.Personel
{
    public class PersonelFilterDto
    {
        public string? AramaMetni { get; set; }
        public int? DepartmanId { get; set; }
        public int? PozisyonId { get; set; }
        public bool SadeceAktifler { get; set; } = true;
    }
}