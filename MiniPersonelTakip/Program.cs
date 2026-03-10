using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiniPersonelTakip.Data;
using MiniPersonelTakip.Repositories.Abstract;
using MiniPersonelTakip.Repositories.Concrete;
using MiniPersonelTakip.Services.Abstract;
using MiniPersonelTakip.Services.Concrete;

namespace MiniPersonelTakip
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var builder = Host.CreateApplicationBuilder();

            builder.Services.AddDbContext<AppDbContext>(options =>
                           options.UseSqlServer("Server=DALAR;Database=PersonelTakipDB;User Id=sa;Password=Nd200528;Trusted_Connection=True; TrustServerCertificate=True;"));

            builder.Services.AddScoped<IPersonelRepository, PersonelRepository>();
            builder.Services.AddScoped<IDepartmanRepository, DepartmanRepository>();
            builder.Services.AddScoped<IPozisyonRepository, PozisyonRepository>();
            builder.Services.AddScoped<IVardiyaRepository, VardiyaRepository>();

            builder.Services.AddScoped<IPersonelService, PersonelService>();
            builder.Services.AddScoped<ILookupService, LookupService>();
            builder.Services.AddScoped<IVardiyaService, VardiyaService>();

            builder.Services.AddTransient<frmMain>();
            builder.Services.AddTransient<frm_MiniPersonelTakip>();
            builder.Services.AddTransient<frm_PersonelDuzenle>();
            builder.Services.AddTransient<frm_VardiyaYonetimi>();
            builder.Services.AddTransient<frm_VardiyaDuzenle>();

            using var host = builder.Build();

            var mainForm = host.Services.GetRequiredService<frmMain>();
            Application.Run(mainForm);
        }
    }
}