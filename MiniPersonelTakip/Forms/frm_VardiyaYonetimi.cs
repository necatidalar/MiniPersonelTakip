using Microsoft.Extensions.DependencyInjection;
using MiniPersonelTakip.DTOs.Common;
using MiniPersonelTakip.DTOs.Vardiya;
using MiniPersonelTakip.Services.Abstract;

namespace MiniPersonelTakip
{
    public partial class frm_VardiyaYonetimi : Form
    {
        private readonly IVardiyaService _vardiyaService;
        private readonly ILookupService _lookupService;
        private readonly IServiceProvider _serviceProvider;

        private bool _filtreYukleniyor = false;
        private bool _listelemeDevamEdiyor = false;

        public frm_VardiyaYonetimi(
            IVardiyaService vardiyaService,
            ILookupService lookupService,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _vardiyaService = vardiyaService;
            _lookupService = lookupService;
            _serviceProvider = serviceProvider;
        }

        private async void frm_VardiyaYonetimi_Load(object sender, EventArgs e)
        {
            try
            {
                _filtreYukleniyor = true;

                dtpBaslangicTarihi.Value = DateTime.Today.AddDays(-7);
                dtpBitisTarihi.Value = DateTime.Today;

                await FiltreleriYukleAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Form yüklenirken hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                _filtreYukleniyor = false;
            }

            await ListeleAsync();
        }

        private async Task FiltreleriYukleAsync()
        {
            try
            {
                var personeller = await _lookupService.GetAktifPersonellerAsync();
                personeller.Insert(0, new LookupDto { Id = 0, Ad = "Tümü" });

                cmbPersonelFiltre.DataSource = null;
                cmbPersonelFiltre.DisplayMember = nameof(LookupDto.Ad);
                cmbPersonelFiltre.ValueMember = nameof(LookupDto.Id);
                cmbPersonelFiltre.DataSource = personeller;
                cmbPersonelFiltre.SelectedIndex = 0;

                cmbVardiyaTipiFiltre.DataSource = null;
                cmbVardiyaTipiFiltre.DataSource = new List<string>
                {
                    "Tümü",
                    "Sabah",
                    "Aksam",
                    "Gece",
                    "Ofis",
                    "Hafta Sonu"
                };
                cmbVardiyaTipiFiltre.SelectedIndex = 0;

                cmbDurumFiltre.DataSource = null;
                cmbDurumFiltre.DataSource = new List<string>
                {
                    "Tümü",
                    "Tamamlandi",
                    "Eksik",
                    "Devam Ediyor",
                    "Izinli"
                };
                cmbDurumFiltre.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Filtreler yüklenirken hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int? SeciliLookupIdGetir(ComboBox comboBox)
        {
            if (comboBox.DataSource == null)
                return null;

            if (comboBox.SelectedValue == null)
                return null;

            if (comboBox.SelectedValue is int intValue)
                return intValue > 0 ? intValue : null;

            if (comboBox.SelectedValue is LookupDto lookupDto)
                return lookupDto.Id > 0 ? lookupDto.Id : null;

            if (int.TryParse(comboBox.SelectedValue.ToString(), out int parsedValue))
                return parsedValue > 0 ? parsedValue : null;

            return null;
        }

        private string? SeciliMetinGetir(ComboBox comboBox)
        {
            var value = comboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(value) || value == "Tümü")
                return null;

            return value;
        }

        private async Task ListeleAsync()
        {
            if (_filtreYukleniyor)
                return;

            if (_listelemeDevamEdiyor)
                return;

            try
            {
                _listelemeDevamEdiyor = true;
                Cursor = Cursors.WaitCursor;

                var filtre = new VardiyaFilterDto
                {
                    PersonelId = SeciliLookupIdGetir(cmbPersonelFiltre),
                    BaslangicTarihi = dtpBaslangicTarihi.Value.Date,
                    BitisTarihi = dtpBitisTarihi.Value.Date,
                    VardiyaTipi = SeciliMetinGetir(cmbVardiyaTipiFiltre),
                    Durum = SeciliMetinGetir(cmbDurumFiltre)
                };

                var liste = await _vardiyaService.GetFilteredAsync(filtre);

                dgvVardiyalar.AutoGenerateColumns = true;
                dgvVardiyalar.DataSource = null;
                dgvVardiyalar.DataSource = liste;

                GridAyarla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Vardiya listesi yüklenirken hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                _listelemeDevamEdiyor = false;
                Cursor = Cursors.Default;
            }
        }

        private void GridAyarla()
        {
            if (dgvVardiyalar.Columns["Id"] != null)
                dgvVardiyalar.Columns["Id"].Visible = false;

            if (dgvVardiyalar.Columns["PersonelId"] != null)
                dgvVardiyalar.Columns["PersonelId"].Visible = false;

            if (dgvVardiyalar.Columns["PersonelKod"] != null)
                dgvVardiyalar.Columns["PersonelKod"].HeaderText = "Personel Kodu";

            if (dgvVardiyalar.Columns["PersonelAdSoyad"] != null)
                dgvVardiyalar.Columns["PersonelAdSoyad"].HeaderText = "Personel";

            if (dgvVardiyalar.Columns["Tarih"] != null)
            {
                dgvVardiyalar.Columns["Tarih"].HeaderText = "Tarih";
                dgvVardiyalar.Columns["Tarih"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }

            if (dgvVardiyalar.Columns["PlanlananGiris"] != null)
            {
                dgvVardiyalar.Columns["PlanlananGiris"].HeaderText = "Planlanan Giriş";
                dgvVardiyalar.Columns["PlanlananGiris"].DefaultCellStyle.Format = @"hh\:mm";
            }

            if (dgvVardiyalar.Columns["PlanlananCikis"] != null)
            {
                dgvVardiyalar.Columns["PlanlananCikis"].HeaderText = "Planlanan Çıkış";
                dgvVardiyalar.Columns["PlanlananCikis"].DefaultCellStyle.Format = @"hh\:mm";
            }

            if (dgvVardiyalar.Columns["GercekGiris"] != null)
            {
                dgvVardiyalar.Columns["GercekGiris"].HeaderText = "Gerçek Giriş";
                dgvVardiyalar.Columns["GercekGiris"].DefaultCellStyle.Format = @"hh\:mm";
            }

            if (dgvVardiyalar.Columns["GercekCikis"] != null)
            {
                dgvVardiyalar.Columns["GercekCikis"].HeaderText = "Gerçek Çıkış";
                dgvVardiyalar.Columns["GercekCikis"].DefaultCellStyle.Format = @"hh\:mm";
            }

            if (dgvVardiyalar.Columns["VardiyaTipi"] != null)
                dgvVardiyalar.Columns["VardiyaTipi"].HeaderText = "Vardiya Tipi";

            if (dgvVardiyalar.Columns["Durum"] != null)
                dgvVardiyalar.Columns["Durum"].HeaderText = "Durum";

            if (dgvVardiyalar.Columns["Aciklama"] != null)
                dgvVardiyalar.Columns["Aciklama"].HeaderText = "Açıklama";

            if (dgvVardiyalar.Columns["PlanlananSureSaat"] != null)
            {
                dgvVardiyalar.Columns["PlanlananSureSaat"].HeaderText = "Planlanan Saat";
                dgvVardiyalar.Columns["PlanlananSureSaat"].DefaultCellStyle.Format = "N2";
            }

            if (dgvVardiyalar.Columns["GerceklesenSureSaat"] != null)
            {
                dgvVardiyalar.Columns["GerceklesenSureSaat"].HeaderText = "Gerçekleşen Saat";
                dgvVardiyalar.Columns["GerceklesenSureSaat"].DefaultCellStyle.Format = "N2";
            }

            if (dgvVardiyalar.Columns["FarkSaat"] != null)
            {
                dgvVardiyalar.Columns["FarkSaat"].HeaderText = "Fark Saat";
                dgvVardiyalar.Columns["FarkSaat"].DefaultCellStyle.Format = "N2";
            }

            dgvVardiyalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVardiyalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVardiyalar.MultiSelect = false;
            dgvVardiyalar.ReadOnly = true;
            dgvVardiyalar.AllowUserToAddRows = false;
            dgvVardiyalar.AllowUserToDeleteRows = false;
        }

        private int? SeciliVardiyaIdGetir()
        {
            if (dgvVardiyalar.CurrentRow == null)
                return null;

            var cellValue = dgvVardiyalar.CurrentRow.Cells["Id"]?.Value;

            if (cellValue == null)
                return null;

            if (int.TryParse(cellValue.ToString(), out int id))
                return id;

            return null;
        }

        private async void btnAra_Click(object sender, EventArgs e)
        {
            await ListeleAsync();
        }

        private async void cmbPersonelFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_filtreYukleniyor)
                return;

            await ListeleAsync();
        }

        private async void cmbVardiyaTipiFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_filtreYukleniyor)
                return;

            await ListeleAsync();
        }

        private async void cmbDurumFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_filtreYukleniyor)
                return;

            await ListeleAsync();
        }

        private async void dtpBaslangicTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (_filtreYukleniyor)
                return;

            await ListeleAsync();
        }

        private async void dtpBitisTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (_filtreYukleniyor)
                return;

            await ListeleAsync();
        }

        private async void btnYenile_Click(object sender, EventArgs e)
        {
            try
            {
                btnYenile.Enabled = false;
                _filtreYukleniyor = true;

                cmbPersonelFiltre.SelectedIndex = 0;
                cmbVardiyaTipiFiltre.SelectedIndex = 0;
                cmbDurumFiltre.SelectedIndex = 0;
                dtpBaslangicTarihi.Value = DateTime.Today.AddDays(-7);
                dtpBitisTarihi.Value = DateTime.Today;
            }
            finally
            {
                _filtreYukleniyor = false;
                btnYenile.Enabled = true;
            }

            await ListeleAsync();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using var scope = _serviceProvider.CreateScope();
                var form = scope.ServiceProvider.GetRequiredService<frm_VardiyaDuzenle>();

                form.VardiyaId = null;

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                    await ListeleAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Vardiya ekleme ekranı açılırken hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                var seciliId = SeciliVardiyaIdGetir();

                if (!seciliId.HasValue)
                {
                    MessageBox.Show(
                        "Lütfen düzenlemek istediğiniz vardiya kaydını seçin.",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                using var scope = _serviceProvider.CreateScope();
                var form = scope.ServiceProvider.GetRequiredService<frm_VardiyaDuzenle>();

                form.VardiyaId = seciliId.Value;

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                    await ListeleAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Vardiya düzenleme ekranı açılırken hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var seciliId = SeciliVardiyaIdGetir();

                if (!seciliId.HasValue)
                {
                    MessageBox.Show(
                        "Lütfen silmek istediğiniz vardiya kaydını seçin.",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var onay = MessageBox.Show(
                    "Seçili vardiya kaydı silinecektir. Devam edilsin mi?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (onay != DialogResult.Yes)
                    return;

                await _vardiyaService.DeleteAsync(seciliId.Value);

                MessageBox.Show(
                    "Vardiya kaydı başarıyla silindi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await ListeleAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Silme işlemi sırasında hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void dgvVardiyalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            await Task.Yield();
            btnDuzenle.PerformClick();
        }
    }
}