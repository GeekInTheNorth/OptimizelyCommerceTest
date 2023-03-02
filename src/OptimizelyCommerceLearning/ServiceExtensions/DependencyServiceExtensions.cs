namespace OptimizelyCommerceLearning.ServiceExtensions;

using Microsoft.Extensions.DependencyInjection;

using OptimizelyCommerceLearning.Features.Blocks.Image;
using OptimizelyCommerceLearning.Features.Pages.Home;

public static class DependencyServiceExtensions
{
    public static IServiceCollection AddCustomDependencies(this IServiceCollection serviceCollection)
    {
        // Page Model Builders
        serviceCollection.AddTransient<IHomePageViewModelBuilder, HomePageViewModelBuilder>();

        // Block Model Builders
        serviceCollection.AddTransient<IImageBlockViewModelBuilder, ImageBlockViewModelBuilder>();

        return serviceCollection;
    }
}
