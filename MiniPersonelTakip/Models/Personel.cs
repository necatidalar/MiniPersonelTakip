using System;

namespace MiniPersonelTakip.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public string Telefon { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public bool AktifMi { get; set; }
    }
}