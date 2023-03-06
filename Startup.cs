using Microsoft.EntityFrameworkCore;
using PaginaLogin.Data;
using PaginaLogin.Repositorio;

namespace PaginaLogin
{
    public class Startup
    {
        public Startup (IConfiguration configuration)
        {
            Configuration = configuration;

        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            // Add services to the container.
            services.AddControllersWithViews();
            services.AddEntityFrameworkSqlServer().AddDbContext<BancoContent>(o => o.UseSqlServer(Configuration.GetConnectionString("PaginaLogin")));
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
        }
        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

        }
    }
}
