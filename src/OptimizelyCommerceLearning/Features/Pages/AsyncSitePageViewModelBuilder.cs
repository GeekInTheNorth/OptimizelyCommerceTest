namespace OptimizelyCommerceLearning.Features.Pages;

public abstract class AsyncSitePageViewModelBuilder<TContent, TModel> : IAsyncSitePageViewModelBuilder<TContent, TModel>
    where TContent : ISitePageData
    where TModel : ISitePageViewModel<TContent>
{
    protected TModel Model;

    protected AsyncSitePageViewModelBuilder()
    {
        Model = (TModel)Activator.CreateInstance(typeof(TModel), default(TContent))!;
    }

    public IAsyncSitePageViewModelBuilder<TContent, TModel> WithContent(TContent? content)
    {
        Model = (TModel)Activator.CreateInstance(typeof(TModel), content)!;

        return this;
    }

    public abstract Task<TModel> BuildAsync();
}