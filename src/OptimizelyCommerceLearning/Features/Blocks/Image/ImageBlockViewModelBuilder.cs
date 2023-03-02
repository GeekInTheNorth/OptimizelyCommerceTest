namespace OptimizelyCommerceLearning.Features.Blocks.Image;

using EPiServer;

using OptimizelyCommerceLearning.Features.Media;

public sealed class ImageBlockViewModelBuilder : IImageBlockViewModelBuilder
{
    private readonly IContentLoader _contentLoader;

    private ImageBlock? _block;

    public ImageBlockViewModelBuilder(IContentLoader contentLoader)
    {
        _contentLoader = contentLoader;
    }

    public IImageBlockViewModelBuilder WithBlock(ImageBlock? block)
    {
        _block = block;

        return this;
    }

    public ImageBlockViewModel? Build()
    {
        if (!_contentLoader.TryGet<IImageContent>(_block?.ImageReference, out var imageData))
        {
            return default;
        }

        return new ImageBlockViewModel
        {
            ImageReference = imageData.ContentLink,
            AltText = imageData.AltText ?? string.Empty,
            Caption = _block?.Caption ?? string.Empty,
            IsVectorImage = imageData is VectorImageContent
        };
    }
}