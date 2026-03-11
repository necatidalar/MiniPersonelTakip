using Microsoft.Extensions.DependencyInjection;
using MiniPersonelTakip.DTOs.Common;
using MiniPersonelTakip.DTOs.Gorev;
using MiniPersonelTakip.Services.Abstract;

namespace MiniPersonelTakip.Forms
{
    public partial class frm_GorevYonetimi : Form
    {
        private readonly IGorevService _gorevService;
        private readonly ILookupService _lookupService;
        private readonly IServiceProvider _serviceProvider;

        private bool _filtreYukleniyor;
        private bool _listelemeDevamEdiyor;
        private CancellationTokenSource? _aramaCts;

        public frm_GorevYonetimi(
            IGorevService gorevService,
            ILookupService lookupService,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _gorevService = gorevService;
            _lookupService = lookupService;
            _serviceProvider = serviceProvider;

            Load += frm_GorevYonetimi_Load;
            btnAra.Click += async (s, e) => await ListeleAsync();
            btnYenile.Click += btnYenile_Click;
            btnEkle.Click += btnEkle_Click;
            btnDuzenle.Click += btnDuzenle_Click;
            btnSil.Click += btnSil_Click;
            dgvGorevler.CellDoubleClick += dgvGorevler_CellDoubleClick;

            txtArama.TextChanged += txtArama_TextChanged;
            cmbPersonelFiltre.SelectedIndexChanged += async (s, e) => { if (!_filtreYukleniyor) await ListeleAsync(); };
            cmbOncelikFiltre.SelectedIndexChanged += async (s, e) => { if (!_filtreYukleniyor) await ListeleAsync(); };
            cmbDurumFiltre.SelectedIndexChanged += async (s, e) => { if (!_filtreYukleniyor) await ListeleAsync(); };
            dtpBaslangic.ValueChanged += async (s, e) => { if (!_filtreYukleniyor) await ListeleAsync(); };
            dtpBitis.ValueChanged += async (s, e) => { if (!_filtreYukleniyor) await ListeleAsync(); };
        }

        private async void frm_GorevYonetimi_Load(object? sender, EventArgs e)
        {
            try
            {
                _filtreYukleniyor = true;

                dtpBaslangic.Value = DateTime.Today.AddMonths(-1);
                dtpBitis.Value = DateTime.Today.AddMonths(1);

                await FiltreleriYukleAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Filtreler yüklenirken hata oluştu.\n\nDetay: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _filtreYukleniyor = false;
            }

            await ListeleAsync();
        }

        private async Task FiltreleriYukleAsync()
        {
            var personeller = await _lookupService.GetAktifPersonellerAsync();
            personeller.Insert(0, new LookupDto { Id = 0, Ad = "Tümü" });

            cmbPersonelFiltre.DataSource = null;
            cmbPersonelFiltre.DisplayMember = nameof(LookupDto.Ad);
            cmbPersonelFiltre.ValueMember = nameof(LookupDto.Id);
            cmbPersonelFiltre.DataSource = personeller;
            cmbPersonelFiltre.SelectedIndex = 0;

            cmbOncelikFiltre.DataSource = new List<string>
            {
                "Tümü",
                "Düşük",
                "Orta",
                "Yüksek",
                "Kritik"
            };

            cmbDurumFiltre.DataSource = new List<string>
            {
                "Tümü",
                "Bekliyor",
                "Devam Ediyor",
                "Tamamlandı",
                "İptal Edildi"
            };
        }

        private async Task ListeleAsync()
        {
            if (_filtreYukleniyor || _listelemeDevamEdiyor)
                return;

            try
            {
                _listelemeDevamEdiyor = true;
                Cursor = Cursors.WaitCursor;

                var filter = new GorevFilterDto
                {
                    AramaMetni = txtArama.Text.Trim(),
                    PersonelId = SeciliLookupIdGetir(cmbPersonelFiltre),
                    Oncelik = SeciliMetinGetir(cmbOncelikFiltre),
                    Durum = SeciliMetinGetir(cmbDurumFiltre),
                    BaslangicTarihi = dtpBaslangic.Value.Date,
                    BitisTarihi = dtpBitis.Value.Date
                };

                var liste = await _gorevService.GetFilteredAsync(filter);

                dgvGorevler.AutoGenerateColumns = true;
                dgvGorevler.DataSource = null;
                dgvGorevler.DataSource = liste;

                GridAyarla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Görev listesi yüklenirken hata oluştu.\n\nDetay: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _listelemeDevamEdiyor = false;
                Cursor = Cursors.Default;
            }
        }

        private void GridAyarla()
        {
            if (dgvGorevler.Columns["Id"] != null)
                dgvGorevler.Columns["Id"].Visible = false;

            if (dgvGorevler.Columns["PersonelId"] != null)
                dgvGorevler.Columns["PersonelId"].Visible = false;

            if (dgvGorevler.Columns["PersonelKod"] != null)
                dgvGorevler.Columns["PersonelKod"].HeaderText = "Personel Kodu";

            if (dgvGorevler.Columns["PersonelAdSoyad"] != null)
                dgvGorevler.Columns["PersonelAdSoyad"].HeaderText = "Personel";

            if (dgvGorevler.Columns["GorevBasligi"] != null)
                dgvGorevler.Columns["GorevBasligi"].HeaderText = "Görev Başlığı";

            if (dgvGorevler.Columns["GorevDetayi"] != null)
                dgvGorevler.Columns["GorevDetayi"].HeaderText = "Görev Detayı";

            if (dgvGorevler.Columns["BaslangicTarihi"] != null)
            {
                dgvGorevler.Columns["BaslangicTarihi"].HeaderText = "Başlangıç";
                dgvGorevler.Columns["BaslangicTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }

            if (dgvGorevler.Columns["BitisTarihi"] != null)
            {
                dgvGorevler.Columns["BitisTarihi"].HeaderText = "Bitiş";
                dgvGorevler.Columns["BitisTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }

            if (dgvGorevler.Columns["Oncelik"] != null)
                dgvGorevler.Columns["Oncelik"].HeaderText = "Öncelik";

            if (dgvGorevler.Columns["Durum"] != null)
                dgvGorevler.Columns["Durum"].HeaderText = "Durum";

            if (dgvGorevler.Columns["OlusturmaTarihi"] != null)
            {
                dgvGorevler.Columns["OlusturmaTarihi"].HeaderText = "Oluşturma";
                dgvGorevler.Columns["OlusturmaTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
        }

        private int? SeciliLookupIdGetir(ComboBox comboBox)
        {
            if (comboBox.SelectedValue == null)
                return null;

            if (comboBox.SelectedValue is int intValue)
                return intValue > 0 ? intValue : null;

            return int.TryParse(comboBox.SelectedValue.ToString(), out int parsed)
                ? parsed > 0 ? parsed : null
                : null;
        }

        private string? SeciliMetinGetir(ComboBox comboBox)
        {
            var value = comboBox.SelectedItem?.ToString();
            return string.IsNullOrWhiteSpace(value) || value == "Tümü" ? null : value;
        }

        private int? SeciliGorevIdGetir()
        {
            if (dgvGorevler.CurrentRow == null)
                return null;

            var value = dgvGorevler.CurrentRow.Cells["Id"]?.Value;
            if (value == null)
                return null;

            return int.TryParse(value.ToString(), out int id) ? id : null;
        }

        private async void txtArama_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                _aramaCts?.Cancel();
                _aramaCts?.Dispose();
                _aramaCts = new CancellationTokenSource();

                await Task.Delay(300, _aramaCts.Token);
                await ListeleAsync();
            }
            catch (TaskCanceledException)
            {
            }
        }

        private async void btnYenile_Click(object? sender, EventArgs e)
        {
            try
            {
                btnYenile.Enabled = false;
                _filtreYukleniyor = true;

                txtArama.Clear();
                cmbPersonelFiltre.SelectedIndex = 0;
                cmbOncelikFiltre.SelectedIndex = 0;
                cmbDurumFiltre.SelectedIndex = 0;
                dtpBaslangic.Value = DateTime.Today.AddMonths(-1);
                dtpBitis.Value = DateTime.Today.AddMonths(1);
            }
            finally
            {
                _filtreYukleniyor = false;
                btnYenile.Enabled = true;
            }

            await ListeleAsync();
        }

        private async void btnEkle_Click(object? sender, EventArgs e)
        {
            try
            {
                using var scope = _serviceProvider.CreateScope();
                var form = scope.ServiceProvider.GetRequiredService<frm_GorevDuzenle>();
                form.GorevId = null;

                if (form.ShowDialog() == DialogResult.OK)
                    await ListeleAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Görev ekleme ekranı açılırken hata oluştu.\n\nDetay: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDuzenle_Click(object? sender, EventArgs e)
        {
            try
            {
                var seciliId = SeciliGorevIdGetir();
                if (!seciliId.HasValue)
                {
                    MessageBox.Show("Lütfen düzenlemek istediğiniz görev kaydını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var scope = _serviceProvider.CreateScope();
                var form = scope.ServiceProvider.GetRequiredService<frm_GorevDuzenle>();
                form.GorevId = seciliId.Value;

                if (form.ShowDialog() == DialogResult.OK)
                    await ListeleAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Görev düzenleme ekranı açılırken hata oluştu.\n\nDetay: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSil_Click(object? sender, EventArgs e)
        {
            try
            {
                var seciliId = SeciliGorevIdGetir();
                if (!seciliId.HasValue)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz görev kaydını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var onay = MessageBox.Show(
                    "Seçili görev kaydı silinecektir. Devam edilsin mi?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (onay != DialogResult.Yes)
                    return;

                await _gorevService.DeleteAsync(seciliId.Value);

                MessageBox.Show("Görev kaydı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await ListeleAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme işlemi sırasında hata oluştu.\n\nDetay: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvGorevler_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            await Task.Yield();
            btnDuzenle.PerformClick();
        }
    }
}