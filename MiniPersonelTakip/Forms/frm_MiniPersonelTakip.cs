using MiniPersonelTakip.Models;
using MiniPersonelTakip.Services;

namespace MiniPersonelTakip
{
    public partial class frm_MiniPersonelTakip : Form
    {
        public frm_MiniPersonelTakip()
        {
            InitializeComponent();
        }

        private void frm_MiniPersonelTakip_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            var service = new PersonelService();
            dgvPersonel.DataSource = service.Listele();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new PersonelService();

                service.Ekle(new Personel
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TCKN = txtTckn.Text,
                    Telefon = txtTelefon.Text,
                    IseGirisTarihi = dtpIseGiris.Value,
                    AktifMi = true
                });

                MessageBox.Show("Kayıt başarılı");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvPersonel.CurrentRow == null) return;

            int id = (int)dgvPersonel.CurrentRow.Cells["Id"].Value;

            if (MessageBox.Show(
                "Seçili personel pasife alınacak. Onaylıyor musun?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            var service = new PersonelService();
            service.Sil(id);

            Listele();
        }
        private void dgvPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersonel.CurrentRow == null) return;

            int id = (int)dgvPersonel.CurrentRow.Cells["Id"].Value;

            var frm = new frm_PersonelDuzenle(id);
            frm.ShowDialog();

            Listele();
        }
    }
}