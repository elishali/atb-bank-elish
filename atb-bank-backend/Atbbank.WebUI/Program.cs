using Atbbank.WebUI.Models.Persistences;
using Microsoft.EntityFrameworkCore;

namespace Atbbank.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<DataContext>(cfg => {
                cfg.UseSqlServer(builder.Configuration.GetConnectionString("cElish"),
                    opt =>
                    {
                        opt.MigrationsHistoryTable("Migrations");
                    });
            });

            builder.Services.AddRouting(cfg => cfg.LowercaseUrls = true);

            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(cfg =>
            {

                 cfg.MapControllerRoute(
                 name: "areas",
                 pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                );


                cfg.MapControllerRoute("default","{controller=home}/{action=index}/{id?}");
            });

            app.Run();
        }
    }
}