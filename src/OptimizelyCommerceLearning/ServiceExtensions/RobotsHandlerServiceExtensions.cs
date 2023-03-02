namespace OptimizelyCommerceLearning.ServiceExtensions;

using Microsoft.Extensions.DependencyInjection;
using Stott.Optimizely.RobotsHandler.Common;
using Stott.Optimizely.RobotsHandler.Configuration;

public static class RobotsHandlerServiceExtensions
{
    public static IServiceCollection AddRobotsTextHandler(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddRobotsHandler(authorizationOptions =>
        {
            authorizationOptions.AddPolicy(RobotsConstants.AuthorizationPolicy, policy =>
            {
                policy.RequireRole("WebAdmins", "SeoAdmin");
            });
        });

        return serviceCollection;
    }
}