namespace OptimizelyCommerceLearning.Features.Pages;

using EPiServer.Core;
using Geta.Optimizely.Categories;

public interface ISitePageData : IContent, ICategorizableContent
{
    string? Heading { get; }

    string? ShortPageName { get; }

    string? TeaserTitle { get; }

    string? TeaserSubtitle { get; }

    string? TeaserDescription { get; }

    ContentReference? TeaserImage { get; }
}