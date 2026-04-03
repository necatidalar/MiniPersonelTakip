using MiniPersonelTakip.DTOs.Common;
using MiniPersonelTakip.DTOs.Gorev;
using MiniPersonelTakip.Helpers;
using MiniPersonelTakip.Services.Abstract;
using System.ComponentModel;

namespace MiniPersonelTakip.Forms
{
    public partial class frm_GorevDuzenle : Form
    {
        private readonly IGorevService _gorevService;
        private readonly ILookupService _lookupService;


        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int? GorevId { get; set; }

        public frm_GorevDuzenle(IGorevService gorevService, ILookupService lookupService)
        {
            InitializeComponent();

            _gorevService = gorevService;
            _lookupService = lookupService;

            btnKaydet.Click += btnKaydet_Click;
            btnIptal.Click += (s, e) => DialogResult = DialogResult.Cancel;
            chkBitisTarihi.CheckedChanged += chkBitisTarihi_CheckedChanged;

            AcceptButton = btnKaydet;
            CancelButton = btnIptal;
        }

        private async void frm_GorevDuzenle_Load(object? sender, EventArgs e)
        {
            try
            {
                await PersonelleriYukleAsync();

                cmbOncelik.DataSource = new List<string>
                {
                    "Düşük",
                    "Orta",
                    "Yüksek",
                    "Kritik"
                };

                cmbDurum.DataSource = new List<string>
                {
                    "Bekliyor",
                    "Devam Ediyor",
                    "Tamamlandı",
                    "İptal Edildi"
                };

                dtpBaslangic.Value = DateTime.Today;
                dtpBitis.Value = DateTime.Today;
                chkBitisTarihi.Checked = false;
                dtpBitis.Enabled = false;

                if (GorevId.HasValue)
                {
                    var dto = await _gorevService.GetByIdAsync(GorevId.Value);

                    if (dto == null)
                    {
                        MessageBox.Show("Görev kaydı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DialogResult = DialogResult.Cancel;
                        return;
                    }

                    Text = "Görev Güncelle";
                    cmbPersonel.SelectedValue = dto.PersonelId;
                    txtGorevBasligi.Text = dto.GorevBasligi;
                    txtGorevDetayi.Text = dto.GorevDetayi;
                    dtpBaslangic.Value = dto.BaslangicTarihi;
                    cmbOncelik.SelectedItem = dto.Oncelik;
                    cmbDurum.SelectedItem = dto.Durum;

                    if (dto.BitisTarihi.HasValue)
                    {
                        chkBitisTarihi.Checked = true;
                        dtpBitis.Enabled = true;
                        dtpBitis.Value = dto.BitisTarihi.Value;
                    }
                }
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

        private void chkBitisTarihi_CheckedChanged(object? sender, EventArgs e)
        {
            dtpBitis.Enabled = chkBitisTarihi.Checked;

            if (!chkBitisTarihi.Checked)
                dtpBitis.Value = dtpBaslangic.Value.Date;
        }

        private async void btnKaydet_Click(object? sender, EventArgs e)
        {
            try
            {
                btnKaydet.Enabled = false;

                if (cmbPersonel.SelectedValue == null || !int.TryParse(cmbPersonel.SelectedValue.ToString(), out int personelId))
                    throw new ArgumentException("Personel seçimi zorunludur.");

                DateTime? bitisTarihi = chkBitisTarihi.Checked
                    ? dtpBitis.Value.Date
                    : (DateTime?)null;

                if (GorevId.HasValue)
                {
                    var updateDto = new GorevUpdateDto
                    {
                        Id = GorevId.Value,
                        PersonelId = personelId,
                        GorevBasligi = txtGorevBasligi.Text.Trim(),
                        GorevDetayi = txtGorevDetayi.Text.Trim(),
                        BaslangicTarihi = dtpBaslangic.Value.Date,
                        BitisTarihi = bitisTarihi,
                        Oncelik = cmbOncelik.SelectedItem?.ToString() ?? string.Empty,
                        Durum = cmbDurum.SelectedItem?.ToString() ?? string.Empty
                    };

                    await _gorevService.UpdateAsync(updateDto);
                    MessageBox.Show("Görev kaydı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var createDto = new GorevCreateDto
                    {
                        PersonelId = personelId,
                        GorevBasligi = txtGorevBasligi.Text.Trim(),
                        GorevDetayi = txtGorevDetayi.Text.Trim(),
                        BaslangicTarihi = dtpBaslangic.Value.Date,
                        BitisTarihi = bitisTarihi,
                        Oncelik = cmbOncelik.SelectedItem?.ToString() ?? string.Empty,
                        Durum = cmbDurum.SelectedItem?.ToString() ?? string.Empty
                    };

                    await _gorevService.AddAsync(createDto);
                    MessageBox.Show("Görev kaydı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Kaydetme işlemi sırasında hata oluştu.\n\nDetay:\n{MiniPersonelTakip.Helpers.ExceptionHelper.GetFullMessage(ex)}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnKaydet.Enabled = true;
            }
        }
    }
}