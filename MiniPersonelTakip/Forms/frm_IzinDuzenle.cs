using MiniPersonelTakip.DTOs.Common;
using MiniPersonelTakip.DTOs.Izin;
using MiniPersonelTakip.Helpers;
using MiniPersonelTakip.Services.Abstract;
using System.ComponentModel;

namespace MiniPersonelTakip.Forms
{
    public partial class frm_IzinDuzenle : Form
    {
        private readonly IIzinService _izinService;
        private readonly ILookupService _lookupService;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int? IzinId { get; set; }

        public frm_IzinDuzenle(IIzinService izinService, ILookupService lookupService)
        {
            InitializeComponent();

            _izinService = izinService;
            _lookupService = lookupService;

            Load += frm_IzinDuzenle_Load;
            dtpBaslangic.ValueChanged += Tarih_ValueChanged;
            dtpBitis.ValueChanged += Tarih_ValueChanged;
            btnKaydet.Click += btnKaydet_Click;
            btnIptal.Click += btnIptal_Click;

            AcceptButton = btnKaydet;
            CancelButton = btnIptal;
        }

        private async void frm_IzinDuzenle_Load(object? sender, EventArgs e)
        {
            UiTheme.StyleDialog(this);
            UiTheme.StyleInputs(this);

            lblGunSayisi.ForeColor = UiTheme.Primary;
            lblGunSayisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            UiTheme.StylePrimaryButton(btnKaydet);
            UiTheme.StyleNeutralButton(btnIptal);
            try
            {
                await PersonelleriYukleAsync();

                cmbIzinTuru.DataSource = new List<string>
                {
                    "Yıllık İzin",
                    "Hastalık İzni",
                    "Mazeret İzni",
                    "Ücretsiz İzin"
                };

                cmbDurum.DataSource = new List<string>
                {
                    "Beklemede",
                    "Onaylandı",
                    "Reddedildi",
                    "İptal Edildi"
                };

                dtpBaslangic.Value = DateTime.Today;
                dtpBitis.Value = DateTime.Today;

                if (IzinId.HasValue)
                {
                    var dto = await _izinService.GetByIdAsync(IzinId.Value);

                    if (dto == null)
                    {
                        MessageBox.Show("İzin kaydı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DialogResult = DialogResult.Cancel;
                        return;
                    }

                    Text = "İzin Güncelle";
                    cmbPersonel.SelectedValue = dto.PersonelId;
                    cmbIzinTuru.SelectedItem = dto.IzinTuru;
                    cmbDurum.SelectedItem = dto.Durum;
                    dtpBaslangic.Value = dto.BaslangicTarihi;
                    dtpBitis.Value = dto.BitisTarihi;
                    txtAciklama.Text = dto.Aciklama ?? string.Empty;
                }

                GunSayisiniGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form yüklenirken hata oluştu.\n\nDetay: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }

        private async Task PersonelleriYukleAsync()
        {
            var personeller = await _lookupService.GetAktifPersonellerAsync();

            cmbPersonel.DataSource = null;
            cmbPersonel.DisplayMember = nameof(LookupDto.Ad);
            cmbPersonel.ValueMember = nameof(LookupDto.Id);
            cmbPersonel.DataSource = personeller;
        }

        private void Tarih_ValueChanged(object? sender, EventArgs e)
        {
            if (dtpBitis.Value.Date < dtpBaslangic.Value.Date)
            {
                dtpBitis.Value = dtpBaslangic.Value.Date;
            }

            GunSayisiniGuncelle();
        }

        private void GunSayisiniGuncelle()
        {
            var gunSayisi = (dtpBitis.Value.Date - dtpBaslangic.Value.Date).Days + 1;
            lblGunSayisi.Text = $"Gün Sayısı: {gunSayisi}";
        }

        private async void btnKaydet_Click(object? sender, EventArgs e)
        {
            try
            {
                btnKaydet.Enabled = false;

                if (cmbPersonel.SelectedValue == null || !int.TryParse(cmbPersonel.SelectedValue.ToString(), out int personelId))
                {
                    throw new ArgumentException("Personel seçimi zorunludur.");
                }

                if (IzinId.HasValue)
                {
                    var updateDto = new IzinUpdateDto
                    {
                        Id = IzinId.Value,
                        PersonelId = personelId,
                        IzinTuru = cmbIzinTuru.SelectedItem?.ToString() ?? string.Empty,
                        Durum = cmbDurum.SelectedItem?.ToString() ?? string.Empty,
                        BaslangicTarihi = dtpBaslangic.Value.Date,
                        BitisTarihi = dtpBitis.Value.Date,
                        Aciklama = txtAciklama.Text.Trim()
                    };

                    await _izinService.UpdateAsync(updateDto);
                    MessageBox.Show("İzin kaydı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var createDto = new IzinCreateDto
                    {
                        PersonelId = personelId,
                        IzinTuru = cmbIzinTuru.SelectedItem?.ToString() ?? string.Empty,
                        Durum = cmbDurum.SelectedItem?.ToString() ?? string.Empty,
                        BaslangicTarihi = dtpBaslangic.Value.Date,
                        BitisTarihi = dtpBitis.Value.Date,
                        Aciklama = txtAciklama.Text.Trim()
                    };

                    await _izinService.AddAsync(createDto);
                    MessageBox.Show("İzin kaydı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kaydetme işlemi sırasında hata oluştu.\n\nDetay: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnKaydet.Enabled = true;
            }
        }

        private void btnIptal_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}