using Microsoft.Extensions.DependencyInjection;

namespace MiniPersonelTakip
{
    public partial class frmMain : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public frmMain(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnPersonelYonetimi_Click(object sender, EventArgs e)
        {
            try
            {
                using var scope = _serviceProvider.CreateScope();
                var form = scope.ServiceProvider.GetRequiredService<frm_MiniPersonelTakip>();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Personel yönetimi ekranı açılırken hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnVardiyaYonetimi_Click(object sender, EventArgs e)
        {
            try
            {
                using var scope = _serviceProvider.CreateScope();
                var form = scope.ServiceProvider.GetRequiredService<frm_VardiyaYonetimi>();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Vardiya yönetimi ekranı açılırken hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}