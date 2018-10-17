using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinamicasAgile.Banco;
using dinamicasAgile.DAO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace dinamicasAgile
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment hostEnvironment)
        {
            Configuration = configuration;
            HostEnvironment = hostEnvironment;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment HostEnvironment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            string connectionString = "";
            if(HostEnvironment.IsDevelopment()) {
                connectionString = Configuration.GetConnectionString("DefaultConnection");
            } else {
                
                string clearDbUrl = Environment.GetEnvironmentVariable("CLEARDB_DATABASE_URL");
                clearDbUrl.Replace("//", "");
                char[] delimiterChars = { '/', ':', '@', '?' };
                string[] strConn = clearDbUrl.Split(delimiterChars).Where(x => !string.IsNullOrEmpty(x)).ToArray();
                connectionString = "server="+strConn[3]+";port=3306;database="+strConn[4]+";uid="+strConn[1]+";password="+strConn[2]+";";
            }
            services.AddDbContext<DinamicaContext>(options =>
                    options.UseLazyLoadingProxies().UseMySql(connectionString));


            services.AddTransient<DinamicaDao>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
