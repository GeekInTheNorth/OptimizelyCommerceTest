namespace OptimizelyCommerceLearning.Features.Blocks.Image;

using EPiServer.Core;

public sealed class ImageBlockViewModel
{
    public string? AltText { get; set; }

    public string? Caption { get; set; }

    public ContentReference? ImageReference { get; set; }

    public bool IsVectorImage { get; set; }
}
