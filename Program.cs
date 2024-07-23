using Microsoft.EntityFrameworkCore;
using Task15.Models.Contexts;

namespace Task15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseInMemoryDatabase("ContriesDb");
            });
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}/{id?}");

            //app.MapGet("/", () => "Hello World!");

            app.Seed();

            app.Run();
        }
    }
}
