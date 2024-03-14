using Chatty.Data;
using Chatty.Hubs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chatty
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Această metodă este apelată de runtime. Utilizați această metodă pentru a adăuga servicii la container.
        // Pentru mai multe informații despre configurarea aplicației, vizitați https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>(); // Adăugarea serviciului WeatherForecastService ca singleton
            services.AddResponseCompression(opts => {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "application/octet-stream" });
            });
        }

        // Această metodă este apelată de runtime. Utilizați această metodă pentru a configura conducta de solicitare HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Utilizare pagină de excepție pentru mediu de dezvoltare
            }
            else
            {
                app.UseExceptionHandler("/Error"); // Utilizare pagină de eroare pentru mediu de producție
                // Valoarea implicită HSTS este de 30 de zile. Este posibil să doriți să o schimbați pentru scenariile de producție, consultați https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection(); // Redirecționare la HTTPS
            app.UseStaticFiles(); // Utilizare fișiere statice

            app.UseRouting(); // Utilizare rutare

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub(); // Mapare BlazorHub
                endpoints.MapHub<ChatHub>("/chathub"); // Mapare Hub de chat la calea /chathub
                endpoints.MapFallbackToPage("/_Host"); // Mapare către pagină de rezervă
            });
        }
    }
}

