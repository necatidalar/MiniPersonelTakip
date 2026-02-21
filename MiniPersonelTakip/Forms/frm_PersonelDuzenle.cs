using System.Windows.Forms;

namespace MiniPersonelTakip
{
    public partial class frm_PersonelDuzenle : Form
    {
        private readonly int _personelId;

        public frm_PersonelDuzenle(int personelId)
        {
            InitializeComponent();
            _personelId = personelId;
        }

        private void FrmPersonelDuzenle_Load(object sender, EventArgs e)
        {
            var service = new PersonelService();
            var p = service.Getir(_personelId);

            if (p == null)
            {
                MessageBox.Show("Personel bulunamadı");
                Close();
                return;
            }

            txtAd.Text = p.Ad;
            txtSoyad.Text = p.Soyad;
            txtTckn.Text = p.TCKN;
            txtTelefon.Text = p.Telefon;
            dtpIseGiris.Value = p.IseGirisTarihi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var service = new PersonelService();

            service.Guncelle(new Personel
            {
                Id = _personelId,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TCKN = txtTckn.Text,
                Telefon = txtTelefon.Text,
                IseGirisTarihi = dtpIseGiris.Value
            });

            MessageBox.Show("Güncelleme başarılı");
            Close();
        }
    }
}
