using Microsoft.Extensions.DependencyInjection;
using MiniPersonelTakip.DTOs.Common;
using MiniPersonelTakip.DTOs.Izin;
using MiniPersonelTakip.Helpers;
using MiniPersonelTakip.Services.Abstract;

namespace MiniPersonelTakip.Forms
{
    public partial class frm_IzinYonetimi : Form
    {
        private readonly IIzinService _izinService;
        private readonly ILookupService _lookupService;
        private readonly IServiceProvider _serviceProvider;

        private bool _filtreYukleniyor;
        private bool _listelemeDevamEdiyor;
        private CancellationTokenSource? _aramaCts;

        public frm_IzinYonetimi(
            IIzinService izinService,
            ILookupService lookupService,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _izinService = izinService;
            _lookupService = lookupService;
            _serviceProvider = serviceProvider;

            Load += frm_IzinYonetimi_Load;
            btnAra.Click += async (s, e) => await ListeleAsync();
            btnYenile.Click += btnYenile_Click;
            btnEkle.Click += btnEkle_Click;
            btnDuzenle.Click += btnDuzenle_Click;
            btnSil.Click += btnSil_Click;
            dgvIzinler.CellDoubleClick += dgvIzinler_CellDoubleClick;

            txtArama.TextChanged += txtArama_TextChanged;
            cmbPersonelFiltre.SelectedIndexChanged += async (s, e) =>
            {
                if (!_filtreYukleniyor)
                {
                    await ListeleAsync();
                }
            };
            cmbIzinTuruFiltre.SelectedIndexChanged += async (s, e) =>
            {
                if (!_filtreYukleniyor)
                {
                    await ListeleAsync();
                }
            };
            cmbDurumFiltre.SelectedIndexChanged += async (s, e) =>
            {
                if (!_filtreYukleniyor)
                {
                    await ListeleAsync();
                }
            };
            dtpBaslangic.ValueChanged += async (s, e) =>
            {
                if (!_filtreYukleniyor)
                {
                    await ListeleAsync();
                }
            };
            dtpBitis.ValueChanged += async (s, e) =>
            {
                if (!_filtreYukleniyor)
                {
                    await ListeleAsync();
                }
            };
        }

        private async void frm_IzinYonetimi_Load(object? sender, EventArgs e)
        {
            UiTheme.StylePage(this);
            UiTheme.StyleSurface(pnlTop);
            UiTheme.StyleGrid(dgvIzinler);

            UiTheme.StyleTextBox(txtArama);
            UiTheme.StyleComboBox(cmbPersonelFiltre);
            UiTheme.StyleComboBox(cmbIzinTuruFiltre);
            UiTheme.StyleComboBox(cmbDurumFiltre);

            UiTheme.StylePrimaryButton(btnAra);
            UiTheme.StyleNeutralButton(btnYenile);
            UiTheme.StyleSuccessButton(btnEkle);
            UiTheme.StyleWarningButton(btnDuzenle);
            UiTheme.StyleDangerButton(btnSil);
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

            cmbIzinTuruFiltre.DataSource = new List<string>
            {
                "Tümü",
                "Yıllık İzin",
                "Hastalık İzni",
                "Mazeret İzni",
                "Ücretsiz İzin"
            };

            cmbDurumFiltre.DataSource = new List<string>
            {
                "Tümü",
                "Beklemede",
                "Onaylandı",
                "Reddedildi",
                "İptal Edildi"
            };
        }

        private async Task ListeleAsync()
        {
            if (_filtreYukleniyor || _listelemeDevamEdiyor)
            {
                return;
            }

            try
            {
                _listelemeDevamEdiyor = true;
                Cursor = Cursors.WaitCursor;

                var filtre = new IzinFilterDto
                {
                    AramaMetni = txtArama.Text.Trim(),
                    PersonelId = SeciliLookupIdGetir(cmbPersonelFiltre),
                    IzinTuru = SeciliMetinGetir(cmbIzinTuruFiltre),
                    Durum = SeciliMetinGetir(cmbDurumFiltre),
                    BaslangicTarihi = dtpBaslangic.Value.Date,
                    BitisTarihi = dtpBitis.Value.Date
                };

                var liste = await _izinService.GetFilteredAsync(filtre);

                dgvIzinler.AutoGenerateColumns = true;
                dgvIzinler.DataSource = null;
                dgvIzinler.DataSource = liste;

                GridAyarla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İzin listesi yüklenirken hata oluştu.\n\nDetay: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _listelemeDevamEdiyor = false;
                Cursor = Cursors.Default;
            }
        }

        private void GridAyarla()
        {
            if (dgvIzinler.Columns["Id"] != null)
                dgvIzinler.Columns["Id"].Visible = false;

            if (dgvIzinler.Columns["PersonelId"] != null)
                dgvIzinler.Columns["PersonelId"].Visible = false;

            if (dgvIzinler.Columns["PersonelKod"] != null)
                dgvIzinler.Columns["PersonelKod"].HeaderText = "Personel Kodu";

            if (dgvIzinler.Columns["PersonelAdSoyad"] != null)
                dgvIzinler.Columns["PersonelAdSoyad"].HeaderText = "Personel";

            if (dgvIzinler.Columns["IzinTuru"] != null)
                dgvIzinler.Columns["IzinTuru"].HeaderText = "İzin Türü";

            if (dgvIzinler.Columns["BaslangicTarihi"] != null)
            {
                dgvIzinler.Columns["BaslangicTarihi"].HeaderText = "Başlangıç";
                dgvIzinler.Columns["BaslangicTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }

            if (dgvIzinler.Columns["BitisTarihi"] != null)
            {
                dgvIzinler.Columns["BitisTarihi"].HeaderText = "Bitiş";
                dgvIzinler.Columns["BitisTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }

            if (dgvIzinler.Columns["GunSayisi"] != null)
                dgvIzinler.Columns["GunSayisi"].HeaderText = "Gün";

            if (dgvIzinler.Columns["Durum"] != null)
                dgvIzinler.Columns["Durum"].HeaderText = "Durum";

            if (dgvIzinler.Columns["Aciklama"] != null)
                dgvIzinler.Columns["Aciklama"].HeaderText = "Açıklama";

            if (dgvIzinler.Columns["KalanYillikIzinGun"] != null)
                dgvIzinler.Columns["KalanYillikIzinGun"].HeaderText = "Kalan Yıllık İzin";
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

        private int? SeciliIzinIdGetir()
        {
            if (dgvIzinler.CurrentRow == null)
                return null;

            var value = dgvIzinler.CurrentRow.Cells["Id"]?.Value;
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
                cmbIzinTuruFiltre.SelectedIndex = 0;
                cmbDurumFiltre.SelectedIndex = 0;
                dtpBaslangic.Value = DateTime.Today.AddMonths(-1);
                dtpBitis.Value = DateTime.Today.AddMonths(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Filtre sıfırlanırken hata oluştu.\n\nDetay: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var form = scope.ServiceProvider.GetRequiredService<frm_IzinDuzenle>();
                form.IzinId = null;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    await ListeleAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İzin ekleme ekranı açılırken hata oluştu.\n\nDetay: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDuzenle_Click(object? sender, EventArgs e)
        {
            try
            {
                var seciliId = SeciliIzinIdGetir();
                if (!seciliId.HasValue)
                {
                    MessageBox.Show("Lütfen düzenlemek istediğiniz izin kaydını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var scope = _serviceProvider.CreateScope();
                var form = scope.ServiceProvider.GetRequiredService<frm_IzinDuzenle>();
                form.IzinId = seciliId.Value;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    await ListeleAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İzin düzenleme ekranı açılırken hata oluştu.\n\nDetay: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSil_Click(object? sender, EventArgs e)
        {
            try
            {
                var seciliId = SeciliIzinIdGetir();
                if (!seciliId.HasValue)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz izin kaydını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var onay = MessageBox.Show(
                    "Seçili izin kaydı silinecektir. Devam edilsin mi?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (onay != DialogResult.Yes)
                {
                    return;
                }

                await _izinService.DeleteAsync(seciliId.Value);

                MessageBox.Show("İzin kaydı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await ListeleAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme işlemi sırasında hata oluştu.\n\nDetay: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvIzinler_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            await Task.Yield();
            btnDuzenle.PerformClick();
        }
    }
}