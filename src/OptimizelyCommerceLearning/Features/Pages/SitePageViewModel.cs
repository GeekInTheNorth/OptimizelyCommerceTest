namespace OptimizelyCommerceLearning.Features.Pages;

using System.Diagnostics.CodeAnalysis;

public abstract class SitePageViewModel<TContent> : ISitePageViewModel<TContent>
    where TContent : ISitePageData
{
    protected SitePageViewModel(TContent? currentPage)
    {
        CurrentPage = currentPage;
    }

    [NotNull]
    public TContent? CurrentPage { get; internal set; }
}
