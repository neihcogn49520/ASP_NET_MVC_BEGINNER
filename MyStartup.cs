using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class MyStartup
{
    public void ConfigureServices(IServiceCollection service)
    {
        // service.AddSingleton
    }

    //xay dung pipeLine (chuoi Middleware)
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        //wwwroot - StaticFileMiddleware
        app.UseStaticFiles();

        //EndpointRoutingMiddleware
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async (context) =>
            {
                await context.Response.WriteAsync("Trang chu");
            });
        });

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/about", async (context) =>
            {
                await context.Response.WriteAsync("Trang gioi thieu");
            });
        });

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/contact", async (context) =>
            {
                await context.Response.WriteAsync("Trang lien he");
            });
        });

        //Terminate Middleware M2
        app.Map("/abc", app1 =>
        {
            app1.Run(async (context) =>
            {
                await context.Response.WriteAsync("Xin chao tu ABC");
            });
        });


        //StatusCodePage
        app.UseStatusCodePages();


        // //Terminate Middleware M1
        // app.Run(async (context) =>
        // {
        //     await context.Response.WriteAsync("Xin chao MyStartUp");
        // });


    }
}

