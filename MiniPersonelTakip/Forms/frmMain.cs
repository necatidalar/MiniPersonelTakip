using Microsoft.Extensions.DependencyInjection;
using MiniPersonelTakip.Forms;
using MiniPersonelTakip.Helpers;

namespace MiniPersonelTakip
{
    public partial class frmMain : Form
    {
        private readonly IServiceProvider _serviceProvider;

        private void frmMain_Load(object sender, EventArgs e)
        {
            UiTheme.StylePage(this);

            UiTheme.StyleSidebarButton(btnPersonelYonetimi, UiTheme.Primary);
            UiTheme.StyleSidebarButton(btnVardiyaYonetimi, UiTheme.Success);
            UiTheme.StyleSidebarButton(btnIzinYonetimi, UiTheme.Secondary);
            UiTheme.StyleSidebarButton(btnGorevYonetimi, UiTheme.Warning);
        }

        public frmMain(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void OpenMdiChild<TForm>() where TForm : Form
        {
            try
            {
                foreach (Form child in MdiChildren)
                {
                    if (child is TForm)
                    {
                        child.Activate();
                        child.WindowState = FormWindowState.Maximized;
                        return;
                    }
                }

                var scope = _serviceProvider.CreateScope();
                var form = scope.ServiceProvider.GetRequiredService<TForm>();

                form.MdiParent = this;
                form.StartPosition = FormStartPosition.Manual;
                form.WindowState = FormWindowState.Maximized;

                form.FormClosed += (_, __) => scope.Dispose();

                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Form açılırken hata oluştu.\n\nDetay: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnPersonelYonetimi_Click(object sender, EventArgs e)
        {
            OpenMdiChild<frm_PersonelTakip>();
        }

        private void btnGorevYonetimi_Click(object sender, EventArgs e)
        {
            OpenMdiChild<frm_GorevYonetimi>();
        }

        private void btnVardiyaYonetimi_Click(object sender, EventArgs e)
        {
            OpenMdiChild<frm_VardiyaYonetimi>();
        }

        private void btnIzinYonetimi_Click(object sender, EventArgs e)
        {
            OpenMdiChild<frm_IzinYonetimi>();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}