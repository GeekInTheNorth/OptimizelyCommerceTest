namespace OptimizelyCommerceLearning.Features.Catalogue
{
    using EPiServer.Commerce.Catalog.ContentTypes;
    using EPiServer.Commerce.Catalog.DataAnnotations;

    [CatalogContentType(
        DisplayName = "Test Product",
        Description = "A Test Product for this demo",
        GUID = "4563143F-68BB-4DE1-83F8-01215420D283",
        MetaClassName = "test_product")]
    public class TestProduct : ProductContent
    {
        public virtual XhtmlString? Description { get; set; }
    }
}
