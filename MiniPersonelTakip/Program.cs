using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiniPersonelTakip.Data;
using MiniPersonelTakip.Forms;
using MiniPersonelTakip.Repositories.Abstract;
using MiniPersonelTakip.Repositories.Concrete;
using MiniPersonelTakip.Services.Abstract;
using MiniPersonelTakip.Services.Concrete;

namespace MiniPersonelTakip
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();

            var builder = Host.CreateApplicationBuilder();
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                MessageBox.Show(
                    "Bağlantı dizesi bulunamadı. appsettings.json içindeki DefaultConnection ayarını kontrol edin.",
                    "Yapılandırma Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddScoped<IPersonelRepository, PersonelRepository>();
            builder.Services.AddScoped<IDepartmanRepository, DepartmanRepository>();
            builder.Services.AddScoped<IPozisyonRepository, PozisyonRepository>();
            builder.Services.AddScoped<IVardiyaRepository, VardiyaRepository>();
            builder.Services.AddScoped<IIzinRepository, IzinRepository>();
            builder.Services.AddScoped<IGorevRepository, GorevRepository>();

            builder.Services.AddScoped<IPersonelService, PersonelService>();
            builder.Services.AddScoped<ILookupService, LookupService>();
            builder.Services.AddScoped<IVardiyaService, VardiyaService>();
            builder.Services.AddScoped<IIzinService, IzinService>();
            builder.Services.AddScoped<IGorevService, GorevService>();

            builder.Services.AddTransient<frmMain>();
            builder.Services.AddTransient<frm_PersonelYonetimi>();
            builder.Services.AddTransient<frm_PersonelDuzenle>();
            builder.Services.AddTransient<frm_VardiyaYonetimi>();
            builder.Services.AddTransient<frm_VardiyaDuzenle>();
            builder.Services.AddTransient<frm_IzinYonetimi>();
            builder.Services.AddTransient<frm_IzinDuzenle>();
            builder.Services.AddTransient<frm_GorevYonetimi>();
            builder.Services.AddTransient<frm_GorevDuzenle>();

            using var host = builder.Build();

            try
            {
                using var scope = host.Services.CreateScope();
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                dbContext.Database.EnsureCreated();

                var mainForm = scope.ServiceProvider.GetRequiredService<frmMain>();
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Uygulama başlatılırken hata oluştu. Detay:" +
                    $"{ Helpers.ExceptionHelper.GetFullMessage(ex)} ", "Başlatma Hatası", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
