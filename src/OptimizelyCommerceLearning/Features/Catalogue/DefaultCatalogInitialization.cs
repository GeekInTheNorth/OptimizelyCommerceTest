namespace OptimizelyCommerceLearning.Features.Catalogue
{
    using EPiServer.Commerce.Routing;
    using EPiServer.Framework;
    using EPiServer.Framework.Initialization;

    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Commerce.Initialization.InitializationModule))]
    public sealed class DefaultCatalogInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            CatalogRouteHelper.MapDefaultHierarchialRouter(false);
        }

        public void Uninitialize(InitializationEngine context)
        {
            // Do nothing, required for interface specification.
        }
    }
}
