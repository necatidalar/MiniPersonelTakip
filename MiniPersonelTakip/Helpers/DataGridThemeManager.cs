using System.Drawing;
using System.Windows.Forms;

namespace MiniPersonelTakip.Helpers // Projendeki klasör yapına göre değiştirebilirsin
{
    public static class DataGridThemeManager
    {
        public static void Apply(DataGridView grid)
        {
            // Temel Davranış Ayarları
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.MultiSelect = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowHeadersVisible = false; // Sol taraftaki ok işaretini gizler, modern görünüm sağlar
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ana Arka Plan ve Kenarlıklar (Dark Mode Zemin)
            grid.BackgroundColor = Color.FromArgb(20, 22, 27); // Panellerin arka planıyla uyumlu
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Sadece yatay çizgi, modern web tablosu hissiyatı
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.EnableHeadersVisualStyles = false; // Windows'un varsayılan gri başlıklarını ezer
            grid.GridColor = Color.FromArgb(45, 48, 55); // Satır arası hafif gri çizgiler

            // BAŞLIKLAR (Header)
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            grid.ColumnHeadersHeight = 40; // Tıklama alanı daha rahat olsun diye biraz yükseltildi
            grid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(35, 38, 45), // Zemin renginden bir tık daha açık koyu gri
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                SelectionBackColor = Color.FromArgb(35, 38, 45) // Başlık seçildiğinde rengi değişmesin
            };

            // SATIRLAR VE HÜCRELER (Cells)
            grid.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(28, 30, 38), // Satır arka planı
                ForeColor = Color.FromArgb(220, 230, 242), // Metin rengi (Göz yormayan kırık beyaz)
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = Color.FromArgb(52, 152, 219), // Seçili satır için tatlı bir mavi vurgu
                SelectionForeColor = Color.White,
                Padding = new Padding(5, 0, 0, 0) // Metinleri hücre kenarından biraz ayırmak için
            };

            grid.RowTemplate.Height = 35; // Satır yüksekliği (daha ferah bir görünüm)
        }
    }
}