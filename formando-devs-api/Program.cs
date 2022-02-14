using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace formando_devs_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>

            Host.CreateDefaultBuilder(args)

                .ConfigureWebHostDefaults(webBuilder =>

                {
                    var HostURL= Environment.GetEnvironmentVariable("HostURL");
                    webBuilder.UseUrls(String.IsNullOrWhiteSpace(HostURL)?"http://0.0.0.0:8080":HostURL).UseStartup<Startup>(); // definindo variavel de ambiente para que seja repassado dentro do docker a porta de preferência para subir a aplicação

                });

    }
}
