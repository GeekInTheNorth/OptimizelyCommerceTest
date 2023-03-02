namespace OptimizelyCommerceLearning.Features.Blocks.Image;

using EPiServer.Web.Mvc;

using Microsoft.AspNetCore.Mvc;

public sealed class ImageBlockViewComponent : BlockComponent<ImageBlock>
{
    private readonly IImageBlockViewModelBuilder _viewModelBuilder;

    public ImageBlockViewComponent(IImageBlockViewModelBuilder viewModelBuilder)
    {
        _viewModelBuilder = viewModelBuilder;
    }

    protected override IViewComponentResult InvokeComponent(ImageBlock currentContent)
    {
        var model = _viewModelBuilder.WithBlock(currentContent).Build();

        return model != null ? View(model) : Content(string.Empty);
    }
}
