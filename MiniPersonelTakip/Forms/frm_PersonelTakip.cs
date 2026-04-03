using Microsoft.Extensions.DependencyInjection;
using MiniPersonelTakip.DTOs.Common;
using MiniPersonelTakip.DTOs.Personel;
using MiniPersonelTakip.Helpers;
using MiniPersonelTakip.Services.Abstract;

namespace MiniPersonelTakip
{
    public partial class frm_PersonelTakip : Form
    {
        private readonly IPersonelService _personelService;
        private readonly ILookupService _lookupService;
        private readonly IServiceProvider _serviceProvider;

        private bool _filtreYukleniyor = false;
        private bool _listelemeDevamEdiyor = false;
        private CancellationTokenSource? _aramaCts;

        public frm_PersonelTakip(
            IPersonelService personelService,
            ILookupService lookupService,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _personelService = personelService;
            _lookupService = lookupService;
            _serviceProvider = serviceProvider;
        }

        private async void frm_MiniPersonelTakip_Load(object sender, EventArgs e)
        {
            UiTheme.StylePage(this);
            UiTheme.StyleFilterPanel(pnlTop);
            UiTheme.StyleActionPanel(pnlRight);
            UiTheme.StyleGrid(dgvPersoneller);

            UiTheme.StyleTextBox(txtArama);
            UiTheme.StyleComboBox(cmbDepartmanFiltre);
            UiTheme.StyleComboBox(cmbPozisyonFiltre);
            UiTheme.StyleCheckBox(chkSadeceAktifler);

            UiTheme.StylePrimaryButton(btnAra);
            UiTheme.StyleSuccessButton(btnEkle);
            UiTheme.StyleWarningButton(btnDuzenle);
            UiTheme.StyleDangerButton(btnSil);
            UiTheme.StyleNeutralButton(btnYenile);

            ConfigureResponsiveLayout();

            await FiltreleriYukleAsync();
            await ListeleAsync();
        }

        private void ConfigureResponsiveLayout()
        {
            txtArama.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnAra.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            chkSadeceAktifler.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblDepartmanFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbDepartmanFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPozisyonFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPozisyonFiltre.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnEkle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDuzenle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnYenile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        private async Task FiltreleriYukleAsync()
        {
            try
            {
                _filtreYukleniyor = true;

                var departmanlar = await _lookupService.GetAktifDepartmanlarAsync();
                var pozisyonlar = await _lookupService.GetAktifPozisyonlarAsync();

                departmanlar.Insert(0, new LookupDto { Id = 0, Ad = "Tümü" });
                pozisyonlar.Insert(0, new LookupDto { Id = 0, Ad = "Tümü" });

                cmbDepartmanFiltre.DataSource = null;
                cmbDepartmanFiltre.DisplayMember = nameof(LookupDto.Ad);
                cmbDepartmanFiltre.ValueMember = nameof(LookupDto.Id);
                cmbDepartmanFiltre.DataSource = departmanlar;
                cmbDepartmanFiltre.SelectedIndex = 0;

                cmbPozisyonFiltre.DataSource = null;
                cmbPozisyonFiltre.DisplayMember = nameof(LookupDto.Ad);
                cmbPozisyonFiltre.ValueMember = nameof(LookupDto.Id);
                cmbPozisyonFiltre.DataSource = pozisyonlar;
                cmbPozisyonFiltre.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Filtre listeleri yüklenirken hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                _filtreYukleniyor = false;
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

                var filtre = new PersonelFilterDto
                {
                    AramaMetni = txtArama.Text.Trim(),
                    SadeceAktifler = chkSadeceAktifler.Checked,
                    DepartmanId = SeciliLookupIdGetir(cmbDepartmanFiltre),
                    PozisyonId = SeciliLookupIdGetir(cmbPozisyonFiltre)
                };

                var liste = await _personelService.GetFilteredAsync(filtre);

                dgvPersoneller.AutoGenerateColumns = true;
                dgvPersoneller.DataSource = null;
                dgvPersoneller.DataSource = liste;

                GridAyarla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Personel listesi yüklenirken hata oluştu.\n\nDetay: {ex.Message}",
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
            if (dgvPersoneller.Columns["Id"] != null)
                dgvPersoneller.Columns["Id"].Visible = false;

            if (dgvPersoneller.Columns["DepartmanId"] != null)
                dgvPersoneller.Columns["DepartmanId"].Visible = false;

            if (dgvPersoneller.Columns["PozisyonId"] != null)
                dgvPersoneller.Columns["PozisyonId"].Visible = false;

            if (dgvPersoneller.Columns["Ad"] != null)
                dgvPersoneller.Columns["Ad"].Visible = false;

            if (dgvPersoneller.Columns["Soyad"] != null)
                dgvPersoneller.Columns["Soyad"].Visible = false;

            if (dgvPersoneller.Columns["PersonelKod"] != null)
                dgvPersoneller.Columns["PersonelKod"].HeaderText = "Personel Kodu";

            if (dgvPersoneller.Columns["AdSoyad"] != null)
                dgvPersoneller.Columns["AdSoyad"].HeaderText = "Ad Soyad";

            if (dgvPersoneller.Columns["DepartmanAdi"] != null)
                dgvPersoneller.Columns["DepartmanAdi"].HeaderText = "Departman";

            if (dgvPersoneller.Columns["PozisyonAdi"] != null)
                dgvPersoneller.Columns["PozisyonAdi"].HeaderText = "Pozisyon";

            if (dgvPersoneller.Columns["Telefon"] != null)
                dgvPersoneller.Columns["Telefon"].HeaderText = "Telefon";

            if (dgvPersoneller.Columns["Eposta"] != null)
                dgvPersoneller.Columns["Eposta"].HeaderText = "E-Posta";

            if (dgvPersoneller.Columns["IseGirisTarihi"] != null)
            {
                dgvPersoneller.Columns["IseGirisTarihi"].HeaderText = "İşe Giriş Tarihi";
                dgvPersoneller.Columns["IseGirisTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }

            if (dgvPersoneller.Columns["AktifMi"] != null)
                dgvPersoneller.Columns["AktifMi"].HeaderText = "Aktif Mi";

            dgvPersoneller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersoneller.MultiSelect = false;
            dgvPersoneller.ReadOnly = true;
            dgvPersoneller.AllowUserToAddRows = false;
            dgvPersoneller.AllowUserToDeleteRows = false;
        }

        private int? SeciliPersonelIdGetir()
        {
            if (dgvPersoneller.CurrentRow == null)
                return null;

            var cellValue = dgvPersoneller.CurrentRow.Cells["Id"]?.Value;

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

        private async void txtArama_TextChanged(object sender, EventArgs e)
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

        private async void chkSadeceAktifler_CheckedChanged(object sender, EventArgs e)
        {
            if (_filtreYukleniyor)
                return;

            await ListeleAsync();
        }

        private async void cmbDepartmanFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_filtreYukleniyor)
                return;

            await ListeleAsync();
        }

        private async void cmbPozisyonFiltre_SelectedIndexChanged(object sender, EventArgs e)
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

                txtArama.Clear();
                chkSadeceAktifler.Checked = true;
                cmbDepartmanFiltre.SelectedIndex = 0;
                cmbPozisyonFiltre.SelectedIndex = 0;
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
                var form = scope.ServiceProvider.GetRequiredService<frm_PersonelDuzenle>();

                form.PersonelId = null;

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                    await ListeleAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ekleme ekranı açılırken hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                var seciliId = SeciliPersonelIdGetir();

                if (!seciliId.HasValue)
                {
                    MessageBox.Show(
                        "Lütfen düzenlemek istediğiniz personeli seçin.",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                using var scope = _serviceProvider.CreateScope();
                var form = scope.ServiceProvider.GetRequiredService<frm_PersonelDuzenle>();

                form.PersonelId = seciliId.Value;

                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                    await ListeleAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Düzenleme ekranı açılırken hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var seciliId = SeciliPersonelIdGetir();

                if (!seciliId.HasValue)
                {
                    MessageBox.Show(
                        "Lütfen pasife almak istediğiniz personeli seçin.",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var onay = MessageBox.Show(
                    "Seçili personel pasife alınacaktır. Devam edilsin mi?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (onay != DialogResult.Yes)
                    return;

                await _personelService.SoftDeleteAsync(seciliId.Value);

                MessageBox.Show(
                    "Personel başarıyla pasife alındı.",
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

        private async void dgvPersoneller_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            await Task.Yield();
            btnDuzenle.PerformClick();
        }
    }
}
