using System.ComponentModel;
using MiniPersonelTakip.DTOs.Common;
using MiniPersonelTakip.DTOs.Vardiya;
using MiniPersonelTakip.Services.Abstract;

namespace MiniPersonelTakip
{
    public partial class frm_VardiyaDuzenle : Form
    {
        private readonly IVardiyaService _vardiyaService;
        private readonly ILookupService _lookupService;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int? VardiyaId { get; set; }

        public frm_VardiyaDuzenle(
            IVardiyaService vardiyaService,
            ILookupService lookupService)
        {
            InitializeComponent();
            _vardiyaService = vardiyaService;
            _lookupService = lookupService;
        }

        private async void frm_VardiyaDuzenle_Load(object sender, EventArgs e)
        {
            try
            {
                FormBaslat();
                await LookupYukleAsync();
                await VarsaKayitYukleAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Form yüklenirken hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }

        private void FormBaslat()
        {
            Text = VardiyaId.HasValue ? "Vardiya Düzenle" : "Yeni Vardiya";

            dtpTarih.Value = DateTime.Today;

            dtpPlanlananGiris.Format = DateTimePickerFormat.Time;
            dtpPlanlananGiris.ShowUpDown = true;

            dtpPlanlananCikis.Format = DateTimePickerFormat.Time;
            dtpPlanlananCikis.ShowUpDown = true;

            dtpGercekGiris.Format = DateTimePickerFormat.Time;
            dtpGercekGiris.ShowUpDown = true;

            dtpGercekCikis.Format = DateTimePickerFormat.Time;
            dtpGercekCikis.ShowUpDown = true;

            dtpPlanlananGiris.Value = DateTime.Today.AddHours(8);
            dtpPlanlananCikis.Value = DateTime.Today.AddHours(17);
            dtpGercekGiris.Value = DateTime.Today.AddHours(8);
            dtpGercekCikis.Value = DateTime.Today.AddHours(17);

            chkGercekSaatlerGirilsin.Checked = false;
            GercekSaatKontrolDurumuUygula();
        }

        private async Task LookupYukleAsync()
        {
            var personeller = await _lookupService.GetAktifPersonellerAsync();

            cmbPersonel.DataSource = personeller;
            cmbPersonel.DisplayMember = nameof(LookupDto.Ad);
            cmbPersonel.ValueMember = nameof(LookupDto.Id);
            cmbPersonel.SelectedIndex = -1;

            cmbVardiyaTipi.DataSource = new List<string>
            {
                "Sabah",
                "Aksam",
                "Gece",
                "Ofis",
                "Hafta Sonu"
            };

            cmbDurum.DataSource = new List<string>
            {
                "Tamamlandi",
                "Eksik",
                "Devam Ediyor",
                "Izinli"
            };
        }

        private async Task VarsaKayitYukleAsync()
        {
            if (!VardiyaId.HasValue)
                return;

            Cursor = Cursors.WaitCursor;

            try
            {
                var dto = await _vardiyaService.GetByIdAsync(VardiyaId.Value);

                if (dto == null)
                {
                    MessageBox.Show(
                        "Vardiya kaydı bulunamadı.",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                cmbPersonel.SelectedValue = dto.PersonelId;
                dtpTarih.Value = dto.Tarih.Date;
                dtpPlanlananGiris.Value = DateTime.Today.Add(dto.PlanlananGiris);
                dtpPlanlananCikis.Value = DateTime.Today.Add(dto.PlanlananCikis);

                chkGercekSaatlerGirilsin.Checked = dto.GercekGiris.HasValue && dto.GercekCikis.HasValue;

                dtpGercekGiris.Value = DateTime.Today.Add(dto.GercekGiris ?? dto.PlanlananGiris);
                dtpGercekCikis.Value = DateTime.Today.Add(dto.GercekCikis ?? dto.PlanlananCikis);

                cmbVardiyaTipi.SelectedItem = dto.VardiyaTipi;
                cmbDurum.SelectedItem = dto.Durum;
                txtAciklama.Text = dto.Aciklama ?? string.Empty;

                GercekSaatKontrolDurumuUygula();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void GercekSaatKontrolDurumuUygula()
        {
            dtpGercekGiris.Enabled = chkGercekSaatlerGirilsin.Checked;
            dtpGercekCikis.Enabled = chkGercekSaatlerGirilsin.Checked;
        }

        private bool FormValidMi()
        {
            if (cmbPersonel.SelectedValue == null)
            {
                MessageBox.Show("Personel seçimi zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPersonel.Focus();
                return false;
            }

            if (cmbVardiyaTipi.SelectedItem == null)
            {
                MessageBox.Show("Vardiya tipi seçimi zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbVardiyaTipi.Focus();
                return false;
            }

            if (cmbDurum.SelectedItem == null)
            {
                MessageBox.Show("Durum seçimi zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDurum.Focus();
                return false;
            }

            return true;
        }

        private VardiyaCreateDto CreateCreateDto()
        {
            return new VardiyaCreateDto
            {
                PersonelId = Convert.ToInt32(cmbPersonel.SelectedValue),
                Tarih = dtpTarih.Value.Date,
                PlanlananGiris = dtpPlanlananGiris.Value.TimeOfDay,
                PlanlananCikis = dtpPlanlananCikis.Value.TimeOfDay,
                GercekGiris = chkGercekSaatlerGirilsin.Checked ? dtpGercekGiris.Value.TimeOfDay : null,
                GercekCikis = chkGercekSaatlerGirilsin.Checked ? dtpGercekCikis.Value.TimeOfDay : null,
                VardiyaTipi = cmbVardiyaTipi.SelectedItem?.ToString() ?? string.Empty,
                Durum = cmbDurum.SelectedItem?.ToString() ?? string.Empty,
                Aciklama = txtAciklama.Text.Trim()
            };
        }

        private VardiyaUpdateDto CreateUpdateDto()
        {
            return new VardiyaUpdateDto
            {
                Id = VardiyaId ?? 0,
                PersonelId = Convert.ToInt32(cmbPersonel.SelectedValue),
                Tarih = dtpTarih.Value.Date,
                PlanlananGiris = dtpPlanlananGiris.Value.TimeOfDay,
                PlanlananCikis = dtpPlanlananCikis.Value.TimeOfDay,
                GercekGiris = chkGercekSaatlerGirilsin.Checked ? dtpGercekGiris.Value.TimeOfDay : null,
                GercekCikis = chkGercekSaatlerGirilsin.Checked ? dtpGercekCikis.Value.TimeOfDay : null,
                VardiyaTipi = cmbVardiyaTipi.SelectedItem?.ToString() ?? string.Empty,
                Durum = cmbDurum.SelectedItem?.ToString() ?? string.Empty,
                Aciklama = txtAciklama.Text.Trim()
            };
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FormValidMi())
                    return;

                btnKaydet.Enabled = false;
                Cursor = Cursors.WaitCursor;

                if (!VardiyaId.HasValue)
                {
                    var createDto = CreateCreateDto();
                    await _vardiyaService.AddAsync(createDto);

                    MessageBox.Show(
                        "Vardiya kaydı başarıyla eklendi.",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    var updateDto = CreateUpdateDto();
                    await _vardiyaService.UpdateAsync(updateDto);

                    MessageBox.Show(
                        "Vardiya kaydı başarıyla güncellendi.",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "İş Kuralı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Kayıt işlemi sırasında hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnKaydet.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void chkGercekSaatlerGirilsin_CheckedChanged(object sender, EventArgs e)
        {
            GercekSaatKontrolDurumuUygula();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}