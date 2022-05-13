//using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace First_Demo_ASPWeb
{
    public class Program
    {
        /*
            Host (IHost) object:
                - Dependency Injection
                - Logging
                - Config
                IHostService => StartAscyn: Run HTTP Server (Kestrel Http)
            1) Tao IHostBuilder
            2) Cau hinh, dang ky dich vu
            3) IHostBuilder.Build() => Host (IHost)
            4) Host.Run();

            Request => pipeLine (Middleware)
        */
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //tuy bien them ve HOST
                    //webHostBuilder.UseWebRoot("publish");
                    webBuilder.UseStartup<MyStartup>();
                });
    }
}
