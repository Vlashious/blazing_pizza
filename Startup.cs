using Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlazingPizza
{
    public class Startup
    {
        private IConfiguration _conf;

        public Startup(IConfiguration conf)
        {
            _conf = conf;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlite(_conf.GetConnectionString("DefaultConnection"));
            });
            services.AddServerSideBlazor();
            services.AddTransient<IRepository, Repository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
            });
        }
    }
}
