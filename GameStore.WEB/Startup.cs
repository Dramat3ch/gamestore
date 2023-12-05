using GameStore.BLL.Interfaces;
using GameStore.BLL.Services;
using GameStore.DAL;
using GameStore.DAL.Interfaces;
using GameStore.DAL.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore.WEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            const string connection = "Server=(localdb)\\mssqllocaldb; Database=userstoredb; Trusted_Connection=true;";
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connection));

            services.AddControllersWithViews();
            services.AddRazorPages().AddRazorRuntimeCompilation();

            services.AddTransient<IGameService, GameService>();
            services.AddTransient<IGameRepository, GameRepository>();

            services.AddTransient<IGenreService, GenreService>();
            services.AddTransient<IGenreRepository, GenreRepository>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Games}/{action=Index}/{id?}");
            });
        }
    }
}