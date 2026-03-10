using MiniPersonelTakip.DTOs.Common;
using MiniPersonelTakip.DTOs.Personel;
using MiniPersonelTakip.Services.Abstract;
using System.ComponentModel;

namespace MiniPersonelTakip
{
    public partial class frm_PersonelDuzenle : Form
    {
        private readonly IPersonelService _personelService;
        private readonly ILookupService _lookupService;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int? PersonelId { get; set; }

        public frm_PersonelDuzenle(
            IPersonelService personelService,
            ILookupService lookupService)
        {
            InitializeComponent();
            _personelService = personelService;
            _lookupService = lookupService;
        }

        private async void frm_PersonelDuzenle_Load(object sender, EventArgs e)
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
            dtpIseGirisTarihi.Value = DateTime.Now;

            if (!PersonelId.HasValue)
            {
                Text = "Personel Ekle";
                chkAktifMi.Checked = true;
                chkAktifMi.Enabled = false;
            }
            else
            {
                Text = "Personel Düzenle";
                chkAktifMi.Enabled = true;
            }
        }

        private async Task LookupYukleAsync()
        {
            var departmanlar = await _lookupService.GetAktifDepartmanlarAsync();
            var pozisyonlar = await _lookupService.GetAktifPozisyonlarAsync();

            cmbDepartman.DataSource = departmanlar;
            cmbDepartman.DisplayMember = nameof(LookupDto.Ad);
            cmbDepartman.ValueMember = nameof(LookupDto.Id);
            cmbDepartman.SelectedIndex = -1;

            cmbPozisyon.DataSource = pozisyonlar;
            cmbPozisyon.DisplayMember = nameof(LookupDto.Ad);
            cmbPozisyon.ValueMember = nameof(LookupDto.Id);
            cmbPozisyon.SelectedIndex = -1;
        }

        private async Task VarsaKayitYukleAsync()
        {
            if (!PersonelId.HasValue)
                return;

            Cursor = Cursors.WaitCursor;

            try
            {
                var dto = await _personelService.GetByIdAsync(PersonelId.Value);

                if (dto == null)
                {
                    MessageBox.Show("Kayıt bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                txtPersonelKod.Text = dto.PersonelKod;
                txtAd.Text = dto.Ad;
                txtSoyad.Text = dto.Soyad;
                txtTelefon.Text = dto.Telefon;
                txtEposta.Text = dto.Eposta;
                txtAdres.Text = dto.Adres;
                dtpIseGirisTarihi.Value = dto.IseGirisTarihi == default ? DateTime.Now : dto.IseGirisTarihi;
                chkAktifMi.Checked = dto.AktifMi;

                cmbDepartman.SelectedValue = dto.DepartmanId;
                cmbPozisyon.SelectedValue = dto.PozisyonId;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private PersonelCreateDto CreateCreateDto()
        {
            return new PersonelCreateDto
            {
                PersonelKod = txtPersonelKod.Text.Trim(),
                Ad = txtAd.Text.Trim(),
                Soyad = txtSoyad.Text.Trim(),
                DepartmanId = Convert.ToInt32(cmbDepartman.SelectedValue),
                PozisyonId = Convert.ToInt32(cmbPozisyon.SelectedValue),
                Telefon = txtTelefon.Text.Trim(),
                Eposta = txtEposta.Text.Trim(),
                Adres = txtAdres.Text.Trim(),
                IseGirisTarihi = dtpIseGirisTarihi.Value.Date
            };
        }

        private PersonelUpdateDto CreateUpdateDto()
        {
            return new PersonelUpdateDto
            {
                Id = PersonelId ?? 0,
                PersonelKod = txtPersonelKod.Text.Trim(),
                Ad = txtAd.Text.Trim(),
                Soyad = txtSoyad.Text.Trim(),
                DepartmanId = Convert.ToInt32(cmbDepartman.SelectedValue),
                PozisyonId = Convert.ToInt32(cmbPozisyon.SelectedValue),
                Telefon = txtTelefon.Text.Trim(),
                Eposta = txtEposta.Text.Trim(),
                Adres = txtAdres.Text.Trim(),
                IseGirisTarihi = dtpIseGirisTarihi.Value.Date,
                AktifMi = chkAktifMi.Checked
            };
        }

        private bool FormValidMi()
        {
            if (cmbDepartman.SelectedValue == null)
            {
                MessageBox.Show("Departman seçimi zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDepartman.Focus();
                return false;
            }

            if (cmbPozisyon.SelectedValue == null)
            {
                MessageBox.Show("Pozisyon seçimi zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPozisyon.Focus();
                return false;
            }

            return true;
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FormValidMi())
                    return;

                btnKaydet.Enabled = false;
                Cursor = Cursors.WaitCursor;

                if (!PersonelId.HasValue)
                {
                    var createDto = CreateCreateDto();
                    await _personelService.AddAsync(createDto);
                    MessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var updateDto = CreateUpdateDto();
                    await _personelService.UpdateAsync(updateDto);
                    MessageBox.Show("Personel başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Kayıt işlemi sırasında hata oluştu.\n\nDetay: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnKaydet.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}