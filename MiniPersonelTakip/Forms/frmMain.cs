using Microsoft.Extensions.DependencyInjection;
using MiniPersonelTakip.Forms;
using MiniPersonelTakip.Helpers;

namespace MiniPersonelTakip
{
    public partial class frmMain : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private IServiceScope? _currentScope;

        public frmMain(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenFormInPanel<frm_PersonelYonetimi>();
        }

        private void OpenFormInPanel<TForm>() where TForm : Form
        {
            try
            {
                if (pnlContainer.Controls.Count > 0 && pnlContainer.Controls[0] is TForm)
                {
                    return;
                }

                if (pnlContainer.Controls.Count > 0)
                {
                    var existingForm = pnlContainer.Controls[0] as Form;
                    existingForm?.Close();
                    existingForm?.Dispose();
                    pnlContainer.Controls.Clear();
                }

                _currentScope?.Dispose();
                _currentScope = _serviceProvider.CreateScope();

                var form = _currentScope.ServiceProvider.GetRequiredService<TForm>();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;

                pnlContainer.Controls.Add(form);
                pnlContainer.Tag = form;
                form.Show();
                form.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form açılırken hata oluştu. Detay: { ExceptionHelper.GetFullMessage(ex)}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _currentScope?.Dispose();
            base.OnFormClosed(e);
        }

        private void btnPersonelYonetimi_Click(object sender, EventArgs e)
        {
            OpenFormInPanel<frm_PersonelYonetimi>();
        }

        private void btnGorevYonetimi_Click(object sender, EventArgs e)
        {
            OpenFormInPanel<frm_GorevYonetimi>();
        }

        private void btnVardiyaYonetimi_Click(object sender, EventArgs e)
        {
            OpenFormInPanel<frm_VardiyaYonetimi>();
        }

        private void btnIzinYonetimi_Click(object sender, EventArgs e)
        {
            OpenFormInPanel<frm_IzinYonetimi>();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
