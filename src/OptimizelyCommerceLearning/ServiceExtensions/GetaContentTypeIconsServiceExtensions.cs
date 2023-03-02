namespace OptimizelyCommerceLearning.ServiceExtensions;

using System;
using Geta.Optimizely.ContentTypeIcons.Infrastructure.Configuration;
using Geta.Optimizely.ContentTypeIcons.Infrastructure.Initialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public static class GetaContentTypeIconsServiceExtensions
{
    public static IServiceCollection AddGetaContentTypeIcons(
        this IServiceCollection serviceCollection,
        IWebHostEnvironment webHostEnvironment)
    {
        if (webHostEnvironment.IsDevelopment() && Environment.OSVersion.Platform == PlatformID.MacOSX)
        {
            return serviceCollection;
        }

        serviceCollection.AddContentTypeIcons(x =>
        {
            x.EnableTreeIcons = true;
            x.ForegroundColor = "#ffffff";
            x.BackgroundColor = "#00358e";
            x.FontSize = 40;
            x.CachePath = "[appDataPath]\\thumb_cache\\";
            x.CustomFontPath = "[appDataPath]\\fonts\\";
        });

        return serviceCollection;
    }

    public static IApplicationBuilder UseGetaContentTypeIcons(
        this IApplicationBuilder app,
        IWebHostEnvironment webHostEnvironment)
    {
        if (webHostEnvironment.IsDevelopment() && Environment.OSVersion.Platform == PlatformID.MacOSX)
        {
            return app;
        }

        app.UseContentTypeIcons();

        return app;
    }
}
