namespace OptimizelyCommerceLearning.ServiceExtensions;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Stott.Security.Optimizely.Common;
using Stott.Security.Optimizely.Features.Configuration;

public static class SecurityServiceExtensions
{
    public static IServiceCollection AddSecurityAdmin(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddCspManager(cspSetupOptions =>
            {
                cspSetupOptions.ConnectionStringName = ConfigConstants.OptimizelyConnectionStringName;
            },
            authorizationOptions =>
            {
                authorizationOptions.AddPolicy(CspConstants.AuthorizationPolicy, policy =>
                {
                    policy.RequireRole("WebAdmins");
                });
            });

        return serviceCollection;
    }

    public static IApplicationBuilder UseSecurityAdmin(this IApplicationBuilder app)
    {
        app.UseCspManager();

        return app;
    }
}