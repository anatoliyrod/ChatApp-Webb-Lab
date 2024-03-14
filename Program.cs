using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DChat
{
    public class Program
    {
        // Metoda Main - punctul de intrare al aplicației
        public static void Main(string[] args)
        {
            // Construiește și rulează gazda
            CreateHostBuilder(args).Build().Run();
        }

        // Metoda pentru crearea gazdei
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            // Creează un builder pentru gazdă utilizând setările implicite
            Host.CreateDefaultBuilder(args)
                // Configurează serviciile web
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // Utilizează clasa Startup pentru configurarea aplicației
                    webBuilder.UseStartup<Startup>();
                });
    }
}
