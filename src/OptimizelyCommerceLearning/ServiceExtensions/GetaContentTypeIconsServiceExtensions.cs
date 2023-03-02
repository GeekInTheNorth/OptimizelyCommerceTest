namespace OptimizelyCommerceLearning.ServiceExtensions;

using Geta.Optimizely.ContentTypeIcons.Infrastructure.Configuration;
using Geta.Optimizely.ContentTypeIcons.Infrastructure.Initialization;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public static class GetaContentTypeIconsServiceExtensions
{
    public static IServiceCollection AddGetaContentTypeIcons(this IServiceCollection serviceCollection)
    {
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

    public static IApplicationBuilder UseGetaContentTypeIcons(this IApplicationBuilder app)
    {
        app.UseContentTypeIcons();

        return app;
    }
}
